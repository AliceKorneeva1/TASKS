namespace TaskManagment
{
	partial class Autorisation
	{
		/// <summary>
		/// Required designer variable.
		/// </summary>
		private System.ComponentModel.IContainer components = null;

		/// <summary>
		/// Clean up any resources being used.
		/// </summary>
		/// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
		protected override void Dispose(bool disposing)
		{
			if (disposing && (components != null))
			{
				components.Dispose();
			}
			base.Dispose(disposing);
		}

		#region Windows Form Designer generated code

		/// <summary>
		/// Required method for Designer support - do not modify
		/// the contents of this method with the code editor.
		/// </summary>
		private void InitializeComponent()
		{
			System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Autorisation));
			login = new TextBox();
			label1 = new Label();
			Password = new TextBox();
			label2 = new Label();
			button1 = new Button();
			SuspendLayout();
			// 
			// login
			// 
			resources.ApplyResources(login, "login");
			login.Name = "login";
			// 
			// label1
			// 
			resources.ApplyResources(label1, "label1");
			label1.Name = "label1";
			// 
			// Password
			// 
			resources.ApplyResources(Password, "Password");
			Password.Name = "Password";
			Password.UseSystemPasswordChar = true;
			// 
			// label2
			// 
			resources.ApplyResources(label2, "label2");
			label2.Name = "label2";
			// 
			// button1
			// 
			resources.ApplyResources(button1, "button1");
			button1.Name = "button1";
			button1.UseVisualStyleBackColor = true;
			button1.Click += button1_Click;
			// 
			// Autorisation
			// 
			resources.ApplyResources(this, "$this");
			AutoScaleMode = AutoScaleMode.Font;
			Controls.Add(button1);
			Controls.Add(label2);
			Controls.Add(Password);
			Controls.Add(label1);
			Controls.Add(login);
			Name = "Autorisation";
			TopMost = true;
			ResumeLayout(false);
			PerformLayout();
		}

		#endregion

		private TextBox login;
		private Label label1;
		private TextBox Password;
		private Label label2;
		private Button button1;
	}
}