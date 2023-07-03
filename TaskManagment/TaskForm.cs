using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace TaskManagment
{
	public partial class TaskForm : Form
	{
		bool bNew = false;
		public TaskForm()
		{
			InitializeComponent();
		}
		public void Initialization(object[] ItemArray)
		{
			ID.Text = ((long)ItemArray[0]).ToString();
			Title.Text = (string)ItemArray[1];
			Description.Text = (string)ItemArray[2];
			dateTimePicker1.Value = DateTime.Parse((string)ItemArray[3]);
			Priority.Text = ((long)ItemArray[4]).ToString();
			status.Checked = (long)ItemArray[5] > 0;
		}
		public void CreateNew()
		{
			bNew = true;
			ID.Text = "Новый";
			var command = MainForm.db.connection.CreateCommand();

		}
		private void button1_Click(object sender, EventArgs e)
		{
			var command = MainForm.db.connection.CreateCommand();
			if (bNew)
			{
				command.CommandText = @"INSERT INTO Tasks (Title, Description,  Date,  Priority, Status) VALUES (@param2,@param3,@param4, @param5, @param6)";
				command.Parameters.AddWithValue("@param2", Title.Text);
				command.Parameters.AddWithValue("@param3", Description.Text);
				command.Parameters.AddWithValue("@param4", DateOnly.FromDateTime(dateTimePicker1.Value));
				command.Parameters.AddWithValue("@param5", Priority.Text);
				command.Parameters.AddWithValue("@param6", status.Checked);
				command.ExecuteNonQuery();
				this.Close();
			}
			else
			{
				command.CommandText = @"UPDATE Tasks SET Title = @param2, Description = @param3, Date = @param4, Priority = @param5, Status  = @param6 WHERE Id = @param1";
				command.Parameters.AddWithValue("@param1", ID.Text);
				command.Parameters.AddWithValue("@param2", Title.Text);
				command.Parameters.AddWithValue("@param3", Description.Text);
				command.Parameters.AddWithValue("@param4", DateOnly.FromDateTime(dateTimePicker1.Value));
				command.Parameters.AddWithValue("@param5", Priority.Text);
				command.Parameters.AddWithValue("@param6", status.Checked);
				command.ExecuteNonQuery();
				this.Close();
			}
		}
	}
}
