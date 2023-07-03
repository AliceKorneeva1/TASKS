using System.Data;
using System.Data.SqlClient;
using System.Data.Common;
using System.IO;
using System.Windows.Forms;
using Microsoft.Data.Sqlite;
using Microsoft.VisualBasic.ApplicationServices;
using TaskManagment;
using static System.Windows.Forms.VisualStyles.VisualStyleElement;


namespace TaskManagment
{


	public partial class MainForm : Form
	{
		static public DataBase db = new DataBase();
		List<User> users = new List<User>();
		List<Task> tasks = new List<Task>();
		DataTable table = new DataTable();
		public MainForm()
		{
			InitializeComponent();
		}

		struct User
		{
			public int id { get; set; }
			public string name { get; set; }
			public bool rw { get; set; }
			public override string ToString()
			{
				return name + " " + (rw ? " (редактор)" : " (читатель)");
			}
		}
		private void RefreshUsers()
		{

			var command = db.connection.CreateCommand();
			users.Clear();
			command.CommandText = @"SELECT Id, Name, RW FROM Users";
			using (var reader = command.ExecuteReader())
			{
				while (reader.Read())
				{
					var id = reader.GetInt32(0);
					if (id == db.curUser)
						continue;
					var name = reader.GetString(1);
					bool rw = reader.GetInt32(2) > 0;
					users.Add(new User { name = name, id = id, rw = rw });
				}
			}

			SelectUser.DataSource = new BindingSource(users, null);
		}

		private void RefreshTasks()
		{
			var command = db.connection.CreateCommand();
			table.Clear();
			command.CommandText = @"SELECT Id, Title, Description, Date, Priority, Status FROM Tasks";
			using (var reader = command.ExecuteReader())
			{
				table.Load(reader);
				dataGridView1.DataSource = table;
			}
			command = db.connection.CreateCommand();
			command.CommandText = @"SELECT count(*) FROM Tasks WHERE Status = 1";

			using (var reader = command.ExecuteReader())
			{
				while (reader.Read())
				{
					var id = reader.GetInt32(0);
					Done.Text = String.Format(" Выполнено {0} задач ", id);
				}
			}

			command.CommandText = @"SELECT count(*) FROM Tasks WHERE Status = 0";

			using (var reader = command.ExecuteReader())
			{
				while (reader.Read())
				{
					var id = reader.GetInt32(0);
					DOING.Text = String.Format(" Не выполнено {0} задач ", id);
				}
			}

			command.CommandText = @"SELECT count(*) FROM Tasks WHERE Priority = 0";

			using (var reader = command.ExecuteReader())
			{
				while (reader.Read())
				{
					var id = reader.GetInt32(0);
					P0.Text = String.Format(" С приоритетом 0 - {0} задач ", id);
				}
			}

			command.CommandText = @"SELECT count(*) FROM Tasks WHERE Priority = 1";

			using (var reader = command.ExecuteReader())
			{
				while (reader.Read())
				{
					var id = reader.GetInt32(0);
					P1.Text = String.Format(" С приоритетом 1 - {0} задач ", id);
				}
			}

			command.CommandText = @"SELECT count(*) FROM Tasks WHERE Priority = 2";
			using (var reader = command.ExecuteReader())
			{
				while (reader.Read())
				{
					var id = reader.GetInt32(0);
					P2.Text = String.Format(" С приоритетом 2 - {0} задач ", id);
				}
			}
		}

		private void MainForm_Load(object sender, EventArgs e)
		{
			groupBox1.Visible = false;
			if (openFileDialog1.ShowDialog() == DialogResult.OK)
			{
				db.connection = new SqliteConnection("DataSource =" + openFileDialog1.FileName);
				db.connection.Open();
				Autorisation form = new Autorisation();
				var result = form.ShowDialog();
				if (result != DialogResult.OK)
				{
					this.Close();
					return;
				}
				currentName.Text = "Пользователь: " + db.curName;
				groupBox1.Visible = db.RW;
				RefreshUsers();
				RefreshTasks();
				if (!db.RW)
				{
					dataGridView1.Columns["DO"].Visible = false;
				}
			}
			else
				MessageBox.Show("Неверный формат файла базы данных", "ОШИБОЧКА");
		}

		private void deleteUser_Click(object sender, EventArgs e)
		{
			var command = db.connection.CreateCommand();
			command.CommandText = @"DELETE FROM Users WHERE Id = @param1";
			int id = (SelectUser.SelectedItem as dynamic).id;
			command.Parameters.AddWithValue("@param1", id);
			var reader = command.ExecuteReader();
			RefreshUsers();
		}

		private void changeRW_Click(object sender, EventArgs e)
		{
			var command = db.connection.CreateCommand();
			command.CommandText = @"UPDATE Users SET RW = @param2 WHERE Id = @param1";
			int id = (SelectUser.SelectedItem as dynamic).id;
			command.Parameters.AddWithValue("@param1", id);
			bool rw = (SelectUser.SelectedItem as dynamic).rw;
			command.Parameters.AddWithValue("@param2", rw ? 0 : 1);
			var reader = command.ExecuteReader();
			RefreshUsers();
		}

		private void addUser_Click(object sender, EventArgs e)
		{
			var command = db.connection.CreateCommand();
			command.CommandText = @"INSERT INTO Users (Name, Password, RW) VALUES (@param1, @param2, @param3)";
			command.CommandType = CommandType.Text;
			command.Parameters.AddWithValue("@param1", login.Text);
			command.Parameters.AddWithValue("@param2", Password.Text);
			command.Parameters.AddWithValue("@param3", radioButton1.Checked ? 1 : 0);
			command.ExecuteNonQuery();
			RefreshUsers();
		}

		private void dataGridView1_CellClick(object sender, DataGridViewCellEventArgs e)
		{
			var senderGrid = (DataGridView)sender;
			if (e.ColumnIndex >= 0 && senderGrid.Columns[e.ColumnIndex] is DataGridViewButtonColumn && e.RowIndex >= 0)
			{
				TaskForm form = new TaskForm();
				if (e.RowIndex >= table.Rows.Count)
				{
					form.CreateNew();
				}
				else
					form.Initialization(table.Rows[e.RowIndex].ItemArray);
				var result = form.ShowDialog();
				RefreshTasks();
			}
		}
	}
}