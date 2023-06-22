using System;
using System.IO;
using System.Text;
using System.Linq;
using System.Drawing;
using System.Diagnostics;
using System.Windows.Forms;
using System.Collections.Generic;
using MediaConverter.Forms;
using static System.Windows.Forms.ListBox;
using static MediaConverter.Tools.Forms;
using static MediaConverter.Data.Storage;
using static MediaConverter.Managers.ConfigManager;
using static MediaConverter.Managers.ConvertManager;
using static MediaConverter.Managers.MediaItemManager;
using static MediaConverter.Data.Structure.MediaStructure;
using static MediaConverter.Data.Structure.ConfigStructure;

namespace MediaConverter
{
    public partial class Main : Form
    {
        public Main()
        {
            InitializeComponent();
        }

        ConfigBase config = new ConfigBase();
        Color themeColor = new Color();

        private void Main_Load(object sender, EventArgs e)
        {
            EnableLoadingIcon(true);

            // create necessary directories
            Directory.CreateDirectory("MediaConverter\\config");
            Directory.CreateDirectory("MediaConverter\\queue");
            Directory.CreateDirectory("MediaConverter\\working");
            Directory.CreateDirectory("Converts");

            // read configuration from file if it exists
            if (File.Exists("MediaConverter\\config\\config.mc"))
                config = ReadConfig();

            // create a default config file if it doesn't exist
            if (!File.Exists("MediaConverter\\config\\_base"))
            {
                config.QUEUE_ITEM_ORDER = "";
                config.QUEUE_ITEM_SELECTIONS = "";
                config.THEME_COLOR_R = 0;
                config.THEME_COLOR_G = 150;
                config.THEME_COLOR_B = 0;

                File.Create("MediaConverter\\config\\_base");
            }

            WriteConfig(config);

            // set theme color based on the config
            themeColor = Color.FromArgb(255, config.THEME_COLOR_R, config.THEME_COLOR_G, config.THEME_COLOR_B);
            // set the background color of the main panel
            MainPanel.BackColor = themeColor;

            // refresh the queue list
            RefreshQueue(true);
            // restore selected items in the queue list
            if (string.IsNullOrEmpty(config.QUEUE_ITEM_SELECTIONS) == false)
            {
                string[] selectedItems = config.QUEUE_ITEM_SELECTIONS.Split('ʃ');
                foreach (string itemText in selectedItems)
                {
                    for (int i = 0; i < QueueListBox.Items.Count; i++)
                    {
                        if (QueueListBox.GetItemText(QueueListBox.Items[i]) == itemText)
                        {
                            QueueListBox.SetSelected(i, true);
                            break;
                        }
                    }
                }
            }

            // update the label displaying the number of selected items
            UpdateSelectedLabel();

            // set the version label text and position
            VersionLabel.Text = "MediaConverter " + VERSION;
            VersionLabel.Location = new Point(Width - (VersionLabel.Width + 33), VersionLabel.Location.Y);

            #region loadTooltips
            // bind tooltips
            string[] tooltipMap = {
                "MinimizeButton", "Minimize",
                "CloseButton", "Close",

                "QueueAddMediaButton", "Add media",
                "QueueAddMediaFolderButton", "Add media from folder",

                "QueueConvertAllButton", "Convert all media",
                "QueueConvertSelectedButton", "Convert selected media",

                "QueueSelectAllButton", "Select all (A)",
                "QueueDeselectAllButton", "Deselect all (D)",
                "QueueSelectInvertButton", "Invert selection (I)",

                "QueueEditButton", "Open media editor",
                "QueueRenameButton", "Open the media renamer",

                "QueueRemoveAllButton", "De-queue all media",
                "QueueRemoveSelectedButton", "De-queue selected media (Delete)",

                "QueueOpenMediaLocationButton", "Open locations to selected media in Windows Explorer (limited to 10 selections)",

                "SettingsButton", "Open the options window",

                "QueueRefreshButton", "Reload the queue",
                "QueueSelectionMoveDownButton", "Move selected media down (Down Arrow)",
                "QueueSelectionMoveUpButton", "Move selected media up (Up Arrow)"
            };

            // load tooltips
            for (int i = 0; i < tooltipMap.Length; i += 2)
                MainToolTip.SetToolTip(Controls.Find(tooltipMap[i], true)[0], tooltipMap[i + 1]);

            // configure tooltip draw
            MainToolTip.AutoPopDelay = 10000;
            MainToolTip.InitialDelay = 500;
            MainToolTip.ReshowDelay = 100;
            MainToolTip.OwnerDraw = true;
            MainToolTip.BackColor = Color.FromArgb(255, 15, 15, 15);
            MainToolTip.ForeColor = Color.FromArgb(255, 150, 150, 150);
            #endregion

            EnableLoadingIcon(false);
        }

