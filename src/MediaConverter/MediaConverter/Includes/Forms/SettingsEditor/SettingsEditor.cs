using System;
using System.Drawing;
using System.Windows.Forms;
using static MediaConverter.Tools.Forms;
using static MediaConverter.Managers.ConfigManager;
using static MediaConverter.Data.Structure.ConfigStructure;

namespace MediaConverter.Forms
{
    public partial class SettingsEditor : Form
    {
        ConfigBase config = new ConfigBase();

        public SettingsEditor(ConfigBase config_)
        {
            InitializeComponent();

            config = config_;
        }

        private void SettingsEditor_Load(object sender, EventArgs e)
        {
            var colors = CalculateThemeButtonColors(config);
            ThemeColorPanel.BackColor = colors.Item1;
            SaveButton.ForeColor = colors.Item1;
            SaveButton.BackColor = colors.Item2;
            SaveButton.FlatAppearance.BorderColor = colors.Item3;

            #region loadTooltips
            // bind tooltips
            string[] tooltipMap = {
                "CloseButton", "Close",
                "ThemeColorPickerButton", "Open the color selector",
                "ThemeColorResetButton", "Reset the color to default",
                "SaveButton", "Apply settings"
            };

            // load tooltips
            for (int i = 0; i < tooltipMap.Length; i += 2)
                SettingsEditorToolTip.SetToolTip(Controls.Find(tooltipMap[i], true)[0], tooltipMap[i + 1]);

            // configure tooltip draw
            SettingsEditorToolTip.AutoPopDelay = 10000;
            SettingsEditorToolTip.InitialDelay = 500;
            SettingsEditorToolTip.ReshowDelay = 100;
            SettingsEditorToolTip.OwnerDraw = true;
            SettingsEditorToolTip.BackColor = Color.FromArgb(255, 30, 30, 30);
            SettingsEditorToolTip.ForeColor = Color.FromArgb(255, 150, 150, 150);
            #endregion
        }

        private void SettingsEditorToolTip_Draw(object sender, DrawToolTipEventArgs e)
        {
            e.DrawBackground();
            e.DrawBorder();
            e.DrawText();
        }

        private void ThemeColorPickerButton_Click(object sender, EventArgs e)
        {
            ColorDialog colorDialog = new ColorDialog();
            colorDialog.AnyColor = true;

            int r;
            int g;
            int b;

            if (colorDialog.ShowDialog() == DialogResult.OK)
            {
                r = Convert.ToInt32(colorDialog.Color.R);
                g = Convert.ToInt32(colorDialog.Color.G);
                b = Convert.ToInt32(colorDialog.Color.B);

                config.THEME_COLOR_R = r;
                config.THEME_COLOR_G = g;
                config.THEME_COLOR_B = b;

                var colors = CalculateThemeButtonColors(config);
                ThemeColorPanel.BackColor = colors.Item1;
                SaveButton.ForeColor = colors.Item1;
                SaveButton.BackColor = colors.Item2;
                SaveButton.FlatAppearance.BorderColor = colors.Item3;
            }
        }

        private void ThemeColorResetButton_Click(object sender, EventArgs e)
        {
            config.THEME_COLOR_R = 0;
            config.THEME_COLOR_G = 150;
            config.THEME_COLOR_B = 0;

            var colors = CalculateThemeButtonColors(config);
            ThemeColorPanel.BackColor = colors.Item1;
            SaveButton.ForeColor = colors.Item1;
            SaveButton.BackColor = colors.Item2;
            SaveButton.FlatAppearance.BorderColor = colors.Item3;
        }

        private void SaveButton_Click(object sender, EventArgs e)
        {
            WriteConfig(config);
            Close();
        }

        private void CloseButton_Click(object sender, EventArgs e)
        {
            Close();
        }

        private void TitlebarPanel_MouseDown(object sender, MouseEventArgs e)
        {
            MoveForm(Handle, e);
        }

        private void IconPictureBox_MouseDown(object sender, MouseEventArgs e)
        {
            MoveForm(Handle, e);
        }
    }
}