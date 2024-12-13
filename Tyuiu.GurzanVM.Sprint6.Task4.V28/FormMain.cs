using Tyuiu.GurzanVM.Sprint6.Task4.V28.Lib;

namespace Tyuiu.GurzanVM.Sprint6.Task4.V28
{
    public partial class FormMain : Form
    {
        public FormMain()
        {
            InitializeComponent();
        }

        DataService ds = new DataService();

        private void buttonDone_GVM_Click(object sender, EventArgs e)
        {
            try
            {
                int startValue = Convert.ToInt32(textBoxVvo_GVM.Text);
                int stopValue = Convert.ToInt32(textBoxVvod_GVM.Text);

                int len = ds.GetMassFunction(startValue, stopValue).Length;

                double[] valueArray = new double[len];

                valueArray = ds.GetMassFunction(startValue, stopValue);


            }
            catch
            {
                MessageBox.Show("������� �������� ������", "������", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }



        }

        private void buttonMy_GVM_Click(object sender, EventArgs e)
        {
            MessageBox.Show("�������� ������� 1 ����� ������ ������ 24-1 ������ ��������� ����������", "���������", MessageBoxButtons.OK, MessageBoxIcon.Information);
        }

        private void buttonSave_GVM_Click(object sender, EventArgs e)
        {
            try
            {


                string path = Path.Combine(new string[] { "C:", "DataSprint6", "InPutDataFileTask6V28.txt" });
                File.WriteAllText(path, textBoxRes_GVM.Text);

                DialogResult dialog = MessageBox.Show("���� " + path + "�������� �������! \n ������� ��� � ��������?", "���������", MessageBoxButtons.YesNo, MessageBoxIcon.Information);

                if (dialog == DialogResult.Yes)
                {
                    System.Diagnostics.Process txt = new System.Diagnostics.Process();
                    txt.StartInfo.FileName = "notepad.exe";
                    txt.StartInfo.Arguments = path;
                    txt.Start();
                }
            }
            catch
            {
                MessageBox.Show("���� ��� ���������� �����", "������", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }
    }
}