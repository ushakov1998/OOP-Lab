
namespace GUI
{
    partial class AddWorkerForm
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(AddWorkerForm));
            this.NameBox = new System.Windows.Forms.TextBox();
            this.LabelSurname = new System.Windows.Forms.Label();
            this.LabelName = new System.Windows.Forms.Label();
            this.LabelTypeOfSalary = new System.Windows.Forms.Label();
            this.SurnameBox = new System.Windows.Forms.TextBox();
            this.NextButton = new System.Windows.Forms.Button();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.TypeOfSalaryBox = new System.Windows.Forms.ComboBox();
            this.PerHourGroupBox = new System.Windows.Forms.GroupBox();
            this.CostPerHourBox = new System.Windows.Forms.TextBox();
            this.HoursWorkedBox = new System.Windows.Forms.TextBox();
            this.CostPerHourLabel2 = new System.Windows.Forms.Label();
            this.WorkedHoursLabel1 = new System.Windows.Forms.Label();
            this.RateGroupBox = new System.Windows.Forms.GroupBox();
            this.WorkedDaysRateNumeric = new System.Windows.Forms.NumericUpDown();
            this.CostPerDayBox = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.TariffGroupBox = new System.Windows.Forms.GroupBox();
            this.DaysWorkedTariffNumeric = new System.Windows.Forms.NumericUpDown();
            this.MonthWorkedDaysNumeric = new System.Windows.Forms.NumericUpDown();
            this.label5 = new System.Windows.Forms.Label();
            this.TariffBox = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.AllRandomButton = new System.Windows.Forms.Button();
            this.groupBox1.SuspendLayout();
            this.PerHourGroupBox.SuspendLayout();
            this.RateGroupBox.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.WorkedDaysRateNumeric)).BeginInit();
            this.TariffGroupBox.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.DaysWorkedTariffNumeric)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.MonthWorkedDaysNumeric)).BeginInit();
            this.SuspendLayout();
            // 
            // NameBox
            // 
            this.NameBox.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Bold);
            this.NameBox.Location = new System.Drawing.Point(109, 44);
            this.NameBox.Name = "NameBox";
            this.NameBox.Size = new System.Drawing.Size(157, 23);
            this.NameBox.TabIndex = 0;
            this.NameBox.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.NameBox_KeyPress);
            // 
            // LabelSurname
            // 
            this.LabelSurname.AutoSize = true;
            this.LabelSurname.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Bold);
            this.LabelSurname.Location = new System.Drawing.Point(13, 70);
            this.LabelSurname.Name = "LabelSurname";
            this.LabelSurname.Size = new System.Drawing.Size(62, 15);
            this.LabelSurname.TabIndex = 1;
            this.LabelSurname.Text = "Фамилия";
            // 
            // LabelName
            // 
            this.LabelName.AutoSize = true;
            this.LabelName.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Bold);
            this.LabelName.Location = new System.Drawing.Point(15, 33);
            this.LabelName.Name = "LabelName";
            this.LabelName.Size = new System.Drawing.Size(32, 15);
            this.LabelName.TabIndex = 2;
            this.LabelName.Text = "Имя";
            // 
            // LabelTypeOfSalary
            // 
            this.LabelTypeOfSalary.AutoSize = true;
            this.LabelTypeOfSalary.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Bold);
            this.LabelTypeOfSalary.Location = new System.Drawing.Point(14, 106);
            this.LabelTypeOfSalary.Name = "LabelTypeOfSalary";
            this.LabelTypeOfSalary.Size = new System.Drawing.Size(49, 15);
            this.LabelTypeOfSalary.TabIndex = 3;
            this.LabelTypeOfSalary.Text = "Тип з/п";
            // 
            // SurnameBox
            // 
            this.SurnameBox.Location = new System.Drawing.Point(97, 68);
            this.SurnameBox.Name = "SurnameBox";
            this.SurnameBox.Size = new System.Drawing.Size(157, 23);
            this.SurnameBox.TabIndex = 4;
            this.SurnameBox.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.NameBox_KeyPress);
            // 
            // NextButton
            // 
            this.NextButton.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.NextButton.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Bold);
            this.NextButton.Location = new System.Drawing.Point(196, 303);
            this.NextButton.Name = "NextButton";
            this.NextButton.Size = new System.Drawing.Size(79, 22);
            this.NextButton.TabIndex = 7;
            this.NextButton.Text = "Далее";
            this.NextButton.UseVisualStyleBackColor = true;
            this.NextButton.Click += new System.EventHandler(this.button2_Click);
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.TypeOfSalaryBox);
            this.groupBox1.Controls.Add(this.SurnameBox);
            this.groupBox1.Controls.Add(this.LabelSurname);
            this.groupBox1.Controls.Add(this.LabelName);
            this.groupBox1.Controls.Add(this.LabelTypeOfSalary);
            this.groupBox1.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Bold);
            this.groupBox1.Location = new System.Drawing.Point(12, 12);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(263, 151);
            this.groupBox1.TabIndex = 8;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Информация о работнике";
            // 
            // TypeOfSalaryBox
            // 
            this.TypeOfSalaryBox.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.TypeOfSalaryBox.FormattingEnabled = true;
            this.TypeOfSalaryBox.Location = new System.Drawing.Point(97, 105);
            this.TypeOfSalaryBox.Name = "TypeOfSalaryBox";
            this.TypeOfSalaryBox.Size = new System.Drawing.Size(157, 23);
            this.TypeOfSalaryBox.TabIndex = 0;
            this.TypeOfSalaryBox.SelectedIndexChanged += new System.EventHandler(this.TypeOfSalaryBox_SelectedIndexChanged);
            // 
            // PerHourGroupBox
            // 
            this.PerHourGroupBox.Controls.Add(this.CostPerHourBox);
            this.PerHourGroupBox.Controls.Add(this.HoursWorkedBox);
            this.PerHourGroupBox.Controls.Add(this.CostPerHourLabel2);
            this.PerHourGroupBox.Controls.Add(this.WorkedHoursLabel1);
            this.PerHourGroupBox.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Bold);
            this.PerHourGroupBox.Location = new System.Drawing.Point(11, 175);
            this.PerHourGroupBox.Name = "PerHourGroupBox";
            this.PerHourGroupBox.Size = new System.Drawing.Size(262, 100);
            this.PerHourGroupBox.TabIndex = 9;
            this.PerHourGroupBox.TabStop = false;
            this.PerHourGroupBox.Text = "Почасовая оплата";
            // 
            // CostPerHourBox
            // 
            this.CostPerHourBox.Location = new System.Drawing.Point(145, 53);
            this.CostPerHourBox.Name = "CostPerHourBox";
            this.CostPerHourBox.Size = new System.Drawing.Size(83, 23);
            this.CostPerHourBox.TabIndex = 3;
            this.CostPerHourBox.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.CheckTextBox);
            // 
            // HoursWorkedBox
            // 
            this.HoursWorkedBox.Location = new System.Drawing.Point(145, 20);
            this.HoursWorkedBox.Name = "HoursWorkedBox";
            this.HoursWorkedBox.Size = new System.Drawing.Size(83, 23);
            this.HoursWorkedBox.TabIndex = 2;
            this.HoursWorkedBox.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.CheckTextBoxInt);
            // 
            // CostPerHourLabel2
            // 
            this.CostPerHourLabel2.AutoSize = true;
            this.CostPerHourLabel2.Location = new System.Drawing.Point(17, 56);
            this.CostPerHourLabel2.Name = "CostPerHourLabel2";
            this.CostPerHourLabel2.Size = new System.Drawing.Size(96, 15);
            this.CostPerHourLabel2.TabIndex = 1;
            this.CostPerHourLabel2.Text = "Стоимость часа";
            // 
            // WorkedHoursLabel1
            // 
            this.WorkedHoursLabel1.AutoSize = true;
            this.WorkedHoursLabel1.Location = new System.Drawing.Point(17, 24);
            this.WorkedHoursLabel1.Name = "WorkedHoursLabel1";
            this.WorkedHoursLabel1.Size = new System.Drawing.Size(122, 15);
            this.WorkedHoursLabel1.TabIndex = 0;
            this.WorkedHoursLabel1.Text = "Отработанные часы";
            // 
            // RateGroupBox
            // 
            this.RateGroupBox.Controls.Add(this.WorkedDaysRateNumeric);
            this.RateGroupBox.Controls.Add(this.CostPerDayBox);
            this.RateGroupBox.Controls.Add(this.label1);
            this.RateGroupBox.Controls.Add(this.label2);
            this.RateGroupBox.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Bold);
            this.RateGroupBox.Location = new System.Drawing.Point(11, 175);
            this.RateGroupBox.Name = "RateGroupBox";
            this.RateGroupBox.Size = new System.Drawing.Size(257, 94);
            this.RateGroupBox.TabIndex = 12;
            this.RateGroupBox.TabStop = false;
            this.RateGroupBox.Text = "Оплата по ставке";
            // 
            // WorkedDaysRateNumeric
            // 
            this.WorkedDaysRateNumeric.Location = new System.Drawing.Point(145, 20);
            this.WorkedDaysRateNumeric.Maximum = new decimal(new int[] {
            100000,
            0,
            0,
            0});
            this.WorkedDaysRateNumeric.Name = "WorkedDaysRateNumeric";
            this.WorkedDaysRateNumeric.Size = new System.Drawing.Size(84, 23);
            this.WorkedDaysRateNumeric.TabIndex = 4;
            // 
            // CostPerDayBox
            // 
            this.CostPerDayBox.Location = new System.Drawing.Point(145, 53);
            this.CostPerDayBox.Name = "CostPerDayBox";
            this.CostPerDayBox.Size = new System.Drawing.Size(83, 23);
            this.CostPerDayBox.TabIndex = 3;
            this.CostPerDayBox.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.CheckTextBox);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(17, 56);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(92, 15);
            this.label1.TabIndex = 1;
            this.label1.Text = "Стоимость дня";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(17, 24);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(105, 15);
            this.label2.TabIndex = 0;
            this.label2.Text = "Отработано дней";
            // 
            // TariffGroupBox
            // 
            this.TariffGroupBox.Controls.Add(this.DaysWorkedTariffNumeric);
            this.TariffGroupBox.Controls.Add(this.MonthWorkedDaysNumeric);
            this.TariffGroupBox.Controls.Add(this.label5);
            this.TariffGroupBox.Controls.Add(this.TariffBox);
            this.TariffGroupBox.Controls.Add(this.label3);
            this.TariffGroupBox.Controls.Add(this.label4);
            this.TariffGroupBox.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Bold);
            this.TariffGroupBox.Location = new System.Drawing.Point(11, 175);
            this.TariffGroupBox.Name = "TariffGroupBox";
            this.TariffGroupBox.Size = new System.Drawing.Size(262, 116);
            this.TariffGroupBox.TabIndex = 13;
            this.TariffGroupBox.TabStop = false;
            this.TariffGroupBox.Text = "Оплата по окладу";
            // 
            // DaysWorkedTariffNumeric
            // 
            this.DaysWorkedTariffNumeric.Location = new System.Drawing.Point(184, 48);
            this.DaysWorkedTariffNumeric.Maximum = new decimal(new int[] {
            31,
            0,
            0,
            0});
            this.DaysWorkedTariffNumeric.Name = "DaysWorkedTariffNumeric";
            this.DaysWorkedTariffNumeric.Size = new System.Drawing.Size(43, 23);
            this.DaysWorkedTariffNumeric.TabIndex = 7;
            // 
            // MonthWorkedDaysNumeric
            // 
            this.MonthWorkedDaysNumeric.Location = new System.Drawing.Point(184, 20);
            this.MonthWorkedDaysNumeric.Maximum = new decimal(new int[] {
            31,
            0,
            0,
            0});
            this.MonthWorkedDaysNumeric.Name = "MonthWorkedDaysNumeric";
            this.MonthWorkedDaysNumeric.Size = new System.Drawing.Size(44, 23);
            this.MonthWorkedDaysNumeric.TabIndex = 6;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(17, 85);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(43, 15);
            this.label5.TabIndex = 5;
            this.label5.Text = "Оклад";
            // 
            // TariffBox
            // 
            this.TariffBox.Location = new System.Drawing.Point(145, 82);
            this.TariffBox.Name = "TariffBox";
            this.TariffBox.Size = new System.Drawing.Size(83, 23);
            this.TariffBox.TabIndex = 4;
            this.TariffBox.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.CheckTextBox);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(17, 56);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(105, 15);
            this.label3.TabIndex = 1;
            this.label3.Text = "Отработано дней";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(17, 24);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(145, 15);
            this.label4.TabIndex = 0;
            this.label4.Text = "Рабочих дней в месяце";
            // 
            // AllRandomButton
            // 
            this.AllRandomButton.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("AllRandomButton.BackgroundImage")));
            this.AllRandomButton.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Center;
            this.AllRandomButton.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.AllRandomButton.Location = new System.Drawing.Point(156, 303);
            this.AllRandomButton.Name = "AllRandomButton";
            this.AllRandomButton.Size = new System.Drawing.Size(27, 22);
            this.AllRandomButton.TabIndex = 14;
            this.AllRandomButton.UseVisualStyleBackColor = true;
            this.AllRandomButton.Click += new System.EventHandler(this.AllRandomButton_Click);
            // 
            // AddWorkerForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(288, 340);
            this.Controls.Add(this.AllRandomButton);
            this.Controls.Add(this.TariffGroupBox);
            this.Controls.Add(this.PerHourGroupBox);
            this.Controls.Add(this.RateGroupBox);
            this.Controls.Add(this.NextButton);
            this.Controls.Add(this.NameBox);
            this.Controls.Add(this.groupBox1);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MaximizeBox = false;
            this.Name = "AddWorkerForm";
            this.Text = "Добавление";
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.PerHourGroupBox.ResumeLayout(false);
            this.PerHourGroupBox.PerformLayout();
            this.RateGroupBox.ResumeLayout(false);
            this.RateGroupBox.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.WorkedDaysRateNumeric)).EndInit();
            this.TariffGroupBox.ResumeLayout(false);
            this.TariffGroupBox.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.DaysWorkedTariffNumeric)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.MonthWorkedDaysNumeric)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox NameBox;
        private System.Windows.Forms.Label LabelSurname;
        private System.Windows.Forms.Label LabelName;
        private System.Windows.Forms.Label LabelTypeOfSalary;
        private System.Windows.Forms.TextBox SurnameBox;
        private System.Windows.Forms.Button NextButton;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.ComboBox TypeOfSalaryBox;
        private System.Windows.Forms.GroupBox PerHourGroupBox;
        private System.Windows.Forms.TextBox CostPerHourBox;
        private System.Windows.Forms.TextBox HoursWorkedBox;
        private System.Windows.Forms.Label CostPerHourLabel2;
        private System.Windows.Forms.Label WorkedHoursLabel1;
        private System.Windows.Forms.GroupBox RateGroupBox;
        private System.Windows.Forms.TextBox CostPerDayBox;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.GroupBox TariffGroupBox;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.TextBox TariffBox;
        private System.Windows.Forms.NumericUpDown MonthWorkedDaysNumeric;
        private System.Windows.Forms.NumericUpDown DaysWorkedTariffNumeric;
        private System.Windows.Forms.NumericUpDown WorkedDaysRateNumeric;
        private System.Windows.Forms.Button AllRandomButton;
    }
}