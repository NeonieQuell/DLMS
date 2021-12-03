
namespace DLMS.Forms.Office365SignIn
{
    partial class FormOfficeSignIn_Email
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FormOfficeSignIn_Email));
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.labelSignIn = new System.Windows.Forms.Label();
            this.labelNoAcc = new System.Windows.Forms.Label();
            this.labelCreateOne = new System.Windows.Forms.Label();
            this.labelCantAccessAcc = new System.Windows.Forms.Label();
            this.textboxEmail = new DLMS.CustomControls.CustomTextbox();
            this.buttonNext = new DLMS.CustomControls.CustomButton();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // pictureBox1
            // 
            this.pictureBox1.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox1.Image")));
            this.pictureBox1.Location = new System.Drawing.Point(38, 1);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(110, 44);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pictureBox1.TabIndex = 0;
            this.pictureBox1.TabStop = false;
            // 
            // labelSignIn
            // 
            this.labelSignIn.AutoSize = true;
            this.labelSignIn.Font = new System.Drawing.Font("Microsoft YaHei", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelSignIn.Location = new System.Drawing.Point(32, 50);
            this.labelSignIn.Name = "labelSignIn";
            this.labelSignIn.Size = new System.Drawing.Size(97, 31);
            this.labelSignIn.TabIndex = 0;
            this.labelSignIn.Text = "Sign in";
            // 
            // labelNoAcc
            // 
            this.labelNoAcc.AutoSize = true;
            this.labelNoAcc.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelNoAcc.Location = new System.Drawing.Point(35, 147);
            this.labelNoAcc.Name = "labelNoAcc";
            this.labelNoAcc.Size = new System.Drawing.Size(83, 16);
            this.labelNoAcc.TabIndex = 2;
            this.labelNoAcc.Text = "No account?";
            // 
            // labelCreateOne
            // 
            this.labelCreateOne.AutoSize = true;
            this.labelCreateOne.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelCreateOne.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(47)))), ((int)(((byte)(131)))), ((int)(((byte)(197)))));
            this.labelCreateOne.Location = new System.Drawing.Point(124, 147);
            this.labelCreateOne.Name = "labelCreateOne";
            this.labelCreateOne.Size = new System.Drawing.Size(79, 16);
            this.labelCreateOne.TabIndex = 3;
            this.labelCreateOne.Text = "Create One!";
            // 
            // labelCantAccessAcc
            // 
            this.labelCantAccessAcc.AutoSize = true;
            this.labelCantAccessAcc.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelCantAccessAcc.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(47)))), ((int)(((byte)(131)))), ((int)(((byte)(197)))));
            this.labelCantAccessAcc.Location = new System.Drawing.Point(35, 183);
            this.labelCantAccessAcc.Name = "labelCantAccessAcc";
            this.labelCantAccessAcc.Size = new System.Drawing.Size(171, 16);
            this.labelCantAccessAcc.TabIndex = 4;
            this.labelCantAccessAcc.Text = "Can\'t access your account?";
            // 
            // textboxEmail
            // 
            this.textboxEmail.BackColor = System.Drawing.SystemColors.Window;
            this.textboxEmail.BorderColor = System.Drawing.Color.DarkGray;
            this.textboxEmail.BorderColorFocusColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(103)))), ((int)(((byte)(184)))));
            this.textboxEmail.BorderSize = 1;
            this.textboxEmail.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.textboxEmail.ForeColor = System.Drawing.Color.DimGray;
            this.textboxEmail.IsFocused = false;
            this.textboxEmail.Location = new System.Drawing.Point(38, 95);
            this.textboxEmail.Margin = new System.Windows.Forms.Padding(4);
            this.textboxEmail.Multiline = false;
            this.textboxEmail.Name = "textboxEmail";
            this.textboxEmail.Padding = new System.Windows.Forms.Padding(7);
            this.textboxEmail.PasswordChar = false;
            this.textboxEmail.Size = new System.Drawing.Size(379, 35);
            this.textboxEmail.TabIndex = 1;
            this.textboxEmail.TabStop = false;
            this.textboxEmail.Texts = "Email, phone, or Skype";
            this.textboxEmail.UnderlinedStyle = true;
            this.textboxEmail.Enter += new System.EventHandler(this.textboxEmail_Enter);
            this.textboxEmail.Leave += new System.EventHandler(this.textboxEmail_Leave);
            // 
            // buttonNext
            // 
            this.buttonNext.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(103)))), ((int)(((byte)(184)))));
            this.buttonNext.BackgroundColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(103)))), ((int)(((byte)(184)))));
            this.buttonNext.BorderColor = System.Drawing.Color.PaleVioletRed;
            this.buttonNext.BorderRadius = 0;
            this.buttonNext.BorderSize = 0;
            this.buttonNext.FlatAppearance.BorderSize = 0;
            this.buttonNext.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.buttonNext.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.buttonNext.FontColor = System.Drawing.Color.White;
            this.buttonNext.ForeColor = System.Drawing.Color.White;
            this.buttonNext.Location = new System.Drawing.Point(288, 229);
            this.buttonNext.Name = "buttonNext";
            this.buttonNext.Size = new System.Drawing.Size(106, 32);
            this.buttonNext.TabIndex = 5;
            this.buttonNext.Text = "Next";
            this.buttonNext.UseVisualStyleBackColor = false;
            this.buttonNext.Click += new System.EventHandler(this.buttonNext_Click);
            // 
            // FormOfficeSignIn_Email
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.ClientSize = new System.Drawing.Size(446, 308);
            this.Controls.Add(this.textboxEmail);
            this.Controls.Add(this.buttonNext);
            this.Controls.Add(this.labelCantAccessAcc);
            this.Controls.Add(this.labelCreateOne);
            this.Controls.Add(this.labelNoAcc);
            this.Controls.Add(this.labelSignIn);
            this.Controls.Add(this.pictureBox1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.MaximizeBox = false;
            this.Name = "FormOfficeSignIn_Email";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "DLMS";
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.FormOfficeSignIn_FormClosing);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.Label labelSignIn;
        private System.Windows.Forms.Label labelNoAcc;
        private System.Windows.Forms.Label labelCreateOne;
        private System.Windows.Forms.Label labelCantAccessAcc;
        private CustomControls.CustomButton buttonNext;
        private CustomControls.CustomTextbox textboxEmail;
    }
}