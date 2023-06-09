using System.IO;
using System.Text;
using static System.Windows.Forms.ListBox;
using static MediaConverter.Data.Structure.MediaStructure;

namespace MediaConverter.Tools.Managers
{
    public static class MediaItemManager
    {
        public static void WriteMediaItem(string mediaItem, MediaItemData mediaItemData)
        {
            var sb = new StringBuilder();
            foreach (var field in typeof(MediaItemData).GetFields())
            {
                object value = field.GetValue(mediaItemData);
                if (value != null)
                    sb.Append(field.Name + "¶" + value.ToString());
                sb.Append("\n");
            }
            sb.Length--;
            File.WriteAllText("MediaConverter\\queue\\" + mediaItem + ".mediaitem", sb.ToString());
        }

        public static MediaItemData ReadMediaItem(string mediaItem)
        {
            MediaItemData mediaData = new MediaItemData();

            // load data from file
            string mediaItemFile = File.ReadAllText("MediaConverter\\queue\\" + mediaItem + ".mediaitem");
            string[] mediaItemSetting = mediaItemFile.Split('\n');

            for (int i = 0; i < mediaItemSetting.Length; i++)
            {
                string[] mediaItemSettingPair = mediaItemSetting[i].Split('¶');

                try
                {
                    switch (mediaItemSettingPair[0])
                    {
                        case "INPUT_FILE_PATH": mediaData.INPUT_FILE_PATH = mediaItemSettingPair[1]; break;
                        case "INPUT_FILE": mediaData.INPUT_FILE = mediaItemSettingPair[1]; break;
                        case "INPUT_FILE_NAME": mediaData.INPUT_FILE_NAME = mediaItemSettingPair[1]; break;

                        // OUTPUT SETTINGS
                        case "OUTPUT_FILE_PATH": mediaData.OUTPUT_FILE_PATH = mediaItemSettingPair[1]; break;
                        case "OUTPUT_FILE_NAME": mediaData.OUTPUT_FILE_NAME = mediaItemSettingPair[1]; break;
                        //

                        // CODEC SETTINGS
                        case "OUTPUT_FORMAT": mediaData.OUTPUT_FORMAT = mediaItemSettingPair[1]; break;
                        case "OUTPUT_FORMAT_TYPE": mediaData.OUTPUT_FORMAT_TYPE = mediaItemSettingPair[1]; break;
                        case "OUTPUT_FORMAT_PREPROCESSOR": mediaData.OUTPUT_FORMAT_PREPROCESSOR = mediaItemSettingPair[1]; break;
                        case "OUTPUT_FORMAT_IS_IMAGE_SEQUENCE": mediaData.OUTPUT_FORMAT_IS_IMAGE_SEQUENCE = bool.Parse(mediaItemSettingPair[1]); break;

                        case "OUTPUT_VIDEO_CODEC": mediaData.OUTPUT_VIDEO_CODEC = mediaItemSettingPair[1]; break;
                        case "OUTPUT_AUDIO_CODEC": mediaData.OUTPUT_AUDIO_CODEC = mediaItemSettingPair[1]; break;

                        case "OUTPUT_VIDEO_BITRATE": mediaData.OUTPUT_VIDEO_BITRATE = mediaItemSettingPair[1]; break;
                        case "OUTPUT_AUDIO_BITRATE": mediaData.OUTPUT_AUDIO_BITRATE = mediaItemSettingPair[1]; break;
                        //

                        // EDIT SETTINGS
                        case "OUTPUT_USE_RESIZE_VIDEO": mediaData.OUTPUT_USE_RESIZE_VIDEO = bool.Parse(mediaItemSettingPair[1]); break;
                        case "OUTPUT_VIDEO_WIDTH": mediaData.OUTPUT_VIDEO_WIDTH = mediaItemSettingPair[1]; break;
                        case "OUTPUT_VIDEO_HEIGHT": mediaData.OUTPUT_VIDEO_HEIGHT = mediaItemSettingPair[1]; break;

                        case "OUTPUT_USE_CHANGE_FRAMERATE": mediaData.OUTPUT_USE_CHANGE_FRAMERATE = bool.Parse(mediaItemSettingPair[1]); break;
                        case "OUTPUT_VIDEO_FRAMERATE": mediaData.OUTPUT_VIDEO_FRAMERATE = mediaItemSettingPair[1]; break;

                        case "OUTPUT_USE_TIMEFRAME": mediaData.OUTPUT_USE_TIMEFRAME = bool.Parse(mediaItemSettingPair[1]); break;
                        case "OUTPUT_TIMEFRAME_START": mediaData.OUTPUT_TIMEFRAME_START = mediaItemSettingPair[1]; break;
                        case "OUTPUT_TIMEFRAME_END": mediaData.OUTPUT_TIMEFRAME_END = mediaItemSettingPair[1]; break;
                        //
                    }
                } catch { }
            }

            return mediaData;
        }

        public static string[] SelectedItemsToArray(SelectedObjectCollection mediaItemCollection)
        {
            string[] mediaItems = new string[mediaItemCollection.Count];
            for (int i = 0; i < mediaItemCollection.Count; i++)
                mediaItems[i] = mediaItemCollection[i].ToString();

            return mediaItems;
        }
    }
}