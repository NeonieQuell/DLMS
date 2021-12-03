using System;
using System.Drawing;
using System.Windows.Forms;
using DLMS.CustomClasses;

namespace DLMS.Forms
{
    public partial class FormMainMenu : Form
    {
        public FormMainMenu()
        {
            InitializeComponent();

            labelStudName.Text = Student.FName;

            // Load FormHome on startup
            LoadForm(Singleton.FrmHome);
        }

        private void FormMainMenu_FormClosing(object sender, FormClosingEventArgs e)
        {
            Application.Exit();
        }

        // Method for loading forms inside the panel
        private void LoadForm(object Form)
        {
            if (panelContent.Controls.Count > 0)
                panelContent.Controls.RemoveAt(0);
            Form f = Form as Form;
            f.TopLevel = false;
            f.Dock = DockStyle.Fill;
            panelContent.Controls.Add(f);
            panelContent.Tag = f;
            f.Show();
        }

        #region Methods for making buttons to active/inactive state
        private void MakeHomeButtonActive()
        {
            panelHome.FillColor = Color.White;
            panelHome.Invalidate();
            pictureBoxHomeActive.Visible = true;
            pictureBoxHomeINActive.Visible = false;
            labelHome.Visible = false;
            panelHomeLine.Visible = true;
        }

        private void MakeHomeButtonINActive()
        {
            panelHome.FillColor = Color.Transparent;
            panelHome.Invalidate();
            pictureBoxHomeActive.Visible = false;
            pictureBoxHomeINActive.Visible = true;
            labelHome.Visible = true;
            panelHomeLine.Visible = false;
        }

        private void MakeLibraryButtonActive()
        {
            panelLibrary.FillColor = Color.White;
            panelLibrary.Invalidate();
            pictureBoxLibraryActive.Visible = true;
            pictureBoxLibraryINActive.Visible = false;
            labelLibrary.Visible = false;
            panelLibLine.Visible = true;
        }

        private void MakeLibraryButtonINActive()
        {
            panelLibrary.FillColor = Color.Transparent;
            panelLibrary.Invalidate();
            pictureBoxLibraryActive.Visible = false;
            pictureBoxLibraryINActive.Visible = true;
            labelLibrary.Visible = true;
            panelLibLine.Visible = false;
        }
        #endregion

        #region Events when home area is clicked
        private void panelHome_Click(object sender, EventArgs e)
        {
            LoadForm(Singleton.FrmHome);
            MakeHomeButtonActive();
            MakeLibraryButtonINActive();
        }

        private void pictureBoxHomeActive_Click(object sender, EventArgs e)
        {
            LoadForm(Singleton.FrmHome);
            MakeHomeButtonActive();
            MakeLibraryButtonINActive();
        }

        private void pictureBoxHomeINActive_Click(object sender, EventArgs e)
        {
            LoadForm(Singleton.FrmHome);
            MakeHomeButtonActive();
            MakeLibraryButtonINActive();
        }

        private void labelHome_Click(object sender, EventArgs e)
        {
            LoadForm(Singleton.FrmHome);
            MakeHomeButtonActive();
            MakeLibraryButtonINActive();
        }
        #endregion

        #region Events when library area is clicked
        private void panelLibrary_Click(object sender, EventArgs e)
        {
            LoadForm(Singleton.FrmLibrary);
            MakeHomeButtonINActive();
            MakeLibraryButtonActive();
        }

        private void pictureBoxLibraryActive_Click(object sender, EventArgs e)
        {
            LoadForm(Singleton.FrmLibrary);
            MakeHomeButtonINActive();
            MakeLibraryButtonActive();
        }

        private void pictureBoxLibraryINActive_Click(object sender, EventArgs e)
        {
            LoadForm(Singleton.FrmLibrary);
            MakeHomeButtonINActive();
            MakeLibraryButtonActive();
        }

        private void labelLibrary_Click(object sender, EventArgs e)
        {
            LoadForm(Singleton.FrmLibrary);
            MakeHomeButtonINActive();
            MakeLibraryButtonActive();
        }
        #endregion

        #region Events when profile is clicked
        private void panelProfile_Click(object sender, EventArgs e)
        {
            LoadForm(Singleton.FrmViewProfile);
            MakeHomeButtonINActive();
            MakeLibraryButtonINActive();
        }

        private void pictureBoxUser_Click(object sender, EventArgs e)
        {
            LoadForm(Singleton.FrmViewProfile);
            MakeHomeButtonINActive();
            MakeLibraryButtonINActive();
        }

        private void labelStudName_Click(object sender, EventArgs e)
        {
            LoadForm(Singleton.FrmViewProfile);
            MakeHomeButtonINActive();
            MakeLibraryButtonINActive();
        }
        #endregion

        #region Events when sign out is clicked
        private void VerifySignOut()
        {
            DialogResult dialog = MessageBox.Show("Are you sure you want to sign out?", "Confirm", MessageBoxButtons.YesNo, MessageBoxIcon.Question);

            if (dialog == DialogResult.Yes)
            {
                // Hide first the FrmMainMenu to avoid snappy animation
                Singleton.FrmMainMenu.Hide();

                // Free up the objects in singleton
                Singleton.FrmMainMenu = null;
                Singleton.FrmHome = null;
                Singleton.FrmLibrary = null;
                Singleton.FrmViewProfile = null;

                // Force garbage collection
                GC.Collect();

                //Show the main sign in form
                Singleton.FrmMainSignIn.Show();
            }
        }

        private void panelSignOut_Click(object sender, EventArgs e)
        {
            VerifySignOut();
        }

        private void labelSignOut_Click(object sender, EventArgs e)
        {
            VerifySignOut();
        }
        #endregion
    }
}