        private void MainToolTip_Draw(object sender, DrawToolTipEventArgs e)
        {
            e.DrawBackground();
            e.DrawBorder();
            e.DrawText();
        }

        private void QueueListBox_DrawItem(object sender, DrawItemEventArgs e)
        {
            // code forked from: https://stackoverflow.com/a/3709452
            // custom drawing for queue list box items
            e.DrawBackground();
            bool selected = (e.State & DrawItemState.Selected) == DrawItemState.Selected;

            int index = e.Index;
            if (index >= 0 && index < QueueListBox.Items.Count)
            {
                Graphics g = e.Graphics;

                SolidBrush backgroundBrush;
                if (selected)
                    backgroundBrush = new SolidBrush(themeColor);
                else if ((index % 2) == 0)
                    backgroundBrush = new SolidBrush(Color.FromArgb(255, 20, 20, 20));
                else
                    backgroundBrush = new SolidBrush(Color.FromArgb(255, 15, 15, 15));
                g.FillRectangle(backgroundBrush, e.Bounds);

                string text = QueueListBox.Items[index].ToString();
                g.DrawString(text, e.Font, new SolidBrush(Color.FromArgb(255, 225, 225, 225)), QueueListBox.GetItemRectangle(index).Location);
            }
            //
        }

        private void QueueConvertAllButton_Click(object sender, EventArgs e)
        {
            // convert all media items in the queue
            if (QueueListBox.Items.Count == 0) return;

            EnableLoadingIcon(true);

            string[] mediaItems = new string[QueueListBox.Items.Count];
            for (int i = 0; i < QueueListBox.Items.Count; i++)
                mediaItems[i] = QueueListBox.Items[i].ToString();

            ConvertMediaItems(mediaItems, false);

            EnableLoadingIcon(false);
        }

        private void QueueConvertSelectedButton_Click(object sender, EventArgs e)
        {
            // convert selected media items in the queue
            if (QueueListBox.SelectedItems.Count == 0) return;

            EnableLoadingIcon(true);

            string[] mediaItems = SelectedItemsToArray(QueueListBox.SelectedItems);
            ConvertMediaItems(mediaItems, false);

            EnableLoadingIcon(false);
        }

        private void QueueAddMediaButton_Click(object sender, EventArgs e)
        {
            EnableLoadingIcon(true);

            // open file dialog to select media files
            OpenFileDialog openFileDialog = new OpenFileDialog();
            openFileDialog.Filter = "All Files (*.*)|*.*";
            openFileDialog.Multiselect = true;

            DialogResult result = openFileDialog.ShowDialog();

            if (result == DialogResult.OK)
            {
                string[] mediaItems = openFileDialog.FileNames;
                QueueAddMediaItems(mediaItems);
            }

            UpdateSelectedLabel();

            EnableLoadingIcon(false);
        }

