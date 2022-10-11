namespace Apteka
{
	partial class Info
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Info));
            this.sp1 = new System.Windows.Forms.SplitContainer();
            this.pbImage = new System.Windows.Forms.PictureBox();
            this.sp2 = new System.Windows.Forms.SplitContainer();
            this.btnGTB = new System.Windows.Forms.Button();
            this.p1 = new System.Windows.Forms.Panel();
            this.lblOldPrice = new System.Windows.Forms.Label();
            this.lblPrice = new System.Windows.Forms.Label();
            this.pbFavorite = new System.Windows.Forms.PictureBox();
            this.pbClose = new System.Windows.Forms.PictureBox();
            this.lblName = new System.Windows.Forms.Label();
            this.btnAdd = new System.Windows.Forms.Button();
            this.lblInfo = new System.Windows.Forms.Label();
            this.dsApteka = new Apteka.dsApteka();
            this.bsBasket = new System.Windows.Forms.BindingSource(this.components);
            this.bsGoods = new System.Windows.Forms.BindingSource(this.components);
            this.bsFavorite = new System.Windows.Forms.BindingSource(this.components);
            this.goodsTableAdapter = new Apteka.dsAptekaTableAdapters.GoodsTableAdapter();
            this.favoriteTableAdapter = new Apteka.dsAptekaTableAdapters.FavoriteTableAdapter();
            this.basketTableAdapter = new Apteka.dsAptekaTableAdapters.BasketTableAdapter();
            ((System.ComponentModel.ISupportInitialize)(this.sp1)).BeginInit();
            this.sp1.Panel1.SuspendLayout();
            this.sp1.Panel2.SuspendLayout();
            this.sp1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pbImage)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.sp2)).BeginInit();
            this.sp2.Panel1.SuspendLayout();
            this.sp2.Panel2.SuspendLayout();
            this.sp2.SuspendLayout();
            this.p1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pbFavorite)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pbClose)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dsApteka)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.bsBasket)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.bsGoods)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.bsFavorite)).BeginInit();
            this.SuspendLayout();
            // 
            // sp1
            // 
            this.sp1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.sp1.IsSplitterFixed = true;
            this.sp1.Location = new System.Drawing.Point(0, 0);
            this.sp1.Name = "sp1";
            // 
            // sp1.Panel1
            // 
            this.sp1.Panel1.AutoScroll = true;
            this.sp1.Panel1.Controls.Add(this.pbImage);
            this.sp1.Panel1MinSize = 325;
            // 
            // sp1.Panel2
            // 
            this.sp1.Panel2.Controls.Add(this.sp2);
            this.sp1.Panel2MinSize = 325;
            this.sp1.Size = new System.Drawing.Size(700, 650);
            this.sp1.SplitterDistance = 325;
            this.sp1.SplitterWidth = 1;
            this.sp1.TabIndex = 0;
            // 
            // pbImage
            // 
            this.pbImage.Dock = System.Windows.Forms.DockStyle.Fill;
            this.pbImage.ErrorImage = global::Apteka.Properties.Resources.error;
            this.pbImage.Location = new System.Drawing.Point(0, 0);
            this.pbImage.Name = "pbImage";
            this.pbImage.Size = new System.Drawing.Size(325, 650);
            this.pbImage.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pbImage.TabIndex = 4;
            this.pbImage.TabStop = false;
            // 
            // sp2
            // 
            this.sp2.Dock = System.Windows.Forms.DockStyle.Fill;
            this.sp2.IsSplitterFixed = true;
            this.sp2.Location = new System.Drawing.Point(0, 0);
            this.sp2.Name = "sp2";
            this.sp2.Orientation = System.Windows.Forms.Orientation.Horizontal;
            // 
            // sp2.Panel1
            // 
            this.sp2.Panel1.Controls.Add(this.btnGTB);
            this.sp2.Panel1.Controls.Add(this.p1);
            this.sp2.Panel1.Controls.Add(this.pbFavorite);
            this.sp2.Panel1.Controls.Add(this.pbClose);
            this.sp2.Panel1.Controls.Add(this.lblName);
            this.sp2.Panel1.Controls.Add(this.btnAdd);
            this.sp2.Panel1.Padding = new System.Windows.Forms.Padding(25);
            this.sp2.Panel1MinSize = 187;
            // 
            // sp2.Panel2
            // 
            this.sp2.Panel2.Controls.Add(this.lblInfo);
            this.sp2.Panel2.Padding = new System.Windows.Forms.Padding(25, 0, 25, 25);
            this.sp2.Panel2MinSize = 187;
            this.sp2.Size = new System.Drawing.Size(374, 650);
            this.sp2.SplitterDistance = 324;
            this.sp2.SplitterWidth = 1;
            this.sp2.TabIndex = 1;
            // 
            // btnGTB
            // 
            this.btnGTB.AutoSize = true;
            this.btnGTB.BackgroundImage = global::Apteka.Properties.Resources.fon3;
            this.btnGTB.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnGTB.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnGTB.ForeColor = System.Drawing.Color.White;
            this.btnGTB.Location = new System.Drawing.Point(31, 131);
            this.btnGTB.Margin = new System.Windows.Forms.Padding(25);
            this.btnGTB.Name = "btnGTB";
            this.btnGTB.Size = new System.Drawing.Size(26, 49);
            this.btnGTB.TabIndex = 61;
            this.btnGTB.Tag = "2";
            this.btnGTB.UseVisualStyleBackColor = true;
            this.btnGTB.Visible = false;
            this.btnGTB.Click += new System.EventHandler(this.btnGTB_Click);
            // 
            // p1
            // 
            this.p1.Controls.Add(this.lblOldPrice);
            this.p1.Controls.Add(this.lblPrice);
            this.p1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.p1.Location = new System.Drawing.Point(25, 150);
            this.p1.Margin = new System.Windows.Forms.Padding(25);
            this.p1.Name = "p1";
            this.p1.Padding = new System.Windows.Forms.Padding(25);
            this.p1.Size = new System.Drawing.Size(251, 97);
            this.p1.TabIndex = 60;
            // 
            // lblOldPrice
            // 
            this.lblOldPrice.AutoSize = true;
            this.lblOldPrice.Dock = System.Windows.Forms.DockStyle.Left;
            this.lblOldPrice.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.lblOldPrice.Font = new System.Drawing.Font("Segoe UI Black", 18F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Strikeout))), System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.lblOldPrice.ForeColor = System.Drawing.Color.Silver;
            this.lblOldPrice.Location = new System.Drawing.Point(147, 25);
            this.lblOldPrice.Name = "lblOldPrice";
            this.lblOldPrice.Size = new System.Drawing.Size(0, 41);
            this.lblOldPrice.TabIndex = 22;
            this.lblOldPrice.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // lblPrice
            // 
            this.lblPrice.AutoSize = true;
            this.lblPrice.Dock = System.Windows.Forms.DockStyle.Left;
            this.lblPrice.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.lblPrice.Font = new System.Drawing.Font("Segoe UI Black", 22.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.lblPrice.ForeColor = System.Drawing.Color.Black;
            this.lblPrice.Location = new System.Drawing.Point(25, 25);
            this.lblPrice.Name = "lblPrice";
            this.lblPrice.Size = new System.Drawing.Size(122, 50);
            this.lblPrice.TabIndex = 21;
            this.lblPrice.Text = "900 ₽";
            this.lblPrice.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // pbFavorite
            // 
            this.pbFavorite.BackColor = System.Drawing.Color.Transparent;
            this.pbFavorite.Cursor = System.Windows.Forms.Cursors.Hand;
            this.pbFavorite.Dock = System.Windows.Forms.DockStyle.Right;
            this.pbFavorite.ErrorImage = global::Apteka.Properties.Resources.error;
            this.pbFavorite.Image = global::Apteka.Properties.Resources.favorite;
            this.pbFavorite.Location = new System.Drawing.Point(276, 150);
            this.pbFavorite.Name = "pbFavorite";
            this.pbFavorite.Size = new System.Drawing.Size(73, 97);
            this.pbFavorite.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pbFavorite.TabIndex = 59;
            this.pbFavorite.TabStop = false;
            this.pbFavorite.Tag = "0";
            this.pbFavorite.Click += new System.EventHandler(this.pbFavorite_Click);
            // 
            // pbClose
            // 
            this.pbClose.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.pbClose.BackColor = System.Drawing.Color.Transparent;
            this.pbClose.Cursor = System.Windows.Forms.Cursors.Hand;
            this.pbClose.ErrorImage = global::Apteka.Properties.Resources.error;
            this.pbClose.Image = ((System.Drawing.Image)(resources.GetObject("pbClose.Image")));
            this.pbClose.Location = new System.Drawing.Point(350, 0);
            this.pbClose.Name = "pbClose";
            this.pbClose.Size = new System.Drawing.Size(25, 25);
            this.pbClose.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pbClose.TabIndex = 57;
            this.pbClose.TabStop = false;
            this.pbClose.Tag = "100";
            this.pbClose.Click += new System.EventHandler(this.pbClose_Click);
            // 
            // lblName
            // 
            this.lblName.Dock = System.Windows.Forms.DockStyle.Top;
            this.lblName.Font = new System.Drawing.Font("Segoe UI", 19.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.lblName.Location = new System.Drawing.Point(25, 25);
            this.lblName.Name = "lblName";
            this.lblName.Size = new System.Drawing.Size(324, 125);
            this.lblName.TabIndex = 54;
            this.lblName.Text = "Name";
            this.lblName.TextAlign = System.Drawing.ContentAlignment.BottomLeft;
            // 
            // btnAdd
            // 
            this.btnAdd.AutoSize = true;
            this.btnAdd.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("btnAdd.BackgroundImage")));
            this.btnAdd.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnAdd.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.btnAdd.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnAdd.ForeColor = System.Drawing.Color.White;
            this.btnAdd.Location = new System.Drawing.Point(25, 247);
            this.btnAdd.Margin = new System.Windows.Forms.Padding(25);
            this.btnAdd.Name = "btnAdd";
            this.btnAdd.Size = new System.Drawing.Size(324, 52);
            this.btnAdd.TabIndex = 29;
            this.btnAdd.Tag = "2";
            this.btnAdd.Text = "Добавить в корзину";
            this.btnAdd.UseVisualStyleBackColor = true;
            this.btnAdd.Click += new System.EventHandler(this.btnAdd_Click);
            // 
            // lblInfo
            // 
            this.lblInfo.Dock = System.Windows.Forms.DockStyle.Fill;
            this.lblInfo.Location = new System.Drawing.Point(25, 0);
            this.lblInfo.Name = "lblInfo";
            this.lblInfo.Size = new System.Drawing.Size(324, 300);
            this.lblInfo.TabIndex = 27;
            // 
            // dsApteka
            // 
            this.dsApteka.DataSetName = "dsApteka";
            this.dsApteka.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // bsBasket
            // 
            this.bsBasket.DataMember = "Basket";
            this.bsBasket.DataSource = this.dsApteka;
            // 
            // bsGoods
            // 
            this.bsGoods.DataMember = "Goods";
            this.bsGoods.DataSource = this.dsApteka;
            // 
            // bsFavorite
            // 
            this.bsFavorite.DataMember = "Favorite";
            this.bsFavorite.DataSource = this.dsApteka;
            // 
            // goodsTableAdapter
            // 
            this.goodsTableAdapter.ClearBeforeFill = true;
            // 
            // favoriteTableAdapter
            // 
            this.favoriteTableAdapter.ClearBeforeFill = true;
            // 
            // basketTableAdapter
            // 
            this.basketTableAdapter.ClearBeforeFill = true;
            // 
            // Info
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(14F, 31F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.ClientSize = new System.Drawing.Size(700, 650);
            this.Controls.Add(this.sp1);
            this.Font = new System.Drawing.Font("Segoe UI", 13.8F, System.Drawing.FontStyle.Bold);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Margin = new System.Windows.Forms.Padding(5, 6, 5, 6);
            this.Name = "Info";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterParent;
            this.Text = "Info";
            this.Load += new System.EventHandler(this.Info_Load);
            this.sp1.Panel1.ResumeLayout(false);
            this.sp1.Panel2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.sp1)).EndInit();
            this.sp1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.pbImage)).EndInit();
            this.sp2.Panel1.ResumeLayout(false);
            this.sp2.Panel1.PerformLayout();
            this.sp2.Panel2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.sp2)).EndInit();
            this.sp2.ResumeLayout(false);
            this.p1.ResumeLayout(false);
            this.p1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pbFavorite)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pbClose)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dsApteka)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.bsBasket)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.bsGoods)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.bsFavorite)).EndInit();
            this.ResumeLayout(false);

		}

		#endregion

		private System.Windows.Forms.SplitContainer sp1;
		public System.Windows.Forms.PictureBox pbImage;
		private System.Windows.Forms.SplitContainer sp2;
		private System.Windows.Forms.Button btnGTB;
		private System.Windows.Forms.Panel p1;
		public System.Windows.Forms.Label lblOldPrice;
		public System.Windows.Forms.Label lblPrice;
		private System.Windows.Forms.PictureBox pbFavorite;
		private System.Windows.Forms.PictureBox pbClose;
		public System.Windows.Forms.Label lblName;
		private System.Windows.Forms.Button btnAdd;
		public System.Windows.Forms.Label lblInfo;
		private System.Windows.Forms.BindingSource bsBasket;
		private dsApteka dsApteka;
		private System.Windows.Forms.BindingSource bsGoods;
		private System.Windows.Forms.BindingSource bsFavorite;
		private dsAptekaTableAdapters.GoodsTableAdapter goodsTableAdapter;
		private dsAptekaTableAdapters.FavoriteTableAdapter favoriteTableAdapter;
		private dsAptekaTableAdapters.BasketTableAdapter basketTableAdapter;
	}
}