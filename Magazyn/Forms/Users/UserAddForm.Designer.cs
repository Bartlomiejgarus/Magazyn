namespace Warehouse.Forms.Users
{
    partial class UserAddForm
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            this.lblUser = new System.Windows.Forms.Label();
            this.gBGeneral = new System.Windows.Forms.GroupBox();
            this.dTAddDate = new System.Windows.Forms.DateTimePicker();
            this.cBAddSex = new System.Windows.Forms.ComboBox();
            this.bsSex = new System.Windows.Forms.BindingSource(this.components);
            this.txtAddLastName = new System.Windows.Forms.TextBox();
            this.txtAddFirstName = new System.Windows.Forms.TextBox();
            this.lbAddSex = new System.Windows.Forms.Label();
            this.lbAddDateBirth = new System.Windows.Forms.Label();
            this.lbAddLastName = new System.Windows.Forms.Label();
            this.lbAddFirstName = new System.Windows.Forms.Label();
            this.gBContact = new System.Windows.Forms.GroupBox();
            this.txtAddMail = new System.Windows.Forms.TextBox();
            this.txtAddPhoneNumber = new System.Windows.Forms.TextBox();
            this.lbAddMail = new System.Windows.Forms.Label();
            this.lbAddPhoneNumber = new System.Windows.Forms.Label();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.btnSaveUser = new System.Windows.Forms.Button();
            this.btnCancelUser = new System.Windows.Forms.Button();
            this.epFirstName = new System.Windows.Forms.ErrorProvider(this.components);
            this.epLastName = new System.Windows.Forms.ErrorProvider(this.components);
            this.epPhoneNumber = new System.Windows.Forms.ErrorProvider(this.components);
            this.epMail = new System.Windows.Forms.ErrorProvider(this.components);
            this.gBGeneral.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.bsSex)).BeginInit();
            this.gBContact.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.epFirstName)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.epLastName)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.epPhoneNumber)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.epMail)).BeginInit();
            this.SuspendLayout();
            // 
            // lblUser
            // 
            this.lblUser.AutoSize = true;
            this.lblUser.Font = new System.Drawing.Font("Segoe UI", 16.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.lblUser.Location = new System.Drawing.Point(12, 9);
            this.lblUser.Name = "lblUser";
            this.lblUser.Size = new System.Drawing.Size(260, 38);
            this.lblUser.TabIndex = 0;
            this.lblUser.Text = "Identification data";
            // 
            // gBGeneral
            // 
            this.gBGeneral.Controls.Add(this.dTAddDate);
            this.gBGeneral.Controls.Add(this.cBAddSex);
            this.gBGeneral.Controls.Add(this.txtAddLastName);
            this.gBGeneral.Controls.Add(this.txtAddFirstName);
            this.gBGeneral.Controls.Add(this.lbAddSex);
            this.gBGeneral.Controls.Add(this.lbAddDateBirth);
            this.gBGeneral.Controls.Add(this.lbAddLastName);
            this.gBGeneral.Controls.Add(this.lbAddFirstName);
            this.gBGeneral.Location = new System.Drawing.Point(12, 80);
            this.gBGeneral.Name = "gBGeneral";
            this.gBGeneral.Size = new System.Drawing.Size(592, 231);
            this.gBGeneral.TabIndex = 1;
            this.gBGeneral.TabStop = false;
            this.gBGeneral.Text = "General Information";
            // 
            // dTAddDate
            // 
            this.dTAddDate.CustomFormat = " ";
            this.dTAddDate.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.dTAddDate.Location = new System.Drawing.Point(161, 122);
            this.dTAddDate.Name = "dTAddDate";
            this.dTAddDate.Size = new System.Drawing.Size(273, 27);
            this.dTAddDate.TabIndex = 7;
            // 
            // cBAddSex
            // 
            this.cBAddSex.DataSource = this.bsSex;
            this.cBAddSex.DisplayMember = "Value";
            this.cBAddSex.Font = new System.Drawing.Font("Segoe UI", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.cBAddSex.FormattingEnabled = true;
            this.cBAddSex.Location = new System.Drawing.Point(161, 160);
            this.cBAddSex.Name = "cBAddSex";
            this.cBAddSex.Size = new System.Drawing.Size(134, 31);
            this.cBAddSex.TabIndex = 6;
            this.cBAddSex.ValueMember = "UserId";
            // 
            // bsSex
            // 
            this.bsSex.DataSource = typeof(Warehouse.Models.Dictionares.SexModel);
            // 
            // txtAddLastName
            // 
            this.txtAddLastName.Font = new System.Drawing.Font("Segoe UI", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.txtAddLastName.Location = new System.Drawing.Point(161, 80);
            this.txtAddLastName.Name = "txtAddLastName";
            this.txtAddLastName.Size = new System.Drawing.Size(273, 30);
            this.txtAddLastName.TabIndex = 5;
            this.txtAddLastName.TextChanged += new System.EventHandler(this.txtAddLastName_TextChanged);
            // 
            // txtAddFirstName
            // 
            this.txtAddFirstName.Font = new System.Drawing.Font("Segoe UI", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.txtAddFirstName.Location = new System.Drawing.Point(161, 38);
            this.txtAddFirstName.Name = "txtAddFirstName";
            this.txtAddFirstName.Size = new System.Drawing.Size(273, 30);
            this.txtAddFirstName.TabIndex = 4;
            this.txtAddFirstName.TextChanged += new System.EventHandler(this.txtAddFirstName_TextChanged);
            // 
            // lbAddSex
            // 
            this.lbAddSex.AutoSize = true;
            this.lbAddSex.Font = new System.Drawing.Font("Segoe UI", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.lbAddSex.Location = new System.Drawing.Point(32, 163);
            this.lbAddSex.Name = "lbAddSex";
            this.lbAddSex.Size = new System.Drawing.Size(38, 23);
            this.lbAddSex.TabIndex = 3;
            this.lbAddSex.Text = "Sex";
            // 
            // lbAddDateBirth
            // 
            this.lbAddDateBirth.AutoSize = true;
            this.lbAddDateBirth.Font = new System.Drawing.Font("Segoe UI", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.lbAddDateBirth.Location = new System.Drawing.Point(32, 122);
            this.lbAddDateBirth.Name = "lbAddDateBirth";
            this.lbAddDateBirth.Size = new System.Drawing.Size(93, 23);
            this.lbAddDateBirth.TabIndex = 2;
            this.lbAddDateBirth.Text = "Birth Date";
            // 
            // lbAddLastName
            // 
            this.lbAddLastName.AutoSize = true;
            this.lbAddLastName.Font = new System.Drawing.Font("Segoe UI", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.lbAddLastName.Location = new System.Drawing.Point(32, 80);
            this.lbAddLastName.Name = "lbAddLastName";
            this.lbAddLastName.Size = new System.Drawing.Size(94, 23);
            this.lbAddLastName.TabIndex = 1;
            this.lbAddLastName.Text = "Last Name";
            // 
            // lbAddFirstName
            // 
            this.lbAddFirstName.AutoSize = true;
            this.lbAddFirstName.Font = new System.Drawing.Font("Segoe UI", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.lbAddFirstName.Location = new System.Drawing.Point(32, 39);
            this.lbAddFirstName.Name = "lbAddFirstName";
            this.lbAddFirstName.Size = new System.Drawing.Size(97, 23);
            this.lbAddFirstName.TabIndex = 0;
            this.lbAddFirstName.Text = "First Name";
            // 
            // gBContact
            // 
            this.gBContact.Controls.Add(this.txtAddMail);
            this.gBContact.Controls.Add(this.txtAddPhoneNumber);
            this.gBContact.Controls.Add(this.lbAddMail);
            this.gBContact.Controls.Add(this.lbAddPhoneNumber);
            this.gBContact.Location = new System.Drawing.Point(12, 317);
            this.gBContact.Name = "gBContact";
            this.gBContact.Size = new System.Drawing.Size(592, 125);
            this.gBContact.TabIndex = 2;
            this.gBContact.TabStop = false;
            this.gBContact.Text = "Contact";
            // 
            // txtAddMail
            // 
            this.txtAddMail.Location = new System.Drawing.Point(161, 79);
            this.txtAddMail.Name = "txtAddMail";
            this.txtAddMail.Size = new System.Drawing.Size(273, 27);
            this.txtAddMail.TabIndex = 3;
            this.txtAddMail.TextChanged += new System.EventHandler(this.txtAddMail_TextChanged);
            // 
            // txtAddPhoneNumber
            // 
            this.txtAddPhoneNumber.Location = new System.Drawing.Point(161, 41);
            this.txtAddPhoneNumber.Name = "txtAddPhoneNumber";
            this.txtAddPhoneNumber.Size = new System.Drawing.Size(273, 27);
            this.txtAddPhoneNumber.TabIndex = 2;
            this.txtAddPhoneNumber.TextChanged += new System.EventHandler(this.txtAddPhoneNumber_TextChanged);
            // 
            // lbAddMail
            // 
            this.lbAddMail.AutoSize = true;
            this.lbAddMail.Font = new System.Drawing.Font("Segoe UI", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.lbAddMail.Location = new System.Drawing.Point(32, 80);
            this.lbAddMail.Name = "lbAddMail";
            this.lbAddMail.Size = new System.Drawing.Size(66, 23);
            this.lbAddMail.TabIndex = 1;
            this.lbAddMail.Text = "E-mail ";
            // 
            // lbAddPhoneNumber
            // 
            this.lbAddPhoneNumber.AutoSize = true;
            this.lbAddPhoneNumber.Font = new System.Drawing.Font("Segoe UI", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.lbAddPhoneNumber.Location = new System.Drawing.Point(32, 42);
            this.lbAddPhoneNumber.Name = "lbAddPhoneNumber";
            this.lbAddPhoneNumber.Size = new System.Drawing.Size(130, 23);
            this.lbAddPhoneNumber.TabIndex = 0;
            this.lbAddPhoneNumber.Text = "Phone Number";
            // 
            // pictureBox1
            // 
            this.pictureBox1.Image = global::Warehouse.Properties.Resources.employee_64;
            this.pictureBox1.Location = new System.Drawing.Point(721, 12);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(67, 62);
            this.pictureBox1.TabIndex = 3;
            this.pictureBox1.TabStop = false;
            // 
            // btnSaveUser
            // 
            this.btnSaveUser.Font = new System.Drawing.Font("Segoe UI", 10.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.btnSaveUser.Image = global::Warehouse.Properties.Resources.save_32;
            this.btnSaveUser.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnSaveUser.Location = new System.Drawing.Point(556, 475);
            this.btnSaveUser.Name = "btnSaveUser";
            this.btnSaveUser.Padding = new System.Windows.Forms.Padding(5, 0, 0, 0);
            this.btnSaveUser.Size = new System.Drawing.Size(103, 46);
            this.btnSaveUser.TabIndex = 4;
            this.btnSaveUser.Text = "Save";
            this.btnSaveUser.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.btnSaveUser.UseVisualStyleBackColor = true;
            this.btnSaveUser.Click += new System.EventHandler(this.btnSaveUser_Click);
            // 
            // btnCancelUser
            // 
            this.btnCancelUser.Font = new System.Drawing.Font("Segoe UI", 10.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.btnCancelUser.Image = global::Warehouse.Properties.Resources.cancel_321;
            this.btnCancelUser.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnCancelUser.Location = new System.Drawing.Point(665, 475);
            this.btnCancelUser.Name = "btnCancelUser";
            this.btnCancelUser.Padding = new System.Windows.Forms.Padding(3, 0, 0, 0);
            this.btnCancelUser.Size = new System.Drawing.Size(112, 46);
            this.btnCancelUser.TabIndex = 5;
            this.btnCancelUser.Text = "Cancel";
            this.btnCancelUser.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.btnCancelUser.UseVisualStyleBackColor = true;
            this.btnCancelUser.Click += new System.EventHandler(this.btnCancelUser_Click);
            // 
            // epFirstName
            // 
            this.epFirstName.ContainerControl = this;
            // 
            // epLastName
            // 
            this.epLastName.ContainerControl = this;
            // 
            // epPhoneNumber
            // 
            this.epPhoneNumber.ContainerControl = this;
            // 
            // epMail
            // 
            this.epMail.ContainerControl = this;
            // 
            // UserAddForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 533);
            this.Controls.Add(this.btnCancelUser);
            this.Controls.Add(this.btnSaveUser);
            this.Controls.Add(this.pictureBox1);
            this.Controls.Add(this.gBContact);
            this.Controls.Add(this.gBGeneral);
            this.Controls.Add(this.lblUser);
            this.Name = "UserAddForm";
            this.Text = "Add User";
            this.gBGeneral.ResumeLayout(false);
            this.gBGeneral.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.bsSex)).EndInit();
            this.gBContact.ResumeLayout(false);
            this.gBContact.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.epFirstName)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.epLastName)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.epPhoneNumber)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.epMail)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private Label lblUser;
        private GroupBox gBGeneral;
        private Label lbAddDateBirth;
        private Label lbAddLastName;
        private Label lbAddFirstName;
        private GroupBox gBContact;
        private Label lbAddSex;
        private DateTimePicker dTAddDate;
        private ComboBox cBAddSex;
        private TextBox txtAddLastName;
        private TextBox txtAddFirstName;
        private TextBox txtAddMail;
        private TextBox txtAddPhoneNumber;
        private Label lbAddMail;
        private Label lbAddPhoneNumber;
        private PictureBox pictureBox1;
        private Button btnSaveUser;
        private Button btnCancelUser;
        private BindingSource bsSex;
        private ErrorProvider epFirstName;
        private ErrorProvider epLastName;
        private ErrorProvider epPhoneNumber;
        private ErrorProvider epMail;
    }
}