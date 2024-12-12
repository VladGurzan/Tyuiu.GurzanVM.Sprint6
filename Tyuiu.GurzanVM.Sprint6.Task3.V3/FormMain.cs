using System.Drawing.Drawing2D;
using Tyuiu.GurzanVM.Sprint6.Task3.V3.Lib;

namespace Tyuiu.GurzanVM.Sprint6.Task3.V3
{
    public partial class FormMain : Form
    {
        public FormMain()
        {
            InitializeComponent();
        }

        DataService ds = new DataService();
        int[,] mtrx = new int[5, 5] { { -18, 21, 10, -2, 12 },
        { -18, -10, 33, -20, 32 },
        { 14, -15, -14, 12, -18 },
        { -19, 5, -3, 28, -17 },
        { -14, -9, 23, -13, 11 } };

        private void FormMain_Load(object sender, EventArgs e)
        {
            int rows = mtrx.GetUpperBound(0) + 1;
            int cols = mtrx.Length / rows;

            dataGridViewMatrix.ColumnCount = cols;
            dataGridViewMatrix.RowCount = rows;

            for (int i = 0; i < cols; i++)
            {
                dataGridViewMatrix.Columns[i].Width = 50;
            }

            for (int i = 0; i < rows; i++)
            {
                for (int j = 0; j < cols; j++)
                {
                    dataGridViewMatrix.Rows[i].Cells[j].Value = Convert.ToString(mtrx[i, j]);
                }
            }

        }

        private void buttonDone_GVM_Click(object sender, EventArgs e)
        {
            textBoxViv_GVM.Text = Convert.ToString(ds.Calculate(mtrx));
        }

        private void buttonMy_GVM_Click(object sender, EventArgs e)
        {
            MessageBox.Show("Таск 3 выполнил студент группы СМАРТБ 24-1 Гурззан Владислав Михайлович", "Сообщение", MessageBoxButtons.OK, MessageBoxIcon.Information);
        }
    }
}
