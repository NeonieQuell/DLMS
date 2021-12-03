using System;
using System.Windows.Forms;
using DLMS.CustomClasses;

namespace DLMS.Forms.Office365SignIn
{
    public partial class FormOfficeSignIn_Password : Form
    {
        public FormOfficeSignIn_Password()
        {
            InitializeComponent();
            labelEmail.Text = InputCredentials.Email;
        }

        private void FormOfficeSignIn_Password_FormClosing(object sender, FormClosingEventArgs e)
        {
            Singleton.FrmMainSignIn.Enabled = true;
            Dispose();
        }

        #region Textbox Placeholder
        private void textboxPassword_Enter(object sender, EventArgs e)
        {
            if (textboxPassword.Texts.Equals("Password"))
                textboxPassword.Texts = "";

            textboxPassword.PasswordChar = true;
        }
        #endregion

        private void pictureBoxBackButton_Click(object sender, EventArgs e)
        {
            new FormOfficeSignIn_Email().Show();
            Dispose();
        }

        private void buttonSignIn_Click(object sender, EventArgs e)
        {
            if (!textboxPassword.Texts.Equals("Password"))
            {
                InputCredentials.Password = textboxPassword.Texts;

                if (Singleton.DBHandler.VerifyLogIn(InputCredentials.Email, InputCredentials.Password))
                {
                    MessageBox.Show("Log In Success!", "Message", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    //Fetch data of student on successful log in
                    Singleton.DBHandler.FetchDataStudent();
                    Singleton.FrmMainMenu.Show();
                    Singleton.FrmMainSignIn.Hide();
                    Singleton.FrmMainSignIn.Enabled = true;
                    Dispose();
                }
                else
                {
                    MessageBox.Show("Log In Failed!", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    pictureBoxBackButton_Click(sender, e);
                }
            }
            else
                MessageBox.Show("Please enter your password", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
        }
    }
}