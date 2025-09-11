namespace ApexCareApp
{
    partial class TechnicianForm
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
            panel2 = new Panel();
            btnLogout = new Button();
            lbl_Heading = new Label();
            lbl_Personal = new Label();
            lbl_Name = new Label();
            lbl_N = new Label();
            lbl_PN = new Label();
            lbl_Phone = new Label();
            lbl_C = new Label();
            lbl_City = new Label();
            lbl_S = new Label();
            lbl_Suburb = new Label();
            lbl_T = new Label();
            lbl_Type = new Label();
            lbl_P = new Label();
            lbl_Province = new Label();
            label1 = new Label();
            dgv_assignments = new DataGridView();
            lbl_Assignments = new Label();
            lbl_Updates = new Label();
            cmb_assignment = new ComboBox();
            lbl_choose = new Label();
            lbl_message = new Label();
            txb_message = new TextBox();
            rdb_Completed = new RadioButton();
            btn_Submit = new Button();
            chb_Printers = new CheckBox();
            chb_Copiers = new CheckBox();
            chb_HVAC = new CheckBox();
            chb_Generators = new CheckBox();
            panel2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)dgv_assignments).BeginInit();
            SuspendLayout();
            // 
            // panel2
            // 
            panel2.BackColor = Color.FromArgb(187, 215, 253);
            panel2.Controls.Add(btnLogout);
            panel2.Controls.Add(lbl_Heading);
            panel2.Location = new Point(0, 2);
            panel2.Name = "panel2";
            panel2.Size = new Size(1265, 134);
            panel2.TabIndex = 3;
            // 
            // btnLogout
            // 
            btnLogout.Font = new Font("Segoe UI", 18F, FontStyle.Bold, GraphicsUnit.Point, 0);
            btnLogout.Location = new Point(1045, 44);
            btnLogout.Name = "btnLogout";
            btnLogout.Size = new Size(133, 43);
            btnLogout.TabIndex = 32;
            btnLogout.Text = "Logout";
            btnLogout.UseVisualStyleBackColor = true;
            btnLogout.Click += btnLogout_Click;
            // 
            // lbl_Heading
            // 
            lbl_Heading.AutoSize = true;
            lbl_Heading.Font = new Font("Segoe UI", 36F, FontStyle.Bold, GraphicsUnit.Point, 0);
            lbl_Heading.Location = new Point(439, 34);
            lbl_Heading.Name = "lbl_Heading";
            lbl_Heading.Size = new Size(388, 65);
            lbl_Heading.TabIndex = 0;
            lbl_Heading.Text = "Technician Page";
            // 
            // lbl_Personal
            // 
            lbl_Personal.AutoSize = true;
            lbl_Personal.Font = new Font("Segoe UI", 26.25F, FontStyle.Underline, GraphicsUnit.Point, 0);
            lbl_Personal.Location = new Point(12, 139);
            lbl_Personal.Name = "lbl_Personal";
            lbl_Personal.Size = new Size(343, 47);
            lbl_Personal.TabIndex = 4;
            lbl_Personal.Text = "Personal Information";
            // 
            // lbl_Name
            // 
            lbl_Name.AutoSize = true;
            lbl_Name.Font = new Font("Segoe UI", 14.25F, FontStyle.Bold);
            lbl_Name.Location = new Point(23, 198);
            lbl_Name.Name = "lbl_Name";
            lbl_Name.Size = new Size(69, 25);
            lbl_Name.TabIndex = 5;
            lbl_Name.Text = "Name:";
            // 
            // lbl_N
            // 
            lbl_N.AutoSize = true;
            lbl_N.Font = new Font("Segoe UI", 14.25F, FontStyle.Regular, GraphicsUnit.Point, 0);
            lbl_N.Location = new Point(173, 198);
            lbl_N.Name = "lbl_N";
            lbl_N.Size = new Size(59, 25);
            lbl_N.TabIndex = 6;
            lbl_N.Text = "name";
            // 
            // lbl_PN
            // 
            lbl_PN.AutoSize = true;
            lbl_PN.Font = new Font("Segoe UI", 14.25F, FontStyle.Regular, GraphicsUnit.Point, 0);
            lbl_PN.Location = new Point(173, 242);
            lbl_PN.Name = "lbl_PN";
            lbl_PN.Size = new Size(59, 25);
            lbl_PN.TabIndex = 8;
            lbl_PN.Text = "name";
            // 
            // lbl_Phone
            // 
            lbl_Phone.AutoSize = true;
            lbl_Phone.Font = new Font("Segoe UI", 14.25F, FontStyle.Bold);
            lbl_Phone.Location = new Point(23, 242);
            lbl_Phone.Name = "lbl_Phone";
            lbl_Phone.Size = new Size(154, 25);
            lbl_Phone.TabIndex = 7;
            lbl_Phone.Text = "Phone Number:";
            // 
            // lbl_C
            // 
            lbl_C.AutoSize = true;
            lbl_C.Font = new Font("Segoe UI", 14.25F, FontStyle.Regular, GraphicsUnit.Point, 0);
            lbl_C.Location = new Point(491, 242);
            lbl_C.Name = "lbl_C";
            lbl_C.Size = new Size(59, 25);
            lbl_C.TabIndex = 12;
            lbl_C.Text = "name";
            // 
            // lbl_City
            // 
            lbl_City.AutoSize = true;
            lbl_City.Font = new Font("Segoe UI", 14.25F, FontStyle.Bold);
            lbl_City.Location = new Point(341, 242);
            lbl_City.Name = "lbl_City";
            lbl_City.Size = new Size(51, 25);
            lbl_City.TabIndex = 11;
            lbl_City.Text = "City:";
            // 
            // lbl_S
            // 
            lbl_S.AutoSize = true;
            lbl_S.Font = new Font("Segoe UI", 14.25F, FontStyle.Regular, GraphicsUnit.Point, 0);
            lbl_S.Location = new Point(491, 198);
            lbl_S.Name = "lbl_S";
            lbl_S.Size = new Size(59, 25);
            lbl_S.TabIndex = 10;
            lbl_S.Text = "name";
            // 
            // lbl_Suburb
            // 
            lbl_Suburb.AutoSize = true;
            lbl_Suburb.Font = new Font("Segoe UI", 14.25F, FontStyle.Bold);
            lbl_Suburb.Location = new Point(341, 198);
            lbl_Suburb.Name = "lbl_Suburb";
            lbl_Suburb.Size = new Size(84, 25);
            lbl_Suburb.TabIndex = 9;
            lbl_Suburb.Text = "Suburb:";
            // 
            // lbl_T
            // 
            lbl_T.AutoSize = true;
            lbl_T.Font = new Font("Segoe UI", 14.25F, FontStyle.Regular, GraphicsUnit.Point, 0);
            lbl_T.Location = new Point(790, 242);
            lbl_T.Name = "lbl_T";
            lbl_T.Size = new Size(59, 25);
            lbl_T.TabIndex = 16;
            lbl_T.Text = "name";
            // 
            // lbl_Type
            // 
            lbl_Type.AutoSize = true;
            lbl_Type.Font = new Font("Segoe UI", 14.25F, FontStyle.Bold);
            lbl_Type.Location = new Point(640, 242);
            lbl_Type.Name = "lbl_Type";
            lbl_Type.Size = new Size(59, 25);
            lbl_Type.TabIndex = 15;
            lbl_Type.Text = "Type:";
            // 
            // lbl_P
            // 
            lbl_P.AutoSize = true;
            lbl_P.Font = new Font("Segoe UI", 14.25F, FontStyle.Regular, GraphicsUnit.Point, 0);
            lbl_P.Location = new Point(790, 198);
            lbl_P.Name = "lbl_P";
            lbl_P.Size = new Size(59, 25);
            lbl_P.TabIndex = 14;
            lbl_P.Text = "name";
            // 
            // lbl_Province
            // 
            lbl_Province.AutoSize = true;
            lbl_Province.Font = new Font("Segoe UI", 14.25F, FontStyle.Bold);
            lbl_Province.Location = new Point(640, 198);
            lbl_Province.Name = "lbl_Province";
            lbl_Province.Size = new Size(95, 25);
            lbl_Province.TabIndex = 13;
            lbl_Province.Text = "Province:";
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Segoe UI", 14.25F, FontStyle.Bold);
            label1.Location = new Point(1013, 198);
            label1.Name = "label1";
            label1.Size = new Size(147, 25);
            label1.TabIndex = 18;
            label1.Text = "Specializations:";
            // 
            // dgv_assignments
            // 
            dgv_assignments.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dgv_assignments.Location = new Point(12, 340);
            dgv_assignments.Name = "dgv_assignments";
            dgv_assignments.ReadOnly = true;
            dgv_assignments.Size = new Size(1240, 150);
            dgv_assignments.TabIndex = 22;
            // 
            // lbl_Assignments
            // 
            lbl_Assignments.AutoSize = true;
            lbl_Assignments.Font = new Font("Segoe UI", 26.25F, FontStyle.Underline, GraphicsUnit.Point, 0);
            lbl_Assignments.Location = new Point(12, 290);
            lbl_Assignments.Name = "lbl_Assignments";
            lbl_Assignments.Size = new Size(217, 47);
            lbl_Assignments.TabIndex = 23;
            lbl_Assignments.Text = "Assignments";
            // 
            // lbl_Updates
            // 
            lbl_Updates.AutoSize = true;
            lbl_Updates.Font = new Font("Segoe UI", 26.25F, FontStyle.Underline, GraphicsUnit.Point, 0);
            lbl_Updates.Location = new Point(12, 493);
            lbl_Updates.Name = "lbl_Updates";
            lbl_Updates.Size = new Size(221, 47);
            lbl_Updates.TabIndex = 24;
            lbl_Updates.Text = "Issue Update";
            // 
            // cmb_assignment
            // 
            cmb_assignment.FormattingEnabled = true;
            cmb_assignment.Location = new Point(12, 592);
            cmb_assignment.Name = "cmb_assignment";
            cmb_assignment.Size = new Size(227, 23);
            cmb_assignment.TabIndex = 25;
            // 
            // lbl_choose
            // 
            lbl_choose.AutoSize = true;
            lbl_choose.Font = new Font("Segoe UI", 14.25F, FontStyle.Bold);
            lbl_choose.Location = new Point(23, 564);
            lbl_choose.Name = "lbl_choose";
            lbl_choose.Size = new Size(188, 25);
            lbl_choose.TabIndex = 26;
            lbl_choose.Text = "Choose assignment:";
            // 
            // lbl_message
            // 
            lbl_message.AutoSize = true;
            lbl_message.Font = new Font("Segoe UI", 14.25F, FontStyle.Bold);
            lbl_message.Location = new Point(285, 574);
            lbl_message.Name = "lbl_message";
            lbl_message.Size = new Size(162, 25);
            lbl_message.TabIndex = 27;
            lbl_message.Text = "Update message:";
            // 
            // txb_message
            // 
            txb_message.Location = new Point(453, 576);
            txb_message.Name = "txb_message";
            txb_message.Size = new Size(297, 23);
            txb_message.TabIndex = 28;
            // 
            // rdb_Completed
            // 
            rdb_Completed.AutoSize = true;
            rdb_Completed.Font = new Font("Segoe UI", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            rdb_Completed.Location = new Point(780, 574);
            rdb_Completed.Name = "rdb_Completed";
            rdb_Completed.Size = new Size(112, 25);
            rdb_Completed.TabIndex = 30;
            rdb_Completed.TabStop = true;
            rdb_Completed.Text = "Completed";
            rdb_Completed.UseVisualStyleBackColor = true;
            // 
            // btn_Submit
            // 
            btn_Submit.Font = new Font("Segoe UI", 9.75F, FontStyle.Bold, GraphicsUnit.Point, 0);
            btn_Submit.Location = new Point(923, 567);
            btn_Submit.Name = "btn_Submit";
            btn_Submit.Size = new Size(126, 38);
            btn_Submit.TabIndex = 31;
            btn_Submit.Text = "Submit Update";
            btn_Submit.UseVisualStyleBackColor = true;
            btn_Submit.Click += btn_Submit_Click;
            // 
            // chb_Printers
            // 
            chb_Printers.AutoSize = true;
            chb_Printers.Enabled = false;
            chb_Printers.Location = new Point(1013, 226);
            chb_Printers.Name = "chb_Printers";
            chb_Printers.Size = new Size(66, 19);
            chb_Printers.TabIndex = 32;
            chb_Printers.Text = "Printers";
            chb_Printers.UseVisualStyleBackColor = true;
            // 
            // chb_Copiers
            // 
            chb_Copiers.AutoSize = true;
            chb_Copiers.Enabled = false;
            chb_Copiers.Location = new Point(1013, 251);
            chb_Copiers.Name = "chb_Copiers";
            chb_Copiers.Size = new Size(66, 19);
            chb_Copiers.TabIndex = 33;
            chb_Copiers.Text = "Copiers";
            chb_Copiers.UseVisualStyleBackColor = true;
            // 
            // chb_HVAC
            // 
            chb_HVAC.AutoSize = true;
            chb_HVAC.Enabled = false;
            chb_HVAC.Location = new Point(1102, 226);
            chb_HVAC.Name = "chb_HVAC";
            chb_HVAC.Size = new Size(57, 19);
            chb_HVAC.TabIndex = 34;
            chb_HVAC.Text = "HVAC";
            chb_HVAC.UseVisualStyleBackColor = true;
            // 
            // chb_Generators
            // 
            chb_Generators.AutoSize = true;
            chb_Generators.Enabled = false;
            chb_Generators.Location = new Point(1102, 251);
            chb_Generators.Name = "chb_Generators";
            chb_Generators.Size = new Size(83, 19);
            chb_Generators.TabIndex = 35;
            chb_Generators.Text = "Generators";
            chb_Generators.UseVisualStyleBackColor = true;
            // 
            // TechnicianForm
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.FromArgb(253, 251, 227);
            ClientSize = new Size(1264, 681);
            Controls.Add(chb_Generators);
            Controls.Add(chb_HVAC);
            Controls.Add(chb_Copiers);
            Controls.Add(chb_Printers);
            Controls.Add(btn_Submit);
            Controls.Add(rdb_Completed);
            Controls.Add(txb_message);
            Controls.Add(lbl_message);
            Controls.Add(lbl_choose);
            Controls.Add(cmb_assignment);
            Controls.Add(lbl_Updates);
            Controls.Add(lbl_Assignments);
            Controls.Add(dgv_assignments);
            Controls.Add(label1);
            Controls.Add(lbl_T);
            Controls.Add(lbl_Type);
            Controls.Add(lbl_P);
            Controls.Add(lbl_Province);
            Controls.Add(lbl_C);
            Controls.Add(lbl_City);
            Controls.Add(lbl_S);
            Controls.Add(lbl_Suburb);
            Controls.Add(lbl_PN);
            Controls.Add(lbl_Phone);
            Controls.Add(lbl_N);
            Controls.Add(lbl_Name);
            Controls.Add(lbl_Personal);
            Controls.Add(panel2);
            FormBorderStyle = FormBorderStyle.FixedSingle;
            MaximizeBox = false;
            Name = "TechnicianForm";
            Text = "TechnicianForm";
            FormClosing += TechnicianForm_FormClosing;
            Load += TechnicianForm_Load;
            panel2.ResumeLayout(false);
            panel2.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)dgv_assignments).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Panel panel2;
        private Label lbl_Heading;
        private Label lbl_Personal;
        private Label lbl_Name;
        private Label lbl_N;
        private Label lbl_PN;
        private Label lbl_Phone;
        private Label lbl_C;
        private Label lbl_City;
        private Label lbl_S;
        private Label lbl_Suburb;
        private Label lbl_T;
        private Label lbl_Type;
        private Label lbl_P;
        private Label lbl_Province;
        private Label label1;
        private DataGridView dgv_assignments;
        private Label lbl_Assignments;
        private Label lbl_Updates;
        private ComboBox cmb_assignment;
        private Label lbl_choose;
        private Label lbl_message;
        private TextBox txb_message;
        private RadioButton rdb_Completed;
        private Button btn_Submit;
        private Button btnLogout;
        private CheckBox chb_Printers;
        private CheckBox chb_Copiers;
        private CheckBox chb_HVAC;
        private CheckBox chb_Generators;
    }
}