namespace MediaConverter
{
    partial class Main
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Main));
            this.QueueListBox = new System.Windows.Forms.ListBox();
            this.TitlebarPanel = new System.Windows.Forms.Panel();
            this.IconPictureBox = new System.Windows.Forms.PictureBox();
            this.MinimizeButton = new System.Windows.Forms.Button();
            this.CloseButton = new System.Windows.Forms.Button();
            this.Menubar1Panel = new System.Windows.Forms.Panel();
            this.LoadingIconPictureBox = new System.Windows.Forms.PictureBox();
            this.QueueAddMediaButton = new System.Windows.Forms.Button();
            this.QueueAddMediaFolderButton = new System.Windows.Forms.Button();
            this.QueueConvertAllButton = new System.Windows.Forms.Button();
            this.QueueConvertSelectedButton = new System.Windows.Forms.Button();
            this.Menubar2Panel = new System.Windows.Forms.Panel();
            this.QueueRenameButton = new System.Windows.Forms.Button();
            this.SettingsButton = new System.Windows.Forms.Button();
            this.QueueDeselectAllButton = new System.Windows.Forms.Button();
            this.QueueSelectInvertButton = new System.Windows.Forms.Button();
            this.QueueSelectAllButton = new System.Windows.Forms.Button();
            this.QueueEditButton = new System.Windows.Forms.Button();
            this.QueueOpenMediaLocationButton = new System.Windows.Forms.Button();
            this.QueueRemoveAllButton = new System.Windows.Forms.Button();
            this.QueueRemoveSelectedButton = new System.Windows.Forms.Button();
            this.MainPanel = new System.Windows.Forms.Panel();
            this.QueueRefreshButton = new System.Windows.Forms.Button();
            this.QueueSelectionMoveDownButton = new System.Windows.Forms.Button();
            this.QueueSelectionMoveUpButton = new System.Windows.Forms.Button();
            this.Menubar3Panel = new System.Windows.Forms.Panel();
            this.VersionLabel = new System.Windows.Forms.Label();
            this.QueueSelectedLabel = new System.Windows.Forms.Label();
            this.MainToolTip = new System.Windows.Forms.ToolTip(this.components);
            this.button1 = new System.Windows.Forms.Button();
            this.TitlebarPanel.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.IconPictureBox)).BeginInit();
            this.Menubar1Panel.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.LoadingIconPictureBox)).BeginInit();
            this.Menubar2Panel.SuspendLayout();
            this.MainPanel.SuspendLayout();
            this.Menubar3Panel.SuspendLayout();
            this.SuspendLayout();
            // 
            // QueueListBox
            // 
            this.QueueListBox.AllowDrop = true;
            this.QueueListBox.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(15)))), ((int)(((byte)(15)))), ((int)(((byte)(15)))));
            this.QueueListBox.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.QueueListBox.DrawMode = System.Windows.Forms.DrawMode.OwnerDrawFixed;
            this.QueueListBox.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.QueueListBox.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(225)))), ((int)(((byte)(225)))), ((int)(((byte)(225)))));
            this.QueueListBox.FormattingEnabled = true;
            this.QueueListBox.ItemHeight = 20;
            this.QueueListBox.Location = new System.Drawing.Point(1, 1);
            this.QueueListBox.Name = "QueueListBox";
            this.QueueListBox.SelectionMode = System.Windows.Forms.SelectionMode.MultiSimple;
            this.QueueListBox.Size = new System.Drawing.Size(521, 320);
            this.QueueListBox.TabIndex = 0;
            this.QueueListBox.MouseClick += new System.Windows.Forms.MouseEventHandler(this.QueueListBox_MouseClick);
            this.QueueListBox.DrawItem += new System.Windows.Forms.DrawItemEventHandler(this.QueueListBox_DrawItem);
            this.QueueListBox.DragDrop += new System.Windows.Forms.DragEventHandler(this.QueueListBox_DragDrop);
            this.QueueListBox.DragEnter += new System.Windows.Forms.DragEventHandler(this.QueueListBox_DragEnter);
            this.QueueListBox.DragLeave += new System.EventHandler(this.QueueListBox_DragLeave);
            this.QueueListBox.MouseDoubleClick += new System.Windows.Forms.MouseEventHandler(this.QueueListBox_MouseDoubleClick);
            this.QueueListBox.MouseDown += new System.Windows.Forms.MouseEventHandler(this.QueueListBox_MouseDown);
            this.QueueListBox.PreviewKeyDown += new System.Windows.Forms.PreviewKeyDownEventHandler(this.QueueListBox_PreviewKeyDown);
            // 
            // TitlebarPanel
            // 
            this.TitlebarPanel.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(30)))), ((int)(((byte)(30)))), ((int)(((byte)(30)))));
            this.TitlebarPanel.Controls.Add(this.IconPictureBox);
            this.TitlebarPanel.Controls.Add(this.MinimizeButton);
            this.TitlebarPanel.Controls.Add(this.CloseButton);
            this.TitlebarPanel.Location = new System.Drawing.Point(-4, -2);
            this.TitlebarPanel.Name = "TitlebarPanel";
            this.TitlebarPanel.Size = new System.Drawing.Size(560, 25);
            this.TitlebarPanel.TabIndex = 0;
            this.TitlebarPanel.MouseDown += new System.Windows.Forms.MouseEventHandler(this.TitlebarPanel_MouseDown);
            // 
            // IconPictureBox
            // 
            this.IconPictureBox.Image = global::MediaConverter.Properties.Resources.logo_256x;
            this.IconPictureBox.Location = new System.Drawing.Point(6, 3);
            this.IconPictureBox.Name = "IconPictureBox";
            this.IconPictureBox.Size = new System.Drawing.Size(20, 20);
            this.IconPictureBox.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.IconPictureBox.TabIndex = 0;
            this.IconPictureBox.TabStop = false;
            this.IconPictureBox.MouseDown += new System.Windows.Forms.MouseEventHandler(this.IconPictureBox_MouseDown);
            // 
            // MinimizeButton
            // 
            this.MinimizeButton.FlatAppearance.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(45)))), ((int)(((byte)(45)))), ((int)(((byte)(45)))));
            this.MinimizeButton.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.MinimizeButton.Font = new System.Drawing.Font("Microsoft Sans Serif", 6F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.MinimizeButton.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(90)))), ((int)(((byte)(90)))), ((int)(((byte)(90)))));
            this.MinimizeButton.Location = new System.Drawing.Point(507, 2);
            this.MinimizeButton.Name = "MinimizeButton";
            this.MinimizeButton.Size = new System.Drawing.Size(25, 23);
            this.MinimizeButton.TabIndex = 0;
            this.MinimizeButton.Text = "_";
            this.MinimizeButton.UseVisualStyleBackColor = true;
            this.MinimizeButton.Click += new System.EventHandler(this.MinimizeButton_Click);
            // 
            // CloseButton
            // 
            this.CloseButton.FlatAppearance.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(45)))), ((int)(((byte)(45)))), ((int)(((byte)(45)))));
            this.CloseButton.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.CloseButton.Font = new System.Drawing.Font("Microsoft Sans Serif", 6F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.CloseButton.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(90)))), ((int)(((byte)(90)))), ((int)(((byte)(90)))));
            this.CloseButton.Location = new System.Drawing.Point(532, 2);
            this.CloseButton.Name = "CloseButton";
            this.CloseButton.Size = new System.Drawing.Size(25, 23);
            this.CloseButton.TabIndex = 1;
            this.CloseButton.Text = "X";
            this.CloseButton.UseVisualStyleBackColor = true;
            this.CloseButton.Click += new System.EventHandler(this.CloseButton_Click);
            // 
            // Menubar1Panel
            // 
            this.Menubar1Panel.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(25)))), ((int)(((byte)(25)))), ((int)(((byte)(25)))));
            this.Menubar1Panel.Controls.Add(this.LoadingIconPictureBox);
            this.Menubar1Panel.Controls.Add(this.QueueAddMediaButton);
            this.Menubar1Panel.Controls.Add(this.QueueAddMediaFolderButton);
            this.Menubar1Panel.Controls.Add(this.QueueConvertAllButton);
            this.Menubar1Panel.Controls.Add(this.QueueConvertSelectedButton);
            this.Menubar1Panel.Location = new System.Drawing.Point(3, 23);
            this.Menubar1Panel.Name = "Menubar1Panel";
            this.Menubar1Panel.Size = new System.Drawing.Size(550, 27);
            this.Menubar1Panel.TabIndex = 0;
            this.Menubar1Panel.MouseDown += new System.Windows.Forms.MouseEventHandler(this.Menubar1Panel_MouseDown);
            // 
            // LoadingIconPictureBox
            // 
            this.LoadingIconPictureBox.Image = global::MediaConverter.Properties.Resources.loading_icon;
            this.LoadingIconPictureBox.Location = new System.Drawing.Point(48, 6);
            this.LoadingIconPictureBox.Name = "LoadingIconPictureBox";
            this.LoadingIconPictureBox.Size = new System.Drawing.Size(15, 15);
            this.LoadingIconPictureBox.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.LoadingIconPictureBox.TabIndex = 0;
            this.LoadingIconPictureBox.TabStop = false;
            this.LoadingIconPictureBox.MouseDown += new System.Windows.Forms.MouseEventHandler(this.LoadingIconPictureBox_MouseDown);
            // 
            // QueueAddMediaButton
            // 
            this.QueueAddMediaButton.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(25)))), ((int)(((byte)(25)))), ((int)(((byte)(25)))));
            this.QueueAddMediaButton.BackgroundImage = global::MediaConverter.Properties.Resources.add_media_button;
            this.QueueAddMediaButton.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.QueueAddMediaButton.FlatAppearance.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(25)))), ((int)(((byte)(25)))), ((int)(((byte)(25)))));
            this.QueueAddMediaButton.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.QueueAddMediaButton.ForeColor = System.Drawing.Color.Gainsboro;
            this.QueueAddMediaButton.Location = new System.Drawing.Point(3, 3);
            this.QueueAddMediaButton.Name = "QueueAddMediaButton";
            this.QueueAddMediaButton.Size = new System.Drawing.Size(20, 20);
            this.QueueAddMediaButton.TabIndex = 0;
            this.QueueAddMediaButton.UseVisualStyleBackColor = false;
            this.QueueAddMediaButton.Click += new System.EventHandler(this.QueueAddMediaButton_Click);
            // 
            // QueueAddMediaFolderButton
            // 
            this.QueueAddMediaFolderButton.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(25)))), ((int)(((byte)(25)))), ((int)(((byte)(25)))));
            this.QueueAddMediaFolderButton.BackgroundImage = global::MediaConverter.Properties.Resources.add_media_folder_button;
            this.QueueAddMediaFolderButton.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.QueueAddMediaFolderButton.FlatAppearance.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(25)))), ((int)(((byte)(25)))), ((int)(((byte)(25)))));
            this.QueueAddMediaFolderButton.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.QueueAddMediaFolderButton.ForeColor = System.Drawing.Color.Gainsboro;
            this.QueueAddMediaFolderButton.Location = new System.Drawing.Point(24, 3);
            this.QueueAddMediaFolderButton.Name = "QueueAddMediaFolderButton";
            this.QueueAddMediaFolderButton.Size = new System.Drawing.Size(20, 20);
            this.QueueAddMediaFolderButton.TabIndex = 1;
            this.QueueAddMediaFolderButton.UseVisualStyleBackColor = false;
            this.QueueAddMediaFolderButton.Click += new System.EventHandler(this.QueueAddMediaFolderButton_Click);
            // 
            // QueueConvertAllButton
            // 
            this.QueueConvertAllButton.BackgroundImage = global::MediaConverter.Properties.Resources.convert_all_button;
            this.QueueConvertAllButton.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.QueueConvertAllButton.FlatAppearance.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(25)))), ((int)(((byte)(25)))), ((int)(((byte)(25)))));
            this.QueueConvertAllButton.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.QueueConvertAllButton.ForeColor = System.Drawing.Color.LimeGreen;
            this.QueueConvertAllButton.Location = new System.Drawing.Point(502, 3);
            this.QueueConvertAllButton.Name = "QueueConvertAllButton";
            this.QueueConvertAllButton.Size = new System.Drawing.Size(20, 20);
            this.QueueConvertAllButton.TabIndex = 2;
            this.QueueConvertAllButton.UseVisualStyleBackColor = true;
            this.QueueConvertAllButton.Click += new System.EventHandler(this.QueueConvertAllButton_Click);
            // 
            // QueueConvertSelectedButton
            // 
            this.QueueConvertSelectedButton.BackgroundImage = global::MediaConverter.Properties.Resources.convert_selected_button;
            this.QueueConvertSelectedButton.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.QueueConvertSelectedButton.FlatAppearance.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(25)))), ((int)(((byte)(25)))), ((int)(((byte)(25)))));
            this.QueueConvertSelectedButton.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.QueueConvertSelectedButton.ForeColor = System.Drawing.Color.MediumSpringGreen;
            this.QueueConvertSelectedButton.Location = new System.Drawing.Point(526, 3);
            this.QueueConvertSelectedButton.Name = "QueueConvertSelectedButton";
            this.QueueConvertSelectedButton.Size = new System.Drawing.Size(20, 20);
            this.QueueConvertSelectedButton.TabIndex = 3;
            this.QueueConvertSelectedButton.UseVisualStyleBackColor = true;
            this.QueueConvertSelectedButton.Click += new System.EventHandler(this.QueueConvertSelectedButton_Click);
            // 
            // Menubar2Panel
            // 
            this.Menubar2Panel.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(20)))), ((int)(((byte)(20)))), ((int)(((byte)(20)))));
            this.Menubar2Panel.Controls.Add(this.button1);
            this.Menubar2Panel.Controls.Add(this.QueueRenameButton);
            this.Menubar2Panel.Controls.Add(this.SettingsButton);
            this.Menubar2Panel.Controls.Add(this.QueueDeselectAllButton);
            this.Menubar2Panel.Controls.Add(this.QueueSelectInvertButton);
            this.Menubar2Panel.Controls.Add(this.QueueSelectAllButton);
            this.Menubar2Panel.Controls.Add(this.QueueEditButton);
            this.Menubar2Panel.Controls.Add(this.QueueOpenMediaLocationButton);
            this.Menubar2Panel.Controls.Add(this.QueueRemoveAllButton);
            this.Menubar2Panel.Controls.Add(this.QueueRemoveSelectedButton);
            this.Menubar2Panel.Location = new System.Drawing.Point(3, 50);
            this.Menubar2Panel.Name = "Menubar2Panel";
            this.Menubar2Panel.Size = new System.Drawing.Size(27, 342);
            this.Menubar2Panel.TabIndex = 0;
            // 
            // QueueRenameButton
            // 
            this.QueueRenameButton.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(20)))), ((int)(((byte)(20)))), ((int)(((byte)(20)))));
            this.QueueRenameButton.BackgroundImage = global::MediaConverter.Properties.Resources.rename_button;
            this.QueueRenameButton.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.QueueRenameButton.FlatAppearance.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(20)))), ((int)(((byte)(20)))), ((int)(((byte)(20)))));
            this.QueueRenameButton.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.QueueRenameButton.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(100)))), ((int)(((byte)(237)))), ((int)(((byte)(177)))));
            this.QueueRenameButton.Location = new System.Drawing.Point(4, 98);
            this.QueueRenameButton.Name = "QueueRenameButton";
            this.QueueRenameButton.Size = new System.Drawing.Size(20, 20);
            this.QueueRenameButton.TabIndex = 4;
            this.QueueRenameButton.UseVisualStyleBackColor = false;
            this.QueueRenameButton.Click += new System.EventHandler(this.QueueRenameButton_Click);
            // 
            // SettingsButton
            // 
            this.SettingsButton.BackgroundImage = global::MediaConverter.Properties.Resources.settings_button;
            this.SettingsButton.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.SettingsButton.FlatAppearance.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(20)))), ((int)(((byte)(20)))), ((int)(((byte)(20)))));
            this.SettingsButton.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.SettingsButton.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(150)))), ((int)(((byte)(150)))), ((int)(((byte)(150)))));
            this.SettingsButton.Location = new System.Drawing.Point(3, 320);
            this.SettingsButton.Name = "SettingsButton";
            this.SettingsButton.Size = new System.Drawing.Size(20, 20);
            this.SettingsButton.TabIndex = 8;
            this.SettingsButton.UseVisualStyleBackColor = true;
            this.SettingsButton.Click += new System.EventHandler(this.SettingsButton_Click);
            this.SettingsButton.MouseDown += new System.Windows.Forms.MouseEventHandler(this.SettingsButton_MouseDown);
            // 
            // QueueDeselectAllButton
            // 
            this.QueueDeselectAllButton.BackgroundImage = global::MediaConverter.Properties.Resources.deselect_all_button;
            this.QueueDeselectAllButton.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.QueueDeselectAllButton.FlatAppearance.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(20)))), ((int)(((byte)(20)))), ((int)(((byte)(20)))));
            this.QueueDeselectAllButton.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.QueueDeselectAllButton.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(144)))), ((int)(((byte)(153)))), ((int)(((byte)(178)))));
            this.QueueDeselectAllButton.Location = new System.Drawing.Point(4, 25);
            this.QueueDeselectAllButton.Name = "QueueDeselectAllButton";
            this.QueueDeselectAllButton.Size = new System.Drawing.Size(20, 20);
            this.QueueDeselectAllButton.TabIndex = 1;
            this.QueueDeselectAllButton.UseVisualStyleBackColor = true;
            this.QueueDeselectAllButton.Click += new System.EventHandler(this.QueueDeselectAllButton_Click);
            // 
            // QueueSelectInvertButton
            // 
            this.QueueSelectInvertButton.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("QueueSelectInvertButton.BackgroundImage")));
            this.QueueSelectInvertButton.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.QueueSelectInvertButton.FlatAppearance.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(20)))), ((int)(((byte)(20)))), ((int)(((byte)(20)))));
            this.QueueSelectInvertButton.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.QueueSelectInvertButton.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(144)))), ((int)(((byte)(153)))), ((int)(((byte)(178)))));
            this.QueueSelectInvertButton.Location = new System.Drawing.Point(4, 46);
            this.QueueSelectInvertButton.Name = "QueueSelectInvertButton";
            this.QueueSelectInvertButton.Size = new System.Drawing.Size(20, 20);
            this.QueueSelectInvertButton.TabIndex = 2;
            this.QueueSelectInvertButton.UseVisualStyleBackColor = true;
            this.QueueSelectInvertButton.Click += new System.EventHandler(this.QueueSelectInvertButton_Click);
            // 
            // QueueSelectAllButton
            // 
            this.QueueSelectAllButton.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("QueueSelectAllButton.BackgroundImage")));
            this.QueueSelectAllButton.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.QueueSelectAllButton.FlatAppearance.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(20)))), ((int)(((byte)(20)))), ((int)(((byte)(20)))));
            this.QueueSelectAllButton.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.QueueSelectAllButton.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(144)))), ((int)(((byte)(153)))), ((int)(((byte)(178)))));
            this.QueueSelectAllButton.Location = new System.Drawing.Point(4, 4);
            this.QueueSelectAllButton.Name = "QueueSelectAllButton";
            this.QueueSelectAllButton.Size = new System.Drawing.Size(20, 20);
            this.QueueSelectAllButton.TabIndex = 0;
            this.QueueSelectAllButton.UseVisualStyleBackColor = true;
            this.QueueSelectAllButton.Click += new System.EventHandler(this.QueueSelectAllButton_Click);
            // 
            // QueueEditButton
            // 
            this.QueueEditButton.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(20)))), ((int)(((byte)(20)))), ((int)(((byte)(20)))));
            this.QueueEditButton.BackgroundImage = global::MediaConverter.Properties.Resources.edit_button;
            this.QueueEditButton.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.QueueEditButton.FlatAppearance.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(20)))), ((int)(((byte)(20)))), ((int)(((byte)(20)))));
            this.QueueEditButton.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.QueueEditButton.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(65)))), ((int)(((byte)(225)))), ((int)(((byte)(118)))));
            this.QueueEditButton.Location = new System.Drawing.Point(4, 77);
            this.QueueEditButton.Name = "QueueEditButton";
            this.QueueEditButton.Size = new System.Drawing.Size(20, 20);
            this.QueueEditButton.TabIndex = 3;
            this.QueueEditButton.UseVisualStyleBackColor = false;
            this.QueueEditButton.Click += new System.EventHandler(this.QueueEditButton_Click);
            // 
            // QueueOpenMediaLocationButton
            // 
            this.QueueOpenMediaLocationButton.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("QueueOpenMediaLocationButton.BackgroundImage")));
            this.QueueOpenMediaLocationButton.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.QueueOpenMediaLocationButton.FlatAppearance.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(20)))), ((int)(((byte)(20)))), ((int)(((byte)(20)))));
            this.QueueOpenMediaLocationButton.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.QueueOpenMediaLocationButton.ForeColor = System.Drawing.Color.Khaki;
            this.QueueOpenMediaLocationButton.Location = new System.Drawing.Point(4, 181);
            this.QueueOpenMediaLocationButton.Name = "QueueOpenMediaLocationButton";
            this.QueueOpenMediaLocationButton.Size = new System.Drawing.Size(20, 20);
            this.QueueOpenMediaLocationButton.TabIndex = 7;
            this.QueueOpenMediaLocationButton.UseVisualStyleBackColor = true;
            this.QueueOpenMediaLocationButton.Click += new System.EventHandler(this.QueueOpenMediaLocationButton_Click);
            // 
            // QueueRemoveAllButton
            // 
            this.QueueRemoveAllButton.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(20)))), ((int)(((byte)(20)))), ((int)(((byte)(20)))));
            this.QueueRemoveAllButton.BackgroundImage = global::MediaConverter.Properties.Resources.remove_all_button;
            this.QueueRemoveAllButton.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.QueueRemoveAllButton.FlatAppearance.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(20)))), ((int)(((byte)(20)))), ((int)(((byte)(20)))));
            this.QueueRemoveAllButton.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.QueueRemoveAllButton.ForeColor = System.Drawing.Color.Red;
            this.QueueRemoveAllButton.Location = new System.Drawing.Point(4, 129);
            this.QueueRemoveAllButton.Name = "QueueRemoveAllButton";
            this.QueueRemoveAllButton.Size = new System.Drawing.Size(20, 20);
            this.QueueRemoveAllButton.TabIndex = 5;
            this.QueueRemoveAllButton.UseVisualStyleBackColor = false;
            this.QueueRemoveAllButton.Click += new System.EventHandler(this.QueueRemoveAllButton_Click);
            // 
            // QueueRemoveSelectedButton
            // 
            this.QueueRemoveSelectedButton.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(20)))), ((int)(((byte)(20)))), ((int)(((byte)(20)))));
            this.QueueRemoveSelectedButton.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("QueueRemoveSelectedButton.BackgroundImage")));
            this.QueueRemoveSelectedButton.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.QueueRemoveSelectedButton.FlatAppearance.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(20)))), ((int)(((byte)(20)))), ((int)(((byte)(20)))));
            this.QueueRemoveSelectedButton.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.QueueRemoveSelectedButton.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(220)))), ((int)(((byte)(20)))), ((int)(((byte)(80)))));
            this.QueueRemoveSelectedButton.Location = new System.Drawing.Point(4, 150);
            this.QueueRemoveSelectedButton.Name = "QueueRemoveSelectedButton";
            this.QueueRemoveSelectedButton.Size = new System.Drawing.Size(20, 20);
            this.QueueRemoveSelectedButton.TabIndex = 6;
            this.QueueRemoveSelectedButton.UseVisualStyleBackColor = false;
            this.QueueRemoveSelectedButton.Click += new System.EventHandler(this.QueueRemoveSelectedButton_Click);
            // 
            // MainPanel
            // 
            this.MainPanel.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(150)))), ((int)(((byte)(0)))));
            this.MainPanel.Controls.Add(this.QueueRefreshButton);
            this.MainPanel.Controls.Add(this.QueueSelectionMoveDownButton);
            this.MainPanel.Controls.Add(this.QueueSelectionMoveUpButton);
            this.MainPanel.Controls.Add(this.QueueListBox);
            this.MainPanel.Location = new System.Drawing.Point(30, 50);
            this.MainPanel.Name = "MainPanel";
            this.MainPanel.Size = new System.Drawing.Size(523, 322);
            this.MainPanel.TabIndex = 0;
            // 
            // QueueRefreshButton
            // 
            this.QueueRefreshButton.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(15)))), ((int)(((byte)(15)))), ((int)(((byte)(15)))));
            this.QueueRefreshButton.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("QueueRefreshButton.BackgroundImage")));
            this.QueueRefreshButton.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.QueueRefreshButton.FlatAppearance.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(15)))), ((int)(((byte)(15)))), ((int)(((byte)(15)))));
            this.QueueRefreshButton.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.QueueRefreshButton.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.QueueRefreshButton.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(150)))), ((int)(((byte)(150)))), ((int)(((byte)(150)))));
            this.QueueRefreshButton.Location = new System.Drawing.Point(458, 299);
            this.QueueRefreshButton.Name = "QueueRefreshButton";
            this.QueueRefreshButton.Size = new System.Drawing.Size(20, 20);
            this.QueueRefreshButton.TabIndex = 1;
            this.QueueRefreshButton.UseVisualStyleBackColor = false;
            this.QueueRefreshButton.Click += new System.EventHandler(this.QueueRefreshButton_Click);
            // 
            // QueueSelectionMoveDownButton
            // 
            this.QueueSelectionMoveDownButton.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(15)))), ((int)(((byte)(15)))), ((int)(((byte)(15)))));
            this.QueueSelectionMoveDownButton.BackgroundImage = global::MediaConverter.Properties.Resources.move_down_button;
            this.QueueSelectionMoveDownButton.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.QueueSelectionMoveDownButton.FlatAppearance.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(15)))), ((int)(((byte)(15)))), ((int)(((byte)(15)))));
            this.QueueSelectionMoveDownButton.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.QueueSelectionMoveDownButton.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.QueueSelectionMoveDownButton.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(150)))), ((int)(((byte)(150)))), ((int)(((byte)(150)))));
            this.QueueSelectionMoveDownButton.Location = new System.Drawing.Point(479, 299);
            this.QueueSelectionMoveDownButton.Name = "QueueSelectionMoveDownButton";
            this.QueueSelectionMoveDownButton.Size = new System.Drawing.Size(20, 20);
            this.QueueSelectionMoveDownButton.TabIndex = 2;
            this.QueueSelectionMoveDownButton.UseVisualStyleBackColor = false;
            this.QueueSelectionMoveDownButton.Click += new System.EventHandler(this.QueueSelectionMoveDownButton_Click);
            // 
            // QueueSelectionMoveUpButton
            // 
            this.QueueSelectionMoveUpButton.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(15)))), ((int)(((byte)(15)))), ((int)(((byte)(15)))));
            this.QueueSelectionMoveUpButton.BackgroundImage = global::MediaConverter.Properties.Resources.move_up_button;
            this.QueueSelectionMoveUpButton.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.QueueSelectionMoveUpButton.FlatAppearance.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(15)))), ((int)(((byte)(15)))), ((int)(((byte)(15)))));
            this.QueueSelectionMoveUpButton.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.QueueSelectionMoveUpButton.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.QueueSelectionMoveUpButton.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(150)))), ((int)(((byte)(150)))), ((int)(((byte)(150)))));
            this.QueueSelectionMoveUpButton.Location = new System.Drawing.Point(500, 299);
            this.QueueSelectionMoveUpButton.Name = "QueueSelectionMoveUpButton";
            this.QueueSelectionMoveUpButton.Size = new System.Drawing.Size(20, 20);
            this.QueueSelectionMoveUpButton.TabIndex = 3;
            this.QueueSelectionMoveUpButton.UseVisualStyleBackColor = false;
            this.QueueSelectionMoveUpButton.Click += new System.EventHandler(this.QueueSelectionMoveUpButton_Click);
            // 
            // Menubar3Panel
            // 
            this.Menubar3Panel.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(15)))), ((int)(((byte)(15)))), ((int)(((byte)(15)))));
            this.Menubar3Panel.Controls.Add(this.VersionLabel);
            this.Menubar3Panel.Controls.Add(this.QueueSelectedLabel);
            this.Menubar3Panel.Location = new System.Drawing.Point(30, 372);
            this.Menubar3Panel.Name = "Menubar3Panel";
            this.Menubar3Panel.Size = new System.Drawing.Size(523, 20);
            this.Menubar3Panel.TabIndex = 0;
            // 
            // VersionLabel
            // 
            this.VersionLabel.AutoSize = true;
            this.VersionLabel.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(100)))), ((int)(((byte)(100)))), ((int)(((byte)(100)))));
            this.VersionLabel.Location = new System.Drawing.Point(405, 4);
            this.VersionLabel.Name = "VersionLabel";
            this.VersionLabel.Size = new System.Drawing.Size(115, 13);
            this.VersionLabel.TabIndex = 0;
            this.VersionLabel.Text = "MediaConverter v0.0.0";
            // 
            // QueueSelectedLabel
            // 
            this.QueueSelectedLabel.AutoSize = true;
            this.QueueSelectedLabel.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(175)))), ((int)(((byte)(175)))), ((int)(((byte)(175)))));
            this.QueueSelectedLabel.Location = new System.Drawing.Point(2, 3);
            this.QueueSelectedLabel.Name = "QueueSelectedLabel";
            this.QueueSelectedLabel.Size = new System.Drawing.Size(97, 13);
            this.QueueSelectedLabel.TabIndex = 0;
            this.QueueSelectedLabel.Text = "0 items | 0 selected";
            // 
            // MainToolTip
            // 
            this.MainToolTip.Draw += new System.Windows.Forms.DrawToolTipEventHandler(this.MainToolTip_Draw);
            // 
            // button1
            // 
            this.button1.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("button1.BackgroundImage")));
            this.button1.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.button1.FlatAppearance.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(20)))), ((int)(((byte)(20)))), ((int)(((byte)(20)))));
            this.button1.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button1.ForeColor = System.Drawing.Color.Khaki;
            this.button1.Location = new System.Drawing.Point(4, 202);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(20, 20);
            this.button1.TabIndex = 9;
            this.button1.UseVisualStyleBackColor = true;
            // 
            // Main
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(30)))), ((int)(((byte)(30)))), ((int)(((byte)(30)))));
            this.ClientSize = new System.Drawing.Size(556, 395);
            this.Controls.Add(this.Menubar3Panel);
            this.Controls.Add(this.MainPanel);
            this.Controls.Add(this.Menubar2Panel);
            this.Controls.Add(this.Menubar1Panel);
            this.Controls.Add(this.TitlebarPanel);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "Main";
            this.Text = "MediaConverter";
            this.Load += new System.EventHandler(this.Main_Load);
            this.TitlebarPanel.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.IconPictureBox)).EndInit();
            this.Menubar1Panel.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.LoadingIconPictureBox)).EndInit();
            this.Menubar2Panel.ResumeLayout(false);
            this.MainPanel.ResumeLayout(false);
            this.Menubar3Panel.ResumeLayout(false);
            this.Menubar3Panel.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion
        private System.Windows.Forms.ListBox QueueListBox;
        private System.Windows.Forms.Button QueueConvertSelectedButton;
        private System.Windows.Forms.Button QueueRemoveSelectedButton;
        private System.Windows.Forms.Button QueueConvertAllButton;
        private System.Windows.Forms.Panel TitlebarPanel;
        private System.Windows.Forms.Button QueueRemoveAllButton;
        private System.Windows.Forms.Button CloseButton;
        private System.Windows.Forms.Button MinimizeButton;
        private System.Windows.Forms.Panel Menubar1Panel;
        private System.Windows.Forms.Panel Menubar2Panel;
        private System.Windows.Forms.Panel MainPanel;
        private System.Windows.Forms.Button QueueAddMediaFolderButton;
        private System.Windows.Forms.Button QueueAddMediaButton;
        private System.Windows.Forms.Button QueueOpenMediaLocationButton;
        private System.Windows.Forms.Button QueueSelectionMoveDownButton;
        private System.Windows.Forms.Button QueueEditButton;
        private System.Windows.Forms.Button QueueSelectAllButton;
        private System.Windows.Forms.Button QueueSelectInvertButton;
        private System.Windows.Forms.Button QueueDeselectAllButton;
        private System.Windows.Forms.Panel Menubar3Panel;
        private System.Windows.Forms.Label QueueSelectedLabel;
        private System.Windows.Forms.PictureBox LoadingIconPictureBox;
        private System.Windows.Forms.ToolTip MainToolTip;
        private System.Windows.Forms.Label VersionLabel;
        private System.Windows.Forms.PictureBox IconPictureBox;
        private System.Windows.Forms.Button SettingsButton;
        private System.Windows.Forms.Button QueueSelectionMoveUpButton;
        private System.Windows.Forms.Button QueueRefreshButton;
        private System.Windows.Forms.Button QueueRenameButton;
        private System.Windows.Forms.Button button1;
    }
}