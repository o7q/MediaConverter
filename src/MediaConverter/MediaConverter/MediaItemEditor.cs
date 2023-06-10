using System;
using System.IO;
using System.Drawing;
using System.Windows.Forms;
using static MediaConverter.Tools.Forms;
using static MediaConverter.Data.Structure.MediaStructure;
using static MediaConverter.Tools.Managers.ConvertManager;
using static MediaConverter.Tools.Managers.MediaItemManager;

namespace MediaConverter
{
    public partial class MediaItemEditor : Form
    {
        public MediaItemData[] mediaSettings { get; set; }
        bool isBulk = false;

        Color themeColor;

        public MediaItemEditor(MediaItemData[] mediaSettings_, Color themeColor_)
        {
            InitializeComponent();

            if (mediaSettings_.Length == 1)
            {
                mediaSettings = new MediaItemData[1];
                mediaSettings[0] = mediaSettings_[0];
            }
            else
            {
                isBulk = true;
                mediaSettings = new MediaItemData[mediaSettings_.Length];
                for (int i = 0; i < mediaSettings_.Length; i++)
                    mediaSettings[i] = mediaSettings_[i];
            }

            themeColor = themeColor_;
        }

        private void MediaItemEditor_Load(object sender, EventArgs e)
        {
            // OUTPUT SETTINGS
            OutputFilePathTextBox.Text = isBulk ? "" : mediaSettings[0].OUTPUT_FILE_PATH;
            OutputFileNameTextBox.Text = isBulk ? "%FILE_NAME%" : mediaSettings[0].OUTPUT_FILE_NAME;
            //

            // CODEC SETTINGS
            OutputFormatComboBox.Text = isBulk ? "mp4" : mediaSettings[0].OUTPUT_FORMAT;
            OutputIsImageSequenceCheckBox.Checked = isBulk ? false : mediaSettings[0].OUTPUT_FORMAT_IS_IMAGE_SEQUENCE;

            OutputVideoCodecComboBox.Text = isBulk ? "h264_nvenc" : mediaSettings[0].OUTPUT_VIDEO_CODEC;
            OutputAudioCodecComboBox.Text = isBulk ? "mp3" : mediaSettings[0].OUTPUT_AUDIO_CODEC;

            OutputVideoBitrateTextBox.Text = isBulk ? "100M" : mediaSettings[0].OUTPUT_VIDEO_BITRATE;
            OutputAudioBitrateTextBox.Text = isBulk ? "320K" : mediaSettings[0].OUTPUT_AUDIO_BITRATE;
            //

            // EDIT SETTINGS
            OutputUseResizeVideoCheckbox.Checked = isBulk ? false : mediaSettings[0].OUTPUT_USE_RESIZE_VIDEO;
            OutputVideoWidthTextBox.Text = isBulk ? "1920" : mediaSettings[0].OUTPUT_VIDEO_WIDTH;
            OutputVideoHeightTextBox.Text = isBulk ? "1080" : mediaSettings[0].OUTPUT_VIDEO_HEIGHT;

            OutputUseChangeFramerateCheckbox.Checked = isBulk ? false : mediaSettings[0].OUTPUT_USE_CHANGE_FRAMERATE;
            OutputFramerateTextBox.Text = isBulk ? "60" : mediaSettings[0].OUTPUT_VIDEO_FRAMERATE;

            OutputUseTimeframeCheckBox.Checked = isBulk ? false : mediaSettings[0].OUTPUT_USE_TIMEFRAME;
            OutputTimeframeStartTextBox.Text = isBulk ? "0:00" : mediaSettings[0].OUTPUT_TIMEFRAME_START;
            OutputTimeframeEndTextBox.Text = isBulk ? "0:10" : mediaSettings[0].OUTPUT_TIMEFRAME_END;
            //

            SaveButton.ForeColor = themeColor;
            PreviewButton.ForeColor = Color.FromArgb(255, (int)(themeColor.R / 1.25), (int)(themeColor.G / 1.25), (int)(themeColor.B / 1.25));

            #region loadTooltips
            // bind tooltips
            string[] tooltipMap = {
                "CloseButton", "Close",

                "OutputFormatPresetComboBox", "Media configuration presets",

                "OutputFormatComboBox", "File format for output",
                "OutputIsImageSequenceCheckBox", "Enable image sequence output",

                "OutputVideoCodecComboBox", "Output video codec",
                "OutputAudioCodecComboBox", "Output audio codec",

                "OutputVideoBitrateTextBox", "Output bitrate for video",
                "OutputAudioBitrateTextBox", "Output bitrate for audio",

                "OutputUseResizeVideoCheckbox", "Enable video resizing",
                "OutputVideoWidthTextBox", "Video resize width",
                "OutputVideoHeightTextBox", "Video resize height",

                "OutputUseChangeFramerateCheckbox", "Change output video framerate",
                "OutputFramerateTextBox", "Output video framerate",

                "OutputUseTimeframeCheckBox", "Trim the length of the output between two points",
                "OutputTimeframeStartTextBox", "Trim start time",
                "OutputTimeframeEndTextBox", "Trim end time",

                "OutputFileNameTextBox", "Output file name",
                "OutputFilePathButton", "Open the directory browser",
                "OutputFilePathTextBox", "Output path",

                "SaveButton", "Apply options",
                "PreviewButton", "Preview what the output will look like"
            };

            // load tooltips
            for (int i = 0; i < tooltipMap.Length; i += 2)
                MediaItemEditorToolTip.SetToolTip(Controls.Find(tooltipMap[i], true)[0], tooltipMap[i + 1]);

            // configure tooltip draw
            MediaItemEditorToolTip.AutoPopDelay = 10000;
            MediaItemEditorToolTip.InitialDelay = 500;
            MediaItemEditorToolTip.ReshowDelay = 100;
            MediaItemEditorToolTip.OwnerDraw = true;
            MediaItemEditorToolTip.BackColor = Color.FromArgb(255, 30, 30, 30);
            MediaItemEditorToolTip.ForeColor = Color.FromArgb(255, 150, 150, 150);
            #endregion
        }

