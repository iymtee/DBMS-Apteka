using dllCheck;
using System;
using System.Data.SqlClient;
using System.Linq;
using System.Windows.Forms;

namespace Apteka
{
	public partial class Registration : Form
	{
		public static Boolean close;
		string q;
		SqlConnection con = Dashboard.con;

		public Registration()
		{
			InitializeComponent();
		}

		void  Visible(TextBox ctbxPassword, PictureBox pbVisible)
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

		private void pbVisiblePass_Click(object sender, EventArgs e)
		{
			Visible(ctbxPassword, pbVisiblePass);
		}

		private void pbVisibleAgPass_Click(object sender, EventArgs e)
		{
			Visible(ctbxPasswordAgain, pbVisibleAgPass);
		}

		private void btnReg_Click(object sender, EventArgs e)
		{
			if (Dashboard.user.id != -1)
			{
				Update_Click();
			}
			else Reg_Click();
		}

		private void Update_Click()
		{
			if (ctbxlName.Text != "" && ctbxName.Text != "" && ctbxmName.Text != "" && ctbxEmail.Text != "" &&
				 ctbxPhone.Text != "" && ctbxPassword.Text != "" && ctbxLogin.Text != "" && ctbxPasswordAgain.Text != ""
				 && ctbxCity.Text != "" && ctbxIndex.Text != "" && ctbxHome.Text != "" && ctbxStreet.Text != "" && ctbxHome.Text != "")
			{
				q = "UPDATE [user] SET lName= '" + ctbxlName.Text + "'," +
					"Name = '" + ctbxName.Text + "'," +
					"mName = '" + ctbxmName.Text + "'," +
					"bDay = '" + dtpbDay.Value.ToShortDateString() + "'," +
					"index = '" + ctbxIndex.Text + "'," +
					"city = '" + ctbxCity.Text + "'," +
					"street = '" + ctbxStreet.Text + "'," +
					"home = " + ctbxHome.Text + "," +
					"flat = " + ctbxFlat.Text + "," +
					"email = '" + ctbxEmail.Text + "'," +
					"phone = '" + ctbxPhone.Text + "'," +
					"login = '" + ctbxlName.Text + "'," +
					"password = '" + ctbxName.Text + "'" +
					" WHERE idU =" + Dashboard.user.id;
				try
				{
					con.Open();
					SqlCommand update = new SqlCommand(q, con);
					update.ExecuteNonQuery();
					con.Close();
					this.Close();
				}
				catch (Exception ex)
				{
					con.Close();
					MessageBox.Show(ex.Message);
					DialogResult = DialogResult.Abort;
				}
			}
		}

		private void Reg_Click()
		{
			if (ctbxlName.Text != "" && ctbxName.Text != "" && ctbxmName.Text != "" && ctbxEmail.Text != "" &&
				 ctbxPhone.Text != "" && ctbxlName.Text != "" && ctbxName.Text != "" && ctbxPasswordAgain.Text != ""
				 && ctbxCity.Text != "" && ctbxIndex.Text != "" && ctbxHome.Text != "" && ctbxStreet.Text != "" && ctbxFlat.Text != "")
			{
				con.Open();
				q = "INSERT INTO [user] (lName, name, mName, login, password, email, phone, bDay, index, city, street, home, flat ) VALUES ('"
					+ ctbxlName.Text + "', '"
					+ ctbxName.Text + "', '"
					+ ctbxmName.Text + "', "
					+ ctbxlName.Text + ", '"
					+ ctbxName.Text + "', '"
					+ ctbxEmail.Text + "', '"
					+ ctbxPhone.Text + "', '"
					+ dtpbDay.Text + "', '"
					+ ctbxIndex.Text + "', '"
					+ ctbxCity.Text + "', '"
					+ ctbxStreet.Text + "', "
					+ ctbxHome.Text + ", "
					+ ctbxFlat.Text + ")";

				SqlCommand reg = new SqlCommand(q, con);
				try
				{
					reg.ExecuteNonQuery();
					close = false;
					DialogResult = DialogResult.OK;
					Dashboard.bsFilter = "login = '" + ctbxlName.Text + "' and " + "password = '" + ctbxName.Text + "'";
					this.Close();
				}
				catch (Exception ex)
				{
					close = false;
					con.Close();
					if (ex.Message.IndexOf("UNIQUE KEY") >= 0)
					{
						MessageBox.Show("Измените логин. Пользователь с таким Логином уже существует.", "", MessageBoxButtons.OK, MessageBoxIcon.Warning);
						return;
					}
					else
					MessageBox.Show(ex.Message);
				}
			}
		}

