using Microsoft.Data.Sqlite;

namespace TaskManagment
{
	internal static class Program
	{
		/// <summary>
		///  The main entry point for the application.
		/// </summary>
		[STAThread]
		static void Main()
		{
			// To customize application configuration such as set high DPI settings or default font,
			// see https://aka.ms/applicationconfiguration.
			ApplicationConfiguration.Initialize();
			Application.Run(new MainForm());
		}
	}

	public class DataBase
	{
		public int curUser { get; set; }
		public string curName { get; set; }
		public bool RW { get; set; }
		public SqliteConnection? connection;
	}
	public class Task
	{
		public int Id { get; set; }
		public string Title { get; set; }
		public string Description { get; set; }
		public DateOnly Date { get; set; }
		public int Priority { get; set; }

		public bool Status { get; set; }
	}
}