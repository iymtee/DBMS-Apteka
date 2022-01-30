namespace Apteka
{
	partial class Registration
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
			System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Registration));
			this.sp1 = new System.Windows.Forms.SplitContainer();
			this.pbClose = new System.Windows.Forms.PictureBox();
			this.label2 = new System.Windows.Forms.Label();
			this.sp2 = new System.Windows.Forms.SplitContainer();
			this.sp3 = new System.Windows.Forms.SplitContainer();
			this.pbVisiblePass = new System.Windows.Forms.PictureBox();
			this.ctbxPassword = new CueTextBox();
			this.pbVisibleAgPass = new System.Windows.Forms.PictureBox();
			this.dtpbDay = new System.Windows.Forms.DateTimePicker();
			this.ctbxPasswordAgain = new CueTextBox();
			this.ctbxLogin = new CueTextBox();
			this.ctbxmName = new CueTextBox();
			this.ctbxName = new CueTextBox();
			this.ctbxlName = new CueTextBox();
			this.ctbxEmail = new CueTextBox();
			this.ctbxPhone = new CueTextBox();
			this.ctbxHome = new CueTextBox();
			this.ctbxFlat = new CueTextBox();
			this.ctbxStreet = new CueTextBox();
			this.ctbxCity = new CueTextBox();
			this.ctbxIndex = new CueTextBox();
			this.btnReg = new System.Windows.Forms.Button();
			this.ttInfo = new System.Windows.Forms.ToolTip(this.components);
			((System.ComponentModel.ISupportInitialize)(this.sp1)).BeginInit();
			this.sp1.Panel1.SuspendLayout();
			this.sp1.Panel2.SuspendLayout();
			this.sp1.SuspendLayout();
			((System.ComponentModel.ISupportInitialize)(this.pbClose)).BeginInit();
			((System.ComponentModel.ISupportInitialize)(this.sp2)).BeginInit();
			this.sp2.Panel1.SuspendLayout();
			this.sp2.Panel2.SuspendLayout();
			this.sp2.SuspendLayout();
			((System.ComponentModel.ISupportInitialize)(this.sp3)).BeginInit();
			this.sp3.Panel1.SuspendLayout();
			this.sp3.Panel2.SuspendLayout();
			this.sp3.SuspendLayout();
			((System.ComponentModel.ISupportInitialize)(this.pbVisiblePass)).BeginInit();
			((System.ComponentModel.ISupportInitialize)(this.pbVisibleAgPass)).BeginInit();
			this.SuspendLayout();
			// 
			// sp1
			// 
			this.sp1.Dock = System.Windows.Forms.DockStyle.Fill;
			this.sp1.IsSplitterFixed = true;
			this.sp1.Location = new System.Drawing.Point(0, 0);
			this.sp1.Name = "sp1";
			this.sp1.Orientation = System.Windows.Forms.Orientation.Horizontal;
			// 
			// sp1.Panel1
			// 
			this.sp1.Panel1.Controls.Add(this.pbClose);
			this.sp1.Panel1.Controls.Add(this.label2);
			this.sp1.Panel1.Padding = new System.Windows.Forms.Padding(25, 25, 25, 0);
			this.sp1.Panel1MinSize = 100;
			// 
			// sp1.Panel2
			// 
			this.sp1.Panel2.Controls.Add(this.sp2);
			this.sp1.Size = new System.Drawing.Size(700, 650);
			this.sp1.SplitterDistance = 108;
			this.sp1.SplitterWidth = 1;
			this.sp1.TabIndex = 0;
			// 
			// pbClose
			// 
			this.pbClose.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
			this.pbClose.BackColor = System.Drawing.Color.Transparent;
			this.pbClose.Cursor = System.Windows.Forms.Cursors.Hand;
			this.pbClose.ErrorImage = global::Apteka.Properties.Resources.error;
			this.pbClose.Image = global::Apteka.Properties.Resources.close;
			this.pbClose.Location = new System.Drawing.Point(675, 0);
			this.pbClose.Name = "pbClose";
			this.pbClose.Size = new System.Drawing.Size(25, 25);
			this.pbClose.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
			this.pbClose.TabIndex = 50;
			this.pbClose.TabStop = false;
			this.pbClose.Tag = "100";
			this.pbClose.Click += new System.EventHandler(this.pbClose_Click);
			// 
			// label2
			// 
			this.label2.BackColor = System.Drawing.Color.Transparent;
			this.label2.Dock = System.Windows.Forms.DockStyle.Fill;
			this.label2.Font = new System.Drawing.Font("Segoe UI", 20.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
			this.label2.ForeColor = System.Drawing.Color.ForestGreen;
			this.label2.Location = new System.Drawing.Point(25, 25);
			this.label2.Margin = new System.Windows.Forms.Padding(0);
			this.label2.Name = "label2";
			this.label2.Size = new System.Drawing.Size(650, 83);
			this.label2.TabIndex = 42;
			this.label2.Text = "Вход или регистрация";
			this.label2.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
			// 
			// sp2
			// 
			this.sp2.Dock = System.Windows.Forms.DockStyle.Fill;
			this.sp2.FixedPanel = System.Windows.Forms.FixedPanel.Panel1;
			this.sp2.Location = new System.Drawing.Point(0, 0);
			this.sp2.Margin = new System.Windows.Forms.Padding(0);
			this.sp2.Name = "sp2";
			this.sp2.Orientation = System.Windows.Forms.Orientation.Horizontal;
			// 
			// sp2.Panel1
			// 
			this.sp2.Panel1.Controls.Add(this.sp3);
			this.sp2.Panel1MinSize = 465;
			// 
			// sp2.Panel2
			// 
			this.sp2.Panel2.Controls.Add(this.btnReg);
			this.sp2.Size = new System.Drawing.Size(700, 541);
			this.sp2.SplitterDistance = 465;
			this.sp2.SplitterWidth = 1;
			this.sp2.TabIndex = 0;
			// 
			// sp3
			// 
			this.sp3.Dock = System.Windows.Forms.DockStyle.Fill;
			this.sp3.IsSplitterFixed = true;
			this.sp3.Location = new System.Drawing.Point(0, 0);
			this.sp3.Margin = new System.Windows.Forms.Padding(0);
			this.sp3.Name = "sp3";
			// 
			// sp3.Panel1
			// 
			this.sp3.Panel1.Controls.Add(this.pbVisiblePass);
			this.sp3.Panel1.Controls.Add(this.ctbxPassword);
			this.sp3.Panel1.Controls.Add(this.pbVisibleAgPass);
			this.sp3.Panel1.Controls.Add(this.dtpbDay);
			this.sp3.Panel1.Controls.Add(this.ctbxPasswordAgain);
			this.sp3.Panel1.Controls.Add(this.ctbxLogin);
			this.sp3.Panel1.Controls.Add(this.ctbxmName);
			this.sp3.Panel1.Controls.Add(this.ctbxName);
			this.sp3.Panel1.Controls.Add(this.ctbxlName);
			this.sp3.Panel1.Padding = new System.Windows.Forms.Padding(5);
			this.sp3.Panel1MinSize = 350;
			// 
			// sp3.Panel2
			// 
			this.sp3.Panel2.Controls.Add(this.ctbxEmail);
			this.sp3.Panel2.Controls.Add(this.ctbxPhone);
			this.sp3.Panel2.Controls.Add(this.ctbxHome);
			this.sp3.Panel2.Controls.Add(this.ctbxFlat);
			this.sp3.Panel2.Controls.Add(this.ctbxStreet);
			this.sp3.Panel2.Controls.Add(this.ctbxCity);
			this.sp3.Panel2.Controls.Add(this.ctbxIndex);
			this.sp3.Panel2.Padding = new System.Windows.Forms.Padding(5);
			this.sp3.Size = new System.Drawing.Size(700, 465);
			this.sp3.SplitterDistance = 350;
			this.sp3.SplitterWidth = 1;
			this.sp3.TabIndex = 0;
			// 
			// pbVisiblePass
			// 
			this.pbVisiblePass.Anchor = System.Windows.Forms.AnchorStyles.Right;
			this.pbVisiblePass.BackColor = System.Drawing.Color.Transparent;
			this.pbVisiblePass.Cursor = System.Windows.Forms.Cursors.Hand;
			this.pbVisiblePass.ErrorImage = global::Apteka.Properties.Resources.error;
			this.pbVisiblePass.Image = ((System.Drawing.Image)(resources.GetObject("pbVisiblePass.Image")));
			this.pbVisiblePass.Location = new System.Drawing.Point(303, 350);
			this.pbVisiblePass.Name = "pbVisiblePass";
			this.pbVisiblePass.Size = new System.Drawing.Size(35, 22);
			this.pbVisiblePass.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
			this.pbVisiblePass.TabIndex = 62;
			this.pbVisiblePass.TabStop = false;
			this.pbVisiblePass.Tag = "100";
			this.pbVisiblePass.Click += new System.EventHandler(this.pbVisiblePass_Click);
			// 
			// ctbxPassword
			// 
			this.ctbxPassword.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
			this.ctbxPassword.Cue = "Пароль";
			this.ctbxPassword.Font = new System.Drawing.Font("Segoe UI", 13.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
			this.ctbxPassword.Location = new System.Drawing.Point(5, 340);
			this.ctbxPassword.Name = "ctbxPassword";
			this.ctbxPassword.Size = new System.Drawing.Size(340, 38);
			this.ctbxPassword.TabIndex = 61;
			this.ctbxPassword.Tag = "100";
			this.ttInfo.SetToolTip(this.ctbxPassword, "Пароль");
			this.ctbxPassword.UseSystemPasswordChar = true;
			this.ctbxPassword.TextChanged += new System.EventHandler(this.check);
			// 
			// pbVisibleAgPass
			// 
			this.pbVisibleAgPass.Anchor = System.Windows.Forms.AnchorStyles.Right;
			this.pbVisibleAgPass.BackColor = System.Drawing.Color.Transparent;
			this.pbVisibleAgPass.Cursor = System.Windows.Forms.Cursors.Hand;
			this.pbVisibleAgPass.ErrorImage = global::Apteka.Properties.Resources.error;
			this.pbVisibleAgPass.Image = ((System.Drawing.Image)(resources.GetObject("pbVisibleAgPass.Image")));
			this.pbVisibleAgPass.Location = new System.Drawing.Point(303, 412);
			this.pbVisibleAgPass.Name = "pbVisibleAgPass";
			this.pbVisibleAgPass.Size = new System.Drawing.Size(35, 22);
			this.pbVisibleAgPass.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
			this.pbVisibleAgPass.TabIndex = 60;
			this.pbVisibleAgPass.TabStop = false;
			this.pbVisibleAgPass.Tag = "100";
			this.pbVisibleAgPass.Click += new System.EventHandler(this.pbVisibleAgPass_Click);
			// 
			// dtpbDay
			// 
			this.dtpbDay.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
			this.dtpbDay.Location = new System.Drawing.Point(5, 214);
			this.dtpbDay.Name = "dtpbDay";
			this.dtpbDay.Size = new System.Drawing.Size(340, 34);
			this.dtpbDay.TabIndex = 58;
			this.ttInfo.SetToolTip(this.dtpbDay, "Дата рождения");
			// 
			// ctbxPasswordAgain
			// 
			this.ctbxPasswordAgain.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
			this.ctbxPasswordAgain.Cue = "Повторите пароль";
			this.ctbxPasswordAgain.Font = new System.Drawing.Font("Segoe UI", 13.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
			this.ctbxPasswordAgain.Location = new System.Drawing.Point(5, 403);
			this.ctbxPasswordAgain.Name = "ctbxPasswordAgain";
			this.ctbxPasswordAgain.Size = new System.Drawing.Size(340, 38);
			this.ctbxPasswordAgain.TabIndex = 55;
			this.ctbxPasswordAgain.Tag = "100";
			this.ttInfo.SetToolTip(this.ctbxPasswordAgain, "Повторите пароль");
			this.ctbxPasswordAgain.UseSystemPasswordChar = true;
			this.ctbxPasswordAgain.TextChanged += new System.EventHandler(this.check);
			// 
			// ctbxLogin
			// 
			this.ctbxLogin.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
			this.ctbxLogin.Cue = "Логин";
			this.ctbxLogin.Font = new System.Drawing.Font("Segoe UI", 13.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
			this.ctbxLogin.Location = new System.Drawing.Point(5, 277);
			this.ctbxLogin.Name = "ctbxLogin";
			this.ctbxLogin.Size = new System.Drawing.Size(340, 38);
			this.ctbxLogin.TabIndex = 53;
			this.ttInfo.SetToolTip(this.ctbxLogin, "Логин");
			this.ctbxLogin.TextChanged += new System.EventHandler(this.check);
			// 
			// ctbxmName
			// 
			this.ctbxmName.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
			this.ctbxmName.Cue = "Отчество";
			this.ctbxmName.Font = new System.Drawing.Font("Segoe UI", 13.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
			this.ctbxmName.Location = new System.Drawing.Point(5, 151);
			this.ctbxmName.Name = "ctbxmName";
			this.ctbxmName.Size = new System.Drawing.Size(340, 38);
			this.ctbxmName.TabIndex = 51;
			this.ttInfo.SetToolTip(this.ctbxmName, "Отчество");
			this.ctbxmName.TextChanged += new System.EventHandler(this.check);
			// 
			// ctbxName
			// 
			this.ctbxName.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
			this.ctbxName.Cue = "Имя";
			this.ctbxName.Font = new System.Drawing.Font("Segoe UI", 13.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
			this.ctbxName.Location = new System.Drawing.Point(5, 88);
			this.ctbxName.Name = "ctbxName";
			this.ctbxName.Size = new System.Drawing.Size(340, 38);
			this.ctbxName.TabIndex = 50;
			this.ttInfo.SetToolTip(this.ctbxName, "Имя");
			this.ctbxName.TextChanged += new System.EventHandler(this.check);
			// 
			// ctbxlName
			// 
			this.ctbxlName.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
			this.ctbxlName.Cue = "Фамилия";
			this.ctbxlName.Font = new System.Drawing.Font("Segoe UI", 13.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
			this.ctbxlName.Location = new System.Drawing.Point(5, 25);
			this.ctbxlName.Margin = new System.Windows.Forms.Padding(0);
			this.ctbxlName.Name = "ctbxlName";
			this.ctbxlName.Size = new System.Drawing.Size(340, 38);
			this.ctbxlName.TabIndex = 0;
			this.ttInfo.SetToolTip(this.ctbxlName, "Фамилия");
			this.ctbxlName.TextChanged += new System.EventHandler(this.check);
			// 
			// ctbxEmail
			// 
			this.ctbxEmail.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
			this.ctbxEmail.Cue = "Электронная почта";
			this.ctbxEmail.Font = new System.Drawing.Font("Segoe UI", 13.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
			this.ctbxEmail.Location = new System.Drawing.Point(5, 403);
			this.ctbxEmail.Name = "ctbxEmail";
			this.ctbxEmail.Size = new System.Drawing.Size(346, 38);
			this.ctbxEmail.TabIndex = 62;
			this.ttInfo.SetToolTip(this.ctbxEmail, "Электронная почта");
			this.ctbxEmail.TextChanged += new System.EventHandler(this.check);
			// 
			// ctbxPhone
			// 
			this.ctbxPhone.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
			this.ctbxPhone.Cue = "Телефон";
			this.ctbxPhone.Font = new System.Drawing.Font("Segoe UI", 13.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
			this.ctbxPhone.Location = new System.Drawing.Point(5, 340);
			this.ctbxPhone.Name = "ctbxPhone";
			this.ctbxPhone.Size = new System.Drawing.Size(346, 38);
			this.ctbxPhone.TabIndex = 61;
			this.ttInfo.SetToolTip(this.ctbxPhone, "Телефон");
			this.ctbxPhone.TextChanged += new System.EventHandler(this.check);
			// 
			// ctbxHome
			// 
			this.ctbxHome.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
			this.ctbxHome.Cue = "Дом";
			this.ctbxHome.Font = new System.Drawing.Font("Segoe UI", 13.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
			this.ctbxHome.Location = new System.Drawing.Point(5, 210);
			this.ctbxHome.Name = "ctbxHome";
			this.ctbxHome.Size = new System.Drawing.Size(346, 38);
			this.ctbxHome.TabIndex = 60;
			this.ttInfo.SetToolTip(this.ctbxHome, "Дом");
			this.ctbxHome.TextChanged += new System.EventHandler(this.check);
			// 
			// ctbxFlat
			// 
			this.ctbxFlat.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
			this.ctbxFlat.Cue = "Квартира";
			this.ctbxFlat.Font = new System.Drawing.Font("Segoe UI", 13.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
			this.ctbxFlat.Location = new System.Drawing.Point(5, 277);
			this.ctbxFlat.Name = "ctbxFlat";
			this.ctbxFlat.Size = new System.Drawing.Size(346, 38);
			this.ctbxFlat.TabIndex = 59;
			this.ttInfo.SetToolTip(this.ctbxFlat, "Квартира");
			this.ctbxFlat.TextChanged += new System.EventHandler(this.check);
			// 
			// ctbxStreet
			// 
			this.ctbxStreet.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
			this.ctbxStreet.Cue = "Улица";
			this.ctbxStreet.Font = new System.Drawing.Font("Segoe UI", 13.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
			this.ctbxStreet.Location = new System.Drawing.Point(5, 151);
			this.ctbxStreet.Name = "ctbxStreet";
			this.ctbxStreet.Size = new System.Drawing.Size(346, 38);
			this.ctbxStreet.TabIndex = 58;
			this.ttInfo.SetToolTip(this.ctbxStreet, "Улица");
			this.ctbxStreet.TextChanged += new System.EventHandler(this.check);
			// 
			// ctbxCity
			// 
			this.ctbxCity.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
			this.ctbxCity.Cue = "Город";
			this.ctbxCity.Font = new System.Drawing.Font("Segoe UI", 13.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
			this.ctbxCity.Location = new System.Drawing.Point(5, 88);
			this.ctbxCity.Name = "ctbxCity";
			this.ctbxCity.Size = new System.Drawing.Size(346, 38);
			this.ctbxCity.TabIndex = 57;
			this.ttInfo.SetToolTip(this.ctbxCity, "Город");
			this.ctbxCity.TextChanged += new System.EventHandler(this.check);
			// 
			// ctbxIndex
			// 
			this.ctbxIndex.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
			this.ctbxIndex.Cue = "Индекс";
			this.ctbxIndex.Font = new System.Drawing.Font("Segoe UI", 13.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
			this.ctbxIndex.Location = new System.Drawing.Point(5, 25);
			this.ctbxIndex.Margin = new System.Windows.Forms.Padding(0);
			this.ctbxIndex.Name = "ctbxIndex";
			this.ctbxIndex.Size = new System.Drawing.Size(346, 38);
			this.ctbxIndex.TabIndex = 56;
			this.ttInfo.SetToolTip(this.ctbxIndex, "Индекс");
			this.ctbxIndex.TextChanged += new System.EventHandler(this.check);
			// 
			// btnReg
			// 
			this.btnReg.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(192)))), ((int)(((byte)(0)))));
			this.btnReg.BackgroundImage = global::Apteka.Properties.Resources.fon;
			this.btnReg.Cursor = System.Windows.Forms.Cursors.Hand;
			this.btnReg.Dock = System.Windows.Forms.DockStyle.Fill;
			this.btnReg.Enabled = false;
			this.btnReg.FlatAppearance.BorderSize = 0;
			this.btnReg.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
			this.btnReg.Font = new System.Drawing.Font("Segoe UI Semibold", 16F, System.Drawing.FontStyle.Bold);
			this.btnReg.ForeColor = System.Drawing.Color.White;
			this.btnReg.Location = new System.Drawing.Point(0, 0);
			this.btnReg.Margin = new System.Windows.Forms.Padding(0);
			this.btnReg.Name = "btnReg";
			this.btnReg.Size = new System.Drawing.Size(700, 75);
			this.btnReg.TabIndex = 43;
			this.btnReg.TabStop = false;
			this.btnReg.Text = "Зарегистрировать";
			this.btnReg.UseVisualStyleBackColor = false;
			this.btnReg.Click += new System.EventHandler(this.btnReg_Click);
			// 
			// Registration
			// 
			this.AutoScaleDimensions = new System.Drawing.SizeF(12F, 28F);
			this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
			this.BackColor = System.Drawing.Color.White;
			this.ClientSize = new System.Drawing.Size(700, 650);
			this.Controls.Add(this.sp1);
			this.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Bold);
			this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
			this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
			this.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
			this.Name = "Registration";
			this.Text = "Registration";
			this.Load += new System.EventHandler(this.Registration_Load);
			this.sp1.Panel1.ResumeLayout(false);
			this.sp1.Panel2.ResumeLayout(false);
			((System.ComponentModel.ISupportInitialize)(this.sp1)).EndInit();
			this.sp1.ResumeLayout(false);
			((System.ComponentModel.ISupportInitialize)(this.pbClose)).EndInit();
			this.sp2.Panel1.ResumeLayout(false);
			this.sp2.Panel2.ResumeLayout(false);
			((System.ComponentModel.ISupportInitialize)(this.sp2)).EndInit();
			this.sp2.ResumeLayout(false);
			this.sp3.Panel1.ResumeLayout(false);
			this.sp3.Panel1.PerformLayout();
			this.sp3.Panel2.ResumeLayout(false);
			this.sp3.Panel2.PerformLayout();
			((System.ComponentModel.ISupportInitialize)(this.sp3)).EndInit();
			this.sp3.ResumeLayout(false);
			((System.ComponentModel.ISupportInitialize)(this.pbVisiblePass)).EndInit();
			((System.ComponentModel.ISupportInitialize)(this.pbVisibleAgPass)).EndInit();
			this.ResumeLayout(false);

		}

		#endregion

		private System.Windows.Forms.SplitContainer sp1;
		private System.Windows.Forms.Label label2;
		private System.Windows.Forms.SplitContainer sp2;
		private System.Windows.Forms.SplitContainer sp3;
		private System.Windows.Forms.Button btnReg;
		private CueTextBox ctbxPasswordAgain;
		private CueTextBox ctbxLogin;
		private CueTextBox ctbxmName;
		private CueTextBox ctbxName;
		private CueTextBox ctbxlName;
		private CueTextBox ctbxEmail;
		private CueTextBox ctbxPhone;
		private CueTextBox ctbxHome;
		private CueTextBox ctbxFlat;
		private CueTextBox ctbxStreet;
		private CueTextBox ctbxCity;
		private CueTextBox ctbxIndex;
		private System.Windows.Forms.DateTimePicker dtpbDay;
		private System.Windows.Forms.ToolTip ttInfo;
		private System.Windows.Forms.PictureBox pbClose;
		private CueTextBox ctbxPassword;
		private System.Windows.Forms.PictureBox pbVisiblePass;
		private System.Windows.Forms.PictureBox pbVisibleAgPass;
	}
}