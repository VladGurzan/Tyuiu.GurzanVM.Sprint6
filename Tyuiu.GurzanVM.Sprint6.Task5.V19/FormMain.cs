using Tyuiu.GurzanVM.Sprint6.Task5.V19.Lib;

namespace Tyuiu.GurzanVM.Sprint6.Task5.V19
{
    public partial class FormMain : Form
    {
        public FormMain()
        {
            InitializeComponent();
        }

        DataService ds = new DataService();

        string path = Path.Combine(new string[] { "C:", "DataSprint6", "InPutDataFileTask6V28.txt" });


        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void buttonDone_GVM_Click(object sender, EventArgs e)
        {
            double[] mass = new double[ds.len];
            mass = ds.LoadFromDataFile(path);

            for (int i = 0; i < mass.Length; i++)
            {

            }
        }

        private void buttonOpen_GVM_Click(object sender, EventArgs e)
        {
            System.Diagnostics.Process txt = new System.Diagnostics.Process();
            txt.StartInfo.FileName = "notepad.exe";
            txt.StartInfo.Arguments = path;
            txt.Start();
        }

        private void buttonMy_GVM_Click(object sender, EventArgs e)
        {
            MessageBox.Show("���� �������� ������� 1 ����� ������ ������ 24-1 ������ ��������� ����������", "���������", MessageBoxButtons.OK, MessageBoxIcon.Information);
        }
    }
}
