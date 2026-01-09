namespace IK_Takip_Sistemi_Temiz
{
    partial class SalaryForm
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
            this.cmbEmployee = new System.Windows.Forms.ComboBox();
            this.nudBaseSalary = new System.Windows.Forms.NumericUpDown();
            this.nudBonus = new System.Windows.Forms.NumericUpDown();
            this.nudDeduction = new System.Windows.Forms.NumericUpDown();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.btnCalculate = new System.Windows.Forms.Button();
            this.lblNetSalary = new System.Windows.Forms.Label();
            this.btnClear = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.nudBaseSalary)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.nudBonus)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.nudDeduction)).BeginInit();
            this.SuspendLayout();
            // 
            // cmbEmployee
            // 
            this.cmbEmployee.FormattingEnabled = true;
            this.cmbEmployee.Location = new System.Drawing.Point(105, 49);
            this.cmbEmployee.Name = "cmbEmployee";
            this.cmbEmployee.Size = new System.Drawing.Size(186, 24);
            this.cmbEmployee.TabIndex = 0;
            this.cmbEmployee.SelectedIndexChanged += new System.EventHandler(this.cmbEmployee_SelectedIndexChanged);
            // 
            // nudBaseSalary
            // 
            this.nudBaseSalary.DecimalPlaces = 2;
            this.nudBaseSalary.Increment = new decimal(new int[] {
            100,
            0,
            0,
            0});
            this.nudBaseSalary.Location = new System.Drawing.Point(130, 122);
            this.nudBaseSalary.Maximum = new decimal(new int[] {
            1000000,
            0,
            0,
            0});
            this.nudBaseSalary.Name = "nudBaseSalary";
            this.nudBaseSalary.Size = new System.Drawing.Size(120, 22);
            this.nudBaseSalary.TabIndex = 1;
            // 
            // nudBonus
            // 
            this.nudBonus.DecimalPlaces = 2;
            this.nudBonus.Increment = new decimal(new int[] {
            50,
            0,
            0,
            0});
            this.nudBonus.Location = new System.Drawing.Point(130, 193);
            this.nudBonus.Maximum = new decimal(new int[] {
            50000,
            0,
            0,
            0});
            this.nudBonus.Name = "nudBonus";
            this.nudBonus.Size = new System.Drawing.Size(120, 22);
            this.nudBonus.TabIndex = 2;
            // 
            // nudDeduction
            // 
            this.nudDeduction.DecimalPlaces = 2;
            this.nudDeduction.Increment = new decimal(new int[] {
            50,
            0,
            0,
            0});
            this.nudDeduction.Location = new System.Drawing.Point(130, 258);
            this.nudDeduction.Maximum = new decimal(new int[] {
            50000,
            0,
            0,
            0});
            this.nudDeduction.Name = "nudDeduction";
            this.nudDeduction.Size = new System.Drawing.Size(120, 22);
            this.nudDeduction.TabIndex = 3;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(102, 30);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(110, 16);
            this.label1.TabIndex = 4;
            this.label1.Text = "Personel Seçiniz:";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(127, 103);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(70, 16);
            this.label2.TabIndex = 5;
            this.label2.Text = "Brüt Maaş:";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(127, 174);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(37, 16);
            this.label3.TabIndex = 6;
            this.label3.Text = "Prim:";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(130, 236);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(49, 16);
            this.label4.TabIndex = 7;
            this.label4.Text = "Kesinti:";
            // 
            // btnCalculate
            // 
            this.btnCalculate.Location = new System.Drawing.Point(130, 323);
            this.btnCalculate.Name = "btnCalculate";
            this.btnCalculate.Size = new System.Drawing.Size(117, 41);
            this.btnCalculate.TabIndex = 8;
            this.btnCalculate.Text = "Hesapla";
            this.btnCalculate.UseVisualStyleBackColor = true;
            this.btnCalculate.Click += new System.EventHandler(this.btnCalculate_Click);
            // 
            // lblNetSalary
            // 
            this.lblNetSalary.AutoSize = true;
            this.lblNetSalary.Location = new System.Drawing.Point(143, 392);
            this.lblNetSalary.Name = "lblNetSalary";
            this.lblNetSalary.Size = new System.Drawing.Size(88, 16);
            this.lblNetSalary.TabIndex = 9;
            this.lblNetSalary.Text = "Net Maaş: 0 ₺";
            // 
            // btnClear
            // 
            this.btnClear.Location = new System.Drawing.Point(302, 323);
            this.btnClear.Name = "btnClear";
            this.btnClear.Size = new System.Drawing.Size(113, 41);
            this.btnClear.TabIndex = 10;
            this.btnClear.Text = "Temizle";
            this.btnClear.UseVisualStyleBackColor = true;
            this.btnClear.Click += new System.EventHandler(this.btnClear_Click);
            // 
            // SalaryForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.btnClear);
            this.Controls.Add(this.lblNetSalary);
            this.Controls.Add(this.btnCalculate);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.nudDeduction);
            this.Controls.Add(this.nudBonus);
            this.Controls.Add(this.nudBaseSalary);
            this.Controls.Add(this.cmbEmployee);
            this.Name = "SalaryForm";
            this.Text = "SalaryForm";
            this.Load += new System.EventHandler(this.SalaryForm_Load);
            ((System.ComponentModel.ISupportInitialize)(this.nudBaseSalary)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.nudBonus)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.nudDeduction)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.ComboBox cmbEmployee;
        private System.Windows.Forms.NumericUpDown nudBaseSalary;
        private System.Windows.Forms.NumericUpDown nudBonus;
        private System.Windows.Forms.NumericUpDown nudDeduction;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Button btnCalculate;
        private System.Windows.Forms.Label lblNetSalary;
        private System.Windows.Forms.Button btnClear;
    }
}