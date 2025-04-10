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
    public partial class ViewMetal : Form
    {
        private MainImpl impl { get; set; }
        public Pasport selectedPasport { get; set; }
        private List<Pasport> pasports;

        public ViewMetal()
        {
            InitializeComponent();
            impl = new MainImpl();

            PasportsGrid.SelectionMode = DataGridViewSelectionMode.FullRowSelect;
            PasportsGrid.MultiSelect = false;
            PasportsGrid.ReadOnly = true;
            PasportsGrid.AllowUserToAddRows = false;
            PasportsGrid.AllowUserToDeleteRows = false;
            PasportsGrid.AllowUserToResizeRows = false;
        }

        private void ViewMetal_Load(object sender, EventArgs e)
        {
            try
            {
                var cehs = impl.GetCeh();
                CehList.DataSource = cehs;
                CehList.ValueMember = "Id";
                CehList.DisplayMember = "Name";


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

        private void SelectMetal_Click(object sender, EventArgs e)
        {
            if (PasportsGrid.SelectedRows.Count != 0)
            {
                selectedPasport = pasports[PasportsGrid.SelectedRows[0].Index];
                this.Close();
            }
            else
            {
                MessageBox.Show("Ничего не выбрано");
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
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }
    }
}
