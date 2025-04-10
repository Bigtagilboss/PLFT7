namespace AmApp.Pages
{
    partial class OperationsForm
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
            groupBox2 = new GroupBox();
            panel6 = new Panel();
            OperList = new DataGridView();
            panel5 = new Panel();
            ClearOperation = new Button();
            EditorOperations = new Button();
            groupBox1 = new GroupBox();
            panel4 = new Panel();
            ZagotList = new DataGridView();
            panel3 = new Panel();
            OperWithoutRaskroy = new Button();
            SelectAllZags = new Button();
            panel1.SuspendLayout();
            groupBox2.SuspendLayout();
            panel6.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)OperList).BeginInit();
            panel5.SuspendLayout();
            groupBox1.SuspendLayout();
            panel4.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)ZagotList).BeginInit();
            panel3.SuspendLayout();
            SuspendLayout();
            // 
            // panel1
            // 
            panel1.Controls.Add(groupBox2);
            panel1.Controls.Add(groupBox1);
            panel1.Dock = DockStyle.Fill;
            panel1.Location = new Point(0, 0);
            panel1.Name = "panel1";
            panel1.Size = new Size(1028, 689);
            panel1.TabIndex = 0;
            // 
            // groupBox2
            // 
            groupBox2.Controls.Add(panel6);
            groupBox2.Controls.Add(panel5);
            groupBox2.Dock = DockStyle.Fill;
            groupBox2.Location = new Point(0, 195);
            groupBox2.Name = "groupBox2";
            groupBox2.Size = new Size(1028, 494);
            groupBox2.TabIndex = 4;
            groupBox2.TabStop = false;
            groupBox2.Text = "Операции";
            // 
            // panel6
            // 
            panel6.Controls.Add(OperList);
            panel6.Dock = DockStyle.Fill;
            panel6.Location = new Point(3, 19);
            panel6.Name = "panel6";
            panel6.Size = new Size(818, 472);
            panel6.TabIndex = 6;
            // 
            // OperList
            // 
            OperList.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
            OperList.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            OperList.Dock = DockStyle.Fill;
            OperList.Location = new Point(0, 0);
            OperList.Name = "OperList";
            OperList.Size = new Size(818, 472);
            OperList.TabIndex = 1;
            OperList.SelectionChanged += OperList_SelectionChanged;
            // 
            // panel5
            // 
            panel5.Controls.Add(ClearOperation);
            panel5.Controls.Add(EditorOperations);
            panel5.Dock = DockStyle.Right;
            panel5.Location = new Point(821, 19);
            panel5.Name = "panel5";
            panel5.Size = new Size(204, 472);
            panel5.TabIndex = 5;
            // 
            // ClearOperation
            // 
            ClearOperation.Dock = DockStyle.Top;
            ClearOperation.Enabled = false;
            ClearOperation.Location = new Point(0, 36);
            ClearOperation.Name = "ClearOperation";
            ClearOperation.Size = new Size(204, 36);
            ClearOperation.TabIndex = 2;
            ClearOperation.Text = "Очистить операцию";
            ClearOperation.UseVisualStyleBackColor = true;
            ClearOperation.Click += ClearOperation_Click;
            // 
            // EditorOperations
            // 
            EditorOperations.Dock = DockStyle.Top;
            EditorOperations.Enabled = false;
            EditorOperations.Location = new Point(0, 0);
            EditorOperations.Name = "EditorOperations";
            EditorOperations.Size = new Size(204, 36);
            EditorOperations.TabIndex = 1;
            EditorOperations.Text = "Заполнить операцию";
            EditorOperations.UseVisualStyleBackColor = true;
            EditorOperations.Click += EditorOperations_Click;
            // 
            // groupBox1
            // 
            groupBox1.Controls.Add(panel4);
            groupBox1.Controls.Add(panel3);
            groupBox1.Dock = DockStyle.Top;
            groupBox1.Location = new Point(0, 0);
            groupBox1.Name = "groupBox1";
            groupBox1.Size = new Size(1028, 195);
            groupBox1.TabIndex = 3;
            groupBox1.TabStop = false;
            groupBox1.Text = "Заготовки";
            // 
            // panel4
            // 
            panel4.Controls.Add(ZagotList);
            panel4.Dock = DockStyle.Fill;
            panel4.Location = new Point(3, 19);
            panel4.Name = "panel4";
            panel4.Size = new Size(818, 173);
            panel4.TabIndex = 4;
            // 
            // ZagotList
            // 
            ZagotList.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
            ZagotList.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            ZagotList.Dock = DockStyle.Fill;
            ZagotList.Location = new Point(0, 0);
            ZagotList.Name = "ZagotList";
            ZagotList.Size = new Size(818, 173);
            ZagotList.TabIndex = 0;
            ZagotList.SelectionChanged += ZagotList_SelectionChanged;
            // 
            // panel3
            // 
            panel3.Controls.Add(OperWithoutRaskroy);
            panel3.Controls.Add(SelectAllZags);
            panel3.Dock = DockStyle.Right;
            panel3.Location = new Point(821, 19);
            panel3.Name = "panel3";
            panel3.Size = new Size(204, 173);
            panel3.TabIndex = 3;
            // 
            // OperWithoutRaskroy
            // 
            OperWithoutRaskroy.Dock = DockStyle.Top;
            OperWithoutRaskroy.Enabled = false;
            OperWithoutRaskroy.Location = new Point(0, 36);
            OperWithoutRaskroy.Name = "OperWithoutRaskroy";
            OperWithoutRaskroy.Size = new Size(204, 36);
            OperWithoutRaskroy.TabIndex = 1;
            OperWithoutRaskroy.Text = "Операция без раскроя";
            OperWithoutRaskroy.UseVisualStyleBackColor = true;
            OperWithoutRaskroy.Click += OperWithoutRaskroy_Click;
            // 
            // SelectAllZags
            // 
            SelectAllZags.Dock = DockStyle.Top;
            SelectAllZags.Location = new Point(0, 0);
            SelectAllZags.Name = "SelectAllZags";
            SelectAllZags.Size = new Size(204, 36);
            SelectAllZags.TabIndex = 0;
            SelectAllZags.Text = "Выбрать все заготовки";
            SelectAllZags.UseVisualStyleBackColor = true;
            // 
            // OperationsForm
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(1028, 689);
            Controls.Add(panel1);
            Name = "OperationsForm";
            Text = "Операции на паспорте";
            Load += OperationsForm_Load;
            panel1.ResumeLayout(false);
            groupBox2.ResumeLayout(false);
            panel6.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)OperList).EndInit();
            panel5.ResumeLayout(false);
            groupBox1.ResumeLayout(false);
            panel4.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)ZagotList).EndInit();
            panel3.ResumeLayout(false);
            ResumeLayout(false);
        }

        #endregion

        private Panel panel1;
        private GroupBox groupBox2;
        private Panel panel5;
        private GroupBox groupBox1;
        private Panel panel4;
        private Panel panel3;
        private Panel panel6;
        private Button ClearOperation;
        private Button EditorOperations;
        private Button OperWithoutRaskroy;
        private Button SelectAllZags;
        private DataGridView OperList;
        private DataGridView ZagotList;
    }
}