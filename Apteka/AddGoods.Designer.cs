namespace Apteka
{
	partial class AddGoods
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
            System.Windows.Forms.Label label24;
            System.Windows.Forms.Label label23;
            System.Windows.Forms.Label lblName;
            System.Windows.Forms.Label label2;
            System.Windows.Forms.Label label3;
            System.Windows.Forms.Label label4;
            System.Windows.Forms.Label label5;
            System.Windows.Forms.Label label6;
            System.Windows.Forms.Label label7;
            System.Windows.Forms.Label label8;
            System.Windows.Forms.Label label9;
            System.Windows.Forms.Label label10;
            System.Windows.Forms.Label label11;
            System.Windows.Forms.Label label1;
            System.Windows.Forms.Label nameLabel;
            System.Windows.Forms.Label label13;
            System.Windows.Forms.Label label12;
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(AddGoods));
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle1 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle2 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle3 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle4 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle5 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle6 = new System.Windows.Forms.DataGridViewCellStyle();
            this.dsApteka = new Apteka.dsApteka();
            this.bsGoods = new System.Windows.Forms.BindingSource(this.components);
            this.goodsTableAdapter = new Apteka.dsAptekaTableAdapters.GoodsTableAdapter();
            this.tableAdapterManager = new Apteka.dsAptekaTableAdapters.TableAdapterManager();
            this.tGTableAdapter = new Apteka.dsAptekaTableAdapters.TGTableAdapter();
            this.nameTextBox = new System.Windows.Forms.TextBox();
            this.infoTextBox = new System.Windows.Forms.TextBox();
            this.compTextBox = new System.Windows.Forms.TextBox();
            this.recomendTextBox = new System.Windows.Forms.TextBox();
            this.contrindicTextBox = new System.Windows.Forms.TextBox();
            this.countTextBox = new System.Windows.Forms.TextBox();
            this.dosageTextBox = new System.Windows.Forms.TextBox();
            this.shelfLifeTextBox = new System.Windows.Forms.TextBox();
            this.storageCondTextBox = new System.Windows.Forms.TextBox();
            this.manufactureTextBox = new System.Windows.Forms.TextBox();
            this.priceTextBox = new System.Windows.Forms.TextBox();
            this.bsTG = new System.Windows.Forms.BindingSource(this.components);
            this.openFileDialog1 = new System.Windows.Forms.OpenFileDialog();
            this.pbClose = new System.Windows.Forms.PictureBox();
            this.nameTGTextBox = new System.Windows.Forms.TextBox();
            this.unitTextBox = new System.Windows.Forms.TextBox();
            this.imagePictureBox = new System.Windows.Forms.PictureBox();
            this.btnAccept = new System.Windows.Forms.Button();
            this.tp3 = new System.Windows.Forms.TabPage();
            this.panel4 = new System.Windows.Forms.Panel();
            this.dgvTG = new System.Windows.Forms.DataGridView();
            this.dataGridViewTextBoxColumn1 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn2 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.btnDelTG = new System.Windows.Forms.Button();
            this.panel5 = new System.Windows.Forms.Panel();
            this.tbxUnit = new System.Windows.Forms.TextBox();
            this.tbxnameTG = new System.Windows.Forms.TextBox();
            this.btnAddTG = new System.Windows.Forms.Button();
            this.tp2 = new System.Windows.Forms.TabPage();
            this.panel1 = new System.Windows.Forms.Panel();
            this.dgvGoods = new System.Windows.Forms.DataGridView();
            this.image = new System.Windows.Forms.DataGridViewImageColumn();
            this.name = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.info = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.recomend = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.contrindic = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.count = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dosage = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.shelfLife = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.storageCond = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.manufacture = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.price = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.stock = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.btnDel = new System.Windows.Forms.Button();
            this.panel2 = new System.Windows.Forms.Panel();
            this.panel3 = new System.Windows.Forms.Panel();
            this.pbImage = new System.Windows.Forms.PictureBox();
            this.btnImage = new System.Windows.Forms.Button();
            this.cbxTG = new System.Windows.Forms.ComboBox();
            this.tbxInfo = new System.Windows.Forms.TextBox();
            this.tbxStock = new System.Windows.Forms.TextBox();
            this.tbxDosage = new System.Windows.Forms.TextBox();
            this.tbxCount = new System.Windows.Forms.TextBox();
            this.tbxPrice = new System.Windows.Forms.TextBox();
            this.tbxManufacture = new System.Windows.Forms.TextBox();
            this.tbxStorageCond = new System.Windows.Forms.TextBox();
            this.tbxShelfLife = new System.Windows.Forms.TextBox();
            this.tbxContrindic = new System.Windows.Forms.TextBox();
            this.tbxRecomend = new System.Windows.Forms.TextBox();
            this.tbxComp = new System.Windows.Forms.TextBox();
            this.tbxName = new System.Windows.Forms.TextBox();
            this.btnAdd = new System.Windows.Forms.Button();
            this.tp1 = new System.Windows.Forms.TabPage();
            this.pAddExG = new System.Windows.Forms.Panel();
            this.dgvExGoods = new System.Windows.Forms.DataGridView();
            this.dataGridViewTextBoxColumn3 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn4 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.id = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.btnDelEG = new System.Windows.Forms.Button();
            this.panel7 = new System.Windows.Forms.Panel();
            this.tbxCountExGoods = new System.Windows.Forms.TextBox();
            this.cbxExGoods = new System.Windows.Forms.ComboBox();
            this.btnAddEG = new System.Windows.Forms.Button();
            this.tabControl1 = new System.Windows.Forms.TabControl();
            this.discountTextBox = new System.Windows.Forms.TextBox();
            this.stockTextBox = new System.Windows.Forms.TextBox();
            this.idTGTextBox = new System.Windows.Forms.TextBox();
            label24 = new System.Windows.Forms.Label();
            label23 = new System.Windows.Forms.Label();
            lblName = new System.Windows.Forms.Label();
            label2 = new System.Windows.Forms.Label();
            label3 = new System.Windows.Forms.Label();
            label4 = new System.Windows.Forms.Label();
            label5 = new System.Windows.Forms.Label();
            label6 = new System.Windows.Forms.Label();
            label7 = new System.Windows.Forms.Label();
            label8 = new System.Windows.Forms.Label();
            label9 = new System.Windows.Forms.Label();
            label10 = new System.Windows.Forms.Label();
            label11 = new System.Windows.Forms.Label();
            label1 = new System.Windows.Forms.Label();
            nameLabel = new System.Windows.Forms.Label();
            label13 = new System.Windows.Forms.Label();
            label12 = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.dsApteka)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.bsGoods)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.bsTG)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pbClose)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.imagePictureBox)).BeginInit();
            this.tp3.SuspendLayout();
            this.panel4.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvTG)).BeginInit();
            this.panel5.SuspendLayout();
            this.tp2.SuspendLayout();
            this.panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvGoods)).BeginInit();
            this.panel2.SuspendLayout();
            this.panel3.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pbImage)).BeginInit();
            this.tp1.SuspendLayout();
            this.pAddExG.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvExGoods)).BeginInit();
            this.panel7.SuspendLayout();
            this.tabControl1.SuspendLayout();
            this.SuspendLayout();
            // 
            // label24
            // 
            label24.AutoSize = true;
            label24.Dock = System.Windows.Forms.DockStyle.Top;
            label24.Location = new System.Drawing.Point(0, 0);
            label24.Name = "label24";
            label24.Size = new System.Drawing.Size(134, 32);
            label24.TabIndex = 170;
            label24.Text = "Название:";
            // 
            // label23
            // 
            label23.AutoSize = true;
            label23.Dock = System.Windows.Forms.DockStyle.Top;
            label23.Location = new System.Drawing.Point(0, 64);
            label23.Name = "label23";
            label23.Size = new System.Drawing.Size(261, 32);
            label23.TabIndex = 172;
            label23.Text = "Единица измерения:";
            // 
            // lblName
            // 
            lblName.AutoSize = true;
            lblName.Dock = System.Windows.Forms.DockStyle.Top;
            lblName.Location = new System.Drawing.Point(0, 0);
            lblName.Name = "lblName";
            lblName.Size = new System.Drawing.Size(134, 32);
            lblName.TabIndex = 166;
            lblName.Text = "Название:";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Dock = System.Windows.Forms.DockStyle.Top;
            label2.Location = new System.Drawing.Point(0, 64);
            label2.Name = "label2";
            label2.Size = new System.Drawing.Size(175, 32);
            label2.TabIndex = 168;
            label2.Text = "Компоненты:";
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Dock = System.Windows.Forms.DockStyle.Top;
            label3.Location = new System.Drawing.Point(0, 128);
            label3.Name = "label3";
            label3.Size = new System.Drawing.Size(197, 32);
            label3.TabIndex = 170;
            label3.Text = "Рекомендации:";
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Dock = System.Windows.Forms.DockStyle.Top;
            label4.Location = new System.Drawing.Point(0, 192);
            label4.Name = "label4";
            label4.Size = new System.Drawing.Size(249, 32);
            label4.TabIndex = 172;
            label4.Text = "Противопоказания:";
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Dock = System.Windows.Forms.DockStyle.Top;
            label5.Location = new System.Drawing.Point(0, 256);
            label5.Name = "label5";
            label5.Size = new System.Drawing.Size(194, 32);
            label5.TabIndex = 174;
            label5.Text = "Срок годности:";
            // 
            // label6
            // 
            label6.AutoSize = true;
            label6.Dock = System.Windows.Forms.DockStyle.Top;
            label6.Location = new System.Drawing.Point(0, 320);
            label6.Name = "label6";
            label6.Size = new System.Drawing.Size(239, 32);
            label6.TabIndex = 176;
            label6.Text = "Условия хранения:";
            // 
            // label7
            // 
            label7.AutoSize = true;
            label7.Dock = System.Windows.Forms.DockStyle.Top;
            label7.Location = new System.Drawing.Point(0, 384);
            label7.Name = "label7";
            label7.Size = new System.Drawing.Size(206, 32);
            label7.TabIndex = 178;
            label7.Text = "Производитель:";
            // 
            // label8
            // 
            label8.AutoSize = true;
            label8.Dock = System.Windows.Forms.DockStyle.Top;
            label8.Location = new System.Drawing.Point(0, 448);
            label8.Name = "label8";
            label8.Size = new System.Drawing.Size(82, 32);
            label8.TabIndex = 180;
            label8.Text = "Цена:";
            // 
            // label9
            // 
            label9.AutoSize = true;
            label9.Dock = System.Windows.Forms.DockStyle.Top;
            label9.Location = new System.Drawing.Point(0, 512);
            label9.Name = "label9";
            label9.Size = new System.Drawing.Size(248, 32);
            label9.TabIndex = 182;
            label9.Text = "В упаковке(шт, мл):";
            // 
            // label10
            // 
            label10.AutoSize = true;
            label10.Dock = System.Windows.Forms.DockStyle.Top;
            label10.Location = new System.Drawing.Point(0, 576);
            label10.Name = "label10";
            label10.Size = new System.Drawing.Size(180, 32);
            label10.TabIndex = 184;
            label10.Text = "Дозировка(г):";
            // 
            // label11
            // 
            label11.AutoSize = true;
            label11.Dock = System.Windows.Forms.DockStyle.Top;
            label11.Location = new System.Drawing.Point(0, 640);
            label11.Name = "label11";
            label11.Size = new System.Drawing.Size(213, 32);
            label11.TabIndex = 186;
            label11.Text = "Ко-во на складе:";
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Dock = System.Windows.Forms.DockStyle.Top;
            label1.Location = new System.Drawing.Point(0, 704);
            label1.Name = "label1";
            label1.Size = new System.Drawing.Size(137, 32);
            label1.TabIndex = 188;
            label1.Text = "Описание:";
            // 
            // nameLabel
            // 
            nameLabel.AutoSize = true;
            nameLabel.Dock = System.Windows.Forms.DockStyle.Top;
            nameLabel.Location = new System.Drawing.Point(0, 768);
            nameLabel.Name = "nameLabel";
            nameLabel.Size = new System.Drawing.Size(151, 32);
            nameLabel.TabIndex = 190;
            nameLabel.Text = "Тип товара:";
            // 
            // label13
            // 
            label13.AutoSize = true;
            label13.Dock = System.Windows.Forms.DockStyle.Top;
            label13.Location = new System.Drawing.Point(0, 0);
            label13.Name = "label13";
            label13.Size = new System.Drawing.Size(90, 32);
            label13.TabIndex = 170;
            label13.Text = "Товар:";
            // 
            // label12
            // 
            label12.AutoSize = true;
            label12.Dock = System.Windows.Forms.DockStyle.Top;
            label12.Location = new System.Drawing.Point(0, 71);
            label12.Name = "label12";
            label12.Size = new System.Drawing.Size(105, 32);
            label12.TabIndex = 193;
            label12.Text = "Кол-во:";
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
            this.tableAdapterManager.TGTableAdapter = this.tGTableAdapter;
            this.tableAdapterManager.UpdateOrder = Apteka.dsAptekaTableAdapters.TableAdapterManager.UpdateOrderOption.InsertUpdateDelete;
            this.tableAdapterManager.UserTableAdapter = null;
            // 
            // tGTableAdapter
            // 
            this.tGTableAdapter.ClearBeforeFill = true;
            // 
            // nameTextBox
            // 
            this.nameTextBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.bsGoods, "name", true));
            this.nameTextBox.Location = new System.Drawing.Point(117, 103);
            this.nameTextBox.Name = "nameTextBox";
            this.nameTextBox.Size = new System.Drawing.Size(100, 39);
            this.nameTextBox.TabIndex = 60;
            // 
            // infoTextBox
            // 
            this.infoTextBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.bsGoods, "info", true));
            this.infoTextBox.Location = new System.Drawing.Point(117, 148);
            this.infoTextBox.Name = "infoTextBox";
            this.infoTextBox.Size = new System.Drawing.Size(100, 39);
            this.infoTextBox.TabIndex = 61;
            // 
            // compTextBox
            // 
            this.compTextBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.bsGoods, "comp", true));
            this.compTextBox.Location = new System.Drawing.Point(117, 193);
            this.compTextBox.Name = "compTextBox";
            this.compTextBox.Size = new System.Drawing.Size(100, 39);
            this.compTextBox.TabIndex = 62;
            // 
            // recomendTextBox
            // 
            this.recomendTextBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.bsGoods, "recomend", true));
            this.recomendTextBox.Location = new System.Drawing.Point(117, 238);
            this.recomendTextBox.Name = "recomendTextBox";
            this.recomendTextBox.Size = new System.Drawing.Size(100, 39);
            this.recomendTextBox.TabIndex = 63;
            // 
            // contrindicTextBox
            // 
            this.contrindicTextBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.bsGoods, "contrindic", true));
            this.contrindicTextBox.Location = new System.Drawing.Point(117, 283);
            this.contrindicTextBox.Name = "contrindicTextBox";
            this.contrindicTextBox.Size = new System.Drawing.Size(100, 39);
            this.contrindicTextBox.TabIndex = 64;
            // 
            // countTextBox
            // 
            this.countTextBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.bsGoods, "count", true));
            this.countTextBox.Location = new System.Drawing.Point(117, 328);
            this.countTextBox.Name = "countTextBox";
            this.countTextBox.Size = new System.Drawing.Size(100, 39);
            this.countTextBox.TabIndex = 65;
            // 
            // dosageTextBox
            // 
            this.dosageTextBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.bsGoods, "dosage", true));
            this.dosageTextBox.Location = new System.Drawing.Point(117, 373);
            this.dosageTextBox.Name = "dosageTextBox";
            this.dosageTextBox.Size = new System.Drawing.Size(100, 39);
            this.dosageTextBox.TabIndex = 66;
            // 
            // shelfLifeTextBox
            // 
            this.shelfLifeTextBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.bsGoods, "shelfLife", true));
            this.shelfLifeTextBox.Location = new System.Drawing.Point(223, 103);
            this.shelfLifeTextBox.Name = "shelfLifeTextBox";
            this.shelfLifeTextBox.Size = new System.Drawing.Size(100, 39);
            this.shelfLifeTextBox.TabIndex = 67;
            // 
            // storageCondTextBox
            // 
            this.storageCondTextBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.bsGoods, "storageCond", true));
            this.storageCondTextBox.Location = new System.Drawing.Point(223, 148);
            this.storageCondTextBox.Name = "storageCondTextBox";
            this.storageCondTextBox.Size = new System.Drawing.Size(100, 39);
            this.storageCondTextBox.TabIndex = 68;
            // 
            // manufactureTextBox
            // 
            this.manufactureTextBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.bsGoods, "manufacture", true));
            this.manufactureTextBox.Location = new System.Drawing.Point(223, 193);
            this.manufactureTextBox.Name = "manufactureTextBox";
            this.manufactureTextBox.Size = new System.Drawing.Size(100, 39);
            this.manufactureTextBox.TabIndex = 69;
            // 
            // priceTextBox
            // 
            this.priceTextBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.bsGoods, "price", true));
            this.priceTextBox.Location = new System.Drawing.Point(223, 238);
            this.priceTextBox.Name = "priceTextBox";
            this.priceTextBox.Size = new System.Drawing.Size(100, 39);
            this.priceTextBox.TabIndex = 70;
            // 
            // bsTG
            // 
            this.bsTG.DataMember = "TG";
            this.bsTG.DataSource = this.dsApteka;
            // 
            // openFileDialog1
            // 
            this.openFileDialog1.FileName = "openFileDialog1";
            // 
            // pbClose
            // 
            this.pbClose.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.pbClose.BackColor = System.Drawing.Color.Transparent;
            this.pbClose.Cursor = System.Windows.Forms.Cursors.Hand;
            this.pbClose.ErrorImage = global::Apteka.Properties.Resources.error;
            this.pbClose.Image = ((System.Drawing.Image)(resources.GetObject("pbClose.Image")));
            this.pbClose.Location = new System.Drawing.Point(743, 1);
            this.pbClose.Name = "pbClose";
            this.pbClose.Size = new System.Drawing.Size(25, 25);
            this.pbClose.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pbClose.TabIndex = 58;
            this.pbClose.TabStop = false;
            this.pbClose.Tag = "100";
            this.pbClose.Click += new System.EventHandler(this.pbClose_Click);
            // 
            // nameTGTextBox
            // 
            this.nameTGTextBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.bsTG, "name", true));
            this.nameTGTextBox.Location = new System.Drawing.Point(475, 108);
            this.nameTGTextBox.Name = "nameTGTextBox";
            this.nameTGTextBox.Size = new System.Drawing.Size(100, 39);
            this.nameTGTextBox.TabIndex = 71;
            // 
            // unitTextBox
            // 
            this.unitTextBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.bsTG, "unit", true));
            this.unitTextBox.Location = new System.Drawing.Point(485, 177);
            this.unitTextBox.Name = "unitTextBox";
            this.unitTextBox.Size = new System.Drawing.Size(100, 39);
            this.unitTextBox.TabIndex = 72;
            // 
            // imagePictureBox
            // 
            this.imagePictureBox.DataBindings.Add(new System.Windows.Forms.Binding("Image", this.bsGoods, "image", true));
            this.imagePictureBox.Location = new System.Drawing.Point(417, 319);
            this.imagePictureBox.Name = "imagePictureBox";
            this.imagePictureBox.Size = new System.Drawing.Size(100, 50);
            this.imagePictureBox.TabIndex = 75;
            this.imagePictureBox.TabStop = false;
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
            this.btnAccept.Size = new System.Drawing.Size(719, 70);
            this.btnAccept.TabIndex = 74;
            this.btnAccept.TabStop = false;
            this.btnAccept.Text = "Принять документ к учёту";
            this.btnAccept.UseVisualStyleBackColor = false;
            this.btnAccept.Click += new System.EventHandler(this.btnAccept_Click);
            // 
            // tp3
            // 
            this.tp3.Controls.Add(this.panel4);
            this.tp3.Location = new System.Drawing.Point(4, 40);
            this.tp3.Name = "tp3";
            this.tp3.Padding = new System.Windows.Forms.Padding(3);
            this.tp3.Size = new System.Drawing.Size(711, 486);
            this.tp3.TabIndex = 2;
            this.tp3.Text = "Добавить новый тип товара";
            this.tp3.UseVisualStyleBackColor = true;
            // 
            // panel4
            // 
            this.panel4.Controls.Add(this.dgvTG);
            this.panel4.Controls.Add(this.btnDelTG);
            this.panel4.Controls.Add(this.panel5);
            this.panel4.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panel4.Location = new System.Drawing.Point(3, 3);
            this.panel4.Name = "panel4";
            this.panel4.Size = new System.Drawing.Size(705, 480);
            this.panel4.TabIndex = 75;
            // 
            // dgvTG
            // 
            this.dgvTG.AllowUserToAddRows = false;
            this.dgvTG.AllowUserToDeleteRows = false;
            this.dgvTG.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.AllCells;
            this.dgvTG.AutoSizeRowsMode = System.Windows.Forms.DataGridViewAutoSizeRowsMode.AllCells;
            this.dgvTG.BackgroundColor = System.Drawing.Color.White;
            dataGridViewCellStyle1.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle1.BackColor = System.Drawing.Color.White;
            dataGridViewCellStyle1.Font = new System.Drawing.Font("Segoe UI", 14F, System.Drawing.FontStyle.Bold);
            dataGridViewCellStyle1.ForeColor = System.Drawing.SystemColors.WindowText;
            dataGridViewCellStyle1.SelectionBackColor = System.Drawing.Color.White;
            dataGridViewCellStyle1.SelectionForeColor = System.Drawing.SystemColors.WindowText;
            dataGridViewCellStyle1.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dgvTG.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle1;
            this.dgvTG.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvTG.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.dataGridViewTextBoxColumn1,
            this.dataGridViewTextBoxColumn2});
            dataGridViewCellStyle2.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle2.BackColor = System.Drawing.SystemColors.Window;
            dataGridViewCellStyle2.Font = new System.Drawing.Font("Segoe UI", 14F, System.Drawing.FontStyle.Bold);
            dataGridViewCellStyle2.ForeColor = System.Drawing.SystemColors.ControlText;
            dataGridViewCellStyle2.SelectionBackColor = System.Drawing.SystemColors.Window;
            dataGridViewCellStyle2.SelectionForeColor = System.Drawing.SystemColors.ControlText;
            dataGridViewCellStyle2.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dgvTG.DefaultCellStyle = dataGridViewCellStyle2;
            this.dgvTG.Dock = System.Windows.Forms.DockStyle.Fill;
            this.dgvTG.Location = new System.Drawing.Point(0, 176);
            this.dgvTG.Name = "dgvTG";
            this.dgvTG.ReadOnly = true;
            this.dgvTG.RowHeadersWidth = 51;
            this.dgvTG.RowTemplate.Height = 24;
            this.dgvTG.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dgvTG.Size = new System.Drawing.Size(705, 259);
            this.dgvTG.TabIndex = 51;
            // 
            // dataGridViewTextBoxColumn1
            // 
            this.dataGridViewTextBoxColumn1.HeaderText = "Название";
            this.dataGridViewTextBoxColumn1.MinimumWidth = 6;
            this.dataGridViewTextBoxColumn1.Name = "dataGridViewTextBoxColumn1";
            this.dataGridViewTextBoxColumn1.ReadOnly = true;
            this.dataGridViewTextBoxColumn1.Width = 156;
            // 
            // dataGridViewTextBoxColumn2
            // 
            this.dataGridViewTextBoxColumn2.HeaderText = "Единица измерения";
            this.dataGridViewTextBoxColumn2.MinimumWidth = 6;
            this.dataGridViewTextBoxColumn2.Name = "dataGridViewTextBoxColumn2";
            this.dataGridViewTextBoxColumn2.ReadOnly = true;
            this.dataGridViewTextBoxColumn2.Width = 257;
            // 
            // btnDelTG
            // 
            this.btnDelTG.AccessibleDescription = "";
            this.btnDelTG.BackColor = System.Drawing.Color.Green;
            this.btnDelTG.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnDelTG.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.btnDelTG.FlatAppearance.BorderSize = 0;
            this.btnDelTG.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnDelTG.Font = new System.Drawing.Font("Segoe UI", 14F, System.Drawing.FontStyle.Bold);
            this.btnDelTG.ForeColor = System.Drawing.Color.White;
            this.btnDelTG.Location = new System.Drawing.Point(0, 435);
            this.btnDelTG.Margin = new System.Windows.Forms.Padding(0);
            this.btnDelTG.Name = "btnDelTG";
            this.btnDelTG.Size = new System.Drawing.Size(705, 45);
            this.btnDelTG.TabIndex = 50;
            this.btnDelTG.Text = "Удалить выделенный тип товара";
            this.btnDelTG.UseVisualStyleBackColor = false;
            this.btnDelTG.Click += new System.EventHandler(this.btnDelTG_Click);
            // 
            // panel5
            // 
            this.panel5.Controls.Add(this.tbxUnit);
            this.panel5.Controls.Add(label23);
            this.panel5.Controls.Add(this.tbxnameTG);
            this.panel5.Controls.Add(label24);
            this.panel5.Controls.Add(this.btnAddTG);
            this.panel5.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel5.Location = new System.Drawing.Point(0, 0);
            this.panel5.Name = "panel5";
            this.panel5.Size = new System.Drawing.Size(705, 176);
            this.panel5.TabIndex = 0;
            // 
            // tbxUnit
            // 
            this.tbxUnit.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(192)))), ((int)(((byte)(0)))));
            this.tbxUnit.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.tbxUnit.Dock = System.Windows.Forms.DockStyle.Top;
            this.tbxUnit.ForeColor = System.Drawing.Color.White;
            this.tbxUnit.Location = new System.Drawing.Point(0, 96);
            this.tbxUnit.Name = "tbxUnit";
            this.tbxUnit.Size = new System.Drawing.Size(705, 32);
            this.tbxUnit.TabIndex = 173;
            // 
            // tbxnameTG
            // 
            this.tbxnameTG.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(192)))), ((int)(((byte)(0)))));
            this.tbxnameTG.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.tbxnameTG.Dock = System.Windows.Forms.DockStyle.Top;
            this.tbxnameTG.ForeColor = System.Drawing.Color.White;
            this.tbxnameTG.Location = new System.Drawing.Point(0, 32);
            this.tbxnameTG.Name = "tbxnameTG";
            this.tbxnameTG.Size = new System.Drawing.Size(705, 32);
            this.tbxnameTG.TabIndex = 171;
            // 
            // btnAddTG
            // 
            this.btnAddTG.BackColor = System.Drawing.Color.Green;
            this.btnAddTG.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnAddTG.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.btnAddTG.FlatAppearance.BorderSize = 0;
            this.btnAddTG.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnAddTG.Font = new System.Drawing.Font("Segoe UI", 14F, System.Drawing.FontStyle.Bold);
            this.btnAddTG.ForeColor = System.Drawing.Color.White;
            this.btnAddTG.Location = new System.Drawing.Point(0, 131);
            this.btnAddTG.Margin = new System.Windows.Forms.Padding(0);
            this.btnAddTG.Name = "btnAddTG";
            this.btnAddTG.Size = new System.Drawing.Size(705, 45);
            this.btnAddTG.TabIndex = 122;
            this.btnAddTG.Text = "Добавить тип товара";
            this.btnAddTG.UseVisualStyleBackColor = false;
            this.btnAddTG.Click += new System.EventHandler(this.btnAddTG_Click);
            // 
            // tp2
            // 
            this.tp2.Controls.Add(this.panel1);
            this.tp2.Location = new System.Drawing.Point(4, 40);
            this.tp2.Name = "tp2";
            this.tp2.Padding = new System.Windows.Forms.Padding(3);
            this.tp2.Size = new System.Drawing.Size(711, 486);
            this.tp2.TabIndex = 0;
            this.tp2.Text = "Добавить новый товар";
            this.tp2.UseVisualStyleBackColor = true;
            // 
            // panel1
            // 
            this.panel1.Controls.Add(this.dgvGoods);
            this.panel1.Controls.Add(this.btnDel);
            this.panel1.Controls.Add(this.panel2);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panel1.Location = new System.Drawing.Point(3, 3);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(705, 480);
            this.panel1.TabIndex = 73;
            // 
            // dgvGoods
            // 
            this.dgvGoods.AllowUserToAddRows = false;
            this.dgvGoods.AllowUserToDeleteRows = false;
            this.dgvGoods.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.AllCells;
            this.dgvGoods.AutoSizeRowsMode = System.Windows.Forms.DataGridViewAutoSizeRowsMode.AllCells;
            this.dgvGoods.BackgroundColor = System.Drawing.Color.White;
            dataGridViewCellStyle3.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle3.BackColor = System.Drawing.Color.White;
            dataGridViewCellStyle3.Font = new System.Drawing.Font("Segoe UI", 14F, System.Drawing.FontStyle.Bold);
            dataGridViewCellStyle3.ForeColor = System.Drawing.SystemColors.WindowText;
            dataGridViewCellStyle3.SelectionBackColor = System.Drawing.Color.White;
            dataGridViewCellStyle3.SelectionForeColor = System.Drawing.SystemColors.WindowText;
            dataGridViewCellStyle3.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dgvGoods.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle3;
            this.dgvGoods.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvGoods.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.image,
            this.name,
            this.info,
            this.recomend,
            this.contrindic,
            this.count,
            this.dosage,
            this.shelfLife,
            this.storageCond,
            this.manufacture,
            this.price,
            this.stock});
            dataGridViewCellStyle4.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle4.BackColor = System.Drawing.SystemColors.Window;
            dataGridViewCellStyle4.Font = new System.Drawing.Font("Segoe UI", 14F, System.Drawing.FontStyle.Bold);
            dataGridViewCellStyle4.ForeColor = System.Drawing.SystemColors.ControlText;
            dataGridViewCellStyle4.SelectionBackColor = System.Drawing.SystemColors.Window;
            dataGridViewCellStyle4.SelectionForeColor = System.Drawing.SystemColors.ControlText;
            dataGridViewCellStyle4.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dgvGoods.DefaultCellStyle = dataGridViewCellStyle4;
            this.dgvGoods.Dock = System.Windows.Forms.DockStyle.Top;
            this.dgvGoods.Location = new System.Drawing.Point(0, 276);
            this.dgvGoods.Name = "dgvGoods";
            this.dgvGoods.ReadOnly = true;
            this.dgvGoods.RowHeadersWidth = 51;
            this.dgvGoods.RowTemplate.Height = 24;
            this.dgvGoods.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dgvGoods.Size = new System.Drawing.Size(705, 229);
            this.dgvGoods.TabIndex = 51;
            // 
            // image
            // 
            this.image.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.None;
            this.image.FillWeight = 150F;
            this.image.HeaderText = "Фото";
            this.image.ImageLayout = System.Windows.Forms.DataGridViewImageCellLayout.Zoom;
            this.image.MinimumWidth = 150;
            this.image.Name = "image";
            this.image.ReadOnly = true;
            this.image.Width = 150;
            // 
            // name
            // 
            this.name.HeaderText = "Название";
            this.name.MinimumWidth = 6;
            this.name.Name = "name";
            this.name.ReadOnly = true;
            this.name.Width = 156;
            // 
            // info
            // 
            this.info.HeaderText = "Описание";
            this.info.MinimumWidth = 6;
            this.info.Name = "info";
            this.info.ReadOnly = true;
            this.info.Width = 159;
            // 
            // recomend
            // 
            this.recomend.HeaderText = "Рекомендации";
            this.recomend.MinimumWidth = 6;
            this.recomend.Name = "recomend";
            this.recomend.ReadOnly = true;
            this.recomend.Width = 219;
            // 
            // contrindic
            // 
            this.contrindic.HeaderText = "Противопоказания";
            this.contrindic.MinimumWidth = 6;
            this.contrindic.Name = "contrindic";
            this.contrindic.ReadOnly = true;
            this.contrindic.Width = 271;
            // 
            // count
            // 
            this.count.HeaderText = "В упаковке (шт, мл)";
            this.count.MinimumWidth = 6;
            this.count.Name = "count";
            this.count.ReadOnly = true;
            this.count.Width = 214;
            // 
            // dosage
            // 
            this.dosage.HeaderText = "Дозировка";
            this.dosage.MinimumWidth = 6;
            this.dosage.Name = "dosage";
            this.dosage.ReadOnly = true;
            this.dosage.Width = 174;
            // 
            // shelfLife
            // 
            this.shelfLife.HeaderText = "Срок годности";
            this.shelfLife.MinimumWidth = 6;
            this.shelfLife.Name = "shelfLife";
            this.shelfLife.ReadOnly = true;
            this.shelfLife.Width = 197;
            // 
            // storageCond
            // 
            this.storageCond.HeaderText = "Условия хранения";
            this.storageCond.MinimumWidth = 6;
            this.storageCond.Name = "storageCond";
            this.storageCond.ReadOnly = true;
            this.storageCond.Width = 237;
            // 
            // manufacture
            // 
            this.manufacture.HeaderText = "Производитель";
            this.manufacture.MinimumWidth = 6;
            this.manufacture.Name = "manufacture";
            this.manufacture.ReadOnly = true;
            this.manufacture.Width = 228;
            // 
            // price
            // 
            this.price.HeaderText = "Цена";
            this.price.MinimumWidth = 6;
            this.price.Name = "price";
            this.price.ReadOnly = true;
            this.price.Width = 104;
            // 
            // stock
            // 
            this.stock.HeaderText = "На складе";
            this.stock.MinimumWidth = 6;
            this.stock.Name = "stock";
            this.stock.ReadOnly = true;
            this.stock.Width = 147;
            // 
            // btnDel
            // 
            this.btnDel.BackColor = System.Drawing.Color.Green;
            this.btnDel.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnDel.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.btnDel.FlatAppearance.BorderSize = 0;
            this.btnDel.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnDel.Font = new System.Drawing.Font("Segoe UI", 14F, System.Drawing.FontStyle.Bold);
            this.btnDel.ForeColor = System.Drawing.Color.White;
            this.btnDel.Location = new System.Drawing.Point(0, 435);
            this.btnDel.Margin = new System.Windows.Forms.Padding(0);
            this.btnDel.Name = "btnDel";
            this.btnDel.Size = new System.Drawing.Size(705, 45);
            this.btnDel.TabIndex = 50;
            this.btnDel.Text = "Удалить выделенный товар";
            this.btnDel.UseVisualStyleBackColor = false;
            // 
            // panel2
            // 
            this.panel2.Controls.Add(this.panel3);
            this.panel2.Controls.Add(this.btnAdd);
            this.panel2.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel2.Location = new System.Drawing.Point(0, 0);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(705, 276);
            this.panel2.TabIndex = 0;
            // 
            // panel3
            // 
            this.panel3.AutoScroll = true;
            this.panel3.Controls.Add(this.pbImage);
            this.panel3.Controls.Add(this.btnImage);
            this.panel3.Controls.Add(this.cbxTG);
            this.panel3.Controls.Add(nameLabel);
            this.panel3.Controls.Add(this.tbxInfo);
            this.panel3.Controls.Add(label1);
            this.panel3.Controls.Add(this.tbxStock);
            this.panel3.Controls.Add(label11);
            this.panel3.Controls.Add(this.tbxDosage);
            this.panel3.Controls.Add(label10);
            this.panel3.Controls.Add(this.tbxCount);
            this.panel3.Controls.Add(label9);
            this.panel3.Controls.Add(this.tbxPrice);
            this.panel3.Controls.Add(label8);
            this.panel3.Controls.Add(this.tbxManufacture);
            this.panel3.Controls.Add(label7);
            this.panel3.Controls.Add(this.tbxStorageCond);
            this.panel3.Controls.Add(label6);
            this.panel3.Controls.Add(this.tbxShelfLife);
            this.panel3.Controls.Add(label5);
            this.panel3.Controls.Add(this.tbxContrindic);
            this.panel3.Controls.Add(label4);
            this.panel3.Controls.Add(this.tbxRecomend);
            this.panel3.Controls.Add(label3);
            this.panel3.Controls.Add(this.tbxComp);
            this.panel3.Controls.Add(label2);
            this.panel3.Controls.Add(this.tbxName);
            this.panel3.Controls.Add(lblName);
            this.panel3.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panel3.Location = new System.Drawing.Point(0, 0);
            this.panel3.Name = "panel3";
            this.panel3.Size = new System.Drawing.Size(705, 231);
            this.panel3.TabIndex = 123;
            // 
            // pbImage
            // 
            this.pbImage.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.pbImage.Location = new System.Drawing.Point(0, 884);
            this.pbImage.MaximumSize = new System.Drawing.Size(0, 150);
            this.pbImage.MinimumSize = new System.Drawing.Size(150, 150);
            this.pbImage.Name = "pbImage";
            this.pbImage.Size = new System.Drawing.Size(684, 150);
            this.pbImage.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pbImage.TabIndex = 193;
            this.pbImage.TabStop = false;
            // 
            // btnImage
            // 
            this.btnImage.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(192)))), ((int)(((byte)(0)))));
            this.btnImage.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnImage.Dock = System.Windows.Forms.DockStyle.Top;
            this.btnImage.FlatAppearance.BorderSize = 0;
            this.btnImage.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnImage.Font = new System.Drawing.Font("Segoe UI", 14F, System.Drawing.FontStyle.Bold);
            this.btnImage.ForeColor = System.Drawing.Color.White;
            this.btnImage.Location = new System.Drawing.Point(0, 839);
            this.btnImage.Margin = new System.Windows.Forms.Padding(0, 0, 0, 12);
            this.btnImage.Name = "btnImage";
            this.btnImage.Size = new System.Drawing.Size(684, 45);
            this.btnImage.TabIndex = 192;
            this.btnImage.Text = "Загрузить фото";
            this.btnImage.UseVisualStyleBackColor = false;
            this.btnImage.Click += new System.EventHandler(this.btnImage_Click);
            // 
            // cbxTG
            // 
            this.cbxTG.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(192)))), ((int)(((byte)(0)))));
            this.cbxTG.DataBindings.Add(new System.Windows.Forms.Binding("Tag", this.bsTG, "idTG", true));
            this.cbxTG.DataSource = this.bsTG;
            this.cbxTG.DisplayMember = "name";
            this.cbxTG.Dock = System.Windows.Forms.DockStyle.Top;
            this.cbxTG.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cbxTG.ForeColor = System.Drawing.Color.White;
            this.cbxTG.FormattingEnabled = true;
            this.cbxTG.Location = new System.Drawing.Point(0, 800);
            this.cbxTG.Name = "cbxTG";
            this.cbxTG.Size = new System.Drawing.Size(684, 39);
            this.cbxTG.TabIndex = 191;
            this.cbxTG.ValueMember = "idTG";
            // 
            // tbxInfo
            // 
            this.tbxInfo.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(192)))), ((int)(((byte)(0)))));
            this.tbxInfo.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.tbxInfo.Dock = System.Windows.Forms.DockStyle.Top;
            this.tbxInfo.ForeColor = System.Drawing.Color.White;
            this.tbxInfo.Location = new System.Drawing.Point(0, 736);
            this.tbxInfo.Name = "tbxInfo";
            this.tbxInfo.ScrollBars = System.Windows.Forms.ScrollBars.Both;
            this.tbxInfo.Size = new System.Drawing.Size(684, 32);
            this.tbxInfo.TabIndex = 189;
            // 
            // tbxStock
            // 
            this.tbxStock.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(192)))), ((int)(((byte)(0)))));
            this.tbxStock.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.tbxStock.Dock = System.Windows.Forms.DockStyle.Top;
            this.tbxStock.ForeColor = System.Drawing.Color.White;
            this.tbxStock.Location = new System.Drawing.Point(0, 672);
            this.tbxStock.Name = "tbxStock";
            this.tbxStock.ScrollBars = System.Windows.Forms.ScrollBars.Both;
            this.tbxStock.Size = new System.Drawing.Size(684, 32);
            this.tbxStock.TabIndex = 187;
            this.tbxStock.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.Numbers_KeyPress);
            // 
            // tbxDosage
            // 
            this.tbxDosage.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(192)))), ((int)(((byte)(0)))));
            this.tbxDosage.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.tbxDosage.Dock = System.Windows.Forms.DockStyle.Top;
            this.tbxDosage.ForeColor = System.Drawing.Color.White;
            this.tbxDosage.Location = new System.Drawing.Point(0, 608);
            this.tbxDosage.Name = "tbxDosage";
            this.tbxDosage.ScrollBars = System.Windows.Forms.ScrollBars.Both;
            this.tbxDosage.Size = new System.Drawing.Size(684, 32);
            this.tbxDosage.TabIndex = 185;
            this.tbxDosage.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.NumbersWithComma_KeyPress);
            // 
            // tbxCount
            // 
            this.tbxCount.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(192)))), ((int)(((byte)(0)))));
            this.tbxCount.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.tbxCount.Dock = System.Windows.Forms.DockStyle.Top;
            this.tbxCount.ForeColor = System.Drawing.Color.White;
            this.tbxCount.Location = new System.Drawing.Point(0, 544);
            this.tbxCount.Name = "tbxCount";
            this.tbxCount.Size = new System.Drawing.Size(684, 32);
            this.tbxCount.TabIndex = 183;
            this.tbxCount.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.Numbers_KeyPress);
            // 
            // tbxPrice
            // 
            this.tbxPrice.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(192)))), ((int)(((byte)(0)))));
            this.tbxPrice.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.tbxPrice.Dock = System.Windows.Forms.DockStyle.Top;
            this.tbxPrice.ForeColor = System.Drawing.Color.White;
            this.tbxPrice.Location = new System.Drawing.Point(0, 480);
            this.tbxPrice.Name = "tbxPrice";
            this.tbxPrice.Size = new System.Drawing.Size(684, 32);
            this.tbxPrice.TabIndex = 181;
            this.tbxPrice.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.NumbersWithComma_KeyPress);
            // 
            // tbxManufacture
            // 
            this.tbxManufacture.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(192)))), ((int)(((byte)(0)))));
            this.tbxManufacture.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.tbxManufacture.Dock = System.Windows.Forms.DockStyle.Top;
            this.tbxManufacture.ForeColor = System.Drawing.Color.White;
            this.tbxManufacture.Location = new System.Drawing.Point(0, 416);
            this.tbxManufacture.Name = "tbxManufacture";
            this.tbxManufacture.Size = new System.Drawing.Size(684, 32);
            this.tbxManufacture.TabIndex = 179;
            // 
            // tbxStorageCond
            // 
            this.tbxStorageCond.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(192)))), ((int)(((byte)(0)))));
            this.tbxStorageCond.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.tbxStorageCond.Dock = System.Windows.Forms.DockStyle.Top;
            this.tbxStorageCond.ForeColor = System.Drawing.Color.White;
            this.tbxStorageCond.Location = new System.Drawing.Point(0, 352);
            this.tbxStorageCond.Name = "tbxStorageCond";
            this.tbxStorageCond.Size = new System.Drawing.Size(684, 32);
            this.tbxStorageCond.TabIndex = 177;
            // 
            // tbxShelfLife
            // 
            this.tbxShelfLife.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(192)))), ((int)(((byte)(0)))));
            this.tbxShelfLife.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.tbxShelfLife.Dock = System.Windows.Forms.DockStyle.Top;
            this.tbxShelfLife.ForeColor = System.Drawing.Color.White;
            this.tbxShelfLife.Location = new System.Drawing.Point(0, 288);
            this.tbxShelfLife.Name = "tbxShelfLife";
            this.tbxShelfLife.Size = new System.Drawing.Size(684, 32);
            this.tbxShelfLife.TabIndex = 175;
            this.tbxShelfLife.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.Numbers_KeyPress);
            // 
            // tbxContrindic
            // 
            this.tbxContrindic.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(192)))), ((int)(((byte)(0)))));
            this.tbxContrindic.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.tbxContrindic.Dock = System.Windows.Forms.DockStyle.Top;
            this.tbxContrindic.ForeColor = System.Drawing.Color.White;
            this.tbxContrindic.Location = new System.Drawing.Point(0, 224);
            this.tbxContrindic.Name = "tbxContrindic";
            this.tbxContrindic.Size = new System.Drawing.Size(684, 32);
            this.tbxContrindic.TabIndex = 173;
            // 
            // tbxRecomend
            // 
            this.tbxRecomend.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(192)))), ((int)(((byte)(0)))));
            this.tbxRecomend.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.tbxRecomend.Dock = System.Windows.Forms.DockStyle.Top;
            this.tbxRecomend.ForeColor = System.Drawing.Color.White;
            this.tbxRecomend.Location = new System.Drawing.Point(0, 160);
            this.tbxRecomend.Name = "tbxRecomend";
            this.tbxRecomend.Size = new System.Drawing.Size(684, 32);
            this.tbxRecomend.TabIndex = 171;
            // 
            // tbxComp
            // 
            this.tbxComp.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(192)))), ((int)(((byte)(0)))));
            this.tbxComp.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.tbxComp.Dock = System.Windows.Forms.DockStyle.Top;
            this.tbxComp.ForeColor = System.Drawing.Color.White;
            this.tbxComp.Location = new System.Drawing.Point(0, 96);
            this.tbxComp.Name = "tbxComp";
            this.tbxComp.Size = new System.Drawing.Size(684, 32);
            this.tbxComp.TabIndex = 169;
            // 
            // tbxName
            // 
            this.tbxName.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(192)))), ((int)(((byte)(0)))));
            this.tbxName.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.tbxName.Dock = System.Windows.Forms.DockStyle.Top;
            this.tbxName.ForeColor = System.Drawing.Color.White;
            this.tbxName.Location = new System.Drawing.Point(0, 32);
            this.tbxName.Name = "tbxName";
            this.tbxName.Size = new System.Drawing.Size(684, 32);
            this.tbxName.TabIndex = 167;
            // 
            // btnAdd
            // 
            this.btnAdd.BackColor = System.Drawing.Color.Green;
            this.btnAdd.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnAdd.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.btnAdd.FlatAppearance.BorderSize = 0;
            this.btnAdd.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnAdd.Font = new System.Drawing.Font("Segoe UI", 14F, System.Drawing.FontStyle.Bold);
            this.btnAdd.ForeColor = System.Drawing.Color.White;
            this.btnAdd.Location = new System.Drawing.Point(0, 231);
            this.btnAdd.Margin = new System.Windows.Forms.Padding(0);
            this.btnAdd.Name = "btnAdd";
            this.btnAdd.Size = new System.Drawing.Size(705, 45);
            this.btnAdd.TabIndex = 122;
            this.btnAdd.Text = "Добавить товар";
            this.btnAdd.UseVisualStyleBackColor = false;
            this.btnAdd.Click += new System.EventHandler(this.btnAdd_Click);
            // 
            // tp1
            // 
            this.tp1.Controls.Add(this.pAddExG);
            this.tp1.Location = new System.Drawing.Point(4, 40);
            this.tp1.Name = "tp1";
            this.tp1.Padding = new System.Windows.Forms.Padding(3);
            this.tp1.Size = new System.Drawing.Size(711, 486);
            this.tp1.TabIndex = 1;
            this.tp1.Text = "Добавить существующий товар";
            this.tp1.UseVisualStyleBackColor = true;
            // 
            // pAddExG
            // 
            this.pAddExG.Controls.Add(this.dgvExGoods);
            this.pAddExG.Controls.Add(this.btnDelEG);
            this.pAddExG.Controls.Add(this.panel7);
            this.pAddExG.Dock = System.Windows.Forms.DockStyle.Fill;
            this.pAddExG.Location = new System.Drawing.Point(3, 3);
            this.pAddExG.Name = "pAddExG";
            this.pAddExG.Size = new System.Drawing.Size(705, 480);
            this.pAddExG.TabIndex = 77;
            // 
            // dgvExGoods
            // 
            this.dgvExGoods.AllowUserToAddRows = false;
            this.dgvExGoods.AllowUserToDeleteRows = false;
            this.dgvExGoods.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.AllCells;
            this.dgvExGoods.AutoSizeRowsMode = System.Windows.Forms.DataGridViewAutoSizeRowsMode.AllCells;
            this.dgvExGoods.BackgroundColor = System.Drawing.Color.White;
            dataGridViewCellStyle5.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle5.BackColor = System.Drawing.Color.White;
            dataGridViewCellStyle5.Font = new System.Drawing.Font("Segoe UI", 14F, System.Drawing.FontStyle.Bold);
            dataGridViewCellStyle5.ForeColor = System.Drawing.SystemColors.WindowText;
            dataGridViewCellStyle5.SelectionBackColor = System.Drawing.Color.White;
            dataGridViewCellStyle5.SelectionForeColor = System.Drawing.SystemColors.WindowText;
            dataGridViewCellStyle5.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dgvExGoods.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle5;
            this.dgvExGoods.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvExGoods.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.dataGridViewTextBoxColumn3,
            this.dataGridViewTextBoxColumn4,
            this.id});
            dataGridViewCellStyle6.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle6.BackColor = System.Drawing.SystemColors.Window;
            dataGridViewCellStyle6.Font = new System.Drawing.Font("Segoe UI", 14F, System.Drawing.FontStyle.Bold);
            dataGridViewCellStyle6.ForeColor = System.Drawing.SystemColors.ControlText;
            dataGridViewCellStyle6.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(192)))), ((int)(((byte)(0)))));
            dataGridViewCellStyle6.SelectionForeColor = System.Drawing.Color.White;
            dataGridViewCellStyle6.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dgvExGoods.DefaultCellStyle = dataGridViewCellStyle6;
            this.dgvExGoods.Dock = System.Windows.Forms.DockStyle.Fill;
            this.dgvExGoods.Location = new System.Drawing.Point(0, 183);
            this.dgvExGoods.Name = "dgvExGoods";
            this.dgvExGoods.ReadOnly = true;
            this.dgvExGoods.RowHeadersWidth = 51;
            this.dgvExGoods.RowTemplate.Height = 24;
            this.dgvExGoods.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dgvExGoods.Size = new System.Drawing.Size(705, 252);
            this.dgvExGoods.TabIndex = 51;
            // 
            // dataGridViewTextBoxColumn3
            // 
            this.dataGridViewTextBoxColumn3.HeaderText = "Название";
            this.dataGridViewTextBoxColumn3.MinimumWidth = 6;
            this.dataGridViewTextBoxColumn3.Name = "dataGridViewTextBoxColumn3";
            this.dataGridViewTextBoxColumn3.ReadOnly = true;
            this.dataGridViewTextBoxColumn3.Width = 156;
            // 
            // dataGridViewTextBoxColumn4
            // 
            this.dataGridViewTextBoxColumn4.HeaderText = "Кол-во";
            this.dataGridViewTextBoxColumn4.MinimumWidth = 6;
            this.dataGridViewTextBoxColumn4.Name = "dataGridViewTextBoxColumn4";
            this.dataGridViewTextBoxColumn4.ReadOnly = true;
            this.dataGridViewTextBoxColumn4.Width = 127;
            // 
            // id
            // 
            this.id.HeaderText = "id";
            this.id.MinimumWidth = 6;
            this.id.Name = "id";
            this.id.ReadOnly = true;
            this.id.Visible = false;
            this.id.Width = 66;
            // 
            // btnDelEG
            // 
            this.btnDelEG.BackColor = System.Drawing.Color.Green;
            this.btnDelEG.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnDelEG.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.btnDelEG.FlatAppearance.BorderSize = 0;
            this.btnDelEG.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnDelEG.Font = new System.Drawing.Font("Segoe UI", 14F, System.Drawing.FontStyle.Bold);
            this.btnDelEG.ForeColor = System.Drawing.Color.White;
            this.btnDelEG.Location = new System.Drawing.Point(0, 435);
            this.btnDelEG.Margin = new System.Windows.Forms.Padding(0);
            this.btnDelEG.Name = "btnDelEG";
            this.btnDelEG.Size = new System.Drawing.Size(705, 45);
            this.btnDelEG.TabIndex = 50;
            this.btnDelEG.Text = "Удалить выделенный товар";
            this.btnDelEG.UseVisualStyleBackColor = false;
            this.btnDelEG.Click += new System.EventHandler(this.btnDelEG_Click);
            // 
            // panel7
            // 
            this.panel7.Controls.Add(this.tbxCountExGoods);
            this.panel7.Controls.Add(label12);
            this.panel7.Controls.Add(this.cbxExGoods);
            this.panel7.Controls.Add(label13);
            this.panel7.Controls.Add(this.btnAddEG);
            this.panel7.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel7.Location = new System.Drawing.Point(0, 0);
            this.panel7.Name = "panel7";
            this.panel7.Size = new System.Drawing.Size(705, 183);
            this.panel7.TabIndex = 0;
            // 
            // tbxCountExGoods
            // 
            this.tbxCountExGoods.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(192)))), ((int)(((byte)(0)))));
            this.tbxCountExGoods.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.tbxCountExGoods.Dock = System.Windows.Forms.DockStyle.Top;
            this.tbxCountExGoods.ForeColor = System.Drawing.Color.White;
            this.tbxCountExGoods.Location = new System.Drawing.Point(0, 103);
            this.tbxCountExGoods.Name = "tbxCountExGoods";
            this.tbxCountExGoods.Size = new System.Drawing.Size(705, 32);
            this.tbxCountExGoods.TabIndex = 194;
            this.tbxCountExGoods.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.Numbers_KeyPress);
            // 
            // cbxExGoods
            // 
            this.cbxExGoods.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(192)))), ((int)(((byte)(0)))));
            this.cbxExGoods.DataBindings.Add(new System.Windows.Forms.Binding("Tag", this.bsTG, "idTG", true));
            this.cbxExGoods.DataSource = this.bsGoods;
            this.cbxExGoods.DisplayMember = "name";
            this.cbxExGoods.Dock = System.Windows.Forms.DockStyle.Top;
            this.cbxExGoods.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cbxExGoods.ForeColor = System.Drawing.Color.White;
            this.cbxExGoods.FormattingEnabled = true;
            this.cbxExGoods.Location = new System.Drawing.Point(0, 32);
            this.cbxExGoods.Name = "cbxExGoods";
            this.cbxExGoods.Size = new System.Drawing.Size(705, 39);
            this.cbxExGoods.TabIndex = 192;
            this.cbxExGoods.ValueMember = "idG";
            // 
            // btnAddEG
            // 
            this.btnAddEG.BackColor = System.Drawing.Color.Green;
            this.btnAddEG.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnAddEG.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.btnAddEG.FlatAppearance.BorderSize = 0;
            this.btnAddEG.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnAddEG.Font = new System.Drawing.Font("Segoe UI", 14F, System.Drawing.FontStyle.Bold);
            this.btnAddEG.ForeColor = System.Drawing.Color.White;
            this.btnAddEG.Location = new System.Drawing.Point(0, 138);
            this.btnAddEG.Margin = new System.Windows.Forms.Padding(0);
            this.btnAddEG.Name = "btnAddEG";
            this.btnAddEG.Size = new System.Drawing.Size(705, 45);
            this.btnAddEG.TabIndex = 122;
            this.btnAddEG.Text = "Добавить товар";
            this.btnAddEG.UseVisualStyleBackColor = false;
            this.btnAddEG.Click += new System.EventHandler(this.btnAddEG_Click);
            // 
            // tabControl1
            // 
            this.tabControl1.Controls.Add(this.tp1);
            this.tabControl1.Controls.Add(this.tp2);
            this.tabControl1.Controls.Add(this.tp3);
            this.tabControl1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tabControl1.Location = new System.Drawing.Point(25, 25);
            this.tabControl1.Name = "tabControl1";
            this.tabControl1.SelectedIndex = 0;
            this.tabControl1.Size = new System.Drawing.Size(719, 530);
            this.tabControl1.TabIndex = 76;
            // 
            // discountTextBox
            // 
            this.discountTextBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.bsGoods, "discount", true));
            this.discountTextBox.Location = new System.Drawing.Point(132, 380);
            this.discountTextBox.Name = "discountTextBox";
            this.discountTextBox.Size = new System.Drawing.Size(100, 39);
            this.discountTextBox.TabIndex = 77;
            // 
            // stockTextBox
            // 
            this.stockTextBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.bsGoods, "stock", true));
            this.stockTextBox.Location = new System.Drawing.Point(334, 306);
            this.stockTextBox.Name = "stockTextBox";
            this.stockTextBox.Size = new System.Drawing.Size(100, 39);
            this.stockTextBox.TabIndex = 195;
            // 
            // idTGTextBox
            // 
            this.idTGTextBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.bsGoods, "idTG", true));
            this.idTGTextBox.Location = new System.Drawing.Point(342, 314);
            this.idTGTextBox.Name = "idTGTextBox";
            this.idTGTextBox.Size = new System.Drawing.Size(100, 39);
            this.idTGTextBox.TabIndex = 196;
            // 
            // AddGoods
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(14F, 31F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.AutoScroll = true;
            this.BackColor = System.Drawing.Color.White;
            this.ClientSize = new System.Drawing.Size(769, 650);
            this.Controls.Add(this.tabControl1);
            this.Controls.Add(this.imagePictureBox);
            this.Controls.Add(this.btnAccept);
            this.Controls.Add(this.unitTextBox);
            this.Controls.Add(this.nameTGTextBox);
            this.Controls.Add(this.priceTextBox);
            this.Controls.Add(this.manufactureTextBox);
            this.Controls.Add(this.storageCondTextBox);
            this.Controls.Add(this.shelfLifeTextBox);
            this.Controls.Add(this.dosageTextBox);
            this.Controls.Add(this.countTextBox);
            this.Controls.Add(this.contrindicTextBox);
            this.Controls.Add(this.recomendTextBox);
            this.Controls.Add(this.compTextBox);
            this.Controls.Add(this.infoTextBox);
            this.Controls.Add(this.nameTextBox);
            this.Controls.Add(this.pbClose);
            this.Controls.Add(this.discountTextBox);
            this.Controls.Add(this.stockTextBox);
            this.Controls.Add(this.idTGTextBox);
            this.Font = new System.Drawing.Font("Segoe UI", 14F, System.Drawing.FontStyle.Bold);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Margin = new System.Windows.Forms.Padding(5, 6, 5, 6);
            this.Name = "AddGoods";
            this.Padding = new System.Windows.Forms.Padding(25);
            this.Text = "AddG";
            this.Load += new System.EventHandler(this.AddG_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dsApteka)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.bsGoods)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.bsTG)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pbClose)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.imagePictureBox)).EndInit();
            this.tp3.ResumeLayout(false);
            this.panel4.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dgvTG)).EndInit();
            this.panel5.ResumeLayout(false);
            this.panel5.PerformLayout();
            this.tp2.ResumeLayout(false);
            this.panel1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dgvGoods)).EndInit();
            this.panel2.ResumeLayout(false);
            this.panel3.ResumeLayout(false);
            this.panel3.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pbImage)).EndInit();
            this.tp1.ResumeLayout(false);
            this.pAddExG.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dgvExGoods)).EndInit();
            this.panel7.ResumeLayout(false);
            this.panel7.PerformLayout();
            this.tabControl1.ResumeLayout(false);
            this.ResumeLayout(false);
            this.PerformLayout();

		}

		#endregion
		private dsApteka dsApteka;
		private System.Windows.Forms.BindingSource bsGoods;
		private dsAptekaTableAdapters.GoodsTableAdapter goodsTableAdapter;
		private dsAptekaTableAdapters.TableAdapterManager tableAdapterManager;
		private System.Windows.Forms.TextBox nameTextBox;
		private System.Windows.Forms.TextBox infoTextBox;
		private System.Windows.Forms.TextBox compTextBox;
		private System.Windows.Forms.TextBox recomendTextBox;
		private System.Windows.Forms.TextBox contrindicTextBox;
		private System.Windows.Forms.TextBox countTextBox;
		private System.Windows.Forms.TextBox dosageTextBox;
		private System.Windows.Forms.TextBox shelfLifeTextBox;
		private System.Windows.Forms.TextBox storageCondTextBox;
		private System.Windows.Forms.TextBox manufactureTextBox;
		private System.Windows.Forms.TextBox priceTextBox;
		private dsAptekaTableAdapters.TGTableAdapter tGTableAdapter;
		private System.Windows.Forms.BindingSource bsTG;
		private System.Windows.Forms.OpenFileDialog openFileDialog1;
		private System.Windows.Forms.PictureBox pbClose;
		private System.Windows.Forms.TextBox nameTGTextBox;
		private System.Windows.Forms.TextBox unitTextBox;
		private System.Windows.Forms.PictureBox imagePictureBox;
		public System.Windows.Forms.Button btnAccept;
		private System.Windows.Forms.TabPage tp3;
		private System.Windows.Forms.Panel panel4;
		private System.Windows.Forms.DataGridView dgvTG;
		private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn1;
		private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn2;
		public System.Windows.Forms.Button btnDelTG;
		private System.Windows.Forms.Panel panel5;
		private System.Windows.Forms.TextBox tbxUnit;
		private System.Windows.Forms.TextBox tbxnameTG;
		public System.Windows.Forms.Button btnAddTG;
		private System.Windows.Forms.TabPage tp2;
		private System.Windows.Forms.Panel panel1;
		private System.Windows.Forms.DataGridView dgvGoods;
		public System.Windows.Forms.Button btnDel;
		private System.Windows.Forms.Panel panel2;
		private System.Windows.Forms.Panel panel3;
		private System.Windows.Forms.PictureBox pbImage;
		public System.Windows.Forms.Button btnImage;
		private System.Windows.Forms.ComboBox cbxTG;
		private System.Windows.Forms.TextBox tbxInfo;
		private System.Windows.Forms.TextBox tbxStock;
		private System.Windows.Forms.TextBox tbxDosage;
		private System.Windows.Forms.TextBox tbxCount;
		private System.Windows.Forms.TextBox tbxPrice;
		private System.Windows.Forms.TextBox tbxManufacture;
		private System.Windows.Forms.TextBox tbxStorageCond;
		private System.Windows.Forms.TextBox tbxShelfLife;
		private System.Windows.Forms.TextBox tbxContrindic;
		private System.Windows.Forms.TextBox tbxRecomend;
		private System.Windows.Forms.TextBox tbxComp;
		private System.Windows.Forms.TextBox tbxName;
		public System.Windows.Forms.Button btnAdd;
		private System.Windows.Forms.TabPage tp1;
		private System.Windows.Forms.Panel pAddExG;
		private System.Windows.Forms.DataGridView dgvExGoods;
		private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn3;
		private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn4;
		private System.Windows.Forms.DataGridViewTextBoxColumn id;
		public System.Windows.Forms.Button btnDelEG;
		private System.Windows.Forms.Panel panel7;
		private System.Windows.Forms.TextBox tbxCountExGoods;
		private System.Windows.Forms.ComboBox cbxExGoods;
		public System.Windows.Forms.Button btnAddEG;
		private System.Windows.Forms.TabControl tabControl1;
		private System.Windows.Forms.TextBox discountTextBox;
		private System.Windows.Forms.TextBox stockTextBox;
		private System.Windows.Forms.TextBox idTGTextBox;
		private System.Windows.Forms.DataGridViewImageColumn image;
		private System.Windows.Forms.DataGridViewTextBoxColumn name;
		private System.Windows.Forms.DataGridViewTextBoxColumn info;
		private System.Windows.Forms.DataGridViewTextBoxColumn recomend;
		private System.Windows.Forms.DataGridViewTextBoxColumn contrindic;
		private System.Windows.Forms.DataGridViewTextBoxColumn count;
		private System.Windows.Forms.DataGridViewTextBoxColumn dosage;
		private System.Windows.Forms.DataGridViewTextBoxColumn shelfLife;
		private System.Windows.Forms.DataGridViewTextBoxColumn storageCond;
		private System.Windows.Forms.DataGridViewTextBoxColumn manufacture;
		private System.Windows.Forms.DataGridViewTextBoxColumn price;
		private System.Windows.Forms.DataGridViewTextBoxColumn stock;
	}
}