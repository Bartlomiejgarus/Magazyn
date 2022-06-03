using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Warehouse.Forms.Contractor
{
    public partial class ContractorForm : Form
    {
        private static ContractorForm instance = null;

        public static ContractorForm Instance
        {
            get
            {
                if (IsNull)
                {
                    instance = new ContractorForm();
                }
                return instance;
            }
        }

        public static bool IsNull
        {
            get { return instance == null; }
        }

        private ContractorForm()
        {
            InitializeComponent();
        }

        private void ContractorForm_FormClosed(object sender, FormClosedEventArgs e)
        {
            instance = null;
        }
    }
}
