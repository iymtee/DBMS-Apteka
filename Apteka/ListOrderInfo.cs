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
	public partial class ListOrderInfo : Form
	{
		public ListOrderInfo()
		{
			InitializeComponent();
		}

		private void ListOrderInfo_Load(object sender, EventArgs e)
		{
			// TODO: This line of code loads data into the 'dsApteka.adpOrderInfo' table. You can move, or remove it, as needed.
			this.adpOrderInfoTableAdapter.Fill(this.dsApteka.adpOrderInfo);

		}

		private void pbClose_Click(object sender, EventArgs e)
		{
			Close();
		}
	}
}
