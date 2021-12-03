
namespace DLMS.Forms
{
    partial class FormMainSignIn
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FormMainSignIn));
            this.pictureBoxStudents = new System.Windows.Forms.PictureBox();
            this.labelSignIn = new System.Windows.Forms.Label();
            this.pictureBoxSTILogo = new System.Windows.Forms.PictureBox();
            this.labelCantSignIn = new System.Windows.Forms.Label();
            this.buttonSignIn = new DLMS.CustomControls.CustomButton();
            this.labelContact = new System.Windows.Forms.Label();
            this.pictureBoxBlue = new System.Windows.Forms.PictureBox();
            this.panelSignIn = new System.Windows.Forms.Panel();
            this.panelContactSTI = new System.Windows.Forms.Panel();
            this.labelFAQ = new System.Windows.Forms.Label();
            this.labelONESTI = new System.Windows.Forms.Label();
            this.labelSTIeLMS = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBoxStudents)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBoxSTILogo)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBoxBlue)).BeginInit();
            this.panelSignIn.SuspendLayout();
            this.panelContactSTI.SuspendLayout();
            this.SuspendLayout();
            // 
            // pictureBoxStudents
            // 
            this.pictureBoxStudents.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.pictureBoxStudents.Image = ((System.Drawing.Image)(resources.GetObject("pictureBoxStudents.Image")));
            this.pictureBoxStudents.Location = new System.Drawing.Point(427, -9);
            this.pictureBoxStudents.Name = "pictureBoxStudents";
            this.pictureBoxStudents.Size = new System.Drawing.Size(1335, 787);
            this.pictureBoxStudents.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBoxStudents.TabIndex = 0;
            this.pictureBoxStudents.TabStop = false;
            // 
            // labelSignIn
            // 
            this.labelSignIn.AutoSize = true;
            this.labelSignIn.Font = new System.Drawing.Font("Microsoft YaHei", 20.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelSignIn.ForeColor = System.Drawing.Color.White;
            this.labelSignIn.Location = new System.Drawing.Point(73, 21);
            this.labelSignIn.Name = "labelSignIn";
            this.labelSignIn.Size = new System.Drawing.Size(110, 36);
            this.labelSignIn.TabIndex = 0;
            this.labelSignIn.Text = "Sign In";
            // 
            // pictureBoxSTILogo
            // 
            this.pictureBoxSTILogo.Image = ((System.Drawing.Image)(resources.GetObject("pictureBoxSTILogo.Image")));
            this.pictureBoxSTILogo.Location = new System.Drawing.Point(153, 45);
            this.pictureBoxSTILogo.Name = "pictureBoxSTILogo";
            this.pictureBoxSTILogo.Size = new System.Drawing.Size(139, 74);
            this.pictureBoxSTILogo.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pictureBoxSTILogo.TabIndex = 3;
            this.pictureBoxSTILogo.TabStop = false;
            // 
            // labelCantSignIn
            // 
            this.labelCantSignIn.AutoSize = true;
            this.labelCantSignIn.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelCantSignIn.Location = new System.Drawing.Point(3, 15);
            this.labelCantSignIn.Name = "labelCantSignIn";
            this.labelCantSignIn.Size = new System.Drawing.Size(86, 16);
            this.labelCantSignIn.TabIndex = 0;
            this.labelCantSignIn.Text = "Can\'t sign in?";
            // 
            // buttonSignIn
            // 
            this.buttonSignIn.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(220)))), ((int)(((byte)(62)))), ((int)(((byte)(21)))));
            this.buttonSignIn.BackgroundColor = System.Drawing.Color.FromArgb(((int)(((byte)(220)))), ((int)(((byte)(62)))), ((int)(((byte)(21)))));
            this.buttonSignIn.BorderColor = System.Drawing.Color.PaleVioletRed;
            this.buttonSignIn.BorderRadius = 30;
            this.buttonSignIn.BorderSize = 0;
            this.buttonSignIn.FlatAppearance.BorderSize = 0;
            this.buttonSignIn.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.buttonSignIn.Font = new System.Drawing.Font("Microsoft YaHei", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.buttonSignIn.FontColor = System.Drawing.Color.White;
            this.buttonSignIn.ForeColor = System.Drawing.Color.White;
            this.buttonSignIn.Image = ((System.Drawing.Image)(resources.GetObject("buttonSignIn.Image")));
            this.buttonSignIn.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.buttonSignIn.Location = new System.Drawing.Point(1, 82);
            this.buttonSignIn.Name = "buttonSignIn";
            this.buttonSignIn.Padding = new System.Windows.Forms.Padding(15, 0, 15, 0);
            this.buttonSignIn.Size = new System.Drawing.Size(247, 55);
            this.buttonSignIn.TabIndex = 1;
            this.buttonSignIn.Text = "Sign-in with Office 365";
            this.buttonSignIn.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.buttonSignIn.UseVisualStyleBackColor = false;
            this.buttonSignIn.Click += new System.EventHandler(this.buttonSignIn_Click);
            // 
            // labelContact
            // 
            this.labelContact.AutoSize = true;
            this.labelContact.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelContact.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(47)))), ((int)(((byte)(131)))), ((int)(((byte)(197)))));
            this.labelContact.Location = new System.Drawing.Point(95, 15);
            this.labelContact.Name = "labelContact";
            this.labelContact.Size = new System.Drawing.Size(206, 16);
            this.labelContact.TabIndex = 1;
            this.labelContact.Text = "Contact your enrolled STI Branch ";
            // 
            // pictureBoxBlue
            // 
            this.pictureBoxBlue.Image = ((System.Drawing.Image)(resources.GetObject("pictureBoxBlue.Image")));
            this.pictureBoxBlue.Location = new System.Drawing.Point(-6, -38);
            this.pictureBoxBlue.Name = "pictureBoxBlue";
            this.pictureBoxBlue.Size = new System.Drawing.Size(660, 855);
            this.pictureBoxBlue.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pictureBoxBlue.TabIndex = 9;
            this.pictureBoxBlue.TabStop = false;
            // 
            // panelSignIn
            // 
            this.panelSignIn.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(30)))), ((int)(((byte)(65)))), ((int)(((byte)(169)))));
            this.panelSignIn.Controls.Add(this.buttonSignIn);
            this.panelSignIn.Controls.Add(this.labelSignIn);
            this.panelSignIn.Location = new System.Drawing.Point(97, 224);
            this.panelSignIn.Name = "panelSignIn";
            this.panelSignIn.Size = new System.Drawing.Size(250, 193);
            this.panelSignIn.TabIndex = 0;
            // 
            // panelContactSTI
            // 
            this.panelContactSTI.BackColor = System.Drawing.Color.White;
            this.panelContactSTI.Controls.Add(this.labelContact);
            this.panelContactSTI.Controls.Add(this.labelCantSignIn);
            this.panelContactSTI.Location = new System.Drawing.Point(12, 731);
            this.panelContactSTI.Name = "panelContactSTI";
            this.panelContactSTI.Size = new System.Drawing.Size(335, 47);
            this.panelContactSTI.TabIndex = 1;
            // 
            // labelFAQ
            // 
            this.labelFAQ.AutoSize = true;
            this.labelFAQ.BackColor = System.Drawing.Color.Black;
            this.labelFAQ.Font = new System.Drawing.Font("Microsoft YaHei", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelFAQ.ForeColor = System.Drawing.Color.White;
            this.labelFAQ.Location = new System.Drawing.Point(961, 20);
            this.labelFAQ.Name = "labelFAQ";
            this.labelFAQ.Size = new System.Drawing.Size(53, 26);
            this.labelFAQ.TabIndex = 2;
            this.labelFAQ.Text = "FAQ";
            // 
            // labelONESTI
            // 
            this.labelONESTI.AutoSize = true;
            this.labelONESTI.BackColor = System.Drawing.Color.Black;
            this.labelONESTI.Font = new System.Drawing.Font("Microsoft YaHei", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelONESTI.ForeColor = System.Drawing.Color.White;
            this.labelONESTI.Location = new System.Drawing.Point(1208, 20);
            this.labelONESTI.Name = "labelONESTI";
            this.labelONESTI.Size = new System.Drawing.Size(136, 26);
            this.labelONESTI.TabIndex = 4;
            this.labelONESTI.Text = "ONE STI App";
            // 
            // labelSTIeLMS
            // 
            this.labelSTIeLMS.AutoSize = true;
            this.labelSTIeLMS.BackColor = System.Drawing.Color.Black;
            this.labelSTIeLMS.Font = new System.Drawing.Font("Microsoft YaHei", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelSTIeLMS.ForeColor = System.Drawing.Color.White;
            this.labelSTIeLMS.Location = new System.Drawing.Point(1040, 20);
            this.labelSTIeLMS.Name = "labelSTIeLMS";
            this.labelSTIeLMS.Size = new System.Drawing.Size(145, 26);
            this.labelSTIeLMS.TabIndex = 3;
            this.labelSTIeLMS.Text = "STI eLMS App";
            // 
            // FormMainSignIn
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.Control;
            this.ClientSize = new System.Drawing.Size(1365, 774);
            this.Controls.Add(this.labelONESTI);
            this.Controls.Add(this.labelFAQ);
            this.Controls.Add(this.labelSTIeLMS);
            this.Controls.Add(this.panelContactSTI);
            this.Controls.Add(this.panelSignIn);
            this.Controls.Add(this.pictureBoxSTILogo);
            this.Controls.Add(this.pictureBoxStudents);
            this.Controls.Add(this.pictureBoxBlue);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.MaximizeBox = false;
            this.Name = "FormMainSignIn";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "DLMS";
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.FormMainSignIn_FormClosing);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBoxStudents)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBoxSTILogo)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBoxBlue)).EndInit();
            this.panelSignIn.ResumeLayout(false);
            this.panelSignIn.PerformLayout();
            this.panelContactSTI.ResumeLayout(false);
            this.panelContactSTI.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.PictureBox pictureBoxStudents;
        private CustomControls.CustomButton buttonSignIn;
        private System.Windows.Forms.Label labelSignIn;
        private System.Windows.Forms.PictureBox pictureBoxSTILogo;
        private System.Windows.Forms.Label labelCantSignIn;
        private System.Windows.Forms.Label labelContact;
        private System.Windows.Forms.PictureBox pictureBoxBlue;
        private System.Windows.Forms.Panel panelSignIn;
        private System.Windows.Forms.Panel panelContactSTI;
        private System.Windows.Forms.Label labelFAQ;
        private System.Windows.Forms.Label labelONESTI;
        private System.Windows.Forms.Label labelSTIeLMS;
    }
}

