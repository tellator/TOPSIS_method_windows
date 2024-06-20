namespace Lab3_decisions_6th_sem_TOPSIS
{
    partial class Form1
    {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///  Clean up any resources being used.
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
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            criteriaDatagrid = new DataGridView();
            criterionColumn = new DataGridViewTextBoxColumn();
            criterionWeightColumn = new DataGridViewTextBoxColumn();
            criterionIsPositiveColumn = new DataGridViewCheckBoxColumn();
            alternativesDatagrid = new DataGridView();
            alternativeNameColumn = new DataGridViewTextBoxColumn();
            label1 = new Label();
            label2 = new Label();
            comparisonDatagrid = new DataGridView();
            label3 = new Label();
            groupBox1 = new GroupBox();
            groupBox2 = new GroupBox();
            runTopsisButton = new Button();
            insertTestDataButton = new Button();
            updateTableButton = new Button();
            bestAlternativeResultLabel = new Label();
            bestAlternativeLabel = new Label();
            label6 = new Label();
            label5 = new Label();
            resultDatagrid = new DataGridView();
            dataGridViewTextBoxColumn1 = new DataGridViewTextBoxColumn();
            Column1 = new DataGridViewTextBoxColumn();
            label4 = new Label();
            ((System.ComponentModel.ISupportInitialize)criteriaDatagrid).BeginInit();
            ((System.ComponentModel.ISupportInitialize)alternativesDatagrid).BeginInit();
            ((System.ComponentModel.ISupportInitialize)comparisonDatagrid).BeginInit();
            groupBox1.SuspendLayout();
            groupBox2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)resultDatagrid).BeginInit();
            SuspendLayout();
            // 
            // criteriaDatagrid
            // 
            criteriaDatagrid.AllowUserToResizeRows = false;
            criteriaDatagrid.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
            criteriaDatagrid.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            criteriaDatagrid.Columns.AddRange(new DataGridViewColumn[] { criterionColumn, criterionWeightColumn, criterionIsPositiveColumn });
            criteriaDatagrid.Location = new Point(13, 60);
            criteriaDatagrid.Name = "criteriaDatagrid";
            criteriaDatagrid.RowHeadersWidth = 62;
            criteriaDatagrid.Size = new Size(538, 327);
            criteriaDatagrid.TabIndex = 0;
            // 
            // criterionColumn
            // 
            criterionColumn.FillWeight = 160F;
            criterionColumn.HeaderText = "Название критерия";
            criterionColumn.MinimumWidth = 8;
            criterionColumn.Name = "criterionColumn";
            // 
            // criterionWeightColumn
            // 
            criterionWeightColumn.FillWeight = 50F;
            criterionWeightColumn.HeaderText = "Вес";
            criterionWeightColumn.MinimumWidth = 8;
            criterionWeightColumn.Name = "criterionWeightColumn";
            // 
            // criterionIsPositiveColumn
            // 
            criterionIsPositiveColumn.HeaderText = "Положительный";
            criterionIsPositiveColumn.MinimumWidth = 8;
            criterionIsPositiveColumn.Name = "criterionIsPositiveColumn";
            // 
            // alternativesDatagrid
            // 
            alternativesDatagrid.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
            alternativesDatagrid.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            alternativesDatagrid.Columns.AddRange(new DataGridViewColumn[] { alternativeNameColumn });
            alternativesDatagrid.Location = new Point(570, 60);
            alternativesDatagrid.Name = "alternativesDatagrid";
            alternativesDatagrid.RowHeadersWidth = 62;
            alternativesDatagrid.Size = new Size(442, 327);
            alternativesDatagrid.TabIndex = 1;
            // 
            // alternativeNameColumn
            // 
            alternativeNameColumn.HeaderText = "Название альтернативы";
            alternativeNameColumn.MinimumWidth = 8;
            alternativeNameColumn.Name = "alternativeNameColumn";
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Segoe UI", 11F, FontStyle.Regular, GraphicsUnit.Point, 204);
            label1.Location = new Point(6, 27);
            label1.Name = "label1";
            label1.Size = new Size(112, 30);
            label1.TabIndex = 2;
            label1.Text = "Критерии";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Font = new Font("Segoe UI", 11F, FontStyle.Regular, GraphicsUnit.Point, 204);
            label2.Location = new Point(570, 27);
            label2.Name = "label2";
            label2.Size = new Size(158, 30);
            label2.TabIndex = 3;
            label2.Text = "Альтернативы";
            // 
            // comparisonDatagrid
            // 
            comparisonDatagrid.AllowUserToAddRows = false;
            comparisonDatagrid.AllowUserToDeleteRows = false;
            comparisonDatagrid.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
            comparisonDatagrid.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            comparisonDatagrid.Location = new Point(18, 448);
            comparisonDatagrid.Name = "comparisonDatagrid";
            comparisonDatagrid.RowHeadersWidth = 62;
            comparisonDatagrid.Size = new Size(1006, 442);
            comparisonDatagrid.TabIndex = 4;
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Font = new Font("Segoe UI", 11F, FontStyle.Regular, GraphicsUnit.Point, 204);
            label3.Location = new Point(18, 415);
            label3.Name = "label3";
            label3.Size = new Size(212, 30);
            label3.TabIndex = 5;
            label3.Text = "Таблица сравнения";
            // 
            // groupBox1
            // 
            groupBox1.Controls.Add(label1);
            groupBox1.Controls.Add(criteriaDatagrid);
            groupBox1.Controls.Add(alternativesDatagrid);
            groupBox1.Controls.Add(label2);
            groupBox1.Location = new Point(12, 12);
            groupBox1.Name = "groupBox1";
            groupBox1.Size = new Size(1018, 400);
            groupBox1.TabIndex = 6;
            groupBox1.TabStop = false;
            groupBox1.Text = "Ввод исходных данных";
            // 
            // groupBox2
            // 
            groupBox2.Controls.Add(runTopsisButton);
            groupBox2.Controls.Add(insertTestDataButton);
            groupBox2.Controls.Add(updateTableButton);
            groupBox2.Controls.Add(bestAlternativeResultLabel);
            groupBox2.Controls.Add(bestAlternativeLabel);
            groupBox2.Controls.Add(label6);
            groupBox2.Controls.Add(label5);
            groupBox2.Location = new Point(1036, 12);
            groupBox2.Name = "groupBox2";
            groupBox2.Size = new Size(293, 400);
            groupBox2.TabIndex = 7;
            groupBox2.TabStop = false;
            groupBox2.Text = "Вывод результата";
            // 
            // runTopsisButton
            // 
            runTopsisButton.Location = new Point(6, 348);
            runTopsisButton.Name = "runTopsisButton";
            runTopsisButton.Size = new Size(278, 39);
            runTopsisButton.TabIndex = 10;
            runTopsisButton.Text = "Вычислить";
            runTopsisButton.UseVisualStyleBackColor = true;
            runTopsisButton.Click += runTopsisButton_Click;
            // 
            // insertTestDataButton
            // 
            insertTestDataButton.Location = new Point(6, 303);
            insertTestDataButton.Name = "insertTestDataButton";
            insertTestDataButton.Size = new Size(278, 39);
            insertTestDataButton.TabIndex = 9;
            insertTestDataButton.Text = "Вставить тестовые данные";
            insertTestDataButton.UseVisualStyleBackColor = true;
            insertTestDataButton.Click += insertTestDataButton_Click;
            // 
            // updateTableButton
            // 
            updateTableButton.Location = new Point(6, 258);
            updateTableButton.Name = "updateTableButton";
            updateTableButton.Size = new Size(278, 39);
            updateTableButton.TabIndex = 8;
            updateTableButton.Text = "Обновить таблицу";
            updateTableButton.UseVisualStyleBackColor = true;
            updateTableButton.Click += updateTableButton_Click;
            // 
            // bestAlternativeResultLabel
            // 
            bestAlternativeResultLabel.AutoSize = true;
            bestAlternativeResultLabel.Font = new Font("Segoe UI", 11F, FontStyle.Regular, GraphicsUnit.Point, 204);
            bestAlternativeResultLabel.Location = new Point(28, 166);
            bestAlternativeResultLabel.Name = "bestAlternativeResultLabel";
            bestAlternativeResultLabel.Size = new Size(61, 30);
            bestAlternativeResultLabel.TabIndex = 7;
            bestAlternativeResultLabel.Text = "Балл";
            // 
            // bestAlternativeLabel
            // 
            bestAlternativeLabel.AutoSize = true;
            bestAlternativeLabel.Font = new Font("Segoe UI", 11F, FontStyle.Regular, GraphicsUnit.Point, 204);
            bestAlternativeLabel.Location = new Point(28, 80);
            bestAlternativeLabel.Name = "bestAlternativeLabel";
            bestAlternativeLabel.Size = new Size(234, 30);
            bestAlternativeLabel.TabIndex = 6;
            bestAlternativeLabel.Text = "Лучшая альтернатива";
            // 
            // label6
            // 
            label6.AutoSize = true;
            label6.Font = new Font("Segoe UI", 11F, FontStyle.Regular, GraphicsUnit.Point, 204);
            label6.Location = new Point(6, 136);
            label6.Name = "label6";
            label6.Size = new Size(61, 30);
            label6.TabIndex = 5;
            label6.Text = "Балл";
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Font = new Font("Segoe UI", 11F, FontStyle.Regular, GraphicsUnit.Point, 204);
            label5.Location = new Point(6, 50);
            label5.Name = "label5";
            label5.Size = new Size(234, 30);
            label5.TabIndex = 4;
            label5.Text = "Лучшая альтернатива";
            // 
            // resultDatagrid
            // 
            resultDatagrid.AllowUserToAddRows = false;
            resultDatagrid.AllowUserToDeleteRows = false;
            resultDatagrid.AllowUserToResizeColumns = false;
            resultDatagrid.AllowUserToResizeRows = false;
            resultDatagrid.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
            resultDatagrid.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            resultDatagrid.Columns.AddRange(new DataGridViewColumn[] { dataGridViewTextBoxColumn1, Column1 });
            resultDatagrid.Location = new Point(1042, 448);
            resultDatagrid.Name = "resultDatagrid";
            resultDatagrid.ReadOnly = true;
            resultDatagrid.RowHeadersVisible = false;
            resultDatagrid.RowHeadersWidth = 62;
            resultDatagrid.Size = new Size(287, 442);
            resultDatagrid.TabIndex = 4;
            // 
            // dataGridViewTextBoxColumn1
            // 
            dataGridViewTextBoxColumn1.FillWeight = 160F;
            dataGridViewTextBoxColumn1.HeaderText = "Альтернатива";
            dataGridViewTextBoxColumn1.MinimumWidth = 8;
            dataGridViewTextBoxColumn1.Name = "dataGridViewTextBoxColumn1";
            dataGridViewTextBoxColumn1.ReadOnly = true;
            // 
            // Column1
            // 
            Column1.HeaderText = "Результат";
            Column1.MinimumWidth = 8;
            Column1.Name = "Column1";
            Column1.ReadOnly = true;
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Font = new Font("Segoe UI", 11F, FontStyle.Regular, GraphicsUnit.Point, 204);
            label4.Location = new Point(1042, 415);
            label4.Name = "label4";
            label4.Size = new Size(258, 30);
            label4.TabIndex = 8;
            label4.Text = "Результаты альтернатив";
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(10F, 25F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(1341, 902);
            Controls.Add(label4);
            Controls.Add(resultDatagrid);
            Controls.Add(groupBox2);
            Controls.Add(groupBox1);
            Controls.Add(label3);
            Controls.Add(comparisonDatagrid);
            MaximumSize = new Size(1363, 958);
            MinimumSize = new Size(1363, 958);
            Name = "Form1";
            Text = "MSDM TOPSIS";
            ((System.ComponentModel.ISupportInitialize)criteriaDatagrid).EndInit();
            ((System.ComponentModel.ISupportInitialize)alternativesDatagrid).EndInit();
            ((System.ComponentModel.ISupportInitialize)comparisonDatagrid).EndInit();
            groupBox1.ResumeLayout(false);
            groupBox1.PerformLayout();
            groupBox2.ResumeLayout(false);
            groupBox2.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)resultDatagrid).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private DataGridView criteriaDatagrid;
        private DataGridView alternativesDatagrid;
        private Label label1;
        private Label label2;
        private DataGridView comparisonDatagrid;
        private Label label3;
        private GroupBox groupBox1;
        private GroupBox groupBox2;
        private Label bestAlternativeResultLabel;
        private Label bestAlternativeLabel;
        private Label label6;
        private Label label5;
        private DataGridViewTextBoxColumn criterionColumn;
        private DataGridViewTextBoxColumn criterionWeightColumn;
        private DataGridViewCheckBoxColumn criterionIsPositiveColumn;
        private DataGridViewTextBoxColumn alternativeNameColumn;
        private Button updateTableButton;
        private Button insertTestDataButton;
        private Button runTopsisButton;
        private DataGridView resultDatagrid;
        private DataGridViewTextBoxColumn dataGridViewTextBoxColumn1;
        private DataGridViewTextBoxColumn Column1;
        private Label label4;
    }
}
