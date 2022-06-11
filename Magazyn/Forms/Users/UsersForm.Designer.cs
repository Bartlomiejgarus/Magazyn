namespace Warehouse.Forms.Users
{
    partial class UsersForm
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
            this.tlpUsers = new System.Windows.Forms.TableLayoutPanel();
            this.pUsers = new System.Windows.Forms.Panel();
            this.btnCreate = new System.Windows.Forms.Button();
            this.btnModify = new System.Windows.Forms.Button();
            this.btnDelete = new System.Windows.Forms.Button();
            this.btnRefresh = new System.Windows.Forms.Button();
            this.btnSendMail = new System.Windows.Forms.Button();
            this.dGVUsers = new System.Windows.Forms.DataGridView();
            this.tlpUsers.SuspendLayout();
            this.pUsers.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dGVUsers)).BeginInit();
            this.SuspendLayout();
            // 
            // tlpUsers
            // 
            this.tlpUsers.ColumnCount = 1;
            this.tlpUsers.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.tlpUsers.Controls.Add(this.pUsers, 0, 0);
            this.tlpUsers.Controls.Add(this.dGVUsers, 0, 1);
            this.tlpUsers.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tlpUsers.Location = new System.Drawing.Point(0, 0);
            this.tlpUsers.Name = "tlpUsers";
            this.tlpUsers.RowCount = 2;
            this.tlpUsers.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 40F));
            this.tlpUsers.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.tlpUsers.Size = new System.Drawing.Size(914, 600);
            this.tlpUsers.TabIndex = 0;
            // 
            // pUsers
            // 
            this.pUsers.Controls.Add(this.btnSendMail);
            this.pUsers.Controls.Add(this.btnRefresh);
            this.pUsers.Controls.Add(this.btnDelete);
            this.pUsers.Controls.Add(this.btnModify);
            this.pUsers.Controls.Add(this.btnCreate);
            this.pUsers.Dock = System.Windows.Forms.DockStyle.Fill;
            this.pUsers.Location = new System.Drawing.Point(3, 3);
            this.pUsers.Name = "pUsers";
            this.pUsers.Size = new System.Drawing.Size(908, 34);
            this.pUsers.TabIndex = 0;
            // 
            // btnCreate
            // 
            this.btnCreate.BackColor = System.Drawing.SystemColors.ControlLightLight;
            this.btnCreate.Dock = System.Windows.Forms.DockStyle.Left;
            this.btnCreate.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnCreate.Location = new System.Drawing.Point(0, 0);
            this.btnCreate.Name = "btnCreate";
            this.btnCreate.Size = new System.Drawing.Size(120, 34);
            this.btnCreate.TabIndex = 0;
            this.btnCreate.Text = "Create User";
            this.btnCreate.UseVisualStyleBackColor = false;
            // 
            // btnModify
            // 
            this.btnModify.BackColor = System.Drawing.SystemColors.ControlLightLight;
            this.btnModify.Dock = System.Windows.Forms.DockStyle.Left;
            this.btnModify.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnModify.Location = new System.Drawing.Point(120, 0);
            this.btnModify.Name = "btnModify";
            this.btnModify.Size = new System.Drawing.Size(120, 34);
            this.btnModify.TabIndex = 1;
            this.btnModify.Text = "Modify User";
            this.btnModify.UseVisualStyleBackColor = false;
            // 
            // btnDelete
            // 
            this.btnDelete.BackColor = System.Drawing.SystemColors.ControlLightLight;
            this.btnDelete.Dock = System.Windows.Forms.DockStyle.Left;
            this.btnDelete.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnDelete.Location = new System.Drawing.Point(240, 0);
            this.btnDelete.Name = "btnDelete";
            this.btnDelete.Size = new System.Drawing.Size(120, 34);
            this.btnDelete.TabIndex = 2;
            this.btnDelete.Text = "Delete User";
            this.btnDelete.UseVisualStyleBackColor = false;
            // 
            // btnRefresh
            // 
            this.btnRefresh.BackColor = System.Drawing.SystemColors.ControlLightLight;
            this.btnRefresh.Dock = System.Windows.Forms.DockStyle.Left;
            this.btnRefresh.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnRefresh.Location = new System.Drawing.Point(360, 0);
            this.btnRefresh.Name = "btnRefresh";
            this.btnRefresh.Size = new System.Drawing.Size(90, 34);
            this.btnRefresh.TabIndex = 3;
            this.btnRefresh.Text = "Refresh";
            this.btnRefresh.UseVisualStyleBackColor = false;
            // 
            // btnSendMail
            // 
            this.btnSendMail.BackColor = System.Drawing.SystemColors.ControlLightLight;
            this.btnSendMail.Dock = System.Windows.Forms.DockStyle.Right;
            this.btnSendMail.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnSendMail.Location = new System.Drawing.Point(788, 0);
            this.btnSendMail.Name = "btnSendMail";
            this.btnSendMail.Size = new System.Drawing.Size(120, 34);
            this.btnSendMail.TabIndex = 4;
            this.btnSendMail.Text = "Send Mail";
            this.btnSendMail.UseVisualStyleBackColor = false;
            // 
            // dGVUsers
            // 
            this.dGVUsers.AllowUserToAddRows = false;
            this.dGVUsers.AllowUserToDeleteRows = false;
            this.dGVUsers.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dGVUsers.Dock = System.Windows.Forms.DockStyle.Fill;
            this.dGVUsers.Location = new System.Drawing.Point(3, 43);
            this.dGVUsers.Name = "dGVUsers";
            this.dGVUsers.ReadOnly = true;
            this.dGVUsers.RowHeadersWidth = 51;
            this.dGVUsers.RowTemplate.Height = 29;
            this.dGVUsers.Size = new System.Drawing.Size(908, 554);
            this.dGVUsers.TabIndex = 1;
            // 
            // UsersForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(914, 600);
            this.Controls.Add(this.tlpUsers);
            this.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.Name = "UsersForm";
            this.Text = "Użytkownicy";
            this.FormClosed += new System.Windows.Forms.FormClosedEventHandler(this.UsersForm_FormClosed);
            this.tlpUsers.ResumeLayout(false);
            this.pUsers.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dGVUsers)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private TableLayoutPanel tlpUsers;
        private Panel pUsers;
        private Button btnSendMail;
        private Button btnRefresh;
        private Button btnDelete;
        private Button btnModify;
        private Button btnCreate;
        private DataGridView dGVUsers;
    }
}