        private void QueueAddMediaFolderButton_Click(object sender, EventArgs e)
        {
            EnableLoadingIcon(true);

            // open folder dialog to select a folder
            using (OpenFileDialog selectFolderDialog = new OpenFileDialog())
            {
                selectFolderDialog.Multiselect = false;
                selectFolderDialog.CheckFileExists = false;
                selectFolderDialog.CheckPathExists = true;
                selectFolderDialog.FileName = "Select a folder";
                selectFolderDialog.Filter = "Directories|Folders";
                DialogResult result = selectFolderDialog.ShowDialog();

                if (result == DialogResult.OK)
                {
                    string folderPath = Path.GetDirectoryName(selectFolderDialog.FileName);
                    string[] mediaItems = Directory.GetFiles(folderPath);
                    QueueAddMediaItems(mediaItems);
                }
            }

            UpdateSelectedLabel();

            EnableLoadingIcon(false);
        }

        private void QueueSelectAllButton_Click(object sender, EventArgs e)
        {
            EnableLoadingIcon(true);

            QueueSelectAll();

            EnableLoadingIcon(false);
        }

        private void QueueSelectAll()
        {
            for (int i = 0; i < QueueListBox.Items.Count; i++)
                QueueListBox.SetSelected(i, true);

            UpdateSelectedLabel();
        }

        private void QueueDeselectAllButton_Click(object sender, EventArgs e)
        {
            EnableLoadingIcon(true);

            QueueDeselectAll();

            EnableLoadingIcon(false);
        }

        private void QueueDeselectAll()
        {
            for (int i = 0; i < QueueListBox.Items.Count; i++)
                QueueListBox.SetSelected(i, false);

            UpdateSelectedLabel();
        }

        private void QueueSelectInvertButton_Click(object sender, EventArgs e)
        {
            EnableLoadingIcon(true);

            QueueSelectInvert();

            EnableLoadingIcon(false);
        }

        private void QueueSelectInvert()
        {
            for (int i = 0; i < QueueListBox.Items.Count; i++)
            {
                if (QueueListBox.GetSelected(i) == true)
                    QueueListBox.SetSelected(i, false);
                else
                    QueueListBox.SetSelected(i, true);
            }

            UpdateSelectedLabel();
        }

        private void QueueEditButton_Click(object sender, EventArgs e)
        {
            if (QueueListBox.SelectedItems.Count == 0) return;

            EnableLoadingIcon(true);

            if (QueueListBox.SelectedItems.Count == 1)
            {
                // read the settings of the selected media item
                MediaItemData[] mediaSettings = new MediaItemData[1];
                mediaSettings[0] = ReadMediaItem(QueueListBox.SelectedItem.ToString());
                if (mediaSettings[0].INPUT_FILE == null) return;

                // display a window to edit the settings of the single media item
                MediaItemEditor mediaEditor = new MediaItemEditor(mediaSettings, config);
                mediaEditor.ShowDialog();
            }
            else
            {
                // read the settings of the selected media items
                MediaItemData[] mediaSettings = new MediaItemData[QueueListBox.SelectedItems.Count];

                int index = 0;
                foreach (string item in QueueListBox.SelectedItems)
                {
                    mediaSettings[index] = ReadMediaItem(item);
                    index++;
                }
                if (mediaSettings[0].INPUT_FILE == null) return;

                // display a window to edit the settings of the selected media items
                MediaItemEditor mediaEditor = new MediaItemEditor(mediaSettings, config);
                mediaEditor.ShowDialog();
            }

            EnableLoadingIcon(false);
        }

