
namespace DLMS.Forms
{
    partial class FormMainMenu
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FormMainMenu));
            this.panelContent = new System.Windows.Forms.Panel();
            this.pictureBoxHelp = new System.Windows.Forms.PictureBox();
            this.pictureBoxDarkMode = new System.Windows.Forms.PictureBox();
            this.pictureBoxSettings = new System.Windows.Forms.PictureBox();
            this.panelSignOut = new DLMS.CustomControls.CustomPanel();
            this.labelSignOut = new System.Windows.Forms.Label();
            this.panelProfile = new DLMS.CustomControls.CustomPanel();
            this.labelStudName = new System.Windows.Forms.Label();
            this.pictureBoxUser = new System.Windows.Forms.PictureBox();
            this.panelLibrary = new DLMS.CustomControls.CustomPanel();
            this.panelLibLine = new DLMS.CustomControls.CustomPanel();
            this.labelLibrary = new System.Windows.Forms.Label();
            this.pictureBoxLibraryActive = new System.Windows.Forms.PictureBox();
            this.pictureBoxLibraryINActive = new System.Windows.Forms.PictureBox();
            this.panelHome = new DLMS.CustomControls.CustomPanel();
            this.panelHomeLine = new DLMS.CustomControls.CustomPanel();
            this.labelHome = new System.Windows.Forms.Label();
            this.pictureBoxHomeActive = new System.Windows.Forms.PictureBox();
            this.pictureBoxHomeINActive = new System.Windows.Forms.PictureBox();
            this.textboxSearch = new DLMS.CustomControls.CustomTextbox();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBoxHelp)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBoxDarkMode)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBoxSettings)).BeginInit();
            this.panelSignOut.SuspendLayout();
            this.panelProfile.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBoxUser)).BeginInit();
            this.panelLibrary.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBoxLibraryActive)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBoxLibraryINActive)).BeginInit();
            this.panelHome.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBoxHomeActive)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBoxHomeINActive)).BeginInit();
            this.SuspendLayout();
            // 
            // panelContent
            // 
            this.panelContent.BackColor = System.Drawing.Color.Transparent;
            this.panelContent.Location = new System.Drawing.Point(98, 90);
            this.panelContent.Name = "panelContent";
            this.panelContent.Size = new System.Drawing.Size(1153, 710);
            this.panelContent.TabIndex = 0;
            // 
            // pictureBoxHelp
            // 
            this.pictureBoxHelp.BackColor = System.Drawing.Color.Transparent;
            this.pictureBoxHelp.Image = ((System.Drawing.Image)(resources.GetObject("pictureBoxHelp.Image")));
            this.pictureBoxHelp.Location = new System.Drawing.Point(33, 735);
            this.pictureBoxHelp.Name = "pictureBoxHelp";
            this.pictureBoxHelp.Size = new System.Drawing.Size(31, 41);
            this.pictureBoxHelp.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pictureBoxHelp.TabIndex = 10;
            this.pictureBoxHelp.TabStop = false;
            // 
            // pictureBoxDarkMode
            // 
            this.pictureBoxDarkMode.BackColor = System.Drawing.Color.Transparent;
            this.pictureBoxDarkMode.Image = ((System.Drawing.Image)(resources.GetObject("pictureBoxDarkMode.Image")));
            this.pictureBoxDarkMode.Location = new System.Drawing.Point(33, 641);
            this.pictureBoxDarkMode.Name = "pictureBoxDarkMode";
            this.pictureBoxDarkMode.Size = new System.Drawing.Size(31, 41);
            this.pictureBoxDarkMode.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pictureBoxDarkMode.TabIndex = 11;
            this.pictureBoxDarkMode.TabStop = false;
            // 
            // pictureBoxSettings
            // 
            this.pictureBoxSettings.BackColor = System.Drawing.Color.Transparent;
            this.pictureBoxSettings.Image = ((System.Drawing.Image)(resources.GetObject("pictureBoxSettings.Image")));
            this.pictureBoxSettings.Location = new System.Drawing.Point(33, 688);
            this.pictureBoxSettings.Name = "pictureBoxSettings";
            this.pictureBoxSettings.Size = new System.Drawing.Size(31, 41);
            this.pictureBoxSettings.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pictureBoxSettings.TabIndex = 12;
            this.pictureBoxSettings.TabStop = false;
            // 
            // panelSignOut
            // 
            this.panelSignOut.BackColor = System.Drawing.Color.Transparent;
            this.panelSignOut.BorderColor = System.Drawing.Color.Red;
            this.panelSignOut.BorderWidth = 1;
            this.panelSignOut.Controls.Add(this.labelSignOut);
            this.panelSignOut.FillColor = System.Drawing.Color.Transparent;
            this.panelSignOut.IsBorder = true;
            this.panelSignOut.IsFill = true;
            this.panelSignOut.Location = new System.Drawing.Point(1141, 38);
            this.panelSignOut.Name = "panelSignOut";
            this.panelSignOut.Padding_ = 5;
            this.panelSignOut.Radius = 15;
            this.panelSignOut.Size = new System.Drawing.Size(92, 46);
            this.panelSignOut.TabIndex = 9;
            this.panelSignOut.Click += new System.EventHandler(this.panelSignOut_Click);
            // 
            // labelSignOut
            // 
            this.labelSignOut.AutoSize = true;
            this.labelSignOut.BackColor = System.Drawing.Color.Transparent;
            this.labelSignOut.Font = new System.Drawing.Font("Microsoft YaHei", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelSignOut.ForeColor = System.Drawing.Color.Red;
            this.labelSignOut.Location = new System.Drawing.Point(20, 15);
            this.labelSignOut.Name = "labelSignOut";
            this.labelSignOut.Size = new System.Drawing.Size(54, 16);
            this.labelSignOut.TabIndex = 4;
            this.labelSignOut.Text = "Sign Out";
            this.labelSignOut.Click += new System.EventHandler(this.labelSignOut_Click);
            // 
            // panelProfile
            // 
            this.panelProfile.BackColor = System.Drawing.Color.Transparent;
            this.panelProfile.BorderColor = System.Drawing.Color.DimGray;
            this.panelProfile.BorderWidth = 1;
            this.panelProfile.Controls.Add(this.labelStudName);
            this.panelProfile.Controls.Add(this.pictureBoxUser);
            this.panelProfile.FillColor = System.Drawing.Color.Transparent;
            this.panelProfile.IsBorder = true;
            this.panelProfile.IsFill = true;
            this.panelProfile.Location = new System.Drawing.Point(918, 38);
            this.panelProfile.Name = "panelProfile";
            this.panelProfile.Padding_ = 5;
            this.panelProfile.Radius = 15;
            this.panelProfile.Size = new System.Drawing.Size(161, 46);
            this.panelProfile.TabIndex = 7;
            this.panelProfile.Click += new System.EventHandler(this.panelProfile_Click);
            // 
            // labelStudName
            // 
            this.labelStudName.AutoSize = true;
            this.labelStudName.BackColor = System.Drawing.Color.Transparent;
            this.labelStudName.Font = new System.Drawing.Font("Microsoft YaHei", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelStudName.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(83)))), ((int)(((byte)(83)))), ((int)(((byte)(83)))));
            this.labelStudName.Location = new System.Drawing.Point(42, 16);
            this.labelStudName.Name = "labelStudName";
            this.labelStudName.Size = new System.Drawing.Size(39, 16);
            this.labelStudName.TabIndex = 4;
            this.labelStudName.Text = "Name";
            this.labelStudName.Click += new System.EventHandler(this.labelStudName_Click);
            // 
            // pictureBoxUser
            // 
            this.pictureBoxUser.BackColor = System.Drawing.Color.Transparent;
            this.pictureBoxUser.Image = global::DLMS.Properties.Resources.User_Avatar;
            this.pictureBoxUser.Location = new System.Drawing.Point(11, 11);
            this.pictureBoxUser.Name = "pictureBoxUser";
            this.pictureBoxUser.Size = new System.Drawing.Size(28, 26);
            this.pictureBoxUser.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pictureBoxUser.TabIndex = 3;
            this.pictureBoxUser.TabStop = false;
            this.pictureBoxUser.Click += new System.EventHandler(this.pictureBoxUser_Click);
            // 
            // panelLibrary
            // 
            this.panelLibrary.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.panelLibrary.BorderWidth = 5;
            this.panelLibrary.Controls.Add(this.panelLibLine);
            this.panelLibrary.Controls.Add(this.labelLibrary);
            this.panelLibrary.Controls.Add(this.pictureBoxLibraryActive);
            this.panelLibrary.Controls.Add(this.pictureBoxLibraryINActive);
            this.panelLibrary.FillColor = System.Drawing.Color.Transparent;
            this.panelLibrary.IsBorder = false;
            this.panelLibrary.IsFill = true;
            this.panelLibrary.Location = new System.Drawing.Point(2, 176);
            this.panelLibrary.Name = "panelLibrary";
            this.panelLibrary.Padding_ = 5;
            this.panelLibrary.Radius = 10;
            this.panelLibrary.Size = new System.Drawing.Size(93, 85);
            this.panelLibrary.TabIndex = 6;
            this.panelLibrary.Click += new System.EventHandler(this.panelLibrary_Click);
            // 
            // panelLibLine
            // 
            this.panelLibLine.BackColor = System.Drawing.Color.Transparent;
            this.panelLibLine.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.panelLibLine.BorderWidth = 5;
            this.panelLibLine.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(114)))), ((int)(((byte)(188)))));
            this.panelLibLine.IsBorder = false;
            this.panelLibLine.IsFill = true;
            this.panelLibLine.Location = new System.Drawing.Point(1, 22);
            this.panelLibLine.Name = "panelLibLine";
            this.panelLibLine.Padding_ = 5;
            this.panelLibLine.Radius = 10;
            this.panelLibLine.Size = new System.Drawing.Size(15, 41);
            this.panelLibLine.TabIndex = 10;
            this.panelLibLine.Visible = false;
            // 
            // labelLibrary
            // 
            this.labelLibrary.AutoSize = true;
            this.labelLibrary.BackColor = System.Drawing.Color.Transparent;
            this.labelLibrary.Font = new System.Drawing.Font("Microsoft YaHei", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelLibrary.ForeColor = System.Drawing.Color.DimGray;
            this.labelLibrary.Location = new System.Drawing.Point(24, 58);
            this.labelLibrary.Name = "labelLibrary";
            this.labelLibrary.Size = new System.Drawing.Size(44, 16);
            this.labelLibrary.TabIndex = 0;
            this.labelLibrary.Text = "Library";
            this.labelLibrary.Click += new System.EventHandler(this.labelLibrary_Click);
            // 
            // pictureBoxLibraryActive
            // 
            this.pictureBoxLibraryActive.BackColor = System.Drawing.Color.Transparent;
            this.pictureBoxLibraryActive.Image = ((System.Drawing.Image)(resources.GetObject("pictureBoxLibraryActive.Image")));
            this.pictureBoxLibraryActive.Location = new System.Drawing.Point(31, 22);
            this.pictureBoxLibraryActive.Name = "pictureBoxLibraryActive";
            this.pictureBoxLibraryActive.Size = new System.Drawing.Size(31, 41);
            this.pictureBoxLibraryActive.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pictureBoxLibraryActive.TabIndex = 7;
            this.pictureBoxLibraryActive.TabStop = false;
            this.pictureBoxLibraryActive.Visible = false;
            this.pictureBoxLibraryActive.Click += new System.EventHandler(this.pictureBoxLibraryActive_Click);
            // 
            // pictureBoxLibraryINActive
            // 
            this.pictureBoxLibraryINActive.BackColor = System.Drawing.Color.Transparent;
            this.pictureBoxLibraryINActive.Image = ((System.Drawing.Image)(resources.GetObject("pictureBoxLibraryINActive.Image")));
            this.pictureBoxLibraryINActive.Location = new System.Drawing.Point(31, 14);
            this.pictureBoxLibraryINActive.Name = "pictureBoxLibraryINActive";
            this.pictureBoxLibraryINActive.Size = new System.Drawing.Size(31, 41);
            this.pictureBoxLibraryINActive.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pictureBoxLibraryINActive.TabIndex = 6;
            this.pictureBoxLibraryINActive.TabStop = false;
            this.pictureBoxLibraryINActive.Click += new System.EventHandler(this.pictureBoxLibraryINActive_Click);
            // 
            // panelHome
            // 
            this.panelHome.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.panelHome.BorderWidth = 5;
            this.panelHome.Controls.Add(this.panelHomeLine);
            this.panelHome.Controls.Add(this.labelHome);
            this.panelHome.Controls.Add(this.pictureBoxHomeActive);
            this.panelHome.Controls.Add(this.pictureBoxHomeINActive);
            this.panelHome.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            this.panelHome.IsBorder = false;
            this.panelHome.IsFill = true;
            this.panelHome.Location = new System.Drawing.Point(2, 85);
            this.panelHome.Name = "panelHome";
            this.panelHome.Padding_ = 5;
            this.panelHome.Radius = 10;
            this.panelHome.Size = new System.Drawing.Size(93, 85);
            this.panelHome.TabIndex = 5;
            this.panelHome.Click += new System.EventHandler(this.panelHome_Click);
            // 
            // panelHomeLine
            // 
            this.panelHomeLine.BackColor = System.Drawing.Color.Transparent;
            this.panelHomeLine.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.panelHomeLine.BorderWidth = 5;
            this.panelHomeLine.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(114)))), ((int)(((byte)(188)))));
            this.panelHomeLine.IsBorder = false;
            this.panelHomeLine.IsFill = true;
            this.panelHomeLine.Location = new System.Drawing.Point(1, 22);
            this.panelHomeLine.Name = "panelHomeLine";
            this.panelHomeLine.Padding_ = 5;
            this.panelHomeLine.Radius = 10;
            this.panelHomeLine.Size = new System.Drawing.Size(15, 41);
            this.panelHomeLine.TabIndex = 9;
            // 
            // labelHome
            // 
            this.labelHome.AutoSize = true;
            this.labelHome.BackColor = System.Drawing.Color.Transparent;
            this.labelHome.Font = new System.Drawing.Font("Microsoft YaHei", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelHome.ForeColor = System.Drawing.Color.DimGray;
            this.labelHome.Location = new System.Drawing.Point(28, 58);
            this.labelHome.Name = "labelHome";
            this.labelHome.Size = new System.Drawing.Size(40, 16);
            this.labelHome.TabIndex = 0;
            this.labelHome.Text = "Home";
            this.labelHome.Visible = false;
            this.labelHome.Click += new System.EventHandler(this.labelHome_Click);
            // 
            // pictureBoxHomeActive
            // 
            this.pictureBoxHomeActive.BackColor = System.Drawing.Color.Transparent;
            this.pictureBoxHomeActive.Image = ((System.Drawing.Image)(resources.GetObject("pictureBoxHomeActive.Image")));
            this.pictureBoxHomeActive.Location = new System.Drawing.Point(31, 22);
            this.pictureBoxHomeActive.Name = "pictureBoxHomeActive";
            this.pictureBoxHomeActive.Size = new System.Drawing.Size(31, 41);
            this.pictureBoxHomeActive.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pictureBoxHomeActive.TabIndex = 6;
            this.pictureBoxHomeActive.TabStop = false;
            this.pictureBoxHomeActive.Click += new System.EventHandler(this.pictureBoxHomeActive_Click);
            // 
            // pictureBoxHomeINActive
            // 
            this.pictureBoxHomeINActive.BackColor = System.Drawing.Color.Transparent;
            this.pictureBoxHomeINActive.Image = ((System.Drawing.Image)(resources.GetObject("pictureBoxHomeINActive.Image")));
            this.pictureBoxHomeINActive.Location = new System.Drawing.Point(31, 14);
            this.pictureBoxHomeINActive.Name = "pictureBoxHomeINActive";
            this.pictureBoxHomeINActive.Size = new System.Drawing.Size(31, 41);
            this.pictureBoxHomeINActive.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pictureBoxHomeINActive.TabIndex = 6;
            this.pictureBoxHomeINActive.TabStop = false;
            this.pictureBoxHomeINActive.Visible = false;
            this.pictureBoxHomeINActive.Click += new System.EventHandler(this.pictureBoxHomeINActive_Click);
            // 
            // textboxSearch
            // 
            this.textboxSearch.BackColor = System.Drawing.SystemColors.Window;
            this.textboxSearch.BorderColor = System.Drawing.Color.DarkGray;
            this.textboxSearch.BorderColorFocusColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(103)))), ((int)(((byte)(184)))));
            this.textboxSearch.BorderSize = 2;
            this.textboxSearch.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.textboxSearch.ForeColor = System.Drawing.Color.DimGray;
            this.textboxSearch.IsFocused = false;
            this.textboxSearch.Location = new System.Drawing.Point(437, 44);
            this.textboxSearch.Margin = new System.Windows.Forms.Padding(4);
            this.textboxSearch.Multiline = false;
            this.textboxSearch.Name = "textboxSearch";
            this.textboxSearch.Padding = new System.Windows.Forms.Padding(7);
            this.textboxSearch.PasswordChar = false;
            this.textboxSearch.Size = new System.Drawing.Size(474, 35);
            this.textboxSearch.TabIndex = 3;
            this.textboxSearch.TabStop = false;
            this.textboxSearch.Texts = "Search Titles & Authors";
            this.textboxSearch.UnderlinedStyle = false;
            // 
            // FormMainMenu
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.Control;
            this.ClientSize = new System.Drawing.Size(1245, 794);
            this.Controls.Add(this.pictureBoxSettings);
            this.Controls.Add(this.pictureBoxDarkMode);
            this.Controls.Add(this.pictureBoxHelp);
            this.Controls.Add(this.panelSignOut);
            this.Controls.Add(this.panelProfile);
            this.Controls.Add(this.panelLibrary);
            this.Controls.Add(this.panelHome);
            this.Controls.Add(this.textboxSearch);
            this.Controls.Add(this.panelContent);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.MaximizeBox = false;
            this.Name = "FormMainMenu";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "DLMS";
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.FormMainMenu_FormClosing);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBoxHelp)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBoxDarkMode)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBoxSettings)).EndInit();
            this.panelSignOut.ResumeLayout(false);
            this.panelSignOut.PerformLayout();
            this.panelProfile.ResumeLayout(false);
            this.panelProfile.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBoxUser)).EndInit();
            this.panelLibrary.ResumeLayout(false);
            this.panelLibrary.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBoxLibraryActive)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBoxLibraryINActive)).EndInit();
            this.panelHome.ResumeLayout(false);
            this.panelHome.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBoxHomeActive)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBoxHomeINActive)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel panelContent;
        private System.Windows.Forms.PictureBox pictureBoxUser;
        private CustomControls.CustomTextbox textboxSearch;
        private System.Windows.Forms.PictureBox pictureBoxHomeINActive;
        private System.Windows.Forms.Label labelHome;
        private System.Windows.Forms.Label labelLibrary;
        private System.Windows.Forms.PictureBox pictureBoxLibraryINActive;
        private System.Windows.Forms.PictureBox pictureBoxHomeActive;
        private System.Windows.Forms.PictureBox pictureBoxLibraryActive;
        private CustomControls.CustomPanel panelHome;
        private CustomControls.CustomPanel panelLibrary;
        private CustomControls.CustomPanel panelProfile;
        private System.Windows.Forms.Label labelStudName;
        private CustomControls.CustomPanel panelSignOut;
        private System.Windows.Forms.Label labelSignOut;
        private CustomControls.CustomPanel panelLibLine;
        private CustomControls.CustomPanel panelHomeLine;
        private System.Windows.Forms.PictureBox pictureBoxHelp;
        private System.Windows.Forms.PictureBox pictureBoxDarkMode;
        private System.Windows.Forms.PictureBox pictureBoxSettings;
    }
}