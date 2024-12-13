using Tyuiu.GurzanVM.Sprint6.Task6.V29.Lib;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.IO;

namespace Tyuiu.GurzanVM.Sprint6.Task6.V29
{
    public partial class FormMain : Form
    {


        DataService ds = new DataService();
        string path;
        public FormMain()
        {
            InitializeComponent();
        }

        private void buttonOpen_GVM_Click(object sender, EventArgs e)
        {
            openFileDialogTask_GVM.ShowDialog();
            path = openFileDialogTask_GVM.FileName;
            textBoxV_GVM.Text = File.ReadAllText(path);
            groupBoxV_GVM.Text = groupBoxV_GVM.Text + " " + path;
            buttonDone_GVM.Enabled = true;
        }

        private void buttonDone_GVM_Click(object sender, EventArgs e)
        {
            textBoxRes_GVM.Text = ds.CollectTextFromFile(path);
        }

        private void buttonSp_GVM_Click(object sender, EventArgs e)
        {
            FormAbout formAbout = new FormAbout();
            formAbout.ShowDialog();
        }

        private void FormMain_Load(object sender, EventArgs e)
        {

        }
    }
}
