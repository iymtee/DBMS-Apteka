using System;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Windows.Forms;

namespace Apteka
{
	public partial class Info : Form
	{
		public static int id = -1;
		string q;
		SqlConnection con = Dashboard.con;
		SqlCommand sqlCom;

		public Info()
		{
			InitializeComponent();
			check();
		}

		private void pbClose_Click(object sender, EventArgs e)
		{
			id = -1;
			Dashboard.isSearch = true;
			this.Close();
		}

		private void pbFavorite_Click(object sender, EventArgs e)
		{
			if (Convert.ToInt32(pbFavorite.Tag) == 0)
			{
				con.Open();
				q = "INSERT INTO [favorite] (idG,idU) VALUES (" + (id) + "," + Dashboard.user.id + ")";
				sqlCom = new SqlCommand(q, con);
				try
				{
					sqlCom.ExecuteNonQuery();
					pbFavorite.Tag = 1;
					pbFavorite.Image = Properties.Resources.favoriteAct;
				}
				catch (Exception ex)
				{
					pbFavorite.Image = Properties.Resources.favorite;
					pbFavorite.Tag = 0;
					MessageBox.Show(ex.Message);
				}
				con.Close();
			}
			else
			{
				con.Open();
				q = "delete from [favorite] where idG = " + (id) + "and idU = " + Dashboard.user.id;
				sqlCom = new SqlCommand(q, con);
				try
				{
					pbFavorite.Image = Properties.Resources.favorite;
					sqlCom.ExecuteNonQuery();
					pbFavorite.Tag = 0;
				}
				catch (Exception ex)
				{
					pbFavorite.Tag = 1;
					pbFavorite.Image = Properties.Resources.favoriteAct;
					MessageBox.Show(ex.Message);
				}
				con.Close();
			}
		}

		private void btnAdd_Click(object sender, EventArgs e)
		{
			if (bsBasket.Count == 0)
			{
				q = "insert into [basket](idU,idG,count) values(" + Dashboard.user.id + "," + (id) + ", 1)";
			}
			if (bsBasket.Count > 0)
			{
				DataRowView t = (DataRowView)bsBasket[0];
				if ((int)t[1] == Dashboard.user.id && (int)t[2] == (id))
				{
					q = "UPDATE [basket] set count =" + ((int)t[3] +1)+ " where idB =" + (int)t[0];
				}
			}
			con.Open();
			sqlCom = new SqlCommand(q, con);
			try
			{
				sqlCom.ExecuteNonQuery();
			}
			catch (Exception ex)
			{
				MessageBox.Show(ex.Message);
			}
			con.Close();
			check();
		}

		private void Info_Load(object sender, EventArgs e)
		{
			pbImage.Image = Dashboard.masTovar[id-1].image;
			lblName.Text = Dashboard.masTovar[id - 1].name;
			lblPrice.Text = Dashboard.masTovar[id - 1].itogprice.ToString() + "₽";
			if (Dashboard.masTovar[Info.id - 1].itogprice != Dashboard.masTovar[id - 1].price)
				lblOldPrice.Text = Dashboard.masTovar[id - 1].price.ToString() + "₽";
			lblInfo.Text = Dashboard.masTovar[id - 1].info;
			if (Dashboard.user.id != -1)
				bsBasket.Filter = "idG = '" + (id) + "' and " + "idU = '" + Dashboard.user.id + "'";
		}


		public void check()
		{
			this.basketTableAdapter.Fill(this.dsApteka.Basket);
			this.favoriteTableAdapter.Fill(this.dsApteka.Favorite);
			this.goodsTableAdapter.Fill(this.dsApteka.Goods);

			if (Dashboard.user.id == -1)
			{
				btnAdd.Enabled = false;
				pbFavorite.Enabled = false;
				pbFavorite.Tag = 2;
				pbFavorite.Image = Properties.Resources.favoriteOff;
				return;
			}

			else
			{
				btnAdd.Enabled = true;
				pbFavorite.Enabled = true;
				for (int i = 0; i < bsFavorite.Count; i++)
				{
					DataRowView t = (DataRowView)bsFavorite[i];
					if ((int)t[1] == (id) && Dashboard.user.id == (int)t[2])
					{
						pbFavorite.Image = Properties.Resources.favoriteAct;
						pbFavorite.Tag = 1;
						break;
					}
					else
					{
						pbFavorite.Tag = 0;
						pbFavorite.Image = Properties.Resources.favorite;
					}
				}


				if (bsBasket.Count > 0)
				{
					for (int i = 0; i < bsBasket.Count; i++)
					{
						DataRowView t = (DataRowView)bsBasket[i];
						if ((int)t["idG"] == (id))
							if ((int)t["count"] > 0)
							{
								btnAdd.Text = "+1";
								btnAdd.TextAlign = ContentAlignment.MiddleRight;
								btnGTB.Visible = true;
								btnGTB.Width = (int)(btnAdd.Width * 0.90);
								btnGTB.Height = btnAdd.Height;
								btnGTB.Cursor = Cursors.Hand;
								btnGTB.Left = btnAdd.Left;
								btnGTB.Top = btnAdd.Top;
								btnGTB.Text = "В корзине " + t["count"] + "шт.\r\nПерейти";
							}
							else
							{

								btnAdd.Text = "Добавить в корзину";
								btnGTB.Visible = false;
							}
					}
				}
				for (int l = 0; l < bsGoods.Count; l++)
				{
					DataRowView u = (DataRowView)bsGoods[l];
					if ((int)u["stock"] == 0)
					{
						btnAdd.Text = "Нет в наличии";
						btnAdd.Enabled = false;
						return;
					}
					else
					{
						btnAdd.Enabled = true;
					}
				}
			}
		}

		private void Info_Resize(object sender, EventArgs e)
		{
			check();
		}

		private void btnGTB_Click(object sender, EventArgs e)
		{
			Dashboard main = this.Owner as Dashboard;
			main.openChildForm(new Basket());
			this.Close();
		}
	}
}
