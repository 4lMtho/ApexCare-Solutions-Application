namespace ApexCareApp
{
    partial class LoginForm
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
            lbl_Username = new Label();
            lbl_Password = new Label();
            txb_Username = new TextBox();
            txb_Password = new TextBox();
            btn_Login = new Button();
            panel1.SuspendLayout();
            SuspendLayout();
            // 
            // panel1
            // 
            panel1.BackColor = Color.FromArgb(187, 215, 253);
            panel1.Controls.Add(lbl_Header);
            panel1.Location = new Point(0, 1);
            panel1.Name = "panel1";
            panel1.Size = new Size(1265, 134);
            panel1.TabIndex = 0;
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
            // lbl_Username
            // 
            lbl_Username.AutoSize = true;
            lbl_Username.Font = new Font("Segoe UI", 15.75F, FontStyle.Regular, GraphicsUnit.Point, 0);
            lbl_Username.Location = new Point(470, 293);
            lbl_Username.Name = "lbl_Username";
            lbl_Username.Size = new Size(111, 30);
            lbl_Username.TabIndex = 1;
            lbl_Username.Text = "Username:";
            // 
            // lbl_Password
            // 
            lbl_Password.AutoSize = true;
            lbl_Password.Font = new Font("Segoe UI", 15.75F, FontStyle.Regular, GraphicsUnit.Point, 0);
            lbl_Password.Location = new Point(477, 341);
            lbl_Password.Name = "lbl_Password";
            lbl_Password.Size = new Size(104, 30);
            lbl_Password.TabIndex = 2;
            lbl_Password.Text = "Password:";
            // 
            // txb_Username
            // 
            txb_Username.Location = new Point(587, 300);
            txb_Username.Name = "txb_Username";
            txb_Username.Size = new Size(137, 23);
            txb_Username.TabIndex = 3;
            // 
            // txb_Password
            // 
            txb_Password.Location = new Point(587, 348);
            txb_Password.Name = "txb_Password";
            txb_Password.PasswordChar = '*';
            txb_Password.Size = new Size(137, 23);
            txb_Password.TabIndex = 4;
            // 
            // btn_Login
            // 
            btn_Login.Font = new Font("Segoe UI", 15.75F, FontStyle.Bold, GraphicsUnit.Point, 0);
            btn_Login.Location = new Point(587, 391);
            btn_Login.Name = "btn_Login";
            btn_Login.Size = new Size(137, 40);
            btn_Login.TabIndex = 5;
            btn_Login.Text = "Login";
            btn_Login.UseVisualStyleBackColor = true;
            btn_Login.Click += btn_Login_Click;
            // 
            // LoginForm
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.FromArgb(253, 251, 227);
            ClientSize = new Size(1264, 681);
            Controls.Add(btn_Login);
            Controls.Add(txb_Password);
            Controls.Add(txb_Username);
            Controls.Add(lbl_Password);
            Controls.Add(lbl_Username);
            Controls.Add(panel1);
            FormBorderStyle = FormBorderStyle.FixedSingle;
            MaximizeBox = false;
            Name = "LoginForm";
            Text = "LoginForm";
            FormClosing += LoginForm_FormClosing;
            Load += LoginForm_Load;
            panel1.ResumeLayout(false);
            panel1.PerformLayout();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Panel panel1;
        private Label lbl_Header;
        private Label lbl_Username;
        private Label lbl_Password;
        private TextBox txb_Username;
        private TextBox txb_Password;
        private Button btn_Login;
    }
}