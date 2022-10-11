using dllCheck;
using System;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.IO;
using System.Windows.Forms;

namespace Apteka
{
	public partial class Dashboard : Form
	{
		public static bool isSearch = true;
		public static Goods[] masTovar, masTS;
		public static string bsFilter = "";
		public static User user = new User();
		public static SqlConnection con = new SqlConnection(@"Data Source=(LocalDB)\MSSQLLocalDB;AttachDbFilename=|DataDirectory|\Apteka.mdf;Integrated Security=True;Connect Timeout=30");
		private Form activeForm = null;

		public struct User
		{
			public int type;
			public string lName, name, mName, indexs, city, street, phone, login, password, email;
			public DateTime bDay;
			public int id, home, flat;
		}

		public struct Goods
		{
			public int id, count, stock, shelfLife, discount, idVT;
			public double price, itogprice;
			public string name, info, comp, recomend, contrindic, storageCond, dosage, manufacture;
			public Image image;
		}

		public void openChildForm(Form childForm)
		{
			isSearch = false;
			if (activeForm != null) activeForm.Close();
			activeForm = childForm;
			activeForm.Owner = this;
			childForm.TopLevel = false;
			childForm.FormBorderStyle = FormBorderStyle.None;
			childForm.Dock = DockStyle.Fill;
			panelChildForm.Controls.Add(childForm);
			panelChildForm.Tag = childForm;
			childForm.BringToFront();
			childForm.Show();
		}

		public void Fill()
		{
			this.goodsTableAdapter.Fill(this.dsApteka.Goods);
			this.userTableAdapter.Fill(this.dsApteka.User);
			FM(ref masTovar);
			FL(masTovar, panelChildForm);
		}

		public Dashboard()
		{
			InitializeComponent();
			user.id = -1;
			this.goodsTableAdapter.Fill(this.dsApteka.Goods);
			this.userTableAdapter.Fill(this.dsApteka.User);
			check();
			Fill();
		}

		void check()
		{
			if (bsFilter == "")
			{
				pbUser.Image = Properties.Resources.user;
				pAdm.Visible = false;
				pExit.Visible = false;
				pAdm.Visible = false;
				pAdd.Visible = false;
				pDis.Visible = false;
				pUsers.Visible = false;
				ttInfo.SetToolTip(pbUser, "Вход или регистрация");
				pbBasket.Enabled = false;
				pbOrder.Enabled = false;
				pbFavorite.Enabled = false;
				pbBasket.Image = Properties.Resources.basketOff;
				pbOrder.Image = Properties.Resources.boxOff;
				pbFavorite.Image = Properties.Resources.favoriteOff;
			}
			else
			{
				pExit.Visible = true;
				this.userTableAdapter.Fill(this.dsApteka.User);
				Basket frm = new Basket();
				DataRowView t = (DataRowView)bsUser[0];
				user.id = (int)t[0];
				user.lName = t[1].ToString();
				user.name = t[2].ToString();
				user.mName = t[3].ToString();
				user.bDay = (DateTime)t[4];
				user.indexs = t[5].ToString();
				user.city = t[6].ToString();
				user.street = t[7].ToString();
				user.home = (int)t[8];
				user.flat = (int)t[9];
				user.phone = t[10].ToString();
				user.login = t[11].ToString();
				user.password = t[12].ToString();
				user.email = t[13].ToString();
				user.type = (int)t[14];
				if (user.type == 0)
				{
					pAdm.Visible = true;
					pAdd.Visible = true;
					pDis.Visible = true;
					pUsers.Visible = true;
				}
				else
				if (user.type == 1)
				{
					pAdm.Visible = true;
				}
				else
					if (user.type == 2)
				{
					pAdd.Visible = true;
					pDis.Visible = true;
				}
				pbBasket.Enabled = true;
				pbOrder.Enabled = true;
				pbFavorite.Enabled = true;
				pbBasket.Image = Properties.Resources.basket;
				pbOrder.Image = Properties.Resources.box;
				pbFavorite.Image = Properties.Resources.favorite;
				ttInfo.SetToolTip(pbUser, "Изменить профиль");
				pbUser.Image = Properties.Resources.userSet;
			}
		}

		private void mainForm_MdiChildActivate(object sender, EventArgs e)
		{
			check();
		}

		private void pbUser_Click(object sender, EventArgs e)
		{
			if (bsFilter == "")
			{
				Autorization frm = new Autorization();
				frm.Owner = this;
				if (frm.ShowDialog() == DialogResult.OK)
				{
					bsUser.Filter = bsFilter;
					check();
					if (activeForm != null)
					{
						activeForm.Close();
						activeForm = null;
					}
				}
			}
			else openChildForm(new Registration());
		}

		private void mainForm_FormClosing(object sender, FormClosingEventArgs e)
		{
			bsFilter = "";
			user.id = -1;
		}

		private void pbOrder_Click(object sender, EventArgs e)
		{
			openChildForm(new Orders());
		}

		private void pbAdm_Click(object sender, EventArgs e)
		{
			openChildForm(new OrdersAdm());
		}

		private void pbBasket_Click(object sender, EventArgs e)
		{
			openChildForm(new Basket());
		}

