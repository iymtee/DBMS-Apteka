using dllCheck;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Apteka
{
	public partial class Basket : Form
	{
		string q;
		SqlConnection con = Dashboard.con;
		SqlCommand sqlCom;
		double price = 0;

		public Basket()
		{
			InitializeComponent();
		}
		private void SumPrice()
		{
			price = 0;
			for (int i = 0; i < bsAdpBasket.Count; i++)
			{
				DataRowView t = (DataRowView)bsAdpBasket[i];
				price += Convert.ToDouble(dgvBasket.Rows[i].Cells[1].Value) * Convert.ToDouble(dgvBasket.Rows[i].Cells[2].Value);
			}
		}

		private void ListBasket_Resize(object sender, EventArgs e)
		{
			dtpDate.Width = (int)(p1.Width * 0.5);
			mtbxTime.Width = (int)(p1.Width * 0.5);
			mtbxTime.Focus();
		}

		private void ListBasket_Load(object sender, EventArgs e)
		{
			this.adpBasketTableAdapter.Fill(this.dsApteka.adpBasket);
			bsAdpBasket.Filter = "idU = '" + Dashboard.user.id + "'";
			dtpDate.MinDate = DateTime.Now;
			mtbxTime.Text = (Convert.ToInt32(DateTime.Now.Hour.ToString())+2) + DateTime.Now.Minute.ToString();
			check();
		}
		
		int count, stock;
		bool plus = false;

		void check()
		{
			if (dgvBasket.RowCount != 0)
			{
				btnBuy.Enabled = true;
				SumPrice();
				lblPrice.Text = "К оплате: " + price + " руб.";
			}
			else
			{
				btnBuy.Enabled = false;
				lblPrice.Text = "";
			}

			for (int i = 0; i < dgvBasket.Rows.Count; i++)
			{
				count = Convert.ToInt32(dgvBasket.Rows[i].Cells[2].Value);
				stock = Convert.ToInt32(dgvBasket.Rows[i].Cells[3].Value);
				if (count >= stock) dgvBasket.Rows[i].Cells["Add"].ReadOnly = true;
			}
		}

		private void btnAdd_Click(int num)
		{
			count = Convert.ToInt32(dgvBasket.Rows[num].Cells[2].Value);
			stock = Convert.ToInt32(dgvBasket.Rows[num].Cells[3].Value);
			if (plus) count = count + 1; else count = count - 1;
			if (count <= stock)
			{
				if ((count + 1) > stock) dgvBasket.Rows[num].Cells["Add"].ReadOnly = true;
				con.Open();
				q = "update [basket] set count =" + count + " where idB = " + Convert.ToInt32(dgvBasket.Rows[num].Cells[7].Value);

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
			}
			if (count == 0)
			{
				con.Open();
				q = "delete from [basket] where idB = " + Convert.ToInt32(dgvBasket.Rows[num].Cells[7].Value);
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
			}
			check();
			bsAdpBasket.EndEdit();
			this.adpBasketTableAdapter.Fill(this.dsApteka.adpBasket);
		}

		private void KeyPress(object sender, KeyPressEventArgs e)
		{
			if (Check.Numbers(e.KeyChar)) e.Handled = true;
		}

		private void dgvBasket_EditingControlShowing(object sender, DataGridViewEditingControlShowingEventArgs e)
		{
			e.Control.KeyPress -= new KeyPressEventHandler(KeyPress);
			e.Control.KeyPress += new KeyPressEventHandler(KeyPress);
		}		

		private void dgvBasket_CellClick(object sender, DataGridViewCellEventArgs e)
		{
			if (e.ColumnIndex == 4)
			{
				plus = true;
				btnAdd_Click(e.RowIndex);
			}
			if (e.ColumnIndex == 5)
			{
				plus = false;
				btnAdd_Click(e.RowIndex);
			}
			SumPrice();
			lblPrice.Text = "К оплате: " + price + " руб.";
		}

		private void btnBuy_Click(object sender, EventArgs e)
		{
			SqlConnection con = Dashboard.con;
			SqlCommand getIdM = new SqlCommand("MMO", con);
			con.Open();
			getIdM.CommandType = CommandType.StoredProcedure;
			int idM = 0;
			try
			{
				var returnValue = getIdM.Parameters.Add("@return", SqlDbType.Int);
				returnValue.Direction = ParameterDirection.ReturnValue;
				getIdM.ExecuteNonQuery();
				idM = (int)returnValue.Value + 1;
			}
			catch
			{
				con.Close(); return;
			}
			con.Close();
			int idO = -1;
			string a = "";
			if (rbt0.Checked) a = rbt0.Text; else a = rbt1.Text;
			string d = DateTime.Now.ToString("yyyy-MM-dd");

			SumPrice();

			q = "insert into Orders(cost, dateStart, status, payment, idU, dateEnd, idUM) values (" + price.ToString().Replace(',', '.')
				+ ", '" + d + "', " + 0 + ", '" + a + "', " + Dashboard.user.id + ",'" + dtpDate.Value.ToString("yyyy-MM-dd") + " " + mtbxTime.Text + "'," + idM + ")";
			con.Open();
			sqlCom = new SqlCommand(q, con);
			try
			{
				sqlCom.ExecuteNonQuery();
			}
			catch (Exception ex)
			{
				MessageBox.Show(ex.Message); con.Close(); return;
			}
			con.Close();

			q = "SELECT MAX(idO) FROM Orders where [dateStart] ='" + d + "' and idU =" + Dashboard.user.id;
			sqlCom = new SqlCommand(q, con);
			con.Open();
			try
			{
				SqlDataReader sdr = sqlCom.ExecuteReader();
				if (sdr.Read()) idO = Convert.ToInt32(sdr[0]);
			}
			catch (Exception ex)
			{
				MessageBox.Show(ex.Message); con.Close(); return;
			}
			con.Close();

			for (int i = 0; i < bsAdpBasket.Count; i++)
			{
				DataRowView t = (DataRowView)bsAdpBasket[i];
				q = "insert into OG(idO, idG, idU, count) values (" + idO + ", "
				+ Convert.ToInt32(t["idG"]) + ", " + Dashboard.user.id + ", " + Convert.ToInt32(t["count"]) + ")";
				sqlCom = new SqlCommand(q, con);
				con.Open();
				try
				{
					sqlCom.ExecuteNonQuery();
				}
				catch (Exception ex)
				{
					MessageBox.Show(ex.Message); con.Close(); return;
				}
				con.Close();

				q = "update goods set stock =" + (Convert.ToInt32(t[3]) - Convert.ToInt32(t[2])) +
					"where idG = " + Convert.ToInt32(t["idG"]);
				sqlCom = new SqlCommand(q, con);
				con.Open();
				try
				{
					sqlCom.ExecuteNonQuery();
				}
				catch (Exception ex)
				{
					MessageBox.Show(ex.Message); con.Close(); return;
				}
				con.Close();

				q = "delete from [basket] where idU = " + Dashboard.user.id;
				sqlCom = new SqlCommand(q, con);
				con.Open();
				try
				{
					sqlCom.ExecuteNonQuery();
				}
				catch (Exception ex)
				{
					MessageBox.Show(ex.Message); con.Close(); return;
				}
				con.Close();
			}
			bsAdpBasket.EndEdit();
			adpBasketTableAdapter.Fill(this.dsApteka.adpBasket);
			dgvBasket.Refresh();
			MessageBox.Show("Заказ сформирован!");
		}

		private void pbClose_Click(object sender, EventArgs e)
		{
			Dashboard.isSearch = true;
			this.Close();
		}
	}
}
