﻿namespace Warehouse.Forms
{
    partial class MainForm
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
            this.pGeneral = new System.Windows.Forms.Panel();
            this.btUsers = new System.Windows.Forms.Button();
            this.btContractor = new System.Windows.Forms.Button();
            this.btTowards = new System.Windows.Forms.Button();
            this.btIncoming = new System.Windows.Forms.Button();
            this.btSale = new System.Windows.Forms.Button();
            this.pMain = new System.Windows.Forms.Panel();
            this.ssMain = new System.Windows.Forms.StatusStrip();
            this.ssVersion = new System.Windows.Forms.ToolStripStatusLabel();
            this.ssUser = new System.Windows.Forms.ToolStripStatusLabel();
            this.tcTabs = new System.Windows.Forms.TabControl();
            this.pGeneral.SuspendLayout();
            this.pMain.SuspendLayout();
            this.ssMain.SuspendLayout();
            this.SuspendLayout();
            // 
            // pGeneral
            // 
            this.pGeneral.Controls.Add(this.btUsers);
            this.pGeneral.Controls.Add(this.btContractor);
            this.pGeneral.Controls.Add(this.btTowards);
            this.pGeneral.Controls.Add(this.btIncoming);
            this.pGeneral.Controls.Add(this.btSale);
            this.pGeneral.Dock = System.Windows.Forms.DockStyle.Top;
            this.pGeneral.Location = new System.Drawing.Point(0, 0);
            this.pGeneral.Name = "pGeneral";
            this.pGeneral.Size = new System.Drawing.Size(944, 70);
            this.pGeneral.TabIndex = 1;
            // 
            // btUsers
            // 
            this.btUsers.BackColor = System.Drawing.Color.Thistle;
            this.btUsers.Dock = System.Windows.Forms.DockStyle.Fill;
            this.btUsers.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btUsers.Location = new System.Drawing.Point(752, 0);
            this.btUsers.Name = "btUsers";
            this.btUsers.Size = new System.Drawing.Size(192, 70);
            this.btUsers.TabIndex = 6;
            this.btUsers.Text = "Użytkownicy";
            this.btUsers.UseVisualStyleBackColor = false;
            this.btUsers.Click += new System.EventHandler(this.btUsers_Click);
            // 
            // btContractor
            // 
            this.btContractor.BackColor = System.Drawing.Color.Salmon;
            this.btContractor.Dock = System.Windows.Forms.DockStyle.Left;
            this.btContractor.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btContractor.Location = new System.Drawing.Point(564, 0);
            this.btContractor.Name = "btContractor";
            this.btContractor.Size = new System.Drawing.Size(188, 70);
            this.btContractor.TabIndex = 4;
            this.btContractor.Text = "Kontrahenci";
            this.btContractor.UseVisualStyleBackColor = false;
            // 
            // btTowards
            // 
            this.btTowards.BackColor = System.Drawing.Color.Khaki;
            this.btTowards.Dock = System.Windows.Forms.DockStyle.Left;
            this.btTowards.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btTowards.Location = new System.Drawing.Point(376, 0);
            this.btTowards.Name = "btTowards";
            this.btTowards.Size = new System.Drawing.Size(188, 70);
            this.btTowards.TabIndex = 3;
            this.btTowards.Text = "Słownik towarów";
            this.btTowards.UseVisualStyleBackColor = false;
            // 
            // btIncoming
            // 
            this.btIncoming.BackColor = System.Drawing.Color.YellowGreen;
            this.btIncoming.Dock = System.Windows.Forms.DockStyle.Left;
            this.btIncoming.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btIncoming.Location = new System.Drawing.Point(188, 0);
            this.btIncoming.Name = "btIncoming";
            this.btIncoming.Size = new System.Drawing.Size(188, 70);
            this.btIncoming.TabIndex = 2;
            this.btIncoming.Text = "Przyjęcia";
            this.btIncoming.UseVisualStyleBackColor = false;
            // 
            // btSale
            // 
            this.btSale.BackColor = System.Drawing.Color.SkyBlue;
            this.btSale.Dock = System.Windows.Forms.DockStyle.Left;
            this.btSale.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btSale.ForeColor = System.Drawing.SystemColors.ControlText;
            this.btSale.Location = new System.Drawing.Point(0, 0);
            this.btSale.Name = "btSale";
            this.btSale.Size = new System.Drawing.Size(188, 70);
            this.btSale.TabIndex = 1;
            this.btSale.Text = "Sprzedaż";
            this.btSale.UseVisualStyleBackColor = false;
            // 
            // pMain
            // 
            this.pMain.Controls.Add(this.tcTabs);
            this.pMain.Controls.Add(this.ssMain);
            this.pMain.Dock = System.Windows.Forms.DockStyle.Fill;
            this.pMain.Location = new System.Drawing.Point(0, 70);
            this.pMain.Name = "pMain";
            this.pMain.Size = new System.Drawing.Size(944, 431);
            this.pMain.TabIndex = 2;
            // 
            // ssMain
            // 
            this.ssMain.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.ssVersion,
            this.ssUser});
            this.ssMain.Location = new System.Drawing.Point(0, 409);
            this.ssMain.Name = "ssMain";
            this.ssMain.Size = new System.Drawing.Size(944, 22);
            this.ssMain.TabIndex = 0;
            this.ssMain.Text = "ssMain";
            // 
            // ssVersion
            // 
            this.ssVersion.Name = "ssVersion";
            this.ssVersion.Size = new System.Drawing.Size(87, 17);
            this.ssVersion.Text = "Wersja 1.0.0.0   ";
            // 
            // ssUser
            // 
            this.ssUser.Name = "ssUser";
            this.ssUser.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.ssUser.Size = new System.Drawing.Size(30, 17);
            this.ssUser.Text = "User";
            // 
            // tcTabs
            // 
            this.tcTabs.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tcTabs.Location = new System.Drawing.Point(0, 0);
            this.tcTabs.Name = "tcTabs";
            this.tcTabs.SelectedIndex = 0;
            this.tcTabs.Size = new System.Drawing.Size(944, 409);
            this.tcTabs.TabIndex = 1;
            // 
            // MainForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(944, 501);
            this.Controls.Add(this.pMain);
            this.Controls.Add(this.pGeneral);
            this.Name = "MainForm";
            this.Text = "Warehouse";
            this.pGeneral.ResumeLayout(false);
            this.pMain.ResumeLayout(false);
            this.pMain.PerformLayout();
            this.ssMain.ResumeLayout(false);
            this.ssMain.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private Panel pGeneral;
        private Button btUsers;
        private Button btContractor;
        private Button btTowards;
        private Button btIncoming;
        private Button btSale;
        private Panel pMain;
        private StatusStrip ssMain;
        private ToolStripStatusLabel ssVersion;
        private ToolStripStatusLabel ssUser;
        private TabControl tcTabs;
    }
}