namespace TaskManagment
{
	partial class TaskForm
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
			label1 = new Label();
			ID = new TextBox();
			label2 = new Label();
			Title = new TextBox();
			Description = new TextBox();
			label3 = new Label();
			dateTimePicker1 = new DateTimePicker();
			label4 = new Label();
			status = new CheckBox();
			button1 = new Button();
			Priority = new TextBox();
			Priority1 = new Label();
			SuspendLayout();
			// 
			// label1
			// 
			label1.AutoSize = true;
			label1.Location = new Point(12, 9);
			label1.Name = "label1";
			label1.Size = new Size(18, 15);
			label1.TabIndex = 0;
			label1.Text = "ID";
			// 
			// ID
			// 
			ID.Enabled = false;
			ID.Location = new Point(12, 27);
			ID.Name = "ID";
			ID.Size = new Size(100, 23);
			ID.TabIndex = 1;
			// 
			// label2
			// 
			label2.AutoSize = true;
			label2.Location = new Point(129, 9);
			label2.Name = "label2";
			label2.Size = new Size(65, 15);
			label2.TabIndex = 2;
			label2.Text = "Заголовок";
			// 
			// Title
			// 
			Title.Location = new Point(129, 27);
			Title.Name = "Title";
			Title.Size = new Size(259, 23);
			Title.TabIndex = 3;
			// 
			// Description
			// 
			Description.Location = new Point(12, 75);
			Description.Name = "Description";
			Description.Size = new Size(376, 23);
			Description.TabIndex = 4;
			// 
			// label3
			// 
			label3.AutoSize = true;
			label3.Location = new Point(12, 57);
			label3.Name = "label3";
			label3.Size = new Size(62, 15);
			label3.TabIndex = 5;
			label3.Text = "Описание";
			// 
			// dateTimePicker1
			// 
			dateTimePicker1.Location = new Point(12, 131);
			dateTimePicker1.Name = "dateTimePicker1";
			dateTimePicker1.Size = new Size(144, 23);
			dateTimePicker1.TabIndex = 6;
			// 
			// label4
			// 
			label4.AutoSize = true;
			label4.Location = new Point(12, 113);
			label4.Name = "label4";
			label4.Size = new Size(35, 15);
			label4.TabIndex = 7;
			label4.Text = "Срок";
			// 
			// status
			// 
			status.AutoSize = true;
			status.Location = new Point(300, 131);
			status.Name = "status";
			status.Size = new Size(88, 19);
			status.TabIndex = 8;
			status.Text = "Завершена";
			status.UseVisualStyleBackColor = true;
			// 
			// button1
			// 
			button1.Location = new Point(192, 168);
			button1.Name = "button1";
			button1.Size = new Size(196, 36);
			button1.TabIndex = 9;
			button1.Text = "Сохранить";
			button1.UseVisualStyleBackColor = true;
			button1.Click += button1_Click;
			// 
			// Priority
			// 
			Priority.Location = new Point(192, 131);
			Priority.Name = "Priority";
			Priority.Size = new Size(59, 23);
			Priority.TabIndex = 10;
			// 
			// Priority1
			// 
			Priority1.AutoSize = true;
			Priority1.Location = new Point(192, 113);
			Priority1.Name = "Priority1";
			Priority1.Size = new Size(67, 15);
			Priority1.TabIndex = 11;
			Priority1.Text = "Приоритет";
			// 
			// TaskForm
			// 
			AutoScaleDimensions = new SizeF(7F, 15F);
			AutoScaleMode = AutoScaleMode.Font;
			ClientSize = new Size(396, 220);
			Controls.Add(Priority1);
			Controls.Add(Priority);
			Controls.Add(button1);
			Controls.Add(status);
			Controls.Add(label4);
			Controls.Add(dateTimePicker1);
			Controls.Add(label3);
			Controls.Add(Description);
			Controls.Add(Title);
			Controls.Add(label2);
			Controls.Add(ID);
			Controls.Add(label1);
			Name = "TaskForm";
			Text = "TaskForm";
			ResumeLayout(false);
			PerformLayout();
		}

		#endregion

		private Label label1;
		private TextBox ID;
		private Label label2;
		private TextBox Title;
		private TextBox Description;
		private Label label3;
		private DateTimePicker dateTimePicker1;
		private Label label4;
		private CheckBox status;
		private Button button1;
		private TextBox Priority;
		private Label Priority1;
	}
}