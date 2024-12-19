namespace Tyuiu.GurzanVM.Sprint6.Task7.V4
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
            components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FormMain));
            groupBoxUs_GVM = new GroupBox();
            textBox1 = new TextBox();
            groupBoxEnter_GVM = new GroupBox();
            dataGridViewEnter_GVM = new DataGridView();
            groupBoxNotEnter_GVM = new GroupBox();
            dataGridViewNotEnter_GVM = new DataGridView();
            buttonFile_GVM = new Button();
            buttonDone_GVM = new Button();
            buttonMy_GVM = new Button();
            buttonSave_GVM = new Button();
            openFileDialogTask = new OpenFileDialog();
            toolTipButton = new ToolTip(components);
            saveFileDialogMatrix = new SaveFileDialog();
            groupBoxUs_GVM.SuspendLayout();
            groupBoxEnter_GVM.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)dataGridViewEnter_GVM).BeginInit();
            groupBoxNotEnter_GVM.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)dataGridViewNotEnter_GVM).BeginInit();
            SuspendLayout();
            // 
            // groupBoxUs_GVM
            // 
            groupBoxUs_GVM.Controls.Add(textBox1);
            groupBoxUs_GVM.Location = new Point(12, 96);
            groupBoxUs_GVM.Name = "groupBoxUs_GVM";
            groupBoxUs_GVM.Size = new Size(1317, 125);
            groupBoxUs_GVM.TabIndex = 0;
            groupBoxUs_GVM.TabStop = false;
            groupBoxUs_GVM.Text = "Условие";
            // 
            // textBox1
            // 
            textBox1.BackColor = SystemColors.Control;
            textBox1.BorderStyle = BorderStyle.None;
            textBox1.Location = new Point(6, 19);
            textBox1.Multiline = true;
            textBox1.Name = "textBox1";
            textBox1.Size = new Size(1305, 100);
            textBox1.TabIndex = 0;
            textBox1.Text = resources.GetString("textBox1.Text");
            // 
            // groupBoxEnter_GVM
            // 
            groupBoxEnter_GVM.Controls.Add(dataGridViewEnter_GVM);
            groupBoxEnter_GVM.Location = new Point(12, 227);
            groupBoxEnter_GVM.Name = "groupBoxEnter_GVM";
            groupBoxEnter_GVM.Size = new Size(694, 315);
            groupBoxEnter_GVM.TabIndex = 1;
            groupBoxEnter_GVM.TabStop = false;
            groupBoxEnter_GVM.Text = "Ввод:";
            // 
            // dataGridViewEnter_GVM
            // 
            dataGridViewEnter_GVM.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridViewEnter_GVM.Location = new Point(6, 26);
            dataGridViewEnter_GVM.Name = "dataGridViewEnter_GVM";
            dataGridViewEnter_GVM.RowHeadersVisible = false;
            dataGridViewEnter_GVM.RowHeadersWidth = 51;
            dataGridViewEnter_GVM.Size = new Size(682, 283);
            dataGridViewEnter_GVM.TabIndex = 0;
            // 
            // groupBoxNotEnter_GVM
            // 
            groupBoxNotEnter_GVM.Controls.Add(dataGridViewNotEnter_GVM);
            groupBoxNotEnter_GVM.Location = new Point(712, 227);
            groupBoxNotEnter_GVM.Name = "groupBoxNotEnter_GVM";
            groupBoxNotEnter_GVM.Size = new Size(617, 315);
            groupBoxNotEnter_GVM.TabIndex = 2;
            groupBoxNotEnter_GVM.TabStop = false;
            groupBoxNotEnter_GVM.Text = "Вывод:";
            // 
            // dataGridViewNotEnter_GVM
            // 
            dataGridViewNotEnter_GVM.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridViewNotEnter_GVM.Location = new Point(6, 26);
            dataGridViewNotEnter_GVM.Name = "dataGridViewNotEnter_GVM";
            dataGridViewNotEnter_GVM.RowHeadersWidth = 51;
            dataGridViewNotEnter_GVM.Size = new Size(605, 283);
            dataGridViewNotEnter_GVM.TabIndex = 0;
            // 
            // buttonFile_GVM
            // 
            buttonFile_GVM.BackColor = Color.Yellow;
            buttonFile_GVM.FlatStyle = FlatStyle.Flat;
            buttonFile_GVM.Location = new Point(12, 12);
            buttonFile_GVM.Name = "buttonFile_GVM";
            buttonFile_GVM.Size = new Size(121, 78);
            buttonFile_GVM.TabIndex = 3;
            buttonFile_GVM.Text = "Открыть файл";
            buttonFile_GVM.UseVisualStyleBackColor = false;
            buttonFile_GVM.Click += buttonFile_GVM_Click;
            buttonFile_GVM.MouseEnter += buttonFile_GVM_MouseEnter;
            // 
            // buttonDone_GVM
            // 
            buttonDone_GVM.BackColor = Color.Green;
            buttonDone_GVM.FlatStyle = FlatStyle.Flat;
            buttonDone_GVM.Location = new Point(139, 12);
            buttonDone_GVM.Name = "buttonDone_GVM";
            buttonDone_GVM.Size = new Size(121, 78);
            buttonDone_GVM.TabIndex = 4;
            buttonDone_GVM.Text = "Выполнить";
            buttonDone_GVM.UseVisualStyleBackColor = false;
            buttonDone_GVM.Click += buttonDone_GVM_Click;
            buttonDone_GVM.MouseEnter += buttonDone_GVM_MouseEnter;
            // 
            // buttonMy_GVM
            // 
            buttonMy_GVM.BackColor = Color.Blue;
            buttonMy_GVM.FlatStyle = FlatStyle.Flat;
            buttonMy_GVM.Location = new Point(1202, 12);
            buttonMy_GVM.Name = "buttonMy_GVM";
            buttonMy_GVM.Size = new Size(121, 78);
            buttonMy_GVM.TabIndex = 5;
            buttonMy_GVM.Text = "Справка";
            buttonMy_GVM.UseVisualStyleBackColor = false;
            // 
            // buttonSave_GVM
            // 
            buttonSave_GVM.BackColor = Color.Orange;
            buttonSave_GVM.FlatStyle = FlatStyle.Flat;
            buttonSave_GVM.Location = new Point(266, 12);
            buttonSave_GVM.Name = "buttonSave_GVM";
            buttonSave_GVM.Size = new Size(121, 78);
            buttonSave_GVM.TabIndex = 6;
            buttonSave_GVM.Text = "Сохранить файл";
            buttonSave_GVM.UseVisualStyleBackColor = false;
            buttonSave_GVM.Click += buttonSave_GVM_Click;
            buttonSave_GVM.MouseEnter += buttonSave_GVM_MouseEnter;
            // 
            // openFileDialogTask
            // 
            openFileDialogTask.FileName = "openFileDialog1";
            // 
            // toolTipButton
            // 
            toolTipButton.IsBalloon = true;
            toolTipButton.ToolTipIcon = ToolTipIcon.Info;
            toolTipButton.ToolTipTitle = "Подсказка";
            // 
            // FormMain
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(1341, 554);
            Controls.Add(buttonSave_GVM);
            Controls.Add(buttonMy_GVM);
            Controls.Add(buttonDone_GVM);
            Controls.Add(buttonFile_GVM);
            Controls.Add(groupBoxNotEnter_GVM);
            Controls.Add(groupBoxEnter_GVM);
            Controls.Add(groupBoxUs_GVM);
            FormBorderStyle = FormBorderStyle.Fixed3D;
            Name = "FormMain";
            Text = "Form1";
            Load += FormMain_Load;
            groupBoxUs_GVM.ResumeLayout(false);
            groupBoxUs_GVM.PerformLayout();
            groupBoxEnter_GVM.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)dataGridViewEnter_GVM).EndInit();
            groupBoxNotEnter_GVM.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)dataGridViewNotEnter_GVM).EndInit();
            ResumeLayout(false);
        }

        #endregion

        private GroupBox groupBoxUs_GVM;
        private TextBox textBox1;
        private GroupBox groupBoxEnter_GVM;
        private DataGridView dataGridViewEnter_GVM;
        private GroupBox groupBoxNotEnter_GVM;
        private DataGridView dataGridViewNotEnter_GVM;
        private Button buttonFile_GVM;
        private Button buttonDone_GVM;
        private Button buttonMy_GVM;
        private Button buttonSave_GVM;
        private OpenFileDialog openFileDialogTask;
        private ToolTip toolTipButton;
        private SaveFileDialog saveFileDialogMatrix;
    }
}
