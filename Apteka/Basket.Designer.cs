namespace Apteka
{
	partial class Basket
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
			this.dsApteka = new Apteka.dsApteka();
			this.p1 = new System.Windows.Forms.Panel();
			this.bsAdpBasket = new System.Windows.Forms.BindingSource(this.components);
			this.adpBasketTableAdapter = new Apteka.dsAptekaTableAdapters.adpBasketTableAdapter();
			this.pbClose = new System.Windows.Forms.PictureBox();
			this.dgvBasket = new System.Windows.Forms.DataGridView();
			this.rbt0 = new System.Windows.Forms.RadioButton();
			this.rbt1 = new System.Windows.Forms.RadioButton();
			this.gbPay = new System.Windows.Forms.GroupBox();
			this.btnBuy = new System.Windows.Forms.Button();
			this.dtpDate = new System.Windows.Forms.DateTimePicker();
			this.mtbxTime = new System.Windows.Forms.MaskedTextBox();
			this.gbDateTime = new System.Windows.Forms.GroupBox();
			this.lblPrice = new System.Windows.Forms.Label();
			this.dataGridViewTextBoxColumn1 = new System.Windows.Forms.DataGridViewTextBoxColumn();
			this.dataGridViewTextBoxColumn7 = new System.Windows.Forms.DataGridViewTextBoxColumn();
			this.countt = new System.Windows.Forms.DataGridViewTextBoxColumn();
			this.stockk = new System.Windows.Forms.DataGridViewTextBoxColumn();
			this.Add = new System.Windows.Forms.DataGridViewButtonColumn();
			this.Rem = new System.Windows.Forms.DataGridViewButtonColumn();
			this.dataGridViewTextBoxColumn5 = new System.Windows.Forms.DataGridViewTextBoxColumn();
			this.dataGridViewTextBoxColumn6 = new System.Windows.Forms.DataGridViewTextBoxColumn();
			this.dataGridViewTextBoxColumn3 = new System.Windows.Forms.DataGridViewTextBoxColumn();
			((System.ComponentModel.ISupportInitialize)(this.dsApteka)).BeginInit();
			this.p1.SuspendLayout();
			((System.ComponentModel.ISupportInitialize)(this.bsAdpBasket)).BeginInit();
			((System.ComponentModel.ISupportInitialize)(this.pbClose)).BeginInit();
			((System.ComponentModel.ISupportInitialize)(this.dgvBasket)).BeginInit();
			this.gbPay.SuspendLayout();
			this.gbDateTime.SuspendLayout();
			this.SuspendLayout();
			// 
			// dsApteka
			// 
			this.dsApteka.DataSetName = "dsApteka";
			this.dsApteka.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
			// 
			// p1
			// 
			this.p1.Controls.Add(this.lblPrice);
			this.p1.Controls.Add(this.gbPay);
			this.p1.Controls.Add(this.gbDateTime);
			this.p1.Dock = System.Windows.Forms.DockStyle.Bottom;
			this.p1.Location = new System.Drawing.Point(25, 330);
			this.p1.Name = "p1";
			this.p1.Padding = new System.Windows.Forms.Padding(5);
			this.p1.Size = new System.Drawing.Size(650, 220);
			this.p1.TabIndex = 46;
			// 
			// bsAdpBasket
			// 
			this.bsAdpBasket.DataMember = "adpBasket";
			this.bsAdpBasket.DataSource = this.dsApteka;
			// 
			// adpBasketTableAdapter
			// 
			this.adpBasketTableAdapter.ClearBeforeFill = true;
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
			this.pbClose.TabIndex = 51;
			this.pbClose.TabStop = false;
			this.pbClose.Tag = "100";
			this.pbClose.Click += new System.EventHandler(this.pbClose_Click);
			// 
			// dgvBasket
			// 
			this.dgvBasket.AllowUserToAddRows = false;
			this.dgvBasket.AllowUserToDeleteRows = false;
			this.dgvBasket.AutoGenerateColumns = false;
			this.dgvBasket.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.AllCells;
			this.dgvBasket.BackgroundColor = System.Drawing.Color.White;
			this.dgvBasket.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
			this.dgvBasket.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.dataGridViewTextBoxColumn1,
            this.dataGridViewTextBoxColumn7,
            this.countt,
            this.stockk,
            this.Add,
            this.Rem,
            this.dataGridViewTextBoxColumn5,
            this.dataGridViewTextBoxColumn6,
            this.dataGridViewTextBoxColumn3});
			this.dgvBasket.DataSource = this.bsAdpBasket;
			this.dgvBasket.Dock = System.Windows.Forms.DockStyle.Fill;
			this.dgvBasket.Location = new System.Drawing.Point(25, 25);
			this.dgvBasket.Name = "dgvBasket";
			this.dgvBasket.RowTemplate.Height = 24;
			this.dgvBasket.Size = new System.Drawing.Size(650, 600);
			this.dgvBasket.TabIndex = 0;
			this.dgvBasket.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgvBasket_CellClick);
			// 
			// rbt0
			// 
			this.rbt0.AutoSize = true;
			this.rbt0.Checked = true;
			this.rbt0.Location = new System.Drawing.Point(5, 36);
			this.rbt0.Name = "rbt0";
			this.rbt0.Size = new System.Drawing.Size(176, 36);
			this.rbt0.TabIndex = 0;
			this.rbt0.TabStop = true;
			this.rbt0.Text = "наличными";
			this.rbt0.UseVisualStyleBackColor = true;
			// 
			// rbt1
			// 
			this.rbt1.AutoSize = true;
			this.rbt1.Location = new System.Drawing.Point(239, 36);
			this.rbt1.Name = "rbt1";
			this.rbt1.Size = new System.Drawing.Size(118, 36);
			this.rbt1.TabIndex = 1;
			this.rbt1.Text = "картой";
			this.rbt1.UseVisualStyleBackColor = true;
			// 
			// gbPay
			// 
			this.gbPay.Controls.Add(this.rbt1);
			this.gbPay.Controls.Add(this.rbt0);
			this.gbPay.Dock = System.Windows.Forms.DockStyle.Top;
			this.gbPay.Location = new System.Drawing.Point(5, 85);
			this.gbPay.Name = "gbPay";
			this.gbPay.Padding = new System.Windows.Forms.Padding(5);
			this.gbPay.Size = new System.Drawing.Size(640, 80);
			this.gbPay.TabIndex = 46;
			this.gbPay.TabStop = false;
			this.gbPay.Text = "Выберите способ оплаты:";
			// 
			// btnBuy
			// 
			this.btnBuy.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(192)))), ((int)(((byte)(0)))));
			this.btnBuy.BackgroundImage = global::Apteka.Properties.Resources.fon;
			this.btnBuy.Cursor = System.Windows.Forms.Cursors.Hand;
			this.btnBuy.Dock = System.Windows.Forms.DockStyle.Bottom;
			this.btnBuy.Enabled = false;
			this.btnBuy.FlatAppearance.BorderSize = 0;
			this.btnBuy.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
			this.btnBuy.Font = new System.Drawing.Font("Segoe UI Semibold", 16F, System.Drawing.FontStyle.Bold);
			this.btnBuy.ForeColor = System.Drawing.Color.White;
			this.btnBuy.Location = new System.Drawing.Point(25, 550);
			this.btnBuy.Margin = new System.Windows.Forms.Padding(0);
			this.btnBuy.Name = "btnBuy";
			this.btnBuy.Size = new System.Drawing.Size(650, 75);
			this.btnBuy.TabIndex = 45;
			this.btnBuy.TabStop = false;
			this.btnBuy.Text = "Сформировать заказ";
			this.btnBuy.UseVisualStyleBackColor = false;
			this.btnBuy.Click += new System.EventHandler(this.btnBuy_Click);
			// 
			// dtpDate
			// 
			this.dtpDate.Dock = System.Windows.Forms.DockStyle.Left;
			this.dtpDate.Location = new System.Drawing.Point(0, 31);
			this.dtpDate.Name = "dtpDate";
			this.dtpDate.Size = new System.Drawing.Size(316, 38);
			this.dtpDate.TabIndex = 0;
			// 
			// mtbxTime
			// 
			this.mtbxTime.Dock = System.Windows.Forms.DockStyle.Right;
			this.mtbxTime.Location = new System.Drawing.Point(324, 31);
			this.mtbxTime.Mask = "00:00";
			this.mtbxTime.Name = "mtbxTime";
			this.mtbxTime.Size = new System.Drawing.Size(316, 38);
			this.mtbxTime.TabIndex = 1;
			this.mtbxTime.TabStop = false;
			this.mtbxTime.Text = "1200";
			this.mtbxTime.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
			this.mtbxTime.ValidatingType = typeof(System.DateTime);
			// 
			// gbDateTime
			// 
			this.gbDateTime.Controls.Add(this.mtbxTime);
			this.gbDateTime.Controls.Add(this.dtpDate);
			this.gbDateTime.Dock = System.Windows.Forms.DockStyle.Top;
			this.gbDateTime.Location = new System.Drawing.Point(5, 5);
			this.gbDateTime.Name = "gbDateTime";
			this.gbDateTime.Padding = new System.Windows.Forms.Padding(0, 0, 0, 5);
			this.gbDateTime.Size = new System.Drawing.Size(640, 80);
			this.gbDateTime.TabIndex = 45;
			this.gbDateTime.TabStop = false;
			this.gbDateTime.Text = "Укажите желательную дату и время доставки:";
			// 
			// lblPrice
			// 
			this.lblPrice.BackColor = System.Drawing.Color.Transparent;
			this.lblPrice.Dock = System.Windows.Forms.DockStyle.Bottom;
			this.lblPrice.Font = new System.Drawing.Font("Segoe UI Black", 16.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
			this.lblPrice.ForeColor = System.Drawing.Color.ForestGreen;
			this.lblPrice.Location = new System.Drawing.Point(5, 168);
			this.lblPrice.Margin = new System.Windows.Forms.Padding(0);
			this.lblPrice.Name = "lblPrice";
			this.lblPrice.Size = new System.Drawing.Size(640, 47);
			this.lblPrice.TabIndex = 48;
			this.lblPrice.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
			// 
			// dataGridViewTextBoxColumn1
			// 
			this.dataGridViewTextBoxColumn1.DataPropertyName = "name";
			this.dataGridViewTextBoxColumn1.Frozen = true;
			this.dataGridViewTextBoxColumn1.HeaderText = "Название";
			this.dataGridViewTextBoxColumn1.Name = "dataGridViewTextBoxColumn1";
			this.dataGridViewTextBoxColumn1.ReadOnly = true;
			this.dataGridViewTextBoxColumn1.Width = 157;
			// 
			// dataGridViewTextBoxColumn7
			// 
			this.dataGridViewTextBoxColumn7.DataPropertyName = "itogprice";
			this.dataGridViewTextBoxColumn7.Frozen = true;
			this.dataGridViewTextBoxColumn7.HeaderText = "Цена";
			this.dataGridViewTextBoxColumn7.Name = "dataGridViewTextBoxColumn7";
			this.dataGridViewTextBoxColumn7.ReadOnly = true;
			this.dataGridViewTextBoxColumn7.Width = 105;
			// 
			// countt
			// 
			this.countt.DataPropertyName = "count";
			this.countt.Frozen = true;
			this.countt.HeaderText = "Кол-во";
			this.countt.Name = "countt";
			this.countt.Width = 128;
			// 
			// stockk
			// 
			this.stockk.DataPropertyName = "stock";
			this.stockk.Frozen = true;
			this.stockk.HeaderText = "На складе";
			this.stockk.Name = "stockk";
			this.stockk.ReadOnly = true;
			this.stockk.Width = 162;
			// 
			// Add
			// 
			this.Add.FillWeight = 50F;
			this.Add.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
			this.Add.Frozen = true;
			this.Add.HeaderText = "+";
			this.Add.MinimumWidth = 50;
			this.Add.Name = "Add";
			this.Add.Text = "+";
			this.Add.UseColumnTextForButtonValue = true;
			this.Add.Width = 50;
			// 
			// Rem
			// 
			this.Rem.FillWeight = 50F;
			this.Rem.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
			this.Rem.Frozen = true;
			this.Rem.HeaderText = "-";
			this.Rem.MinimumWidth = 50;
			this.Rem.Name = "Rem";
			this.Rem.Text = "-";
			this.Rem.UseColumnTextForButtonValue = true;
			this.Rem.Width = 50;
			// 
			// dataGridViewTextBoxColumn5
			// 
			this.dataGridViewTextBoxColumn5.DataPropertyName = "idG";
			this.dataGridViewTextBoxColumn5.Frozen = true;
			this.dataGridViewTextBoxColumn5.HeaderText = "idG";
			this.dataGridViewTextBoxColumn5.Name = "dataGridViewTextBoxColumn5";
			this.dataGridViewTextBoxColumn5.ReadOnly = true;
			this.dataGridViewTextBoxColumn5.Visible = false;
			this.dataGridViewTextBoxColumn5.Width = 83;
			// 
			// dataGridViewTextBoxColumn6
			// 
			this.dataGridViewTextBoxColumn6.DataPropertyName = "idB";
			this.dataGridViewTextBoxColumn6.Frozen = true;
			this.dataGridViewTextBoxColumn6.HeaderText = "idB";
			this.dataGridViewTextBoxColumn6.Name = "dataGridViewTextBoxColumn6";
			this.dataGridViewTextBoxColumn6.ReadOnly = true;
			this.dataGridViewTextBoxColumn6.Visible = false;
			this.dataGridViewTextBoxColumn6.Width = 81;
			// 
			// dataGridViewTextBoxColumn3
			// 
			this.dataGridViewTextBoxColumn3.DataPropertyName = "idU";
			this.dataGridViewTextBoxColumn3.Frozen = true;
			this.dataGridViewTextBoxColumn3.HeaderText = "idU";
			this.dataGridViewTextBoxColumn3.Name = "dataGridViewTextBoxColumn3";
			this.dataGridViewTextBoxColumn3.ReadOnly = true;
			this.dataGridViewTextBoxColumn3.Visible = false;
			this.dataGridViewTextBoxColumn3.Width = 83;
			// 
			// Basket
			// 
			this.AutoScaleDimensions = new System.Drawing.SizeF(14F, 31F);
			this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
			this.BackColor = System.Drawing.Color.White;
			this.ClientSize = new System.Drawing.Size(700, 650);
			this.Controls.Add(this.pbClose);
			this.Controls.Add(this.p1);
			this.Controls.Add(this.btnBuy);
			this.Controls.Add(this.dgvBasket);
			this.Font = new System.Drawing.Font("Segoe UI", 13.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
			this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
			this.Margin = new System.Windows.Forms.Padding(5, 6, 5, 6);
			this.Name = "Basket";
			this.Padding = new System.Windows.Forms.Padding(25);
			this.StartPosition = System.Windows.Forms.FormStartPosition.CenterParent;
			this.Text = "ListBasket";
			this.Load += new System.EventHandler(this.ListBasket_Load);
			this.Resize += new System.EventHandler(this.ListBasket_Resize);
			((System.ComponentModel.ISupportInitialize)(this.dsApteka)).EndInit();
			this.p1.ResumeLayout(false);
			((System.ComponentModel.ISupportInitialize)(this.bsAdpBasket)).EndInit();
			((System.ComponentModel.ISupportInitialize)(this.pbClose)).EndInit();
			((System.ComponentModel.ISupportInitialize)(this.dgvBasket)).EndInit();
			this.gbPay.ResumeLayout(false);
			this.gbPay.PerformLayout();
			this.gbDateTime.ResumeLayout(false);
			this.gbDateTime.PerformLayout();
			this.ResumeLayout(false);

		}

		#endregion

		private dsApteka dsApteka;
		private System.Windows.Forms.Panel p1;
		public System.Windows.Forms.BindingSource bsAdpBasket;
		private dsAptekaTableAdapters.adpBasketTableAdapter adpBasketTableAdapter;
		private System.Windows.Forms.PictureBox pbClose;
		private System.Windows.Forms.GroupBox gbPay;
		private System.Windows.Forms.RadioButton rbt1;
		private System.Windows.Forms.RadioButton rbt0;
		private System.Windows.Forms.GroupBox gbDateTime;
		private System.Windows.Forms.MaskedTextBox mtbxTime;
		private System.Windows.Forms.DateTimePicker dtpDate;
		private System.Windows.Forms.DataGridView dgvBasket;
		private System.Windows.Forms.Button btnBuy;
		private System.Windows.Forms.Label lblPrice;
		private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn1;
		private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn7;
		private System.Windows.Forms.DataGridViewTextBoxColumn countt;
		private System.Windows.Forms.DataGridViewTextBoxColumn stockk;
		private System.Windows.Forms.DataGridViewButtonColumn Add;
		private System.Windows.Forms.DataGridViewButtonColumn Rem;
		private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn5;
		private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn6;
		private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn3;
	}
}