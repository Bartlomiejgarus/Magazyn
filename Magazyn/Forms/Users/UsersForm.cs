using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Warehouse.Models;
using Warehouse.Models.Dictionares;
using Warehouse.ViewModel;
using System.Linq;
using Warehouse.Helpers;

namespace Warehouse.Forms.Users
{
    public partial class UsersForm : Form
    {
        #region Fields
        private static UsersForm instance = null;
        private static IList<UserViewModel> fakeUsers;
        #endregion
        #region Properties
        public static UsersForm Instance
        {
            get
            {
                if(IsNull)
                {
                    instance = new UsersForm();
                }
                return instance;
            }
        }

        public static bool IsNull
        {
            get { return instance == null; }
        }
        #endregion
        #region Constructor
        private UsersForm()
        {
            InitializeComponent();
            fakeUsers = GetFakeUsers();
            PrepareUsersData();
        }
        #endregion
        #region PrivateMethods
        private void PrepareUsersData()
        {
            var fakeUsersSorted = fakeUsers.OrderBy(x => x.Code).ToList();
            bsUsers.DataSource = new BindingList<UserViewModel>(fakeUsersSorted);
            dGVUsers.DataSource = bsUsers;
        }

        private IList<UserViewModel> GetFakeUsers()
        {
            IList<UserModel> fakeUsersModel = new List<UserModel>()
            {
                new UserModel()
                {
                    UserId = 1,
                    LastName = "Herbert",
                    FirstName = "Zbigniew",
                    CreatedDate = DateTime.Now,
                    Sex = new SexModel("mężczyzna"),
                    Code = 2,
                    DateBirth = new DateTime(1924,10,29),
                    PhoneNumber = "192939491",
                    Email = "z.herbert@poezja.pl",
                    Status = new StatusModel("Wprowadzony")
                },
                new UserModel()
                {
                    UserId = 2,
                    LastName = "Sienkiewicz",
                    FirstName = "Henryk",
                    CreatedDate = DateTime.Now,
                    Sex = new SexModel("mężczyzna"),
                    Code = 1,
                    DateBirth = new DateTime(1846, 5, 5),
                    PhoneNumber = "192939492",
                    Email = "h.sienkiewicz@poezja.pl",
                    Status = new StatusModel("Wprowadzony")
                },
                new UserModel()
                {
                    UserId = 3,
                    LastName = "Asnyk",
                    FirstName = "Adam",
                    CreatedDate = DateTime.Now,
                    Sex = new SexModel("mężczyzna"),
                    Code = 3,
                    DateBirth = new DateTime(1838, 9, 11),
                    PhoneNumber = "192939493",
                    Email = "a.asnyk@poezja.pl",
                    Status = new StatusModel("Wprowadzony")
                },
                new UserModel()
                {
                    UserId = 4,
                    LastName = "Konopnicka",
                    FirstName = "Maria",
                    CreatedDate = DateTime.Now,
                    Sex = new SexModel("kobieta"),
                    Code = 4,
                    DateBirth = new DateTime(1842, 5, 23),
                    PhoneNumber = "192939494",
                    Email = "m.konopnicka@poezja.pl",
                    Status = new StatusModel("Wprowadzony")
                }

            };

            return MappingHelper.MapUserModelToUserViewModel(fakeUsersModel);
        }
        #endregion
        #region Events  

        private void UsersForm_FormClosed(object sender, FormClosedEventArgs e)
        {
            instance = null;
        }

        private void btnSendMail_Click(object sender, EventArgs e)
        {

        }

        private void bsUsers_CurrentChanged(object sender, EventArgs e)
        {

        }

        private void dGVUsers_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void bsUsers_CurrentChanged_1(object sender, EventArgs e)
        {

        }

        private void userViewModelBindingSource_CurrentChanged(object sender, EventArgs e)
        {

        }
        #endregion

        private void btnCreate_Click(object sender, EventArgs e)
        {
            UserAddForm frm = new UserAddForm();
            frm.ShowDialog();
        }
    }
}
