namespace Tyuiu.GurzanVM.Sprint6.Task6.V29
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
            groupBoxV_GVM = new GroupBox();
            textBoxV_GVM = new TextBox();
            groupBoxVi_GVM = new GroupBox();
            textBoxRes_GVM = new TextBox();
            buttonDone_GVM = new Button();
            buttonSp_GVM = new Button();
            openFileDialogTask_GVM = new OpenFileDialog();
            toolTip_GVM = new ToolTip(components);
            buttonOpen_GVM = new Button();
            backgroundWorker1 = new System.ComponentModel.BackgroundWorker();
            groupBoxUs_GVM.SuspendLayout();
            groupBoxV_GVM.SuspendLayout();
            groupBoxVi_GVM.SuspendLayout();
            SuspendLayout();
            // 
            // groupBoxUs_GVM
            // 
            groupBoxUs_GVM.Controls.Add(textBox1);
            groupBoxUs_GVM.Location = new Point(12, 86);
            groupBoxUs_GVM.Name = "groupBoxUs_GVM";
            groupBoxUs_GVM.Size = new Size(1258, 125);
            groupBoxUs_GVM.TabIndex = 0;
            groupBoxUs_GVM.TabStop = false;
            groupBoxUs_GVM.Text = "Условие:";
            // 
            // textBox1
            // 
            textBox1.BorderStyle = BorderStyle.None;
            textBox1.Location = new Point(0, 26);
            textBox1.Multiline = true;
            textBox1.Name = "textBox1";
            textBox1.ReadOnly = true;
            textBox1.Size = new Size(1258, 93);
            textBox1.TabIndex = 0;
            textBox1.Text = resources.GetString("textBox1.Text");
            // 
            // groupBoxV_GVM
            // 
            groupBoxV_GVM.Controls.Add(textBoxV_GVM);
            groupBoxV_GVM.Location = new Point(12, 217);
            groupBoxV_GVM.Name = "groupBoxV_GVM";
            groupBoxV_GVM.Size = new Size(649, 314);
            groupBoxV_GVM.TabIndex = 1;
            groupBoxV_GVM.TabStop = false;
            groupBoxV_GVM.Text = "Ввод:";
            // 
            // textBoxV_GVM
            // 
            textBoxV_GVM.Location = new Point(6, 26);
            textBoxV_GVM.Multiline = true;
            textBoxV_GVM.Name = "textBoxV_GVM";
            textBoxV_GVM.ScrollBars = ScrollBars.Both;
            textBoxV_GVM.Size = new Size(643, 282);
            textBoxV_GVM.TabIndex = 0;
            // 
            // groupBoxVi_GVM
            // 
            groupBoxVi_GVM.Controls.Add(textBoxRes_GVM);
            groupBoxVi_GVM.Location = new Point(667, 217);
            groupBoxVi_GVM.Name = "groupBoxVi_GVM";
            groupBoxVi_GVM.Size = new Size(603, 314);
            groupBoxVi_GVM.TabIndex = 2;
            groupBoxVi_GVM.TabStop = false;
            groupBoxVi_GVM.Text = "Вывод:";
            // 
            // textBoxRes_GVM
            // 
            textBoxRes_GVM.Location = new Point(6, 26);
            textBoxRes_GVM.Multiline = true;
            textBoxRes_GVM.Name = "textBoxRes_GVM";
            textBoxRes_GVM.ScrollBars = ScrollBars.Both;
            textBoxRes_GVM.Size = new Size(597, 282);
            textBoxRes_GVM.TabIndex = 0;
            // 
            // buttonDone_GVM
            // 
            buttonDone_GVM.BackColor = Color.Green;
            buttonDone_GVM.Location = new Point(133, 4);
            buttonDone_GVM.Name = "buttonDone_GVM";
            buttonDone_GVM.Size = new Size(115, 78);
            buttonDone_GVM.TabIndex = 4;
            buttonDone_GVM.Text = "Выполнить";
            toolTip_GVM.SetToolTip(buttonDone_GVM, "Нажмите для выполнения программы\r\n");
            buttonDone_GVM.UseVisualStyleBackColor = false;
            buttonDone_GVM.Click += buttonDone_GVM_Click;
            // 
            // buttonSp_GVM
            // 
            buttonSp_GVM.BackColor = Color.DodgerBlue;
            buttonSp_GVM.Location = new Point(1155, 4);
            buttonSp_GVM.Name = "buttonSp_GVM";
            buttonSp_GVM.Size = new Size(115, 78);
            buttonSp_GVM.TabIndex = 5;
            buttonSp_GVM.Text = "Справка";
            toolTip_GVM.SetToolTip(buttonSp_GVM, "Информация о создателе приложения");
            buttonSp_GVM.UseVisualStyleBackColor = false;
            buttonSp_GVM.Click += buttonSp_GVM_Click;
            // 
            // openFileDialogTask_GVM
            // 
            openFileDialogTask_GVM.FileName = "openFileDialog1";
            // 
            // toolTip_GVM
            // 
            toolTip_GVM.ToolTipIcon = ToolTipIcon.Info;
            toolTip_GVM.ToolTipTitle = "Подсказка";
            // 
            // buttonOpen_GVM
            // 
            buttonOpen_GVM.BackColor = Color.Yellow;
            buttonOpen_GVM.Location = new Point(18, 4);
            buttonOpen_GVM.Name = "buttonOpen_GVM";
            buttonOpen_GVM.Size = new Size(115, 78);
            buttonOpen_GVM.TabIndex = 6;
            buttonOpen_GVM.Text = "Выбрать";
            toolTip_GVM.SetToolTip(buttonOpen_GVM, "Нажмите для выбора файла, который хотите открыть\r\n");
            buttonOpen_GVM.UseVisualStyleBackColor = false;
            buttonOpen_GVM.Click += buttonOpen_GVM_Click_1;
            // 
            // FormMain
            // 
            AutoScaleMode = AutoScaleMode.None;
            BackColor = SystemColors.Control;
            ClientSize = new Size(1282, 543);
            Controls.Add(buttonOpen_GVM);
            Controls.Add(buttonSp_GVM);
            Controls.Add(buttonDone_GVM);
            Controls.Add(groupBoxVi_GVM);
            Controls.Add(groupBoxV_GVM);
            Controls.Add(groupBoxUs_GVM);
            Font = new Font("Microsoft Sans Serif", 9F, FontStyle.Regular, GraphicsUnit.Point, 204);
            FormBorderStyle = FormBorderStyle.Fixed3D;
            Name = "FormMain";
            RightToLeft = RightToLeft.No;
            Text = "Спринт 6 | Такс 6 | Вариант 29 | Гурзан В.М";
            Load += FormMain_Load;
            groupBoxUs_GVM.ResumeLayout(false);
            groupBoxUs_GVM.PerformLayout();
            groupBoxV_GVM.ResumeLayout(false);
            groupBoxV_GVM.PerformLayout();
            groupBoxVi_GVM.ResumeLayout(false);
            groupBoxVi_GVM.PerformLayout();
            ResumeLayout(false);
        }

        #endregion

        private GroupBox groupBoxUs_GVM;
        private TextBox textBox1;
        private GroupBox groupBoxV_GVM;
        private TextBox textBoxV_GVM;
        private GroupBox groupBoxVi_GVM;
        private TextBox textBoxRes_GVM;
        private Button buttonDone_GVM;
        private Button buttonSp_GVM;
        private OpenFileDialog openFileDialogTask_GVM;
        private ToolTip toolTip_GVM;
        private System.ComponentModel.BackgroundWorker backgroundWorker1;
        private Button buttonOpen_GVM;
    }
}
