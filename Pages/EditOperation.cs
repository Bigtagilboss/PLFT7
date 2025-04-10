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
    public partial class EditOperation : Form
    {
        private UserRole userRole { get; set; }
        private Operation selectedOper { get; set; }
        private MainImpl impl { get; set; }
        List<OperRashod> Rashod;
        List<FactZagot> Fact;

        public EditOperation(UserRole _userRole, Operation _selectedOper)
        {
            InitializeComponent();

            userRole = _userRole;
            selectedOper = _selectedOper;
            impl = new MainImpl();
            impl.userRole = _userRole;

            InZagots.SelectionMode = DataGridViewSelectionMode.FullRowSelect;
            InZagots.MultiSelect = false;
            InZagots.ReadOnly = true;
            InZagots.AllowUserToAddRows = false;
            InZagots.AllowUserToDeleteRows = false;
            InZagots.AllowUserToResizeRows = false;

            OutZagots.SelectionMode = DataGridViewSelectionMode.FullRowSelect;
            OutZagots.MultiSelect = false;
            OutZagots.ReadOnly = true;
            OutZagots.AllowUserToAddRows = false;
            OutZagots.AllowUserToDeleteRows = false;
            OutZagots.AllowUserToResizeRows = false;
        }

        private void EditOperation_Load(object sender, EventArgs e)
        {
            Rashod = impl.GetOperRashod(selectedOper);
            Fact = impl.GetFactZagot(selectedOper);


            UpdateRashod(Rashod);
            UpdateFact(Fact);
        }
        List<FactWorker> workers;
        private void UpdateRashod(List<OperRashod> _operRashods)
        {
            try
            {
                workers = new List<FactWorker>();
                foreach (var o in _operRashods)
                {
                    workers.AddRange(o.factWorkers);
                }

                InZagots.DataSource = workers;
                InZagots.Columns["FIO"].HeaderText = "Рабочий";
                InZagots.Columns["OborudName"].HeaderText = "Оборудование";
                InZagots.Columns["DateCreate"].HeaderText = "Дата создания";
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        private void UpdateFact(List<FactZagot> _factZagots)
        {
            try
            {
                List<Zagot> zagots = new List<Zagot>();

                foreach (var o in _factZagots)
                {
                    foreach (var item in o.zagots)
                    {
                        zagots.Add(item.zagots);
                    }
                }

                OutZagots.DataSource = zagots;
                OutZagots.Columns["LastOperName"].Visible = false;
                OutZagots.Columns["Number"].HeaderText = "Номер заготовки на выходе";
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }


        private void SelectWorker_Click_1(object sender, EventArgs e)
        {
            try
            {
                var CreateFactWorkers = new CreateFactWorkers(userRole, selectedRashod, selectedOper);
                CreateFactWorkers.ShowDialog();
                if (CreateFactWorkers.Result != null)
                {
                    impl.CreateFactWorker(CreateFactWorkers.Result);

                    Rashod = impl.GetOperRashod(selectedOper);
                    Fact = impl.GetFactZagot(selectedOper);

                    UpdateRashod(Rashod);
                    UpdateFact(Fact);

                    MessageBox.Show("Успешно!");
                }
                else
                {
                    throw new Exception("Ничего не выбрано!");
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }
        FactWorker selectedRashod;
        private void InZagots_SelectionChanged(object sender, EventArgs e)
        {
            if (((DataGridView)sender).SelectedRows.Count != 0)
            {
                var selectedIndex = ((DataGridView)sender).SelectedRows[0].Index;

                selectedRashod = workers[selectedIndex];
                var state = selectedRashod != null;

                DeleteRow.Enabled = state;
            }
        }

        private void DeleteRow_Click(object sender, EventArgs e)
        {
            try
            {
                impl.DeleteFactWorker(selectedRashod);

                Rashod = impl.GetOperRashod(selectedOper);
                Fact = impl.GetFactZagot(selectedOper);

                UpdateRashod(Rashod);
                UpdateFact(Fact);

                MessageBox.Show("Успешно!");
            }
            catch(Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }
    }
}
