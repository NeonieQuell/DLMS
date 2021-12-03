using System.Windows.Forms;
using DLMS.CustomClasses;

namespace DLMS.Forms.Office365SignIn
{
    public partial class FormOfficeSignIn_Email : Form
    {
        public FormOfficeSignIn_Email()
        {  
            InitializeComponent();
        }

        private void FormOfficeSignIn_FormClosing(object sender, FormClosingEventArgs e)
        {
            Singleton.FrmMainSignIn.Enabled = true;
            Dispose();
        }

        #region Textbox Placeholder
        private void textboxEmail_Enter(object sender, System.EventArgs e)
        {
            if (textboxEmail.Texts.Equals("Email, phone, or Skype"))
                textboxEmail.Texts = "";
        }

        private void textboxEmail_Leave(object sender, System.EventArgs e)
        {
            if (textboxEmail.Texts.Equals(""))
                textboxEmail.Texts = "Email, phone, or Skype";
        } 
        #endregion

        private void buttonNext_Click(object sender, System.EventArgs e)
        {
            if (!textboxEmail.Texts.Equals("Email, phone, or Skype"))
            {
                InputCredentials.Email = textboxEmail.Texts;
                new FormOfficeSignIn_Password().Show();
                Dispose();
            }
            else
                MessageBox.Show("Please enter your email", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
        }
    }
}