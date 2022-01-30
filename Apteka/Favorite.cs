using System;
using System.Windows.Forms;

namespace Apteka
{
	public partial class Favorite : Form
	{
		public Favorite()
		{
			InitializeComponent();
		}

		private void ListFavorite_Load(object sender, EventArgs e)
		{
			this.adpFavoriteTableAdapter.Fill(this.dsApteka.adpFavorite);
			bsAdpFavorite.Filter = "idU = '" + Dashboard.user.id + "'";
		}

		private void pbClose_Click(object sender, EventArgs e)
		{
			Dashboard.isSearch = true;
			Close();
		}
	}
}