        private void QueueRenameButton_Click(object sender, EventArgs e)
        {
            if (QueueListBox.SelectedItems.Count == 0) return;

            EnableLoadingIcon(true);

            if (QueueListBox.SelectedItems.Count == 1)
                QueueRenameSingle();
            else
            {
                #region storeSelectedIndices
                // define a List to store the selected indices
                List<int> selectedIndices = new List<int>();
                // store the selected indices
                foreach (int indiceStore in QueueListBox.SelectedIndices)
                    selectedIndices.Add(indiceStore);
                #endregion

                // read the settings of the selected media items
                MediaItemData[] mediaItems = new MediaItemData[QueueListBox.SelectedItems.Count];

                int index = 0;
                foreach (string item in QueueListBox.SelectedItems)
                {
                    mediaItems[index] = ReadMediaItem(item);
                    index++;
                }
                if (mediaItems[0].INPUT_FILE == null) return;

                // display a window to rename the selected media items
                MediaItemRenamer itemRenamer = new MediaItemRenamer(mediaItems, config);
                itemRenamer.ShowDialog();

                if (itemRenamer.RenameValue[0] != null)
                {
                    // create a copy of the selected items
                    List<string> selectedItems = QueueListBox.SelectedItems.Cast<string>().ToList();

                    // iterate over the selected items and retrieve their indices
                    for (int i = 0; i < selectedItems.Count; i++)
                    {
                        int itemIndex = QueueListBox.Items.IndexOf(selectedItems[i]);
                        QueueListBox.Items[itemIndex] = itemRenamer.RenameValue[i];
                    }
                }

                #region readSelectedIndices
                // reselect the items from the stored indices
                foreach (int indiceRead in selectedIndices)
                {
                    if (indiceRead >= 0 && indiceRead < QueueListBox.Items.Count)
                        QueueListBox.SetSelected(indiceRead, true);
                }
                #endregion
            }

            EnableLoadingIcon(false);
        }
        private void QueueRenameSingle()
        {
            // read the settings of the selected media item
            MediaItemData[] mediaItems = new MediaItemData[1];
            mediaItems[0] = ReadMediaItem(QueueListBox.SelectedItem.ToString());
            if (mediaItems[0].INPUT_FILE == null) return;

            // open the media item renamer window
            MediaItemRenamer itemRenamer = new MediaItemRenamer(mediaItems, config);
            itemRenamer.ShowDialog();

            if (itemRenamer.RenameValue[0] != null)
                QueueListBox.Items[QueueListBox.SelectedIndex] = itemRenamer.RenameValue[0];
        }

        private void QueueRemoveAllButton_Click(object sender, EventArgs e)
        {
            EnableLoadingIcon(true);

            // create a list to store the items to be removed
            List<object> itemsToRemove = new List<object>();

            // iterate over the items and add them to the removal list
            foreach (var item in QueueListBox.Items)
                itemsToRemove.Add(item);

            // remove the items from the list
            foreach (var itemToRemove in itemsToRemove)
            {
                QueueListBox.Items.Remove(itemToRemove);
                string itemFile = itemToRemove.ToString();

                // delete corresponding mediaitem file
                File.Delete("MediaConverter\\queue\\" + itemFile + ".mcitem");
            }

            UpdateSelectedLabel();

            EnableLoadingIcon(false);
        }

        private void QueueRemoveSelectedButton_Click(object sender, EventArgs e)
        {
            EnableLoadingIcon(true);

            QueueRemovedSelected();

            EnableLoadingIcon(false);
        }

        private void QueueRemovedSelected()
        {
            var itemsToRemove = new List<object>();

            // create a list of selected items to remove
            foreach (var selectedItem in QueueListBox.SelectedItems)
                itemsToRemove.Add(selectedItem);

            // remove selected items from the queue and delete associated files
            foreach (var selectedItem in itemsToRemove)
            {
                QueueListBox.Items.Remove(selectedItem);
                string itemFile = selectedItem.ToString();
                File.Delete("MediaConverter\\queue\\" + itemFile + ".mcitem");
            }

            // set the selected index to 0 if there is at least 1 item in the queue
            if (QueueListBox.Items.Count >= 1 == true)
                QueueListBox.SelectedIndex = 0;

            UpdateSelectedLabel();
        }

