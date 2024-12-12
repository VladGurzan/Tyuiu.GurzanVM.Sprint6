using Tyuiu.GurzanVM.Sprint6.Task1.V3.Lib;

namespace Tyuiu.GurzanVM.Sprint6.Task1.V3
{
    public partial class FormMain : Form
    {
        public FormMain()
        {
            InitializeComponent();
        }

        DataService ds = new DataService();

        private void buttonEx_GVM_Click(object sender, EventArgs e)
        {
            try
            {


                int startValue = Convert.ToInt32(textEnter1_GVM.Text);
                int stopValue = Convert.ToInt32(textEnter2_GVM.Text);

                string strLine;

                int len = ds.GetMassFunction(startValue, stopValue).Length;

                double[] array;
                array = new double[len];

                array = ds.GetMassFunction(startValue, stopValue);
                textRez_GVM.Text = "";
                textRez_GVM.AppendText("+----------+----------+" + Environment.NewLine);
                textRez_GVM.AppendText("|    X     |    f(x)  |" + Environment.NewLine);
                textRez_GVM.AppendText("+----------+----------+" + Environment.NewLine);

                for (int i = 0; i < len; i++)
                {
                    strLine = String.Format("|{0,5:d}     |  {1, 6:f2}  |", startValue, array[i]);
                    textRez_GVM.AppendText(strLine + Environment.NewLine);
                    startValue++;
                }

                textRez_GVM.AppendText("+----------+----------+" + Environment.NewLine);



            }
            catch
            {
                MessageBox.Show("Введены неверные данные", "Ошибка", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }


        }

        private void buttonSP_GVM_Click(object sender, EventArgs e)
        {
            MessageBox.Show("Таск выполнил студент первого группы СМАРТБ 24-1 Гурзан Владислав Михайлович", "Ошибка", MessageBoxButtons.OK, MessageBoxIcon.Information);
        }
    }
}
