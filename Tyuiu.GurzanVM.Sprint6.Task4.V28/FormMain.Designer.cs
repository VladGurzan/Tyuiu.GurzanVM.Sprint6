namespace Tyuiu.GurzanVM.Sprint6.Task4.V28
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
            groupBoxVv_GVM = new GroupBox();
            buttonMy_GVM = new Button();
            buttonSave_GVM = new Button();
            buttonDone_GVM = new Button();
            textBoxVvod_GVM = new TextBox();
            textBoxVvo_GVM = new TextBox();
            textBoxVv_GVM = new TextBox();
            textBoxV_GVM = new TextBox();
            groupBox_Res_GVM = new GroupBox();
            textBoxRes_GVM = new TextBox();
            groupBoxVv_GVM.SuspendLayout();
            groupBox_Res_GVM.SuspendLayout();
            SuspendLayout();
            // 
            // groupBoxUs_GVM
            // 
            groupBoxUs_GVM.Location = new Point(12, 12);
            groupBoxUs_GVM.Name = "groupBoxUs_GVM";
            groupBoxUs_GVM.Size = new Size(631, 112);
            groupBoxUs_GVM.TabIndex = 0;
            groupBoxUs_GVM.TabStop = false;
            groupBoxUs_GVM.Text = "Условие";
            // 
            // groupBoxVv_GVM
            // 
            groupBoxVv_GVM.Controls.Add(buttonMy_GVM);
            groupBoxVv_GVM.Controls.Add(buttonSave_GVM);
            groupBoxVv_GVM.Controls.Add(buttonDone_GVM);
            groupBoxVv_GVM.Controls.Add(textBoxVvod_GVM);
            groupBoxVv_GVM.Controls.Add(textBoxVvo_GVM);
            groupBoxVv_GVM.Controls.Add(textBoxVv_GVM);
            groupBoxVv_GVM.Controls.Add(textBoxV_GVM);
            groupBoxVv_GVM.Location = new Point(655, 12);
            groupBoxVv_GVM.Name = "groupBoxVv_GVM";
            groupBoxVv_GVM.Size = new Size(641, 112);
            groupBoxVv_GVM.TabIndex = 1;
            groupBoxVv_GVM.TabStop = false;
            groupBoxVv_GVM.Text = "Ввод данных";
            // 
            // buttonMy_GVM
            // 
            buttonMy_GVM.BackColor = Color.Blue;
            buttonMy_GVM.Location = new Point(533, 26);
            buttonMy_GVM.Name = "buttonMy_GVM";
            buttonMy_GVM.Size = new Size(100, 65);
            buttonMy_GVM.TabIndex = 6;
            buttonMy_GVM.Text = "Справка";
            buttonMy_GVM.UseVisualStyleBackColor = false;
            buttonMy_GVM.Click += buttonMy_GVM_Click;
            // 
            // buttonSave_GVM
            // 
            buttonSave_GVM.BackColor = Color.Yellow;
            buttonSave_GVM.Location = new Point(427, 26);
            buttonSave_GVM.Name = "buttonSave_GVM";
            buttonSave_GVM.Size = new Size(100, 65);
            buttonSave_GVM.TabIndex = 5;
            buttonSave_GVM.Text = "Сохранить";
            buttonSave_GVM.UseVisualStyleBackColor = false;
            buttonSave_GVM.Click += buttonSave_GVM_Click;
            // 
            // buttonDone_GVM
            // 
            buttonDone_GVM.BackColor = Color.Green;
            buttonDone_GVM.Location = new Point(321, 26);
            buttonDone_GVM.Name = "buttonDone_GVM";
            buttonDone_GVM.Size = new Size(100, 65);
            buttonDone_GVM.TabIndex = 4;
            buttonDone_GVM.Text = "Выполнить";
            buttonDone_GVM.UseVisualStyleBackColor = false;
            buttonDone_GVM.Click += buttonDone_GVM_Click;
            // 
            // textBoxVvod_GVM
            // 
            textBoxVvod_GVM.Location = new Point(153, 68);
            textBoxVvod_GVM.Name = "textBoxVvod_GVM";
            textBoxVvod_GVM.Size = new Size(141, 27);
            textBoxVvod_GVM.TabIndex = 3;
            // 
            // textBoxVvo_GVM
            // 
            textBoxVvo_GVM.Location = new Point(6, 68);
            textBoxVvo_GVM.Name = "textBoxVvo_GVM";
            textBoxVvo_GVM.Size = new Size(141, 27);
            textBoxVvo_GVM.TabIndex = 2;
            // 
            // textBoxVv_GVM
            // 
            textBoxVv_GVM.BorderStyle = BorderStyle.None;
            textBoxVv_GVM.Location = new Point(153, 26);
            textBoxVv_GVM.Name = "textBoxVv_GVM";
            textBoxVv_GVM.ReadOnly = true;
            textBoxVv_GVM.Size = new Size(141, 20);
            textBoxVv_GVM.TabIndex = 1;
            textBoxVv_GVM.Text = "Конец шага:";
            // 
            // textBoxV_GVM
            // 
            textBoxV_GVM.BorderStyle = BorderStyle.None;
            textBoxV_GVM.Location = new Point(6, 26);
            textBoxV_GVM.Name = "textBoxV_GVM";
            textBoxV_GVM.ReadOnly = true;
            textBoxV_GVM.Size = new Size(141, 20);
            textBoxV_GVM.TabIndex = 0;
            textBoxV_GVM.Text = "Старт шага:";
            // 
            // groupBox_Res_GVM
            // 
            groupBox_Res_GVM.Controls.Add(textBoxRes_GVM);
            groupBox_Res_GVM.Location = new Point(12, 130);
            groupBox_Res_GVM.Name = "groupBox_Res_GVM";
            groupBox_Res_GVM.Size = new Size(364, 401);
            groupBox_Res_GVM.TabIndex = 2;
            groupBox_Res_GVM.TabStop = false;
            groupBox_Res_GVM.Text = "Вывод:";
            // 
            // textBoxRes_GVM
            // 
            textBoxRes_GVM.Location = new Point(6, 26);
            textBoxRes_GVM.Multiline = true;
            textBoxRes_GVM.Name = "textBoxRes_GVM";
            textBoxRes_GVM.ScrollBars = ScrollBars.Both;
            textBoxRes_GVM.Size = new Size(352, 369);
            textBoxRes_GVM.TabIndex = 0;
            // 
            // FormMain
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(1308, 543);
            Controls.Add(groupBox_Res_GVM);
            Controls.Add(groupBoxVv_GVM);
            Controls.Add(groupBoxUs_GVM);
            Name = "FormMain";
            Text = "Form1";
            groupBoxVv_GVM.ResumeLayout(false);
            groupBoxVv_GVM.PerformLayout();
            groupBox_Res_GVM.ResumeLayout(false);
            groupBox_Res_GVM.PerformLayout();
            ResumeLayout(false);
        }

        #endregion

        private GroupBox groupBoxUs_GVM;
        private GroupBox groupBoxVv_GVM;
        private TextBox textBoxVvod_GVM;
        private TextBox textBoxVvo_GVM;
        private TextBox textBoxVv_GVM;
        private TextBox textBoxV_GVM;
        private Button buttonDone_GVM;
        private Button buttonMy_GVM;
        private Button buttonSave_GVM;
        private GroupBox groupBox_Res_GVM;
        private TextBox textBoxRes_GVM;
    }
}
