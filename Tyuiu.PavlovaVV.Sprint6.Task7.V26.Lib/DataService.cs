using System.IO;
using tyuiu.cources.programming.interfaces.Sprint6;
namespace Tyuiu.PavlovaVV.Sprint6.Task7.V26.Lib
{
    public class DataService : ISprint6Task7V26
    {
        public int[,] GetMatrix(string path)
        {
            string fileData = File.ReadAllText(path);
            fileData = fileData.Replace('\n', '\r');
            string[] lines = fileData.Split(new char[] { '\r' }, StringSplitOptions.RemoveEmptyEntries);


            int rows = lines.Length;
            int columns = lines[0].Split(';').Length;
            int[,] arrayValues = new int[rows, columns];

            for (int i = 0; i < rows; i++)
            {
                string[] line_r = lines[i].Split(';');
                for (int j = 0; j < columns; j++)
                {
                    arrayValues[i, j] = Convert.ToInt32(line_r[j]);
                    if (arrayValues[i, 1] > 5)
                    {
                        arrayValues[i, 1] = 222;
                    }
                }
            }
            return arrayValues;
        }
    }
}
