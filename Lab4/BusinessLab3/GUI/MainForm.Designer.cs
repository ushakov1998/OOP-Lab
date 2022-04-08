
namespace GUI
{
    partial class MainForm
    {
        /// <summary>
        /// Обязательная переменная конструктора.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Освободить все используемые ресурсы.
        /// </summary>
        /// <param name="disposing">истинно, если управляемый ресурс должен быть удален; иначе ложно.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Код, автоматически созданный конструктором форм Windows

        /// <summary>
        /// Требуемый метод для поддержки конструктора — не изменяйте 
        /// содержимое этого метода с помощью редактора кода.
        /// </summary>
        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(MainForm));
            this.DataGridWorkers = new System.Windows.Forms.DataGridView();
            this.SearchBox = new System.Windows.Forms.TextBox();
            this.groupDataGrid = new System.Windows.Forms.GroupBox();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.RemoveWorker = new System.Windows.Forms.Button();
            this.AddWorker = new System.Windows.Forms.Button();
            this.SaveButton = new System.Windows.Forms.Button();
            this.OpenButton = new System.Windows.Forms.Button();
            this.workerName = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Surname = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.typeOfSalary = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.SalaryAccount = new System.Windows.Forms.DataGridViewTextBoxColumn();
            ((System.ComponentModel.ISupportInitialize)(this.DataGridWorkers)).BeginInit();
            this.groupDataGrid.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // DataGridWorkers
            // 
            this.DataGridWorkers.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.DataGridWorkers.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.workerName,
            this.Surname,
            this.typeOfSalary,
            this.SalaryAccount});
            this.DataGridWorkers.Location = new System.Drawing.Point(18, 21);
            this.DataGridWorkers.Name = "DataGridWorkers";
            this.DataGridWorkers.RowHeadersVisible = false;
            this.DataGridWorkers.RowTemplate.Height = 24;
            this.DataGridWorkers.Size = new System.Drawing.Size(424, 253);
            this.DataGridWorkers.TabIndex = 0;
            // 
            // SearchBox
            // 
            this.SearchBox.Font = new System.Drawing.Font("Segoe UI", 10F, System.Drawing.FontStyle.Bold);
            this.SearchBox.Location = new System.Drawing.Point(233, 19);
            this.SearchBox.Name = "SearchBox";
            this.SearchBox.Size = new System.Drawing.Size(195, 25);
            this.SearchBox.TabIndex = 1;
            this.SearchBox.Enter += new System.EventHandler(this.SearchBox_Enter);
            this.SearchBox.Leave += new System.EventHandler(this.SearchBox_Leave);
            // 
            // groupDataGrid
            // 
            this.groupDataGrid.Controls.Add(this.DataGridWorkers);
            this.groupDataGrid.Location = new System.Drawing.Point(12, 58);
            this.groupDataGrid.Name = "groupDataGrid";
            this.groupDataGrid.Size = new System.Drawing.Size(460, 291);
            this.groupDataGrid.TabIndex = 2;
            this.groupDataGrid.TabStop = false;
            this.groupDataGrid.Text = "Заработная плата рабочего";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Segoe UI", 24F, System.Drawing.FontStyle.Bold);
            this.label2.ForeColor = System.Drawing.SystemColors.AppWorkspace;
            this.label2.Location = new System.Drawing.Point(21, 5);
            this.label2.Margin = new System.Windows.Forms.Padding(0);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(30, 45);
            this.label2.TabIndex = 11;
            this.label2.Text = "|";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Segoe UI", 24F, System.Drawing.FontStyle.Bold);
            this.label3.ForeColor = System.Drawing.SystemColors.AppWorkspace;
            this.label3.Location = new System.Drawing.Point(117, 5);
            this.label3.Margin = new System.Windows.Forms.Padding(0);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(30, 45);
            this.label3.TabIndex = 12;
            this.label3.Text = "|";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Segoe UI", 24F, System.Drawing.FontStyle.Bold);
            this.label1.ForeColor = System.Drawing.SystemColors.AppWorkspace;
            this.label1.Location = new System.Drawing.Point(211, 5);
            this.label1.Margin = new System.Windows.Forms.Padding(0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(30, 45);
            this.label1.TabIndex = 13;
            this.label1.Text = "|";
            // 
            // pictureBox1
            // 
            this.pictureBox1.Image = global::GUI.Properties.Resources.icons8_поиск_24;
            this.pictureBox1.InitialImage = global::GUI.Properties.Resources.icons8_поиск_24;
            this.pictureBox1.Location = new System.Drawing.Point(431, 19);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(23, 25);
            this.pictureBox1.TabIndex = 14;
            this.pictureBox1.TabStop = false;
            // 
            // RemoveWorker
            // 
            this.RemoveWorker.BackColor = System.Drawing.SystemColors.Window;
            this.RemoveWorker.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.RemoveWorker.ForeColor = System.Drawing.SystemColors.Window;
            this.RemoveWorker.Image = global::GUI.Properties.Resources.icons8_знак_минус_24;
            this.RemoveWorker.Location = new System.Drawing.Point(182, 15);
            this.RemoveWorker.Name = "RemoveWorker";
            this.RemoveWorker.Size = new System.Drawing.Size(33, 33);
            this.RemoveWorker.TabIndex = 3;
            this.RemoveWorker.UseVisualStyleBackColor = false;
            this.RemoveWorker.Click += new System.EventHandler(this.RemoveWorker_Click);
            // 
            // AddWorker
            // 
            this.AddWorker.BackColor = System.Drawing.SystemColors.Window;
            this.AddWorker.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.AddWorker.ForeColor = System.Drawing.SystemColors.Window;
            this.AddWorker.Image = global::GUI.Properties.Resources.icons8_плюс_24;
            this.AddWorker.Location = new System.Drawing.Point(141, 15);
            this.AddWorker.Name = "AddWorker";
            this.AddWorker.Size = new System.Drawing.Size(33, 33);
            this.AddWorker.TabIndex = 5;
            this.AddWorker.UseVisualStyleBackColor = false;
            this.AddWorker.Click += new System.EventHandler(this.AddWorker_Click);
            // 
            // SaveButton
            // 
            this.SaveButton.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.SaveButton.ForeColor = System.Drawing.SystemColors.Window;
            this.SaveButton.Image = global::GUI.Properties.Resources.icons8_сохранить_и_закрыть_24;
            this.SaveButton.Location = new System.Drawing.Point(87, 16);
            this.SaveButton.Name = "SaveButton";
            this.SaveButton.Size = new System.Drawing.Size(33, 33);
            this.SaveButton.TabIndex = 9;
            this.SaveButton.UseVisualStyleBackColor = true;
            this.SaveButton.Click += new System.EventHandler(this.SaveButton_Click);
            // 
            // OpenButton
            // 
            this.OpenButton.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.OpenButton.ForeColor = System.Drawing.SystemColors.Window;
            this.OpenButton.Image = global::GUI.Properties.Resources.icons8_загрузить_24;
            this.OpenButton.Location = new System.Drawing.Point(45, 16);
            this.OpenButton.Name = "OpenButton";
            this.OpenButton.Size = new System.Drawing.Size(33, 33);
            this.OpenButton.TabIndex = 8;
            this.OpenButton.UseVisualStyleBackColor = true;
            this.OpenButton.Click += new System.EventHandler(this.OpenButton_Click);
            // 
            // workerName
            // 
            this.workerName.HeaderText = "Имя";
            this.workerName.Name = "workerName";
            this.workerName.Resizable = System.Windows.Forms.DataGridViewTriState.False;
            // 
            // Surname
            // 
            this.Surname.HeaderText = "Фамилия";
            this.Surname.Name = "Surname";
            this.Surname.Resizable = System.Windows.Forms.DataGridViewTriState.False;
            // 
            // typeOfSalary
            // 
            this.typeOfSalary.HeaderText = "Тип начисляемой заработной платы";
            this.typeOfSalary.Name = "typeOfSalary";
            this.typeOfSalary.Resizable = System.Windows.Forms.DataGridViewTriState.False;
            this.typeOfSalary.Width = 120;
            // 
            // SalaryAccount
            // 
            this.SalaryAccount.HeaderText = "Зарплата";
            this.SalaryAccount.Name = "SalaryAccount";
            this.SalaryAccount.Resizable = System.Windows.Forms.DataGridViewTriState.False;
            this.SalaryAccount.Width = 101;
            // 
            // MainForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.Window;
            this.ClientSize = new System.Drawing.Size(484, 361);
            this.Controls.Add(this.pictureBox1);
            this.Controls.Add(this.RemoveWorker);
            this.Controls.Add(this.AddWorker);
            this.Controls.Add(this.SaveButton);
            this.Controls.Add(this.SearchBox);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.OpenButton);
            this.Controls.Add(this.groupDataGrid);
            this.Controls.Add(this.label2);
            this.Font = new System.Drawing.Font("Segoe UI", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.Fixed3D;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MaximizeBox = false;
            this.Name = "MainForm";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Начисление заработный платы";
            ((System.ComponentModel.ISupportInitialize)(this.DataGridWorkers)).EndInit();
            this.groupDataGrid.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.DataGridView DataGridWorkers;
        private System.Windows.Forms.TextBox SearchBox;
        private System.Windows.Forms.GroupBox groupDataGrid;
        private System.Windows.Forms.Button RemoveWorker;
        private System.Windows.Forms.Button AddWorker;
        private System.Windows.Forms.Button OpenButton;
        private System.Windows.Forms.Button SaveButton;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.DataGridViewTextBoxColumn workerName;
        private System.Windows.Forms.DataGridViewTextBoxColumn Surname;
        private System.Windows.Forms.DataGridViewTextBoxColumn typeOfSalary;
        private System.Windows.Forms.DataGridViewTextBoxColumn SalaryAccount;
    }
}

