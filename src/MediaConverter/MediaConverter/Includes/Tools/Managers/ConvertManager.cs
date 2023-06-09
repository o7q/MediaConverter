using System.IO;
using System.Linq;
using System.Diagnostics;
using static MediaConverter.Data.Storage;
using static MediaConverter.Data.Structure.MediaStructure;
using static MediaConverter.Tools.Managers.MediaItemManager;

namespace MediaConverter.Tools.Managers
{
    public static class ConvertManager
    {
        public static void ConvertMediaItems(string[] mediaItems, bool isPreview)
        {
            string finalScript = baseArguments;

            int totalMediaItems = mediaItems.Count();
            int currentMediaItem = 1;

            for (int i = 0; i < mediaItems.Count(); i++)
            {
                finalScript = WeaveScript(mediaItems[i], finalScript, currentMediaItem, totalMediaItems, isPreview);
                currentMediaItem++;
            }

            if (isPreview == false)
                finalScript += "\npause";

            CleanFiles("MediaConverter\\working");

            File.WriteAllText("MediaConverter\\working\\mc_header", Properties.Resources.asciiArtBanner.Replace("__VERSION__", VERSION));
            File.WriteAllText("MediaConverter\\working\\mc.bat", finalScript);
            Process.Start("MediaConverter\\working\\mc.bat");
        }

