using AmApp.Models.Identity;
using AmApp.Models.Main;
using AmApp.Repositories.SqlLite.Impl;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace AmApp.Pages
{
    public partial class CreatePasport : Form
    {
        private UserRole userRole { get; set; }
        private Pasport selectedPasport { get; set; }
        private MainImpl impl { get; set; }

        public CreatePasport(UserRole _userRole)
        {
            InitializeComponent();
            impl = new MainImpl();
            userRole = _userRole;
            impl.userRole = _userRole;
        }

        private void SelectMetalBtn_Click(object sender, EventArgs e)
        {
            var viewMetal = new ViewMetal();
            viewMetal.ShowDialog();

            selectedPasport = viewMetal.selectedPasport;

            SelectedMetal.Text = string.Format("Выбрано: {0}", selectedPasport?.Nplav??"0");
        }


        private List<Ceh> cehs;
        private List<Tek> teks;
        private List<Splav> splavs;

        private Pasport selectedCeh { get; set; }
        private Pasport selectedTek { get; set; }
        private Pasport selectedSplav { get; set; }

        private void CreatePasport_Load(object sender, EventArgs e)
        {
            cehs = impl.GetCeh();
            CehList.DataSource = cehs;
            CehList.ValueMember = "Id";
            CehList.DisplayMember = "Name";

            teks = impl.GetTeks(cehs?.FirstOrDefault()?.Id);
            TekList.DataSource = teks;
            TekList.ValueMember = "Id";
            TekList.DisplayMember = "Code";

            splavs = impl.GetSplavs();
            SplavList.DataSource = splavs;
            SplavList.ValueMember = "Id";
            SplavList.DisplayMember = "Name";

            NplavValue.Text = impl.GetNplav(cehs.FirstOrDefault().Name);
        }

        private void CreatePasportBtn_Click(object sender, EventArgs e)
        {
            if (selectedPasport == null)
            {
                MessageBox.Show("Паспорт будет для первичной плавки");
            }
            if (string.IsNullOrWhiteSpace(NpartValue.Text) || string.IsNullOrWhiteSpace(NplavValue.Text))
            {
                MessageBox.Show("Пустые поля для заполнения");
            }
            else
            {
                string? check = null;
                var pasport = new Pasport
                {
                    Nplav = NplavValue.Text,
                    Npart = NpartValue.Text,
                    SplavId = (string)SplavList.SelectedValue,
                    CehId = (string)CehList.SelectedValue,
                    TekId = (string)TekList.SelectedValue,
                    ParentPasportId = selectedPasport?.Id
                };
                try
                {
                    check = impl.CreatePasport(pasport);
                }
                catch (Exception ex)
                {
                    check = ex.Message;
                }


                if (string.IsNullOrWhiteSpace(check))
                {
                    MessageBox.Show("Успешное создание паспорта");
                    this.Hide();
                }
                else
                {
                    MessageBox.Show("Создание паспорта с ошибкой. \n"+check);
                }
            }
        }

        private void CehList_SelectionChangeCommitted(object sender, EventArgs e)
        {
            NplavValue.Text = NplavValue.Text.Replace(CehList.SelectedText, ((Ceh)CehList.SelectedItem).Name);

            teks = impl.GetTeks(((Ceh)CehList.SelectedItem).Id);
            TekList.DataSource = teks;
            TekList.ValueMember = "Id";
            TekList.DisplayMember = "Code";
        }
    }
}
