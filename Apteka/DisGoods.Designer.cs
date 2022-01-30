namespace Apteka
{
	partial class DisGoods
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
			System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(DisGoods));
			System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle1 = new System.Windows.Forms.DataGridViewCellStyle();
			System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle2 = new System.Windows.Forms.DataGridViewCellStyle();
			this.pbClose = new System.Windows.Forms.PictureBox();
			this.dgvGoods = new System.Windows.Forms.DataGridView();
			this.bsGoods = new System.Windows.Forms.BindingSource(this.components);
			this.dsApteka = new Apteka.dsApteka();
			this.goodsTableAdapter = new Apteka.dsAptekaTableAdapters.GoodsTableAdapter();
			this.bsDiscard = new System.Windows.Forms.BindingSource(this.components);
			this.adpDiscardTableAdapter = new Apteka.dsAptekaTableAdapters.adpDiscardTableAdapter();
			this.tableAdapterManager = new Apteka.dsAptekaTableAdapters.TableAdapterManager();
			this.btnDel = new System.Windows.Forms.Button();
			this.btnDiscard = new System.Windows.Forms.Button();
			this.btnToExcel = new System.Windows.Forms.Button();
			this.id = new System.Windows.Forms.DataGridViewTextBoxColumn();
			this.image = new System.Windows.Forms.DataGridViewImageColumn();
			this.nameDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
			this.itogpriceDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
			this.stockDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
			this.count = new System.Windows.Forms.DataGridViewTextBoxColumn();
			this.reason = new System.Windows.Forms.DataGridViewTextBoxColumn();
			((System.ComponentModel.ISupportInitialize)(this.pbClose)).BeginInit();
			((System.ComponentModel.ISupportInitialize)(this.dgvGoods)).BeginInit();
			((System.ComponentModel.ISupportInitialize)(this.bsGoods)).BeginInit();
			((System.ComponentModel.ISupportInitialize)(this.dsApteka)).BeginInit();
			((System.ComponentModel.ISupportInitialize)(this.bsDiscard)).BeginInit();
			this.SuspendLayout();
			// 
			// pbClose
			// 
			this.pbClose.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
			this.pbClose.BackColor = System.Drawing.Color.Transparent;
			this.pbClose.Cursor = System.Windows.Forms.Cursors.Hand;
			this.pbClose.ErrorImage = global::Apteka.Properties.Resources.error;
			this.pbClose.Image = ((System.Drawing.Image)(resources.GetObject("pbClose.Image")));
			this.pbClose.Location = new System.Drawing.Point(745, 0);
			this.pbClose.Name = "pbClose";
			this.pbClose.Size = new System.Drawing.Size(25, 25);
			this.pbClose.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
			this.pbClose.TabIndex = 59;
			this.pbClose.TabStop = false;
			this.pbClose.Tag = "100";
			this.pbClose.Click += new System.EventHandler(this.pbClose_Click);
			// 
			// dgvGoods
			// 
			this.dgvGoods.AllowUserToAddRows = false;
			this.dgvGoods.AllowUserToDeleteRows = false;
			this.dgvGoods.AutoGenerateColumns = false;
			this.dgvGoods.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.AllCells;
			this.dgvGoods.AutoSizeRowsMode = System.Windows.Forms.DataGridViewAutoSizeRowsMode.AllCells;
			dataGridViewCellStyle1.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
			dataGridViewCellStyle1.BackColor = System.Drawing.SystemColors.Control;
			dataGridViewCellStyle1.Font = new System.Drawing.Font("Segoe UI", 14F, System.Drawing.FontStyle.Bold);
			dataGridViewCellStyle1.ForeColor = System.Drawing.SystemColors.WindowText;
			dataGridViewCellStyle1.SelectionBackColor = System.Drawing.SystemColors.Highlight;
			dataGridViewCellStyle1.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
			dataGridViewCellStyle1.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
			this.dgvGoods.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle1;
			this.dgvGoods.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
			this.dgvGoods.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.id,
            this.image,
            this.nameDataGridViewTextBoxColumn,
            this.itogpriceDataGridViewTextBoxColumn,
            this.stockDataGridViewTextBoxColumn,
            this.count,
            this.reason});
			this.dgvGoods.DataSource = this.bsGoods;
			this.dgvGoods.Dock = System.Windows.Forms.DockStyle.Top;
			this.dgvGoods.Location = new System.Drawing.Point(25, 25);
			this.dgvGoods.Name = "dgvGoods";
			dataGridViewCellStyle2.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
			dataGridViewCellStyle2.BackColor = System.Drawing.SystemColors.Control;
			dataGridViewCellStyle2.Font = new System.Drawing.Font("Segoe UI", 14F, System.Drawing.FontStyle.Bold);
			dataGridViewCellStyle2.ForeColor = System.Drawing.SystemColors.WindowText;
			dataGridViewCellStyle2.SelectionBackColor = System.Drawing.SystemColors.Highlight;
			dataGridViewCellStyle2.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
			dataGridViewCellStyle2.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
			this.dgvGoods.RowHeadersDefaultCellStyle = dataGridViewCellStyle2;
			this.dgvGoods.RowTemplate.Height = 50;
			this.dgvGoods.RowTemplate.Resizable = System.Windows.Forms.DataGridViewTriState.False;
			this.dgvGoods.Size = new System.Drawing.Size(720, 436);
			this.dgvGoods.TabIndex = 60;
			this.dgvGoods.CellValidating += new System.Windows.Forms.DataGridViewCellValidatingEventHandler(this.dgvGoods_CellValidating);
			// 
			// bsGoods
			// 
			this.bsGoods.DataMember = "Goods";
			this.bsGoods.DataSource = this.dsApteka;
			// 
			// dsApteka
			// 
			this.dsApteka.DataSetName = "dsApteka";
			this.dsApteka.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
			// 
			// goodsTableAdapter
			// 
			this.goodsTableAdapter.ClearBeforeFill = true;
			// 
			// bsDiscard
			// 
			this.bsDiscard.DataMember = "adpDiscard";
			this.bsDiscard.DataSource = this.dsApteka;
			// 
			// adpDiscardTableAdapter
			// 
			this.adpDiscardTableAdapter.ClearBeforeFill = true;
			// 
			// tableAdapterManager
			// 
			this.tableAdapterManager.BackupDataSetBeforeUpdate = false;
			this.tableAdapterManager.BasketTableAdapter = null;
			this.tableAdapterManager.FavoriteTableAdapter = null;
			this.tableAdapterManager.GoodsTableAdapter = this.goodsTableAdapter;
			this.tableAdapterManager.OGTableAdapter = null;
			this.tableAdapterManager.OrdersTableAdapter = null;
			this.tableAdapterManager.TGTableAdapter = null;
			this.tableAdapterManager.UpdateOrder = Apteka.dsAptekaTableAdapters.TableAdapterManager.UpdateOrderOption.InsertUpdateDelete;
			this.tableAdapterManager.UserTableAdapter = null;
			// 
			// btnDel
			// 
			this.btnDel.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(64)))), ((int)(((byte)(0)))));
			this.btnDel.Cursor = System.Windows.Forms.Cursors.Hand;
			this.btnDel.Dock = System.Windows.Forms.DockStyle.Bottom;
			this.btnDel.FlatAppearance.BorderSize = 0;
			this.btnDel.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
			this.btnDel.Font = new System.Drawing.Font("Segoe UI", 14F, System.Drawing.FontStyle.Bold);
			this.btnDel.ForeColor = System.Drawing.Color.White;
			this.btnDel.Location = new System.Drawing.Point(25, 575);
			this.btnDel.Margin = new System.Windows.Forms.Padding(0);
			this.btnDel.Name = "btnDel";
			this.btnDel.Size = new System.Drawing.Size(720, 50);
			this.btnDel.TabIndex = 69;
			this.btnDel.Text = "Удалить выделенный товар";
			this.btnDel.UseVisualStyleBackColor = false;
			this.btnDel.Click += new System.EventHandler(this.btnDel_Click);
			// 
			// btnDiscard
			// 
			this.btnDiscard.BackColor = System.Drawing.Color.Green;
			this.btnDiscard.Cursor = System.Windows.Forms.Cursors.Hand;
			this.btnDiscard.Dock = System.Windows.Forms.DockStyle.Bottom;
			this.btnDiscard.FlatAppearance.BorderSize = 0;
			this.btnDiscard.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
			this.btnDiscard.Font = new System.Drawing.Font("Segoe UI", 14F, System.Drawing.FontStyle.Bold);
			this.btnDiscard.ForeColor = System.Drawing.Color.White;
			this.btnDiscard.Location = new System.Drawing.Point(25, 525);
			this.btnDiscard.Margin = new System.Windows.Forms.Padding(0);
			this.btnDiscard.Name = "btnDiscard";
			this.btnDiscard.Size = new System.Drawing.Size(720, 50);
			this.btnDiscard.TabIndex = 70;
			this.btnDiscard.Text = "Списать товар";
			this.btnDiscard.UseVisualStyleBackColor = false;
			this.btnDiscard.Click += new System.EventHandler(this.btnDiscard_Click);
			// 
			// btnToExcel
			// 
			this.btnToExcel.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(192)))), ((int)(((byte)(0)))));
			this.btnToExcel.Cursor = System.Windows.Forms.Cursors.Hand;
			this.btnToExcel.Dock = System.Windows.Forms.DockStyle.Fill;
			this.btnToExcel.FlatAppearance.BorderSize = 0;
			this.btnToExcel.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
			this.btnToExcel.Font = new System.Drawing.Font("Segoe UI", 14F, System.Drawing.FontStyle.Bold);
			this.btnToExcel.ForeColor = System.Drawing.Color.White;
			this.btnToExcel.Location = new System.Drawing.Point(25, 461);
			this.btnToExcel.Margin = new System.Windows.Forms.Padding(0, 0, 0, 12);
			this.btnToExcel.Name = "btnToExcel";
			this.btnToExcel.Size = new System.Drawing.Size(720, 64);
			this.btnToExcel.TabIndex = 71;
			this.btnToExcel.Text = "Сформировать документ";
			this.btnToExcel.UseVisualStyleBackColor = false;
			this.btnToExcel.Click += new System.EventHandler(this.btnToExcel_Click);
			// 
			// id
			// 
			this.id.DataPropertyName = "idG";
			this.id.FillWeight = 150F;
			this.id.HeaderText = "id";
			this.id.Name = "id";
			this.id.ReadOnly = true;
			this.id.Visible = false;
			this.id.Width = 66;
			// 
			// image
			// 
			this.image.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.None;
			this.image.DataPropertyName = "image";
			this.image.FillWeight = 150F;
			this.image.HeaderText = "Фото";
			this.image.ImageLayout = System.Windows.Forms.DataGridViewImageCellLayout.Zoom;
			this.image.MinimumWidth = 150;
			this.image.Name = "image";
			this.image.ReadOnly = true;
			this.image.Width = 150;
			// 
			// nameDataGridViewTextBoxColumn
			// 
			this.nameDataGridViewTextBoxColumn.DataPropertyName = "name";
			this.nameDataGridViewTextBoxColumn.HeaderText = "Название";
			this.nameDataGridViewTextBoxColumn.Name = "nameDataGridViewTextBoxColumn";
			this.nameDataGridViewTextBoxColumn.ReadOnly = true;
			this.nameDataGridViewTextBoxColumn.Width = 157;
			// 
			// itogpriceDataGridViewTextBoxColumn
			// 
			this.itogpriceDataGridViewTextBoxColumn.DataPropertyName = "itogprice";
			this.itogpriceDataGridViewTextBoxColumn.HeaderText = "Цена";
			this.itogpriceDataGridViewTextBoxColumn.Name = "itogpriceDataGridViewTextBoxColumn";
			this.itogpriceDataGridViewTextBoxColumn.ReadOnly = true;
			this.itogpriceDataGridViewTextBoxColumn.Width = 105;
			// 
			// stockDataGridViewTextBoxColumn
			// 
			this.stockDataGridViewTextBoxColumn.DataPropertyName = "stock";
			this.stockDataGridViewTextBoxColumn.HeaderText = "На складе";
			this.stockDataGridViewTextBoxColumn.Name = "stockDataGridViewTextBoxColumn";
			this.stockDataGridViewTextBoxColumn.ReadOnly = true;
			this.stockDataGridViewTextBoxColumn.Width = 162;
			// 
			// count
			// 
			this.count.HeaderText = "Сколько списать";
			this.count.Name = "count";
			this.count.Width = 240;
			// 
			// reason
			// 
			this.reason.HeaderText = "Причина";
			this.reason.Name = "reason";
			this.reason.Width = 149;
			// 
			// DisGoods
			// 
			this.AutoScaleDimensions = new System.Drawing.SizeF(14F, 31F);
			this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
			this.ClientSize = new System.Drawing.Size(770, 650);
			this.Controls.Add(this.btnToExcel);
			this.Controls.Add(this.btnDiscard);
			this.Controls.Add(this.btnDel);
			this.Controls.Add(this.dgvGoods);
			this.Controls.Add(this.pbClose);
			this.Font = new System.Drawing.Font("Segoe UI", 14F, System.Drawing.FontStyle.Bold);
			this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
			this.Margin = new System.Windows.Forms.Padding(5, 6, 5, 6);
			this.Name = "DisGoods";
			this.Padding = new System.Windows.Forms.Padding(25);
			this.Text = "DelGoods";
			this.Load += new System.EventHandler(this.DisGoods_Load);
			((System.ComponentModel.ISupportInitialize)(this.pbClose)).EndInit();
			((System.ComponentModel.ISupportInitialize)(this.dgvGoods)).EndInit();
			((System.ComponentModel.ISupportInitialize)(this.bsGoods)).EndInit();
			((System.ComponentModel.ISupportInitialize)(this.dsApteka)).EndInit();
			((System.ComponentModel.ISupportInitialize)(this.bsDiscard)).EndInit();
			this.ResumeLayout(false);

		}

		#endregion

		private System.Windows.Forms.PictureBox pbClose;
		private System.Windows.Forms.DataGridView dgvGoods;
		private System.Windows.Forms.BindingSource bsGoods;
		private dsApteka dsApteka;
		private dsAptekaTableAdapters.GoodsTableAdapter goodsTableAdapter;
		private System.Windows.Forms.BindingSource bsDiscard;
		private dsAptekaTableAdapters.adpDiscardTableAdapter adpDiscardTableAdapter;
		private dsAptekaTableAdapters.TableAdapterManager tableAdapterManager;
		public System.Windows.Forms.Button btnDel;
		public System.Windows.Forms.Button btnDiscard;
		public System.Windows.Forms.Button btnToExcel;
		private System.Windows.Forms.DataGridViewTextBoxColumn id;
		private System.Windows.Forms.DataGridViewImageColumn image;
		private System.Windows.Forms.DataGridViewTextBoxColumn nameDataGridViewTextBoxColumn;
		private System.Windows.Forms.DataGridViewTextBoxColumn itogpriceDataGridViewTextBoxColumn;
		private System.Windows.Forms.DataGridViewTextBoxColumn stockDataGridViewTextBoxColumn;
		private System.Windows.Forms.DataGridViewTextBoxColumn count;
		private System.Windows.Forms.DataGridViewTextBoxColumn reason;
	}
}