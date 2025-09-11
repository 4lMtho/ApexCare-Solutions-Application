using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using ApexCareApp.Control;

namespace ApexCareApp
{
    public partial class LoginForm : Form
    {
        private FileHandler fileHandler;
        public LoginForm()
        {
            InitializeComponent();
            fileHandler = new FileHandler();
        }

        private void LoginForm_Load(object sender, EventArgs e)
        {

        }

        private void OpenAdminForm()
        {
            AdminForm adminForm = new AdminForm();
            adminForm.Show();
            this.Hide();
        }

        private void OpenClientForm()
        {
            ClientForm clientForm = new ClientForm();
            clientForm.Show();
            this.Hide();
        }

        private void OpenTechnicianForm()
        {
            TechnicianForm technicianForm = new TechnicianForm();
            technicianForm.Show();
            this.Hide();
        }
        private void btn_Login_Click(object sender, EventArgs e)
        {
            string username = txb_Username.Text.Trim();
            string password = txb_Password.Text.Trim();

            string role = fileHandler.GetRoleIfLoginValid(username, password);

            if (!string.IsNullOrEmpty(role))
            {
                // Open different forms based on the role
                switch (role.ToLower())
                {
                    case "admin":
                        OpenAdminForm();
                        break;
                    case "client":
                        OpenClientForm();
                        break;
                    case "technician":
                        OpenTechnicianForm();
                        break;
                    default:
                        MessageBox.Show("Unknown role", "Login Failed", MessageBoxButtons.OK, MessageBoxIcon.Error);
                        break;
                }
            }
            else
            {
                // Show error message if login fails
                MessageBox.Show("Invalid username or password", "Login Failed", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void LoginForm_FormClosing(object sender, FormClosingEventArgs e)
        {
            Application.Exit();
        }
    }
}

