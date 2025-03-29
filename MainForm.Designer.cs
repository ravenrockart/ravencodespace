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

            // 
            // txtName
            // 
            this.txtName.Location = new System.Drawing.Point(12, 12);
            this.txtName.Name = "txtName";
            this.txtName.Size = new System.Drawing.Size(200, 20);
            this.txtName.TabIndex = 0;
            // 
            // txtEmail
            // 
            this.txtEmail.Location = new System.Drawing.Point(12, 38);
            this.txtEmail.Name = "txtEmail";
            this.txtEmail.Size = new System.Drawing.Size(200, 20);
            this.txtEmail.TabIndex = 1;
            // 
            // txtPhone
            // 
            this.txtPhone.Location = new System.Drawing.Point(12, 64);
            this.txtPhone.Name = "txtPhone";
            this.txtPhone.Size = new System.Drawing.Size(200, 20);
            this.txtPhone.TabIndex = 2;
            // 
            // dtCaseDate
            // 
            this.dtCaseDate.Location = new System.Drawing.Point(12, 90);
            this.dtCaseDate.Name = "dtCaseDate";
            this.dtCaseDate.Size = new System.Drawing.Size(200, 20);
            this.dtCaseDate.TabIndex = 3;
            // 
            // txtWorkOrder
            // 
            this.txtWorkOrder.Location = new System.Drawing.Point(12, 116);
            this.txtWorkOrder.Name = "txtWorkOrder";
            this.txtWorkOrder.Size = new System.Drawing.Size(200, 20);
            this.txtWorkOrder.TabIndex = 4;
            // 
            // txtReason
            // 
            this.txtReason.Location = new System.Drawing.Point(12, 142);
            this.txtReason.Multiline = true;
            this.txtReason.Name = "txtReason";
            this.txtReason.Size = new System.Drawing.Size(200, 60);
            this.txtReason.TabIndex = 5;
            // 
            // txtAnswer
            // 
            this.txtAnswer.Location = new System.Drawing.Point(12, 208);
            this.txtAnswer.Multiline = true;
            this.txtAnswer.Name = "txtAnswer";
            this.txtAnswer.Size = new System.Drawing.Size(200, 60);
            this.txtAnswer.TabIndex = 6;
            // 
            // txtContractID
            // 
            this.txtContractID.Location = new System.Drawing.Point(12, 274);
            this.txtContractID.Name = "txtContractID";
            this.txtContractID.Size = new System.Drawing.Size(200, 20);
            this.txtContractID.TabIndex = 7;
            // 
            // dtExpiry
            // 
            this.dtExpiry.Location = new System.Drawing.Point(12, 300);
            this.dtExpiry.Name = "dtExpiry";
            this.dtExpiry.Size = new System.Drawing.Size(200, 20);
            this.dtExpiry.TabIndex = 8;
            // 
            // txtCoverage
            // 
            this.txtCoverage.Location = new System.Drawing.Point(12, 326);
            this.txtCoverage.Name = "txtCoverage";
            this.txtCoverage.Size = new System.Drawing.Size(200, 20);
            this.txtCoverage.TabIndex = 9;
            // 
            // txtPartNumber
            // 
            this.txtPartNumber.Location = new System.Drawing.Point(12, 352);
            this.txtPartNumber.Name = "txtPartNumber";
            this.txtPartNumber.Size = new System.Drawing.Size(200, 20);
            this.txtPartNumber.TabIndex = 10;
            // 
            // numQuantity
            // 
            this.numQuantity.Location = new System.Drawing.Point(12, 378);
            this.numQuantity.Name = "numQuantity";
            this.numQuantity.Size = new System.Drawing.Size(200, 20);
            this.numQuantity.TabIndex = 11;
            // 
            // cmbStatus
            // 
            this.cmbStatus.FormattingEnabled = true;
            this.cmbStatus.Items.AddRange(new object[] { "Pending", "Shipped", "Delivered", "Cancelled" });
            this.cmbStatus.Location = new System.Drawing.Point(12, 404);
            this.cmbStatus.Name = "cmbStatus";
            this.cmbStatus.Size = new System.Drawing.Size(200, 21);
            this.cmbStatus.TabIndex = 12;
            this.cmbStatus.SelectedIndex = 0;
            // 
            // dgvPartOrders
            // 
            this.dgvPartOrders.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvPartOrders.Location = new System.Drawing.Point(218, 12);
            this.dgvPartOrders.Name = "dgvPartOrders";
            this.dgvPartOrders.Size = new System.Drawing.Size(240, 400);
            this.dgvPartOrders.TabIndex = 13;
            this.dgvPartOrders.Columns.Add("PartNumber", "Part Number");
            this.dgvPartOrders.Columns.Add("Quantity", "Quantity");
            this.dgvPartOrders.Columns.Add("Status", "Status");
            // 
            // btnAddPart
            // 
            this.btnAddPart.Location = new System.Drawing.Point(12, 431);
            this.btnAddPart.Name = "btnAddPart";
            this.btnAddPart.Size = new System.Drawing.Size(75, 23);
            this.btnAddPart.TabIndex = 14;
            this.btnAddPart.Text = "Add Part";
            this.btnAddPart.UseVisualStyleBackColor = true;
            // 
            // btnSave
            // 
            this.btnSave.Location = new System.Drawing.Point(137, 431);
            this.btnSave.Name = "btnSave";
            this.btnSave.Size = new System.Drawing.Size(75, 23);
            this.btnSave.TabIndex = 15;
            this.btnSave.Text = "Save";
            this.btnSave.UseVisualStyleBackColor = true;
            // 
            // MainForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(470, 466);
            this.Controls.Add(this.btnSave);
            this.Controls.Add(this.btnAddPart);
            this.Controls.Add(this.dgvPartOrders);
            this.Controls.Add(this.cmbStatus);
            this.Controls.Add(this.numQuantity);
            this.Controls.Add(this.txtPartNumber);
            this.Controls.Add(this.txtCoverage);
            this.Controls.Add(this.dtExpiry);
            this.Controls.Add(this.txtContractID);
            this.Controls.Add(this.txtAnswer);
            this.Controls.Add(this.txtReason);
            this.Controls.Add(this.txtWorkOrder);
            this.Controls.Add(this.dtCaseDate);
            this.Controls.Add(this.txtPhone);
            this.Controls.Add(this.txtEmail);
            this.Controls.Add(this.txtName);
            this.Name = "MainForm";
            this.Text = "Tech Support Form";
            ((System.ComponentModel.ISupportInitialize)(this.numQuantity)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dgvPartOrders)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();
        }
    }
}
