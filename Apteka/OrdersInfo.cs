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
	public partial class OrdersInfo : Form
	{
		public OrdersInfo()
		{
			InitializeComponent();
		}

		private void ListOrderInfo_Load(object sender, EventArgs e)
		{
			bsAdpOrderInfo.Filter = Orders.filter;
			this.adpOrderInfoTableAdapter.Fill(this.dsApteka.adpOrderInfo);
		}

		private void pbClose_Click(object sender, EventArgs e)
		{
			Dashboard.isSearch = true;
			Close();
		}

		private void adpOrderInfoDataGridView_CellContentClick(object sender, DataGridViewCellEventArgs e)
		{

		}
	}
}
