namespace Tyuiu.GurzanVM.Sprint6.Task3.V3
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
            groupBoxUs_GVM = new GroupBox();
            dataGridViewMatrix = new DataGridView();
            textBoxUs_GVM = new TextBox();
            groupBoxVi_GVM = new GroupBox();
            textBoxViv_GVM = new TextBox();
            textBoxVi_GVM = new TextBox();
            buttonMy_GVM = new Button();
            buttonDone_GVM = new Button();
            groupBoxUs_GVM.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)dataGridViewMatrix).BeginInit();
            groupBoxVi_GVM.SuspendLayout();
            SuspendLayout();
            // 
            // groupBoxUs_GVM
            // 
            groupBoxUs_GVM.Controls.Add(dataGridViewMatrix);
            groupBoxUs_GVM.Controls.Add(textBoxUs_GVM);
            groupBoxUs_GVM.Location = new Point(12, 12);
            groupBoxUs_GVM.Name = "groupBoxUs_GVM";
            groupBoxUs_GVM.Size = new Size(709, 426);
            groupBoxUs_GVM.TabIndex = 0;
            groupBoxUs_GVM.TabStop = false;
            groupBoxUs_GVM.Text = "Условие";
            // 
            // dataGridViewMatrix
            // 
            dataGridViewMatrix.ColumnHeadersHeight = 20;
            dataGridViewMatrix.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.DisableResizing;
            dataGridViewMatrix.Location = new Point(353, 40);
            dataGridViewMatrix.Name = "dataGridViewMatrix";
            dataGridViewMatrix.RowHeadersVisible = false;
            dataGridViewMatrix.RowHeadersWidth = 120;
            dataGridViewMatrix.Size = new Size(350, 350);
            dataGridViewMatrix.TabIndex = 1;
            // 
            // textBoxUs_GVM
            // 
            textBoxUs_GVM.BorderStyle = BorderStyle.None;
            textBoxUs_GVM.Location = new Point(6, 26);
            textBoxUs_GVM.Multiline = true;
            textBoxUs_GVM.Name = "textBoxUs_GVM";
            textBoxUs_GVM.ReadOnly = true;
            textBoxUs_GVM.Size = new Size(345, 182);
            textBoxUs_GVM.TabIndex = 0;
            textBoxUs_GVM.Text = "Дана матрица 5 на 5 \r\n-18  21  10  -2  12\r\n-18 -10  33 -20  32\r\n 14 -15 -14  12 -18\r\n-19   5  -3  28 -17\r\n-14  -9  23 -13  11\r\nВыполнить сортировку по возрастанию во втором столбце.\r\n";
            // 
            // groupBoxVi_GVM
            // 
            groupBoxVi_GVM.Controls.Add(textBoxViv_GVM);
            groupBoxVi_GVM.Controls.Add(textBoxVi_GVM);
            groupBoxVi_GVM.Location = new Point(727, 12);
            groupBoxVi_GVM.Name = "groupBoxVi_GVM";
            groupBoxVi_GVM.Size = new Size(263, 138);
            groupBoxVi_GVM.TabIndex = 1;
            groupBoxVi_GVM.TabStop = false;
            groupBoxVi_GVM.Text = "Вывод данных";
            // 
            // textBoxViv_GVM
            // 
            textBoxViv_GVM.Location = new Point(6, 49);
            textBoxViv_GVM.Name = "textBoxViv_GVM";
            textBoxViv_GVM.Size = new Size(148, 27);
            textBoxViv_GVM.TabIndex = 1;
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
            // buttonMy_GVM
            // 
            buttonMy_GVM.BackColor = Color.Orange;
            buttonMy_GVM.Location = new Point(733, 363);
            buttonMy_GVM.Name = "buttonMy_GVM";
            buttonMy_GVM.Size = new Size(75, 75);
            buttonMy_GVM.TabIndex = 2;
            buttonMy_GVM.Text = "?";
            buttonMy_GVM.UseVisualStyleBackColor = false;
            buttonMy_GVM.Click += buttonMy_GVM_Click;
            // 
            // buttonDone_GVM
            // 
            buttonDone_GVM.BackColor = Color.Green;
            buttonDone_GVM.Location = new Point(870, 363);
            buttonDone_GVM.Name = "buttonDone_GVM";
            buttonDone_GVM.Size = new Size(120, 75);
            buttonDone_GVM.TabIndex = 3;
            buttonDone_GVM.Text = "Выполнить";
            buttonDone_GVM.UseVisualStyleBackColor = false;
            buttonDone_GVM.Click += buttonDone_GVM_Click;
            // 
            // FormMain
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(1002, 450);
            Controls.Add(buttonDone_GVM);
            Controls.Add(buttonMy_GVM);
            Controls.Add(groupBoxVi_GVM);
            Controls.Add(groupBoxUs_GVM);
            Name = "FormMain";
            Text = "Form1";
            Load += FormMain_Load;
            groupBoxUs_GVM.ResumeLayout(false);
            groupBoxUs_GVM.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)dataGridViewMatrix).EndInit();
            groupBoxVi_GVM.ResumeLayout(false);
            groupBoxVi_GVM.PerformLayout();
            ResumeLayout(false);
        }

        #endregion

        private GroupBox groupBoxUs_GVM;
        private TextBox textBoxUs_GVM;
        private DataGridView dataGridViewMatrix;
        private GroupBox groupBoxVi_GVM;
        private TextBox textBoxViv_GVM;
        private TextBox textBoxVi_GVM;
        private Button buttonMy_GVM;
        private Button buttonDone_GVM;
    }
}
