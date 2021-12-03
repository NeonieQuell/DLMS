using System;
using System.Drawing;
using System.Runtime.InteropServices;
using System.Windows.Forms;

namespace DLMS.Forms
{
    public partial class FormHome : Form
    {
        // Make form rounded
        [DllImport("Gdi32.dll", EntryPoint = "CreateRoundRectRgn")]
        private static extern IntPtr CreateRoundRectRgn
        (
            int nLeftRect,     // x-coordinate of upper-left corner
            int nTopRect,      // y-coordinate of upper-left corner
            int nRightRect,    // x-coordinate of lower-right corner
            int nBottomRect,   // y-coordinate of lower-right corner
            int nWidthEllipse, // height of ellipse
            int nHeightEllipse // width of ellipse
        );

        public FormHome()
        {
            InitializeComponent();
            // Make form rounded
            FormBorderStyle = FormBorderStyle.None;
            Region = Region.FromHrgn(CreateRoundRectRgn(0, 0, Width, Height, 20, 20));

            #region Make labels in header as transparent
            labelHome.Parent = pictureBoxHeader;
            labelHome.BackColor = Color.Transparent;

            labelBeSTI.Parent = pictureBoxHeader;
            labelBeSTI.BackColor = Color.Transparent;

            labelBeFuture.Parent = pictureBoxHeader;
            labelBeFuture.BackColor = Color.Transparent; 
            #endregion
        }
    }
}