        private void MediaItemEditorToolTip_Draw(object sender, DrawToolTipEventArgs e)
        {
            e.DrawBackground();
            e.DrawBorder();
            e.DrawText();
        }

        private void OutputFormatPresetComboBox_SelectedIndexChanged(object sender, EventArgs e)
        {
            switch (OutputFormatPresetComboBox.Text)
            {
                case "mp4  |  Web (AVC)":
                    OutputFormatComboBox.Text = "mp4";
                    OutputVideoCodecComboBox.Text = "libx264";
                    OutputAudioCodecComboBox.Text = "aac";
                    break;
                case "mp4  |  Web (HEVC)":
                    OutputFormatComboBox.Text = "mp4";
                    OutputVideoCodecComboBox.Text = "libx265";
                    OutputAudioCodecComboBox.Text = "aac";
                    break;
                case "mp4  |  Web (AVC.nvidia)":
                    OutputFormatComboBox.Text = "mp4";
                    OutputVideoCodecComboBox.Text = "h264_nvenc";
                    OutputAudioCodecComboBox.Text = "aac";
                    break;
                case "mp4  |  Web (AVC.amd)":
                    OutputFormatComboBox.Text = "mp4";
                    OutputVideoCodecComboBox.Text = "h264_amf";
                    OutputAudioCodecComboBox.Text = "aac";
                    break;
                case "webm  |  Web (VP9)":
                    OutputFormatComboBox.Text = "webm";
                    OutputVideoCodecComboBox.Text = "libvpx-vp9";
                    OutputAudioCodecComboBox.Text = "libopus";
                    break;
                case "avi  |  Quality (uncompressed)":
                    OutputFormatComboBox.Text = "avi";
                    OutputVideoCodecComboBox.Text = "rawvideo";
                    OutputAudioCodecComboBox.Text = "pcm_s16le";
                    break;

                case "mp3  |  Lossy":
                    OutputFormatComboBox.Text = "mp3";
                    OutputVideoCodecComboBox.Text = "(exclude)";
                    OutputAudioCodecComboBox.Text = "libmp3lame";
                    break;
                case "wav  |  Lossless":
                    OutputFormatComboBox.Text = "wav";
                    OutputVideoCodecComboBox.Text = "(exclude)";
                    OutputAudioCodecComboBox.Text = "pcm_s16le";
                    break;
                case "ogg  |  Lossy":
                    OutputFormatComboBox.Text = "ogg";
                    OutputVideoCodecComboBox.Text = "(exclude)";
                    OutputAudioCodecComboBox.Text = "libvorbis";
                    break;
                case "flac  |  Lossless":
                    OutputFormatComboBox.Text = "flac";
                    OutputVideoCodecComboBox.Text = "(exclude)";
                    OutputAudioCodecComboBox.Text = "flac";
                    break;
                case "aac  |  Lossy":
                    OutputFormatComboBox.Text = "aac";
                    OutputVideoCodecComboBox.Text = "(exclude)";
                    OutputAudioCodecComboBox.Text = "aac";
                    break;
                case "opus  |  Lossy":
                    OutputFormatComboBox.Text = "opus";
                    OutputVideoCodecComboBox.Text = "(exclude)";
                    OutputAudioCodecComboBox.Text = "libopus";
                    break;
                case "wma  |  Lossy":
                    OutputFormatComboBox.Text = "wma";
                    OutputVideoCodecComboBox.Text = "(exclude)";
                    OutputAudioCodecComboBox.Text = "wmav2";
                    break;
                case "m4a  |  Lossy":
                    OutputFormatComboBox.Text = "m4a";
                    OutputVideoCodecComboBox.Text = "(exclude)";
                    OutputAudioCodecComboBox.Text = "aac";
                    break;
                case "m4a  |  Lossless":
                    OutputFormatComboBox.Text = "m4a";
                    OutputVideoCodecComboBox.Text = "(exclude)";
                    OutputAudioCodecComboBox.Text = "alac";
                    break;
            }

            OutputFormatPresetComboBox.Text = "";
        }

