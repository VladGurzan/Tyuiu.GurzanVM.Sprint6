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

        string path = Path.Combine(new string[] { "C:", "DataSprint6", "InPutDataFileTask5V19.txt" });


        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void buttonDone_GVM_Click(object sender, EventArgs e)
        {
            dataGridView_GVM.ColumnCount = 2;
            dataGridView_GVM.Columns[0].Width = 40;
            dataGridView_GVM.Columns[1].Width = 70;

            this.chartRes_GVM.ChartAreas[0].AxisX.Title = "Ось X";
            this.chartRes_GVM.ChartAreas[0].AxisY.Title = "Ось Y";

            chartRes_GVM.Series[0].Points.Clear();

            double[] mass = new double[ds.len];
            mass = ds.LoadFromDataFile(path);

            for (int i = 0; i < mass.Length; i++)
            {
                dataGridView_GVM.Rows.Add(Convert.ToString(i), Convert.ToString(mass[i]));
                chartRes_GVM.Series[0].Points.AddXY(i, mass[i]);
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
            MessageBox.Show("Таск выполнил студент 1 курса группы СМАРТБ 24-1 Гурзан Владислав Михайлович", "Сообщение", MessageBoxButtons.OK, MessageBoxIcon.Information);
        }
    }
}
