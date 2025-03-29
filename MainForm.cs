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
            if (string.IsNullOrWhiteSpace(txtName.Text) || string.IsNullOrWhiteSpace(txtEmail.Text) || string.IsNullOrWhiteSpace(txtPhone.Text))
            {
                MessageBox.Show("Please fill in all required fields.");
                return;
            }

            try
            {
                using (SqlConnection conn = new SqlConnection(connectionString))
                {
                    conn.Open();

                    string insertCaseQuery = @"
                        INSERT INTO TechSupportCase 
                        (CustomerName, Email, Phone, CaseDate, WorkOrderNumber, ReasonForCall, AnswerGiven, ContractID, ContractExpiry, CoverageDetails) 
                        OUTPUT INSERTED.CaseID
                        VALUES (@name, @mail, @phone, @date, @work, @reason, @answer, @contract, @expiry, @coverage)";

                    SqlCommand caseCmd = new SqlCommand(insertCaseQuery, conn);
                    caseCmd.Parameters.Add("@name", System.Data.SqlDbType.NVarChar).Value = txtName.Text;
                    caseCmd.Parameters.Add("@mail", System.Data.SqlDbType.NVarChar).Value = txtEmail.Text;
                    caseCmd.Parameters.Add("@phone", System.Data.SqlDbType.NVarChar).Value = txtPhone.Text;
                    caseCmd.Parameters.Add("@date", System.Data.SqlDbType.DateTime).Value = dtCaseDate.Value;
                    caseCmd.Parameters.Add("@work", System.Data.SqlDbType.NVarChar).Value = txtWorkOrder.Text;
                    caseCmd.Parameters.Add("@reason", System.Data.SqlDbType.NVarChar).Value = txtReason.Text;
                    caseCmd.Parameters.Add("@answer", System.Data.SqlDbType.NVarChar).Value = txtAnswer.Text;
                    caseCmd.Parameters.Add("@contract", System.Data.SqlDbType.NVarChar).Value = txtContractID.Text;
                    caseCmd.Parameters.Add("@expiry", System.Data.SqlDbType.DateTime).Value = dtExpiry.Value;
                    caseCmd.Parameters.Add("@coverage", System.Data.SqlDbType.NVarChar).Value = txtCoverage.Text;

                    int caseID = (int)caseCmd.ExecuteScalar();

                    foreach (var part in partOrders)
                    {
                        string insertPartQuery = @"
                            INSERT INTO PartOrder (CaseID, PartNumber, Quantity, Status) 
                            VALUES (@caseID, @part, @qty, @status)";
                        SqlCommand partCmd = new SqlCommand(insertPartQuery, conn);
                        partCmd.Parameters.Add("@caseID", System.Data.SqlDbType.Int).Value = caseID;
                        partCmd.Parameters.Add("@part", System.Data.SqlDbType.NVarChar).Value = part.PartNumber;
                        partCmd.Parameters.Add("@qty", System.Data.SqlDbType.Int).Value = part.Quantity;
                        partCmd.Parameters.Add("@status", System.Data.SqlDbType.NVarChar).Value = part.Status;
                        partCmd.ExecuteNonQuery();
                    }

                    MessageBox.Show("Case and part orders saved successfully.");
                    ClearForm();
                }
            }
            catch (SqlException sqlEx)
            {
                MessageBox.Show($"Database error: {sqlEx.Message}");
            }
            catch (Exception ex)
            {
                MessageBox.Show($"An error occurred: {ex.Message}");
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
