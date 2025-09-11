using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using ApexCare.Model.Technicians;
using ApexCareApp.Control;

namespace ApexCareApp
{
    public partial class TechnicianForm : Form
    {
        private DataHandler dataHandler;
        private DataRow technicianData;
        public TechnicianForm()
        {
            InitializeComponent();
            dataHandler = new DataHandler();
            LoadTechnicianData(1);
            LoadTechnicianSpecializations(1);
            LoadTechnicianRequests(1);
            LoadAssignedRequests(1);
        }

        private void TechnicianForm_Load(object sender, EventArgs e)
        {

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

        private void LoadTechnicianData(int technicianID)
        {
            technicianData = dataHandler.GetTechnicianByID(technicianID);

            if (technicianData != null)
            {
                lbl_N.Text = technicianData["Name"].ToString();
                lbl_PN.Text = technicianData["PhoneNum"].ToString();
                lbl_S.Text = technicianData["Suburb"].ToString();
                lbl_C.Text = technicianData["City"].ToString();
                lbl_P.Text = technicianData["Province"].ToString();
                lbl_T.Text = technicianData["Type"].ToString();
            }
            else
            {
                MessageBox.Show("Technician not found.");
            }
        }

        private void LoadTechnicianSpecializations(int technicianID)
        {
            DataTable specializationData = dataHandler.GetTechnicianSpecializations(technicianID);

            if (specializationData.Rows.Count > 0)
            {
                foreach (DataRow row in specializationData.Rows)
                {
                    string specialization = row["EquipmentSpecialty"].ToString();
                    if (specialization == "Printers")
                    {
                        chb_Printers.Checked = true;
                    }
                    else if (specialization == "HVAC")
                    {
                        chb_HVAC.Checked = true;
                    }
                    else if (specialization == "Copiers")
                    {
                        chb_Copiers.Checked = true;
                    }
                    else if (specialization == "Generators")
                    {
                        chb_Generators.Checked = true;
                    }

                }
            }
            else
            {
                MessageBox.Show("No specializations found for this technician.");
            }
        }

        private void LoadTechnicianRequests(int technicianID)
        {
            DataTable requestData = dataHandler.GetTechnicianRequests(technicianID);

            if (requestData.Rows.Count > 0)
            {
                dgv_assignments.DataSource = requestData;
                dgv_assignments.Columns["RequestID"].HeaderText = "Request ID";
                dgv_assignments.Columns["City"].HeaderText = "City";
                dgv_assignments.Columns["RequestIssue"].HeaderText = "Request Issue";
                dgv_assignments.Columns["LatestUpdate"].HeaderText = "Latest Update";
                dgv_assignments.Columns["Completed"].HeaderText = "Completed";
                int totalWidth = 1150;
                int numberOfColumns = dgv_assignments.Columns.Count;
                int columnWidth = totalWidth / numberOfColumns;
                foreach (DataGridViewColumn column in dgv_assignments.Columns)
                {
                    column.Width = columnWidth;
                }
            }
            else
            {
                MessageBox.Show("No requests found for this technician.");
            }
        }
        private void LoadAssignedRequests(int technicianID)
        {
            DataTable assignedRequests = dataHandler.GetTechnicianRequests(technicianID);

            cmb_assignment.DataSource = assignedRequests;
            cmb_assignment.DisplayMember = "RequestIssue";
            cmb_assignment.ValueMember = "RequestID";
        }

        private void btn_Submit_Click(object sender, EventArgs e)
        {
            int requestID = Convert.ToInt32(cmb_assignment.SelectedValue);
            string updateMessage = txb_message.Text;
            bool isCompleted = rdb_Completed.Checked;
            dataHandler.UpdateRequest(requestID, updateMessage, isCompleted);
            txb_message.Clear();
            LoadTechnicianRequests(1);
            MessageBox.Show("Update submitted successfully.");
        }

        private void TechnicianForm_FormClosing(object sender, FormClosingEventArgs e)
        {
            Application.Exit();
        }
    }
}


