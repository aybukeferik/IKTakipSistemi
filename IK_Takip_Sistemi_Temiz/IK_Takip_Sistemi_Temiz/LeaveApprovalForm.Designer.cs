namespace IK_Takip_Sistemi_Temiz
{
    partial class LeaveApprovalForm
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
            this.dgvLeaves = new System.Windows.Forms.DataGridView();
            this.btnApprove = new System.Windows.Forms.Button();
            this.btnReject = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.dgvLeaves)).BeginInit();
            this.SuspendLayout();
            // 
            // dgvLeaves
            // 
            this.dgvLeaves.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvLeaves.Dock = System.Windows.Forms.DockStyle.Top;
            this.dgvLeaves.Location = new System.Drawing.Point(0, 0);
            this.dgvLeaves.Name = "dgvLeaves";
            this.dgvLeaves.RowHeadersWidth = 49;
            this.dgvLeaves.RowTemplate.Height = 24;
            this.dgvLeaves.Size = new System.Drawing.Size(800, 182);
            this.dgvLeaves.TabIndex = 0;
            // 
            // btnApprove
            // 
            this.btnApprove.Location = new System.Drawing.Point(111, 265);
            this.btnApprove.Name = "btnApprove";
            this.btnApprove.Size = new System.Drawing.Size(122, 68);
            this.btnApprove.TabIndex = 1;
            this.btnApprove.Text = "İzin Onayla";
            this.btnApprove.UseVisualStyleBackColor = true;
            this.btnApprove.Click += new System.EventHandler(this.btnApprove_Click);
            // 
            // btnReject
            // 
            this.btnReject.Location = new System.Drawing.Point(305, 265);
            this.btnReject.Name = "btnReject";
            this.btnReject.Size = new System.Drawing.Size(128, 68);
            this.btnReject.TabIndex = 2;
            this.btnReject.Text = "İzin Reddet";
            this.btnReject.UseVisualStyleBackColor = true;
            this.btnReject.Click += new System.EventHandler(this.btnReject_Click);
            // 
            // LeaveApprovalForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.btnReject);
            this.Controls.Add(this.btnApprove);
            this.Controls.Add(this.dgvLeaves);
            this.Name = "LeaveApprovalForm";
            this.Text = "LeaveApprovalForm";
            this.Load += new System.EventHandler(this.LeaveApprovalForm_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dgvLeaves)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.DataGridView dgvLeaves;
        private System.Windows.Forms.Button btnApprove;
        private System.Windows.Forms.Button btnReject;
    }
}