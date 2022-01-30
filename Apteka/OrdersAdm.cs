using System;
using System.Data;
using System.Windows.Forms;

namespace Apteka
{
	public partial class OrdersAdm : Form
	{
		public OrdersAdm()
		{
			InitializeComponent();
		}

		private void ListOrderAdm_Load(object sender, EventArgs e)
		{
			this.adpOrdersAdmTableAdapter.Fill(this.dsApteka.adpOrdersAdm);
			this.adpOrdersAdmAllTableAdapter.Fill(this.dsApteka.adpOrdersAdmAll);
			if (Dashboard.user.type == 1)
			{
				dgvAdpInfoAdm.DataSource = bsAdpOrdersAdm;
				bsAdpOrdersAdm.Filter = "idUM ='" + Dashboard.user.id + "'";
			}
		}

		private void dgvOrderAdm_CellDoubleClick(object sender, DataGridViewCellEventArgs e)
		{
			DataRowView t;
			try
			{
				if (Dashboard.user.type == 1)
				{
					t = (DataRowView)bsAdpOrdersAdm[e.RowIndex];
					Orders.filter = "idU = '" + Convert.ToInt32(t["idU"]) + "' and (status = 0 or status = 1) and idUM ='" + Dashboard.user.id + "'";
				}
				else
				{
					t = (DataRowView)bsAdpOrdersAdmAll[e.RowIndex];
					Orders.filter = "idU = '" + Convert.ToInt32(t["idU"]) + "' and (status = 0 or status = 1)";
				}			
				Orders.adm = true;
				Dashboard main = this.Owner as Dashboard;
				main.openChildForm(new Orders());
			}
			catch (Exception ex) { MessageBox.Show(ex.Message); }
		}

		private void pbClose_Click(object sender, EventArgs e)
		{
			Dashboard.isSearch = true;
			Close();
		}

		private void dgvAdpInfoAdm_CellContentClick(object sender, DataGridViewCellEventArgs e)
		{

		}
	}
}
