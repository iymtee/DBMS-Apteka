namespace Apteka
{
	partial class ListOrderAdm
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
			System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(ListOrderAdm));
			this.dsApteka = new Apteka.dsApteka();
			this.bsOrderAdm = new System.Windows.Forms.BindingSource(this.components);
			this.adpInfoAdmBindingSource = new System.Windows.Forms.BindingSource(this.components);
			this.adpInfoAdmTableAdapter = new Apteka.dsAptekaTableAdapters.adpInfoAdmTableAdapter();
			this.tableAdapterManager = new Apteka.dsAptekaTableAdapters.TableAdapterManager();
			this.dgvAdpInfoAdm = new System.Windows.Forms.DataGridView();
			this.dataGridViewTextBoxColumn1 = new System.Windows.Forms.DataGridViewTextBoxColumn();
			this.dataGridViewTextBoxColumn3 = new System.Windows.Forms.DataGridViewTextBoxColumn();
			this.dataGridViewTextBoxColumn2 = new System.Windows.Forms.DataGridViewTextBoxColumn();
			this.pbClose = new System.Windows.Forms.PictureBox();
			((System.ComponentModel.ISupportInitialize)(this.dsApteka)).BeginInit();
			((System.ComponentModel.ISupportInitialize)(this.bsOrderAdm)).BeginInit();
			((System.ComponentModel.ISupportInitialize)(this.adpInfoAdmBindingSource)).BeginInit();
			((System.ComponentModel.ISupportInitialize)(this.dgvAdpInfoAdm)).BeginInit();
			((System.ComponentModel.ISupportInitialize)(this.pbClose)).BeginInit();
			this.SuspendLayout();
			// 
			// dsApteka
			// 
			this.dsApteka.DataSetName = "dsApteka";
			this.dsApteka.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
			// 
			// bsOrderAdm
			// 
			this.bsOrderAdm.DataMember = "adpInfoAdm";
			this.bsOrderAdm.DataSource = this.dsApteka;
			// 
			// adpInfoAdmBindingSource
			// 
			this.adpInfoAdmBindingSource.DataMember = "adpInfoAdm";
			this.adpInfoAdmBindingSource.DataSource = this.dsApteka;
			// 
			// adpInfoAdmTableAdapter
			// 
			this.adpInfoAdmTableAdapter.ClearBeforeFill = true;
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
			// dgvAdpInfoAdm
			// 
			this.dgvAdpInfoAdm.AllowUserToAddRows = false;
			this.dgvAdpInfoAdm.AllowUserToDeleteRows = false;
			this.dgvAdpInfoAdm.AutoGenerateColumns = false;
			this.dgvAdpInfoAdm.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.AllCells;
			this.dgvAdpInfoAdm.BackgroundColor = System.Drawing.Color.White;
			this.dgvAdpInfoAdm.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
			this.dgvAdpInfoAdm.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.dataGridViewTextBoxColumn1,
            this.dataGridViewTextBoxColumn3,
            this.dataGridViewTextBoxColumn2});
			this.dgvAdpInfoAdm.DataSource = this.adpInfoAdmBindingSource;
			this.dgvAdpInfoAdm.Dock = System.Windows.Forms.DockStyle.Fill;
			this.dgvAdpInfoAdm.Location = new System.Drawing.Point(25, 25);
			this.dgvAdpInfoAdm.Name = "dgvAdpInfoAdm";
			this.dgvAdpInfoAdm.ReadOnly = true;
			this.dgvAdpInfoAdm.RowTemplate.Height = 24;
			this.dgvAdpInfoAdm.Size = new System.Drawing.Size(650, 600);
			this.dgvAdpInfoAdm.TabIndex = 0;
			this.dgvAdpInfoAdm.CellDoubleClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgvOrderAdm_CellDoubleClick);
			// 
			// dataGridViewTextBoxColumn1
			// 
			this.dataGridViewTextBoxColumn1.DataPropertyName = "custumer";
			this.dataGridViewTextBoxColumn1.HeaderText = "Покупатель";
			this.dataGridViewTextBoxColumn1.Name = "dataGridViewTextBoxColumn1";
			this.dataGridViewTextBoxColumn1.ReadOnly = true;
			this.dataGridViewTextBoxColumn1.Width = 182;
			// 
			// dataGridViewTextBoxColumn3
			// 
			this.dataGridViewTextBoxColumn3.DataPropertyName = "count";
			this.dataGridViewTextBoxColumn3.HeaderText = "Кол-во заказов";
			this.dataGridViewTextBoxColumn3.MinimumWidth = 150;
			this.dataGridViewTextBoxColumn3.Name = "dataGridViewTextBoxColumn3";
			this.dataGridViewTextBoxColumn3.ReadOnly = true;
			this.dataGridViewTextBoxColumn3.Width = 207;
			// 
			// dataGridViewTextBoxColumn2
			// 
			this.dataGridViewTextBoxColumn2.DataPropertyName = "idU";
			this.dataGridViewTextBoxColumn2.HeaderText = "idU";
			this.dataGridViewTextBoxColumn2.Name = "dataGridViewTextBoxColumn2";
			this.dataGridViewTextBoxColumn2.ReadOnly = true;
			this.dataGridViewTextBoxColumn2.Visible = false;
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
			this.pbClose.Click += new System.EventHandler(this.pbClose_Click_1);
			// 
			// ListOrderAdm
			// 
			this.AutoScaleDimensions = new System.Drawing.SizeF(14F, 31F);
			this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
			this.BackColor = System.Drawing.Color.White;
			this.ClientSize = new System.Drawing.Size(700, 650);
			this.Controls.Add(this.pbClose);
			this.Controls.Add(this.dgvAdpInfoAdm);
			this.Font = new System.Drawing.Font("Segoe UI", 14F, System.Drawing.FontStyle.Bold);
			this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
			this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
			this.Margin = new System.Windows.Forms.Padding(5, 6, 5, 6);
			this.Name = "ListOrderAdm";
			this.Padding = new System.Windows.Forms.Padding(25);
			this.Text = "ListOrderAdm";
			this.Load += new System.EventHandler(this.ListOrderAdm_Load);
			((System.ComponentModel.ISupportInitialize)(this.dsApteka)).EndInit();
			((System.ComponentModel.ISupportInitialize)(this.bsOrderAdm)).EndInit();
			((System.ComponentModel.ISupportInitialize)(this.adpInfoAdmBindingSource)).EndInit();
			((System.ComponentModel.ISupportInitialize)(this.dgvAdpInfoAdm)).EndInit();
			((System.ComponentModel.ISupportInitialize)(this.pbClose)).EndInit();
			this.ResumeLayout(false);

		}

		#endregion

		private dsApteka dsApteka;
		public System.Windows.Forms.BindingSource bsOrderAdm;
		private System.Windows.Forms.BindingSource adpInfoAdmBindingSource;
		private dsAptekaTableAdapters.adpInfoAdmTableAdapter adpInfoAdmTableAdapter;
		private dsAptekaTableAdapters.TableAdapterManager tableAdapterManager;
		private System.Windows.Forms.DataGridView dgvAdpInfoAdm;
		private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn1;
		private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn3;
		private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn2;
		private System.Windows.Forms.PictureBox pbClose;
	}
}