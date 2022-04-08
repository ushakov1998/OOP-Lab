
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
            this.groupBox1.SuspendLayout();
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
            this.NextButton.Location = new System.Drawing.Point(197, 170);
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
            this.groupBox1.Size = new System.Drawing.Size(263, 154);
            this.groupBox1.TabIndex = 8;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Информация о работнике";
            // 
            // TypeOfSalaryBox
            // 
            this.TypeOfSalaryBox.FormattingEnabled = true;
            this.TypeOfSalaryBox.Location = new System.Drawing.Point(97, 105);
            this.TypeOfSalaryBox.Name = "TypeOfSalaryBox";
            this.TypeOfSalaryBox.Size = new System.Drawing.Size(157, 23);
            this.TypeOfSalaryBox.TabIndex = 0;
            // 
            // AddWorkerForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(286, 198);
            this.Controls.Add(this.NextButton);
            this.Controls.Add(this.NameBox);
            this.Controls.Add(this.groupBox1);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MaximizeBox = false;
            this.Name = "AddWorkerForm";
            this.Text = "Добавление";
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
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
    }
}