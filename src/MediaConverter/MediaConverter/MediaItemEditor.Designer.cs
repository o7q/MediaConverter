namespace MediaConverter
{
    partial class MediaItemEditor
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(MediaItemEditor));
            this.OutputFormatComboBox = new System.Windows.Forms.ComboBox();
            this.OutputVideoBitrateTextBox = new System.Windows.Forms.TextBox();
            this.SaveButton = new System.Windows.Forms.Button();
            this.OutputTimeframeStartTextBox = new System.Windows.Forms.TextBox();
            this.OutputTimeframeEndTextBox = new System.Windows.Forms.TextBox();
            this.OutputUseTimeframeCheckBox = new System.Windows.Forms.CheckBox();
            this.OutputFileNameTextBox = new System.Windows.Forms.TextBox();
            this.OutputFilePathTextBox = new System.Windows.Forms.TextBox();
            this.TitlebarPanel = new System.Windows.Forms.Panel();
            this.IconPictureBox = new System.Windows.Forms.PictureBox();
            this.CloseButton = new System.Windows.Forms.Button();
            this.CodecSettingsPanel = new System.Windows.Forms.Panel();
            this.OutputIsImageSequenceCheckBox = new System.Windows.Forms.CheckBox();
            this.AudioBitrateLabel = new System.Windows.Forms.Label();
            this.VideoBitrateLabel = new System.Windows.Forms.Label();
            this.AudioCodecLabel = new System.Windows.Forms.Label();
            this.VideoCodecLabel = new System.Windows.Forms.Label();
            this.OutputAudioCodecComboBox = new System.Windows.Forms.ComboBox();
            this.OutputVideoCodecComboBox = new System.Windows.Forms.ComboBox();
            this.FormatLabel = new System.Windows.Forms.Label();
            this.PresetsLabel = new System.Windows.Forms.Label();
            this.OutputFormatPresetComboBox = new System.Windows.Forms.ComboBox();
            this.OutputAudioBitrateTextBox = new System.Windows.Forms.TextBox();
            this.CodecSettingsLabel = new System.Windows.Forms.Label();
            this.EditSettingsLabel = new System.Windows.Forms.Label();
            this.EditSettingsPanel = new System.Windows.Forms.Panel();
            this.OutputFramerateTextBox = new System.Windows.Forms.TextBox();
            this.OutputUseChangeFramerateCheckbox = new System.Windows.Forms.CheckBox();
            this.ResizeVideoXLabel = new System.Windows.Forms.Label();
            this.OutputVideoWidthTextBox = new System.Windows.Forms.TextBox();
            this.OutputVideoHeightTextBox = new System.Windows.Forms.TextBox();
            this.OutputUseResizeVideoCheckbox = new System.Windows.Forms.CheckBox();
            this.TimeframeAndLabel = new System.Windows.Forms.Label();
            this.OutputSettingsPanel = new System.Windows.Forms.Panel();
            this.OutputLocationLabel = new System.Windows.Forms.Label();
            this.OutputNameLabel = new System.Windows.Forms.Label();
            this.OutputFilePathButton = new System.Windows.Forms.Button();
            this.OutputSettingsLabel = new System.Windows.Forms.Label();
            this.PreviewButton = new System.Windows.Forms.Button();
            this.Color1Panel = new System.Windows.Forms.Panel();
            this.Color2Panel = new System.Windows.Forms.Panel();
            this.Color3Panel = new System.Windows.Forms.Panel();
            this.MediaItemEditorToolTip = new System.Windows.Forms.ToolTip(this.components);
            this.TitlebarPanel.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.IconPictureBox)).BeginInit();
            this.CodecSettingsPanel.SuspendLayout();
            this.EditSettingsPanel.SuspendLayout();
            this.OutputSettingsPanel.SuspendLayout();
            this.Color1Panel.SuspendLayout();
            this.Color2Panel.SuspendLayout();
            this.Color3Panel.SuspendLayout();
            this.SuspendLayout();
            // 
            // OutputFormatComboBox
            // 
            this.OutputFormatComboBox.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(30)))), ((int)(((byte)(30)))), ((int)(((byte)(30)))));
            this.OutputFormatComboBox.DrawMode = System.Windows.Forms.DrawMode.OwnerDrawFixed;
            this.OutputFormatComboBox.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.OutputFormatComboBox.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(225)))), ((int)(((byte)(225)))), ((int)(((byte)(225)))));
            this.OutputFormatComboBox.FormattingEnabled = true;
            this.OutputFormatComboBox.Items.AddRange(new object[] {
            "[Video]",
            "mp4",
            "mkv",
            "mov",
            "webm",
            "avi",
            "m4v",
            "wmv",
            "flv",
            "",
            "[Audio]",
            "mp3",
            "wav",
            "ogg",
            "flac",
            "m4a",
            "aac",
            "opus",
            "wma",
            "",
            "[Image]",
            "png",
            "jpg",
            "bmp",
            "tif",
            "gif",
            "ico"});
            this.OutputFormatComboBox.Location = new System.Drawing.Point(8, 58);
            this.OutputFormatComboBox.Name = "OutputFormatComboBox";
            this.OutputFormatComboBox.Size = new System.Drawing.Size(121, 21);
            this.OutputFormatComboBox.TabIndex = 1;
            this.OutputFormatComboBox.DrawItem += new System.Windows.Forms.DrawItemEventHandler(this.OutputFormatComboBox_DrawItem);
            this.OutputFormatComboBox.SelectedIndexChanged += new System.EventHandler(this.OutputFormatComboBox_SelectedIndexChanged);
            // 
            // OutputVideoBitrateTextBox
            // 
            this.OutputVideoBitrateTextBox.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(30)))), ((int)(((byte)(30)))), ((int)(((byte)(30)))));
            this.OutputVideoBitrateTextBox.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.OutputVideoBitrateTextBox.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(225)))), ((int)(((byte)(225)))), ((int)(((byte)(225)))));
            this.OutputVideoBitrateTextBox.Location = new System.Drawing.Point(45, 120);
            this.OutputVideoBitrateTextBox.Name = "OutputVideoBitrateTextBox";
            this.OutputVideoBitrateTextBox.Size = new System.Drawing.Size(84, 20);
            this.OutputVideoBitrateTextBox.TabIndex = 5;
            this.OutputVideoBitrateTextBox.Text = "100M";
            // 
            // SaveButton
            // 
            this.SaveButton.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(30)))), ((int)(((byte)(30)))), ((int)(((byte)(30)))));
            this.SaveButton.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.SaveButton.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.SaveButton.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(29)))), ((int)(((byte)(128)))), ((int)(((byte)(245)))));
            this.SaveButton.Location = new System.Drawing.Point(146, 290);
            this.SaveButton.Name = "SaveButton";
            this.SaveButton.Size = new System.Drawing.Size(62, 32);
            this.SaveButton.TabIndex = 0;
            this.SaveButton.Text = "Apply";
            this.SaveButton.UseVisualStyleBackColor = false;
            this.SaveButton.Click += new System.EventHandler(this.SaveButton_Click);
            // 
            // OutputTimeframeStartTextBox
            // 
            this.OutputTimeframeStartTextBox.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(30)))), ((int)(((byte)(30)))), ((int)(((byte)(30)))));
            this.OutputTimeframeStartTextBox.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.OutputTimeframeStartTextBox.Enabled = false;
            this.OutputTimeframeStartTextBox.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(225)))), ((int)(((byte)(225)))), ((int)(((byte)(225)))));
            this.OutputTimeframeStartTextBox.Location = new System.Drawing.Point(7, 104);
            this.OutputTimeframeStartTextBox.Name = "OutputTimeframeStartTextBox";
            this.OutputTimeframeStartTextBox.Size = new System.Drawing.Size(48, 20);
            this.OutputTimeframeStartTextBox.TabIndex = 7;
            this.OutputTimeframeStartTextBox.Text = "0:00";
            // 
            // OutputTimeframeEndTextBox
            // 
            this.OutputTimeframeEndTextBox.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(30)))), ((int)(((byte)(30)))), ((int)(((byte)(30)))));
            this.OutputTimeframeEndTextBox.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.OutputTimeframeEndTextBox.Enabled = false;
            this.OutputTimeframeEndTextBox.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(225)))), ((int)(((byte)(225)))), ((int)(((byte)(225)))));
            this.OutputTimeframeEndTextBox.Location = new System.Drawing.Point(81, 105);
            this.OutputTimeframeEndTextBox.Name = "OutputTimeframeEndTextBox";
            this.OutputTimeframeEndTextBox.Size = new System.Drawing.Size(48, 20);
            this.OutputTimeframeEndTextBox.TabIndex = 8;
            this.OutputTimeframeEndTextBox.Text = "0:10";
            // 
            // OutputUseTimeframeCheckBox
            // 
            this.OutputUseTimeframeCheckBox.AutoSize = true;
            this.OutputUseTimeframeCheckBox.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(225)))), ((int)(((byte)(225)))), ((int)(((byte)(225)))));
            this.OutputUseTimeframeCheckBox.Location = new System.Drawing.Point(7, 89);
            this.OutputUseTimeframeCheckBox.Name = "OutputUseTimeframeCheckBox";
            this.OutputUseTimeframeCheckBox.Size = new System.Drawing.Size(127, 17);
            this.OutputUseTimeframeCheckBox.TabIndex = 6;
            this.OutputUseTimeframeCheckBox.Text = "Trim Length Between";
            this.OutputUseTimeframeCheckBox.UseVisualStyleBackColor = true;
            this.OutputUseTimeframeCheckBox.CheckedChanged += new System.EventHandler(this.OutputUseTimeframeCheckBox_CheckedChanged);
            // 
            // OutputFileNameTextBox
            // 
            this.OutputFileNameTextBox.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(30)))), ((int)(((byte)(30)))), ((int)(((byte)(30)))));
            this.OutputFileNameTextBox.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.OutputFileNameTextBox.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(225)))), ((int)(((byte)(225)))), ((int)(((byte)(225)))));
            this.OutputFileNameTextBox.Location = new System.Drawing.Point(7, 16);
            this.OutputFileNameTextBox.Name = "OutputFileNameTextBox";
            this.OutputFileNameTextBox.Size = new System.Drawing.Size(106, 20);
            this.OutputFileNameTextBox.TabIndex = 0;
            // 
            // OutputFilePathTextBox
            // 
            this.OutputFilePathTextBox.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(30)))), ((int)(((byte)(30)))), ((int)(((byte)(30)))));
            this.OutputFilePathTextBox.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.OutputFilePathTextBox.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(225)))), ((int)(((byte)(225)))), ((int)(((byte)(225)))));
            this.OutputFilePathTextBox.Location = new System.Drawing.Point(27, 51);
            this.OutputFilePathTextBox.Name = "OutputFilePathTextBox";
            this.OutputFilePathTextBox.Size = new System.Drawing.Size(86, 20);
            this.OutputFilePathTextBox.TabIndex = 2;
            // 
            // TitlebarPanel
            // 
            this.TitlebarPanel.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(30)))), ((int)(((byte)(30)))), ((int)(((byte)(30)))));
            this.TitlebarPanel.Controls.Add(this.IconPictureBox);
            this.TitlebarPanel.Controls.Add(this.CloseButton);
            this.TitlebarPanel.Location = new System.Drawing.Point(-4, -4);
            this.TitlebarPanel.Name = "TitlebarPanel";
            this.TitlebarPanel.Size = new System.Drawing.Size(285, 27);
            this.TitlebarPanel.TabIndex = 0;
            this.TitlebarPanel.MouseDown += new System.Windows.Forms.MouseEventHandler(this.TitlebarPanel_MouseDown);
            // 
            // IconPictureBox
            // 
            this.IconPictureBox.Image = global::MediaConverter.Properties.Resources.logo_256x;
            this.IconPictureBox.Location = new System.Drawing.Point(6, 5);
            this.IconPictureBox.Name = "IconPictureBox";
            this.IconPictureBox.Size = new System.Drawing.Size(20, 20);
            this.IconPictureBox.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.IconPictureBox.TabIndex = 0;
            this.IconPictureBox.TabStop = false;
            // 
            // CloseButton
            // 
            this.CloseButton.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.CloseButton.Font = new System.Drawing.Font("Microsoft Sans Serif", 6F, System.Drawing.FontStyle.Bold);
            this.CloseButton.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(100)))), ((int)(((byte)(100)))), ((int)(((byte)(100)))));
            this.CloseButton.Location = new System.Drawing.Point(255, 4);
            this.CloseButton.Name = "CloseButton";
            this.CloseButton.Size = new System.Drawing.Size(25, 23);
            this.CloseButton.TabIndex = 0;
            this.CloseButton.Text = "X";
            this.CloseButton.UseVisualStyleBackColor = true;
            this.CloseButton.Click += new System.EventHandler(this.CloseButton_Click);
            // 
            // CodecSettingsPanel
            // 
            this.CodecSettingsPanel.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(20)))), ((int)(((byte)(20)))), ((int)(((byte)(20)))));
            this.CodecSettingsPanel.Controls.Add(this.OutputIsImageSequenceCheckBox);
            this.CodecSettingsPanel.Controls.Add(this.AudioBitrateLabel);
            this.CodecSettingsPanel.Controls.Add(this.VideoBitrateLabel);
            this.CodecSettingsPanel.Controls.Add(this.AudioCodecLabel);
            this.CodecSettingsPanel.Controls.Add(this.VideoCodecLabel);
            this.CodecSettingsPanel.Controls.Add(this.OutputAudioCodecComboBox);
            this.CodecSettingsPanel.Controls.Add(this.OutputVideoCodecComboBox);
            this.CodecSettingsPanel.Controls.Add(this.FormatLabel);
            this.CodecSettingsPanel.Controls.Add(this.PresetsLabel);
            this.CodecSettingsPanel.Controls.Add(this.OutputFormatPresetComboBox);
            this.CodecSettingsPanel.Controls.Add(this.OutputFormatComboBox);
            this.CodecSettingsPanel.Controls.Add(this.OutputAudioBitrateTextBox);
            this.CodecSettingsPanel.Controls.Add(this.OutputVideoBitrateTextBox);
            this.CodecSettingsPanel.Location = new System.Drawing.Point(1, 1);
            this.CodecSettingsPanel.Name = "CodecSettingsPanel";
            this.CodecSettingsPanel.Size = new System.Drawing.Size(262, 147);
            this.CodecSettingsPanel.TabIndex = 0;
            // 
            // OutputIsImageSequenceCheckBox
            // 
            this.OutputIsImageSequenceCheckBox.AutoSize = true;
            this.OutputIsImageSequenceCheckBox.Enabled = false;
            this.OutputIsImageSequenceCheckBox.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(225)))), ((int)(((byte)(225)))), ((int)(((byte)(225)))));
            this.OutputIsImageSequenceCheckBox.Location = new System.Drawing.Point(133, 61);
            this.OutputIsImageSequenceCheckBox.Name = "OutputIsImageSequenceCheckBox";
            this.OutputIsImageSequenceCheckBox.Size = new System.Drawing.Size(107, 17);
            this.OutputIsImageSequenceCheckBox.TabIndex = 2;
            this.OutputIsImageSequenceCheckBox.Text = "Image Sequence";
            this.OutputIsImageSequenceCheckBox.UseVisualStyleBackColor = true;
            this.OutputIsImageSequenceCheckBox.CheckedChanged += new System.EventHandler(this.OutputIsImageSequenceCheckBox_CheckedChanged);
            // 
            // AudioBitrateLabel
            // 
            this.AudioBitrateLabel.AutoSize = true;
            this.AudioBitrateLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.AudioBitrateLabel.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(225)))), ((int)(((byte)(225)))), ((int)(((byte)(225)))));
            this.AudioBitrateLabel.Location = new System.Drawing.Point(129, 123);
            this.AudioBitrateLabel.Name = "AudioBitrateLabel";
            this.AudioBitrateLabel.Size = new System.Drawing.Size(40, 13);
            this.AudioBitrateLabel.TabIndex = 0;
            this.AudioBitrateLabel.Text = "Bitrate:";
            // 
            // VideoBitrateLabel
            // 
            this.VideoBitrateLabel.AutoSize = true;
            this.VideoBitrateLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.VideoBitrateLabel.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(225)))), ((int)(((byte)(225)))), ((int)(((byte)(225)))));
            this.VideoBitrateLabel.Location = new System.Drawing.Point(4, 123);
            this.VideoBitrateLabel.Name = "VideoBitrateLabel";
            this.VideoBitrateLabel.Size = new System.Drawing.Size(40, 13);
            this.VideoBitrateLabel.TabIndex = 0;
            this.VideoBitrateLabel.Text = "Bitrate:";
            // 
            // AudioCodecLabel
            // 
            this.AudioCodecLabel.AutoSize = true;
            this.AudioCodecLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.AudioCodecLabel.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(225)))), ((int)(((byte)(225)))), ((int)(((byte)(225)))));
            this.AudioCodecLabel.Location = new System.Drawing.Point(130, 81);
            this.AudioCodecLabel.Name = "AudioCodecLabel";
            this.AudioCodecLabel.Size = new System.Drawing.Size(85, 16);
            this.AudioCodecLabel.TabIndex = 0;
            this.AudioCodecLabel.Text = "Audio Codec";
            // 
            // VideoCodecLabel
            // 
            this.VideoCodecLabel.AutoSize = true;
            this.VideoCodecLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.VideoCodecLabel.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(225)))), ((int)(((byte)(225)))), ((int)(((byte)(225)))));
            this.VideoCodecLabel.Location = new System.Drawing.Point(5, 81);
            this.VideoCodecLabel.Name = "VideoCodecLabel";
            this.VideoCodecLabel.Size = new System.Drawing.Size(86, 16);
            this.VideoCodecLabel.TabIndex = 0;
            this.VideoCodecLabel.Text = "Video Codec";
            // 
            // OutputAudioCodecComboBox
            // 
            this.OutputAudioCodecComboBox.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(30)))), ((int)(((byte)(30)))), ((int)(((byte)(30)))));
            this.OutputAudioCodecComboBox.DrawMode = System.Windows.Forms.DrawMode.OwnerDrawFixed;
            this.OutputAudioCodecComboBox.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.OutputAudioCodecComboBox.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(225)))), ((int)(((byte)(225)))), ((int)(((byte)(225)))));
            this.OutputAudioCodecComboBox.FormattingEnabled = true;
            this.OutputAudioCodecComboBox.Items.AddRange(new object[] {
            "aac",
            "alac",
            "flac",
            "libmp3lame",
            "pcm_s16le",
            "libopus",
            "libvorbis",
            "wmav2",
            "",
            "copy",
            "(exclude)"});
            this.OutputAudioCodecComboBox.Location = new System.Drawing.Point(133, 97);
            this.OutputAudioCodecComboBox.Name = "OutputAudioCodecComboBox";
            this.OutputAudioCodecComboBox.Size = new System.Drawing.Size(121, 21);
            this.OutputAudioCodecComboBox.TabIndex = 4;
            this.OutputAudioCodecComboBox.DrawItem += new System.Windows.Forms.DrawItemEventHandler(this.OutputAudioCodecComboBox_DrawItem);
            // 
            // OutputVideoCodecComboBox
            // 
            this.OutputVideoCodecComboBox.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(30)))), ((int)(((byte)(30)))), ((int)(((byte)(30)))));
            this.OutputVideoCodecComboBox.DrawMode = System.Windows.Forms.DrawMode.OwnerDrawFixed;
            this.OutputVideoCodecComboBox.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.OutputVideoCodecComboBox.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(225)))), ((int)(((byte)(225)))), ((int)(((byte)(225)))));
            this.OutputVideoCodecComboBox.FormattingEnabled = true;
            this.OutputVideoCodecComboBox.Items.AddRange(new object[] {
            "libx264",
            "libx265",
            "h264_nvenc",
            "h264_amf",
            "mpeg4",
            "libvpx-vp9",
            "rawvideo",
            "",
            "copy",
            "(exclude)"});
            this.OutputVideoCodecComboBox.Location = new System.Drawing.Point(8, 97);
            this.OutputVideoCodecComboBox.Name = "OutputVideoCodecComboBox";
            this.OutputVideoCodecComboBox.Size = new System.Drawing.Size(121, 21);
            this.OutputVideoCodecComboBox.TabIndex = 3;
            this.OutputVideoCodecComboBox.DrawItem += new System.Windows.Forms.DrawItemEventHandler(this.OutputVideoCodecComboBox_DrawItem);
            // 
            // FormatLabel
            // 
            this.FormatLabel.AutoSize = true;
            this.FormatLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.FormatLabel.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(225)))), ((int)(((byte)(225)))), ((int)(((byte)(225)))));
            this.FormatLabel.Location = new System.Drawing.Point(4, 42);
            this.FormatLabel.Name = "FormatLabel";
            this.FormatLabel.Size = new System.Drawing.Size(49, 16);
            this.FormatLabel.TabIndex = 0;
            this.FormatLabel.Text = "Format";
            // 
            // PresetsLabel
            // 
            this.PresetsLabel.AutoSize = true;
            this.PresetsLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.PresetsLabel.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(225)))), ((int)(((byte)(225)))), ((int)(((byte)(225)))));
            this.PresetsLabel.Location = new System.Drawing.Point(4, 4);
            this.PresetsLabel.Name = "PresetsLabel";
            this.PresetsLabel.Size = new System.Drawing.Size(53, 16);
            this.PresetsLabel.TabIndex = 0;
            this.PresetsLabel.Text = "Presets";
            // 
            // OutputFormatPresetComboBox
            // 
            this.OutputFormatPresetComboBox.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(30)))), ((int)(((byte)(30)))), ((int)(((byte)(30)))));
            this.OutputFormatPresetComboBox.DrawMode = System.Windows.Forms.DrawMode.OwnerDrawFixed;
            this.OutputFormatPresetComboBox.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.OutputFormatPresetComboBox.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(225)))), ((int)(((byte)(225)))), ((int)(((byte)(225)))));
            this.OutputFormatPresetComboBox.FormattingEnabled = true;
            this.OutputFormatPresetComboBox.Items.AddRange(new object[] {
            "[Video]",
            "mp4  |  Web (AVC)",
            "mp4  |  Web (HEVC)",
            "mp4  |  Web (AVC.nvidia)",
            "mp4  |  Web (AVC.amd)",
            "webm  |  Web (VP9)",
            "avi  |  Quality (uncompressed)",
            "",
            "[Audio]",
            "mp3  |  Lossy",
            "wav  |  Lossless",
            "ogg  |  Lossy",
            "flac  |  Lossless",
            "m4a  |  Lossy",
            "m4a  |  Lossless",
            "aac  |  Lossy",
            "opus  |  Lossy",
            "wma  |  Lossy"});
            this.OutputFormatPresetComboBox.Location = new System.Drawing.Point(8, 20);
            this.OutputFormatPresetComboBox.Name = "OutputFormatPresetComboBox";
            this.OutputFormatPresetComboBox.Size = new System.Drawing.Size(246, 21);
            this.OutputFormatPresetComboBox.TabIndex = 0;
            this.OutputFormatPresetComboBox.DrawItem += new System.Windows.Forms.DrawItemEventHandler(this.OutputFormatPresetComboBox_DrawItem);
            this.OutputFormatPresetComboBox.SelectedIndexChanged += new System.EventHandler(this.OutputFormatPresetComboBox_SelectedIndexChanged);
            // 
            // OutputAudioBitrateTextBox
            // 
            this.OutputAudioBitrateTextBox.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(30)))), ((int)(((byte)(30)))), ((int)(((byte)(30)))));
            this.OutputAudioBitrateTextBox.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.OutputAudioBitrateTextBox.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(225)))), ((int)(((byte)(225)))), ((int)(((byte)(225)))));
            this.OutputAudioBitrateTextBox.Location = new System.Drawing.Point(170, 120);
            this.OutputAudioBitrateTextBox.Name = "OutputAudioBitrateTextBox";
            this.OutputAudioBitrateTextBox.Size = new System.Drawing.Size(84, 20);
            this.OutputAudioBitrateTextBox.TabIndex = 6;
            this.OutputAudioBitrateTextBox.Text = "320K";
            // 
            // CodecSettingsLabel
            // 
            this.CodecSettingsLabel.AutoSize = true;
            this.CodecSettingsLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.CodecSettingsLabel.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(225)))), ((int)(((byte)(225)))), ((int)(((byte)(225)))));
            this.CodecSettingsLabel.Location = new System.Drawing.Point(2, 25);
            this.CodecSettingsLabel.Name = "CodecSettingsLabel";
            this.CodecSettingsLabel.Size = new System.Drawing.Size(112, 18);
            this.CodecSettingsLabel.TabIndex = 0;
            this.CodecSettingsLabel.Text = "Format Options";
            // 
            // EditSettingsLabel
            // 
            this.EditSettingsLabel.AutoSize = true;
            this.EditSettingsLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.EditSettingsLabel.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(225)))), ((int)(((byte)(225)))), ((int)(((byte)(225)))));
            this.EditSettingsLabel.Location = new System.Drawing.Point(2, 192);
            this.EditSettingsLabel.Name = "EditSettingsLabel";
            this.EditSettingsLabel.Size = new System.Drawing.Size(89, 18);
            this.EditSettingsLabel.TabIndex = 0;
            this.EditSettingsLabel.Text = "Edit Options";
            // 
            // EditSettingsPanel
            // 
            this.EditSettingsPanel.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(20)))), ((int)(((byte)(20)))), ((int)(((byte)(20)))));
            this.EditSettingsPanel.Controls.Add(this.OutputFramerateTextBox);
            this.EditSettingsPanel.Controls.Add(this.OutputUseChangeFramerateCheckbox);
            this.EditSettingsPanel.Controls.Add(this.ResizeVideoXLabel);
            this.EditSettingsPanel.Controls.Add(this.OutputVideoWidthTextBox);
            this.EditSettingsPanel.Controls.Add(this.OutputVideoHeightTextBox);
            this.EditSettingsPanel.Controls.Add(this.OutputUseResizeVideoCheckbox);
            this.EditSettingsPanel.Controls.Add(this.TimeframeAndLabel);
            this.EditSettingsPanel.Controls.Add(this.OutputTimeframeStartTextBox);
            this.EditSettingsPanel.Controls.Add(this.OutputTimeframeEndTextBox);
            this.EditSettingsPanel.Controls.Add(this.OutputUseTimeframeCheckBox);
            this.EditSettingsPanel.Location = new System.Drawing.Point(1, 1);
            this.EditSettingsPanel.Name = "EditSettingsPanel";
            this.EditSettingsPanel.Size = new System.Drawing.Size(136, 130);
            this.EditSettingsPanel.TabIndex = 0;
            // 
            // OutputFramerateTextBox
            // 
            this.OutputFramerateTextBox.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(30)))), ((int)(((byte)(30)))), ((int)(((byte)(30)))));
            this.OutputFramerateTextBox.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.OutputFramerateTextBox.Enabled = false;
            this.OutputFramerateTextBox.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(225)))), ((int)(((byte)(225)))), ((int)(((byte)(225)))));
            this.OutputFramerateTextBox.Location = new System.Drawing.Point(7, 63);
            this.OutputFramerateTextBox.Name = "OutputFramerateTextBox";
            this.OutputFramerateTextBox.Size = new System.Drawing.Size(48, 20);
            this.OutputFramerateTextBox.TabIndex = 5;
            this.OutputFramerateTextBox.Text = "60";
            // 
            // OutputUseChangeFramerateCheckbox
            // 
            this.OutputUseChangeFramerateCheckbox.AutoSize = true;
            this.OutputUseChangeFramerateCheckbox.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(225)))), ((int)(((byte)(225)))), ((int)(((byte)(225)))));
            this.OutputUseChangeFramerateCheckbox.Location = new System.Drawing.Point(7, 48);
            this.OutputUseChangeFramerateCheckbox.Name = "OutputUseChangeFramerateCheckbox";
            this.OutputUseChangeFramerateCheckbox.Size = new System.Drawing.Size(113, 17);
            this.OutputUseChangeFramerateCheckbox.TabIndex = 4;
            this.OutputUseChangeFramerateCheckbox.Text = "Change Framerate";
            this.OutputUseChangeFramerateCheckbox.UseVisualStyleBackColor = true;
            this.OutputUseChangeFramerateCheckbox.CheckedChanged += new System.EventHandler(this.OutputUseChangeFramerateCheckbox_CheckedChanged);
            // 
            // ResizeVideoXLabel
            // 
            this.ResizeVideoXLabel.AutoSize = true;
            this.ResizeVideoXLabel.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(225)))), ((int)(((byte)(225)))), ((int)(((byte)(225)))));
            this.ResizeVideoXLabel.Location = new System.Drawing.Point(62, 23);
            this.ResizeVideoXLabel.Name = "ResizeVideoXLabel";
            this.ResizeVideoXLabel.Size = new System.Drawing.Size(12, 13);
            this.ResizeVideoXLabel.TabIndex = 0;
            this.ResizeVideoXLabel.Text = "x";
            // 
            // OutputVideoWidthTextBox
            // 
            this.OutputVideoWidthTextBox.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(30)))), ((int)(((byte)(30)))), ((int)(((byte)(30)))));
            this.OutputVideoWidthTextBox.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.OutputVideoWidthTextBox.Enabled = false;
            this.OutputVideoWidthTextBox.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(225)))), ((int)(((byte)(225)))), ((int)(((byte)(225)))));
            this.OutputVideoWidthTextBox.Location = new System.Drawing.Point(7, 21);
            this.OutputVideoWidthTextBox.Name = "OutputVideoWidthTextBox";
            this.OutputVideoWidthTextBox.Size = new System.Drawing.Size(55, 20);
            this.OutputVideoWidthTextBox.TabIndex = 2;
            this.OutputVideoWidthTextBox.Text = "1920";
            // 
            // OutputVideoHeightTextBox
            // 
            this.OutputVideoHeightTextBox.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(30)))), ((int)(((byte)(30)))), ((int)(((byte)(30)))));
            this.OutputVideoHeightTextBox.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.OutputVideoHeightTextBox.Enabled = false;
            this.OutputVideoHeightTextBox.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(225)))), ((int)(((byte)(225)))), ((int)(((byte)(225)))));
            this.OutputVideoHeightTextBox.Location = new System.Drawing.Point(74, 21);
            this.OutputVideoHeightTextBox.Name = "OutputVideoHeightTextBox";
            this.OutputVideoHeightTextBox.Size = new System.Drawing.Size(55, 20);
            this.OutputVideoHeightTextBox.TabIndex = 3;
            this.OutputVideoHeightTextBox.Text = "1080";
            // 
            // OutputUseResizeVideoCheckbox
            // 
            this.OutputUseResizeVideoCheckbox.AutoSize = true;
            this.OutputUseResizeVideoCheckbox.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(225)))), ((int)(((byte)(225)))), ((int)(((byte)(225)))));
            this.OutputUseResizeVideoCheckbox.Location = new System.Drawing.Point(7, 6);
            this.OutputUseResizeVideoCheckbox.Name = "OutputUseResizeVideoCheckbox";
            this.OutputUseResizeVideoCheckbox.Size = new System.Drawing.Size(86, 17);
            this.OutputUseResizeVideoCheckbox.TabIndex = 1;
            this.OutputUseResizeVideoCheckbox.Text = "Change Size";
            this.OutputUseResizeVideoCheckbox.UseVisualStyleBackColor = true;
            this.OutputUseResizeVideoCheckbox.CheckedChanged += new System.EventHandler(this.OutputUseResizeVideoCheckbox_CheckedChanged);
            // 
            // TimeframeAndLabel
            // 
            this.TimeframeAndLabel.AutoSize = true;
            this.TimeframeAndLabel.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(225)))), ((int)(((byte)(225)))), ((int)(((byte)(225)))));
            this.TimeframeAndLabel.Location = new System.Drawing.Point(55, 107);
            this.TimeframeAndLabel.Name = "TimeframeAndLabel";
            this.TimeframeAndLabel.Size = new System.Drawing.Size(25, 13);
            this.TimeframeAndLabel.TabIndex = 0;
            this.TimeframeAndLabel.Text = "and";
            // 
            // OutputSettingsPanel
            // 
            this.OutputSettingsPanel.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(20)))), ((int)(((byte)(20)))), ((int)(((byte)(20)))));
            this.OutputSettingsPanel.Controls.Add(this.OutputLocationLabel);
            this.OutputSettingsPanel.Controls.Add(this.OutputNameLabel);
            this.OutputSettingsPanel.Controls.Add(this.OutputFileNameTextBox);
            this.OutputSettingsPanel.Controls.Add(this.OutputFilePathButton);
            this.OutputSettingsPanel.Controls.Add(this.OutputFilePathTextBox);
            this.OutputSettingsPanel.Location = new System.Drawing.Point(1, 1);
            this.OutputSettingsPanel.Name = "OutputSettingsPanel";
            this.OutputSettingsPanel.Size = new System.Drawing.Size(122, 76);
            this.OutputSettingsPanel.TabIndex = 0;
            // 
            // OutputLocationLabel
            // 
            this.OutputLocationLabel.AutoSize = true;
            this.OutputLocationLabel.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(225)))), ((int)(((byte)(225)))), ((int)(((byte)(225)))));
            this.OutputLocationLabel.Location = new System.Drawing.Point(3, 38);
            this.OutputLocationLabel.Name = "OutputLocationLabel";
            this.OutputLocationLabel.Size = new System.Drawing.Size(83, 13);
            this.OutputLocationLabel.TabIndex = 0;
            this.OutputLocationLabel.Text = "Output Location";
            // 
            // OutputNameLabel
            // 
            this.OutputNameLabel.AutoSize = true;
            this.OutputNameLabel.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(225)))), ((int)(((byte)(225)))), ((int)(((byte)(225)))));
            this.OutputNameLabel.Location = new System.Drawing.Point(3, 2);
            this.OutputNameLabel.Name = "OutputNameLabel";
            this.OutputNameLabel.Size = new System.Drawing.Size(70, 13);
            this.OutputNameLabel.TabIndex = 0;
            this.OutputNameLabel.Text = "Output Name";
            // 
            // OutputFilePathButton
            // 
            this.OutputFilePathButton.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(30)))), ((int)(((byte)(30)))), ((int)(((byte)(30)))));
            this.OutputFilePathButton.BackgroundImage = global::MediaConverter.Properties.Resources.add_media_folder_button;
            this.OutputFilePathButton.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.OutputFilePathButton.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.OutputFilePathButton.Font = new System.Drawing.Font("Microsoft Sans Serif", 6.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.OutputFilePathButton.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(225)))), ((int)(((byte)(225)))), ((int)(((byte)(225)))));
            this.OutputFilePathButton.Location = new System.Drawing.Point(7, 51);
            this.OutputFilePathButton.Name = "OutputFilePathButton";
            this.OutputFilePathButton.Size = new System.Drawing.Size(20, 20);
            this.OutputFilePathButton.TabIndex = 1;
            this.OutputFilePathButton.UseVisualStyleBackColor = false;
            this.OutputFilePathButton.Click += new System.EventHandler(this.OutputFilePathButton_Click);
            // 
            // OutputSettingsLabel
            // 
            this.OutputSettingsLabel.AutoSize = true;
            this.OutputSettingsLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.OutputSettingsLabel.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(225)))), ((int)(((byte)(225)))), ((int)(((byte)(225)))));
            this.OutputSettingsLabel.Location = new System.Drawing.Point(142, 192);
            this.OutputSettingsLabel.Name = "OutputSettingsLabel";
            this.OutputSettingsLabel.Size = new System.Drawing.Size(108, 18);
            this.OutputSettingsLabel.TabIndex = 0;
            this.OutputSettingsLabel.Text = "Output Options";
            // 
            // PreviewButton
            // 
            this.PreviewButton.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(30)))), ((int)(((byte)(30)))), ((int)(((byte)(30)))));
            this.PreviewButton.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.PreviewButton.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.PreviewButton.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(23)))), ((int)(((byte)(102)))), ((int)(((byte)(196)))));
            this.PreviewButton.Location = new System.Drawing.Point(208, 290);
            this.PreviewButton.Name = "PreviewButton";
            this.PreviewButton.Size = new System.Drawing.Size(62, 32);
            this.PreviewButton.TabIndex = 1;
            this.PreviewButton.Text = "Preview";
            this.PreviewButton.UseVisualStyleBackColor = false;
            this.PreviewButton.Click += new System.EventHandler(this.PreviewButton_Click);
            // 
            // Color1Panel
            // 
            this.Color1Panel.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(100)))), ((int)(((byte)(100)))), ((int)(((byte)(100)))));
            this.Color1Panel.Controls.Add(this.CodecSettingsPanel);
            this.Color1Panel.Location = new System.Drawing.Point(6, 43);
            this.Color1Panel.Name = "Color1Panel";
            this.Color1Panel.Size = new System.Drawing.Size(264, 149);
            this.Color1Panel.TabIndex = 0;
            // 
            // Color2Panel
            // 
            this.Color2Panel.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(100)))), ((int)(((byte)(100)))), ((int)(((byte)(100)))));
            this.Color2Panel.Controls.Add(this.EditSettingsPanel);
            this.Color2Panel.Location = new System.Drawing.Point(6, 210);
            this.Color2Panel.Name = "Color2Panel";
            this.Color2Panel.Size = new System.Drawing.Size(138, 132);
            this.Color2Panel.TabIndex = 0;
            // 
            // Color3Panel
            // 
            this.Color3Panel.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(100)))), ((int)(((byte)(100)))), ((int)(((byte)(100)))));
            this.Color3Panel.Controls.Add(this.OutputSettingsPanel);
            this.Color3Panel.Location = new System.Drawing.Point(146, 210);
            this.Color3Panel.Name = "Color3Panel";
            this.Color3Panel.Size = new System.Drawing.Size(124, 78);
            this.Color3Panel.TabIndex = 0;
            // 
            // MediaItemEditorToolTip
            // 
            this.MediaItemEditorToolTip.Draw += new System.Windows.Forms.DrawToolTipEventHandler(this.MediaItemEditorToolTip_Draw);
            // 
            // MediaItemEditor
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(25)))), ((int)(((byte)(25)))), ((int)(((byte)(25)))));
            this.ClientSize = new System.Drawing.Size(276, 348);
            this.Controls.Add(this.Color3Panel);
            this.Controls.Add(this.Color2Panel);
            this.Controls.Add(this.Color1Panel);
            this.Controls.Add(this.PreviewButton);
            this.Controls.Add(this.OutputSettingsLabel);
            this.Controls.Add(this.EditSettingsLabel);
            this.Controls.Add(this.CodecSettingsLabel);
            this.Controls.Add(this.TitlebarPanel);
            this.Controls.Add(this.SaveButton);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "MediaItemEditor";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterParent;
            this.Text = "MediaConverter Editor";
            this.Load += new System.EventHandler(this.MediaItemEditor_Load);
            this.TitlebarPanel.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.IconPictureBox)).EndInit();
            this.CodecSettingsPanel.ResumeLayout(false);
            this.CodecSettingsPanel.PerformLayout();
            this.EditSettingsPanel.ResumeLayout(false);
            this.EditSettingsPanel.PerformLayout();
            this.OutputSettingsPanel.ResumeLayout(false);
            this.OutputSettingsPanel.PerformLayout();
            this.Color1Panel.ResumeLayout(false);
            this.Color2Panel.ResumeLayout(false);
            this.Color3Panel.ResumeLayout(false);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.ComboBox OutputFormatComboBox;
        private System.Windows.Forms.TextBox OutputVideoBitrateTextBox;
        private System.Windows.Forms.Button SaveButton;
        private System.Windows.Forms.TextBox OutputTimeframeStartTextBox;
        private System.Windows.Forms.TextBox OutputTimeframeEndTextBox;
        private System.Windows.Forms.CheckBox OutputUseTimeframeCheckBox;
        private System.Windows.Forms.TextBox OutputFileNameTextBox;
        private System.Windows.Forms.Button OutputFilePathButton;
        private System.Windows.Forms.TextBox OutputFilePathTextBox;
        private System.Windows.Forms.Panel TitlebarPanel;
        private System.Windows.Forms.Button CloseButton;
        private System.Windows.Forms.Panel CodecSettingsPanel;
        private System.Windows.Forms.ComboBox OutputFormatPresetComboBox;
        private System.Windows.Forms.Label PresetsLabel;
        private System.Windows.Forms.Label FormatLabel;
        private System.Windows.Forms.Label CodecSettingsLabel;
        private System.Windows.Forms.Label EditSettingsLabel;
        private System.Windows.Forms.Panel EditSettingsPanel;
        private System.Windows.Forms.Panel OutputSettingsPanel;
        private System.Windows.Forms.Label OutputSettingsLabel;
        private System.Windows.Forms.Label TimeframeAndLabel;
        private System.Windows.Forms.Label OutputNameLabel;
        private System.Windows.Forms.Label OutputLocationLabel;
        private System.Windows.Forms.ComboBox OutputVideoCodecComboBox;
        private System.Windows.Forms.ComboBox OutputAudioCodecComboBox;
        private System.Windows.Forms.Label AudioCodecLabel;
        private System.Windows.Forms.Label VideoCodecLabel;
        private System.Windows.Forms.Button PreviewButton;
        private System.Windows.Forms.Panel Color1Panel;
        private System.Windows.Forms.Panel Color2Panel;
        private System.Windows.Forms.Panel Color3Panel;
        private System.Windows.Forms.Label VideoBitrateLabel;
        private System.Windows.Forms.TextBox OutputAudioBitrateTextBox;
        private System.Windows.Forms.Label AudioBitrateLabel;
        private System.Windows.Forms.PictureBox IconPictureBox;
        private System.Windows.Forms.CheckBox OutputUseResizeVideoCheckbox;
        private System.Windows.Forms.Label ResizeVideoXLabel;
        private System.Windows.Forms.TextBox OutputVideoWidthTextBox;
        private System.Windows.Forms.TextBox OutputVideoHeightTextBox;
        private System.Windows.Forms.TextBox OutputFramerateTextBox;
        private System.Windows.Forms.CheckBox OutputUseChangeFramerateCheckbox;
        private System.Windows.Forms.CheckBox OutputIsImageSequenceCheckBox;
        private System.Windows.Forms.ToolTip MediaItemEditorToolTip;
    }
}