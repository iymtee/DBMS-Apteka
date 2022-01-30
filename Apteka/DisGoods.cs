using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Excel = Microsoft.Office.Interop.Excel;

namespace Apteka
{
	public partial class DisGoods : Form
	{
		public DisGoods()
		{
			InitializeComponent();
		}

		private void btnToExcel_Click(object sender, EventArgs e)
		{
			Excel.Application exapp = new Excel.Application();
			exapp.Visible = true;
			exapp.Workbooks.Open(Application.StartupPath + "\\Списание.xlsx", Type.Missing, true);
			Excel.Worksheet list1 = (exapp.Worksheets.get_Item(1));
			int rowexel = 24;
			for (int i = 0; i <= dgvGoods.RowCount - 1; i++)
			{
				int countDisc = 0;
				try
				{
					countDisc = Convert.ToInt32(dgvGoods.Rows[i].Cells[5].Value);
				}
				catch { }
				if (countDisc == 0) continue;
				else
				{
					list1.get_Range("A" + rowexel).Value = dgvGoods.Rows[i].Cells[2].Value;
					DataRowView t = (DataRowView)bsDiscard[i];
					list1.get_Range("D" + rowexel).Value = t["TG"].ToString();
					list1.get_Range("F" + rowexel).Value = t["dosage"].ToString();
					list1.get_Range("G" + rowexel).Value = countDisc;
					double price = Convert.ToDouble(dgvGoods.Rows[i].Cells[3].Value);
					list1.get_Range("I" + rowexel).Value = price;
					list1.get_Range("J" + rowexel).Value = countDisc * price;
					list1.get_Range("K" + rowexel).Value = dgvGoods.Rows[i].Cells[6].Value;
					rowexel++;
				}
			}
			list1.get_Range("C15").Value = Dashboard.user.lName + " " + Dashboard.user.name[0] + ". " + Dashboard.user.mName[0] + ". ";
		}

		private void btnDiscard_Click(object sender, EventArgs e)
		{
			if (MessageBox.Show("Вы уверены, что нужно списать указанное количество товара?", "Внимание!", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes)
			{
				try
				{
					for (int i = 0; i <= dgvGoods.RowCount - 1; i++)
					{
						int countDisc = 0;
						try
						{
							countDisc = Convert.ToInt32(dgvGoods.Rows[i].Cells[5].Value);
						}
						catch { }
						if (countDisc == 0) continue;
						else
						{
							int countG = Convert.ToInt32(dgvGoods.Rows[i].Cells[4].Value);
							countG -= countDisc;
							dgvGoods.Rows[i].Cells[4].Value = countG;
						}
					}
					bsGoods.EndEdit();
					goodsTableAdapter.Update(dsApteka.Goods);
					Close();
				}
				catch { MessageBox.Show("Ошибка списания материалов!"); }
			}
		}

		private void DisGoods_Load(object sender, EventArgs e)
		{
			this.adpDiscardTableAdapter.Fill(this.dsApteka.adpDiscard);
			this.goodsTableAdapter.Fill(this.dsApteka.Goods);
		}

		static bool IsNumberContains(string input)
		{
			foreach (char c in input)
				if (Char.IsNumber(c))
					return true;
			return false;
		}

		private void dgvGoods_CellValidating(object sender, DataGridViewCellValidatingEventArgs e)
		{
			if(e.ColumnIndex == 5)
			{
				dgvGoods.Rows[e.RowIndex].ErrorText = "";
				if (e.FormattedValue.ToString() != "")
				{
					if (IsNumberContains(e.FormattedValue.ToString()))
					{
						if (Convert.ToInt32(dgvGoods.Rows[e.RowIndex].Cells[4].Value.ToString()) >= Convert.ToInt32(e.FormattedValue)) return;
						e.Cancel = true;
						dgvGoods.Rows[e.RowIndex].ErrorText = "Кол-во к списанию превышает кол-во на складе!";

					}
					else
					{
						e.Cancel = true;
						dgvGoods.Rows[e.RowIndex].ErrorText = "Некорректный символ!";
					}
				}
			}
		}

		private void pbClose_Click(object sender, EventArgs e)
		{
			Close();
		}

		private void btnDel_Click(object sender, EventArgs e)
		{
			dgvGoods.Rows.Remove(this.dgvGoods.CurrentRow);
			goodsTableAdapter.Update(dsApteka.Goods);
			Dashboard frm = this.Owner as Dashboard;
			frm.Fill();
		}
	}
}

