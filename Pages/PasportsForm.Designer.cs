namespace AmApp.Pages
{
    partial class PasportsForm
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
            components = new System.ComponentModel.Container();
            InfoPanel = new Panel();
            UserImage = new PictureBox();
            UserInfo = new Label();
            MainPanel = new Panel();
            PasportsGrid = new DataGridView();
            PasportContextMenu = new ContextMenuStrip(components);
            маршрутЗаготовкиНаПаспортеToolStripMenuItem = new ToolStripMenuItem();
            FilterPanel = new Panel();
            SearchPasports = new Button();
            NpartValue = new TextBox();
            label2 = new Label();
            NplavValue = new TextBox();
            label1 = new Label();
            CehList = new ComboBox();
            label = new Label();
            BtnMenu = new Panel();
            PasportOpers = new Button();
            CreatePasport = new Button();
            InfoPanel.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)UserImage).BeginInit();
            MainPanel.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)PasportsGrid).BeginInit();
            PasportContextMenu.SuspendLayout();
            FilterPanel.SuspendLayout();
            BtnMenu.SuspendLayout();
            SuspendLayout();
            // 
            // InfoPanel
            // 
            InfoPanel.BackColor = SystemColors.ControlLight;
            InfoPanel.Controls.Add(UserImage);
            InfoPanel.Controls.Add(UserInfo);
            InfoPanel.Dock = DockStyle.Bottom;
            InfoPanel.Location = new Point(0, 605);
            InfoPanel.Name = "InfoPanel";
            InfoPanel.Size = new Size(1014, 47);
            InfoPanel.TabIndex = 0;
            // 
            // UserImage
            // 
            UserImage.BorderStyle = BorderStyle.FixedSingle;
            UserImage.Location = new Point(3, 5);
            UserImage.Name = "UserImage";
            UserImage.Size = new Size(39, 39);
            UserImage.SizeMode = PictureBoxSizeMode.Zoom;
            UserImage.TabIndex = 1;
            UserImage.TabStop = false;
            // 
            // UserInfo
            // 
            UserInfo.AutoSize = true;
            UserInfo.Location = new Point(48, 25);
            UserInfo.Name = "UserInfo";
            UserInfo.Size = new Size(96, 15);
            UserInfo.TabIndex = 0;
            UserInfo.Text = "User: {0} Role: {1}";
            // 
            // MainPanel
            // 
            MainPanel.Controls.Add(PasportsGrid);
            MainPanel.Controls.Add(FilterPanel);
            MainPanel.Controls.Add(BtnMenu);
            MainPanel.Controls.Add(InfoPanel);
            MainPanel.Dock = DockStyle.Fill;
            MainPanel.Location = new Point(0, 0);
            MainPanel.Name = "MainPanel";
            MainPanel.Size = new Size(1014, 652);
            MainPanel.TabIndex = 1;
            // 
            // PasportsGrid
            // 
            PasportsGrid.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
            PasportsGrid.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            PasportsGrid.ContextMenuStrip = PasportContextMenu;
            PasportsGrid.Dock = DockStyle.Fill;
            PasportsGrid.Location = new Point(0, 75);
            PasportsGrid.Name = "PasportsGrid";
            PasportsGrid.Size = new Size(1014, 530);
            PasportsGrid.TabIndex = 3;
            PasportsGrid.SelectionChanged += PasportsGrid_SelectionChanged;
            // 
            // PasportContextMenu
            // 
            PasportContextMenu.Items.AddRange(new ToolStripItem[] { маршрутЗаготовкиНаПаспортеToolStripMenuItem });
            PasportContextMenu.Name = "PasportContextMenu";
            PasportContextMenu.Size = new Size(255, 26);
            // 
            // маршрутЗаготовкиНаПаспортеToolStripMenuItem
            // 
            маршрутЗаготовкиНаПаспортеToolStripMenuItem.Name = "маршрутЗаготовкиНаПаспортеToolStripMenuItem";
            маршрутЗаготовкиНаПаспортеToolStripMenuItem.Size = new Size(254, 22);
            маршрутЗаготовкиНаПаспортеToolStripMenuItem.Text = "Маршрут заготовки на паспорте";
            маршрутЗаготовкиНаПаспортеToolStripMenuItem.Click += маршрутЗаготовкиНаПаспортеToolStripMenuItem_Click;
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
            FilterPanel.Location = new Point(0, 45);
            FilterPanel.Name = "FilterPanel";
            FilterPanel.Size = new Size(1014, 30);
            FilterPanel.TabIndex = 2;
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
            // BtnMenu
            // 
            BtnMenu.BackColor = SystemColors.ControlLight;
            BtnMenu.Controls.Add(PasportOpers);
            BtnMenu.Controls.Add(CreatePasport);
            BtnMenu.Dock = DockStyle.Top;
            BtnMenu.Location = new Point(0, 0);
            BtnMenu.Name = "BtnMenu";
            BtnMenu.Size = new Size(1014, 45);
            BtnMenu.TabIndex = 0;
            // 
            // PasportOpers
            // 
            PasportOpers.Dock = DockStyle.Left;
            PasportOpers.Location = new Point(125, 0);
            PasportOpers.Name = "PasportOpers";
            PasportOpers.Size = new Size(172, 45);
            PasportOpers.TabIndex = 1;
            PasportOpers.Text = "Операции на паспорте";
            PasportOpers.UseVisualStyleBackColor = true;
            PasportOpers.Click += PasportOpers_Click;
            // 
            // CreatePasport
            // 
            CreatePasport.Dock = DockStyle.Left;
            CreatePasport.Location = new Point(0, 0);
            CreatePasport.Name = "CreatePasport";
            CreatePasport.Size = new Size(125, 45);
            CreatePasport.TabIndex = 0;
            CreatePasport.Text = "Создать паспорт";
            CreatePasport.UseVisualStyleBackColor = true;
            CreatePasport.Click += CreatePasport_Click;
            // 
            // PasportsForm
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(1014, 652);
            Controls.Add(MainPanel);
            Name = "PasportsForm";
            Text = "Паспорта";
            Load += PasportsForm_Load;
            InfoPanel.ResumeLayout(false);
            InfoPanel.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)UserImage).EndInit();
            MainPanel.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)PasportsGrid).EndInit();
            PasportContextMenu.ResumeLayout(false);
            FilterPanel.ResumeLayout(false);
            FilterPanel.PerformLayout();
            BtnMenu.ResumeLayout(false);
            ResumeLayout(false);
        }

        #endregion

        private Panel InfoPanel;
        private Label UserInfo;
        private Panel MainPanel;
        private Panel BtnMenu;
        private Button PasportOpers;
        private Button CreatePasport;
        private PictureBox UserImage;
        private Panel FilterPanel;
        private Button SearchPasports;
        private TextBox NpartValue;
        private Label label2;
        private TextBox NplavValue;
        private Label label1;
        private ComboBox CehList;
        private Label label;
        private DataGridView PasportsGrid;
        private ContextMenuStrip PasportContextMenu;
        private ToolStripMenuItem маршрутЗаготовкиНаПаспортеToolStripMenuItem;
    }
}