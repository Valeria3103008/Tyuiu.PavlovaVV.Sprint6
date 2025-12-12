using System.IO;
using System.Windows.Forms;
using Tyuiu.PavlovaVV.Sprint6.Task7.V26.Lib;
namespace Tyuiu.PavlovaVV.Sprint6.Task7.V26
{
    public partial class FormMain : Form
    {
        public FormMain()
        {
            InitializeComponent();

            openFileDialogTask_PVV.Filter = "Çíà÷åíèÿ, ðàçäåëåííûå çàïÿòûìè(* .csv)|*.csv|Âñå ôàëû(*.*)|*.*";
            saveFileDialogMatrix_PVV.Filter = "Çíà÷åíèÿ, ðàçäåëåííûå çàïÿòûìè(* .csv)|*.csv|Âñå ôàëû(*.*)|*.*";
        }
        static string openFilePath;
        static int rows;
        static int colums;
        public static int[,] LoadFromFileData(string filePath)
        {
            string fileData = File.ReadAllText(filePath);

            fileData = fileData.Replace('\n', '\r');
            string[] lines = fileData.Split(new char[] { '\r' }, StringSplitOptions.RemoveEmptyEntries);

            rows = lines.Length;
            colums = lines[0].Split(';').Length;
            int[,] arrayValues = new int[rows, colums];

            for (int i = 0; i < rows; i++)
            {
                string[] line_r = lines[i].Split(';');
                for (int j = 0; j < colums; j++)
                {
                    arrayValues[i, j] = Convert.ToInt32(line_r[j]);
                }
            }
            return arrayValues;
        }


        DataService ds = new DataService();
        private void buttonOpenFile_PVV_Click(object sender, EventArgs e)
        {
            openFileDialogTask_PVV.ShowDialog();
            openFilePath = openFileDialogTask_PVV.FileName;

            int[,] arrayValues = LoadFromFileData(openFilePath);

            dataGridViewInPut_PVV.ColumnCount = colums;
            dataGridViewInPut_PVV.RowCount = rows;
            dataGridViewOutPut_PVV.ColumnCount = colums;
            dataGridViewOutPut_PVV.RowCount = rows;

            for (int i = 0; i < colums; i++)
            {
                dataGridViewInPut_PVV.Columns[i].Width = 100;
                dataGridViewOutPut_PVV.Columns[i].Width = 100;
            }

            for (int r = 0; r < rows; r++)
            {
                for (int c = 0; c < colums; c++)
                {
                    dataGridViewInPut_PVV.Rows[r].Cells[c].Value = arrayValues[r, c];
                }
            }

            arrayValues = ds.GetMatrix(openFilePath);
            buttonDone_PVV.Enabled = true;
        }

        private void buttonDone_PVV_Click(object sender, EventArgs e)
        {
            int[,] arrayValues = new int[rows, colums];
            arrayValues = ds.GetMatrix(openFilePath);

            for (int r = 0; r < rows; r++)
            {
                for (int c = 0; c < colums; c++)
                {
                    dataGridViewOutPut_PVV.Rows[r].Cells[c].Value = arrayValues[r, c];
                }
            }
            buttonSaveFile_PVV.Enabled = true;
        }

        private void buttonHelp_PVV_Click(object sender, EventArgs e)
        {
            FormAbout formAbout = new FormAbout();
            formAbout.ShowDialog();
        }

        private void buttonSaveFile_PVV_Click(object sender, EventArgs e)
        {
            saveFileDialogMatrix_PVV.FileName = "OutPutFileTask7.csv";
            saveFileDialogMatrix_PVV.InitialDirectory = Directory.GetCurrentDirectory();
            saveFileDialogMatrix_PVV.ShowDialog();

            string path = saveFileDialogMatrix_PVV.FileName;

            FileInfo fileInfo = new FileInfo(path);
            bool fileExists = fileInfo.Exists;
            if (fileExists)
            {
                File.Delete(path);
            }

            int rows = dataGridViewOutPut_PVV.RowCount;
            int columns = dataGridViewOutPut_PVV.ColumnCount;

            string str = "";
            for (int i = 0; i < rows; i++)
            {
                for (int j = 0; j < columns; j++)
                {
                    if (j != columns - 1)
                    {
                        str = str + dataGridViewOutPut_PVV.Rows[i].Cells[j].Value + ";";
                    }
                    else
                    {
                        str = str + dataGridViewOutPut_PVV.Rows[i].Cells[j].Value;
                    }
                }
                File.AppendAllText(path, str + Environment.NewLine);
                str = "";
            }
        }

        private void buttonOpenFile_PVV_MouseEnter(object sender, EventArgs e)
        {
            toolTipButton_PVV.ToolTipTitle = "Открыть";
        }

        private void buttonDone_PVV_MouseEnter(object sender, EventArgs e)
        {
            toolTipButton_PVV.ToolTipTitle = "Сделать";
        }

        private void buttonSaveFile_PVV_MouseEnter(object sender, EventArgs e)
        {

            toolTipButton_PVV.ToolTipTitle = "Сохранить";
        }

        private void buttonHelp_PVV_MouseEnter(object sender, EventArgs e)
        {
            toolTipButton_PVV.ToolTipTitle = "Помощь";
        }

        private void FormMain_Load(object sender, EventArgs e)
        {
            dataGridViewInPut_PVV.ColumnCount = 100;
            dataGridViewOutPut_PVV.ColumnCount = 100;

            dataGridViewInPut_PVV.RowCount = 100;
            dataGridViewOutPut_PVV.RowCount = 100;

            for (int i = 0; i < 50; i++)
            {
                dataGridViewInPut_PVV.Columns[i].Width = 50;
                dataGridViewOutPut_PVV.Columns[i].Width = 50;
            }
        }

        private void groupBoxTask_PVV_Enter(object sender, EventArgs e)
        {

        }

        private void ButtonOpenFile_PVV_Click(object sender, EventArgs e)
        {
            openFileDialogTask_PVV.ShowDialog();
            openFilePath = openFileDialogTask_PVV.FileName;

            int[,] arrayValues = LoadFromFileData(openFilePath);

            dataGridViewInPut_PVV.ColumnCount = colums;
            dataGridViewInPut_PVV.RowCount = rows;
            dataGridViewOutPut_PVV.ColumnCount = colums;
            dataGridViewOutPut_PVV.RowCount = rows;

            for (int i = 0; i < colums; i++)
            {
                dataGridViewInPut_PVV.Columns[i].Width = 100;
                dataGridViewOutPut_PVV.Columns[i].Width = 100;
            }

            for (int r = 0; r < rows; r++)
            {
                for (int c = 0; c < colums; c++)
                {
                    dataGridViewInPut_PVV.Rows[r].Cells[c].Value = arrayValues[r, c];
                }
            }

            arrayValues = ds.GetMatrix(openFilePath);
            buttonDone_PVV.Enabled = true;
        }
    }
}

