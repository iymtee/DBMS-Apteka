using dllCheck;
using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Drawing;
using System.Windows.Forms;

namespace Apteka
{
	public partial class AddGoods : Form
	{
		public struct Goods
		{
			public int id, count, stock, shelfLife, discount, idVT;
			public double price, itogprice;
			public string name, info, comp, recomend, contrindic, storageCond, dosage, manufacture;
			public Image image;
		}

		public struct ExGoods
		{
			public int id, count;
			public string name;
		}

		public struct TG
		{
			public string name, unit;
		}

		List<Goods> lstGoods = new List<Goods>();
		List<ExGoods> lstExGoods = new List<ExGoods>();
		List<TG> lstTG = new List<TG>();

		public AddGoods()
		{
			InitializeComponent();
		}

		private void goodsBindingNavigatorSaveItem_Click(object sender, EventArgs e)
		{
			this.Validate();
			this.bsGoods.EndEdit();
			this.tableAdapterManager.UpdateAll(this.dsApteka);
		}

		private void AddG_Load(object sender, EventArgs e)
		{
			this.tGTableAdapter.Fill(this.dsApteka.TG);
			this.goodsTableAdapter.Fill(this.dsApteka.Goods);
		}


		private void btnImage_Click(object sender, EventArgs e)
		{
			if (btnImage.Text == "Загрузить фото")
			{
				if (openFileDialog1.ShowDialog() == DialogResult.OK)
					pbImage.Image = Image.FromFile(openFileDialog1.FileName);
				btnImage.Text = "Удалить фото";
			}
			else
			{
				if (MessageBox.Show("Очистить фотографию?", "Внимание!", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes)
				{
					pbImage.Image = null;
					btnImage.Text = "Загрузить фото";
				}
			}
		}

		private void btnAdd_Click(object sender, EventArgs e)
		{
			if (tbxComp.Text == "" || tbxContrindic.Text == "" || tbxCount.Text == "" || tbxInfo.Text == "" ||
				tbxManufacture.Text == "" || tbxName.Text == "" || tbxPrice.Text == ""
				|| tbxRecomend.Text == "" || tbxShelfLife.Text == "" || tbxStock.Text == "" || tbxStorageCond.Text == "" || pbImage.Image == null)
			{
				MessageBox.Show("Заполните все данные о товаре!");
				return;
			}

			Goods goods = new Goods();
			goods.name = tbxName.Text;
			goods.info = tbxInfo.Text;
			goods.comp = tbxComp.Text;
			goods.recomend = tbxRecomend.Text;
			goods.contrindic = tbxContrindic.Text;
			goods.count = Convert.ToInt32(tbxCount.Text);
			goods.dosage = tbxDosage.Text;
			goods.shelfLife = Convert.ToInt32(tbxShelfLife.Text);
			goods.storageCond = tbxStorageCond.Text;
			goods.manufacture = tbxManufacture.Text;
			goods.price = Convert.ToDouble(tbxPrice.Text);
			goods.stock = Convert.ToInt32(tbxStock.Text);
			goods.image = pbImage.Image;

			lstGoods.Add(goods);

			dgvGoods.Rows.Add(goods.image, goods.name, goods.info, goods.recomend, goods.contrindic,
				goods.count, goods.dosage, goods.shelfLife, goods.storageCond, goods.manufacture, goods.price, goods.stock);
		}

		private void btnAddEG_Click(object sender, EventArgs e)
		{
			if (tbxCountExGoods.Text == "")
			{
				MessageBox.Show("Заполните все данные о товаре!");
				return;
			}

			ExGoods goods;
			goods.name = cbxExGoods.Text;
			goods.id = Convert.ToInt32(cbxExGoods.SelectedValue.ToString());
			goods.count = Convert.ToInt32(tbxCountExGoods.Text);
			lstExGoods.Add(goods);
			dgvExGoods.Rows.Add(goods.name, goods.count, goods.id);

		}

		private void btnAddTG_Click(object sender, EventArgs e)
		{
			if (tbxnameTG.Text == "" || tbxUnit.Text == "")
			{
				MessageBox.Show("Заполните все данные о товаре!");
				return;
			}

			TG typeG;
			typeG.name = tbxnameTG.Text;
			typeG.unit = tbxUnit.Text;

			lstTG.Add(typeG);
			dgvTG.Rows.Add(typeG.name, typeG.unit);
		}

		private void btnDel_Click(object sender, EventArgs e)
		{
			int num = dgvGoods.CurrentRow.Index;
			if (num >= 0)
			{
				lstGoods.RemoveAt(num);
				dgvGoods.Rows.RemoveAt(num);
			}
		}

		private void btnDelEG_Click(object sender, EventArgs e)
		{
			int num = dgvExGoods.CurrentRow.Index;
			if (num >= 0)
			{
				lstExGoods.RemoveAt(num);
				dgvExGoods.Rows.RemoveAt(num);
			}
		}

		private void btnDelTG_Click(object sender, EventArgs e)
		{
			int num = dgvTG.CurrentRow.Index;
			if (num >= 0)
			{
				lstTG.RemoveAt(num);
				dgvTG.Rows.RemoveAt(num);
			}
		}

		private void btnAccept_Click(object sender, EventArgs e)
		{
			foreach (Goods Goods in lstGoods)
			{
				bsGoods.AddNew();
				stockTextBox.Text = Goods.stock.ToString();
				nameTextBox.Text = Goods.name;
				infoTextBox.Text = Goods.info;
				compTextBox.Text = Goods.comp;
				recomendTextBox.Text = Goods.recomend;
				contrindicTextBox.Text = Goods.contrindic;
				countTextBox.Text = Goods.count.ToString();
				dosageTextBox.Text = Goods.dosage;
				shelfLifeTextBox.Text = Goods.shelfLife.ToString();
				storageCondTextBox.Text = Goods.storageCond;
				manufactureTextBox.Text = Goods.manufacture;
				priceTextBox.Text = Goods.price.ToString();
				discountTextBox.Text = "0";
				idTGTextBox.Text = cbxTG.SelectedValue.ToString();
				imagePictureBox.Image = Goods.image;
			}
			bsGoods.EndEdit();
			goodsTableAdapter.Update(dsApteka.Goods);

			foreach (TG typeG in lstTG)
			{
				bsTG.AddNew();
				nameTGTextBox.Text = typeG.name;
				unitTextBox.Text = typeG.unit;
			}
			bsTG.EndEdit();
			tGTableAdapter.Update(dsApteka.TG);

			foreach (ExGoods ExGoods in lstExGoods)
			{
				SqlConnection con = Dashboard.con;
				con.Open();
				SqlCommand sqlCom = new SqlCommand("update Goods set stock = (select stock from Goods where idG =" + ExGoods.id + ") + " + ExGoods.count.ToString() + " where idG = " + ExGoods.id, con);
				try
				{
					sqlCom.ExecuteNonQuery();
				}
				catch (Exception ex)
				{
					MessageBox.Show(ex.Message);
				}
				con.Close();
			}
			MessageBox.Show("Добавление выполнено успешно!");
			Dashboard frm = this.Owner as Dashboard;
			frm.Fill();
			Close();
		}

		private void pbClose_Click(object sender, EventArgs e)
		{
			Close();
		}

		private void Numbers_KeyPress(object sender, KeyPressEventArgs e)
		{
			if (Check.Numbers(e.KeyChar)) e.Handled = true;
		}

		private void NumbersWithComma_KeyPress(object sender, KeyPressEventArgs e)
		{
			if (Check.NumbersWithComma(e.KeyChar)) e.Handled = true;
		}
	}

}
