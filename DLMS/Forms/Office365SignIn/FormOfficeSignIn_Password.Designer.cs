
namespace DLMS.Forms.Office365SignIn
{
    partial class FormOfficeSignIn_Password
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FormOfficeSignIn_Password));
            this.labelForgotMyPass = new System.Windows.Forms.Label();
            this.labelEnterPass = new System.Windows.Forms.Label();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.labelEmail = new System.Windows.Forms.Label();
            this.pictureBoxBackButton = new System.Windows.Forms.PictureBox();
            this.textboxPassword = new DLMS.CustomControls.CustomTextbox();
            this.buttonSignIn = new DLMS.CustomControls.CustomButton();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBoxBackButton)).BeginInit();
            this.SuspendLayout();
            // 
            // labelForgotMyPass
            // 
            this.labelForgotMyPass.AutoSize = true;
            this.labelForgotMyPass.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelForgotMyPass.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(47)))), ((int)(((byte)(131)))), ((int)(((byte)(197)))));
            this.labelForgotMyPass.Location = new System.Drawing.Point(34, 188);
            this.labelForgotMyPass.Name = "labelForgotMyPass";
            this.labelForgotMyPass.Size = new System.Drawing.Size(130, 16);
            this.labelForgotMyPass.TabIndex = 3;
            this.labelForgotMyPass.Text = "Forgot my password";
            // 
            // labelEnterPass
            // 
            this.labelEnterPass.AutoSize = true;
            this.labelEnterPass.Font = new System.Drawing.Font("Microsoft YaHei", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelEnterPass.Location = new System.Drawing.Point(31, 87);
            this.labelEnterPass.Name = "labelEnterPass";
            this.labelEnterPass.Size = new System.Drawing.Size(201, 31);
            this.labelEnterPass.TabIndex = 1;
            this.labelEnterPass.Text = "Enter Password";
            // 
            // pictureBox1
            // 
            this.pictureBox1.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox1.Image")));
            this.pictureBox1.Location = new System.Drawing.Point(38, 1);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(110, 44);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pictureBox1.TabIndex = 13;
            this.pictureBox1.TabStop = false;
            // 
            // labelEmail
            // 
            this.labelEmail.AutoSize = true;
            this.labelEmail.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelEmail.ForeColor = System.Drawing.Color.DimGray;
            this.labelEmail.Location = new System.Drawing.Point(59, 55);
            this.labelEmail.Name = "labelEmail";
            this.labelEmail.Size = new System.Drawing.Size(45, 18);
            this.labelEmail.TabIndex = 0;
            this.labelEmail.Text = "Email";
            // 
            // pictureBoxBackButton
            // 
            this.pictureBoxBackButton.Image = ((System.Drawing.Image)(resources.GetObject("pictureBoxBackButton.Image")));
            this.pictureBoxBackButton.Location = new System.Drawing.Point(37, 56);
            this.pictureBoxBackButton.Name = "pictureBoxBackButton";
            this.pictureBoxBackButton.Size = new System.Drawing.Size(16, 17);
            this.pictureBoxBackButton.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pictureBoxBackButton.TabIndex = 21;
            this.pictureBoxBackButton.TabStop = false;
            this.pictureBoxBackButton.Click += new System.EventHandler(this.pictureBoxBackButton_Click);
            // 
            // textboxPassword
            // 
            this.textboxPassword.BackColor = System.Drawing.SystemColors.Window;
            this.textboxPassword.BorderColor = System.Drawing.Color.DarkGray;
            this.textboxPassword.BorderColorFocusColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(103)))), ((int)(((byte)(184)))));
            this.textboxPassword.BorderSize = 1;
            this.textboxPassword.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.textboxPassword.ForeColor = System.Drawing.Color.DimGray;
            this.textboxPassword.IsFocused = false;
            this.textboxPassword.Location = new System.Drawing.Point(37, 130);
            this.textboxPassword.Margin = new System.Windows.Forms.Padding(4);
            this.textboxPassword.Multiline = false;
            this.textboxPassword.Name = "textboxPassword";
            this.textboxPassword.Padding = new System.Windows.Forms.Padding(7);
            this.textboxPassword.PasswordChar = false;
            this.textboxPassword.Size = new System.Drawing.Size(379, 35);
            this.textboxPassword.TabIndex = 2;
            this.textboxPassword.TabStop = false;
            this.textboxPassword.Texts = "Password";
            this.textboxPassword.UnderlinedStyle = true;
            this.textboxPassword.Enter += new System.EventHandler(this.textboxPassword_Enter);
            // 
            // buttonSignIn
            // 
            this.buttonSignIn.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(103)))), ((int)(((byte)(184)))));
            this.buttonSignIn.BackgroundColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(103)))), ((int)(((byte)(184)))));
            this.buttonSignIn.BorderColor = System.Drawing.Color.PaleVioletRed;
            this.buttonSignIn.BorderRadius = 0;
            this.buttonSignIn.BorderSize = 0;
            this.buttonSignIn.FlatAppearance.BorderSize = 0;
            this.buttonSignIn.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.buttonSignIn.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.buttonSignIn.FontColor = System.Drawing.Color.White;
            this.buttonSignIn.ForeColor = System.Drawing.Color.White;
            this.buttonSignIn.Location = new System.Drawing.Point(287, 229);
            this.buttonSignIn.Name = "buttonSignIn";
            this.buttonSignIn.Size = new System.Drawing.Size(106, 32);
            this.buttonSignIn.TabIndex = 4;
            this.buttonSignIn.Text = "Sign In";
            this.buttonSignIn.UseVisualStyleBackColor = false;
            this.buttonSignIn.Click += new System.EventHandler(this.buttonSignIn_Click);
            // 
            // FormOfficeSignIn_Password
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.ClientSize = new System.Drawing.Size(446, 308);
            this.Controls.Add(this.pictureBoxBackButton);
            this.Controls.Add(this.labelEmail);
            this.Controls.Add(this.textboxPassword);
            this.Controls.Add(this.buttonSignIn);
            this.Controls.Add(this.labelForgotMyPass);
            this.Controls.Add(this.labelEnterPass);
            this.Controls.Add(this.pictureBox1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.MaximizeBox = false;
            this.Name = "FormOfficeSignIn_Password";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "DLMS";
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.FormOfficeSignIn_Password_FormClosing);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBoxBackButton)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private CustomControls.CustomTextbox textboxPassword;
        private CustomControls.CustomButton buttonSignIn;
        private System.Windows.Forms.Label labelForgotMyPass;
        private System.Windows.Forms.Label labelEnterPass;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.Label labelEmail;
        private System.Windows.Forms.PictureBox pictureBoxBackButton;
    }
}