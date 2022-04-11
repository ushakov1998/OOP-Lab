
namespace GUI
{
    partial class RatePaymentForm
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(RatePaymentForm));
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.DaysWorked = new System.Windows.Forms.TextBox();
            this.CostPerDay = new System.Windows.Forms.TextBox();
            this.NextButtonRate = new System.Windows.Forms.Button();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.groupBox1.SuspendLayout();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Bold);
            this.label1.Location = new System.Drawing.Point(20, 40);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(105, 15);
            this.label1.TabIndex = 0;
            this.label1.Text = "Отработано дней";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Bold);
            this.label2.Location = new System.Drawing.Point(14, 66);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(92, 15);
            this.label2.TabIndex = 1;
            this.label2.Text = "Стоимость дня";
            // 
            // DaysWorked
            // 
            this.DaysWorked.Location = new System.Drawing.Point(147, 38);
            this.DaysWorked.Name = "DaysWorked";
            this.DaysWorked.Size = new System.Drawing.Size(53, 22);
            this.DaysWorked.TabIndex = 2;
            // 
            // CostPerDay
            // 
            this.CostPerDay.Location = new System.Drawing.Point(131, 76);
            this.CostPerDay.Name = "CostPerDay";
            this.CostPerDay.Size = new System.Drawing.Size(69, 22);
            this.CostPerDay.TabIndex = 3;
            // 
            // NextButtonRate
            // 
            this.NextButtonRate.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Bold);
            this.NextButtonRate.Location = new System.Drawing.Point(140, 128);
            this.NextButtonRate.Name = "NextButtonRate";
            this.NextButtonRate.Size = new System.Drawing.Size(75, 23);
            this.NextButtonRate.TabIndex = 4;
            this.NextButtonRate.Text = "Далее";
            this.NextButtonRate.UseVisualStyleBackColor = true;
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.label2);
            this.groupBox1.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Bold);
            this.groupBox1.Location = new System.Drawing.Point(6, 12);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(209, 108);
            this.groupBox1.TabIndex = 5;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Оплата по ставке";
            // 
            // RatePaymentForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.Window;
            this.ClientSize = new System.Drawing.Size(227, 163);
            this.Controls.Add(this.NextButtonRate);
            this.Controls.Add(this.CostPerDay);
            this.Controls.Add(this.DaysWorked);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.groupBox1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.Fixed3D;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "RatePaymentForm";
            this.Text = "Начисление з/п";
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox DaysWorked;
        private System.Windows.Forms.TextBox CostPerDay;
        private System.Windows.Forms.Button NextButtonRate;
        private System.Windows.Forms.GroupBox groupBox1;
    }
}