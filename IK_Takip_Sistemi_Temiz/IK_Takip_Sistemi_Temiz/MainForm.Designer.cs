namespace IK_Takip_Sistemi_Temiz
{
    partial class MainForm
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
            this.lblUserName = new System.Windows.Forms.Label();
            this.btnEmployee = new System.Windows.Forms.Button();
            this.btnLeaveApproval = new System.Windows.Forms.Button();
            this.btnDepartment = new System.Windows.Forms.Button();
            this.btnSalary = new System.Windows.Forms.Button();
            this.btnPerformance = new System.Windows.Forms.Button();
            this.btnReport = new System.Windows.Forms.Button();
            this.btnLeaveRequest = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // lblUserName
            // 
            this.lblUserName.AutoSize = true;
            this.lblUserName.Location = new System.Drawing.Point(131, 81);
            this.lblUserName.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblUserName.Name = "lblUserName";
            this.lblUserName.Size = new System.Drawing.Size(44, 16);
            this.lblUserName.TabIndex = 0;
            this.lblUserName.Text = "label1";
            // 
            // btnEmployee
            // 
            this.btnEmployee.Location = new System.Drawing.Point(406, 271);
            this.btnEmployee.Margin = new System.Windows.Forms.Padding(4);
            this.btnEmployee.Name = "btnEmployee";
            this.btnEmployee.Size = new System.Drawing.Size(220, 58);
            this.btnEmployee.TabIndex = 1;
            this.btnEmployee.Text = "Personel Yönetimi";
            this.btnEmployee.UseVisualStyleBackColor = true;
            this.btnEmployee.Click += new System.EventHandler(this.button1_Click);
            // 
            // btnLeaveApproval
            // 
            this.btnLeaveApproval.Location = new System.Drawing.Point(134, 206);
            this.btnLeaveApproval.Margin = new System.Windows.Forms.Padding(4);
            this.btnLeaveApproval.Name = "btnLeaveApproval";
            this.btnLeaveApproval.Size = new System.Drawing.Size(220, 55);
            this.btnLeaveApproval.TabIndex = 2;
            this.btnLeaveApproval.Text = "İzin Yönetimi";
            this.btnLeaveApproval.UseVisualStyleBackColor = true;
            this.btnLeaveApproval.Click += new System.EventHandler(this.button2_Click);
            // 
            // btnDepartment
            // 
            this.btnDepartment.Location = new System.Drawing.Point(134, 269);
            this.btnDepartment.Margin = new System.Windows.Forms.Padding(4);
            this.btnDepartment.Name = "btnDepartment";
            this.btnDepartment.Size = new System.Drawing.Size(220, 60);
            this.btnDepartment.TabIndex = 3;
            this.btnDepartment.Text = "Departman Yönetimi";
            this.btnDepartment.UseVisualStyleBackColor = true;
            this.btnDepartment.Click += new System.EventHandler(this.button3_Click);
            // 
            // btnSalary
            // 
            this.btnSalary.Location = new System.Drawing.Point(134, 336);
            this.btnSalary.Name = "btnSalary";
            this.btnSalary.Size = new System.Drawing.Size(220, 57);
            this.btnSalary.TabIndex = 4;
            this.btnSalary.Text = "Maaş Hesaplama";
            this.btnSalary.UseVisualStyleBackColor = true;
            this.btnSalary.Click += new System.EventHandler(this.btnSalary_Click);
            // 
            // btnPerformance
            // 
            this.btnPerformance.Location = new System.Drawing.Point(405, 203);
            this.btnPerformance.Name = "btnPerformance";
            this.btnPerformance.Size = new System.Drawing.Size(221, 58);
            this.btnPerformance.TabIndex = 5;
            this.btnPerformance.Text = "Performans Değerlendirme";
            this.btnPerformance.UseVisualStyleBackColor = true;
            this.btnPerformance.Click += new System.EventHandler(this.btnPerformance_Click);
            // 
            // btnReport
            // 
            this.btnReport.Location = new System.Drawing.Point(405, 338);
            this.btnReport.Name = "btnReport";
            this.btnReport.Size = new System.Drawing.Size(221, 55);
            this.btnReport.TabIndex = 6;
            this.btnReport.Text = "Raporlama";
            this.btnReport.UseVisualStyleBackColor = true;
            this.btnReport.Click += new System.EventHandler(this.btnReports_Click);
            // 
            // btnLeaveRequest
            // 
            this.btnLeaveRequest.Location = new System.Drawing.Point(134, 143);
            this.btnLeaveRequest.Name = "btnLeaveRequest";
            this.btnLeaveRequest.Size = new System.Drawing.Size(220, 56);
            this.btnLeaveRequest.TabIndex = 7;
            this.btnLeaveRequest.Text = "İzin Talebi";
            this.btnLeaveRequest.UseVisualStyleBackColor = true;
            this.btnLeaveRequest.Click += new System.EventHandler(this.btnLeaveRequest_Click);
            // 
            // MainForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1067, 554);
            this.Controls.Add(this.btnLeaveRequest);
            this.Controls.Add(this.btnReport);
            this.Controls.Add(this.btnPerformance);
            this.Controls.Add(this.btnSalary);
            this.Controls.Add(this.btnDepartment);
            this.Controls.Add(this.btnLeaveApproval);
            this.Controls.Add(this.btnEmployee);
            this.Controls.Add(this.lblUserName);
            this.Margin = new System.Windows.Forms.Padding(4);
            this.Name = "MainForm";
            this.Text = "MainForm";
            this.Load += new System.EventHandler(this.MainForm_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lblUserName;
        private System.Windows.Forms.Button btnEmployee;
        private System.Windows.Forms.Button btnLeaveApproval;
        private System.Windows.Forms.Button btnDepartment;
        private System.Windows.Forms.Button btnSalary;
        private System.Windows.Forms.Button btnPerformance;
        private System.Windows.Forms.Button btnReport;
        private System.Windows.Forms.Button btnLeaveRequest;
    }
}