using System.Linq.Expressions;
using Tyuiu.GurzanVM.Sprint6.Task2.V2.Lib;

namespace Tyuiu.GurzanVM.Sprint6.Task2.V2
{
    public partial class FormMain : Form
    {
        public FormMain()
        {
            InitializeComponent();
        }

        DataService ds = new DataService();
        
        private void buttonDone_GVM_MouseEnter(object sender, EventArgs e)
        {
            buttonDone_GVM.BackColor = Color.Red;
        }

        private void buttonDone_GVM_MouseLeave(object sender, EventArgs e)
        {
            buttonDone_GVM.BackColor = Color.Green;
        }

        private void buttonDone_GVM_MouseDown(object sender, MouseEventArgs e)
        {
            buttonDone_GVM.BackColor = Color.Blue;
        }

        private void buttonDone_GVM_Click(object sender, EventArgs e)
        {
            try
            {
                int startStep = Convert.ToInt32(textBoxSt2_GVM.Text);
                int stopStep = Convert.ToInt32(textBoxKo2_GVM.Text);

                int len = ds.GetMassFunction(startStep, stopStep).Length;
                double[] array;
                array = new double[len];

                array = ds.GetMassFunction(startStep, stopStep);

                this.chartRes_GVM.Titles.Add("График функции Sin(x)");
                this.chartRes_GVM.ChartAreas[0].AxisX.Title = "Ось X";
                this.chartRes_GVM.ChartAreas[0].AxisY.Title = "Ось Y";

                for (int i = 0; i <= len; i++)
                {
                    this.dataGridView_GVM.Rows.Add(Convert.ToString(startStep), Convert.ToString(array[i]));
                    this.chartRes_GVM.Series[0].Points.AddXY(startStep, array[i]);
                    startStep++;
                }


            }
            catch
            {
                MessageBox.Show("Введены неверные данные", "Ошибка", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }
    }
}
