
namespace TechSupportFormApp
{
    partial class MainForm
    {
        private System.ComponentModel.IContainer components = null;

        private System.Windows.Forms.TextBox txtName;
        private System.Windows.Forms.TextBox txtEmail;
        private System.Windows.Forms.TextBox txtPhone;
        private System.Windows.Forms.DateTimePicker dtCaseDate;
        private System.Windows.Forms.TextBox txtWorkOrder;
        private System.Windows.Forms.TextBox txtReason;
        private System.Windows.Forms.TextBox txtAnswer;
        private System.Windows.Forms.TextBox txtContractID;
        private System.Windows.Forms.DateTimePicker dtExpiry;
        private System.Windows.Forms.TextBox txtCoverage;
        private System.Windows.Forms.TextBox txtPartNumber;
        private System.Windows.Forms.NumericUpDown numQuantity;
        private System.Windows.Forms.ComboBox cmbStatus;
        private System.Windows.Forms.DataGridView dgvPartOrders;
        private System.Windows.Forms.Button btnAddPart;
        private System.Windows.Forms.Button btnSave;

        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        private void InitializeComponent()
        {
            this.txtName = new System.Windows.Forms.TextBox();
            this.txtEmail = new System.Windows.Forms.TextBox();
            this.txtPhone = new System.Windows.Forms.TextBox();
            this.dtCaseDate = new System.Windows.Forms.DateTimePicker();
            this.txtWorkOrder = new System.Windows.Forms.TextBox();
            this.txtReason = new System.Windows.Forms.TextBox();
            this.txtAnswer = new System.Windows.Forms.TextBox();
            this.txtContractID = new System.Windows.Forms.TextBox();
            this.dtExpiry = new System.Windows.Forms.DateTimePicker();
            this.txtCoverage = new System.Windows.Forms.TextBox();
            this.txtPartNumber = new System.Windows.Forms.TextBox();
            this.numQuantity = new System.Windows.Forms.NumericUpDown();
            this.cmbStatus = new System.Windows.Forms.ComboBox();
            this.dgvPartOrders = new System.Windows.Forms.DataGridView();
            this.btnAddPart = new System.Windows.Forms.Button();
            this.btnSave = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.numQuantity)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dgvPartOrders)).BeginInit();
            this.SuspendLayout();

            // Skipping control layout for brevity

            this.ResumeLayout(false);
            this.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.numQuantity)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dgvPartOrders)).EndInit();
        }
    }
}