        private void QueueOpenMediaLocationButton_Click(object sender, EventArgs e)
        {
            EnableLoadingIcon(true);

            int maxOpens = 10;
            int openIndex = 1;
            string[] mediaItems = SelectedItemsToArray(QueueListBox.SelectedItems);

            // open the media locations in Windows Explorer, limited to a maximum number of opens
            foreach (string mediaItem in mediaItems)
            {
                if (openIndex == maxOpens)
                    return;
                Process.Start("explorer.exe", "/select, " + ReadMediaItem(mediaItem).INPUT_FILE_PATH);
                openIndex++;
            }

            EnableLoadingIcon(false);
        }

        private void SettingsButton_Click(object sender, EventArgs e)
        {
            EnableLoadingIcon(true);

            // open the settings editor window
            SettingsEditor settingsEditor = new SettingsEditor(config);
            settingsEditor.ShowDialog();

            // read the updated configuration
            config = ReadConfig();

            // update the theme color and panel background color
            themeColor = Color.FromArgb(255, config.THEME_COLOR_R, config.THEME_COLOR_G, config.THEME_COLOR_B);
            MainPanel.BackColor = themeColor;

            QueueListBox.Refresh();

            EnableLoadingIcon(false);
        }

        private void SettingsButton_MouseDown(object sender, MouseEventArgs e)
        {
            if (e.Button == MouseButtons.Right)
                Process.Start("explorer.exe", "MediaConverter\\queue");
        }

        private void QueueSelectionMoveDownButton_Click(object sender, EventArgs e)
        {
            EnableLoadingIcon(true);

            MoveQueueItemsDown();

            EnableLoadingIcon(false);
        }

        private void QueueSelectionMoveUpButton_Click(object sender, EventArgs e)
        {
            EnableLoadingIcon(true);

            MoveQueueItemsUp();

            EnableLoadingIcon(false);
        }

        private void QueueListBox_PreviewKeyDown(object sender, PreviewKeyDownEventArgs e)
        {
            switch (e.KeyCode)
            {
                case Keys.Up: MoveQueueItemsUp(); break;
                case Keys.Down: MoveQueueItemsDown(); break;
                case Keys.A: QueueSelectAll(); break;
                case Keys.D: QueueDeselectAll(); break;
                case Keys.I: QueueSelectInvert(); break;
                case Keys.Delete: QueueRemovedSelected(); break;
            }
        }

        private void QueueRefreshButton_Click(object sender, EventArgs e)
        {
            RefreshQueue(false);
        }

        private void MoveQueueItemsDown()
        {
            SelectedObjectCollection selectedItems = QueueListBox.SelectedItems;

            // move the selected queue items down one position
            for (int i = selectedItems.Count - 1; i >= 0; i--)
            {
                int selectedIndex = QueueListBox.SelectedIndices[i];
                if (selectedIndex < QueueListBox.Items.Count - 1)
                {
                    object selectedItem = selectedItems[i];
                    QueueListBox.Items.RemoveAt(selectedIndex);
                    QueueListBox.Items.Insert(selectedIndex + 1, selectedItem);
                    QueueListBox.SetSelected(selectedIndex + 1, true);
                }
            }

            UpdateSelectedLabel();
        }

        private void MoveQueueItemsUp()
        {
            SelectedObjectCollection selectedItems = QueueListBox.SelectedItems;

            // move the selected queue items up one position
            for (int i = 0; i < selectedItems.Count; i++)
            {
                int selectedIndex = QueueListBox.SelectedIndices[i];
                if (selectedIndex > 0)
                {
                    object selectedItem = selectedItems[i];
                    QueueListBox.Items.RemoveAt(selectedIndex);
                    QueueListBox.Items.Insert(selectedIndex - 1, selectedItem);
                    QueueListBox.SetSelected(selectedIndex - 1, true);
                }
            }

            UpdateSelectedLabel();
        }

