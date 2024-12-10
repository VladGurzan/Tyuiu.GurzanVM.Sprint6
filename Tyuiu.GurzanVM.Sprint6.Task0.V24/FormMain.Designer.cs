namespace Tyuiu.GurzanVM.Sprint6.Task0.V24
{
    partial class FormTask_VGM
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
            groupBoxTask_GVM = new GroupBox();
            textBoxTask_VGM = new TextBox();
            pictureBoxTask_GVM = new PictureBox();
            groupVar_GVM = new GroupBox();
            textVarReadX = new TextBox();
            textVarX_GVM = new TextBox();
            backgroundWorker1 = new System.ComponentModel.BackgroundWorker();
            groupRes_GVM = new GroupBox();
            textVarRes_VGM = new TextBox();
            textRes_GVM = new TextBox();
            ButtonDone_GVM = new Button();
            ButtonHelp_VGM = new Button();
            groupBoxTask_GVM.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)pictureBoxTask_GVM).BeginInit();
            groupVar_GVM.SuspendLayout();
            groupRes_GVM.SuspendLayout();
            SuspendLayout();
            // 
            // groupBoxTask_GVM
            // 
            groupBoxTask_GVM.Controls.Add(textBoxTask_VGM);
            groupBoxTask_GVM.Controls.Add(pictureBoxTask_GVM);
            groupBoxTask_GVM.FlatStyle = FlatStyle.Flat;
            groupBoxTask_GVM.Font = new Font("Microsoft Sans Serif", 9F, FontStyle.Regular, GraphicsUnit.Point, 204);
            groupBoxTask_GVM.ForeColor = SystemColors.ControlText;
            groupBoxTask_GVM.Location = new Point(33, 12);
            groupBoxTask_GVM.Name = "groupBoxTask_GVM";
            groupBoxTask_GVM.Size = new Size(835, 176);
            groupBoxTask_GVM.TabIndex = 1;
            groupBoxTask_GVM.TabStop = false;
            groupBoxTask_GVM.Text = "Условие";
            groupBoxTask_GVM.Enter += groupBox1_Enter;
            // 
            // textBoxTask_VGM
            // 
            textBoxTask_VGM.BackColor = SystemColors.Control;
            textBoxTask_VGM.BorderStyle = BorderStyle.None;
            textBoxTask_VGM.Location = new Point(17, 23);
            textBoxTask_VGM.Multiline = true;
            textBoxTask_VGM.Name = "textBoxTask_VGM";
            textBoxTask_VGM.ReadOnly = true;
            textBoxTask_VGM.Size = new Size(619, 153);
            textBoxTask_VGM.TabIndex = 1;
            textBoxTask_VGM.Text = "вычислить выражение по формуле";
            // 
            // pictureBoxTask_GVM
            // 
            pictureBoxTask_GVM.Image = Properties.Resources.Снимок_экрана_2024_12_10_175402;
            pictureBoxTask_GVM.Location = new Point(659, 23);
            pictureBoxTask_GVM.Name = "pictureBoxTask_GVM";
            pictureBoxTask_GVM.Size = new Size(170, 75);
            pictureBoxTask_GVM.TabIndex = 0;
            pictureBoxTask_GVM.TabStop = false;
            // 
            // groupVar_GVM
            // 
            groupVar_GVM.Controls.Add(textVarReadX);
            groupVar_GVM.Controls.Add(textVarX_GVM);
            groupVar_GVM.Location = new Point(33, 209);
            groupVar_GVM.Name = "groupVar_GVM";
            groupVar_GVM.Size = new Size(554, 156);
            groupVar_GVM.TabIndex = 2;
            groupVar_GVM.TabStop = false;
            groupVar_GVM.Text = "Ввод данных";
            // 
            // textVarReadX
            // 
            textVarReadX.Location = new Point(209, 96);
            textVarReadX.Name = "textVarReadX";
            textVarReadX.Size = new Size(114, 24);
            textVarReadX.TabIndex = 1;
            // 
            // textVarX_GVM
            // 
            textVarX_GVM.BackColor = SystemColors.Control;
            textVarX_GVM.BorderStyle = BorderStyle.None;
            textVarX_GVM.Location = new Point(209, 41);
            textVarX_GVM.Multiline = true;
            textVarX_GVM.Name = "textVarX_GVM";
            textVarX_GVM.ReadOnly = true;
            textVarX_GVM.Size = new Size(114, 35);
            textVarX_GVM.TabIndex = 0;
            textVarX_GVM.Text = "Переменная Х";
            // 
            // groupRes_GVM
            // 
            groupRes_GVM.Controls.Add(textVarRes_VGM);
            groupRes_GVM.Controls.Add(textRes_GVM);
            groupRes_GVM.Location = new Point(618, 209);
            groupRes_GVM.Name = "groupRes_GVM";
            groupRes_GVM.Size = new Size(250, 156);
            groupRes_GVM.TabIndex = 2;
            groupRes_GVM.TabStop = false;
            groupRes_GVM.Text = "Вывод данных";
            // 
            // textVarRes_VGM
            // 
            textVarRes_VGM.Cursor = Cursors.IBeam;
            textVarRes_VGM.Location = new Point(74, 96);
            textVarRes_VGM.Name = "textVarRes_VGM";
            textVarRes_VGM.ReadOnly = true;
            textVarRes_VGM.Size = new Size(125, 24);
            textVarRes_VGM.TabIndex = 1;
            textVarRes_VGM.TextChanged += textVarRes_VGM_TextChanged;
            // 
            // textRes_GVM
            // 
            textRes_GVM.BackColor = SystemColors.Control;
            textRes_GVM.BorderStyle = BorderStyle.None;
            textRes_GVM.Location = new Point(6, 41);
            textRes_GVM.Name = "textRes_GVM";
            textRes_GVM.Size = new Size(114, 17);
            textRes_GVM.TabIndex = 0;
            textRes_GVM.Text = "Результат";
            // 
            // ButtonDone_GVM
            // 
            ButtonDone_GVM.Location = new Point(692, 353);
            ButtonDone_GVM.Name = "ButtonDone_GVM";
            ButtonDone_GVM.Size = new Size(176, 40);
            ButtonDone_GVM.TabIndex = 1;
            ButtonDone_GVM.Text = "Выполнить";
            ButtonDone_GVM.UseVisualStyleBackColor = true;
            // 
            // ButtonHelp_VGM
            // 
            ButtonHelp_VGM.FlatStyle = FlatStyle.Flat;
            ButtonHelp_VGM.Location = new Point(643, 353);
            ButtonHelp_VGM.Name = "ButtonHelp_VGM";
            ButtonHelp_VGM.Size = new Size(43, 40);
            ButtonHelp_VGM.TabIndex = 3;
            ButtonHelp_VGM.Text = "?";
            ButtonHelp_VGM.UseVisualStyleBackColor = true;
            ButtonHelp_VGM.Click += ButtonHelp_VGM_Click;
            // 
            // FormTask_VGM
            // 
            AutoScaleMode = AutoScaleMode.None;
            BackColor = SystemColors.Control;
            ClientSize = new Size(900, 405);
            Controls.Add(ButtonHelp_VGM);
            Controls.Add(ButtonDone_GVM);
            Controls.Add(groupRes_GVM);
            Controls.Add(groupVar_GVM);
            Controls.Add(groupBoxTask_GVM);
            Font = new Font("Microsoft Sans Serif", 9F, FontStyle.Regular, GraphicsUnit.Point, 204);
            ForeColor = Color.Black;
            Name = "FormTask_VGM";
            RightToLeft = RightToLeft.No;
            Text = "Спринт 6 | Такс 0 | Вариант 24 | Гурзан В.М";
            Load += FormTask_VGM_Load;
            groupBoxTask_GVM.ResumeLayout(false);
            groupBoxTask_GVM.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)pictureBoxTask_GVM).EndInit();
            groupVar_GVM.ResumeLayout(false);
            groupVar_GVM.PerformLayout();
            groupRes_GVM.ResumeLayout(false);
            groupRes_GVM.PerformLayout();
            ResumeLayout(false);
        }

        #endregion

        private GroupBox groupBoxTask_GVM;
        private PictureBox pictureBoxTask_GVM;
        private TextBox textBoxTask_VGM;
        private GroupBox groupVar_GVM;
        private System.ComponentModel.BackgroundWorker backgroundWorker1;
        private TextBox textVarX_GVM;
        private GroupBox groupRes_GVM;
        private TextBox textRes_GVM;
        private Button ButtonDone_GVM;
        private TextBox textVarReadX;
        private TextBox textVarRes_VGM;
        private Button ButtonHelp_VGM;
    }
}
