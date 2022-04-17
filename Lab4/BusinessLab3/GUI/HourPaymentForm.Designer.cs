
namespace GUI
{
    partial class HourPaymentForm
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(HourPaymentForm));
            this.LabelHoursWorked = new System.Windows.Forms.Label();
            this.LabelCostPerHour = new System.Windows.Forms.Label();
            this.HoursWorked = new System.Windows.Forms.TextBox();
            this.CostPerHour = new System.Windows.Forms.TextBox();
            this.NextButtonHour = new System.Windows.Forms.Button();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.SuspendLayout();
            // 
            // LabelHoursWorked
            // 
            this.LabelHoursWorked.AutoSize = true;
            this.LabelHoursWorked.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Bold);
            this.LabelHoursWorked.Location = new System.Drawing.Point(22, 39);
            this.LabelHoursWorked.Name = "LabelHoursWorked";
            this.LabelHoursWorked.Size = new System.Drawing.Size(109, 15);
            this.LabelHoursWorked.TabIndex = 0;
            this.LabelHoursWorked.Text = "Отработано часов";
            // 
            // LabelCostPerHour
            // 
            this.LabelCostPerHour.AutoSize = true;
            this.LabelCostPerHour.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Bold);
            this.LabelCostPerHour.Location = new System.Drawing.Point(22, 74);
            this.LabelCostPerHour.Name = "LabelCostPerHour";
            this.LabelCostPerHour.Size = new System.Drawing.Size(96, 15);
            this.LabelCostPerHour.TabIndex = 1;
            this.LabelCostPerHour.Text = "Стоимость часа";
            // 
            // HoursWorked
            // 
            this.HoursWorked.Location = new System.Drawing.Point(153, 37);
            this.HoursWorked.Name = "HoursWorked";
            this.HoursWorked.Size = new System.Drawing.Size(60, 22);
            this.HoursWorked.TabIndex = 2;
            // 
            // CostPerHour
            // 
            this.CostPerHour.Location = new System.Drawing.Point(153, 72);
            this.CostPerHour.Name = "CostPerHour";
            this.CostPerHour.Size = new System.Drawing.Size(60, 22);
            this.CostPerHour.TabIndex = 3;
            // 
            // NextButtonHour
            // 
            this.NextButtonHour.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.NextButtonHour.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Bold);
            this.NextButtonHour.Location = new System.Drawing.Point(162, 121);
            this.NextButtonHour.Name = "NextButtonHour";
            this.NextButtonHour.Size = new System.Drawing.Size(75, 23);
            this.NextButtonHour.TabIndex = 4;
            this.NextButtonHour.Text = "Далее";
            this.NextButtonHour.UseVisualStyleBackColor = true;
            // 
            // groupBox1
            // 
            this.groupBox1.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Bold);
            this.groupBox1.Location = new System.Drawing.Point(12, 12);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(225, 103);
            this.groupBox1.TabIndex = 5;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Почасовая оплата";
            // 
            // HourPaymentForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.Window;
            this.ClientSize = new System.Drawing.Size(249, 150);
            this.Controls.Add(this.NextButtonHour);
            this.Controls.Add(this.CostPerHour);
            this.Controls.Add(this.HoursWorked);
            this.Controls.Add(this.LabelCostPerHour);
            this.Controls.Add(this.LabelHoursWorked);
            this.Controls.Add(this.groupBox1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedDialog;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MaximizeBox = false;
            this.Name = "HourPaymentForm";
            this.Text = "Начисление з/п";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label LabelHoursWorked;
        private System.Windows.Forms.Label LabelCostPerHour;
        private System.Windows.Forms.TextBox HoursWorked;
        private System.Windows.Forms.TextBox CostPerHour;
        private System.Windows.Forms.Button NextButtonHour;
        private System.Windows.Forms.GroupBox groupBox1;
    }
}