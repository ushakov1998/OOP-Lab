
namespace GUI
{
    partial class TariffPaymentForm
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(TariffPaymentForm));
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.WorkingDaysInMonth = new System.Windows.Forms.TextBox();
            this.DaysWorked = new System.Windows.Forms.TextBox();
            this.Tariff = new System.Windows.Forms.TextBox();
            this.NextButtonTariff = new System.Windows.Forms.Button();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Bold);
            this.label1.Location = new System.Drawing.Point(25, 43);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(145, 15);
            this.label1.TabIndex = 0;
            this.label1.Text = "Рабочих дней в месяце";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Bold);
            this.label2.Location = new System.Drawing.Point(25, 78);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(105, 15);
            this.label2.TabIndex = 1;
            this.label2.Text = "Отработано дней";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Bold);
            this.label3.Location = new System.Drawing.Point(26, 112);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(43, 15);
            this.label3.TabIndex = 2;
            this.label3.Text = "Оклад";
            // 
            // WorkingDaysInMonth
            // 
            this.WorkingDaysInMonth.Location = new System.Drawing.Point(191, 41);
            this.WorkingDaysInMonth.Name = "WorkingDaysInMonth";
            this.WorkingDaysInMonth.Size = new System.Drawing.Size(59, 22);
            this.WorkingDaysInMonth.TabIndex = 3;
            // 
            // DaysWorked
            // 
            this.DaysWorked.Location = new System.Drawing.Point(150, 76);
            this.DaysWorked.Name = "DaysWorked";
            this.DaysWorked.Size = new System.Drawing.Size(100, 22);
            this.DaysWorked.TabIndex = 4;
            // 
            // Tariff
            // 
            this.Tariff.Location = new System.Drawing.Point(150, 109);
            this.Tariff.Name = "Tariff";
            this.Tariff.Size = new System.Drawing.Size(100, 22);
            this.Tariff.TabIndex = 5;
            // 
            // NextButtonTariff
            // 
            this.NextButtonTariff.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.NextButtonTariff.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Bold);
            this.NextButtonTariff.Location = new System.Drawing.Point(191, 155);
            this.NextButtonTariff.Name = "NextButtonTariff";
            this.NextButtonTariff.Size = new System.Drawing.Size(75, 23);
            this.NextButtonTariff.TabIndex = 6;
            this.NextButtonTariff.Text = "Далее";
            this.NextButtonTariff.UseVisualStyleBackColor = true;
            // 
            // groupBox1
            // 
            this.groupBox1.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Bold);
            this.groupBox1.Location = new System.Drawing.Point(12, 12);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(256, 137);
            this.groupBox1.TabIndex = 7;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Оплата по окладу";
            // 
            // TariffPaymentForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.Window;
            this.ClientSize = new System.Drawing.Size(280, 190);
            this.Controls.Add(this.NextButtonTariff);
            this.Controls.Add(this.Tariff);
            this.Controls.Add(this.DaysWorked);
            this.Controls.Add(this.WorkingDaysInMonth);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.groupBox1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.Fixed3D;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MaximizeBox = false;
            this.Name = "TariffPaymentForm";
            this.Text = "Начисление з/п";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox WorkingDaysInMonth;
        private System.Windows.Forms.TextBox DaysWorked;
        private System.Windows.Forms.TextBox Tariff;
        private System.Windows.Forms.Button NextButtonTariff;
        private System.Windows.Forms.GroupBox groupBox1;
    }
}