namespace AmApp.Pages
{
    partial class CreatePasport
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
            SplavList = new ComboBox();
            label4 = new Label();
            TekList = new ComboBox();
            label3 = new Label();
            SelectedMetal = new Label();
            SelectMetalBtn = new Button();
            CreatePasportBtn = new Button();
            CehList = new ComboBox();
            NpartValue = new TextBox();
            label2 = new Label();
            NplavValue = new TextBox();
            label1 = new Label();
            label = new Label();
            panel1.SuspendLayout();
            SuspendLayout();
            // 
            // panel1
            // 
            panel1.Controls.Add(SplavList);
            panel1.Controls.Add(label4);
            panel1.Controls.Add(TekList);
            panel1.Controls.Add(label3);
            panel1.Controls.Add(SelectedMetal);
            panel1.Controls.Add(SelectMetalBtn);
            panel1.Controls.Add(CreatePasportBtn);
            panel1.Controls.Add(CehList);
            panel1.Controls.Add(NpartValue);
            panel1.Controls.Add(label2);
            panel1.Controls.Add(NplavValue);
            panel1.Controls.Add(label1);
            panel1.Controls.Add(label);
            panel1.Dock = DockStyle.Fill;
            panel1.Location = new Point(0, 0);
            panel1.Name = "panel1";
            panel1.Size = new Size(272, 292);
            panel1.TabIndex = 0;
            // 
            // SplavList
            // 
            SplavList.FormattingEnabled = true;
            SplavList.Location = new Point(80, 126);
            SplavList.Name = "SplavList";
            SplavList.Size = new Size(180, 23);
            SplavList.TabIndex = 13;
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Location = new Point(12, 129);
            label4.Name = "label4";
            label4.Size = new Size(41, 15);
            label4.TabIndex = 12;
            label4.Text = "Сплав";
            // 
            // TekList
            // 
            TekList.FormattingEnabled = true;
            TekList.Location = new Point(80, 184);
            TekList.Name = "TekList";
            TekList.Size = new Size(180, 23);
            TekList.TabIndex = 11;
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Location = new Point(12, 187);
            label3.Name = "label3";
            label3.Size = new Size(37, 15);
            label3.TabIndex = 10;
            label3.Text = "Заказ";
            // 
            // SelectedMetal
            // 
            SelectedMetal.AutoSize = true;
            SelectedMetal.Location = new Point(53, 38);
            SelectedMetal.Name = "SelectedMetal";
            SelectedMetal.Size = new Size(77, 15);
            SelectedMetal.TabIndex = 9;
            SelectedMetal.Text = "Выбрано: {0}";
            // 
            // SelectMetalBtn
            // 
            SelectMetalBtn.Location = new Point(53, 12);
            SelectMetalBtn.Name = "SelectMetalBtn";
            SelectMetalBtn.Size = new Size(169, 23);
            SelectMetalBtn.TabIndex = 8;
            SelectMetalBtn.Text = "Выбрать металл";
            SelectMetalBtn.UseVisualStyleBackColor = true;
            SelectMetalBtn.Click += SelectMetalBtn_Click;
            // 
            // CreatePasportBtn
            // 
            CreatePasportBtn.Location = new Point(96, 257);
            CreatePasportBtn.Name = "CreatePasportBtn";
            CreatePasportBtn.Size = new Size(75, 23);
            CreatePasportBtn.TabIndex = 6;
            CreatePasportBtn.Text = "Создать";
            CreatePasportBtn.UseVisualStyleBackColor = true;
            CreatePasportBtn.Click += CreatePasportBtn_Click;
            // 
            // CehList
            // 
            CehList.FormattingEnabled = true;
            CehList.Location = new Point(80, 155);
            CehList.Name = "CehList";
            CehList.Size = new Size(180, 23);
            CehList.TabIndex = 1;
            CehList.SelectionChangeCommitted += CehList_SelectionChangeCommitted;
            // 
            // NpartValue
            // 
            NpartValue.Location = new Point(80, 97);
            NpartValue.Name = "NpartValue";
            NpartValue.Size = new Size(180, 23);
            NpartValue.TabIndex = 5;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(12, 100);
            label2.Name = "label2";
            label2.Size = new Size(62, 15);
            label2.TabIndex = 4;
            label2.Text = "№ партии";
            // 
            // NplavValue
            // 
            NplavValue.Location = new Point(80, 68);
            NplavValue.Name = "NplavValue";
            NplavValue.Size = new Size(180, 23);
            NplavValue.TabIndex = 3;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(12, 71);
            label1.Name = "label1";
            label1.Size = new Size(62, 15);
            label1.TabIndex = 2;
            label1.Text = "№ плавки";
            // 
            // label
            // 
            label.AutoSize = true;
            label.Location = new Point(12, 158);
            label.Name = "label";
            label.Size = new Size(28, 15);
            label.TabIndex = 0;
            label.Text = "Цех";
            // 
            // CreatePasport
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(272, 292);
            Controls.Add(panel1);
            Name = "CreatePasport";
            Text = "Создание паспорта";
            Load += CreatePasport_Load;
            panel1.ResumeLayout(false);
            panel1.PerformLayout();
            ResumeLayout(false);
        }

        #endregion

        private Panel panel1;
        private TextBox NpartValue;
        private Label label2;
        private TextBox NplavValue;
        private Label label1;
        private ComboBox CehList;
        private Label label;
        private Button CreatePasportBtn;
        private Label SelectedMetal;
        private Button SelectMetalBtn;
        private ComboBox TekList;
        private Label label3;
        private ComboBox SplavList;
        private Label label4;
    }
}