using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using ApexCare.Model.Clients;
using ApexCareApp.Control;

namespace ApexCareApp
{
    public partial class ClientForm : Form
    {
        private DataHandler dataHandler;
        private DataRow clientData;
        public ClientForm()
        {
            InitializeComponent();
            dataHandler = new DataHandler();
            LoadClientData(1);
            LoadClientContracts(1);
            LoadClientServiceRequests(1);
            LoadClientRequests(1);
        }

        private void btnLogout_Click(object sender, EventArgs e)
        {
            OpenLoginForm();
        }

        private void OpenLoginForm()
        {
            LoginForm loginForm = new LoginForm();
            loginForm.Show();
            this.Hide();
        }

        private void ClientForm_FormClosing(object sender, FormClosingEventArgs e)
        {
            Application.Exit();
        }

        private void LoadClientData(int clientID)
        {
            clientData = dataHandler.GetClientByID(clientID);

            if (clientData != null)
            {
                lbl_N.Text = clientData["ClientName"].ToString();
                lbl_CP.Text = clientData["ContactPerson"].ToString();
                lbl_E.Text = clientData["EmailAddress"].ToString();
                lbl_PN.Text = clientData["ContactNumber"].ToString();
            }
            else
            {
                MessageBox.Show("Client not found.");
            }
        }
        private void LoadClientContracts(int clientID)
        {
            DataTable contractData = dataHandler.GetClientContracts(clientID);

            if (contractData.Rows.Count > 0)
            {
                dgv_Contracts.DataSource = contractData;
                int totalWidth = 1150;
                int numberOfColumns = dgv_Contracts.Columns.Count;
                int columnWidth = totalWidth / numberOfColumns;
                foreach (DataGridViewColumn column in dgv_Contracts.Columns)
                {
                    column.Width = columnWidth;
                }
            }
            else
            {
                MessageBox.Show("No contracts found for this client.");
            }
        }
        private void LoadClientServiceRequests(int clientID)
        {
            DataTable serviceRequestData = dataHandler.GetClientServiceRequests(clientID);

            if (serviceRequestData.Rows.Count > 0)
            {
                dgv_ServiceRequests.DataSource = serviceRequestData;
                int totalWidth = 1150;
                int numberOfColumns = dgv_ServiceRequests.Columns.Count;
                int columnWidth = totalWidth / numberOfColumns;
                foreach (DataGridViewColumn column in dgv_ServiceRequests.Columns)
                {
                    column.Width = columnWidth;
                }
            }
            else
            {
                MessageBox.Show("No service requests found for this client.");
            }
        }

        private void LoadClientRequests(int clientID)
        {

            DataTable clientRequests = dataHandler.GetClientServiceRequests(clientID);
            cmb_requests.DisplayMember = "RequestIssue";
            cmb_requests.ValueMember = "RequestID";
            cmb_requests.DataSource = clientRequests;
        }

        private void btn_Submit_Click(object sender, EventArgs e)
        {
            int requestID = (int)cmb_requests.SelectedValue;
            int satisfactionRating = GetSelectedRating(); 
            string feedbackMessage = txb_message.Text;
            bool requiresFollowUp = chb_followup.Checked;

            dataHandler.SubmitFeedback(requestID, satisfactionRating, feedbackMessage, requiresFollowUp);
            MessageBox.Show("Feedback submitted successfully!", "Feedback", MessageBoxButtons.OK, MessageBoxIcon.Information);

        }

        private int GetSelectedRating()
        {
            if (rdb_1.Checked) return 1;
            if (rdb_2.Checked) return 2;
            if (rdb_3.Checked) return 3;
            if (rdb_4.Checked) return 4;
            if (rdb_5.Checked) return 5;
            return 0;
        }
    }
}