        private void OutputFormatComboBox_SelectedIndexChanged(object sender, EventArgs e)
        {
            switch (OutputFormatComboBox.Text)
            {
                default:
                    OutputIsImageSequenceCheckBox.Checked = false;
                    OutputIsImageSequenceCheckBox.Enabled = false;
                    OutputVideoCodecComboBox.Enabled = true;
                    OutputAudioCodecComboBox.Enabled = true;
                    OutputVideoBitrateTextBox.Enabled = true;
                    OutputAudioBitrateTextBox.Enabled = true;
                    break;
                case "mp3":
                case "wav":
                case "ogg":
                case "flac":
                case "m4a":
                case "aac":
                case "opus":
                case "wma":
                    OutputIsImageSequenceCheckBox.Checked = false;
                    OutputIsImageSequenceCheckBox.Enabled = false;
                    OutputVideoCodecComboBox.Enabled = false;
                    OutputAudioCodecComboBox.Enabled = true;
                    OutputVideoBitrateTextBox.Enabled = false;
                    OutputAudioBitrateTextBox.Enabled = true;
                    break;
                case "png":
                case "jpg":
                    OutputIsImageSequenceCheckBox.Enabled = true;
                    OutputVideoCodecComboBox.Enabled = false;
                    OutputAudioCodecComboBox.Enabled = false;
                    OutputVideoBitrateTextBox.Enabled = false;
                    OutputAudioBitrateTextBox.Enabled = false;
                    break;
                case "gif":
                    OutputIsImageSequenceCheckBox.Checked = false;
                    OutputIsImageSequenceCheckBox.Enabled = false;
                    OutputVideoCodecComboBox.Enabled = false;
                    OutputAudioCodecComboBox.Enabled = false;
                    OutputVideoBitrateTextBox.Enabled = true;
                    OutputAudioBitrateTextBox.Enabled = false;
                    break;
                case "ico":
                    OutputIsImageSequenceCheckBox.Checked = false;
                    OutputIsImageSequenceCheckBox.Enabled = false;
                    OutputVideoCodecComboBox.Enabled = false;
                    OutputAudioCodecComboBox.Enabled = false;
                    OutputVideoBitrateTextBox.Enabled = false;
                    OutputAudioBitrateTextBox.Enabled = false;
                    break;
            }
        }

        private void OutputIsImageSequenceCheckBox_CheckedChanged(object sender, EventArgs e)
        {
            PreviewButton.Enabled = !OutputIsImageSequenceCheckBox.Checked;
        }

