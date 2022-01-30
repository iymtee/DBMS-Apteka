namespace Apteka
{
	partial class Favorite
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
			System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle1 = new System.Windows.Forms.DataGridViewCellStyle();
			System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle2 = new System.Windows.Forms.DataGridViewCellStyle();
			System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Favorite));
			this.dsApteka = new Apteka.dsApteka();
			this.bsAdpFavorite = new System.Windows.Forms.BindingSource(this.components);
			this.adpFavoriteTableAdapter = new Apteka.dsAptekaTableAdapters.adpFavoriteTableAdapter();
			this.tableAdapterManager = new Apteka.dsAptekaTableAdapters.TableAdapterManager();
			this.dgvAdpFavorite = new System.Windows.Forms.DataGridView();
			this.pbClose = new System.Windows.Forms.PictureBox();
			this.dataGridViewTextBoxColumn1 = new System.Windows.Forms.DataGridViewTextBoxColumn();
			this.dataGridViewTextBoxColumn2 = new System.Windows.Forms.DataGridViewTextBoxColumn();
			this.dataGridViewImageColumn1 = new System.Windows.Forms.DataGridViewImageColumn();
			this.dataGridViewTextBoxColumn3 = new System.Windows.Forms.DataGridViewTextBoxColumn();
			this.dataGridViewTextBoxColumn4 = new System.Windows.Forms.DataGridViewTextBoxColumn();
			this.dataGridViewTextBoxColumn5 = new System.Windows.Forms.DataGridViewTextBoxColumn();
			this.dataGridViewTextBoxColumn6 = new System.Windows.Forms.DataGridViewTextBoxColumn();
			this.dataGridViewTextBoxColumn7 = new System.Windows.Forms.DataGridViewTextBoxColumn();
			this.dataGridViewTextBoxColumn9 = new System.Windows.Forms.DataGridViewTextBoxColumn();
			this.dataGridViewTextBoxColumn10 = new System.Windows.Forms.DataGridViewTextBoxColumn();
			this.dataGridViewTextBoxColumn11 = new System.Windows.Forms.DataGridViewTextBoxColumn();
			this.dataGridViewTextBoxColumn12 = new System.Windows.Forms.DataGridViewTextBoxColumn();
			((System.ComponentModel.ISupportInitialize)(this.dsApteka)).BeginInit();
			((System.ComponentModel.ISupportInitialize)(this.bsAdpFavorite)).BeginInit();
			((System.ComponentModel.ISupportInitialize)(this.dgvAdpFavorite)).BeginInit();
			((System.ComponentModel.ISupportInitialize)(this.pbClose)).BeginInit();
			this.SuspendLayout();
			// 
			// dsApteka
			// 
			this.dsApteka.DataSetName = "dsApteka";
			this.dsApteka.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
			// 
			// bsAdpFavorite
			// 
			this.bsAdpFavorite.DataMember = "adpFavorite";
			this.bsAdpFavorite.DataSource = this.dsApteka;
			// 
			// adpFavoriteTableAdapter
			// 
			this.adpFavoriteTableAdapter.ClearBeforeFill = true;
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
			// dgvAdpFavorite
			// 
			this.dgvAdpFavorite.AllowUserToAddRows = false;
			this.dgvAdpFavorite.AllowUserToDeleteRows = false;
			this.dgvAdpFavorite.AutoGenerateColumns = false;
			this.dgvAdpFavorite.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.AllCells;
			this.dgvAdpFavorite.AutoSizeRowsMode = System.Windows.Forms.DataGridViewAutoSizeRowsMode.AllCells;
			this.dgvAdpFavorite.BackgroundColor = System.Drawing.Color.White;
			dataGridViewCellStyle1.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
			dataGridViewCellStyle1.BackColor = System.Drawing.Color.White;
			dataGridViewCellStyle1.Font = new System.Drawing.Font("Segoe UI", 13.8F, System.Drawing.FontStyle.Bold);
			dataGridViewCellStyle1.ForeColor = System.Drawing.SystemColors.WindowText;
			dataGridViewCellStyle1.SelectionBackColor = System.Drawing.Color.White;
			dataGridViewCellStyle1.SelectionForeColor = System.Drawing.SystemColors.WindowText;
			dataGridViewCellStyle1.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
			this.dgvAdpFavorite.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle1;
			this.dgvAdpFavorite.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
			this.dgvAdpFavorite.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.dataGridViewTextBoxColumn1,
            this.dataGridViewTextBoxColumn2,
            this.dataGridViewImageColumn1,
            this.dataGridViewTextBoxColumn3,
            this.dataGridViewTextBoxColumn4,
            this.dataGridViewTextBoxColumn5,
            this.dataGridViewTextBoxColumn6,
            this.dataGridViewTextBoxColumn7,
            this.dataGridViewTextBoxColumn9,
            this.dataGridViewTextBoxColumn10,
            this.dataGridViewTextBoxColumn11,
            this.dataGridViewTextBoxColumn12});
			this.dgvAdpFavorite.DataSource = this.bsAdpFavorite;
			dataGridViewCellStyle2.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
			dataGridViewCellStyle2.BackColor = System.Drawing.SystemColors.Window;
			dataGridViewCellStyle2.Font = new System.Drawing.Font("Segoe UI", 13.8F, System.Drawing.FontStyle.Bold);
			dataGridViewCellStyle2.ForeColor = System.Drawing.SystemColors.ControlText;
			dataGridViewCellStyle2.SelectionBackColor = System.Drawing.SystemColors.Window;
			dataGridViewCellStyle2.SelectionForeColor = System.Drawing.SystemColors.ControlText;
			dataGridViewCellStyle2.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
			this.dgvAdpFavorite.DefaultCellStyle = dataGridViewCellStyle2;
			this.dgvAdpFavorite.Dock = System.Windows.Forms.DockStyle.Fill;
			this.dgvAdpFavorite.Location = new System.Drawing.Point(25, 25);
			this.dgvAdpFavorite.Name = "dgvAdpFavorite";
			this.dgvAdpFavorite.ReadOnly = true;
			this.dgvAdpFavorite.RowTemplate.Height = 24;
			this.dgvAdpFavorite.Size = new System.Drawing.Size(650, 600);
			this.dgvAdpFavorite.TabIndex = 1;
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
			this.pbClose.TabIndex = 52;
			this.pbClose.TabStop = false;
			this.pbClose.Tag = "100";
			this.pbClose.Click += new System.EventHandler(this.pbClose_Click);
			// 
			// dataGridViewTextBoxColumn1
			// 
			this.dataGridViewTextBoxColumn1.DataPropertyName = "idG";
			this.dataGridViewTextBoxColumn1.HeaderText = "idG";
			this.dataGridViewTextBoxColumn1.MinimumWidth = 100;
			this.dataGridViewTextBoxColumn1.Name = "dataGridViewTextBoxColumn1";
			this.dataGridViewTextBoxColumn1.ReadOnly = true;
			this.dataGridViewTextBoxColumn1.Visible = false;
			// 
			// dataGridViewTextBoxColumn2
			// 
			this.dataGridViewTextBoxColumn2.DataPropertyName = "idU";
			this.dataGridViewTextBoxColumn2.HeaderText = "idU";
			this.dataGridViewTextBoxColumn2.Name = "dataGridViewTextBoxColumn2";
			this.dataGridViewTextBoxColumn2.ReadOnly = true;
			this.dataGridViewTextBoxColumn2.Visible = false;
			this.dataGridViewTextBoxColumn2.Width = 83;
			// 
			// dataGridViewImageColumn1
			// 
			this.dataGridViewImageColumn1.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.AllCells;
			this.dataGridViewImageColumn1.DataPropertyName = "image";
			this.dataGridViewImageColumn1.FillWeight = 150F;
			this.dataGridViewImageColumn1.HeaderText = "Фото";
			this.dataGridViewImageColumn1.ImageLayout = System.Windows.Forms.DataGridViewImageCellLayout.Zoom;
			this.dataGridViewImageColumn1.MinimumWidth = 150;
			this.dataGridViewImageColumn1.Name = "dataGridViewImageColumn1";
			this.dataGridViewImageColumn1.ReadOnly = true;
			this.dataGridViewImageColumn1.Width = 150;
			// 
			// dataGridViewTextBoxColumn3
			// 
			this.dataGridViewTextBoxColumn3.DataPropertyName = "name";
			this.dataGridViewTextBoxColumn3.FillWeight = 150F;
			this.dataGridViewTextBoxColumn3.HeaderText = "Название";
			this.dataGridViewTextBoxColumn3.MinimumWidth = 150;
			this.dataGridViewTextBoxColumn3.Name = "dataGridViewTextBoxColumn3";
			this.dataGridViewTextBoxColumn3.ReadOnly = true;
			this.dataGridViewTextBoxColumn3.Width = 157;
			// 
			// dataGridViewTextBoxColumn4
			// 
			this.dataGridViewTextBoxColumn4.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.ColumnHeader;
			this.dataGridViewTextBoxColumn4.DataPropertyName = "info";
			this.dataGridViewTextBoxColumn4.FillWeight = 1000F;
			this.dataGridViewTextBoxColumn4.HeaderText = "Описание";
			this.dataGridViewTextBoxColumn4.MinimumWidth = 1000;
			this.dataGridViewTextBoxColumn4.Name = "dataGridViewTextBoxColumn4";
			this.dataGridViewTextBoxColumn4.ReadOnly = true;
			this.dataGridViewTextBoxColumn4.Width = 1000;
			// 
			// dataGridViewTextBoxColumn5
			// 
			this.dataGridViewTextBoxColumn5.DataPropertyName = "comp";
			this.dataGridViewTextBoxColumn5.FillWeight = 350F;
			this.dataGridViewTextBoxColumn5.HeaderText = "Состав";
			this.dataGridViewTextBoxColumn5.MinimumWidth = 350;
			this.dataGridViewTextBoxColumn5.Name = "dataGridViewTextBoxColumn5";
			this.dataGridViewTextBoxColumn5.ReadOnly = true;
			this.dataGridViewTextBoxColumn5.Width = 350;
			// 
			// dataGridViewTextBoxColumn6
			// 
			this.dataGridViewTextBoxColumn6.DataPropertyName = "recomend";
			this.dataGridViewTextBoxColumn6.HeaderText = "Рекомендации";
			this.dataGridViewTextBoxColumn6.Name = "dataGridViewTextBoxColumn6";
			this.dataGridViewTextBoxColumn6.ReadOnly = true;
			this.dataGridViewTextBoxColumn6.Width = 220;
			// 
			// dataGridViewTextBoxColumn7
			// 
			this.dataGridViewTextBoxColumn7.DataPropertyName = "contrindic";
			this.dataGridViewTextBoxColumn7.FillWeight = 350F;
			this.dataGridViewTextBoxColumn7.HeaderText = "Противопокозания";
			this.dataGridViewTextBoxColumn7.MinimumWidth = 350;
			this.dataGridViewTextBoxColumn7.Name = "dataGridViewTextBoxColumn7";
			this.dataGridViewTextBoxColumn7.ReadOnly = true;
			this.dataGridViewTextBoxColumn7.Width = 350;
			// 
			// dataGridViewTextBoxColumn9
			// 
			this.dataGridViewTextBoxColumn9.DataPropertyName = "shelfLife";
			this.dataGridViewTextBoxColumn9.FillWeight = 250F;
			this.dataGridViewTextBoxColumn9.HeaderText = "Срок годности (лет)";
			this.dataGridViewTextBoxColumn9.MinimumWidth = 250;
			this.dataGridViewTextBoxColumn9.Name = "dataGridViewTextBoxColumn9";
			this.dataGridViewTextBoxColumn9.ReadOnly = true;
			this.dataGridViewTextBoxColumn9.Width = 254;
			// 
			// dataGridViewTextBoxColumn10
			// 
			this.dataGridViewTextBoxColumn10.DataPropertyName = "storageCond";
			this.dataGridViewTextBoxColumn10.FillWeight = 250F;
			this.dataGridViewTextBoxColumn10.HeaderText = "Условия хранения";
			this.dataGridViewTextBoxColumn10.MinimumWidth = 250;
			this.dataGridViewTextBoxColumn10.Name = "dataGridViewTextBoxColumn10";
			this.dataGridViewTextBoxColumn10.ReadOnly = true;
			this.dataGridViewTextBoxColumn10.Width = 250;
			// 
			// dataGridViewTextBoxColumn11
			// 
			this.dataGridViewTextBoxColumn11.DataPropertyName = "manufacture";
			this.dataGridViewTextBoxColumn11.HeaderText = "Производитель";
			this.dataGridViewTextBoxColumn11.Name = "dataGridViewTextBoxColumn11";
			this.dataGridViewTextBoxColumn11.ReadOnly = true;
			this.dataGridViewTextBoxColumn11.Width = 229;
			// 
			// dataGridViewTextBoxColumn12
			// 
			this.dataGridViewTextBoxColumn12.DataPropertyName = "itogprice";
			this.dataGridViewTextBoxColumn12.FillWeight = 200F;
			this.dataGridViewTextBoxColumn12.HeaderText = "Цена";
			this.dataGridViewTextBoxColumn12.MinimumWidth = 200;
			this.dataGridViewTextBoxColumn12.Name = "dataGridViewTextBoxColumn12";
			this.dataGridViewTextBoxColumn12.ReadOnly = true;
			this.dataGridViewTextBoxColumn12.Width = 200;
			// 
			// Favorite
			// 
			this.AutoScaleDimensions = new System.Drawing.SizeF(14F, 31F);
			this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
			this.BackColor = System.Drawing.Color.White;
			this.ClientSize = new System.Drawing.Size(700, 650);
			this.Controls.Add(this.pbClose);
			this.Controls.Add(this.dgvAdpFavorite);
			this.Font = new System.Drawing.Font("Segoe UI", 13.8F, System.Drawing.FontStyle.Bold);
			this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
			this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
			this.Margin = new System.Windows.Forms.Padding(5, 6, 5, 6);
			this.Name = "Favorite";
			this.Padding = new System.Windows.Forms.Padding(25);
			this.Text = "ListFavorite";
			this.Load += new System.EventHandler(this.ListFavorite_Load);
			((System.ComponentModel.ISupportInitialize)(this.dsApteka)).EndInit();
			((System.ComponentModel.ISupportInitialize)(this.bsAdpFavorite)).EndInit();
			((System.ComponentModel.ISupportInitialize)(this.dgvAdpFavorite)).EndInit();
			((System.ComponentModel.ISupportInitialize)(this.pbClose)).EndInit();
			this.ResumeLayout(false);

		}

		#endregion

		private dsApteka dsApteka;
		private dsAptekaTableAdapters.adpFavoriteTableAdapter adpFavoriteTableAdapter;
		private dsAptekaTableAdapters.TableAdapterManager tableAdapterManager;
		private System.Windows.Forms.DataGridView dgvAdpFavorite;
		public System.Windows.Forms.BindingSource bsAdpFavorite;
		private System.Windows.Forms.PictureBox pbClose;
		private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn1;
		private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn2;
		private System.Windows.Forms.DataGridViewImageColumn dataGridViewImageColumn1;
		private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn3;
		private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn4;
		private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn5;
		private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn6;
		private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn7;
		private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn9;
		private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn10;
		private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn11;
		private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn12;
	}
}