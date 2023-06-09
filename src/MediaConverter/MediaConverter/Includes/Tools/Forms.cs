using System;
using System.Drawing;
using System.Windows.Forms;
using System.Runtime.InteropServices;

namespace MediaConverter.Tools
{
    public static class Forms
    {
        // constants for mouse window events
        public const int HT_CAPTION = 0x2;
        public const int WM_NCLBUTTONDOWN = 0xA1;

        // import the SendMessage and ReleaseCapture functions from user32.dll
        [DllImport("user32.dll")]
        public static extern int SendMessage(IntPtr hWnd, int Msg, int wParam, int lParam);
        [DllImport("user32.dll")]
        public static extern bool ReleaseCapture();

        // method to move the form when the mouse is clicked and dragged
        public static void MoveForm(IntPtr handle, MouseEventArgs e)
        {
            if (e.Button == MouseButtons.Left)
            {
                ReleaseCapture();
                SendMessage(handle, WM_NCLBUTTONDOWN, HT_CAPTION, 0);
            }
        }

        public static void DrawComboBox(object sender, DrawItemEventArgs e, Color backColor, Color textColor, Color highlightColor)
        {
            // code forked from: https://stackoverflow.com/a/11650321
            var combo = sender as ComboBox;

            if ((e.State & DrawItemState.Selected) == DrawItemState.Selected)
                e.Graphics.FillRectangle(new SolidBrush(highlightColor), e.Bounds);
            else
                e.Graphics.FillRectangle(new SolidBrush(backColor), e.Bounds);

            e.Graphics.DrawString(combo.Items[e.Index].ToString(), e.Font, new SolidBrush(textColor), new Point(e.Bounds.X, e.Bounds.Y));
            //
        }
    }
}