        private void OutputUseResizeVideoCheckbox_CheckedChanged(object sender, EventArgs e)
        {
            OutputVideoWidthTextBox.Enabled = OutputUseResizeVideoCheckbox.Checked;
            OutputVideoHeightTextBox.Enabled = OutputUseResizeVideoCheckbox.Checked;
        }

        private void OutputUseChangeFramerateCheckbox_CheckedChanged(object sender, EventArgs e)
        {
            OutputFramerateTextBox.Enabled = OutputUseChangeFramerateCheckbox.Checked;
        }

        private void OutputUseTimeframeCheckBox_CheckedChanged(object sender, EventArgs e)
        {
            OutputTimeframeStartTextBox.Enabled = OutputUseTimeframeCheckBox.Checked;
            OutputTimeframeEndTextBox.Enabled = OutputUseTimeframeCheckBox.Checked;
        }

        private void OutputFilePathButton_Click(object sender, EventArgs e)
        {
            // open a file dialog for the output file path selection
            using (OpenFileDialog selectFolderDialog = new OpenFileDialog())
            {
                selectFolderDialog.Multiselect = false;
                selectFolderDialog.CheckFileExists = false;
                selectFolderDialog.CheckPathExists = true;
                selectFolderDialog.FileName = "Select a folder";
                selectFolderDialog.Filter = "Directories|Folders";
                selectFolderDialog.ShowDialog();

                if (selectFolderDialog.FileName != "")
                {
                    string folderPath = Path.GetDirectoryName(selectFolderDialog.FileName);
                    OutputFilePathTextBox.Text = folderPath;
                }
            }
        }

        private void SaveButton_Click(object sender, EventArgs e)
        {
            // if in batch mode, loop through each selected media and apply the same settings to them
            // if not not batch mode, save changes to only the first media index
            if (isBulk == true)
            {
                for (int i = 0; i < mediaSettings.Length; i++)
                {
                    ApplySettings(i);
                    WriteMediaItem(mediaSettings[i].INPUT_FILE, mediaSettings[i]);
                }

                Close();
            }
            else
            {
                ApplySettings(0);
                WriteMediaItem(mediaSettings[0].INPUT_FILE, mediaSettings[0]);
                Close();
            }
        }

        private void PreviewButton_Click(object sender, EventArgs e)
        {
            ApplySettings(0);
            WriteMediaItem(mediaSettings[0].INPUT_FILE, mediaSettings[0]);
            string[] mediaItem = { mediaSettings[0].INPUT_FILE };
            ConvertMediaItems(mediaItem, true);
        }

        private void CloseButton_Click(object sender, EventArgs e)
        {
            Close();
        }

