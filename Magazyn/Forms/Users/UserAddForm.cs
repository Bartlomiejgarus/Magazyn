using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Warehouse.Models.Dictionares;

namespace Warehouse.Forms.Users
{
    public partial class UserAddForm : Form
    {
        public UserAddForm()
        {
            InitializeComponent();
            InitializeData();
        }

        private void InitializeData()
        {
            IList<SexModel> sexes = new List<SexModel>()
            {
                new SexModel("woman"),
                new SexModel("man"),
                new SexModel(string.Empty)
            };
        }

        private void btnSaveUser_Click(object sender, EventArgs e)
        {
            MessageBox.Show("Saved");
            Close();
        }

        private void btnCancelUser_Click(object sender, EventArgs e)
        {
            MessageBox.Show("Cancelled");
            Close();
        }


    }
}
