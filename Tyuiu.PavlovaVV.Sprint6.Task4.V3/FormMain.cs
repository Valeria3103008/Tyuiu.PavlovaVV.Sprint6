using Tyuiu.PavlovaVV.Sprint6.Task4.V3.Lib;
namespace Tyuiu.PavlovaVV.Sprint6.Task4.V3
{
    public partial class FormMain : Form
    {
        public FormMain()
        {
            InitializeComponent();
        }
        DataService ds = new DataService();
        private void buttonDone_NVA_Click(object sender, EventArgs e)
        {
            try
            {
                int startstep = Convert.ToInt32(textBoxStart_PVV.Text);
                int stopstep = Convert.ToInt32(textBoxEnd_PVV.Text);

                string strline;

                int len = ds.GetMassFunction(startstep, stopstep).Length;

                double[] valueArray;
                valueArray = new double[len];

                valueArray = ds.GetMassFunction(startstep, stopstep);
                this.chartFunction_PVV.ChartAreas[0].AxisX.Title = "Îñü Õ";
                this.chartFunction_PVV.ChartAreas[0].AxisY.Title = "Îñü Y";

                textBoxRes_PVV.Text = "";
                chartFunction_PVV.Series[0].Points.Clear();

                for (int i = 0; i < len - 1; i++)
                {
                    this.chartFunction_PVV.Series[0].Points.AddXY(startstep, valueArray[i]);
                    textBoxRes_PVV.AppendText(valueArray[i] + Environment.NewLine);
                    startstep++;
                }

            }
            catch
            {
                MessageBox.Show("Ââåäåíû íåâåðíûå äàííûå", "Îøèáêà", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }

        }
        private void buttonHelp_NVA_Click(object sender, EventArgs e)
        {
            MessageBox.Show("", "", MessageBoxButtons.OK, MessageBoxIcon.Information);
        }
        private void buttonSave_NVA_Click(object sender, EventArgs e)
        {
            try
            {
                string path = $@"{Directory.GetCurrentDirectory()}\OutPutFileTask4V3.txt";
                File.WriteAllText(path, textBoxRes_PVV.Text);

                DialogResult dialogres = MessageBox.Show("Ôàéë " + path + " ñîõðàíåí óñïåøíî!\n Îòêðûòü åãî â áëîêíîòå?", "Ñîîáùåíèå", MessageBoxButtons.YesNo, MessageBoxIcon.Information);

                if (dialogres == DialogResult.Yes)
                {
                    System.Diagnostics.Process txt = new System.Diagnostics.Process();
                    txt.StartInfo.FileName = "notepad.exe";
                    txt.StartInfo.Arguments = path;
                    txt.Start();
                }
            }
            catch
            {
                MessageBox.Show("Ñáîé ïðè ñîõðàíåíèè ôàéëà", "Îøèáêà", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }
}
