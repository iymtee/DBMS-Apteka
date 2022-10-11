using System;
using System.Windows.Forms;

namespace Apteka
{
	public partial class Autorization : Form
	{
		public Autorization()
		{
			InitializeComponent();
		}

		private void Autorization_Load(object sender, EventArgs e)
		{
			this.userTableAdapter.Fill(this.dsApteka.User);
			ctbxLogin.Focus();
		}

		private void pbClose_Click(object sender, EventArgs e)
		{
			Close();
			Dispose();
			DialogResult = DialogResult.Cancel;
		}

		private void btnLogin_Click(object sender, EventArgs e)
		{
			if (ctbxLogin.Text != "" && ctbxPassword.Text != "")
			{
				if (ctbxLogin.Text != "")
				{
					if (ctbxPassword.Text != "")
					{
						Dashboard.bsFilter = "login = '" + ctbxLogin.Text + "' and " + "password = '" + ctbxPassword.Text + "'";

						bsUser.Filter = Dashboard.bsFilter;
						if (bsUser.Count == 1) DialogResult = DialogResult.OK;
						else
						{
							Dashboard.bsFilter = "";
							MessageBox.Show("Пользователь с таким логином и паролем не найден!", "", MessageBoxButtons.OK, MessageBoxIcon.Warning);
						}
					}
					else MessageBox.Show("Введите пароль!", "", MessageBoxButtons.OK, MessageBoxIcon.Warning);
				}
				else MessageBox.Show("Введите логин!", "", MessageBoxButtons.OK, MessageBoxIcon.Warning);
			}
			else MessageBox.Show("Введите логин и пароль!", "", MessageBoxButtons.OK, MessageBoxIcon.Warning);
		}

		private void pbVisible_Click(object sender, EventArgs e)
		{
			if (pbVisible.Tag.ToString() == "100")
			{
				pbVisible.Image = Properties.Resources.invisible;
				ctbxPassword.UseSystemPasswordChar = false;
				pbVisible.Tag = 101;
			}
			else
			{
				pbVisible.Image = Properties.Resources.visible;
				ctbxPassword.UseSystemPasswordChar = true;
				pbVisible.Tag = 100;
			}
		}

		private void hlReg_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
		{
			Dashboard main = this.Owner as Dashboard;
			main.openChildForm(new Registration());
			this.Close();
            this.Dispose();
        }
	}
}
