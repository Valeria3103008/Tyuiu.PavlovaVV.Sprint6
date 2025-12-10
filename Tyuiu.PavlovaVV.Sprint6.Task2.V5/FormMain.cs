using System.Windows.Forms;
using Tyuiu.PavlovaVV.Sprint6.Task2.V5.Lib;
namespace Tyuiu.PavlovaVV.Sprint6.Task2.V5
{
    public partial class FormMain : Form
    {
        DataService ds = new DataService();
        public FormMain_PVV()
        {
            InitializeComponent();
        }

        private void buttonDone_PVV_Click(object sender, EventArgs e)
        {
            try
            {
                int start = Convert.ToInt32(textBoxStart_PVV.Text);
                int stop = Convert.ToInt32(textBoxStop_PVV.Text);
                int len = ds.GetMassFunction(start, stop).Length;
                double[] valueA = new double[len];
                valueA = ds.GetMassFunction(start, stop);
                this.chartResult_PVV.Titles.Add("График функции (2х-3/Cos(x)-2x)+5x-6");
                this.chartResult_PVV.ChartAreas[0].AxisX.Title = "Ось Х";
                this.chartResult_PVV.ChartAreas[0].AxisY.Title = "Ось Y";
                for (int i = 0; i <= len - 1; i++)
                {
                    this.dataGridViewXY_PVV.Rows.Add(Convert.ToString(start), Convert.ToString(valueA[i]));
                    this.chartResult_PVV.Series[0].Points.AddXY(start, valueA[i]);
                    start++;
                }
            }
            catch
            {
                MessageBox.Show("Введены неверные данные", "Ошибка", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }

        }

        private void buttonHelp_PVV_Click(object sender, EventArgs e)
        {
            MessageBox.Show("Таск 2 выполнила студентка группы ИСТНб-25-1 Павлова ", "Сообщение", MessageBoxButtons.OK, MessageBoxIcon.Information);
        }

        private void textBoxStart_PVV_TextChanged(object sender, EventArgs e)
        {

        }

        private void textBoxStart_PVV_KeyPress(object sender, KeyPressEventArgs e)
        {
            if ((e.KeyChar <= 47 || e.KeyChar >= 58) && (e.KeyChar != ',') && (e.KeyChar != 8))
            {
                e.Handled = true;
            }
        }

        private void buttonDone_LMV_MouseEnter(object sender, EventArgs e)
        {
            buttonDone_PVV.BackColor = Color.Red;
        }

        private void buttonDone_LMV_MouseLeave(object sender, EventArgs e)
        {
            buttonDone_PVV.BackColor = Color.Green;
        }

        private void buttonDone_LMV_MouseDown(object sender, MouseEventArgs e)
        {
            buttonDone_PVV.BackColor = Color.Blue;
        }
    }
}
