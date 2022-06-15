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
            ValidateControls();
        }

        private void ValidateControls()
        {
            if (string.IsNullOrWhiteSpace(txtAddFirstName.Text))
            {
                epFirstName.SetError(txtAddFirstName, "First name is required");
            }
            else
            {
                epFirstName.Clear();
            }

            if (string.IsNullOrWhiteSpace(txtAddLastName.Text))
            {
                epLastName.SetError(txtAddLastName, "Last name is required");
            }
            else
            {
                epLastName.Clear();
            }

            if (string.IsNullOrWhiteSpace(txtAddPhoneNumber.Text))
            {
                epPhoneNumber.SetError(txtAddPhoneNumber, "Phone number is required");
            }
            else
            {
                epPhoneNumber.Clear();
            }

            if (string.IsNullOrWhiteSpace(txtAddMail.Text))
            {
                epMail.SetError(txtAddMail, "Mail is required");
            }
            else
            {
                epMail.Clear();
            }
        }

        private void InitializeData()
        {
            IList<SexModel> sexes = new List<SexModel>()
            {
                new SexModel("woman"),
                new SexModel("man"),
                new SexModel(string.Empty)
            };
            bsSex.DataSource = sexes;
            cBAddSex.Text = string.Empty;
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


        private bool ValidateForm()
        {
            StringBuilder sbErrorMessage = new StringBuilder();

            string lastNameErrorMessage = epLastName.GetError(txtAddLastName);
            if (!string.IsNullOrEmpty(lastNameErrorMessage))
            {
                sbErrorMessage.Append(lastNameErrorMessage);
            }

            string firstNameErrorMessage = epFirstName.GetError(txtAddFirstName);
            if (!string.IsNullOrEmpty(firstNameErrorMessage))
            {
                sbErrorMessage.Append(firstNameErrorMessage);
            }
            string phoneNumberErrorMessage = epPhoneNumber.GetError(txtAddPhoneNumber);
            if (!string.IsNullOrEmpty(phoneNumberErrorMessage))
            {
                sbErrorMessage.Append(phoneNumberErrorMessage);
            }
            string MailErrorMessage = epMail.GetError(txtAddMail);
            if (!string.IsNullOrEmpty(MailErrorMessage))
            {
                sbErrorMessage.Append(MailErrorMessage);
            }

            if (sbErrorMessage.Length > 0)
            {
                MessageBox.Show(
                    sbErrorMessage.ToString(),
                    "Dodawanie pracownika",
                    MessageBoxButtons.OK,
                    MessageBoxIcon.Error);
                return false;
            }



            return true;
        }

        private void txtAddFirstName_TextChanged(object sender, EventArgs e)
        {
            ValidateControls();
        }

        private void txtAddLastName_TextChanged(object sender, EventArgs e)
        {
            ValidateControls();
        }

        private void txtAddPhoneNumber_TextChanged(object sender, EventArgs e)
        {
            ValidateControls();
        }

        private void txtAddMail_TextChanged(object sender, EventArgs e)
        {
            ValidateControls();
        }
    }
}
