namespace Apteka
{
	partial class Search
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Search));
            this.pTop = new System.Windows.Forms.Panel();
            this.pSearch = new System.Windows.Forms.Panel();
            this.tbxSearch = new System.Windows.Forms.TextBox();
            this.pbSearch = new System.Windows.Forms.PictureBox();
            this.dsApteka = new Apteka.dsApteka();
            this.bsGoods = new System.Windows.Forms.BindingSource(this.components);
            this.goodsTableAdapter = new Apteka.dsAptekaTableAdapters.GoodsTableAdapter();
            this.tableAdapterManager = new Apteka.dsAptekaTableAdapters.TableAdapterManager();
            this.pBottom = new System.Windows.Forms.Panel();
            this.pTop.SuspendLayout();
            this.pSearch.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pbSearch)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dsApteka)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.bsGoods)).BeginInit();
            this.SuspendLayout();
            // 
            // pTop
            // 
            this.pTop.BackgroundImage = global::Apteka.Properties.Resources.fon2;
            this.pTop.Controls.Add(this.pSearch);
            this.pTop.Controls.Add(this.pbSearch);
            this.pTop.Dock = System.Windows.Forms.DockStyle.Top;
            this.pTop.Location = new System.Drawing.Point(25, 25);
            this.pTop.Margin = new System.Windows.Forms.Padding(0);
            this.pTop.Name = "pTop";
            this.pTop.Size = new System.Drawing.Size(650, 47);
            this.pTop.TabIndex = 0;
            // 
            // pSearch
            // 
            this.pSearch.BackgroundImage = global::Apteka.Properties.Resources.fon2;
            this.pSearch.Controls.Add(this.tbxSearch);
            this.pSearch.Dock = System.Windows.Forms.DockStyle.Fill;
            this.pSearch.Location = new System.Drawing.Point(0, 0);
            this.pSearch.Margin = new System.Windows.Forms.Padding(0);
            this.pSearch.Name = "pSearch";
            this.pSearch.Padding = new System.Windows.Forms.Padding(5);
            this.pSearch.Size = new System.Drawing.Size(566, 47);
            this.pSearch.TabIndex = 3;
            // 
            // tbxSearch
            // 
            this.tbxSearch.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tbxSearch.Font = new System.Drawing.Font("Segoe UI", 13.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.tbxSearch.Location = new System.Drawing.Point(5, 5);
            this.tbxSearch.Margin = new System.Windows.Forms.Padding(0);
            this.tbxSearch.Name = "tbxSearch";
            this.tbxSearch.Size = new System.Drawing.Size(556, 32);
            this.tbxSearch.TabIndex = 1;
            // 
            // pbSearch
            // 
            this.pbSearch.Dock = System.Windows.Forms.DockStyle.Right;
            this.pbSearch.Image = global::Apteka.Properties.Resources.searching;
            this.pbSearch.Location = new System.Drawing.Point(566, 0);
            this.pbSearch.Margin = new System.Windows.Forms.Padding(0);
            this.pbSearch.Name = "pbSearch";
            this.pbSearch.Size = new System.Drawing.Size(84, 47);
            this.pbSearch.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pbSearch.TabIndex = 1;
            this.pbSearch.TabStop = false;
            this.pbSearch.Click += new System.EventHandler(this.pbSearch_Click);
            // 
            // dsApteka
            // 
            this.dsApteka.DataSetName = "dsApteka";
            this.dsApteka.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // bsGoods
            // 
            this.bsGoods.DataMember = "Goods";
            this.bsGoods.DataSource = this.dsApteka;
            // 
            // goodsTableAdapter
            // 
            this.goodsTableAdapter.ClearBeforeFill = true;
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
            // pBottom
            // 
            this.pBottom.Dock = System.Windows.Forms.DockStyle.Fill;
            this.pBottom.Location = new System.Drawing.Point(25, 72);
            this.pBottom.Margin = new System.Windows.Forms.Padding(0);
            this.pBottom.Name = "pBottom";
            this.pBottom.Size = new System.Drawing.Size(650, 553);
            this.pBottom.TabIndex = 1;
            // 
            // Search
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(11F, 25F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.AutoScroll = true;
            this.BackColor = System.Drawing.Color.White;
            this.ClientSize = new System.Drawing.Size(700, 650);
            this.Controls.Add(this.pBottom);
            this.Controls.Add(this.pTop);
            this.Font = new System.Drawing.Font("Segoe UI", 14F, System.Drawing.FontStyle.Bold);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Margin = new System.Windows.Forms.Padding(0, 10, 0, 10);
            this.Name = "Search";
            this.Padding = new System.Windows.Forms.Padding(25);
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "ListInfo";
            this.Load += new System.EventHandler(this.ListInfo_Load);
            this.Resize += new System.EventHandler(this.ListInfo_Resize);
            this.pTop.ResumeLayout(false);
            this.pSearch.ResumeLayout(false);
            this.pSearch.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pbSearch)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dsApteka)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.bsGoods)).EndInit();
            this.ResumeLayout(false);

		}

		#endregion

		private System.Windows.Forms.Panel pTop;
		private dsApteka dsApteka;
		private System.Windows.Forms.BindingSource bsGoods;
		private dsAptekaTableAdapters.GoodsTableAdapter goodsTableAdapter;
		private dsAptekaTableAdapters.TableAdapterManager tableAdapterManager;
		private System.Windows.Forms.Panel pBottom;
		private System.Windows.Forms.Panel pSearch;
		private System.Windows.Forms.TextBox tbxSearch;
		private System.Windows.Forms.PictureBox pbSearch;
	}
}