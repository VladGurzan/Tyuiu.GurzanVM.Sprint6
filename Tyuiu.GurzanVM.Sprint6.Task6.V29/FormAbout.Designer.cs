namespace Tyuiu.GurzanVM.Sprint6.Task6.V29
{
    partial class FormAbout
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
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
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FormAbout));
            pictureBox_GVM = new PictureBox();
            textBox_GVM = new TextBox();
            buttonOk_GVM = new Button();
            ((System.ComponentModel.ISupportInitialize)pictureBox_GVM).BeginInit();
            SuspendLayout();
            // 
            // pictureBox_GVM
            // 
            pictureBox_GVM.Image = Properties.Resources._9e60b10e1362ee45faeec2d675b531c3;
            pictureBox_GVM.Location = new Point(12, 12);
            pictureBox_GVM.Name = "pictureBox_GVM";
            pictureBox_GVM.Size = new Size(228, 229);
            pictureBox_GVM.SizeMode = PictureBoxSizeMode.Zoom;
            pictureBox_GVM.TabIndex = 0;
            pictureBox_GVM.TabStop = false;
            pictureBox_GVM.UseWaitCursor = true;
            // 
            // textBox_GVM
            // 
            textBox_GVM.BorderStyle = BorderStyle.None;
            textBox_GVM.Location = new Point(246, 12);
            textBox_GVM.Multiline = true;
            textBox_GVM.Name = "textBox_GVM";
            textBox_GVM.ReadOnly = true;
            textBox_GVM.Size = new Size(324, 229);
            textBox_GVM.TabIndex = 1;
            textBox_GVM.Text = resources.GetString("textBox_GVM.Text");
            // 
            // buttonOk_GVM
            // 
            buttonOk_GVM.Location = new Point(455, 250);
            buttonOk_GVM.Name = "buttonOk_GVM";
            buttonOk_GVM.Size = new Size(115, 29);
            buttonOk_GVM.TabIndex = 2;
            buttonOk_GVM.Text = "Ok";
            buttonOk_GVM.UseVisualStyleBackColor = true;
            buttonOk_GVM.UseWaitCursor = true;
            buttonOk_GVM.Click += buttonOk_GVM_Click;
            // 
            // FormAbout
            // 
            AutoScaleMode = AutoScaleMode.None;
            ClientSize = new Size(582, 291);
            Controls.Add(buttonOk_GVM);
            Controls.Add(textBox_GVM);
            Controls.Add(pictureBox_GVM);
            FormBorderStyle = FormBorderStyle.Fixed3D;
            Name = "FormAbout";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "О программе";
            ((System.ComponentModel.ISupportInitialize)pictureBox_GVM).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private PictureBox pictureBox_GVM;
        private TextBox textBox_GVM;
        private Button buttonOk_GVM;
    }
}