        private static string WeaveScript(string item, string scriptBraid, int currentMediaItem, int totalMediaItems, bool isPreview)
        {
            MediaItemData mediaItem = ReadMediaItem(item.ToString());

            scriptBraid += "\ntitle MediaConverter " + VERSION + "  [" + currentMediaItem + "/" + totalMediaItems + "]  :  " + item + "\n" +
                             "echo.\n" +
                             "echo.";

            #region codecManager
            string script_codecManager = "";
            if (mediaItem.OUTPUT_VIDEO_CODEC == "(exclude)" && mediaItem.OUTPUT_AUDIO_CODEC == "(exclude)")
                script_codecManager = "-vn -an ";
            else if (mediaItem.OUTPUT_VIDEO_CODEC != "(exclude)" && mediaItem.OUTPUT_AUDIO_CODEC == "(exclude)")
                script_codecManager = "-an -c:v " + mediaItem.OUTPUT_VIDEO_CODEC + " -b:v " + mediaItem.OUTPUT_VIDEO_BITRATE + " ";
            else if (mediaItem.OUTPUT_VIDEO_CODEC == "(exclude)" && mediaItem.OUTPUT_AUDIO_CODEC != "(exclude)")
                script_codecManager = "-vn -c:a " + mediaItem.OUTPUT_AUDIO_CODEC + " -b:a " + mediaItem.OUTPUT_AUDIO_BITRATE + " ";
            else if (mediaItem.OUTPUT_VIDEO_CODEC != "(exclude)" && mediaItem.OUTPUT_AUDIO_CODEC != "(exclude)")
                script_codecManager = "-c:v " + mediaItem.OUTPUT_VIDEO_CODEC + " -c:a " + mediaItem.OUTPUT_AUDIO_CODEC + " -b:v " + mediaItem.OUTPUT_VIDEO_BITRATE + " -b:a " + mediaItem.OUTPUT_AUDIO_BITRATE + " ";
            #endregion

            #region preprocessor
            string script_preprocessor;
            bool usesPreprocessor = false;
            //
            string script_preprocessor_resize;
            string script_preprocessor_timeframe;
            string script_preprocessor_framerate;

            if (mediaItem.OUTPUT_USE_RESIZE_VIDEO == true)
            {
                script_preprocessor_resize = "-vf \"scale=" + mediaItem.OUTPUT_VIDEO_WIDTH + ":" + mediaItem.OUTPUT_VIDEO_HEIGHT + ",setsar=1\" ";
                usesPreprocessor = true;
            }
            else
                script_preprocessor_resize = "";

            if (mediaItem.OUTPUT_USE_CHANGE_FRAMERATE == true)
            {
                script_preprocessor_framerate = "-r " + mediaItem.OUTPUT_VIDEO_FRAMERATE + " ";
                usesPreprocessor = true;
            }
            else
                script_preprocessor_framerate = "";

            if (mediaItem.OUTPUT_USE_TIMEFRAME == true)
            {
                script_preprocessor_timeframe = "-ss " + mediaItem.OUTPUT_TIMEFRAME_START + " -to " + mediaItem.OUTPUT_TIMEFRAME_END + " ";
                usesPreprocessor = true;
            }
            else
                script_preprocessor_timeframe = "";

            if (usesPreprocessor == true)
                script_preprocessor = "\n\"..\\ffmpeg.exe\" -loglevel verbose -y -i \"" + mediaItem.INPUT_FILE_PATH + "\" " + script_preprocessor_resize + script_preprocessor_framerate + script_preprocessor_timeframe + script_codecManager + "\"tmp0." + mediaItem.OUTPUT_FORMAT_PREPROCESSOR + "\"\n";
            else
                script_preprocessor = "\n";
            #endregion

            #region finalizer
            string script_finalize;
            string script_finalize_directory;

            if (mediaItem.OUTPUT_FILE_PATH == "")
            {
                script_finalize = "\ncopy \"final." + mediaItem.OUTPUT_FORMAT + "\" \"..\\..\\Converts\\" + mediaItem.OUTPUT_FILE_NAME + "." + mediaItem.OUTPUT_FORMAT + "\" /y";
                script_finalize_directory = "\nrobocopy \"final\" \"..\\..\\Converts\\" + mediaItem.OUTPUT_FILE_NAME + "\" /e";
            }
            else
            {
                script_finalize = "\ncopy \"final." + mediaItem.OUTPUT_FORMAT + "\" \"" + mediaItem.OUTPUT_FILE_PATH + "\\" + mediaItem.OUTPUT_FILE_NAME + "." + mediaItem.OUTPUT_FORMAT + "\" /y";
                script_finalize_directory = "\nrobocopy \"final\" \"" + mediaItem.OUTPUT_FILE_PATH + "\\" + mediaItem.OUTPUT_FILE_NAME + "\" /e";
            }

            if (isPreview == true)
                script_finalize = "\ndel \"preview." + mediaItem.OUTPUT_FORMAT + "\"\nrename \"final." + mediaItem.OUTPUT_FORMAT + "\" \"preview." + mediaItem.OUTPUT_FORMAT + "\"";

            #endregion

            #region inputFilePath
            string media_inputFilePath;

            if (usesPreprocessor == true)
                media_inputFilePath = "tmp0." + mediaItem.OUTPUT_FORMAT_PREPROCESSOR;
            else
                media_inputFilePath = mediaItem.INPUT_FILE_PATH;
            #endregion

            switch (mediaItem.OUTPUT_FORMAT_TYPE)
            {
                case "VIDEO_OR_AUDIO_BASIC":
                     scriptBraid += script_preprocessor +
                                    "\"..\\ffmpeg.exe\" -loglevel verbose -y -i \"" + media_inputFilePath + "\" " + script_codecManager + "\"final." + mediaItem.OUTPUT_FORMAT + "\"" +
                                    script_finalize;
                     break;
                case "IMAGE_BASIC":
                    switch (mediaItem.OUTPUT_FORMAT_IS_IMAGE_SEQUENCE)
                    {
                        case true:
                            scriptBraid += script_preprocessor +
                                           "mkdir \"final\"\n" +
                                           "\"..\\ffmpeg.exe\" -loglevel verbose -y -i \"tmp0.avi\" \"final\\" + mediaItem.OUTPUT_FILE_NAME + ".%%d." + mediaItem.OUTPUT_FORMAT + "\"" +
                                           script_finalize_directory;
                            break;
                        case false:
                            scriptBraid += script_preprocessor +
                                           "\"..\\ffmpeg.exe\" -loglevel verbose -y -i \"" + media_inputFilePath + "\" \"final." + mediaItem.OUTPUT_FORMAT + "\"" +
                                           script_finalize;
                            break;
                    }
                    break;
                case "IMAGE_GIF":
                    scriptBraid += script_preprocessor +
                                   "\"..\\ffmpeg.exe\" -loglevel verbose -y -i \"" + media_inputFilePath + "\" -vf palettegen \"gif_palette.png\"\n" +
                                   "\"..\\ffmpeg.exe\" -loglevel verbose -y -i \"" + media_inputFilePath + "\" -i \"gif_palette.png\" -lavfi \"paletteuse\" \"final.gif" +
                                   script_finalize;
                    break;
                case "IMAGE_ICO":
                    scriptBraid += script_preprocessor +
                                   "\"..\\ffmpeg.exe\" -loglevel verbose -y -i \"" + media_inputFilePath + "\" -vf \"scale=256:256,setsar=1\" \"final.ico" +
                                   script_finalize;
                    break;
            }

            // add clean script
            if (isPreview == true)
                scriptBraid += "\nstart \"\" \"preview." + mediaItem.OUTPUT_FORMAT + "\"";
            else
                scriptBraid += "\nfor %%A in (*) do ( if not \"%%~nxA\"==\"mc.bat\" ( del \"%%A\" /q ) )" +
                               "\nfor /d %%A in (*) do ( if not \"%%~nxA\"==\"mc.bat\" ( rd \"%%A\" /s /q ) )";

            return scriptBraid;
        }

        private static void CleanFiles(string directory)
        {
            // delete all files
            foreach (string file in Directory.GetFiles(directory))
                File.Delete(file);

            // delete all folders
            foreach (string folder in Directory.GetDirectories(directory))
                Directory.Delete(folder, true);
        }
    }
}