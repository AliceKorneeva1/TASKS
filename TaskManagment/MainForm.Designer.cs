namespace TaskManagment
{
	partial class MainForm
	{
		/// <summary>
		///  Required designer variable.
		/// </summary>
		private System.ComponentModel.IContainer components = null;

		/// <summary>
		///  Clean up any resources being used.
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
		///  Required method for Designer support - do not modify
		///  the contents of this method with the code editor.
		/// </summary>
		private void InitializeComponent()
		{
			components = new System.ComponentModel.Container();
			openFileDialog1 = new OpenFileDialog();
			currentName = new Label();
			groupBox1 = new GroupBox();
			radioButton2 = new RadioButton();
			radioButton1 = new RadioButton();
			addUser = new Button();
			changeRW = new Button();
			label2 = new Label();
			label1 = new Label();
			deleteUser = new Button();
			Password = new TextBox();
			SelectUser = new ComboBox();
			login = new TextBox();
			label3 = new Label();
			dataGridView1 = new DataGridView();
			idDataGridViewTextBoxColumn = new DataGridViewTextBoxColumn();
			titleDataGridViewTextBoxColumn = new DataGridViewTextBoxColumn();
			descriptionDataGridViewTextBoxColumn = new DataGridViewTextBoxColumn();
			dateDataGridViewTextBoxColumn = new DataGridViewTextBoxColumn();
			priorityDataGridViewTextBoxColumn = new DataGridViewTextBoxColumn();
			statusDataGridViewCheckBoxColumn = new DataGridViewCheckBoxColumn();
			DO = new DataGridViewButtonColumn();
			tasksBindingSource = new BindingSource(components);
			dataBaseBindingSource = new BindingSource(components);
			Done = new Label();
			P0 = new Label();
			P1 = new Label();
			P2 = new Label();
			DOING = new Label();
			groupBox1.SuspendLayout();
			((System.ComponentModel.ISupportInitialize)dataGridView1).BeginInit();
			((System.ComponentModel.ISupportInitialize)tasksBindingSource).BeginInit();
			((System.ComponentModel.ISupportInitialize)dataBaseBindingSource).BeginInit();
			SuspendLayout();
			// 
			// openFileDialog1
			// 
			openFileDialog1.FileName = "TaskManagment.db";
			openFileDialog1.Title = "Выберите файл с базой данных";
			// 
			// currentName
			// 
			currentName.AutoSize = true;
			currentName.Location = new Point(1020, 9);
			currentName.Name = "currentName";
			currentName.Size = new Size(38, 15);
			currentName.TabIndex = 0;
			currentName.Text = "label1";
			// 
			// groupBox1
			// 
			groupBox1.Controls.Add(radioButton2);
			groupBox1.Controls.Add(radioButton1);
			groupBox1.Controls.Add(addUser);
			groupBox1.Controls.Add(changeRW);
			groupBox1.Controls.Add(label2);
			groupBox1.Controls.Add(label1);
			groupBox1.Controls.Add(deleteUser);
			groupBox1.Controls.Add(Password);
			groupBox1.Controls.Add(SelectUser);
			groupBox1.Controls.Add(login);
			groupBox1.Controls.Add(label3);
			groupBox1.ForeColor = SystemColors.ActiveCaptionText;
			groupBox1.Location = new Point(1020, 37);
			groupBox1.Name = "groupBox1";
			groupBox1.Size = new Size(211, 378);
			groupBox1.TabIndex = 1;
			groupBox1.TabStop = false;
			groupBox1.Text = "Администрирование";
			groupBox1.Visible = false;
			// 
			// radioButton2
			// 
			radioButton2.AutoSize = true;
			radioButton2.Location = new Point(6, 307);
			radioButton2.Name = "radioButton2";
			radioButton2.Size = new Size(75, 19);
			radioButton2.TabIndex = 11;
			radioButton2.Text = "Читатель";
			radioButton2.UseVisualStyleBackColor = true;
			// 
			// radioButton1
			// 
			radioButton1.AutoSize = true;
			radioButton1.Checked = true;
			radioButton1.Location = new Point(6, 282);
			radioButton1.Name = "radioButton1";
			radioButton1.Size = new Size(75, 19);
			radioButton1.TabIndex = 10;
			radioButton1.TabStop = true;
			radioButton1.Text = "Редактор";
			radioButton1.UseVisualStyleBackColor = true;
			// 
			// addUser
			// 
			addUser.Location = new Point(0, 345);
			addUser.Name = "addUser";
			addUser.Size = new Size(199, 23);
			addUser.TabIndex = 9;
			addUser.Text = "Добавить пользователя";
			addUser.UseVisualStyleBackColor = true;
			addUser.Click += addUser_Click;
			// 
			// changeRW
			// 
			changeRW.Location = new Point(6, 56);
			changeRW.Name = "changeRW";
			changeRW.Size = new Size(199, 23);
			changeRW.TabIndex = 8;
			changeRW.Text = "Поменять права";
			changeRW.UseVisualStyleBackColor = true;
			changeRW.Click += changeRW_Click;
			// 
			// label2
			// 
			label2.AutoSize = true;
			label2.ImeMode = ImeMode.NoControl;
			label2.Location = new Point(6, 235);
			label2.Name = "label2";
			label2.Size = new Size(49, 15);
			label2.TabIndex = 7;
			label2.Text = "Пароль";
			// 
			// label1
			// 
			label1.AutoSize = true;
			label1.Location = new Point(6, 157);
			label1.Name = "label1";
			label1.Size = new Size(137, 15);
			label1.TabIndex = 2;
			label1.Text = "Добавить пользователя";
			// 
			// deleteUser
			// 
			deleteUser.Location = new Point(6, 85);
			deleteUser.Name = "deleteUser";
			deleteUser.Size = new Size(199, 23);
			deleteUser.TabIndex = 1;
			deleteUser.Text = "Удалить пользователя";
			deleteUser.UseVisualStyleBackColor = true;
			deleteUser.Click += deleteUser_Click;
			// 
			// Password
			// 
			Password.Location = new Point(6, 253);
			Password.Name = "Password";
			Password.Size = new Size(199, 23);
			Password.TabIndex = 6;
			// 
			// SelectUser
			// 
			SelectUser.FormattingEnabled = true;
			SelectUser.Location = new Point(6, 26);
			SelectUser.Name = "SelectUser";
			SelectUser.Size = new Size(199, 23);
			SelectUser.TabIndex = 0;
			// 
			// login
			// 
			login.Location = new Point(6, 205);
			login.Name = "login";
			login.Size = new Size(199, 23);
			login.TabIndex = 4;
			// 
			// label3
			// 
			label3.AutoSize = true;
			label3.ImeMode = ImeMode.NoControl;
			label3.Location = new Point(6, 187);
			label3.Name = "label3";
			label3.Size = new Size(109, 15);
			label3.TabIndex = 5;
			label3.Text = "Имя пользователя";
			// 
			// dataGridView1
			// 
			dataGridView1.AutoGenerateColumns = false;
			dataGridView1.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
			dataGridView1.Columns.AddRange(new DataGridViewColumn[] { idDataGridViewTextBoxColumn, titleDataGridViewTextBoxColumn, descriptionDataGridViewTextBoxColumn, dateDataGridViewTextBoxColumn, priorityDataGridViewTextBoxColumn, statusDataGridViewCheckBoxColumn, DO });
			dataGridView1.DataSource = tasksBindingSource;
			dataGridView1.Location = new Point(0, 9);
			dataGridView1.Name = "dataGridView1";
			dataGridView1.RowTemplate.Height = 25;
			dataGridView1.Size = new Size(1014, 406);
			dataGridView1.TabIndex = 2;
			dataGridView1.CellClick += dataGridView1_CellClick;
			// 
			// idDataGridViewTextBoxColumn
			// 
			idDataGridViewTextBoxColumn.DataPropertyName = "Id";
			idDataGridViewTextBoxColumn.HeaderText = "Id";
			idDataGridViewTextBoxColumn.Name = "idDataGridViewTextBoxColumn";
			idDataGridViewTextBoxColumn.ReadOnly = true;
			idDataGridViewTextBoxColumn.Width = 30;
			// 
			// titleDataGridViewTextBoxColumn
			// 
			titleDataGridViewTextBoxColumn.DataPropertyName = "Title";
			titleDataGridViewTextBoxColumn.HeaderText = "Заголовок";
			titleDataGridViewTextBoxColumn.Name = "titleDataGridViewTextBoxColumn";
			titleDataGridViewTextBoxColumn.ReadOnly = true;
			titleDataGridViewTextBoxColumn.Width = 200;
			// 
			// descriptionDataGridViewTextBoxColumn
			// 
			descriptionDataGridViewTextBoxColumn.DataPropertyName = "Description";
			descriptionDataGridViewTextBoxColumn.HeaderText = "Описание";
			descriptionDataGridViewTextBoxColumn.Name = "descriptionDataGridViewTextBoxColumn";
			descriptionDataGridViewTextBoxColumn.ReadOnly = true;
			descriptionDataGridViewTextBoxColumn.Width = 400;
			// 
			// dateDataGridViewTextBoxColumn
			// 
			dateDataGridViewTextBoxColumn.DataPropertyName = "Date";
			dateDataGridViewTextBoxColumn.HeaderText = "Срок выполнения";
			dateDataGridViewTextBoxColumn.Name = "dateDataGridViewTextBoxColumn";
			dateDataGridViewTextBoxColumn.ReadOnly = true;
			dateDataGridViewTextBoxColumn.Width = 80;
			// 
			// priorityDataGridViewTextBoxColumn
			// 
			priorityDataGridViewTextBoxColumn.DataPropertyName = "Priority";
			priorityDataGridViewTextBoxColumn.HeaderText = "Приоритет";
			priorityDataGridViewTextBoxColumn.Name = "priorityDataGridViewTextBoxColumn";
			priorityDataGridViewTextBoxColumn.ReadOnly = true;
			priorityDataGridViewTextBoxColumn.Width = 80;
			// 
			// statusDataGridViewCheckBoxColumn
			// 
			statusDataGridViewCheckBoxColumn.DataPropertyName = "Status";
			statusDataGridViewCheckBoxColumn.FillWeight = 80F;
			statusDataGridViewCheckBoxColumn.HeaderText = "Статус";
			statusDataGridViewCheckBoxColumn.Name = "statusDataGridViewCheckBoxColumn";
			statusDataGridViewCheckBoxColumn.ReadOnly = true;
			statusDataGridViewCheckBoxColumn.Width = 80;
			// 
			// DO
			// 
			DO.HeaderText = "Действие";
			DO.Name = "DO";
			DO.Text = "Редактировать";
			DO.UseColumnTextForButtonValue = true;
			// 
			// tasksBindingSource
			// 
			tasksBindingSource.DataSource = typeof(Task);
			// 
			// dataBaseBindingSource
			// 
			dataBaseBindingSource.DataSource = typeof(DataBase);
			// 
			// Done
			// 
			Done.AutoSize = true;
			Done.Location = new Point(12, 431);
			Done.Name = "Done";
			Done.Size = new Size(104, 15);
			Done.TabIndex = 3;
			Done.Text = "Выполнено задач";
			// 
			// P0
			// 
			P0.AutoSize = true;
			P0.Location = new Point(412, 431);
			P0.Name = "P0";
			P0.Size = new Size(104, 15);
			P0.TabIndex = 4;
			P0.Text = "Выполнено задач";
			// 
			// P1
			// 
			P1.AutoSize = true;
			P1.Location = new Point(677, 431);
			P1.Name = "P1";
			P1.Size = new Size(104, 15);
			P1.TabIndex = 5;
			P1.Text = "Выполнено задач";
			// 
			// P2
			// 
			P2.AutoSize = true;
			P2.Location = new Point(910, 431);
			P2.Name = "P2";
			P2.Size = new Size(104, 15);
			P2.TabIndex = 6;
			P2.Text = "Выполнено задач";
			// 
			// DOING
			// 
			DOING.AutoSize = true;
			DOING.Location = new Point(167, 431);
			DOING.Name = "DOING";
			DOING.Size = new Size(104, 15);
			DOING.TabIndex = 7;
			DOING.Text = "Выполнено задач";
			// 
			// MainForm
			// 
			AutoScaleDimensions = new SizeF(7F, 15F);
			AutoScaleMode = AutoScaleMode.Font;
			ClientSize = new Size(1255, 474);
			Controls.Add(DOING);
			Controls.Add(P2);
			Controls.Add(P1);
			Controls.Add(P0);
			Controls.Add(Done);
			Controls.Add(dataGridView1);
			Controls.Add(groupBox1);
			Controls.Add(currentName);
			Name = "MainForm";
			Text = "TaskManager";
			Load += MainForm_Load;
			groupBox1.ResumeLayout(false);
			groupBox1.PerformLayout();
			((System.ComponentModel.ISupportInitialize)dataGridView1).EndInit();
			((System.ComponentModel.ISupportInitialize)tasksBindingSource).EndInit();
			((System.ComponentModel.ISupportInitialize)dataBaseBindingSource).EndInit();
			ResumeLayout(false);
			PerformLayout();
		}

		#endregion

		private OpenFileDialog openFileDialog1;
		private Label currentName;
		private GroupBox groupBox1;
		private ComboBox SelectUser;
		private Button deleteUser;
		private Label label1;
		private Button changeRW;
		private Label label2;
		private TextBox Password;
		private TextBox login;
		private Label label3;
		private Button addUser;
		private RadioButton radioButton2;
		private RadioButton radioButton1;
		private DataGridView dataGridView1;
		private BindingSource dataBaseBindingSource;
		private BindingSource tasksBindingSource;
		private DataGridViewTextBoxColumn idDataGridViewTextBoxColumn;
		private DataGridViewTextBoxColumn titleDataGridViewTextBoxColumn;
		private DataGridViewTextBoxColumn descriptionDataGridViewTextBoxColumn;
		private DataGridViewTextBoxColumn dateDataGridViewTextBoxColumn;
		private DataGridViewTextBoxColumn priorityDataGridViewTextBoxColumn;
		private DataGridViewCheckBoxColumn statusDataGridViewCheckBoxColumn;
		private DataGridViewButtonColumn DO;
		private Label Done;
		private Label P0;
		private Label P1;
		private Label P2;
		private Label DOING;
	}
}