        private void ApplySettings(int itemIndex)
        {
            // OUTPUT SETTINGS
            mediaSettings[itemIndex].OUTPUT_FILE_PATH = OutputFilePathTextBox.Text;
            if (isBulk == true)
                mediaSettings[itemIndex].OUTPUT_FILE_NAME = OutputFileNameTextBox.Text == "%FILE_NAME%" ? mediaSettings[itemIndex].INPUT_FILE_NAME : OutputFileNameTextBox.Text + "_" + (itemIndex + 1).ToString();
            else
                mediaSettings[itemIndex].OUTPUT_FILE_NAME = OutputFileNameTextBox.Text;
            //

            // CODEC SETTINGS
            mediaSettings[itemIndex].OUTPUT_FORMAT = OutputFormatComboBox.Text;
            mediaSettings[itemIndex].OUTPUT_FORMAT_IS_IMAGE_SEQUENCE = OutputIsImageSequenceCheckBox.Checked;

            mediaSettings[itemIndex].OUTPUT_VIDEO_CODEC = OutputVideoCodecComboBox.Text;
            mediaSettings[itemIndex].OUTPUT_AUDIO_CODEC = OutputAudioCodecComboBox.Text;

            mediaSettings[itemIndex].OUTPUT_VIDEO_BITRATE = OutputVideoBitrateTextBox.Text;
            mediaSettings[itemIndex].OUTPUT_AUDIO_BITRATE = OutputAudioBitrateTextBox.Text;

            switch (OutputFormatComboBox.Text)
            {
                default:
                    mediaSettings[itemIndex].OUTPUT_FORMAT_TYPE = "VIDEO_OR_AUDIO_BASIC";
                    mediaSettings[itemIndex].OUTPUT_FORMAT_PREPROCESSOR = OutputFormatComboBox.Text;
                    break;
                case "png":
                case "jpg":
                    mediaSettings[itemIndex].OUTPUT_FORMAT_TYPE = "IMAGE_BASIC";
                    mediaSettings[itemIndex].OUTPUT_FORMAT_PREPROCESSOR = OutputFormatComboBox.Text;
                    break;
                case "gif":
                    mediaSettings[itemIndex].OUTPUT_FORMAT_TYPE = "IMAGE_GIF";
                    mediaSettings[itemIndex].OUTPUT_FORMAT_PREPROCESSOR = "mp4";
                    mediaSettings[itemIndex].OUTPUT_VIDEO_CODEC = "libx264";
                    mediaSettings[itemIndex].OUTPUT_AUDIO_CODEC = "(exclude)";
                    break;
                case "ico":
                    mediaSettings[itemIndex].OUTPUT_FORMAT_TYPE = "IMAGE_ICO";
                    mediaSettings[itemIndex].OUTPUT_FORMAT_PREPROCESSOR = "png";
                    break;
            }
            if (OutputIsImageSequenceCheckBox.Checked == true)
            {
                mediaSettings[itemIndex].OUTPUT_FORMAT_PREPROCESSOR = "mp4";
                mediaSettings[itemIndex].OUTPUT_VIDEO_CODEC = "libx264";
                mediaSettings[itemIndex].OUTPUT_AUDIO_CODEC = "(exclude)";
            }
            //

            // EDIT SETTINGS
            mediaSettings[itemIndex].OUTPUT_USE_RESIZE_VIDEO = OutputUseResizeVideoCheckbox.Checked;
            mediaSettings[itemIndex].OUTPUT_VIDEO_WIDTH = OutputVideoWidthTextBox.Text;
            mediaSettings[itemIndex].OUTPUT_VIDEO_HEIGHT = OutputVideoHeightTextBox.Text;

            mediaSettings[itemIndex].OUTPUT_USE_CHANGE_FRAMERATE = OutputUseChangeFramerateCheckbox.Checked;
            mediaSettings[itemIndex].OUTPUT_VIDEO_FRAMERATE = OutputFramerateTextBox.Text;

            mediaSettings[itemIndex].OUTPUT_USE_TIMEFRAME = OutputUseTimeframeCheckBox.Checked;
            mediaSettings[itemIndex].OUTPUT_TIMEFRAME_START = OutputTimeframeStartTextBox.Text;
            mediaSettings[itemIndex].OUTPUT_TIMEFRAME_END = OutputTimeframeEndTextBox.Text;
            //
        }

        private void OutputFormatPresetComboBox_DrawItem(object sender, DrawItemEventArgs e)
        {
            DrawComboBox(sender, e, Color.FromArgb(255, 30, 30, 30), Color.FromArgb(255, 225, 225, 225), Color.FromArgb(255, themeColor.R, themeColor.G, themeColor.B));
        }

        private void OutputFormatComboBox_DrawItem(object sender, DrawItemEventArgs e)
        {
            DrawComboBox(sender, e, Color.FromArgb(255, 30, 30, 30), Color.FromArgb(255, 225, 225, 225), Color.FromArgb(255, themeColor.R, themeColor.G, themeColor.B));
        }

        private void OutputVideoCodecComboBox_DrawItem(object sender, DrawItemEventArgs e)
        {
            DrawComboBox(sender, e, Color.FromArgb(255, 30, 30, 30), Color.FromArgb(255, 225, 225, 225), Color.FromArgb(255, themeColor.R, themeColor.G, themeColor.B));
        }

        private void OutputAudioCodecComboBox_DrawItem(object sender, DrawItemEventArgs e)
        {
            DrawComboBox(sender, e, Color.FromArgb(255, 30, 30, 30), Color.FromArgb(255, 225, 225, 225), Color.FromArgb(255, themeColor.R, themeColor.G, themeColor.B));
        }

        private void TitlebarPanel_MouseDown(object sender, MouseEventArgs e)
        {
            MoveForm(Handle, e);
        }
    }
}