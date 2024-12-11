namespace Tyuiu.GurzanVM.Sprint6.Task1.V3
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
            groupCond_GVM = new GroupBox();
            textCond_VGM = new TextBox();
            groupEnter_GVM = new GroupBox();
            textEnter2_GVM = new TextBox();
            textEnter1_GVM = new TextBox();
            textEnterStop_GVM = new TextBox();
            textEnterStart_GVM = new TextBox();
            buttonEx_GVM = new Button();
            buttonSP_GVM = new Button();
            groupConc_GVM = new GroupBox();
            textRez_GVM = new TextBox();
            textRes_GVM = new TextBox();
            groupCond_GVM.SuspendLayout();
            groupEnter_GVM.SuspendLayout();
            groupConc_GVM.SuspendLayout();
            SuspendLayout();
            // 
            // groupCond_GVM
            // 
            groupCond_GVM.Controls.Add(textCond_VGM);
            groupCond_GVM.Location = new Point(12, 12);
            groupCond_GVM.Name = "groupCond_GVM";
            groupCond_GVM.Size = new Size(499, 297);
            groupCond_GVM.TabIndex = 0;
            groupCond_GVM.TabStop = false;
            groupCond_GVM.Text = "Условие";
            // 
            // textCond_VGM
            // 
            textCond_VGM.BackColor = SystemColors.Control;
            textCond_VGM.BorderStyle = BorderStyle.None;
            textCond_VGM.Location = new Point(6, 26);
            textCond_VGM.Multiline = true;
            textCond_VGM.Name = "textCond_VGM";
            textCond_VGM.ReadOnly = true;
            textCond_VGM.Size = new Size(439, 47);
            textCond_VGM.TabIndex = 0;
            textCond_VGM.Text = "Протабулировать функцию sin(x) на заданном диапозоне. Результат вывести в виде таблицы  ";
            // 
            // groupEnter_GVM
            // 
            groupEnter_GVM.Controls.Add(textEnter2_GVM);
            groupEnter_GVM.Controls.Add(textEnter1_GVM);
            groupEnter_GVM.Controls.Add(textEnterStop_GVM);
            groupEnter_GVM.Controls.Add(textEnterStart_GVM);
            groupEnter_GVM.Location = new Point(12, 325);
            groupEnter_GVM.Name = "groupEnter_GVM";
            groupEnter_GVM.Size = new Size(392, 113);
            groupEnter_GVM.TabIndex = 1;
            groupEnter_GVM.TabStop = false;
            groupEnter_GVM.Text = "Ввод данных";
            // 
            // textEnter2_GVM
            // 
            textEnter2_GVM.BackColor = SystemColors.Window;
            textEnter2_GVM.Location = new Point(227, 80);
            textEnter2_GVM.Name = "textEnter2_GVM";
            textEnter2_GVM.Size = new Size(159, 27);
            textEnter2_GVM.TabIndex = 3;
            // 
            // textEnter1_GVM
            // 
            textEnter1_GVM.Location = new Point(6, 80);
            textEnter1_GVM.Name = "textEnter1_GVM";
            textEnter1_GVM.Size = new Size(155, 27);
            textEnter1_GVM.TabIndex = 2;
            // 
            // textEnterStop_GVM
            // 
            textEnterStop_GVM.BackColor = SystemColors.Control;
            textEnterStop_GVM.BorderStyle = BorderStyle.None;
            textEnterStop_GVM.Location = new Point(261, 26);
            textEnterStop_GVM.Name = "textEnterStop_GVM";
            textEnterStop_GVM.ReadOnly = true;
            textEnterStop_GVM.Size = new Size(125, 20);
            textEnterStop_GVM.TabIndex = 1;
            textEnterStop_GVM.Text = "Конец шага:";
            // 
            // textEnterStart_GVM
            // 
            textEnterStart_GVM.BackColor = SystemColors.Control;
            textEnterStart_GVM.BorderStyle = BorderStyle.None;
            textEnterStart_GVM.Location = new Point(6, 26);
            textEnterStart_GVM.Name = "textEnterStart_GVM";
            textEnterStart_GVM.ReadOnly = true;
            textEnterStart_GVM.Size = new Size(125, 20);
            textEnterStart_GVM.TabIndex = 0;
            textEnterStart_GVM.Text = "Старт шага:";
            // 
            // buttonEx_GVM
            // 
            buttonEx_GVM.BackColor = Color.Lime;
            buttonEx_GVM.Location = new Point(412, 315);
            buttonEx_GVM.Name = "buttonEx_GVM";
            buttonEx_GVM.Size = new Size(99, 63);
            buttonEx_GVM.TabIndex = 2;
            buttonEx_GVM.Text = "Выполнить";
            buttonEx_GVM.UseVisualStyleBackColor = false;
            buttonEx_GVM.Click += buttonEx_GVM_Click;
            // 
            // buttonSP_GVM
            // 
            buttonSP_GVM.BackColor = Color.DodgerBlue;
            buttonSP_GVM.Location = new Point(412, 394);
            buttonSP_GVM.Name = "buttonSP_GVM";
            buttonSP_GVM.Size = new Size(99, 48);
            buttonSP_GVM.TabIndex = 3;
            buttonSP_GVM.Text = "Справка";
            buttonSP_GVM.UseVisualStyleBackColor = false;
            buttonSP_GVM.Click += buttonSP_GVM_Click;
            // 
            // groupConc_GVM
            // 
            groupConc_GVM.Controls.Add(textRez_GVM);
            groupConc_GVM.Controls.Add(textRes_GVM);
            groupConc_GVM.Location = new Point(517, 12);
            groupConc_GVM.Name = "groupConc_GVM";
            groupConc_GVM.Size = new Size(271, 430);
            groupConc_GVM.TabIndex = 4;
            groupConc_GVM.TabStop = false;
            groupConc_GVM.Text = "Вывод данных";
            // 
            // textRez_GVM
            // 
            textRez_GVM.BackColor = SystemColors.Control;
            textRez_GVM.Font = new Font("Consolas", 9F, FontStyle.Regular, GraphicsUnit.Point, 204);
            textRez_GVM.Location = new Point(6, 52);
            textRez_GVM.Multiline = true;
            textRez_GVM.Name = "textRez_GVM";
            textRez_GVM.ReadOnly = true;
            textRez_GVM.Size = new Size(259, 372);
            textRez_GVM.TabIndex = 1;
            // 
            // textRes_GVM
            // 
            textRes_GVM.BackColor = SystemColors.Control;
            textRes_GVM.BorderStyle = BorderStyle.None;
            textRes_GVM.Location = new Point(6, 26);
            textRes_GVM.Name = "textRes_GVM";
            textRes_GVM.ReadOnly = true;
            textRes_GVM.Size = new Size(125, 20);
            textRes_GVM.TabIndex = 0;
            textRes_GVM.Text = "Результат:";
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(800, 450);
            Controls.Add(groupConc_GVM);
            Controls.Add(buttonSP_GVM);
            Controls.Add(buttonEx_GVM);
            Controls.Add(groupEnter_GVM);
            Controls.Add(groupCond_GVM);
            Name = "Form1";
            Text = "Form1";
            groupCond_GVM.ResumeLayout(false);
            groupCond_GVM.PerformLayout();
            groupEnter_GVM.ResumeLayout(false);
            groupEnter_GVM.PerformLayout();
            groupConc_GVM.ResumeLayout(false);
            groupConc_GVM.PerformLayout();
            ResumeLayout(false);
        }

        #endregion

        private GroupBox groupCond_GVM;
        private TextBox textCond_VGM;
        private GroupBox groupEnter_GVM;
        private TextBox textEnterStop_GVM;
        private TextBox textEnterStart_GVM;
        private TextBox textEnter2_GVM;
        private TextBox textEnter1_GVM;
        private Button buttonEx_GVM;
        private Button buttonSP_GVM;
        private GroupBox groupConc_GVM;
        private TextBox textRes_GVM;
        private TextBox textRez_GVM;
    }
}
