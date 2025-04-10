namespace AmApp.Pages
{
    partial class ViewMetal
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
            panel2 = new Panel();
            SelectMetal = new Button();
            PasportsGrid = new DataGridView();
            FilterPanel = new Panel();
            SearchPasports = new Button();
            NpartValue = new TextBox();
            label2 = new Label();
            NplavValue = new TextBox();
            label1 = new Label();
            CehList = new ComboBox();
            label = new Label();
            panel1.SuspendLayout();
            panel2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)PasportsGrid).BeginInit();
            FilterPanel.SuspendLayout();
            SuspendLayout();
            // 
            // panel1
            // 
            panel1.Controls.Add(panel2);
            panel1.Controls.Add(PasportsGrid);
            panel1.Controls.Add(FilterPanel);
            panel1.Dock = DockStyle.Fill;
            panel1.Location = new Point(0, 0);
            panel1.Name = "panel1";
            panel1.Size = new Size(528, 520);
            panel1.TabIndex = 0;
            // 
            // panel2
            // 
            panel2.Controls.Add(SelectMetal);
            panel2.Dock = DockStyle.Bottom;
            panel2.Location = new Point(0, 488);
            panel2.Name = "panel2";
            panel2.Size = new Size(528, 32);
            panel2.TabIndex = 5;
            // 
            // SelectMetal
            // 
            SelectMetal.Location = new Point(6, 5);
            SelectMetal.Name = "SelectMetal";
            SelectMetal.Size = new Size(75, 23);
            SelectMetal.TabIndex = 0;
            SelectMetal.Text = "Выбрать";
            SelectMetal.UseVisualStyleBackColor = true;
            SelectMetal.Click += SelectMetal_Click;
            // 
            // PasportsGrid
            // 
            PasportsGrid.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            PasportsGrid.Dock = DockStyle.Fill;
            PasportsGrid.Location = new Point(0, 30);
            PasportsGrid.Name = "PasportsGrid";
            PasportsGrid.Size = new Size(528, 490);
            PasportsGrid.TabIndex = 4;
            // 
            // FilterPanel
            // 
            FilterPanel.Controls.Add(SearchPasports);
            FilterPanel.Controls.Add(NpartValue);
            FilterPanel.Controls.Add(label2);
            FilterPanel.Controls.Add(NplavValue);
            FilterPanel.Controls.Add(label1);
            FilterPanel.Controls.Add(CehList);
            FilterPanel.Controls.Add(label);
            FilterPanel.Dock = DockStyle.Top;
            FilterPanel.Location = new Point(0, 0);
            FilterPanel.Name = "FilterPanel";
            FilterPanel.Size = new Size(528, 30);
            FilterPanel.TabIndex = 3;
            // 
            // SearchPasports
            // 
            SearchPasports.Location = new Point(461, 3);
            SearchPasports.Name = "SearchPasports";
            SearchPasports.Size = new Size(57, 23);
            SearchPasports.TabIndex = 6;
            SearchPasports.Text = "поиск";
            SearchPasports.UseVisualStyleBackColor = true;
            SearchPasports.Click += SearchPasports_Click;
            // 
            // NpartValue
            // 
            NpartValue.Location = new Point(355, 3);
            NpartValue.Name = "NpartValue";
            NpartValue.Size = new Size(100, 23);
            NpartValue.TabIndex = 5;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(287, 6);
            label2.Name = "label2";
            label2.Size = new Size(62, 15);
            label2.TabIndex = 4;
            label2.Text = "№ партии";
            // 
            // NplavValue
            // 
            NplavValue.Location = new Point(181, 3);
            NplavValue.Name = "NplavValue";
            NplavValue.Size = new Size(100, 23);
            NplavValue.TabIndex = 3;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(113, 6);
            label1.Name = "label1";
            label1.Size = new Size(62, 15);
            label1.TabIndex = 2;
            label1.Text = "№ плавки";
            // 
            // CehList
            // 
            CehList.FormattingEnabled = true;
            CehList.Location = new Point(43, 3);
            CehList.Name = "CehList";
            CehList.Size = new Size(64, 23);
            CehList.TabIndex = 1;
            // 
            // label
            // 
            label.AutoSize = true;
            label.Location = new Point(9, 6);
            label.Name = "label";
            label.Size = new Size(28, 15);
            label.TabIndex = 0;
            label.Text = "Цех";
            // 
            // ViewMetal
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(528, 520);
            Controls.Add(panel1);
            Name = "ViewMetal";
            Text = "Выбор металла";
            Load += ViewMetal_Load;
            panel1.ResumeLayout(false);
            panel2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)PasportsGrid).EndInit();
            FilterPanel.ResumeLayout(false);
            FilterPanel.PerformLayout();
            ResumeLayout(false);
        }

        #endregion

        private Panel panel1;
        private Panel FilterPanel;
        private Button SearchPasports;
        private TextBox NpartValue;
        private Label label2;
        private TextBox NplavValue;
        private Label label1;
        private ComboBox CehList;
        private Label label;
        private Panel panel2;
        private Button SelectMetal;
        private DataGridView PasportsGrid;
    }
}