using System;
using System.Windows.Forms;

namespace Apteka
{
	public partial class UsersAdm : Form
	{
		public UsersAdm()
		{
			InitializeComponent();
		}

		private void UsersAdm_Load(object sender, EventArgs e)
		{
			// TODO: This line of code loads data into the 'dsApteka.User' table. You can move, or remove it, as needed.
			this.userTableAdapter.Fill(this.dsApteka.User);
			bsUser.Filter = "type <>'0'";
		}

		private void btnAccept_Click(object sender, EventArgs e)
		{
			bsUser.EndEdit();
			userTableAdapter.Update(dsApteka.User);
		}

		private void pbClose_Click(object sender, EventArgs e)
		{
			Close();
		}

		private void dgvAdpInfoAdm_CellValidating(object sender, DataGridViewCellValidatingEventArgs e)
		{
			if (e.ColumnIndex == 4)
			{
				dgvAdpInfoAdm.Rows[e.RowIndex].ErrorText = "";
				if (e.FormattedValue.ToString() != "1" && e.FormattedValue.ToString() != "2" && e.FormattedValue.ToString() != "3")
				{
					e.Cancel = true;
					dgvAdpInfoAdm.Rows[e.RowIndex].ErrorText = "Некорректный тип пользователя!";
				}
			}
		}
	}
}
