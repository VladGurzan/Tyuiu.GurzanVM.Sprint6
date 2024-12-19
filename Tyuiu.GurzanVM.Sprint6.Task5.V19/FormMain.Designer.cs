namespace Tyuiu.GurzanVM.Sprint6.Task5.V19
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
            textBox1 = new TextBox();
            groupBoxEnter_GVM = new GroupBox();
            dataGridView_GVM = new DataGridView();
            buttonDone_GVM = new Button();
            buttonOpen_GVM = new Button();
            buttonMy_GVM = new Button();
            chartRes_GVM = new System.Windows.Forms.DataVisualization.Charting.Chart();
            groupBoxUs_GVM.SuspendLayout();
            groupBoxEnter_GVM.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)dataGridView_GVM).BeginInit();
            ((System.ComponentModel.ISupportInitialize)chartRes_GVM).BeginInit();
            SuspendLayout();
            // 
            // groupBoxUs_GVM
            // 
            groupBoxUs_GVM.Controls.Add(textBox1);
            groupBoxUs_GVM.Location = new Point(12, 12);
            groupBoxUs_GVM.Name = "groupBoxUs_GVM";
            groupBoxUs_GVM.Size = new Size(761, 125);
            groupBoxUs_GVM.TabIndex = 0;
            groupBoxUs_GVM.TabStop = false;
            groupBoxUs_GVM.Text = "Условие";
            // 
            // textBox1
            // 
            textBox1.BorderStyle = BorderStyle.None;
            textBox1.Location = new Point(6, 26);
            textBox1.Multiline = true;
            textBox1.Name = "textBox1";
            textBox1.ReadOnly = true;
            textBox1.Size = new Size(430, 78);
            textBox1.TabIndex = 0;
            textBox1.Text = "Прочитать данные из файла. Вывести в dataGridViewположительные значения и построить диаграмму по этим значениям";
            // 
            // groupBoxEnter_GVM
            // 
            groupBoxEnter_GVM.Controls.Add(dataGridView_GVM);
            groupBoxEnter_GVM.Location = new Point(12, 143);
            groupBoxEnter_GVM.Name = "groupBoxEnter_GVM";
            groupBoxEnter_GVM.Size = new Size(296, 393);
            groupBoxEnter_GVM.TabIndex = 1;
            groupBoxEnter_GVM.TabStop = false;
            groupBoxEnter_GVM.Text = "Ввод данных";
            // 
            // dataGridView_GVM
            // 
            dataGridView_GVM.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridView_GVM.Location = new Point(0, 26);
            dataGridView_GVM.Name = "dataGridView_GVM";
            dataGridView_GVM.RowHeadersVisible = false;
            dataGridView_GVM.RowHeadersWidth = 51;
            dataGridView_GVM.Size = new Size(290, 361);
            dataGridView_GVM.TabIndex = 5;
            // 
            // buttonDone_GVM
            // 
            buttonDone_GVM.BackColor = Color.Green;
            buttonDone_GVM.Location = new Point(810, 17);
            buttonDone_GVM.Name = "buttonDone_GVM";
            buttonDone_GVM.Size = new Size(110, 99);
            buttonDone_GVM.TabIndex = 2;
            buttonDone_GVM.Text = "Выполнить";
            buttonDone_GVM.UseVisualStyleBackColor = false;
            buttonDone_GVM.Click += buttonDone_GVM_Click;
            // 
            // buttonOpen_GVM
            // 
            buttonOpen_GVM.BackColor = Color.DodgerBlue;
            buttonOpen_GVM.Location = new Point(926, 17);
            buttonOpen_GVM.Name = "buttonOpen_GVM";
            buttonOpen_GVM.Size = new Size(110, 99);
            buttonOpen_GVM.TabIndex = 3;
            buttonOpen_GVM.Text = "Открыть файл";
            buttonOpen_GVM.UseVisualStyleBackColor = false;
            buttonOpen_GVM.Click += buttonOpen_GVM_Click;
            // 
            // buttonMy_GVM
            // 
            buttonMy_GVM.BackColor = Color.Blue;
            buttonMy_GVM.Location = new Point(1042, 17);
            buttonMy_GVM.Name = "buttonMy_GVM";
            buttonMy_GVM.Size = new Size(110, 99);
            buttonMy_GVM.TabIndex = 4;
            buttonMy_GVM.Text = "Справка";
            buttonMy_GVM.UseVisualStyleBackColor = false;
            buttonMy_GVM.Click += buttonMy_GVM_Click;
            // 
            // chartRes_GVM
            // 
            chartArea1.Name = "ChartArea1";
            chartRes_GVM.ChartAreas.Add(chartArea1);
            legend1.Name = "Legend1";
            chartRes_GVM.Legends.Add(legend1);
            chartRes_GVM.Location = new Point(314, 143);
            chartRes_GVM.Name = "chartRes_GVM";
            series1.ChartArea = "ChartArea1";
            series1.Legend = "Legend1";
            series1.Name = "Series1";
            chartRes_GVM.Series.Add(series1);
            chartRes_GVM.Size = new Size(867, 393);
            chartRes_GVM.TabIndex = 5;
            chartRes_GVM.Text = "chart1";
            // 
            // FormMain
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(1193, 548);
            Controls.Add(chartRes_GVM);
            Controls.Add(buttonMy_GVM);
            Controls.Add(buttonOpen_GVM);
            Controls.Add(buttonDone_GVM);
            Controls.Add(groupBoxEnter_GVM);
            Controls.Add(groupBoxUs_GVM);
            Name = "FormMain";
            Text = "Form1";
            Load += Form1_Load;
            groupBoxUs_GVM.ResumeLayout(false);
            groupBoxUs_GVM.PerformLayout();
            groupBoxEnter_GVM.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)dataGridView_GVM).EndInit();
            ((System.ComponentModel.ISupportInitialize)chartRes_GVM).EndInit();
            ResumeLayout(false);
        }

        #endregion

        private GroupBox groupBoxUs_GVM;
        private TextBox textBox1;
        private GroupBox groupBoxEnter_GVM;
        private Button buttonDone_GVM;
        private Button buttonOpen_GVM;
        private Button buttonMy_GVM;
        private DataGridView dataGridView_GVM;
        private System.Windows.Forms.DataVisualization.Charting.Chart chartRes_GVM;
    }
}
