namespace Tyuiu.GurzanVM.Sprint6.Task2.V2
{
    partial class FormMain
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
            System.Windows.Forms.DataVisualization.Charting.ChartArea chartArea1 = new System.Windows.Forms.DataVisualization.Charting.ChartArea();
            System.Windows.Forms.DataVisualization.Charting.Legend legend1 = new System.Windows.Forms.DataVisualization.Charting.Legend();
            System.Windows.Forms.DataVisualization.Charting.Series series1 = new System.Windows.Forms.DataVisualization.Charting.Series();
            groupBoxUs_GVM = new GroupBox();
            textBoxUS_GVM = new TextBox();
            groupBoxVv_GVM = new GroupBox();
            textBoxKo2_GVM = new TextBox();
            textBoxSt2_GVM = new TextBox();
            textBoxKo_GVM = new TextBox();
            textBoxSt_GVM = new TextBox();
            buttonSp_GVM = new Button();
            buttonDone_GVM = new Button();
            groupBoxVi_GVM = new GroupBox();
            chartRes_GVM = new System.Windows.Forms.DataVisualization.Charting.Chart();
            dataGridView_GVM = new DataGridView();
            Column_GVM = new DataGridViewTextBoxColumn();
            Column2_GVM = new DataGridViewTextBoxColumn();
            textBoxVi_GVM = new TextBox();
            groupBoxUs_GVM.SuspendLayout();
            groupBoxVv_GVM.SuspendLayout();
            groupBoxVi_GVM.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)chartRes_GVM).BeginInit();
            ((System.ComponentModel.ISupportInitialize)dataGridView_GVM).BeginInit();
            SuspendLayout();
            // 
            // groupBoxUs_GVM
            // 
            groupBoxUs_GVM.Controls.Add(textBoxUS_GVM);
            groupBoxUs_GVM.FlatStyle = FlatStyle.Flat;
            groupBoxUs_GVM.Location = new Point(12, 12);
            groupBoxUs_GVM.Name = "groupBoxUs_GVM";
            groupBoxUs_GVM.Size = new Size(653, 276);
            groupBoxUs_GVM.TabIndex = 0;
            groupBoxUs_GVM.TabStop = false;
            groupBoxUs_GVM.Text = "Условие";
            // 
            // textBoxUS_GVM
            // 
            textBoxUS_GVM.BorderStyle = BorderStyle.None;
            textBoxUS_GVM.Location = new Point(6, 26);
            textBoxUS_GVM.Multiline = true;
            textBoxUS_GVM.Name = "textBoxUS_GVM";
            textBoxUS_GVM.ReadOnly = true;
            textBoxUS_GVM.Size = new Size(498, 89);
            textBoxUS_GVM.TabIndex = 0;
            textBoxUS_GVM.Text = "Протабулировать функцию sin(x) на заданном диапозоне. Резулультат вывести DataGridView и построить график функции.";
            // 
            // groupBoxVv_GVM
            // 
            groupBoxVv_GVM.Controls.Add(textBoxKo2_GVM);
            groupBoxVv_GVM.Controls.Add(textBoxSt2_GVM);
            groupBoxVv_GVM.Controls.Add(textBoxKo_GVM);
            groupBoxVv_GVM.Controls.Add(textBoxSt_GVM);
            groupBoxVv_GVM.Location = new Point(12, 294);
            groupBoxVv_GVM.Name = "groupBoxVv_GVM";
            groupBoxVv_GVM.Size = new Size(387, 125);
            groupBoxVv_GVM.TabIndex = 1;
            groupBoxVv_GVM.TabStop = false;
            groupBoxVv_GVM.Text = "Ввод данных";
            // 
            // textBoxKo2_GVM
            // 
            textBoxKo2_GVM.Location = new Point(225, 76);
            textBoxKo2_GVM.Name = "textBoxKo2_GVM";
            textBoxKo2_GVM.Size = new Size(156, 27);
            textBoxKo2_GVM.TabIndex = 3;
            // 
            // textBoxSt2_GVM
            // 
            textBoxSt2_GVM.Location = new Point(0, 76);
            textBoxSt2_GVM.Name = "textBoxSt2_GVM";
            textBoxSt2_GVM.Size = new Size(150, 27);
            textBoxSt2_GVM.TabIndex = 2;
            // 
            // textBoxKo_GVM
            // 
            textBoxKo_GVM.BorderStyle = BorderStyle.None;
            textBoxKo_GVM.Location = new Point(256, 26);
            textBoxKo_GVM.Name = "textBoxKo_GVM";
            textBoxKo_GVM.ReadOnly = true;
            textBoxKo_GVM.Size = new Size(125, 20);
            textBoxKo_GVM.TabIndex = 1;
            textBoxKo_GVM.Text = "Конец шага:";
            // 
            // textBoxSt_GVM
            // 
            textBoxSt_GVM.BorderStyle = BorderStyle.None;
            textBoxSt_GVM.Location = new Point(6, 26);
            textBoxSt_GVM.Name = "textBoxSt_GVM";
            textBoxSt_GVM.ReadOnly = true;
            textBoxSt_GVM.Size = new Size(101, 20);
            textBoxSt_GVM.TabIndex = 0;
            textBoxSt_GVM.Text = "Старт шага:";
            // 
            // buttonSp_GVM
            // 
            buttonSp_GVM.BackColor = SystemColors.MenuHighlight;
            buttonSp_GVM.Location = new Point(405, 307);
            buttonSp_GVM.Name = "buttonSp_GVM";
            buttonSp_GVM.Size = new Size(111, 90);
            buttonSp_GVM.TabIndex = 2;
            buttonSp_GVM.Text = "Справка";
            buttonSp_GVM.UseVisualStyleBackColor = false;
            // 
            // buttonDone_GVM
            // 
            buttonDone_GVM.BackColor = Color.LawnGreen;
            buttonDone_GVM.Location = new Point(522, 307);
            buttonDone_GVM.Name = "buttonDone_GVM";
            buttonDone_GVM.Size = new Size(143, 90);
            buttonDone_GVM.TabIndex = 3;
            buttonDone_GVM.Text = "Выполнить";
            buttonDone_GVM.UseVisualStyleBackColor = false;
            buttonDone_GVM.Click += buttonDone_GVM_Click;
            buttonDone_GVM.MouseDown += buttonDone_GVM_MouseDown;
            buttonDone_GVM.MouseEnter += buttonDone_GVM_MouseEnter;
            buttonDone_GVM.MouseLeave += buttonDone_GVM_MouseLeave;
            // 
            // groupBoxVi_GVM
            // 
            groupBoxVi_GVM.Controls.Add(chartRes_GVM);
            groupBoxVi_GVM.Controls.Add(dataGridView_GVM);
            groupBoxVi_GVM.Controls.Add(textBoxVi_GVM);
            groupBoxVi_GVM.Location = new Point(686, 12);
            groupBoxVi_GVM.Name = "groupBoxVi_GVM";
            groupBoxVi_GVM.Size = new Size(629, 407);
            groupBoxVi_GVM.TabIndex = 4;
            groupBoxVi_GVM.TabStop = false;
            groupBoxVi_GVM.Text = "Вывод данных";
            // 
            // chartRes_GVM
            // 
            chartArea1.Name = "ChartArea1";
            chartRes_GVM.ChartAreas.Add(chartArea1);
            legend1.Name = "Legend1";
            chartRes_GVM.Legends.Add(legend1);
            chartRes_GVM.Location = new Point(213, 0);
            chartRes_GVM.Name = "chartRes_GVM";
            series1.ChartArea = "ChartArea1";
            series1.ChartType = System.Windows.Forms.DataVisualization.Charting.SeriesChartType.Spline;
            series1.Legend = "Legend1";
            series1.Name = "Series1";
            chartRes_GVM.Series.Add(series1);
            chartRes_GVM.Size = new Size(511, 407);
            chartRes_GVM.TabIndex = 2;
            chartRes_GVM.Text = "chart1";
            // 
            // dataGridView_GVM
            // 
            dataGridView_GVM.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridView_GVM.Columns.AddRange(new DataGridViewColumn[] { Column_GVM, Column2_GVM });
            dataGridView_GVM.Location = new Point(0, 49);
            dataGridView_GVM.Name = "dataGridView_GVM";
            dataGridView_GVM.RowHeadersVisible = false;
            dataGridView_GVM.RowHeadersWidth = 51;
            dataGridView_GVM.Size = new Size(207, 352);
            dataGridView_GVM.TabIndex = 1;
            // 
            // Column_GVM
            // 
            Column_GVM.HeaderText = "X";
            Column_GVM.MinimumWidth = 6;
            Column_GVM.Name = "Column_GVM";
            Column_GVM.ReadOnly = true;
            Column_GVM.Width = 80;
            // 
            // Column2_GVM
            // 
            Column2_GVM.HeaderText = "F(x)";
            Column2_GVM.MinimumWidth = 6;
            Column2_GVM.Name = "Column2_GVM";
            Column2_GVM.ReadOnly = true;
            Column2_GVM.Width = 80;
            // 
            // textBoxVi_GVM
            // 
            textBoxVi_GVM.BorderStyle = BorderStyle.None;
            textBoxVi_GVM.Location = new Point(6, 23);
            textBoxVi_GVM.Name = "textBoxVi_GVM";
            textBoxVi_GVM.ReadOnly = true;
            textBoxVi_GVM.Size = new Size(125, 20);
            textBoxVi_GVM.TabIndex = 0;
            textBoxVi_GVM.Text = "Результат:";
            // 
            // FormMain
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(1327, 426);
            Controls.Add(groupBoxVi_GVM);
            Controls.Add(buttonDone_GVM);
            Controls.Add(buttonSp_GVM);
            Controls.Add(groupBoxVv_GVM);
            Controls.Add(groupBoxUs_GVM);
            Name = "FormMain";
            Text = "Form1";
            groupBoxUs_GVM.ResumeLayout(false);
            groupBoxUs_GVM.PerformLayout();
            groupBoxVv_GVM.ResumeLayout(false);
            groupBoxVv_GVM.PerformLayout();
            groupBoxVi_GVM.ResumeLayout(false);
            groupBoxVi_GVM.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)chartRes_GVM).EndInit();
            ((System.ComponentModel.ISupportInitialize)dataGridView_GVM).EndInit();
            ResumeLayout(false);
        }

        #endregion

        private GroupBox groupBoxUs_GVM;
        private TextBox textBoxUS_GVM;
        private GroupBox groupBoxVv_GVM;
        private TextBox textBoxKo2_GVM;
        private TextBox textBoxSt2_GVM;
        private TextBox textBoxKo_GVM;
        private TextBox textBoxSt_GVM;
        private Button buttonSp_GVM;
        private Button buttonDone_GVM;
        private GroupBox groupBoxVi_GVM;
        private DataGridView dataGridView_GVM;
        private TextBox textBoxVi_GVM;
        private DataGridViewTextBoxColumn Column_GVM;
        private DataGridViewTextBoxColumn Column2_GVM;
        private System.Windows.Forms.DataVisualization.Charting.Chart chartRes_GVM;
    }
}
