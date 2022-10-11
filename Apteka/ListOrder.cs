using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Apteka
{
	public partial class ListOrder : Form
	{
		public ListOrder()
		{
			InitializeComponent();
		}
		
		private void dgvOrders_CellDoubleClick(object sender, DataGridViewCellEventArgs e)
		{
			DataRowView t = (DataRowView)bsOrder[e.RowIndex];
			ListOrderInfo frm = new ListOrderInfo();
			Dashboard main = this.MdiParent as Dashboard;
			frm.bsAdpOrderInfo.Filter = "idO = '" + Convert.ToInt32(t["idO"]) + "'";
			frm.MdiParent = main;
			frm.Dock = DockStyle.Fill;
			frm.Show();
		}

		private void pbClose_Click(object sender, EventArgs e)
		{
			Close();
		}
		
		void check()
		{
			for (int i = 0; i < bsOrder.Count; i++)
			{
				DataRowView t = (DataRowView)bsOrder[i];
				if (Convert.ToInt32(t["status"]) > 2 || Convert.ToInt32(t["status"]) < 0)
				{
					MessageBox.Show("У заказа под номером " + t[0] + " задан недопустимый статус. Изменения отменены.");
					Close(); return;
				}
			}
		}

		private void btnSave_Click(object sender, EventArgs e)
		{
			check();
			this.bsOrder.EndEdit();
			this.ordersTableAdapter.Update(this.dsApteka.Orders);
			this.ordersTableAdapter.Fill(this.dsApteka.Orders);
			this.tableAdapterManager.UpdateAll(this.dsApteka);
		}

		private void ListOrders_FormClosing(object sender, FormClosingEventArgs e)
		{
			dgvOrders.Columns["status"].ReadOnly = true;
			dgvOrders.Columns["status"].Visible = false;
			dgvOrders.Columns["statusStr"].Visible = true;
			btnSave.Visible = false;
		}

		private void KeyPress(object sender, KeyPressEventArgs e)
		{
			if (e.KeyChar == 48 || e.KeyChar == 49 || e.KeyChar == 50 || e.KeyChar == 8) e.Handled = false;
			else e.Handled = true;
		}

		private void dgvOrders_EditingControlShowing(object sender, DataGridViewEditingControlShowingEventArgs e)
		{
			e.Control.KeyPress -= new KeyPressEventHandler(KeyPress);
			e.Control.KeyPress += new KeyPressEventHandler(KeyPress);
		}

		private void ListOrder_Load(object sender, EventArgs e)
		{
			this.ordersTableAdapter.Fill(this.dsApteka.Orders);
		}

		private void pbClose_Click_1(object sender, EventArgs e)
		{
			Close();
		}
	}
}
