namespace AmApp.Pages
{
    partial class EditOperation
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
            panel4 = new Panel();
            groupBox2 = new GroupBox();
            OutZagots = new DataGridView();
            panel3 = new Panel();
            groupBox1 = new GroupBox();
            InZagots = new DataGridView();
            panel2 = new Panel();
            DeleteRow = new Button();
            SelectWorker = new Button();
            panel1.SuspendLayout();
            panel4.SuspendLayout();
            groupBox2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)OutZagots).BeginInit();
            panel3.SuspendLayout();
            groupBox1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)InZagots).BeginInit();
            panel2.SuspendLayout();
            SuspendLayout();
            // 
            // panel1
            // 
            panel1.Controls.Add(panel4);
            panel1.Controls.Add(panel3);
            panel1.Dock = DockStyle.Fill;
            panel1.Location = new Point(0, 0);
            panel1.Name = "panel1";
            panel1.Size = new Size(800, 450);
            panel1.TabIndex = 0;
            // 
            // panel4
            // 
            panel4.Controls.Add(groupBox2);
            panel4.Dock = DockStyle.Fill;
            panel4.Location = new Point(0, 209);
            panel4.Name = "panel4";
            panel4.Size = new Size(800, 241);
            panel4.TabIndex = 3;
            // 
            // groupBox2
            // 
            groupBox2.Controls.Add(OutZagots);
            groupBox2.Dock = DockStyle.Fill;
            groupBox2.Location = new Point(0, 0);
            groupBox2.Name = "groupBox2";
            groupBox2.Size = new Size(800, 241);
            groupBox2.TabIndex = 7;
            groupBox2.TabStop = false;
            groupBox2.Text = "На выходе";
            // 
            // OutZagots
            // 
            OutZagots.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
            OutZagots.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            OutZagots.Dock = DockStyle.Fill;
            OutZagots.Location = new Point(3, 19);
            OutZagots.Name = "OutZagots";
            OutZagots.Size = new Size(794, 219);
            OutZagots.TabIndex = 5;
            // 
            // panel3
            // 
            panel3.Controls.Add(groupBox1);
            panel3.Controls.Add(panel2);
            panel3.Dock = DockStyle.Top;
            panel3.Location = new Point(0, 0);
            panel3.Name = "panel3";
            panel3.Size = new Size(800, 209);
            panel3.TabIndex = 1;
            // 
            // groupBox1
            // 
            groupBox1.Controls.Add(InZagots);
            groupBox1.Dock = DockStyle.Fill;
            groupBox1.Location = new Point(0, 0);
            groupBox1.Name = "groupBox1";
            groupBox1.Size = new Size(586, 209);
            groupBox1.TabIndex = 5;
            groupBox1.TabStop = false;
            groupBox1.Text = "На операции";
            // 
            // InZagots
            // 
            InZagots.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
            InZagots.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            InZagots.Dock = DockStyle.Fill;
            InZagots.Location = new Point(3, 19);
            InZagots.Name = "InZagots";
            InZagots.Size = new Size(580, 187);
            InZagots.TabIndex = 4;
            InZagots.SelectionChanged += InZagots_SelectionChanged;
            // 
            // panel2
            // 
            panel2.Controls.Add(DeleteRow);
            panel2.Controls.Add(SelectWorker);
            panel2.Dock = DockStyle.Right;
            panel2.Location = new Point(586, 0);
            panel2.Name = "panel2";
            panel2.Size = new Size(214, 209);
            panel2.TabIndex = 3;
            // 
            // DeleteRow
            // 
            DeleteRow.Dock = DockStyle.Top;
            DeleteRow.Location = new Point(0, 32);
            DeleteRow.Name = "DeleteRow";
            DeleteRow.Size = new Size(214, 32);
            DeleteRow.TabIndex = 1;
            DeleteRow.Text = "Удалить";
            DeleteRow.UseVisualStyleBackColor = true;
            DeleteRow.Click += DeleteRow_Click;
            // 
            // SelectWorker
            // 
            SelectWorker.Dock = DockStyle.Top;
            SelectWorker.Location = new Point(0, 0);
            SelectWorker.Name = "SelectWorker";
            SelectWorker.Size = new Size(214, 32);
            SelectWorker.TabIndex = 0;
            SelectWorker.Text = "Выбор исполнителя";
            SelectWorker.UseVisualStyleBackColor = true;
            SelectWorker.Click += SelectWorker_Click_1;
            // 
            // EditOperation
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(800, 450);
            Controls.Add(panel1);
            Name = "EditOperation";
            Text = "Редактирование операции";
            Load += EditOperation_Load;
            panel1.ResumeLayout(false);
            panel4.ResumeLayout(false);
            groupBox2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)OutZagots).EndInit();
            panel3.ResumeLayout(false);
            groupBox1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)InZagots).EndInit();
            panel2.ResumeLayout(false);
            ResumeLayout(false);
        }

        #endregion

        private Panel panel1;
        private Panel panel3;
        private Panel panel4;
        private GroupBox groupBox2;
        private DataGridView OutZagots;
        private GroupBox groupBox1;
        private DataGridView InZagots;
        private Panel panel2;
        private Button SelectWorker;
        private Button DeleteRow;
    }
}