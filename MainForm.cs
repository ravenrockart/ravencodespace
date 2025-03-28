
using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Windows.Forms;

namespace TechSupportFormApp
{
    public partial class MainForm : Form
    {
        List<PartOrder> partOrders = new List<PartOrder>();

        public MainForm()
        {
            InitializeComponent();
        }

        private void btnAddPart_Click(object sender, EventArgs e)
        {
            var part = new PartOrder
            {
                PartNumber = txtPartNumber.Text,
                Quantity = (int)numQuantity.Value,
                Status = cmbStatus.Text
            };

            partOrders.Add(part);
            dgvPartOrders.Rows.Add(part.PartNumber, part.Quantity, part.Status);
            txtPartNumber.Clear();
            numQuantity.Value = 1;
            cmbStatus.SelectedIndex = 0;
        }

        private void btnSave_Click(object sender, EventArgs e)
        {
            string connectionString = "Server=YOUR_SERVER;Database=YOUR_DB;Trusted_Connection=True;";
            using (SqlConnection conn = new SqlConnection(connectionString))
            {
                conn.Open();

                string insertCaseQuery = @"
                    INSERT INTO TechSupportCase 
                    (CustomerName, Email, Phone, CaseDate, WorkOrderNumber, ReasonForCall, AnswerGiven, ContractID, ContractExpiry, CoverageDetails) 
                    OUTPUT INSERTED.CaseID
                    VALUES (@name, @mail, @phone, @date, @work, @reason, @answer, @contract, @expiry, @coverage)";

                SqlCommand caseCmd = new SqlCommand(insertCaseQuery, conn);
                caseCmd.Parameters.AddWithValue("@name", txtName.Text);
                caseCmd.Parameters.AddWithValue("@mail", txtEmail.Text);
                caseCmd.Parameters.AddWithValue("@phone", txtPhone.Text);
                caseCmd.Parameters.AddWithValue("@date", dtCaseDate.Value);
                caseCmd.Parameters.AddWithValue("@work", txtWorkOrder.Text);
                caseCmd.Parameters.AddWithValue("@reason", txtReason.Text);
                caseCmd.Parameters.AddWithValue("@answer", txtAnswer.Text);
                caseCmd.Parameters.AddWithValue("@contract", txtContractID.Text);
                caseCmd.Parameters.AddWithValue("@expiry", dtExpiry.Value);
                caseCmd.Parameters.AddWithValue("@coverage", txtCoverage.Text);

                int caseID = (int)caseCmd.ExecuteScalar();

                foreach (var part in partOrders)
                {
                    string insertPartQuery = @"
                        INSERT INTO PartOrder (CaseID, PartNumber, Quantity, Status) 
                        VALUES (@caseID, @part, @qty, @status)";
                    SqlCommand partCmd = new SqlCommand(insertPartQuery, conn);
                    partCmd.Parameters.AddWithValue("@caseID", caseID);
                    partCmd.Parameters.AddWithValue("@part", part.PartNumber);
                    partCmd.Parameters.AddWithValue("@qty", part.Quantity);
                    partCmd.Parameters.AddWithValue("@status", part.Status);
                    partCmd.ExecuteNonQuery();
                }

                MessageBox.Show("Case and part orders saved successfully.");
                ClearForm();
            }
        }

        private void ClearForm()
        {
            txtName.Clear(); txtEmail.Clear(); txtPhone.Clear();
            txtWorkOrder.Clear(); txtReason.Clear(); txtAnswer.Clear();
            txtContractID.Clear(); txtCoverage.Clear();
            dtCaseDate.Value = DateTime.Today; dtExpiry.Value = DateTime.Today;
            dgvPartOrders.Rows.Clear();
            partOrders.Clear();
        }
    }

    public class PartOrder
    {
        public string PartNumber { get; set; }
        public int Quantity { get; set; }
        public string Status { get; set; }
    }
}
