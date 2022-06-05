using Warehouse.Forms.Contractor;
using Warehouse.Forms.Incoming;
using Warehouse.Forms.Sale;
using Warehouse.Forms.Towards;
using Warehouse.Forms.Users;
namespace Warehouse.Forms
{
    public partial class MainForm : Form
    {
        #region Fields
        private TabPage tpSale = null;
        private TabPage tpIncoming = null;
        private TabPage tpTowards = null;
        private TabPage tpContractor = null;
        private TabPage tpUsers = null;
        #endregion Fields


        #region Ctor
        public MainForm()
        {
            InitializeComponent();
        }
        #endregion Ctor


        #region Events

        private void btSale_Click(object sender, EventArgs e)
        {
            if (SaleForm.IsNull)
            {
                tpSale = new TabPage();
                ShowFormInTabPage(tpSale, SaleForm.Instance);
            }
            else
            {
                tcTabs.SelectedTab = tpSale;
            }
        }

        private void btIncoming_Click(object sender, EventArgs e)
        {
            if (IncomingForm.IsNull)
            {
                tpIncoming = new TabPage();
                ShowFormInTabPage(tpIncoming, IncomingForm.Instance);
            }
            else
            {
                tcTabs.SelectedTab = tpIncoming;
            }
        }

        private void btTowards_Click(object sender, EventArgs e)
        {
            if (TowardsForm.IsNull)
            {
                tpTowards = new TabPage();
                ShowFormInTabPage(tpTowards, TowardsForm.Instance);
            }
            else
            {
                tcTabs.SelectedTab = tpTowards;
            }
        }

        private void btContractor_Click(object sender, EventArgs e)
        {
            if (ContractorForm.IsNull)
            {
                tpContractor = new TabPage();
                ShowFormInTabPage(tpContractor, ContractorForm.Instance);
            }
            else
            {
                tcTabs.SelectedTab = tpContractor;
            }
        }

        private void btUsers_Click(object sender, EventArgs e)
        {
            if (UsersForm.IsNull)
            {
                tpUsers = new TabPage();
                ShowFormInTabPage(tpUsers, UsersForm.Instance);
            }
            else
            {
                tcTabs.SelectedTab = tpUsers;
            }
        }

        private void ShowFormInTabPage(TabPage tpTab, Form form)
        {
            tcTabs.Controls.Add(tpTab);

            tpTab.Text = form.Text;
            form.TopLevel = false;
            form.Visible = true;
            form.FormBorderStyle = FormBorderStyle.None;
            form.Dock = DockStyle.Fill;
            tpTab.Controls.Add(form);
            tcTabs.SelectedTab = tpTab;
        }

        #endregion Events


        #region Private Methods

        private void tcTabs_DrawItem(object sender, DrawItemEventArgs e)
        {
            try
            {
                var tabPage = tcTabs.TabPages[e.Index];
                var tabRect = tcTabs.GetTabRect(e.Index);
                tabRect.Inflate(-2, -2);
                    var closeImage = new Bitmap(Warehouse.Properties.Resources.Close);
                    e.Graphics.DrawImage(closeImage,
                        (tabRect.Right - closeImage.Width),
                        tabRect.Top + (tabRect.Height - closeImage.Height) / 2);
                    TextRenderer.DrawText(e.Graphics, tabPage.Text, tabPage.Font,
                        tabRect, tabPage.ForeColor, TextFormatFlags.Left);
            }
            catch (Exception ex) { throw new Exception(ex.Message); }
        }


        private void tcTabs_MouseDown(object sender, MouseEventArgs e)
        {
            for (var i = 0; i < tcTabs.TabPages.Count; i++)
            {
                var tabRect = tcTabs.GetTabRect(i);
                tabRect.Inflate(-2, -2);
                var closeImage = new Bitmap(Warehouse.Properties.Resources.Close);
                var imageRect = new Rectangle(
                    (tabRect.Right - closeImage.Width),
                    tabRect.Top + (tabRect.Height - closeImage.Height) / 2,
                    closeImage.Width,
                    closeImage.Height);
                if (imageRect.Contains(e.Location))
                {
                    
                    var form = tcTabs.TabPages[i].Controls[0] as Form;
                    if (form != null) 
                        form.Close();

                    tcTabs.TabPages.RemoveAt(i);

                    break;
                }
            }
        }

        #endregion Private Methods
    }
}
