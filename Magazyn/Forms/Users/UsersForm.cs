using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Warehouse.Forms.Users
{
    public partial class UsersForm : Form
    {
        private static UsersForm instance = null;

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

        private UsersForm()
        {
            InitializeComponent();
        }

        private void UsersForm_FormClosed(object sender, FormClosedEventArgs e)
        {
            instance = null;
        }
    }
}
