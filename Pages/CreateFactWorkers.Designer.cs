namespace AmApp.Pages
{
    partial class CreateFactWorkers
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
            panel1 = new Panel();
            Ok = new Button();
            Back = new Button();
            Next = new Button();
            UsersList = new DataGridView();
            OborudList = new DataGridView();
            panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)UsersList).BeginInit();
            ((System.ComponentModel.ISupportInitialize)OborudList).BeginInit();
            SuspendLayout();
            // 
            // panel1
            // 
            panel1.Controls.Add(Ok);
            panel1.Controls.Add(Back);
            panel1.Controls.Add(Next);
            panel1.Dock = DockStyle.Bottom;
            panel1.Location = new Point(0, 364);
            panel1.Name = "panel1";
            panel1.Size = new Size(616, 41);
            panel1.TabIndex = 0;
            // 
            // Ok
            // 
            Ok.Enabled = false;
            Ok.Location = new Point(12, 9);
            Ok.Name = "Ok";
            Ok.Size = new Size(75, 23);
            Ok.TabIndex = 2;
            Ok.Text = "Создать";
            Ok.UseVisualStyleBackColor = true;
            Ok.Click += Ok_Click;
            // 
            // Back
            // 
            Back.Enabled = false;
            Back.Location = new Point(448, 9);
            Back.Name = "Back";
            Back.Size = new Size(75, 23);
            Back.TabIndex = 1;
            Back.Text = "Назад";
            Back.UseVisualStyleBackColor = true;
            Back.Click += Back_Click;
            // 
            // Next
            // 
            Next.Enabled = false;
            Next.Location = new Point(529, 9);
            Next.Name = "Next";
            Next.Size = new Size(75, 23);
            Next.TabIndex = 0;
            Next.Text = "Далее";
            Next.UseVisualStyleBackColor = true;
            Next.Click += Next_Click;
            // 
            // UsersList
            // 
            UsersList.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
            UsersList.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            UsersList.Dock = DockStyle.Fill;
            UsersList.Location = new Point(0, 0);
            UsersList.Name = "UsersList";
            UsersList.Size = new Size(616, 364);
            UsersList.TabIndex = 1;
            UsersList.Visible = false;
            UsersList.SelectionChanged += UsersList_SelectionChanged;
            // 
            // OborudList
            // 
            OborudList.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
            OborudList.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            OborudList.Dock = DockStyle.Fill;
            OborudList.Location = new Point(0, 0);
            OborudList.Name = "OborudList";
            OborudList.Size = new Size(616, 364);
            OborudList.TabIndex = 2;
            OborudList.Visible = false;
            OborudList.SelectionChanged += OborudList_SelectionChanged;
            // 
            // CreateFactWorkers
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(616, 405);
            Controls.Add(OborudList);
            Controls.Add(UsersList);
            Controls.Add(panel1);
            Name = "CreateFactWorkers";
            Text = "Выбор рабочего и оборудования";
            Load += CreateFactWorkers_Load;
            panel1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)UsersList).EndInit();
            ((System.ComponentModel.ISupportInitialize)OborudList).EndInit();
            ResumeLayout(false);
        }

        #endregion

        private Panel panel1;
        private Button Ok;
        private Button Back;
        private Button Next;
        private DataGridView UsersList;
        private DataGridView OborudList;
    }
}