namespace Apteka
{
	partial class ListOrderInfo
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
			System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(ListOrderInfo));
			this.adpOrderInfoDataGridView = new System.Windows.Forms.DataGridView();
			this.dataGridViewTextBoxColumn1 = new System.Windows.Forms.DataGridViewTextBoxColumn();
			this.dataGridViewTextBoxColumn2 = new System.Windows.Forms.DataGridViewTextBoxColumn();
			this.image = new System.Windows.Forms.DataGridViewImageColumn();
			this.dataGridViewTextBoxColumn3 = new System.Windows.Forms.DataGridViewTextBoxColumn();
			this.dataGridViewTextBoxColumn4 = new System.Windows.Forms.DataGridViewTextBoxColumn();
			this.count = new System.Windows.Forms.DataGridViewTextBoxColumn();
			this.itogprice = new System.Windows.Forms.DataGridViewTextBoxColumn();
			this.bsAdpOrderInfo = new System.Windows.Forms.BindingSource(this.components);
			this.dsApteka = new Apteka.dsApteka();
			this.adpOrderInfoTableAdapter = new Apteka.dsAptekaTableAdapters.adpOrderInfoTableAdapter();
			this.tableAdapterManager = new Apteka.dsAptekaTableAdapters.TableAdapterManager();
			this.pbClose = new System.Windows.Forms.PictureBox();
			((System.ComponentModel.ISupportInitialize)(this.adpOrderInfoDataGridView)).BeginInit();
			((System.ComponentModel.ISupportInitialize)(this.bsAdpOrderInfo)).BeginInit();
			((System.ComponentModel.ISupportInitialize)(this.dsApteka)).BeginInit();
			((System.ComponentModel.ISupportInitialize)(this.pbClose)).BeginInit();
			this.SuspendLayout();
			// 
			// adpOrderInfoDataGridView
			// 
			this.adpOrderInfoDataGridView.AutoGenerateColumns = false;
			this.adpOrderInfoDataGridView.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.AllCells;
			this.adpOrderInfoDataGridView.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
			this.adpOrderInfoDataGridView.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.dataGridViewTextBoxColumn1,
            this.dataGridViewTextBoxColumn2,
            this.image,
            this.dataGridViewTextBoxColumn3,
            this.dataGridViewTextBoxColumn4,
            this.count,
            this.itogprice});
			this.adpOrderInfoDataGridView.DataSource = this.bsAdpOrderInfo;
			this.adpOrderInfoDataGridView.Dock = System.Windows.Forms.DockStyle.Fill;
			this.adpOrderInfoDataGridView.Location = new System.Drawing.Point(25, 25);
			this.adpOrderInfoDataGridView.Name = "adpOrderInfoDataGridView";
			this.adpOrderInfoDataGridView.ReadOnly = true;
			this.adpOrderInfoDataGridView.RowTemplate.Height = 24;
			this.adpOrderInfoDataGridView.Size = new System.Drawing.Size(650, 600);
			this.adpOrderInfoDataGridView.TabIndex = 1;
			// 
			// dataGridViewTextBoxColumn1
			// 
			this.dataGridViewTextBoxColumn1.DataPropertyName = "idU";
			this.dataGridViewTextBoxColumn1.HeaderText = "idU";
			this.dataGridViewTextBoxColumn1.Name = "dataGridViewTextBoxColumn1";
			this.dataGridViewTextBoxColumn1.ReadOnly = true;
			this.dataGridViewTextBoxColumn1.Visible = false;
			// 
			// dataGridViewTextBoxColumn2
			// 
			this.dataGridViewTextBoxColumn2.DataPropertyName = "idO";
			this.dataGridViewTextBoxColumn2.HeaderText = "idO";
			this.dataGridViewTextBoxColumn2.Name = "dataGridViewTextBoxColumn2";
			this.dataGridViewTextBoxColumn2.ReadOnly = true;
			this.dataGridViewTextBoxColumn2.Visible = false;
			// 
			// image
			// 
			this.image.DataPropertyName = "image";
			this.image.HeaderText = "Фото";
			this.image.Name = "image";
			this.image.ReadOnly = true;
			this.image.Width = 82;
			// 
			// dataGridViewTextBoxColumn3
			// 
			this.dataGridViewTextBoxColumn3.DataPropertyName = "name";
			this.dataGridViewTextBoxColumn3.HeaderText = "Название";
			this.dataGridViewTextBoxColumn3.Name = "dataGridViewTextBoxColumn3";
			this.dataGridViewTextBoxColumn3.ReadOnly = true;
			this.dataGridViewTextBoxColumn3.Width = 157;
			// 
			// dataGridViewTextBoxColumn4
			// 
			this.dataGridViewTextBoxColumn4.DataPropertyName = "price";
			this.dataGridViewTextBoxColumn4.HeaderText = "Цена за шт.";
			this.dataGridViewTextBoxColumn4.Name = "dataGridViewTextBoxColumn4";
			this.dataGridViewTextBoxColumn4.ReadOnly = true;
			this.dataGridViewTextBoxColumn4.Width = 182;
			// 
			// count
			// 
			this.count.DataPropertyName = "count";
			this.count.HeaderText = "Кол-во";
			this.count.Name = "count";
			this.count.ReadOnly = true;
			this.count.Width = 128;
			// 
			// itogprice
			// 
			this.itogprice.DataPropertyName = "itogprice";
			this.itogprice.HeaderText = "Итого";
			this.itogprice.Name = "itogprice";
			this.itogprice.ReadOnly = true;
			this.itogprice.Width = 114;
			// 
			// bsAdpOrderInfo
			// 
			this.bsAdpOrderInfo.DataMember = "adpOrderInfo";
			this.bsAdpOrderInfo.DataSource = this.dsApteka;
			// 
			// dsApteka
			// 
			this.dsApteka.DataSetName = "dsApteka";
			this.dsApteka.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
			// 
			// adpOrderInfoTableAdapter
			// 
			this.adpOrderInfoTableAdapter.ClearBeforeFill = true;
			// 
			// tableAdapterManager
			// 
			this.tableAdapterManager.BackupDataSetBeforeUpdate = false;
			this.tableAdapterManager.BasketTableAdapter = null;
			this.tableAdapterManager.Connection = null;
			this.tableAdapterManager.FavoriteTableAdapter = null;
			this.tableAdapterManager.GoodsTableAdapter = null;
			this.tableAdapterManager.OGTableAdapter = null;
			this.tableAdapterManager.OrdersTableAdapter = null;
			this.tableAdapterManager.TGTableAdapter = null;
			this.tableAdapterManager.UpdateOrder = Apteka.dsAptekaTableAdapters.TableAdapterManager.UpdateOrderOption.InsertUpdateDelete;
			this.tableAdapterManager.UserTableAdapter = null;
			// 
			// pbClose
			// 
			this.pbClose.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
			this.pbClose.BackColor = System.Drawing.Color.Transparent;
			this.pbClose.Cursor = System.Windows.Forms.Cursors.Hand;
			this.pbClose.ErrorImage = global::Apteka.Properties.Resources.error;
			this.pbClose.Image = global::Apteka.Properties.Resources.close;
			this.pbClose.Location = new System.Drawing.Point(660, 5);
			this.pbClose.Name = "pbClose";
			this.pbClose.Size = new System.Drawing.Size(35, 35);
			this.pbClose.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
			this.pbClose.TabIndex = 52;
			this.pbClose.TabStop = false;
			this.pbClose.Tag = "100";
			this.pbClose.Click += new System.EventHandler(this.pbClose_Click);
			// 
			// ListOrderInfo
			// 
			this.AutoScaleDimensions = new System.Drawing.SizeF(14F, 31F);
			this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
			this.BackColor = System.Drawing.Color.White;
			this.ClientSize = new System.Drawing.Size(700, 650);
			this.Controls.Add(this.pbClose);
			this.Controls.Add(this.adpOrderInfoDataGridView);
			this.Font = new System.Drawing.Font("Segoe UI", 14F, System.Drawing.FontStyle.Bold);
			this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
			this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
			this.Margin = new System.Windows.Forms.Padding(5, 6, 5, 6);
			this.Name = "ListOrderInfo";
			this.Padding = new System.Windows.Forms.Padding(25);
			this.StartPosition = System.Windows.Forms.FormStartPosition.CenterParent;
			this.Text = "ListOrderInfo";
			this.Load += new System.EventHandler(this.ListOrderInfo_Load);
			((System.ComponentModel.ISupportInitialize)(this.adpOrderInfoDataGridView)).EndInit();
			((System.ComponentModel.ISupportInitialize)(this.bsAdpOrderInfo)).EndInit();
			((System.ComponentModel.ISupportInitialize)(this.dsApteka)).EndInit();
			((System.ComponentModel.ISupportInitialize)(this.pbClose)).EndInit();
			this.ResumeLayout(false);

		}

		#endregion

		private dsApteka dsApteka;
		private dsAptekaTableAdapters.adpOrderInfoTableAdapter adpOrderInfoTableAdapter;
		private dsAptekaTableAdapters.TableAdapterManager tableAdapterManager;
		private System.Windows.Forms.DataGridView adpOrderInfoDataGridView;
		private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn1;
		private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn2;
		private System.Windows.Forms.DataGridViewImageColumn image;
		private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn3;
		private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn4;
		private System.Windows.Forms.DataGridViewTextBoxColumn count;
		private System.Windows.Forms.DataGridViewTextBoxColumn itogprice;
		public System.Windows.Forms.BindingSource bsAdpOrderInfo;
		private System.Windows.Forms.PictureBox pbClose;
	}
}