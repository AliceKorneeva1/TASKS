using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using static System.Windows.Forms.VisualStyles.VisualStyleElement.Window;

namespace TaskManagment
{
	public partial class Autorisation : Form
	{
		public Autorisation()
		{
			InitializeComponent();
			//TopMost = true;
			//login.Focus();
		}

		private void button1_Click(object sender, EventArgs e)
		{
			var slogin = login.Text;
			var spassword = Password.Text;
			var command = MainForm.db.connection.CreateCommand();
			MainForm.db.curUser = -1;
			command.CommandText = @"SELECT Id, RW, Name  FROM Users WHERE Name = @param1 AND Password = @param2";
			command.Parameters.AddWithValue("@param1", slogin);
			command.Parameters.AddWithValue("@param2", spassword);
			using (var reader = command.ExecuteReader())
			{
				while (reader.Read())
				{
					MainForm.db.curUser = reader.GetInt32(0);
					MainForm.db.RW = reader.GetInt32(1) > 0;
					MainForm.db.curName = reader.GetString(2);
				}
			}
			if (MainForm.db.curUser >= 0)
			{
				DialogResult = DialogResult.OK;
				this.Close();
			}
			else
				MessageBox.Show("Неверный логин/пароль", "ОШИБОЧКА");
		}
	}
}
