using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Warehouse.Forms.Towards
{
    public partial class TowardsForm : Form
    {
        private static TowardsForm instance = null;

        public static TowardsForm Instance
        {
            get
            {
                if (IsNull)
                {
                    instance = new TowardsForm();
                }
                return instance;
            }
        }

        public static bool IsNull
        {
            get { return instance == null; }
        }

        private TowardsForm()
        {
            InitializeComponent();
        }

        private void TowardsForm_FormClosed(object sender, FormClosedEventArgs e)
        {
            instance = null;
        }
    }
}
