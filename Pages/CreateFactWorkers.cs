using AmApp.Models.Identity;
using AmApp.Models.Main;
using AmApp.Repositories.SqlLite.Impl;

namespace AmApp.Pages
{
    public partial class CreateFactWorkers : Form
    {
        private MainImpl impl { get; set; }
        private UserRole userRole { get; set; }
        private User selectedUser { get; set; }
        private GlobalOborud selectedOborud { get; set; }
        private FactWorker selectedRashod { get; set; }
        private Operation selectedOperation { get; set; }

        List<User> users;
        List<GlobalOborud> globalOboruds;

        public FactWorker? Result;
        public CreateFactWorkers(UserRole _userRole, FactWorker _factWorkers, Operation _operation)
        {
            InitializeComponent();

            userRole = _userRole;
            selectedRashod = _factWorkers;
            selectedOperation = _operation;

            impl = new MainImpl();
            impl.userRole = _userRole;


            UsersList.SelectionMode = DataGridViewSelectionMode.FullRowSelect;
            UsersList.MultiSelect = false;
            UsersList.ReadOnly = true;
            UsersList.AllowUserToAddRows = false;
            UsersList.AllowUserToDeleteRows = false;
            UsersList.AllowUserToResizeRows = false;

            OborudList.SelectionMode = DataGridViewSelectionMode.FullRowSelect;
            OborudList.MultiSelect = false;
            OborudList.ReadOnly = true;
            OborudList.AllowUserToAddRows = false;
            OborudList.AllowUserToDeleteRows = false;
            OborudList.AllowUserToResizeRows = false;
        }

        private void UsersList_SelectionChanged(object sender, EventArgs e)
        {
            if (((DataGridView)sender).SelectedRows.Count != 0)
            {
                var selectedIndex = ((DataGridView)sender).SelectedRows[0].Index;

                selectedUser = users[selectedIndex];
                var state = selectedUser != null;
                var state2 = selectedOborud != null;

                Ok.Enabled = state && state2;
            }
        }

        private void CreateFactWorkers_Load(object sender, EventArgs e)
        {
            try
            {
                UsersList.Visible = true;

                if (UsersList.Visible)
                {
                    users = impl.GetUsers();
                    UpdateUsers(users);
                }
                else
                {
                    globalOboruds = impl.GetOboruds(selectedOperation);
                    UpdateOborud(globalOboruds);
                }

                Next.Enabled = true;
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        private void Next_Click(object sender, EventArgs e)
        {
            Next.Enabled = false;
            Back.Enabled = true;

            UsersList.Visible = false;
            OborudList.Visible = true;


            if (UsersList.Visible)
            {
                users = impl.GetUsers();
                UpdateUsers(users);
            }
            else
            {
                globalOboruds = impl.GetOboruds(selectedOperation);
                UpdateOborud(globalOboruds);
            }
        }

        private void Back_Click(object sender, EventArgs e)
        {
            Next.Enabled = false;
            Back.Enabled = false;

            UsersList.Visible = true;
            OborudList.Visible = false;

            if (UsersList.Visible)
            {
                users = impl.GetUsers();
                UpdateUsers(users);
            }
            else
            {
                globalOboruds = impl.GetOboruds(selectedOperation);
                UpdateOborud(globalOboruds);
            }
        }

        public void UpdateUsers(List<User> _user)
        {
            UsersList.DataSource = _user;
            UsersList.Columns["FIO"].HeaderText = "Имя пользователя";
        }

        public void UpdateOborud(List<GlobalOborud> _oborud)
        {
            OborudList.DataSource = _oborud;
            OborudList.Columns["Name"].HeaderText = "Наименование оборудования";
        }

        private void OborudList_SelectionChanged(object sender, EventArgs e)
        {
            if (((DataGridView)sender).SelectedRows.Count != 0)
            {
                var selectedIndex = ((DataGridView)sender).SelectedRows[0].Index;

                selectedOborud = globalOboruds[selectedIndex];
                var state = selectedUser != null;
                var state2 = selectedOborud != null;

                Ok.Enabled = state && state2;
            }
        }

        private void Ok_Click(object sender, EventArgs e)
        {
            try
            {
                Result = new FactWorker
                {
                    OborudId = selectedOborud.Id,
                    UserId = selectedUser.Id,
                    OperRashodId = selectedOperation.operRashod.Id
                };
                this.Close();
            }
            catch(Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }
    }
}
