namespace ApexCareApp
{
    partial class AdminForm
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
            panel1 = new Panel();
            lbl_Header = new Label();
            panel2 = new Panel();
            lbl_Heading = new Label();
            dgv_Clients = new DataGridView();
            lbl_Clients = new Label();
            lbl_technicians = new Label();
            dgv_Tech = new DataGridView();
            btnLogout = new Button();
            panel1.SuspendLayout();
            panel2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)dgv_Clients).BeginInit();
            ((System.ComponentModel.ISupportInitialize)dgv_Tech).BeginInit();
            SuspendLayout();
            // 
            // panel1
            // 
            panel1.Controls.Add(lbl_Header);
            panel1.Location = new Point(-232, 158);
            panel1.Name = "panel1";
            panel1.Size = new Size(0, 0);
            panel1.TabIndex = 1;
            // 
            // lbl_Header
            // 
            lbl_Header.AutoSize = true;
            lbl_Header.Font = new Font("Segoe UI", 36F, FontStyle.Bold, GraphicsUnit.Point, 0);
            lbl_Header.Location = new Point(514, 40);
            lbl_Header.Name = "lbl_Header";
            lbl_Header.Size = new Size(259, 65);
            lbl_Header.TabIndex = 0;
            lbl_Header.Text = "Apex Care";
            // 
            // panel2
            // 
            panel2.BackColor = Color.FromArgb(187, 215, 253);
            panel2.Controls.Add(lbl_Heading);
            panel2.Location = new Point(0, 0);
            panel2.Name = "panel2";
            panel2.Size = new Size(1265, 134);
            panel2.TabIndex = 2;
            // 
            // lbl_Heading
            // 
            lbl_Heading.AutoSize = true;
            lbl_Heading.Font = new Font("Segoe UI", 36F, FontStyle.Bold, GraphicsUnit.Point, 0);
            lbl_Heading.Location = new Point(473, 36);
            lbl_Heading.Name = "lbl_Heading";
            lbl_Heading.Size = new Size(302, 65);
            lbl_Heading.TabIndex = 0;
            lbl_Heading.Text = "Admin Page";
            // 
            // dgv_Clients
            // 
            dgv_Clients.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dgv_Clients.Location = new Point(12, 198);
            dgv_Clients.Name = "dgv_Clients";
            dgv_Clients.ReadOnly = true;
            dgv_Clients.Size = new Size(1240, 176);
            dgv_Clients.TabIndex = 3;
            // 
            // lbl_Clients
            // 
            lbl_Clients.AutoSize = true;
            lbl_Clients.Font = new Font("Segoe UI", 15.75F, FontStyle.Bold | FontStyle.Underline, GraphicsUnit.Point, 0);
            lbl_Clients.Location = new Point(12, 153);
            lbl_Clients.Name = "lbl_Clients";
            lbl_Clients.Size = new Size(79, 30);
            lbl_Clients.TabIndex = 4;
            lbl_Clients.Text = "Clients";
            // 
            // lbl_technicians
            // 
            lbl_technicians.AutoSize = true;
            lbl_technicians.Font = new Font("Segoe UI", 15.75F, FontStyle.Bold | FontStyle.Underline, GraphicsUnit.Point, 0);
            lbl_technicians.Location = new Point(12, 389);
            lbl_technicians.Name = "lbl_technicians";
            lbl_technicians.Size = new Size(125, 30);
            lbl_technicians.TabIndex = 6;
            lbl_technicians.Text = "Technicians";
            // 
            // dgv_Tech
            // 
            dgv_Tech.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dgv_Tech.Location = new Point(12, 434);
            dgv_Tech.Name = "dgv_Tech";
            dgv_Tech.ReadOnly = true;
            dgv_Tech.Size = new Size(1240, 176);
            dgv_Tech.TabIndex = 5;
            // 
            // btnLogout
            // 
            btnLogout.Font = new Font("Segoe UI", 18F, FontStyle.Bold, GraphicsUnit.Point, 0);
            btnLogout.Location = new Point(570, 626);
            btnLogout.Name = "btnLogout";
            btnLogout.Size = new Size(133, 43);
            btnLogout.TabIndex = 7;
            btnLogout.Text = "Logout";
            btnLogout.UseVisualStyleBackColor = true;
            btnLogout.Click += btnLogout_Click;
            // 
            // AdminForm
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.FromArgb(253, 251, 227);
            ClientSize = new Size(1264, 681);
            Controls.Add(btnLogout);
            Controls.Add(lbl_technicians);
            Controls.Add(dgv_Tech);
            Controls.Add(lbl_Clients);
            Controls.Add(dgv_Clients);
            Controls.Add(panel2);
            Controls.Add(panel1);
            FormBorderStyle = FormBorderStyle.FixedSingle;
            MaximizeBox = false;
            Name = "AdminForm";
            Text = "AdminForm";
            FormClosing += AdminForm_FormClosing;
            Load += AdminForm_Load;
            panel1.ResumeLayout(false);
            panel1.PerformLayout();
            panel2.ResumeLayout(false);
            panel2.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)dgv_Clients).EndInit();
            ((System.ComponentModel.ISupportInitialize)dgv_Tech).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Panel panel1;
        private Label lbl_Header;
        private Panel panel2;
        private Label lbl_Heading;
        private DataGridView dgv_Clients;
        private Label lbl_Clients;
        private Label lbl_technicians;
        private DataGridView dgv_Tech;
        private Button btnLogout;
    }
}