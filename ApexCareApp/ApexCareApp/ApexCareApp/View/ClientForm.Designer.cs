namespace ApexCareApp
{
    partial class ClientForm
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
            lbl_E = new Label();
            lbl_Email = new Label();
            lbl_CP = new Label();
            lbl_ConPers = new Label();
            lbl_PN = new Label();
            lbl_Phone = new Label();
            lbl_N = new Label();
            lbl_Name = new Label();
            lbl_Personal = new Label();
            lbl_Contracts = new Label();
            dgv_Contracts = new DataGridView();
            label1 = new Label();
            dgv_ServiceRequests = new DataGridView();
            btn_Submit = new Button();
            txb_message = new TextBox();
            lbl_message = new Label();
            lbl_choose = new Label();
            cmb_requests = new ComboBox();
            lbl_Feedback = new Label();
            label2 = new Label();
            rdb_1 = new RadioButton();
            rdb_2 = new RadioButton();
            rdb_3 = new RadioButton();
            rdb_4 = new RadioButton();
            rdb_5 = new RadioButton();
            chb_followup = new CheckBox();
            panel2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)dgv_Contracts).BeginInit();
            ((System.ComponentModel.ISupportInitialize)dgv_ServiceRequests).BeginInit();
            SuspendLayout();
            // 
            // panel2
            // 
            panel2.BackColor = Color.FromArgb(187, 215, 253);
            panel2.Controls.Add(btnLogout);
            panel2.Controls.Add(lbl_Heading);
            panel2.Location = new Point(0, 0);
            panel2.Name = "panel2";
            panel2.Size = new Size(1265, 134);
            panel2.TabIndex = 4;
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
            lbl_Heading.Size = new Size(283, 65);
            lbl_Heading.TabIndex = 0;
            lbl_Heading.Text = "Client Page";
            // 
            // lbl_E
            // 
            lbl_E.AutoSize = true;
            lbl_E.Font = new Font("Segoe UI", 14.25F, FontStyle.Regular, GraphicsUnit.Point, 0);
            lbl_E.Location = new Point(710, 196);
            lbl_E.Name = "lbl_E";
            lbl_E.Size = new Size(59, 25);
            lbl_E.TabIndex = 46;
            lbl_E.Text = "name";
            // 
            // lbl_Email
            // 
            lbl_Email.AutoSize = true;
            lbl_Email.Font = new Font("Segoe UI", 14.25F, FontStyle.Bold);
            lbl_Email.Location = new Point(640, 196);
            lbl_Email.Name = "lbl_Email";
            lbl_Email.Size = new Size(64, 25);
            lbl_Email.TabIndex = 45;
            lbl_Email.Text = "Email:";
            // 
            // lbl_CP
            // 
            lbl_CP.AutoSize = true;
            lbl_CP.Font = new Font("Segoe UI", 14.25F, FontStyle.Regular, GraphicsUnit.Point, 0);
            lbl_CP.Location = new Point(441, 196);
            lbl_CP.Name = "lbl_CP";
            lbl_CP.Size = new Size(59, 25);
            lbl_CP.TabIndex = 42;
            lbl_CP.Text = "name";
            // 
            // lbl_ConPers
            // 
            lbl_ConPers.AutoSize = true;
            lbl_ConPers.Font = new Font("Segoe UI", 14.25F, FontStyle.Bold);
            lbl_ConPers.Location = new Point(291, 196);
            lbl_ConPers.Name = "lbl_ConPers";
            lbl_ConPers.Size = new Size(152, 25);
            lbl_ConPers.TabIndex = 41;
            lbl_ConPers.Text = "Contact Person:";
            // 
            // lbl_PN
            // 
            lbl_PN.AutoSize = true;
            lbl_PN.Font = new Font("Segoe UI", 14.25F, FontStyle.Regular, GraphicsUnit.Point, 0);
            lbl_PN.Location = new Point(1112, 196);
            lbl_PN.Name = "lbl_PN";
            lbl_PN.Size = new Size(59, 25);
            lbl_PN.TabIndex = 40;
            lbl_PN.Text = "name";
            // 
            // lbl_Phone
            // 
            lbl_Phone.AutoSize = true;
            lbl_Phone.Font = new Font("Segoe UI", 14.25F, FontStyle.Bold);
            lbl_Phone.Location = new Point(962, 196);
            lbl_Phone.Name = "lbl_Phone";
            lbl_Phone.Size = new Size(154, 25);
            lbl_Phone.TabIndex = 39;
            lbl_Phone.Text = "Phone Number:";
            // 
            // lbl_N
            // 
            lbl_N.AutoSize = true;
            lbl_N.Font = new Font("Segoe UI", 14.25F, FontStyle.Regular, GraphicsUnit.Point, 0);
            lbl_N.Location = new Point(98, 196);
            lbl_N.Name = "lbl_N";
            lbl_N.Size = new Size(59, 25);
            lbl_N.TabIndex = 38;
            lbl_N.Text = "name";
            // 
            // lbl_Name
            // 
            lbl_Name.AutoSize = true;
            lbl_Name.Font = new Font("Segoe UI", 14.25F, FontStyle.Bold);
            lbl_Name.Location = new Point(23, 196);
            lbl_Name.Name = "lbl_Name";
            lbl_Name.Size = new Size(69, 25);
            lbl_Name.TabIndex = 37;
            lbl_Name.Text = "Name:";
            // 
            // lbl_Personal
            // 
            lbl_Personal.AutoSize = true;
            lbl_Personal.Font = new Font("Segoe UI", 26.25F, FontStyle.Underline, GraphicsUnit.Point, 0);
            lbl_Personal.Location = new Point(12, 137);
            lbl_Personal.Name = "lbl_Personal";
            lbl_Personal.Size = new Size(343, 47);
            lbl_Personal.TabIndex = 36;
            lbl_Personal.Text = "Personal Information";
            // 
            // lbl_Contracts
            // 
            lbl_Contracts.AutoSize = true;
            lbl_Contracts.Font = new Font("Segoe UI", 15.75F, FontStyle.Bold | FontStyle.Underline, GraphicsUnit.Point, 0);
            lbl_Contracts.Location = new Point(12, 230);
            lbl_Contracts.Name = "lbl_Contracts";
            lbl_Contracts.Size = new Size(106, 30);
            lbl_Contracts.TabIndex = 48;
            lbl_Contracts.Text = "Contracts";
            // 
            // dgv_Contracts
            // 
            dgv_Contracts.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dgv_Contracts.Location = new Point(12, 275);
            dgv_Contracts.Name = "dgv_Contracts";
            dgv_Contracts.ReadOnly = true;
            dgv_Contracts.Size = new Size(1240, 91);
            dgv_Contracts.TabIndex = 47;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Segoe UI", 15.75F, FontStyle.Bold | FontStyle.Underline, GraphicsUnit.Point, 0);
            label1.Location = new Point(12, 387);
            label1.Name = "label1";
            label1.Size = new Size(176, 30);
            label1.TabIndex = 50;
            label1.Text = "Service Requests";
            // 
            // dgv_ServiceRequests
            // 
            dgv_ServiceRequests.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dgv_ServiceRequests.Location = new Point(12, 432);
            dgv_ServiceRequests.Name = "dgv_ServiceRequests";
            dgv_ServiceRequests.ReadOnly = true;
            dgv_ServiceRequests.Size = new Size(1240, 104);
            dgv_ServiceRequests.TabIndex = 49;
            // 
            // btn_Submit
            // 
            btn_Submit.Font = new Font("Segoe UI", 9.75F, FontStyle.Bold, GraphicsUnit.Point, 0);
            btn_Submit.Location = new Point(1001, 623);
            btn_Submit.Name = "btn_Submit";
            btn_Submit.Size = new Size(126, 38);
            btn_Submit.TabIndex = 57;
            btn_Submit.Text = "Submit Feedback";
            btn_Submit.UseVisualStyleBackColor = true;
            btn_Submit.Click += btn_Submit_Click;
            // 
            // txb_message
            // 
            txb_message.Location = new Point(449, 638);
            txb_message.Name = "txb_message";
            txb_message.Size = new Size(297, 23);
            txb_message.TabIndex = 55;
            // 
            // lbl_message
            // 
            lbl_message.AutoSize = true;
            lbl_message.Font = new Font("Segoe UI", 14.25F, FontStyle.Bold);
            lbl_message.Location = new Point(262, 636);
            lbl_message.Name = "lbl_message";
            lbl_message.Size = new Size(181, 25);
            lbl_message.TabIndex = 54;
            lbl_message.Text = "Feedback message:";
            // 
            // lbl_choose
            // 
            lbl_choose.AutoSize = true;
            lbl_choose.Font = new Font("Segoe UI", 14.25F, FontStyle.Bold);
            lbl_choose.Location = new Point(23, 610);
            lbl_choose.Name = "lbl_choose";
            lbl_choose.Size = new Size(154, 25);
            lbl_choose.TabIndex = 53;
            lbl_choose.Text = "Choose request:";
            // 
            // cmb_requests
            // 
            cmb_requests.FormattingEnabled = true;
            cmb_requests.Location = new Point(12, 638);
            cmb_requests.Name = "cmb_requests";
            cmb_requests.Size = new Size(227, 23);
            cmb_requests.TabIndex = 52;
            // 
            // lbl_Feedback
            // 
            lbl_Feedback.AutoSize = true;
            lbl_Feedback.Font = new Font("Segoe UI", 26.25F, FontStyle.Underline, GraphicsUnit.Point, 0);
            lbl_Feedback.Location = new Point(12, 539);
            lbl_Feedback.Name = "lbl_Feedback";
            lbl_Feedback.Size = new Size(253, 47);
            lbl_Feedback.TabIndex = 51;
            lbl_Feedback.Text = "Issue Feedback";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Font = new Font("Segoe UI", 14.25F, FontStyle.Bold);
            label2.Location = new Point(398, 574);
            label2.Name = "label2";
            label2.Size = new Size(178, 25);
            label2.TabIndex = 58;
            label2.Text = "Satisfaction Rating";
            // 
            // rdb_1
            // 
            rdb_1.AutoSize = true;
            rdb_1.Location = new Point(398, 602);
            rdb_1.Name = "rdb_1";
            rdb_1.Size = new Size(31, 19);
            rdb_1.TabIndex = 59;
            rdb_1.TabStop = true;
            rdb_1.Text = "1";
            rdb_1.UseVisualStyleBackColor = true;
            // 
            // rdb_2
            // 
            rdb_2.AutoSize = true;
            rdb_2.Location = new Point(435, 602);
            rdb_2.Name = "rdb_2";
            rdb_2.Size = new Size(31, 19);
            rdb_2.TabIndex = 60;
            rdb_2.TabStop = true;
            rdb_2.Text = "2";
            rdb_2.UseVisualStyleBackColor = true;
            // 
            // rdb_3
            // 
            rdb_3.AutoSize = true;
            rdb_3.Location = new Point(472, 602);
            rdb_3.Name = "rdb_3";
            rdb_3.Size = new Size(31, 19);
            rdb_3.TabIndex = 61;
            rdb_3.TabStop = true;
            rdb_3.Text = "3";
            rdb_3.UseVisualStyleBackColor = true;
            // 
            // rdb_4
            // 
            rdb_4.AutoSize = true;
            rdb_4.Location = new Point(509, 602);
            rdb_4.Name = "rdb_4";
            rdb_4.Size = new Size(31, 19);
            rdb_4.TabIndex = 62;
            rdb_4.TabStop = true;
            rdb_4.Text = "4";
            rdb_4.UseVisualStyleBackColor = true;
            // 
            // rdb_5
            // 
            rdb_5.AutoSize = true;
            rdb_5.Location = new Point(546, 602);
            rdb_5.Name = "rdb_5";
            rdb_5.Size = new Size(31, 19);
            rdb_5.TabIndex = 63;
            rdb_5.TabStop = true;
            rdb_5.Text = "5";
            rdb_5.UseVisualStyleBackColor = true;
            // 
            // chb_followup
            // 
            chb_followup.AutoSize = true;
            chb_followup.Font = new Font("Segoe UI", 11.25F, FontStyle.Bold, GraphicsUnit.Point, 0);
            chb_followup.Location = new Point(765, 637);
            chb_followup.Name = "chb_followup";
            chb_followup.Size = new Size(149, 24);
            chb_followup.TabIndex = 64;
            chb_followup.Text = "FollowUp needed";
            chb_followup.UseVisualStyleBackColor = true;
            // 
            // ClientForm
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.FromArgb(253, 251, 227);
            ClientSize = new Size(1264, 681);
            Controls.Add(chb_followup);
            Controls.Add(rdb_5);
            Controls.Add(rdb_4);
            Controls.Add(rdb_3);
            Controls.Add(rdb_2);
            Controls.Add(rdb_1);
            Controls.Add(label2);
            Controls.Add(btn_Submit);
            Controls.Add(txb_message);
            Controls.Add(lbl_message);
            Controls.Add(lbl_choose);
            Controls.Add(cmb_requests);
            Controls.Add(lbl_Feedback);
            Controls.Add(label1);
            Controls.Add(dgv_ServiceRequests);
            Controls.Add(lbl_Contracts);
            Controls.Add(dgv_Contracts);
            Controls.Add(lbl_E);
            Controls.Add(lbl_Email);
            Controls.Add(lbl_CP);
            Controls.Add(lbl_ConPers);
            Controls.Add(lbl_PN);
            Controls.Add(lbl_Phone);
            Controls.Add(lbl_N);
            Controls.Add(lbl_Name);
            Controls.Add(lbl_Personal);
            Controls.Add(panel2);
            FormBorderStyle = FormBorderStyle.FixedSingle;
            MaximizeBox = false;
            Name = "ClientForm";
            Text = "ClientForm";
            FormClosing += ClientForm_FormClosing;
            panel2.ResumeLayout(false);
            panel2.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)dgv_Contracts).EndInit();
            ((System.ComponentModel.ISupportInitialize)dgv_ServiceRequests).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Panel panel2;
        private Button btnLogout;
        private Label lbl_Heading;
        private Label lbl_E;
        private Label lbl_Email;
        private Label lbl_CP;
        private Label lbl_ConPers;
        private Label lbl_PN;
        private Label lbl_Phone;
        private Label lbl_N;
        private Label lbl_Name;
        private Label lbl_Personal;
        private Label lbl_Contracts;
        private DataGridView dgv_Contracts;
        private Label label1;
        private DataGridView dgv_ServiceRequests;
        private Button btn_Submit;
        private TextBox txb_message;
        private Label lbl_message;
        private Label lbl_choose;
        private ComboBox cmb_requests;
        private Label lbl_Feedback;
        private Label label2;
        private RadioButton rdb_1;
        private RadioButton rdb_2;
        private RadioButton rdb_3;
        private RadioButton rdb_4;
        private RadioButton rdb_5;
        private CheckBox chb_followup;
    }
}