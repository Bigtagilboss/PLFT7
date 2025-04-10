using AmApp.Models.Identity;
using AmApp.Models.Main;
using AmApp.Repositories.SqlLite.Impl;

namespace AmApp.Pages
{
    public partial class PasportsForm : Form
    {
        private User user { get; set; }
        private UserRole userRole { get; set; }
        private List<Pasport> pasports { get; set; }
        private Pasport selectedPasport { get; set; }
        private MainImpl impl { get; set; }

        public PasportsForm(User _user)
        {
            InitializeComponent();

            user = _user;
            impl = new MainImpl();

            PasportsGrid.SelectionMode = DataGridViewSelectionMode.FullRowSelect;
            PasportsGrid.MultiSelect = false;
            PasportsGrid.ReadOnly = true;
            PasportsGrid.AllowUserToAddRows = false;
            PasportsGrid.AllowUserToDeleteRows = false;
            PasportsGrid.AllowUserToResizeRows = false;
        }

        private void PasportsForm_Load(object sender, EventArgs e)
        {

            try
            {
                var cehs = new List<Ceh>() { new Ceh { Id = "" } };
                cehs.AddRange(impl.GetCeh());
                CehList.DataSource = cehs;
                CehList.ValueMember = "Id";
                CehList.DisplayMember = "Name";

                userRole = impl.GetUserData(user);
                UserInfo.Text = string.Format("User: {0} Role: {1}", user.FIO, userRole.Role.Name);
                byte[] imageBytes = Convert.FromBase64String(user.Image);
                using (var ms = new MemoryStream(imageBytes, 0, imageBytes.Length))
                {
                    UserImage.Image = Image.FromStream(ms, true);
                }

                pasports = impl.GetPasports(new Pasport
                {
                    Nplav = "",
                    Npart = "",
                    CehId = (string)CehList.SelectedValue
                });
                DrawPasport(pasports);
            }
            catch (Exception ex)
            {
                pasports = new List<Pasport>();
                MessageBox.Show(ex.Message);
            }

        }


        private void DrawPasport(List<Pasport> _pasports)
        {
            try
            {
                PasportsGrid.DataSource = _pasports;
                PasportsGrid.Columns["Ceh"].HeaderText = "Цех";
                PasportsGrid.Columns["Nplav"].HeaderText = "№ Плавки";
                PasportsGrid.Columns["Npart"].HeaderText = "№ Партии";
                PasportsGrid.Columns["DateCreate"].HeaderText = "Дата создания";
                PasportsGrid.Columns["DateClose"].HeaderText = "Дата закрытия";
                PasportsGrid.Columns["Splav"].HeaderText = "Сплав";
                PasportsGrid.Columns["TekCode"].HeaderText = "Код заказа";
                PasportsGrid.Columns["UserName"].HeaderText = "Создатель";
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        private void SearchPasports_Click(object sender, EventArgs e)
        {
            try
            {
                pasports = impl.GetPasports(new Pasport
                {
                    Nplav = NplavValue.Text,
                    Npart = NpartValue.Text,
                    CehId = (string)CehList.SelectedValue
                });
            }
            catch (Exception ex)
            {
                pasports = new List<Pasport>();
                MessageBox.Show(ex.Message);
            }

            DrawPasport(pasports);
        }

        private void CreatePasport_Click(object sender, EventArgs e)
        {
            var createPasport = new CreatePasport(userRole);

            createPasport.ShowDialog();

            try
            {
                pasports = impl.GetPasports(new Pasport
                {
                    Nplav = NplavValue.Text,
                    Npart = NpartValue.Text,
                    CehId = (string)CehList.SelectedValue
                });
            }
            catch (Exception ex)
            {
                pasports = new List<Pasport>();
                MessageBox.Show(ex.Message);
            }

            DrawPasport(pasports);
        }

        private void PasportOpers_Click(object sender, EventArgs e)
        {
            if (selectedPasport != null)
            {
                var operationsForm = new OperationsForm(userRole, selectedPasport);
                this.Hide();
                operationsForm.FormClosed += (s, args) => this.Show();
                operationsForm.Show();
            }
            else
            {
                MessageBox.Show("Паспорт не выбран");
            }

        }

        private void PasportsGrid_SelectionChanged(object sender, EventArgs e)
        {
            if (((DataGridView)sender).SelectedRows.Count != 0)
            {
                var selectedIndex = ((DataGridView)sender).SelectedRows[0].Index;
                selectedPasport = pasports[selectedIndex];
            }
        }

        private void маршрутЗаготовкиНаПаспортеToolStripMenuItem_Click(object sender, EventArgs e)
        {

        }

        private void bindingSource1_CurrentChanged(object sender, EventArgs e)
        {

        }
    }
}
