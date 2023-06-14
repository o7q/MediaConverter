namespace MediaConverter.Forms
{
    partial class MediaItemRenamer
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(MediaItemRenamer));
            this.TitlebarPanel = new System.Windows.Forms.Panel();
            this.IconPictureBox = new System.Windows.Forms.PictureBox();
            this.CloseButton = new System.Windows.Forms.Button();
            this.RenameTextBox = new System.Windows.Forms.TextBox();
            this.SaveButton = new System.Windows.Forms.Button();
            this.Color1Panel = new System.Windows.Forms.Panel();
            this.RenameItemsPanel = new System.Windows.Forms.Panel();
            this.CodecSettingsLabel = new System.Windows.Forms.Label();
            this.TitlebarPanel.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.IconPictureBox)).BeginInit();
            this.Color1Panel.SuspendLayout();
            this.RenameItemsPanel.SuspendLayout();
            this.SuspendLayout();
            // 
            // TitlebarPanel
            // 
            this.TitlebarPanel.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(30)))), ((int)(((byte)(30)))), ((int)(((byte)(30)))));
            this.TitlebarPanel.Controls.Add(this.IconPictureBox);
            this.TitlebarPanel.Controls.Add(this.CloseButton);
            this.TitlebarPanel.Location = new System.Drawing.Point(-4, -4);
            this.TitlebarPanel.Name = "TitlebarPanel";
            this.TitlebarPanel.Size = new System.Drawing.Size(174, 27);
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
            this.IconPictureBox.MouseDown += new System.Windows.Forms.MouseEventHandler(this.IconPictureBox_MouseDown);
            // 
            // CloseButton
            // 
            this.CloseButton.FlatAppearance.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(45)))), ((int)(((byte)(45)))), ((int)(((byte)(45)))));
            this.CloseButton.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.CloseButton.Font = new System.Drawing.Font("Microsoft Sans Serif", 6F, System.Drawing.FontStyle.Bold);
            this.CloseButton.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(90)))), ((int)(((byte)(90)))), ((int)(((byte)(90)))));
            this.CloseButton.Location = new System.Drawing.Point(147, 4);
            this.CloseButton.Name = "CloseButton";
            this.CloseButton.Size = new System.Drawing.Size(25, 23);
            this.CloseButton.TabIndex = 0;
            this.CloseButton.Text = "X";
            this.CloseButton.UseVisualStyleBackColor = true;
            this.CloseButton.Click += new System.EventHandler(this.CloseButton_Click);
            // 
            // RenameTextBox
            // 
            this.RenameTextBox.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(30)))), ((int)(((byte)(30)))), ((int)(((byte)(30)))));
            this.RenameTextBox.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.RenameTextBox.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(225)))), ((int)(((byte)(225)))), ((int)(((byte)(225)))));
            this.RenameTextBox.Location = new System.Drawing.Point(4, 5);
            this.RenameTextBox.Name = "RenameTextBox";
            this.RenameTextBox.Size = new System.Drawing.Size(141, 20);
            this.RenameTextBox.TabIndex = 0;
            // 
            // SaveButton
            // 
            this.SaveButton.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(50)))), ((int)(((byte)(0)))));
            this.SaveButton.FlatAppearance.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(75)))), ((int)(((byte)(0)))));
            this.SaveButton.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.SaveButton.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold);
            this.SaveButton.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(150)))), ((int)(((byte)(0)))));
            this.SaveButton.Location = new System.Drawing.Point(8, 82);
            this.SaveButton.Name = "SaveButton";
            this.SaveButton.Size = new System.Drawing.Size(75, 33);
            this.SaveButton.TabIndex = 0;
            this.SaveButton.Text = "Apply";
            this.SaveButton.UseVisualStyleBackColor = false;
            this.SaveButton.Click += new System.EventHandler(this.SaveButton_Click);
            // 
            // Color1Panel
            // 
            this.Color1Panel.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(100)))), ((int)(((byte)(100)))), ((int)(((byte)(100)))));
            this.Color1Panel.Controls.Add(this.RenameItemsPanel);
            this.Color1Panel.Location = new System.Drawing.Point(8, 48);
            this.Color1Panel.Name = "Color1Panel";
            this.Color1Panel.Size = new System.Drawing.Size(151, 32);
            this.Color1Panel.TabIndex = 0;
            // 
            // RenameItemsPanel
            // 
            this.RenameItemsPanel.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(20)))), ((int)(((byte)(20)))), ((int)(((byte)(20)))));
            this.RenameItemsPanel.Controls.Add(this.RenameTextBox);
            this.RenameItemsPanel.Location = new System.Drawing.Point(1, 1);
            this.RenameItemsPanel.Name = "RenameItemsPanel";
            this.RenameItemsPanel.Size = new System.Drawing.Size(149, 30);
            this.RenameItemsPanel.TabIndex = 0;
            // 
            // CodecSettingsLabel
            // 
            this.CodecSettingsLabel.AutoSize = true;
            this.CodecSettingsLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.CodecSettingsLabel.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(225)))), ((int)(((byte)(225)))), ((int)(((byte)(225)))));
            this.CodecSettingsLabel.Location = new System.Drawing.Point(5, 30);
            this.CodecSettingsLabel.Name = "CodecSettingsLabel";
            this.CodecSettingsLabel.Size = new System.Drawing.Size(104, 18);
            this.CodecSettingsLabel.TabIndex = 0;
            this.CodecSettingsLabel.Text = "Rename Items";
            // 
            // MediaItemRenamer
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(25)))), ((int)(((byte)(25)))), ((int)(((byte)(25)))));
            this.ClientSize = new System.Drawing.Size(168, 122);
            this.Controls.Add(this.CodecSettingsLabel);
            this.Controls.Add(this.Color1Panel);
            this.Controls.Add(this.SaveButton);
            this.Controls.Add(this.TitlebarPanel);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "MediaItemRenamer";
            this.ShowInTaskbar = false;
            this.Load += new System.EventHandler(this.MediaItemRenamer_Load);
            this.TitlebarPanel.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.IconPictureBox)).EndInit();
            this.Color1Panel.ResumeLayout(false);
            this.RenameItemsPanel.ResumeLayout(false);
            this.RenameItemsPanel.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Panel TitlebarPanel;
        private System.Windows.Forms.PictureBox IconPictureBox;
        private System.Windows.Forms.Button CloseButton;
        private System.Windows.Forms.TextBox RenameTextBox;
        private System.Windows.Forms.Button SaveButton;
        private System.Windows.Forms.Panel Color1Panel;
        private System.Windows.Forms.Panel RenameItemsPanel;
        private System.Windows.Forms.Label CodecSettingsLabel;
    }
}