        bool queueListBoxWasSelected = false;
        private void QueueListBox_MouseClick(object sender, MouseEventArgs e)
        {
            EnableLoadingIcon(true);

            int clickedIndex = QueueListBox.IndexFromPoint(e.Location);
            if (clickedIndex != NoMatches && QueueListBox.SelectedIndices.Contains(clickedIndex))
                queueListBoxWasSelected = false;
            else
                queueListBoxWasSelected = true;

            UpdateSelectedLabel();

            EnableLoadingIcon(false);
        }
        private void QueueListBox_MouseDoubleClick(object sender, MouseEventArgs e)
        {
            // deselect the current item when double-clicked
            int clickedIndex = QueueListBox.IndexFromPoint(e.Location);
            if (clickedIndex == -1) return;

            EnableLoadingIcon(true);

            MediaItemData[] mediaSettings = new MediaItemData[1];
            mediaSettings[0] = ReadMediaItem(QueueListBox.Items[clickedIndex].ToString());

            // deselect the current item when double-clicked
            if (queueListBoxWasSelected == true)
                QueueListBox.SetSelected(clickedIndex, true);
            else
                QueueListBox.SetSelected(clickedIndex, false);

            // display window with mediaSettings
            MediaItemEditor mediaEditor = new MediaItemEditor(mediaSettings, config);
            mediaEditor.ShowDialog();

            UpdateSelectedLabel();

            EnableLoadingIcon(false);
        }
        private void QueueListBox_MouseDown(object sender, MouseEventArgs e)
        {
            if (QueueListBox.SelectedIndex == -1)
                return;

            if (e.Button == MouseButtons.Right)
                QueueRenameSingle();
        }

        private void QueueListBox_DragDrop(object sender, DragEventArgs e)
        {
            EnableLoadingIcon(true);

            string[] fileList = (string[])e.Data.GetData(DataFormats.FileDrop, false);
            QueueAddMediaItems(fileList);

            QueueListBox.BackColor = Color.FromArgb(255, 15, 15, 15);

            UpdateSelectedLabel();

            EnableLoadingIcon(false);
        }

        private void QueueListBox_DragEnter(object sender, DragEventArgs e)
        {
            if (e.Data.GetDataPresent(DataFormats.FileDrop))
                e.Effect = DragDropEffects.Copy;
            else
                e.Effect = DragDropEffects.None;

            QueueListBox.BackColor = Color.FromArgb(255, 20, 20, 20);
        }

        private void QueueListBox_DragLeave(object sender, EventArgs e)
        {
            QueueListBox.BackColor = Color.FromArgb(255, 15, 15, 15);
        }

        private void QueueAddMediaItems(string[] mediaItems)
        {
            for (int i = 0; i < mediaItems.Length; i++)
            {
                MediaItemData mediaItem = new MediaItemData();

                mediaItem.ITEM_IDENTIFIER = Path.GetFileName(mediaItems[i]);

                mediaItem.INPUT_FILE_PATH = mediaItems[i];
                mediaItem.INPUT_FILE = Path.GetFileName(mediaItems[i]);
                mediaItem.INPUT_FILE_NAME = Path.GetFileNameWithoutExtension(mediaItems[i]);

                // OUTPUT SETTINGS
                mediaItem.OUTPUT_FILE_NAME = Path.GetFileNameWithoutExtension(mediaItems[i]);
                mediaItem.OUTPUT_FILE_PATH = "";
                //

                // CODEC SETTINGS
                mediaItem.OUTPUT_FORMAT = "mp4";
                mediaItem.OUTPUT_FORMAT_TYPE = "VIDEO_OR_AUDIO_BASIC";
                mediaItem.OUTPUT_FORMAT_PREPROCESSOR = "mp4";
                mediaItem.OUTPUT_FORMAT_IS_IMAGE_SEQUENCE = false;

                mediaItem.OUTPUT_VIDEO_CODEC = "libx264";
                mediaItem.OUTPUT_AUDIO_CODEC = "aac";

                mediaItem.OUTPUT_VIDEO_BITRATE = "100M";
                mediaItem.OUTPUT_AUDIO_BITRATE = "320K";

                mediaItem.OUTPUT_USE_RESIZE_VIDEO = false;
                mediaItem.OUTPUT_VIDEO_WIDTH = "1920";
                mediaItem.OUTPUT_VIDEO_HEIGHT = "1080";

                mediaItem.OUTPUT_USE_CHANGE_FRAMERATE = false;
                mediaItem.OUTPUT_VIDEO_FRAMERATE = "60";

                mediaItem.OUTPUT_USE_TIMEFRAME = false;
                mediaItem.OUTPUT_TIMEFRAME_START = "0:00";
                mediaItem.OUTPUT_TIMEFRAME_END = "0:10";

                WriteMediaItem(mediaItem.ITEM_IDENTIFIER, mediaItem);
            }

            RefreshQueue(false);
        }

