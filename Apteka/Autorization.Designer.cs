namespace Apteka
{
	partial class Autorization
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
            this.components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Autorization));
            this.dsApteka = new Apteka.dsApteka();
            this.bsUser = new System.Windows.Forms.BindingSource(this.components);
            this.userTableAdapter = new Apteka.dsAptekaTableAdapters.UserTableAdapter();
            this.lblName = new System.Windows.Forms.Label();
            this.btnLogin = new System.Windows.Forms.Button();
            this.llReg = new System.Windows.Forms.LinkLabel();
            this.pbVisible = new System.Windows.Forms.PictureBox();
            this.pbClose = new System.Windows.Forms.PictureBox();
            this.panel1 = new System.Windows.Forms.Panel();
            this.ctbxPassword = new CueTextBox();
            this.ctbxLogin = new CueTextBox();
            ((System.ComponentModel.ISupportInitialize)(this.dsApteka)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.bsUser)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pbVisible)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pbClose)).BeginInit();
            this.panel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // dsApteka
            // 
            this.dsApteka.DataSetName = "dsApteka";
            this.dsApteka.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // bsUser
            // 
            this.bsUser.DataMember = "User";
            this.bsUser.DataSource = this.dsApteka;
            // 
            // userTableAdapter
            // 
            this.userTableAdapter.ClearBeforeFill = true;
            // 
            // lblName
            // 
            this.lblName.AutoSize = true;
            this.lblName.BackColor = System.Drawing.Color.Transparent;
            this.lblName.Dock = System.Windows.Forms.DockStyle.Top;
            this.lblName.Font = new System.Drawing.Font("Segoe UI", 20.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.lblName.ForeColor = System.Drawing.Color.ForestGreen;
            this.lblName.Location = new System.Drawing.Point(25, 25);
            this.lblName.Margin = new System.Windows.Forms.Padding(0);
            this.lblName.Name = "lblName";
            this.lblName.Padding = new System.Windows.Forms.Padding(0, 0, 0, 25);
            this.lblName.Size = new System.Drawing.Size(390, 71);
            this.lblName.TabIndex = 44;
            this.lblName.Text = "Вход или регистрация";
            this.lblName.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // btnLogin
            // 
            this.btnLogin.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(192)))), ((int)(((byte)(0)))));
            this.btnLogin.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnLogin.FlatAppearance.BorderSize = 0;
            this.btnLogin.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnLogin.Font = new System.Drawing.Font("Segoe UI Semibold", 16F, System.Drawing.FontStyle.Bold);
            this.btnLogin.ForeColor = System.Drawing.Color.White;
            this.btnLogin.Location = new System.Drawing.Point(25, 300);
            this.btnLogin.Margin = new System.Windows.Forms.Padding(0);
            this.btnLogin.Name = "btnLogin";
            this.btnLogin.Size = new System.Drawing.Size(390, 75);
            this.btnLogin.TabIndex = 42;
            this.btnLogin.TabStop = false;
            this.btnLogin.Text = "В О Й Т И";
            this.btnLogin.UseVisualStyleBackColor = false;
            this.btnLogin.Click += new System.EventHandler(this.btnLogin_Click);
            // 
            // llReg
            // 
            this.llReg.BackColor = System.Drawing.Color.Transparent;
            this.llReg.Cursor = System.Windows.Forms.Cursors.Hand;
            this.llReg.DisabledLinkColor = System.Drawing.Color.Black;
            this.llReg.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.llReg.Font = new System.Drawing.Font("Segoe UI Semibold", 13.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.llReg.ForeColor = System.Drawing.Color.Black;
            this.llReg.LinkColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(192)))), ((int)(((byte)(0)))));
            this.llReg.Location = new System.Drawing.Point(25, 385);
            this.llReg.Margin = new System.Windows.Forms.Padding(0);
            this.llReg.Name = "llReg";
            this.llReg.Size = new System.Drawing.Size(390, 55);
            this.llReg.TabIndex = 43;
            this.llReg.TabStop = true;
            this.llReg.Text = "Зарегистрироваться";
            this.llReg.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.llReg.VisitedLinkColor = System.Drawing.Color.Yellow;
            this.llReg.LinkClicked += new System.Windows.Forms.LinkLabelLinkClickedEventHandler(this.hlReg_LinkClicked);
            // 
            // pbVisible
            // 
            this.pbVisible.BackColor = System.Drawing.Color.Transparent;
            this.pbVisible.Cursor = System.Windows.Forms.Cursors.Hand;
            this.pbVisible.ErrorImage = global::Apteka.Properties.Resources.error;
            this.pbVisible.Image = ((System.Drawing.Image)(resources.GetObject("pbVisible.Image")));
            this.pbVisible.Location = new System.Drawing.Point(350, 225);
            this.pbVisible.Name = "pbVisible";
            this.pbVisible.Size = new System.Drawing.Size(65, 65);
            this.pbVisible.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pbVisible.TabIndex = 46;
            this.pbVisible.TabStop = false;
            this.pbVisible.Tag = "100";
            this.pbVisible.Click += new System.EventHandler(this.pbVisible_Click);
            // 
            // pbClose
            // 
            this.pbClose.BackColor = System.Drawing.Color.Transparent;
            this.pbClose.Cursor = System.Windows.Forms.Cursors.Hand;
            this.pbClose.ErrorImage = global::Apteka.Properties.Resources.error;
            this.pbClose.Image = global::Apteka.Properties.Resources.close;
            this.pbClose.Location = new System.Drawing.Point(400, 5);
            this.pbClose.Name = "pbClose";
            this.pbClose.Size = new System.Drawing.Size(35, 35);
            this.pbClose.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pbClose.TabIndex = 49;
            this.pbClose.TabStop = false;
            this.pbClose.Tag = "100";
            this.pbClose.Click += new System.EventHandler(this.pbClose_Click);
            // 
            // panel1
            // 
            this.panel1.Controls.Add(this.pbClose);
            this.panel1.Controls.Add(this.ctbxPassword);
            this.panel1.Controls.Add(this.ctbxLogin);
            this.panel1.Controls.Add(this.pbVisible);
            this.panel1.Controls.Add(this.llReg);
            this.panel1.Controls.Add(this.btnLogin);
            this.panel1.Controls.Add(this.lblName);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panel1.Location = new System.Drawing.Point(5, 5);
            this.panel1.Name = "panel1";
            this.panel1.Padding = new System.Windows.Forms.Padding(25, 25, 25, 0);
            this.panel1.Size = new System.Drawing.Size(440, 440);
            this.panel1.TabIndex = 0;
            // 
            // ctbxPassword
            // 
            this.ctbxPassword.Cue = "Пароль";
            this.ctbxPassword.Font = new System.Drawing.Font("Segoe UI", 13.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.ctbxPassword.Location = new System.Drawing.Point(22, 175);
            this.ctbxPassword.Name = "ctbxPassword";
            this.ctbxPassword.Size = new System.Drawing.Size(390, 38);
            this.ctbxPassword.TabIndex = 48;
            this.ctbxPassword.UseSystemPasswordChar = true;
            // 
            // ctbxLogin
            // 
            this.ctbxLogin.Cue = "Логин";
            this.ctbxLogin.Font = new System.Drawing.Font("Segoe UI", 13.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.ctbxLogin.Location = new System.Drawing.Point(25, 100);
            this.ctbxLogin.Name = "ctbxLogin";
            this.ctbxLogin.Size = new System.Drawing.Size(390, 38);
            this.ctbxLogin.TabIndex = 47;
            // 
            // Autorization
            // 
            this.AcceptButton = this.btnLogin;
            this.AutoScaleDimensions = new System.Drawing.SizeF(12F, 28F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("$this.BackgroundImage")));
            this.ClientSize = new System.Drawing.Size(450, 450);
            this.Controls.Add(this.panel1);
            this.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Bold);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.MaximumSize = new System.Drawing.Size(450, 450);
            this.MinimumSize = new System.Drawing.Size(450, 450);
            this.Name = "Autorization";
            this.Padding = new System.Windows.Forms.Padding(5);
            this.ShowIcon = false;
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterParent;
            this.Text = "Autorization";
            this.Load += new System.EventHandler(this.Autorization_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dsApteka)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.bsUser)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pbVisible)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pbClose)).EndInit();
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.ResumeLayout(false);

		}

		#endregion
		private dsApteka dsApteka;
		private System.Windows.Forms.BindingSource bsUser;
		private dsAptekaTableAdapters.UserTableAdapter userTableAdapter;
        private System.Windows.Forms.Label lblName;
        private System.Windows.Forms.Button btnLogin;
        private System.Windows.Forms.LinkLabel llReg;
        private System.Windows.Forms.PictureBox pbVisible;
        private CueTextBox ctbxLogin;
        private CueTextBox ctbxPassword;
        private System.Windows.Forms.PictureBox pbClose;
        private System.Windows.Forms.Panel panel1;
    }
}