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
    public partial class AdminForm : Form
    {
        private DataHandler dataHandler;
        public AdminForm()
        {
            InitializeComponent();
            dataHandler = new DataHandler();
            LoadClientData();
            LoadTechnicianData();
        }

        private void OpenLoginForm()
        {
            LoginForm loginForm = new LoginForm();
            loginForm.Show();
            this.Hide();
        }

        private void btnLogout_Click(object sender, EventArgs e)
        {
            OpenLoginForm();
        }

        private void LoadClientData()
        {
            try
            {
                DataTable clientData = dataHandler.GetClientData();
                dgv_Clients.DataSource = clientData;
                int totalWidth = 1150;
                int numberOfColumns = dgv_Clients.Columns.Count;
                int columnWidth = totalWidth / numberOfColumns;
                foreach (DataGridViewColumn column in dgv_Clients.Columns)
                {
                    column.Width = columnWidth;
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Error loading client data: {ex.Message}");
            }
        }

        private void LoadTechnicianData()
        {
            try
            {
                DataTable technicianData = dataHandler.GetTechnicianData();
                dgv_Tech.DataSource = technicianData;
                int totalWidth = 1150;
                int numberOfColumns = dgv_Tech.Columns.Count;
                int columnWidth = totalWidth / numberOfColumns;
                foreach (DataGridViewColumn column in dgv_Tech.Columns)
                {
                    column.Width = columnWidth;
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Error loading technician data: {ex.Message}");
            }
        }

        private void AdminForm_FormClosing(object sender, FormClosingEventArgs e)
        {
            Application.Exit();
        }

        private void AdminForm_Load(object sender, EventArgs e)
        {

        }
    }
}