		private void check(object sender, EventArgs e)
		{
			if (ctbxlName.Text == "") btnReg.Text = "Заполните поле фамилию!";
			else
			   if (ctbxName.Text == "") btnReg.Text = "Заполните поле имя!";
			else
			   if (ctbxmName.Text == "") btnReg.Text = "Заполните поле отчество!";
			else
			   if (ctbxLogin.Text == "") btnReg.Text = "Заполните поле логин!";
			else
			   if (ctbxIndex.Text == "") btnReg.Text = "Заполните поле индекс!";
			else
			   if (ctbxCity.Text == "") btnReg.Text = "Заполните поле город!";
			else
			   if (ctbxStreet.Text == "") btnReg.Text = "Заполните поле улица!";
			else
			   if (ctbxHome.Text == "") btnReg.Text = "Заполните поле дом!";
			else
			   if (ctbxFlat.Text == "") btnReg.Text = "Заполните поле квартира!";
			else
			   if (ctbxPhone.Text == "") btnReg.Text = "Заполните поле телефон!";
			else
			   if (ctbxEmail.Text == "") btnReg.Text = "Заполните поле электронная почта!";
			if (ctbxEmail.Text.Contains('@') == false || ctbxEmail.Text.LastIndexOf('@') == ctbxEmail.Text.Length - 1 || ctbxEmail.Text.LastIndexOf('@') != ctbxEmail.Text.IndexOf('@')) btnReg.Text = "Некорректный адрес электронной почты!";
			else
			if (Dashboard.user.id != -1)
			{
				if (ctbxPassword.Text == "") btnReg.Text = "Заполните поле Ваш новый пароль!";
				else
				if (Check.Password(ctbxPassword.Text) == false) btnReg.Text = "Пароль не соответствует требованиям!";
				else
				if (ctbxPasswordAgain.Text != Dashboard.user.password) btnReg.Text = "Неверный старый пароль!";
				else
				{ btnReg.Enabled = true; btnReg.Text = "Зарегистрировать"; }
			}
			else
			{
				if (ctbxPassword.Text == "") btnReg.Text = "Заполните поле пароль!";
				else
				if (Check.Password(ctbxPassword.Text) == false) btnReg.Text = "Пароль не соответствует требованиям!";
				else
				if (ctbxPassword.Text != ctbxPasswordAgain.Text) btnReg.Text = "Пароли не совпадают!";
				else
				{ btnReg.Enabled = true; btnReg.Text = "Сохранить"; }
			}
		}

		private void pbClose_Click(object sender, EventArgs e)
		{
			this.Close();
		}

		void LL()
		{
			Dashboard main = this.Owner as Dashboard;
			main.Fill();
		}

		private void Registration_Load(object sender, EventArgs e)
		{
			if (Dashboard.user.id > 0)
			{
				btnReg.Text = "Сохранить";
				ctbxlName.Text = Dashboard.user.lName;
				ctbxName.Text = Dashboard.user.name;
				ctbxmName.Text = Dashboard.user.mName;
				dtpbDay.Value = Dashboard.user.bDay;
				ctbxIndex.Text = Dashboard.user.indexs;
				ctbxCity.Text = Dashboard.user.city;
				ctbxStreet.Text = Dashboard.user.street;
				ctbxHome.Text = Dashboard.user.home.ToString();
				ctbxFlat.Text = Dashboard.user.flat.ToString();
				ctbxPhone.Text = Dashboard.user.phone;
				ctbxLogin.Text = Dashboard.user.login;
				ctbxEmail.Text = Dashboard.user.email;
			}
		}
	}
}