        private void RefreshQueue(bool sortOnly)
        {
            EnableLoadingIcon(true);

            if (sortOnly == true)
            {
                if (string.IsNullOrEmpty(config.QUEUE_ITEM_ORDER))
                    return;

                string[] items = config.QUEUE_ITEM_ORDER.Split('ʃ');

                QueueListBox.Items.Clear();
                QueueListBox.Items.AddRange(items);

                return;
            }

            QueueListBox.Items.Clear();

            // load keys into array
            string[] files = Directory.GetFiles("MediaConverter\\queue");
            foreach (string file in files)
            {
                string path = "MediaConverter\\queue\\" + new FileInfo(file).Name;
                QueueListBox.Items.Add(Path.GetFileNameWithoutExtension(path));
            }

            UpdateSelectedLabel();

            EnableLoadingIcon(false);
        }

        private void EnableLoadingIcon(bool enable)
        {
            LoadingIconPictureBox.Visible = enable;
        }

        private void UpdateSelectedLabel()
        {
            string items = QueueListBox.Items.Count > 1 || QueueListBox.Items.Count == 0 ? " items" : " item";
            string selectedItem = "";
            if (QueueListBox.SelectedIndex != -1 && QueueListBox.SelectedItems.Count <= 1)
                selectedItem = "  |  " + ReadMediaItem(QueueListBox.SelectedItem.ToString()).INPUT_FILE;
            QueueSelectedLabel.Text = QueueListBox.Items.Count + items + "  |  " + QueueListBox.SelectedItems.Count + " selected" + selectedItem;
        }

        private void MinimizeButton_Click(object sender, EventArgs e)
        {
            WindowState = FormWindowState.Minimized;
        }

        private void CloseButton_Click(object sender, EventArgs e)
        {
            #region itemOrder
            StringBuilder sb_item_order = new StringBuilder();

            foreach (var item in QueueListBox.Items)
            {
                sb_item_order.Append(item.ToString());
                sb_item_order.Append("ʃ");
            }

            // remove the last 'ʃ' character
            if (sb_item_order.Length > 0)
                sb_item_order.Length--;

            config.QUEUE_ITEM_ORDER = sb_item_order.ToString();
            #endregion

            #region itemSelections
            StringBuilder sb_item_selections = new StringBuilder();

            foreach (var item in QueueListBox.SelectedItems)
            {
                sb_item_selections.Append(item.ToString());
                sb_item_selections.Append("ʃ");
            }

            // remove the last 'ʃ' character
            if (sb_item_selections.Length > 0)
                sb_item_selections.Length--;

            config.QUEUE_ITEM_SELECTIONS = sb_item_selections.ToString();
            #endregion

            WriteConfig(config);
            Close();
        }

        private void IconPictureBox_MouseDown(object sender, MouseEventArgs e)
        {
            MoveForm(Handle, e);
        }

        private void TitlebarPanel_MouseDown(object sender, MouseEventArgs e)
        {
            MoveForm(Handle, e);
        }

        private void Menubar1Panel_MouseDown(object sender, MouseEventArgs e)
        {
            MoveForm(Handle, e);
        }

        private void LoadingIconPictureBox_MouseDown(object sender, MouseEventArgs e)
        {
            MoveForm(Handle, e);
        }
    }
}