using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Warehouse.Forms.Incoming
{
    public partial class IncomingForm : Form
    {
        private static IncomingForm instance = null;

        public static IncomingForm Instance
        {
            get
            {
                if (IsNull)
                {
                    instance = new IncomingForm();
                }
                return instance;
            }
        }

        public static bool IsNull
        {
            get { return instance == null; }
        }

        private IncomingForm()
        {
            InitializeComponent();
        }

        private void IncomingForm_FormClosed(object sender, FormClosedEventArgs e)
        {
            instance = null;
        }
    }
}
