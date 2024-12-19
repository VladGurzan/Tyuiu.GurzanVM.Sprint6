using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Tyuiu.GurzanVM.Sprint6.Task7.V4.Lib;

namespace Tyuiu.GurzanVM.Sprint6.Task7.V4
{
    public partial class FormMain : Form
    {
        public FormMain()
        {
            InitializeComponent();

            openFileDialogTask.Filter = "Значения, разделенные запятыми(*.cvs)|*.cvs|Все файлы(*.*)|*.*";
            saveFileDialogMatrix.Filter = "Значения, разделенные запятыми(*.cvs)|*.cvs|Все файлы(*.*)|*.*";
        }

        static int rows;
        static int cols;
        static string openFilePath;

        DataService ds = new DataService();

        public static int[,] LoadFromFileData(string filePath)
        {
            string fileData = File.ReadAllText(filePath);
            fileData = fileData.Replace('\n', '\r');
            string[] lines = fileData.Split(new char[] { '\r' }, StringSplitOptions.RemoveEmptyEntries);
            rows = lines.Length;
            cols = lines[0].Split(';').Length;
            int[,] array = new int[rows, cols];
            for (int i = 0; i < rows; i++)
            {
                string[] line_r = lines[i].Split(';');
                for (int j = 0; j < cols; j++)
                {
                    array[i, j] = Convert.ToInt32(line_r[j]);
                }
            }
            return array;
        }
        private void buttonFile_GVM_Click(object sender, EventArgs e)
        {
            openFileDialogTask.ShowDialog();
            openFilePath = openFileDialogTask.FileName;

            int[,] array = new int[rows, cols];
            array = LoadFromFileData(openFilePath);

            dataGridViewEnter_GVM.ColumnCount = cols;
            dataGridViewEnter_GVM.RowCount = rows;
            dataGridViewNotEnter_GVM.ColumnCount = cols;
            dataGridViewNotEnter_GVM.RowCount = rows;

            for (int i = 0; i < cols; i++)
            {
                dataGridViewEnter_GVM.Columns[i].Width = 25;
                dataGridViewNotEnter_GVM.Columns[i].Width = 25;
            }

            for (int r = 0; r < rows; r++)
            {
                for (int c = 0; c < cols; c++)
                {
                    dataGridViewEnter_GVM.Rows[r].Cells[c].Value = array[r, c];
                }
            }

            array = ds.GetMatrix(openFilePath);
            buttonDone_GVM.Enabled = true;
        }


        private void FormMain_Load(object sender, EventArgs e)
        {
            dataGridViewEnter_GVM.ColumnCount = 50;
            dataGridViewNotEnter_GVM.ColumnCount = 50;
            dataGridViewEnter_GVM.RowCount = 25;
            dataGridViewNotEnter_GVM.RowCount = 25;

            for (int i = 0; i < 50; i++)
            {
                dataGridViewEnter_GVM.Columns[i].Width = 25;
                dataGridViewNotEnter_GVM.Columns[i].Width = 25;
            }
        }

        private void buttonDone_GVM_Click(object sender, EventArgs e)
        {
            int[,] array = new int[rows, cols];
            array = ds.GetMatrix(openFilePath);

            for (int r = 0; r < rows; r++)
            {
                for (int c = 0; c < cols; c++)
                {
                    dataGridViewNotEnter_GVM.Rows[r].Cells[c].Value = array[r, c];
                }
            }
            buttonFile_GVM.Enabled = true;
        }

        private void buttonSave_GVM_Click(object sender, EventArgs e)
        {
            saveFileDialogMatrix.FileName = "OutInFileDataTask7.cvs";
            saveFileDialogMatrix.InitialDirectory = Directory.GetCurrentDirectory();
            saveFileDialogMatrix.ShowDialog();

            string path = saveFileDialogMatrix.FileName;

            FileInfo fileinfo = new FileInfo(path);
            bool fileExists = fileinfo.Exists;
            if (fileExists)
            {
                File.Delete(path);
            }

            int rows = dataGridViewNotEnter_GVM.RowCount;
            int cols = dataGridViewNotEnter_GVM.ColumnCount;

            string str = "";

            for (int r = 0; r < rows; r++)
            {
                for (int c = 0; c < cols; c++)
                {
                    if (r != cols - 1)
                    {
                        str = str + dataGridViewNotEnter_GVM.Rows[r].Cells[c].Value + ";";
                    }
                    else
                    {
                        str = str + dataGridViewNotEnter_GVM.Rows[r].Cells[c].Value;

                    }

                }
                File.AppendAllText(path, str + Environment.NewLine);
                str = "";


            }



        }

        private void buttonFile_GVM_MouseEnter(object sender, EventArgs e)
        {
            toolTipButton.ToolTipTitle = "Открыть файл";
        }

        private void buttonDone_GVM_MouseEnter(object sender, EventArgs e)
        {
            toolTipButton.ToolTipTitle = "Выполнить";

        }

        private void buttonSave_GVM_MouseEnter(object sender, EventArgs e)
        {
            toolTipButton.ToolTipTitle = "Сохранить файл";

        }
    }






































}
