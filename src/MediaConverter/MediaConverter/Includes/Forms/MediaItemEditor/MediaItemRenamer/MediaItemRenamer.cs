using System;
using System.IO;
using System.Windows.Forms;
using static MediaConverter.Tools.Forms;
using static MediaConverter.Tools.Managers.MediaItemManager;
using static MediaConverter.Data.Structure.MediaStructure;
using static MediaConverter.Data.Structure.ConfigStructure;

namespace MediaConverter.Forms
{
    public partial class MediaItemRenamer : Form
    {
        public MediaItemData[] mediaItems { get; set; }
        bool isBulk = false;

        ConfigBase config = new ConfigBase();

        public string[] RenameValue { get; set; }

        public MediaItemRenamer(MediaItemData[] mediaItems_, ConfigBase config_)
        {
            InitializeComponent();

            if (mediaItems_.Length == 1)
            {
                mediaItems = new MediaItemData[1];
                mediaItems[0] = mediaItems_[0];
            }
            else
            {
                isBulk = true;
                mediaItems = new MediaItemData[mediaItems_.Length];
                for (int i = 0; i < mediaItems_.Length; i++)
                    mediaItems[i] = mediaItems_[i];
            }

            config = config_;
        }

        private void MediaItemRenamer_Load(object sender, EventArgs e)
        {
            RenameTextBox.Text = mediaItems[0].ITEM_IDENTIFIER;

            var colors = CalculateThemeButtonColors(config);
            SaveButton.ForeColor = colors.Item1;
            SaveButton.BackColor = colors.Item2;
            SaveButton.FlatAppearance.BorderColor = colors.Item3;
        }

        private void SaveButton_Click(object sender, EventArgs e)
        {
            if (isBulk == true)
            {
                RenameValue = new string[mediaItems.Length];

                for (int i = 0; i < mediaItems.Length; i++)
                {
                    string toFile = "MediaConverter\\queue\\" + RenameTextBox.Text + (i != 0 ? "_" + i : "") + ".mcitem";
                    if (File.Exists(toFile) == true)
                        continue;
                    else
                    {
                        File.Move("MediaConverter\\queue\\" + mediaItems[i].ITEM_IDENTIFIER + ".mcitem", toFile);

                        RenameValue[i] = RenameTextBox.Text + (i != 0 ? "_" + i : "");
                        mediaItems[i].ITEM_IDENTIFIER = RenameValue[i];
                        WriteMediaItem(mediaItems[i].ITEM_IDENTIFIER, mediaItems[i]);
                    }
                }

                Close();
            }
            else
            {
                RenameValue = new string[1];

                string toFile = "MediaConverter\\queue\\" + RenameTextBox.Text + ".mcitem";
                if (File.Exists(toFile) == true)
                    Close();
                else
                {
                    File.Move("MediaConverter\\queue\\" + mediaItems[0].ITEM_IDENTIFIER + ".mcitem", toFile);

                    RenameValue[0] = RenameTextBox.Text;
                    mediaItems[0].ITEM_IDENTIFIER = RenameValue[0];
                    WriteMediaItem(mediaItems[0].ITEM_IDENTIFIER, mediaItems[0]);
                    Close();
                }
            }
        }

        private void CloseButton_Click(object sender, EventArgs e)
        {
            RenameValue = new string[1];
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