using System.Drawing;
using System.Windows.Forms;

namespace DLMS.Forms
{
    public partial class FormMainSignIn : Form
    {
        public FormMainSignIn()
        {
            InitializeComponent();

            #region Make Labels Transparent
            var lbFAQ = PointToScreen(labelFAQ.Location);
            lbFAQ = pictureBoxStudents.PointToClient(lbFAQ);
            labelFAQ.Parent = pictureBoxStudents;
            labelFAQ.Location = lbFAQ;
            labelFAQ.BackColor = Color.Transparent;

            var lbSTIeLMS = PointToScreen(labelSTIeLMS.Location);
            lbSTIeLMS = pictureBoxStudents.PointToClient(lbSTIeLMS);
            labelSTIeLMS.Parent = pictureBoxStudents;
            labelSTIeLMS.Location = lbSTIeLMS;
            labelSTIeLMS.BackColor = Color.Transparent;

            var lbONESTI = PointToScreen(labelONESTI.Location);
            lbONESTI = pictureBoxStudents.PointToClient(lbONESTI);
            labelONESTI.Parent = pictureBoxStudents;
            labelONESTI.Location = lbONESTI;
            labelONESTI.BackColor = Color.Transparent;
            #endregion
        }

        private void FormMainSignIn_FormClosing(object sender, FormClosingEventArgs e)
        { 
            Application.Exit();
        }

        private void buttonSignIn_Click(object sender, System.EventArgs e)
        {
            // Display office 365 Sign-in
            new Office365SignIn.FormOfficeSignIn_Email().Show();

            // Disable the FormMainSignIn temporarily
            Enabled = false;
        }


    }
}
