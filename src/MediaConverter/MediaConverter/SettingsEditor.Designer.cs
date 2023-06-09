namespace MediaConverter
{
    partial class SettingsEditor
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(SettingsEditor));
            this.TitlebarPanel = new System.Windows.Forms.Panel();
            this.IconPictureBox = new System.Windows.Forms.PictureBox();
            this.CloseButton = new System.Windows.Forms.Button();
            this.ThemeColorPickerButton = new System.Windows.Forms.Button();
            this.ThemeColorPanel = new System.Windows.Forms.Panel();
            this.SaveButton = new System.Windows.Forms.Button();
            this.ThemeColorResetButton = new System.Windows.Forms.Button();
            this.Color3Panel = new System.Windows.Forms.Panel();
            this.OutputSettingsPanel = new System.Windows.Forms.Panel();
            this.CodecSettingsLabel = new System.Windows.Forms.Label();
            this.SettingsEditorToolTip = new System.Windows.Forms.ToolTip(this.components);
            this.TitlebarPanel.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.IconPictureBox)).BeginInit();
            this.Color3Panel.SuspendLayout();
            this.OutputSettingsPanel.SuspendLayout();
            this.SuspendLayout();
            // 
            // TitlebarPanel
            // 
            this.TitlebarPanel.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(30)))), ((int)(((byte)(30)))), ((int)(((byte)(30)))));
            this.TitlebarPanel.Controls.Add(this.IconPictureBox);
            this.TitlebarPanel.Controls.Add(this.CloseButton);
            this.TitlebarPanel.Location = new System.Drawing.Point(-4, -4);
            this.TitlebarPanel.Name = "TitlebarPanel";
            this.TitlebarPanel.Size = new System.Drawing.Size(142, 27);
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
            this.CloseButton.Location = new System.Drawing.Point(113, 4);
            this.CloseButton.Name = "CloseButton";
            this.CloseButton.Size = new System.Drawing.Size(25, 23);
            this.CloseButton.TabIndex = 0;
            this.CloseButton.Text = "X";
            this.CloseButton.UseVisualStyleBackColor = true;
            this.CloseButton.Click += new System.EventHandler(this.CloseButton_Click);
            // 
            // ThemeColorPickerButton
            // 
            this.ThemeColorPickerButton.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(30)))), ((int)(((byte)(30)))), ((int)(((byte)(30)))));
            this.ThemeColorPickerButton.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.ThemeColorPickerButton.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.ThemeColorPickerButton.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(225)))), ((int)(((byte)(225)))), ((int)(((byte)(225)))));
            this.ThemeColorPickerButton.Location = new System.Drawing.Point(9, 9);
            this.ThemeColorPickerButton.Name = "ThemeColorPickerButton";
            this.ThemeColorPickerButton.Size = new System.Drawing.Size(70, 27);
            this.ThemeColorPickerButton.TabIndex = 1;
            this.ThemeColorPickerButton.Text = "Select";
            this.ThemeColorPickerButton.UseVisualStyleBackColor = false;
            this.ThemeColorPickerButton.Click += new System.EventHandler(this.ThemeColorPickerButton_Click);
            // 
            // ThemeColorPanel
            // 
            this.ThemeColorPanel.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(29)))), ((int)(((byte)(128)))), ((int)(((byte)(245)))));
            this.ThemeColorPanel.Location = new System.Drawing.Point(8, 36);
            this.ThemeColorPanel.Name = "ThemeColorPanel";
            this.ThemeColorPanel.Size = new System.Drawing.Size(98, 27);
            this.ThemeColorPanel.TabIndex = 0;
            // 
            // SaveButton
            // 
            this.SaveButton.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(30)))), ((int)(((byte)(30)))), ((int)(((byte)(30)))));
            this.SaveButton.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.SaveButton.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold);
            this.SaveButton.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(29)))), ((int)(((byte)(128)))), ((int)(((byte)(245)))));
            this.SaveButton.Location = new System.Drawing.Point(8, 125);
            this.SaveButton.Name = "SaveButton";
            this.SaveButton.Size = new System.Drawing.Size(75, 33);
            this.SaveButton.TabIndex = 3;
            this.SaveButton.Text = "Apply";
            this.SaveButton.UseVisualStyleBackColor = false;
            this.SaveButton.Click += new System.EventHandler(this.SaveButton_Click);
            // 
            // ThemeColorResetButton
            // 
            this.ThemeColorResetButton.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(30)))), ((int)(((byte)(30)))), ((int)(((byte)(30)))));
            this.ThemeColorResetButton.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.ThemeColorResetButton.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(225)))), ((int)(((byte)(225)))), ((int)(((byte)(225)))));
            this.ThemeColorResetButton.Location = new System.Drawing.Point(79, 9);
            this.ThemeColorResetButton.Name = "ThemeColorResetButton";
            this.ThemeColorResetButton.Size = new System.Drawing.Size(27, 27);
            this.ThemeColorResetButton.TabIndex = 2;
            this.ThemeColorResetButton.Text = "X";
            this.ThemeColorResetButton.UseVisualStyleBackColor = false;
            this.ThemeColorResetButton.Click += new System.EventHandler(this.ThemeColorResetButton_Click);
            // 
            // Color3Panel
            // 
            this.Color3Panel.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(100)))), ((int)(((byte)(100)))), ((int)(((byte)(100)))));
            this.Color3Panel.Controls.Add(this.OutputSettingsPanel);
            this.Color3Panel.Location = new System.Drawing.Point(8, 48);
            this.Color3Panel.Name = "Color3Panel";
            this.Color3Panel.Size = new System.Drawing.Size(118, 74);
            this.Color3Panel.TabIndex = 0;
            // 
            // OutputSettingsPanel
            // 
            this.OutputSettingsPanel.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(20)))), ((int)(((byte)(20)))), ((int)(((byte)(20)))));
            this.OutputSettingsPanel.Controls.Add(this.ThemeColorPickerButton);
            this.OutputSettingsPanel.Controls.Add(this.ThemeColorResetButton);
            this.OutputSettingsPanel.Controls.Add(this.ThemeColorPanel);
            this.OutputSettingsPanel.Location = new System.Drawing.Point(1, 1);
            this.OutputSettingsPanel.Name = "OutputSettingsPanel";
            this.OutputSettingsPanel.Size = new System.Drawing.Size(116, 72);
            this.OutputSettingsPanel.TabIndex = 0;
            // 
            // CodecSettingsLabel
            // 
            this.CodecSettingsLabel.AutoSize = true;
            this.CodecSettingsLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.CodecSettingsLabel.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(225)))), ((int)(((byte)(225)))), ((int)(((byte)(225)))));
            this.CodecSettingsLabel.Location = new System.Drawing.Point(5, 30);
            this.CodecSettingsLabel.Name = "CodecSettingsLabel";
            this.CodecSettingsLabel.Size = new System.Drawing.Size(119, 18);
            this.CodecSettingsLabel.TabIndex = 0;
            this.CodecSettingsLabel.Text = "UI Color Options";
            // 
            // SettingsEditorToolTip
            // 
            this.SettingsEditorToolTip.Draw += new System.Windows.Forms.DrawToolTipEventHandler(this.SettingsEditorToolTip_Draw);
            // 
            // SettingsEditor
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(25)))), ((int)(((byte)(25)))), ((int)(((byte)(25)))));
            this.ClientSize = new System.Drawing.Size(134, 164);
            this.Controls.Add(this.CodecSettingsLabel);
            this.Controls.Add(this.Color3Panel);
            this.Controls.Add(this.SaveButton);
            this.Controls.Add(this.TitlebarPanel);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "SettingsEditor";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterParent;
            this.Text = "MediaConverter Settings";
            this.Load += new System.EventHandler(this.SettingsEditor_Load);
            this.TitlebarPanel.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.IconPictureBox)).EndInit();
            this.Color3Panel.ResumeLayout(false);
            this.OutputSettingsPanel.ResumeLayout(false);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Panel TitlebarPanel;
        private System.Windows.Forms.PictureBox IconPictureBox;
        private System.Windows.Forms.Button CloseButton;
        private System.Windows.Forms.Button ThemeColorPickerButton;
        private System.Windows.Forms.Panel ThemeColorPanel;
        private System.Windows.Forms.Button SaveButton;
        private System.Windows.Forms.Button ThemeColorResetButton;
        private System.Windows.Forms.Panel Color3Panel;
        private System.Windows.Forms.Panel OutputSettingsPanel;
        private System.Windows.Forms.Label CodecSettingsLabel;
        private System.Windows.Forms.ToolTip SettingsEditorToolTip;
    }
}