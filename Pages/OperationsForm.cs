using AmApp.Models.Identity;
using AmApp.Models.Main;
using AmApp.Repositories.SqlLite.Impl;
using Microsoft.VisualBasic.ApplicationServices;
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
    public partial class OperationsForm : Form
    {
        private UserRole userRole { get; set; }
        private Pasport selectedPasport { get; set; }
        private Operation selectedOper { get; set; }
        private List<Zagot> selectedZadots { get; set; }
        private MainImpl impl { get; set; }

        List<Operation> operations;
        List<Zagot> zagots;


        public OperationsForm(UserRole _userRole, Pasport _selectedPasport)
        {
            InitializeComponent();

            selectedPasport = _selectedPasport;
            userRole = _userRole;
            impl = new MainImpl();
            impl.userRole = _userRole;

            OperList.SelectionMode = DataGridViewSelectionMode.FullRowSelect;
            OperList.MultiSelect = false;
            OperList.ReadOnly = true;
            OperList.AllowUserToAddRows = false;
            OperList.AllowUserToDeleteRows = false;
            OperList.AllowUserToResizeRows = false;

            ZagotList.SelectionMode = DataGridViewSelectionMode.FullRowSelect;
            ZagotList.MultiSelect = true;
            ZagotList.ReadOnly = true;
            ZagotList.AllowUserToAddRows = false;
            ZagotList.AllowUserToDeleteRows = false;
            ZagotList.AllowUserToResizeRows = false;
        }

        private void OperationsForm_Load(object sender, EventArgs e)
        {
            operations = impl.GetOpers(selectedPasport);
            zagots = impl.GetZagots(selectedPasport, operations.FirstOrDefault());


            UpdateOperations(operations);
            UpdateZagots(zagots);
        }

        private void UpdateZagots(List<Zagot> _zagots)
        {
            try
            {
                ZagotList.DataSource = _zagots;
                ZagotList.Columns["Number"].HeaderText = "Номер заготовки";
                ZagotList.Columns["LastOperName"].HeaderText = "Последняя операция";
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }
        private void UpdateOperations(List<Operation> _operations)
        {
            try
            {
                OperList.DataSource = _operations;
                OperList.Columns["Sort"].HeaderText = "№";
                OperList.Columns["OperName"].HeaderText = "Операция";
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        private void OperList_SelectionChanged(object sender, EventArgs e)
        {
            if (((DataGridView)sender).SelectedRows.Count != 0)
            {
                var selectedIndex = ((DataGridView)sender).SelectedRows[0].Index;
                selectedOper = operations[selectedIndex];

                var state = selectedOper.operRashod != null;

                EditorOperations.Enabled = state;
                ClearOperation.Enabled = selectedZadots?.FirstOrDefault()?.LastOper?.Sort == selectedOper?.Sort;

                OperWithoutRaskroy.Enabled = (selectedZadots?.FirstOrDefault()?.LastOper?.Sort + 1) == selectedOper?.Sort || (selectedZadots?.FirstOrDefault()?.LastOper == null && selectedOper?.Sort == 1);
            }
        }

        private void OperWithoutRaskroy_Click(object sender, EventArgs e)
        {
            try
            {
                impl.CreateWithoutRaskroy(selectedZadots, selectedOper);

                operations = impl.GetOpers(selectedPasport);
                zagots = impl.GetZagots(selectedPasport, operations.FirstOrDefault());

                UpdateOperations(operations);
                UpdateZagots(zagots);

                MessageBox.Show("Успешно!");
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        private void ZagotList_SelectionChanged(object sender, EventArgs e)
        {
            if (((DataGridView)sender).SelectedRows.Count != 0)
            {
                var newList = new List<Zagot>();

                for (var i = 0; i < ((DataGridView)sender).SelectedRows.Count; i++)
                {
                    var selectedIndex = ((DataGridView)sender).SelectedRows[i].Index;
                    newList.Add(zagots[selectedIndex]);
                }

                selectedZadots = newList;
                var state = selectedOper.operRashod != null;

                EditorOperations.Enabled = state;
                ClearOperation.Enabled = selectedZadots?.FirstOrDefault()?.LastOper?.Sort == selectedOper?.Sort;

                OperWithoutRaskroy.Enabled = (selectedZadots.FirstOrDefault()?.LastOper?.Sort + 1) == selectedOper?.Sort || (selectedZadots.FirstOrDefault()?.LastOper == null && selectedOper?.Sort == 1);
            }
        }

        private void ClearOperation_Click(object sender, EventArgs e)
        {
            try
            {
                impl.ClearOper(selectedOper);

                operations = impl.GetOpers(selectedPasport);
                zagots = impl.GetZagots(selectedPasport, operations.FirstOrDefault());

                UpdateOperations(operations);
                UpdateZagots(zagots);
                MessageBox.Show("Успешно!");
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        private void EditorOperations_Click(object sender, EventArgs e)
        {
            var EditorOper = new EditOperation(userRole, selectedOper);
            EditorOper.ShowDialog();
        }
    }
}
