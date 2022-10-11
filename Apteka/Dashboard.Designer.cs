namespace Apteka
{
	partial class Dashboard
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Dashboard));
            this.ttInfo = new System.Windows.Forms.ToolTip(this.components);
            this.pbFavorite = new System.Windows.Forms.PictureBox();
            this.pbBasket = new System.Windows.Forms.PictureBox();
            this.pbFAQ = new System.Windows.Forms.PictureBox();
            this.pbDis = new System.Windows.Forms.PictureBox();
            this.pbAdd = new System.Windows.Forms.PictureBox();
            this.pbOrder = new System.Windows.Forms.PictureBox();
            this.pbUser = new System.Windows.Forms.PictureBox();
            this.pbUsers = new System.Windows.Forms.PictureBox();
            this.pbAdm = new System.Windows.Forms.PictureBox();
            this.pMain = new System.Windows.Forms.Panel();
            this.pAdm = new System.Windows.Forms.Panel();
            this.pUsers = new System.Windows.Forms.Panel();
            this.pUser = new System.Windows.Forms.Panel();
            this.pAdd = new System.Windows.Forms.Panel();
            this.pDis = new System.Windows.Forms.Panel();
            this.pOrder = new System.Windows.Forms.Panel();
            this.pFavorite = new System.Windows.Forms.Panel();
            this.pBasket = new System.Windows.Forms.Panel();
            this.panel4 = new System.Windows.Forms.Panel();
            this.pExit = new System.Windows.Forms.Panel();
            this.pbExit = new System.Windows.Forms.PictureBox();
            this.pImg = new System.Windows.Forms.Panel();
            this.pbImg = new System.Windows.Forms.PictureBox();
            this.panelChildForm = new System.Windows.Forms.Panel();
            this.pTop = new System.Windows.Forms.Panel();
            this.pSearch = new System.Windows.Forms.Panel();
            this.tbxSearch = new System.Windows.Forms.TextBox();
            this.pbSearch = new System.Windows.Forms.PictureBox();
            this.dsApteka = new Apteka.dsApteka();
            this.bsUser = new System.Windows.Forms.BindingSource(this.components);
            this.bsGoods = new System.Windows.Forms.BindingSource(this.components);
            this.tableAdapterManager = new Apteka.dsAptekaTableAdapters.TableAdapterManager();
            this.goodsTableAdapter = new Apteka.dsAptekaTableAdapters.GoodsTableAdapter();
            this.userTableAdapter = new Apteka.dsAptekaTableAdapters.UserTableAdapter();
            ((System.ComponentModel.ISupportInitialize)(this.pbFavorite)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pbBasket)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pbFAQ)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pbDis)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pbAdd)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pbOrder)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pbUser)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pbUsers)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pbAdm)).BeginInit();
            this.pMain.SuspendLayout();
            this.pAdm.SuspendLayout();
            this.pUsers.SuspendLayout();
            this.pUser.SuspendLayout();
            this.pAdd.SuspendLayout();
            this.pDis.SuspendLayout();
            this.pOrder.SuspendLayout();
            this.pFavorite.SuspendLayout();
            this.pBasket.SuspendLayout();
            this.panel4.SuspendLayout();
            this.pExit.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pbExit)).BeginInit();
            this.pImg.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pbImg)).BeginInit();
            this.pTop.SuspendLayout();
            this.pSearch.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pbSearch)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dsApteka)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.bsUser)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.bsGoods)).BeginInit();
            this.SuspendLayout();
            // 
            // pbFavorite
            // 
            this.pbFavorite.Cursor = System.Windows.Forms.Cursors.Hand;
            this.pbFavorite.Dock = System.Windows.Forms.DockStyle.Fill;
            this.pbFavorite.Image = global::Apteka.Properties.Resources.favorite;
            this.pbFavorite.Location = new System.Drawing.Point(15, 15);
            this.pbFavorite.Margin = new System.Windows.Forms.Padding(0);
            this.pbFavorite.Name = "pbFavorite";
            this.pbFavorite.Size = new System.Drawing.Size(50, 50);
            this.pbFavorite.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pbFavorite.TabIndex = 0;
            this.pbFavorite.TabStop = false;
            this.ttInfo.SetToolTip(this.pbFavorite, "Избранное");
            this.pbFavorite.Click += new System.EventHandler(this.pbFavorite_Click);
            // 
            // pbBasket
            // 
            this.pbBasket.Cursor = System.Windows.Forms.Cursors.Hand;
            this.pbBasket.Dock = System.Windows.Forms.DockStyle.Fill;
            this.pbBasket.Image = ((System.Drawing.Image)(resources.GetObject("pbBasket.Image")));
            this.pbBasket.Location = new System.Drawing.Point(15, 15);
            this.pbBasket.Margin = new System.Windows.Forms.Padding(0);
            this.pbBasket.Name = "pbBasket";
            this.pbBasket.Size = new System.Drawing.Size(50, 50);
            this.pbBasket.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pbBasket.TabIndex = 0;
            this.pbBasket.TabStop = false;
            this.ttInfo.SetToolTip(this.pbBasket, "Корзина");
            this.pbBasket.Click += new System.EventHandler(this.pbBasket_Click);
            // 
            // pbFAQ
            // 
            this.pbFAQ.Cursor = System.Windows.Forms.Cursors.Hand;
            this.pbFAQ.Dock = System.Windows.Forms.DockStyle.Fill;
            this.pbFAQ.Image = global::Apteka.Properties.Resources.FAQ;
            this.pbFAQ.Location = new System.Drawing.Point(15, 15);
            this.pbFAQ.Margin = new System.Windows.Forms.Padding(0);
            this.pbFAQ.Name = "pbFAQ";
            this.pbFAQ.Size = new System.Drawing.Size(50, 50);
            this.pbFAQ.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pbFAQ.TabIndex = 0;
            this.pbFAQ.TabStop = false;
            this.ttInfo.SetToolTip(this.pbFAQ, "Справка");
            // 
            // pbDis
            // 
            this.pbDis.Cursor = System.Windows.Forms.Cursors.Hand;
            this.pbDis.Dock = System.Windows.Forms.DockStyle.Fill;
            this.pbDis.Image = global::Apteka.Properties.Resources.del;
            this.pbDis.Location = new System.Drawing.Point(15, 15);
            this.pbDis.Margin = new System.Windows.Forms.Padding(0);
            this.pbDis.Name = "pbDis";
            this.pbDis.Size = new System.Drawing.Size(50, 50);
            this.pbDis.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pbDis.TabIndex = 0;
            this.pbDis.TabStop = false;
            this.ttInfo.SetToolTip(this.pbDis, "Списать товар");
            this.pbDis.Click += new System.EventHandler(this.pbDis_Click);
            // 
            // pbAdd
            // 
            this.pbAdd.Cursor = System.Windows.Forms.Cursors.Hand;
            this.pbAdd.Dock = System.Windows.Forms.DockStyle.Fill;
            this.pbAdd.Image = global::Apteka.Properties.Resources.add;
            this.pbAdd.Location = new System.Drawing.Point(15, 15);
            this.pbAdd.Margin = new System.Windows.Forms.Padding(0);
            this.pbAdd.Name = "pbAdd";
            this.pbAdd.Size = new System.Drawing.Size(50, 50);
            this.pbAdd.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pbAdd.TabIndex = 0;
            this.pbAdd.TabStop = false;
            this.ttInfo.SetToolTip(this.pbAdd, "Принять товар");
            this.pbAdd.Click += new System.EventHandler(this.pbAdd_Click);
            // 
            // pbOrder
            // 
            this.pbOrder.Cursor = System.Windows.Forms.Cursors.Hand;
            this.pbOrder.Dock = System.Windows.Forms.DockStyle.Fill;
            this.pbOrder.Image = ((System.Drawing.Image)(resources.GetObject("pbOrder.Image")));
            this.pbOrder.Location = new System.Drawing.Point(15, 15);
            this.pbOrder.Margin = new System.Windows.Forms.Padding(0);
            this.pbOrder.Name = "pbOrder";
            this.pbOrder.Size = new System.Drawing.Size(50, 50);
            this.pbOrder.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pbOrder.TabIndex = 0;
            this.pbOrder.TabStop = false;
            this.ttInfo.SetToolTip(this.pbOrder, "Заказы");
            this.pbOrder.Click += new System.EventHandler(this.pbOrder_Click);
            // 
            // pbUser
            // 
            this.pbUser.Cursor = System.Windows.Forms.Cursors.Hand;
            this.pbUser.Dock = System.Windows.Forms.DockStyle.Fill;
            this.pbUser.Image = global::Apteka.Properties.Resources.user;
            this.pbUser.Location = new System.Drawing.Point(15, 15);
            this.pbUser.Margin = new System.Windows.Forms.Padding(0);
            this.pbUser.Name = "pbUser";
            this.pbUser.Size = new System.Drawing.Size(50, 50);
            this.pbUser.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pbUser.TabIndex = 0;
            this.pbUser.TabStop = false;
            this.ttInfo.SetToolTip(this.pbUser, "Вход или регистрация");
            this.pbUser.Click += new System.EventHandler(this.pbUser_Click);
            // 
            // pbUsers
            // 
            this.pbUsers.Cursor = System.Windows.Forms.Cursors.Hand;
            this.pbUsers.Dock = System.Windows.Forms.DockStyle.Fill;
            this.pbUsers.Image = global::Apteka.Properties.Resources.users;
            this.pbUsers.Location = new System.Drawing.Point(15, 15);
            this.pbUsers.Margin = new System.Windows.Forms.Padding(0);
            this.pbUsers.Name = "pbUsers";
            this.pbUsers.Size = new System.Drawing.Size(50, 50);
            this.pbUsers.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pbUsers.TabIndex = 0;
            this.pbUsers.TabStop = false;
            this.ttInfo.SetToolTip(this.pbUsers, "Управление пользователями");
            this.pbUsers.Click += new System.EventHandler(this.pbUsers_Click);
            // 
            // pbAdm
            // 
            this.pbAdm.Cursor = System.Windows.Forms.Cursors.Hand;
            this.pbAdm.Dock = System.Windows.Forms.DockStyle.Fill;
            this.pbAdm.Image = global::Apteka.Properties.Resources.managment;
            this.pbAdm.Location = new System.Drawing.Point(15, 15);
            this.pbAdm.Margin = new System.Windows.Forms.Padding(0);
            this.pbAdm.Name = "pbAdm";
            this.pbAdm.Size = new System.Drawing.Size(50, 50);
            this.pbAdm.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pbAdm.TabIndex = 0;
            this.pbAdm.TabStop = false;
            this.ttInfo.SetToolTip(this.pbAdm, "Заказы");
            this.pbAdm.Click += new System.EventHandler(this.pbAdm_Click);
            // 
            // pMain
            // 
            this.pMain.BackColor = System.Drawing.Color.White;
            this.pMain.Controls.Add(this.pAdm);
            this.pMain.Controls.Add(this.pUsers);
            this.pMain.Controls.Add(this.pUser);
            this.pMain.Controls.Add(this.pAdd);
            this.pMain.Controls.Add(this.pDis);
            this.pMain.Controls.Add(this.pOrder);
            this.pMain.Controls.Add(this.pFavorite);
            this.pMain.Controls.Add(this.pBasket);
            this.pMain.Controls.Add(this.panel4);
            this.pMain.Controls.Add(this.pExit);
            this.pMain.Controls.Add(this.pImg);
            this.pMain.Dock = System.Windows.Forms.DockStyle.Top;
            this.pMain.ForeColor = System.Drawing.Color.White;
            this.pMain.ImeMode = System.Windows.Forms.ImeMode.On;
            this.pMain.Location = new System.Drawing.Point(0, 0);
            this.pMain.Margin = new System.Windows.Forms.Padding(0);
            this.pMain.Name = "pMain";
            this.pMain.Size = new System.Drawing.Size(982, 80);
            this.pMain.TabIndex = 104;
            // 
            // pAdm
            // 
            this.pAdm.Controls.Add(this.pbAdm);
            this.pAdm.Dock = System.Windows.Forms.DockStyle.Right;
            this.pAdm.Location = new System.Drawing.Point(262, 0);
            this.pAdm.Name = "pAdm";
            this.pAdm.Padding = new System.Windows.Forms.Padding(15);
            this.pAdm.Size = new System.Drawing.Size(80, 80);
            this.pAdm.TabIndex = 136;
            this.pAdm.Visible = false;
            // 
            // pUsers
            // 
            this.pUsers.Controls.Add(this.pbUsers);
            this.pUsers.Dock = System.Windows.Forms.DockStyle.Right;
            this.pUsers.Location = new System.Drawing.Point(342, 0);
            this.pUsers.Name = "pUsers";
            this.pUsers.Padding = new System.Windows.Forms.Padding(15);
            this.pUsers.Size = new System.Drawing.Size(80, 80);
            this.pUsers.TabIndex = 135;
            this.pUsers.Visible = false;
            // 
            // pUser
            // 
            this.pUser.Controls.Add(this.pbUser);
            this.pUser.Dock = System.Windows.Forms.DockStyle.Right;
            this.pUser.Location = new System.Drawing.Point(422, 0);
            this.pUser.Name = "pUser";
            this.pUser.Padding = new System.Windows.Forms.Padding(15);
            this.pUser.Size = new System.Drawing.Size(80, 80);
            this.pUser.TabIndex = 132;
            // 
            // pAdd
            // 
            this.pAdd.Controls.Add(this.pbAdd);
            this.pAdd.Dock = System.Windows.Forms.DockStyle.Right;
            this.pAdd.Location = new System.Drawing.Point(502, 0);
            this.pAdd.Name = "pAdd";
            this.pAdd.Padding = new System.Windows.Forms.Padding(15);
            this.pAdd.Size = new System.Drawing.Size(80, 80);
            this.pAdd.TabIndex = 131;
            this.pAdd.Visible = false;
            // 
            // pDis
            // 
            this.pDis.Controls.Add(this.pbDis);
            this.pDis.Dock = System.Windows.Forms.DockStyle.Right;
            this.pDis.Location = new System.Drawing.Point(582, 0);
            this.pDis.Name = "pDis";
            this.pDis.Padding = new System.Windows.Forms.Padding(15);
            this.pDis.Size = new System.Drawing.Size(80, 80);
            this.pDis.TabIndex = 130;
            this.pDis.Visible = false;
            this.pDis.Click += new System.EventHandler(this.pbDis_Click);
            // 
            // pOrder
            // 
            this.pOrder.Controls.Add(this.pbOrder);
            this.pOrder.Dock = System.Windows.Forms.DockStyle.Right;
            this.pOrder.Location = new System.Drawing.Point(662, 0);
            this.pOrder.Name = "pOrder";
            this.pOrder.Padding = new System.Windows.Forms.Padding(15);
            this.pOrder.Size = new System.Drawing.Size(80, 80);
            this.pOrder.TabIndex = 122;
            // 
            // pFavorite
            // 
            this.pFavorite.Controls.Add(this.pbFavorite);
            this.pFavorite.Dock = System.Windows.Forms.DockStyle.Right;
            this.pFavorite.Location = new System.Drawing.Point(742, 0);
            this.pFavorite.Name = "pFavorite";
            this.pFavorite.Padding = new System.Windows.Forms.Padding(15);
            this.pFavorite.Size = new System.Drawing.Size(80, 80);
            this.pFavorite.TabIndex = 121;
            // 
            // pBasket
            // 
            this.pBasket.Controls.Add(this.pbBasket);
            this.pBasket.Dock = System.Windows.Forms.DockStyle.Right;
            this.pBasket.Location = new System.Drawing.Point(822, 0);
            this.pBasket.Name = "pBasket";
            this.pBasket.Padding = new System.Windows.Forms.Padding(15);
            this.pBasket.Size = new System.Drawing.Size(80, 80);
            this.pBasket.TabIndex = 120;
            // 
            // panel4
            // 
            this.panel4.Controls.Add(this.pbFAQ);
            this.panel4.Dock = System.Windows.Forms.DockStyle.Right;
            this.panel4.Location = new System.Drawing.Point(902, 0);
            this.panel4.Name = "panel4";
            this.panel4.Padding = new System.Windows.Forms.Padding(15);
            this.panel4.Size = new System.Drawing.Size(80, 80);
            this.panel4.TabIndex = 119;
            this.panel4.Visible = false;
            // 
            // pExit
            // 
            this.pExit.Controls.Add(this.pbExit);
            this.pExit.Dock = System.Windows.Forms.DockStyle.Left;
            this.pExit.Location = new System.Drawing.Point(125, 0);
            this.pExit.Name = "pExit";
            this.pExit.Padding = new System.Windows.Forms.Padding(15);
            this.pExit.Size = new System.Drawing.Size(80, 80);
            this.pExit.TabIndex = 113;
            this.pExit.Visible = false;
            // 
            // pbExit
            // 
            this.pbExit.Cursor = System.Windows.Forms.Cursors.Hand;
            this.pbExit.Dock = System.Windows.Forms.DockStyle.Fill;
            this.pbExit.Image = global::Apteka.Properties.Resources.exit;
            this.pbExit.Location = new System.Drawing.Point(15, 15);
            this.pbExit.Name = "pbExit";
            this.pbExit.Size = new System.Drawing.Size(50, 50);
            this.pbExit.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pbExit.TabIndex = 113;
            this.pbExit.TabStop = false;
            this.pbExit.Click += new System.EventHandler(this.pbExit_Click);
            // 
            // pImg
            // 
            this.pImg.Controls.Add(this.pbImg);
            this.pImg.Dock = System.Windows.Forms.DockStyle.Left;
            this.pImg.Location = new System.Drawing.Point(0, 0);
            this.pImg.Name = "pImg";
            this.pImg.Padding = new System.Windows.Forms.Padding(25, 5, 0, 5);
            this.pImg.Size = new System.Drawing.Size(125, 80);
            this.pImg.TabIndex = 110;
            // 
            // pbImg
            // 
            this.pbImg.Dock = System.Windows.Forms.DockStyle.Fill;
            this.pbImg.Image = ((System.Drawing.Image)(resources.GetObject("pbImg.Image")));
            this.pbImg.Location = new System.Drawing.Point(25, 5);
            this.pbImg.Name = "pbImg";
            this.pbImg.Size = new System.Drawing.Size(100, 70);
            this.pbImg.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pbImg.TabIndex = 0;
            this.pbImg.TabStop = false;
            // 
            // panelChildForm
            // 
            this.panelChildForm.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panelChildForm.Location = new System.Drawing.Point(0, 127);
            this.panelChildForm.Margin = new System.Windows.Forms.Padding(0);
            this.panelChildForm.Name = "panelChildForm";
            this.panelChildForm.Size = new System.Drawing.Size(982, 626);
            this.panelChildForm.TabIndex = 107;
            this.panelChildForm.Resize += new System.EventHandler(this.panelChildForm_Resize);
            // 
            // pTop
            // 
            this.pTop.BackgroundImage = global::Apteka.Properties.Resources.fon2;
            this.pTop.Controls.Add(this.pSearch);
            this.pTop.Controls.Add(this.pbSearch);
            this.pTop.Dock = System.Windows.Forms.DockStyle.Top;
            this.pTop.Location = new System.Drawing.Point(0, 80);
            this.pTop.Margin = new System.Windows.Forms.Padding(0);
            this.pTop.Name = "pTop";
            this.pTop.Size = new System.Drawing.Size(982, 47);
            this.pTop.TabIndex = 106;
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
            this.pSearch.Size = new System.Drawing.Size(898, 47);
            this.pSearch.TabIndex = 3;
            // 
            // tbxSearch
            // 
            this.tbxSearch.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tbxSearch.Font = new System.Drawing.Font("Segoe UI", 13.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.tbxSearch.Location = new System.Drawing.Point(5, 5);
            this.tbxSearch.Margin = new System.Windows.Forms.Padding(0);
            this.tbxSearch.Name = "tbxSearch";
            this.tbxSearch.Size = new System.Drawing.Size(888, 38);
            this.tbxSearch.TabIndex = 1;
            this.tbxSearch.TextChanged += new System.EventHandler(this.tbxSearch_TextChanged);
            this.tbxSearch.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.tbxSearch_KeyPress);
            // 
            // pbSearch
            // 
            this.pbSearch.Dock = System.Windows.Forms.DockStyle.Right;
            this.pbSearch.Image = global::Apteka.Properties.Resources.searching;
            this.pbSearch.Location = new System.Drawing.Point(898, 0);
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
            // bsUser
            // 
            this.bsUser.DataMember = "User";
            this.bsUser.DataSource = this.dsApteka;
            // 
            // bsGoods
            // 
            this.bsGoods.DataMember = "Goods";
            this.bsGoods.DataSource = this.dsApteka;
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
            // goodsTableAdapter
            // 
            this.goodsTableAdapter.ClearBeforeFill = true;
            // 
            // userTableAdapter
            // 
            this.userTableAdapter.ClearBeforeFill = true;
            // 
            // Dashboard
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(12F, 28F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.ClientSize = new System.Drawing.Size(982, 753);
            this.Controls.Add(this.panelChildForm);
            this.Controls.Add(this.pTop);
            this.Controls.Add(this.pMain);
            this.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Bold);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.MinimumSize = new System.Drawing.Size(950, 800);
            this.Name = "Dashboard";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "АИС \"Аптека\"";
            this.WindowState = System.Windows.Forms.FormWindowState.Maximized;
            this.MdiChildActivate += new System.EventHandler(this.mainForm_MdiChildActivate);
            this.Resize += new System.EventHandler(this.Dashboard_Resize);
            ((System.ComponentModel.ISupportInitialize)(this.pbFavorite)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pbBasket)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pbFAQ)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pbDis)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pbAdd)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pbOrder)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pbUser)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pbUsers)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pbAdm)).EndInit();
            this.pMain.ResumeLayout(false);
            this.pAdm.ResumeLayout(false);
            this.pUsers.ResumeLayout(false);
            this.pUser.ResumeLayout(false);
            this.pAdd.ResumeLayout(false);
            this.pDis.ResumeLayout(false);
            this.pOrder.ResumeLayout(false);
            this.pFavorite.ResumeLayout(false);
            this.pBasket.ResumeLayout(false);
            this.panel4.ResumeLayout(false);
            this.pExit.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.pbExit)).EndInit();
            this.pImg.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.pbImg)).EndInit();
            this.pTop.ResumeLayout(false);
            this.pSearch.ResumeLayout(false);
            this.pSearch.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pbSearch)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dsApteka)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.bsUser)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.bsGoods)).EndInit();
            this.ResumeLayout(false);

		}

		#endregion
		private dsApteka dsApteka;
		public System.Windows.Forms.BindingSource bsUser;
		private System.Windows.Forms.ToolTip ttInfo;
		private System.Windows.Forms.Panel pMain;
		private System.Windows.Forms.Panel pExit;
		private System.Windows.Forms.PictureBox pbExit;
		private System.Windows.Forms.Panel pImg;
		private System.Windows.Forms.PictureBox pbImg;
		private System.Windows.Forms.BindingSource bsGoods;
		private dsAptekaTableAdapters.TableAdapterManager tableAdapterManager;
		private System.Windows.Forms.Panel panelChildForm;
		private System.Windows.Forms.Panel pTop;
		private System.Windows.Forms.Panel pSearch;
		private System.Windows.Forms.TextBox tbxSearch;
		private System.Windows.Forms.PictureBox pbSearch;
		private System.Windows.Forms.Panel pFavorite;
		private System.Windows.Forms.PictureBox pbFavorite;
		private System.Windows.Forms.Panel pBasket;
		private System.Windows.Forms.PictureBox pbBasket;
		private System.Windows.Forms.Panel panel4;
		private System.Windows.Forms.PictureBox pbFAQ;
		private System.Windows.Forms.Panel pAdd;
		public System.Windows.Forms.PictureBox pbAdd;
		private System.Windows.Forms.Panel pDis;
		public System.Windows.Forms.PictureBox pbDis;
		private System.Windows.Forms.Panel pUser;
		public System.Windows.Forms.PictureBox pbUser;
		private System.Windows.Forms.Panel pOrder;
		private System.Windows.Forms.PictureBox pbOrder;
		private System.Windows.Forms.Panel pUsers;
		public System.Windows.Forms.PictureBox pbUsers;
		private System.Windows.Forms.Panel pAdm;
		public System.Windows.Forms.PictureBox pbAdm;
		private dsAptekaTableAdapters.GoodsTableAdapter goodsTableAdapter;
		private dsAptekaTableAdapters.UserTableAdapter userTableAdapter;
	}
}

