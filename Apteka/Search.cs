using dllCheck;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Apteka
{
	public partial class Search : Form
	{
		public struct Tovar
		{
			public int id, countvo, countvoSclad, srokGod, discount, idVT;
			public double price, itogprice;
			public string name, info, sostav, recomend, protivpokaz, uslxr, dozirovka, proizvoditel;
			public Image image;
		}

		private void ListInfo_Load(object sender, EventArgs e)
		{
			this.goodsTableAdapter.Fill(this.dsApteka.Goods);
		}

		public Search()
		{
			InitializeComponent();
			this.goodsTableAdapter.Fill(this.dsApteka.Goods);
			FM(ref masTovar);
			FL(masTovar);
		}

		private void info_Click(object sender, EventArgs e)
		{
			Info frm = new Info();
			Dashboard main = this.MdiParent as Dashboard;
			frm.MdiParent = main;
			frm.Dock = DockStyle.Fill;
			Info.id = Convert.ToInt32((sender as PictureBox).Name.ToString().Remove(0, 2));
			frm.pbImage.Image = masTovar[Info.id].image;
			frm.lblName.Text = masTovar[Info.id].name;
			frm.lblPrice.Text = masTovar[Info.id].itogprice.ToString() + "₽";
			if (masTovar[Info.id].itogprice != masTovar[Info.id].price)
				frm.lblOldPrice.Text = masTovar[Info.id].price.ToString() + "₽";
			frm.lblInfo.Text = masTovar[Info.id].info;
			frm.check();
			frm.Show();
		}

		public static Tovar[] masTovar, masTS;

		void FM(ref Tovar[] masTovar)
		{
			if (0 >= bsGoods.Count) return;
			masTovar = new Tovar[bsGoods.Count];

			for (int i = 0; i < bsGoods.Count; i++)
			{
				DataRowView t = (DataRowView)bsGoods[i];
				masTovar[i].id = (int)t[0];
				masTovar[i].name = t[1].ToString();
				masTovar[i].info = t[2].ToString();
				masTovar[i].sostav = t[3].ToString();
				masTovar[i].recomend = t[4].ToString();
				masTovar[i].protivpokaz = t[5].ToString();
				masTovar[i].countvo = (int)t[6];
				masTovar[i].dozirovka = t[7].ToString();
				masTovar[i].srokGod = (int)t[8];
				masTovar[i].uslxr = t[9].ToString();
				masTovar[i].proizvoditel = t[10].ToString();
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
				masTovar[i].countvoSclad = (int)t[15];
				masTovar[i].idVT = (int)t[16];
			}
		}

		public void FL(Tovar[] masTovar)
		{
			pBottom.Controls.Clear();
			PictureBox[] masPB = new PictureBox[masTovar.Length];
			Label[] lab = new Label[masTovar.Length];

			int x = 25, y = 25, dx = x, dy = y, a = 0, width = 150;

			for (int i = 0; i < masTovar.Length; i++)
			{
				if (dx + 25 + width > pBottom.Width)
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
				pBottom.Controls.Add(masPB[i]);
				pBottom.Controls.SetChildIndex(masPB[i], 0);
				//создаем Label с i-товаром
				lab[i] = new Label();
				lab[i].AutoSize = false;
				masPB[i].Tag = masTovar[i].id;
				lab[i].Text = masTovar[i].name;
				lab[i].MaximumSize = new Size(150, 0);
				lab[i].AutoSize = true;
				lab[i].Left = dx;
				lab[i].Top = dy + masPB[i].Height;
				pBottom.Controls.Add(lab[i]);
				pBottom.Controls.SetChildIndex(lab[i], 0);

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
				FM(ref masTovar);
				FL(masTovar);
			}
		}

		private void tbxSearch_TextChanged(object sender, EventArgs e)
		{
			pbSearch_Click(sender, e);
			if (tbxSearch.Text == string.Empty)
			{
				bsGoods.Filter = "";
				FM(ref masTovar);
				FL(masTovar);
			}
		}

		private void tbxSearch_KeyPress(object sender, KeyPressEventArgs e)
		{
			if (Check.Letters(e.KeyChar)) e.Handled = true;
		}

		private void goodsBindingNavigatorSaveItem_Click(object sender, EventArgs e)
		{
			this.Validate();
			this.bsGoods.EndEdit();
			this.tableAdapterManager.UpdateAll(this.dsApteka);

		}

		private void ListInfo_Resize(object sender, EventArgs e)
		{
			FL(masTovar);
		}
	}
}
