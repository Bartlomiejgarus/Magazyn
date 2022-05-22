namespace Warehouse.Forms
{
    public partial class MainForm : Form
    {
        public MainForm()
        {
            InitializeComponent();
        }

        private void btUsers_Click(object sender, EventArgs e)
        {
            TabPage tp = new TabPage();
            tcTabs.Controls.Add(tp);

            Form frm = new Form();
            frm.Text = "Zakładka";
            frm.TopLevel = false;
            frm.Visible = true;
            frm.FormBorderStyle = FormBorderStyle.None;
            frm.Dock = DockStyle.Fill;
            tcTabs.Controls.Add(frm);
        }
    }
}
