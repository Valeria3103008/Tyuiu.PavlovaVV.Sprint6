using System.Windows.Forms;
using Tyuiu.PavlovaVV.Sprint6.Task1.V10.Lib;
namespace Tyuiu.PavlovaVV.Sprint6.Task1.V10
{
    public partial class FormMain : Form
    {
        public FormMain()
        {
            InitializeComponent();
        }
        DataService ds = new DataService(); // будет доступно всем событиям на форме
        private void buttonDone_PVV_Click(object sender, EventArgs e)
        {
            try
            {
                int startStep = Convert.ToInt32(textBoxStart_PVV.Text);
                int stopStep = Convert.ToInt32(textBoxFinish_PVV.Text);

                string strLine;

                int len = ds.GetMassFunction(startStep, stopStep).Length;

                double[] valueArray;
                valueArray = new double[len];

                valueArray = ds.GetMassFunction(startStep, stopStep);
                textBoxResult_PVV.Text = "";
                textBoxResult_PVV.AppendText("+-----------+-----------+" + Environment.NewLine);
                textBoxResult_PVV.AppendText(" |    x      |   f(x)    | " + Environment.NewLine);
                textBoxResult_PVV.AppendText("+-----------+-----------+" + Environment.NewLine);

                for (int i = 0; i <= len - 1; i++)
                {
                    strLine = String.Format(" | {0,7:d}  | {1,7 :f2}  | ", startStep, valueArray[i]);
                    textBoxResult_PVV.AppendText(strLine + Environment.NewLine);
                    startStep++;
                }

                textBoxResult_PVV.AppendText("+-----------+-----------+" + Environment.NewLine);
            }
            catch
            {
                MessageBox.Show("Введены неверные данные", "Ошибка", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }

        }

        private void buttonHelp_PVV_Click(object sender, EventArgs e)
        {
            MessageBox.Show("Task 1. V10. Выполнила студентка группы ИСТНб-25-2, Павлова Валерия  ", "Сообщение");
        }

    }
}
