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
	public partial class ListOrderAdm : Form
	{
		public ListOrderAdm()
		{
			InitializeComponent();
		}

		private void ListOrderAdm_Load(object sender, EventArgs e)
		{
			this.adpInfoAdmTableAdapter.Fill(this.dsApteka.adpInfoAdm);
		}

		private void dgvOrderAdm_CellDoubleClick(object sender, DataGridViewCellEventArgs e)
		{
			try
			{
				ListOrder frm = new ListOrder();
				Dashboard main = this.MdiParent as Dashboard;
				DataRowView t = (DataRowView)bsOrderAdm[e.RowIndex];
				frm.bsOrder.Filter = "idU = '" + (Convert.ToInt32(t[2])-1) + "' and (status = 0 or status = 1)";
				frm.dgvOrders.Columns[3].ReadOnly = false;
				frm.dgvOrders.Columns[3].Visible = true;
				frm.dgvOrders.Columns[4].Visible = false;
				frm.btnSave.Visible = true;
				frm.MdiParent = main;
				frm.Dock = DockStyle.Fill;
				frm.Show();
			}
			catch (Exception ex) { MessageBox.Show(ex.Message); }
		}

		private void pbClose_Click(object sender, EventArgs e)
		{
			Close();
		}

		private void pbClose_Click_1(object sender, EventArgs e)
		{
			Close();
		}
	}
}
