namespace Apteka
{
	partial class UsersAdm
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
			this.pbClose = new System.Windows.Forms.PictureBox();
			this.btnAccept = new System.Windows.Forms.Button();
			this.dgvAdpInfoAdm = new System.Windows.Forms.DataGridView();
			this.idUDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
			this.lNameDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
			this.nameDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
			this.mNameDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
			this.typeDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
			this.typeString = new System.Windows.Forms.DataGridViewTextBoxColumn();
			this.bDayDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
			this.indexDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
			this.cityDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
			this.streetDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
			this.domDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
			this.floatDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
			this.phoneDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
			this.loginDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
			this.passwordDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
			this.emailDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
			this.bsUser = new System.Windows.Forms.BindingSource(this.components);
			this.dsApteka = new Apteka.dsApteka();
			this.userTableAdapter = new Apteka.dsAptekaTableAdapters.UserTableAdapter();
			((System.ComponentModel.ISupportInitialize)(this.pbClose)).BeginInit();
			((System.ComponentModel.ISupportInitialize)(this.dgvAdpInfoAdm)).BeginInit();
			((System.ComponentModel.ISupportInitialize)(this.bsUser)).BeginInit();
			((System.ComponentModel.ISupportInitialize)(this.dsApteka)).BeginInit();
			this.SuspendLayout();
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
			this.pbClose.TabIndex = 53;
			this.pbClose.TabStop = false;
			this.pbClose.Tag = "100";
			this.pbClose.Click += new System.EventHandler(this.pbClose_Click);
			// 
			// btnAccept
			// 
			this.btnAccept.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(192)))), ((int)(((byte)(0)))));
			this.btnAccept.Cursor = System.Windows.Forms.Cursors.Hand;
			this.btnAccept.Dock = System.Windows.Forms.DockStyle.Bottom;
			this.btnAccept.FlatAppearance.BorderSize = 0;
			this.btnAccept.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
			this.btnAccept.Font = new System.Drawing.Font("Segoe UI Semibold", 16F, System.Drawing.FontStyle.Bold);
			this.btnAccept.ForeColor = System.Drawing.Color.White;
			this.btnAccept.Location = new System.Drawing.Point(25, 555);
			this.btnAccept.Margin = new System.Windows.Forms.Padding(0);
			this.btnAccept.Name = "btnAccept";
			this.btnAccept.Size = new System.Drawing.Size(650, 70);
			this.btnAccept.TabIndex = 75;
			this.btnAccept.TabStop = false;
			this.btnAccept.Text = "Сохранить изменения";
			this.btnAccept.UseVisualStyleBackColor = false;
			this.btnAccept.Click += new System.EventHandler(this.btnAccept_Click);
			// 
			// dgvAdpInfoAdm
			// 
			this.dgvAdpInfoAdm.AllowUserToAddRows = false;
			this.dgvAdpInfoAdm.AllowUserToDeleteRows = false;
			this.dgvAdpInfoAdm.AutoGenerateColumns = false;
			this.dgvAdpInfoAdm.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.AllCells;
			this.dgvAdpInfoAdm.BackgroundColor = System.Drawing.Color.White;
			this.dgvAdpInfoAdm.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
			this.dgvAdpInfoAdm.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.idUDataGridViewTextBoxColumn,
            this.lNameDataGridViewTextBoxColumn,
            this.nameDataGridViewTextBoxColumn,
            this.mNameDataGridViewTextBoxColumn,
            this.typeDataGridViewTextBoxColumn,
            this.typeString,
            this.bDayDataGridViewTextBoxColumn,
            this.indexDataGridViewTextBoxColumn,
            this.cityDataGridViewTextBoxColumn,
            this.streetDataGridViewTextBoxColumn,
            this.domDataGridViewTextBoxColumn,
            this.floatDataGridViewTextBoxColumn,
            this.phoneDataGridViewTextBoxColumn,
            this.loginDataGridViewTextBoxColumn,
            this.passwordDataGridViewTextBoxColumn,
            this.emailDataGridViewTextBoxColumn});
			this.dgvAdpInfoAdm.DataSource = this.bsUser;
			this.dgvAdpInfoAdm.Dock = System.Windows.Forms.DockStyle.Fill;
			this.dgvAdpInfoAdm.Location = new System.Drawing.Point(25, 25);
			this.dgvAdpInfoAdm.Name = "dgvAdpInfoAdm";
			this.dgvAdpInfoAdm.RowTemplate.Height = 24;
			this.dgvAdpInfoAdm.Size = new System.Drawing.Size(650, 530);
			this.dgvAdpInfoAdm.TabIndex = 76;
			this.dgvAdpInfoAdm.CellValidating += new System.Windows.Forms.DataGridViewCellValidatingEventHandler(this.dgvAdpInfoAdm_CellValidating);
			// 
			// idUDataGridViewTextBoxColumn
			// 
			this.idUDataGridViewTextBoxColumn.DataPropertyName = "idU";
			this.idUDataGridViewTextBoxColumn.HeaderText = "idU";
			this.idUDataGridViewTextBoxColumn.Name = "idUDataGridViewTextBoxColumn";
			this.idUDataGridViewTextBoxColumn.ReadOnly = true;
			this.idUDataGridViewTextBoxColumn.Visible = false;
			this.idUDataGridViewTextBoxColumn.Width = 58;
			// 
			// lNameDataGridViewTextBoxColumn
			// 
			this.lNameDataGridViewTextBoxColumn.DataPropertyName = "lName";
			this.lNameDataGridViewTextBoxColumn.HeaderText = "Фамилия";
			this.lNameDataGridViewTextBoxColumn.Name = "lNameDataGridViewTextBoxColumn";
			this.lNameDataGridViewTextBoxColumn.Width = 154;
			// 
			// nameDataGridViewTextBoxColumn
			// 
			this.nameDataGridViewTextBoxColumn.DataPropertyName = "name";
			this.nameDataGridViewTextBoxColumn.HeaderText = "Имя";
			this.nameDataGridViewTextBoxColumn.Name = "nameDataGridViewTextBoxColumn";
			this.nameDataGridViewTextBoxColumn.Width = 96;
			// 
			// mNameDataGridViewTextBoxColumn
			// 
			this.mNameDataGridViewTextBoxColumn.DataPropertyName = "mName";
			this.mNameDataGridViewTextBoxColumn.HeaderText = "Отчество";
			this.mNameDataGridViewTextBoxColumn.Name = "mNameDataGridViewTextBoxColumn";
			this.mNameDataGridViewTextBoxColumn.Width = 152;
			// 
			// typeDataGridViewTextBoxColumn
			// 
			this.typeDataGridViewTextBoxColumn.DataPropertyName = "type";
			this.typeDataGridViewTextBoxColumn.HeaderText = "Тип";
			this.typeDataGridViewTextBoxColumn.Name = "typeDataGridViewTextBoxColumn";
			this.typeDataGridViewTextBoxColumn.Width = 86;
			// 
			// typeString
			// 
			this.typeString.DataPropertyName = "typeString";
			this.typeString.HeaderText = "Должность";
			this.typeString.Name = "typeString";
			this.typeString.ReadOnly = true;
			this.typeString.Width = 178;
			// 
			// bDayDataGridViewTextBoxColumn
			// 
			this.bDayDataGridViewTextBoxColumn.DataPropertyName = "bDay";
			this.bDayDataGridViewTextBoxColumn.HeaderText = "Дата рождения";
			this.bDayDataGridViewTextBoxColumn.Name = "bDayDataGridViewTextBoxColumn";
			this.bDayDataGridViewTextBoxColumn.Width = 208;
			// 
			// indexDataGridViewTextBoxColumn
			// 
			this.indexDataGridViewTextBoxColumn.DataPropertyName = "index";
			this.indexDataGridViewTextBoxColumn.HeaderText = "Индекс";
			this.indexDataGridViewTextBoxColumn.Name = "indexDataGridViewTextBoxColumn";
			this.indexDataGridViewTextBoxColumn.Width = 131;
			// 
			// cityDataGridViewTextBoxColumn
			// 
			this.cityDataGridViewTextBoxColumn.DataPropertyName = "city";
			this.cityDataGridViewTextBoxColumn.HeaderText = "Город";
			this.cityDataGridViewTextBoxColumn.Name = "cityDataGridViewTextBoxColumn";
			this.cityDataGridViewTextBoxColumn.Width = 114;
			// 
			// streetDataGridViewTextBoxColumn
			// 
			this.streetDataGridViewTextBoxColumn.DataPropertyName = "street";
			this.streetDataGridViewTextBoxColumn.HeaderText = "Улица";
			this.streetDataGridViewTextBoxColumn.Name = "streetDataGridViewTextBoxColumn";
			this.streetDataGridViewTextBoxColumn.Width = 115;
			// 
			// domDataGridViewTextBoxColumn
			// 
			this.domDataGridViewTextBoxColumn.DataPropertyName = "dom";
			this.domDataGridViewTextBoxColumn.HeaderText = "Дом";
			this.domDataGridViewTextBoxColumn.Name = "domDataGridViewTextBoxColumn";
			this.domDataGridViewTextBoxColumn.Width = 97;
			// 
			// floatDataGridViewTextBoxColumn
			// 
			this.floatDataGridViewTextBoxColumn.DataPropertyName = "float";
			this.floatDataGridViewTextBoxColumn.HeaderText = "Квартира";
			this.floatDataGridViewTextBoxColumn.Name = "floatDataGridViewTextBoxColumn";
			this.floatDataGridViewTextBoxColumn.Width = 156;
			// 
			// phoneDataGridViewTextBoxColumn
			// 
			this.phoneDataGridViewTextBoxColumn.DataPropertyName = "phone";
			this.phoneDataGridViewTextBoxColumn.HeaderText = "Телефон";
			this.phoneDataGridViewTextBoxColumn.Name = "phoneDataGridViewTextBoxColumn";
			this.phoneDataGridViewTextBoxColumn.Width = 145;
			// 
			// loginDataGridViewTextBoxColumn
			// 
			this.loginDataGridViewTextBoxColumn.DataPropertyName = "login";
			this.loginDataGridViewTextBoxColumn.HeaderText = "Логин";
			this.loginDataGridViewTextBoxColumn.Name = "loginDataGridViewTextBoxColumn";
			this.loginDataGridViewTextBoxColumn.Width = 117;
			// 
			// passwordDataGridViewTextBoxColumn
			// 
			this.passwordDataGridViewTextBoxColumn.DataPropertyName = "password";
			this.passwordDataGridViewTextBoxColumn.HeaderText = "Пароль";
			this.passwordDataGridViewTextBoxColumn.Name = "passwordDataGridViewTextBoxColumn";
			this.passwordDataGridViewTextBoxColumn.Width = 132;
			// 
			// emailDataGridViewTextBoxColumn
			// 
			this.emailDataGridViewTextBoxColumn.DataPropertyName = "email";
			this.emailDataGridViewTextBoxColumn.HeaderText = "Эл. почта";
			this.emailDataGridViewTextBoxColumn.Name = "emailDataGridViewTextBoxColumn";
			this.emailDataGridViewTextBoxColumn.Width = 142;
			// 
			// bsUser
			// 
			this.bsUser.DataMember = "User";
			this.bsUser.DataSource = this.dsApteka;
			// 
			// dsApteka
			// 
			this.dsApteka.DataSetName = "dsApteka";
			this.dsApteka.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
			// 
			// userTableAdapter
			// 
			this.userTableAdapter.ClearBeforeFill = true;
			// 
			// UsersAdm
			// 
			this.AutoScaleDimensions = new System.Drawing.SizeF(14F, 31F);
			this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
			this.BackColor = System.Drawing.Color.White;
			this.ClientSize = new System.Drawing.Size(700, 650);
			this.Controls.Add(this.dgvAdpInfoAdm);
			this.Controls.Add(this.btnAccept);
			this.Controls.Add(this.pbClose);
			this.Font = new System.Drawing.Font("Segoe UI", 14F, System.Drawing.FontStyle.Bold);
			this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
			this.Margin = new System.Windows.Forms.Padding(5, 6, 5, 6);
			this.Name = "UsersAdm";
			this.Padding = new System.Windows.Forms.Padding(25);
			this.Text = "UsersAdm";
			this.Load += new System.EventHandler(this.UsersAdm_Load);
			((System.ComponentModel.ISupportInitialize)(this.pbClose)).EndInit();
			((System.ComponentModel.ISupportInitialize)(this.dgvAdpInfoAdm)).EndInit();
			((System.ComponentModel.ISupportInitialize)(this.bsUser)).EndInit();
			((System.ComponentModel.ISupportInitialize)(this.dsApteka)).EndInit();
			this.ResumeLayout(false);

		}

		#endregion

		private System.Windows.Forms.PictureBox pbClose;
		private dsApteka dsApteka;
		private System.Windows.Forms.BindingSource bsUser;
		public System.Windows.Forms.Button btnAccept;
		private System.Windows.Forms.DataGridView dgvAdpInfoAdm;
		private System.Windows.Forms.DataGridViewTextBoxColumn typeString;
		private System.Windows.Forms.DataGridViewTextBoxColumn idUDataGridViewTextBoxColumn;
		private System.Windows.Forms.DataGridViewTextBoxColumn lNameDataGridViewTextBoxColumn;
		private System.Windows.Forms.DataGridViewTextBoxColumn nameDataGridViewTextBoxColumn;
		private System.Windows.Forms.DataGridViewTextBoxColumn mNameDataGridViewTextBoxColumn;
		private System.Windows.Forms.DataGridViewTextBoxColumn typeDataGridViewTextBoxColumn;
		private System.Windows.Forms.DataGridViewTextBoxColumn bDayDataGridViewTextBoxColumn;
		private System.Windows.Forms.DataGridViewTextBoxColumn indexDataGridViewTextBoxColumn;
		private System.Windows.Forms.DataGridViewTextBoxColumn cityDataGridViewTextBoxColumn;
		private System.Windows.Forms.DataGridViewTextBoxColumn streetDataGridViewTextBoxColumn;
		private System.Windows.Forms.DataGridViewTextBoxColumn domDataGridViewTextBoxColumn;
		private System.Windows.Forms.DataGridViewTextBoxColumn floatDataGridViewTextBoxColumn;
		private System.Windows.Forms.DataGridViewTextBoxColumn phoneDataGridViewTextBoxColumn;
		private System.Windows.Forms.DataGridViewTextBoxColumn loginDataGridViewTextBoxColumn;
		private System.Windows.Forms.DataGridViewTextBoxColumn passwordDataGridViewTextBoxColumn;
		private System.Windows.Forms.DataGridViewTextBoxColumn emailDataGridViewTextBoxColumn;
		private dsAptekaTableAdapters.UserTableAdapter userTableAdapter;
	}
}