		private void pbFavorite_Click(object sender, EventArgs e)
		{
			openChildForm(new Favorite());
		}

		private void pbExit_Click(object sender, EventArgs e)
		{
			if (activeForm != null) activeForm.Close();
			user.id = -1;
			bsFilter = "";
			check();
		}

		//поиск
		private void info_Click(object sender, EventArgs e)
		{
			Info.id = (Convert.ToInt32((sender as PictureBox).Name.ToString().Remove(0, 2))) + 1;
			openChildForm(new Info());
		}

		//заполнение массива
		void FM(ref Goods[] masTovar)
		{
			if (0 >= bsGoods.Count) return;
			masTovar = new Goods[bsGoods.Count];

			for (int i = 0; i < bsGoods.Count; i++)
			{
				DataRowView t = (DataRowView)bsGoods[i];
				masTovar[i].id = (int)t[0];
				masTovar[i].name = t[1].ToString();
				masTovar[i].info = t[2].ToString();
				masTovar[i].comp = t[3].ToString();
				masTovar[i].recomend = t[4].ToString();
				masTovar[i].contrindic = t[5].ToString();
				masTovar[i].count = (int)t[6];
				masTovar[i].dosage = t[7].ToString();
				masTovar[i].shelfLife = (int)t[8];
				masTovar[i].storageCond = t[9].ToString();
				masTovar[i].manufacture = t[10].ToString();
				masTovar[i].price = Convert.ToDouble(t[11]);
				masTovar[i].discount = (int)t[12];
				masTovar[i].itogprice = Convert.ToDouble(t[13]);
				try
				{
					MemoryStream ms = new MemoryStream((byte[])t[14]);
					masTovar[i].image = Image.FromStream(ms);
				}
				catch
				{
					masTovar[i].image = Properties.Resources.error;
				}
				masTovar[i].stock = (int)t[15];
				masTovar[i].idVT = (int)t[16];
			}
		}
		//заполнение формы
		public void FL(Goods[] masTovar, Panel panelChildForm)
		{
			panelChildForm.Controls.Clear();
			PictureBox[] masPB = new PictureBox[masTovar.Length];
			Label[] lab = new Label[masTovar.Length];

			int x = 25, y = 25, dx = x, dy = y, a = 0, width = 150;

			for (int i = 0; i < masTovar.Length; i++)
			{
				if (dx + 25 + width > panelChildForm.Width)
				{
					y = y + a;
					dy = y;
					dx = x;
				}
				//создаем PictureBox с i-товаром
				masPB[i] = new PictureBox();
				masPB[i].SizeMode = PictureBoxSizeMode.Zoom;
				masPB[i].Name = "pb" + (masTovar[i].id - 1).ToString();
				masPB[i].Image = masTovar[i].image;
				masPB[i].Width = width;
				masPB[i].Height = 150;
				masPB[i].Cursor = Cursors.Hand;
				masPB[i].Left = dx;
				masPB[i].Top = dy;
				masPB[i].Click += new EventHandler(info_Click);
				panelChildForm.Controls.Add(masPB[i]);
				panelChildForm.Controls.SetChildIndex(masPB[i], 0);
				//создаем Label с i-товаром
				lab[i] = new Label();
				lab[i].AutoSize = false;
				masPB[i].Tag = masTovar[i].id;
				lab[i].Text = masTovar[i].name;
				lab[i].MaximumSize = new Size(150, 0);
				lab[i].AutoSize = true;
				lab[i].Left = dx;
				lab[i].Top = dy + masPB[i].Height;
				panelChildForm.Controls.Add(lab[i]);
				panelChildForm.Controls.SetChildIndex(lab[i], 0);

				dx = dx + masPB[i].Width + 25;
				a = masPB[i].Height + lab[i].Height + 25;
			}
		}

		private void pbSearch_Click(object sender, EventArgs e)
		{
			if (tbxSearch.Text != "")
			{
				bsGoods.Filter = "";
				FM(ref masTovar);
				bsGoods.Filter = "name like '%" + tbxSearch.Text + "%'";
			}
			else bsGoods.Filter = "";
			if (bsGoods.Count > 0)
			{
				Fill();
			}
		}

		private void tbxSearch_TextChanged(object sender, EventArgs e)
		{
			pbSearch_Click(sender, e);
			if (tbxSearch.Text == string.Empty)
			{
				bsGoods.Filter = "";
				Fill();
			}
		}

		private void Dashboard_Resize(object sender, EventArgs e)
		{
			if (isSearch) Fill();
		}

		private void pbAdd_Click(object sender, EventArgs e)
		{
			openChildForm(new AddGoods());
		}

		private void pbDis_Click(object sender, EventArgs e)
		{
			openChildForm(new DisGoods());
		}

		private void pbUsers_Click(object sender, EventArgs e)
		{
			openChildForm(new UsersAdm());
		}

		private void panelChildForm_Resize(object sender, EventArgs e)
		{
			Fill();
		}

		private void tbxSearch_KeyPress(object sender, KeyPressEventArgs e)
		{
			if (Check.Letters(e.KeyChar)) e.Handled = true;
		}

	}
}
