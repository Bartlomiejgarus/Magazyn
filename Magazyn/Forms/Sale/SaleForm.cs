using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Warehouse.Forms.Sale
{
    public partial class SaleForm : Form
    {
        private static SaleForm instance = null;

        public static SaleForm Instance
        {
            get
            {
                if (IsNull)
                {
                    instance = new SaleForm();
                }
                return instance;
            }
        }

        public static bool IsNull
        {
            get { return instance == null; }
        }

        private SaleForm()
        {
            InitializeComponent();
        }

        private void SaleForm_FormClosed(object sender, FormClosedEventArgs e)
        {
            instance = null;
        }
    }
}
