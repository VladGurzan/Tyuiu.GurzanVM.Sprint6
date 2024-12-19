using Tyuiu.GurzanVM.Sprint6.Task0.V24.Lib;

namespace Tyuiu.GurzanVM.Sprint6.Task0.V24
{
    public partial class FormTask_VGM : Form
    {
        public FormTask_VGM()
        {
            InitializeComponent();
        }

        private void FormTask_VGM_Load(object sender, EventArgs e)
        {

        }

        private void groupBox1_Enter(object sender, EventArgs e)
        {

        }

        private void textBox2_TextChanged(object sender, EventArgs e)
        {

        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }


        private void textVarReadX_KeyPress(object sender, KeyPressEventArgs e)
        {
            {
                if ((e.KeyChar <= 47 || e.KeyChar >= 58) && (e.KeyChar != ',') && (e.KeyChar != 8))
                {
                    e.Handled = true;
                }
            }
        }

        private void textVarRes_VGM_TextChanged(object sender, EventArgs e)
        {
            DataService ds = new DataService();
            textVarRes_VGM.Text = Convert.ToString(ds.Calculate(Convert.ToInt32(textVarReadX.Text)));
        }

        private void ButtonHelp_VGM_Click(object sender, EventArgs e)
        {
            MessageBox.Show("Таск 0 выполнил студент группы СМАРТБ-24-1 Владислав Гурзан Михайлович", "Ошибка", MessageBoxButtons.OK, MessageBoxIcon.Information);
        }

        private void ButtonDone_GVM_Click_1(object sender, EventArgs e)
        {
            DataService ds = new();
            try
            {
                textVarRes_VGM.Text = Convert.ToString(ds.Calculate(Convert.ToInt32(textVarReadX.Text)));

            }
            catch
            {
                MessageBox.Show("Введены неверные данные", "Ошибка", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }
    }
}
