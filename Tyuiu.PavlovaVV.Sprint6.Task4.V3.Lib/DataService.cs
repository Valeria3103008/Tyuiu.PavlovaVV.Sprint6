using tyuiu.cources.programming.interfaces.Sprint6;
namespace Tyuiu.PavlovaVV.Sprint6.Task4.V3.Lib
{
    public class DataService : ISprint6Task4V3
    {
        public double[] GetMassFunction(int startValue, int stopValue)
        {
            double[] valueArray;
            int len = (stopValue - startValue) + 1;
            valueArray = new double[len];
            double y;
            int cnt = 0;

            for (int x = startValue; x <= stopValue; x++)
            {
                y = ((3 * x - 1.5) / (Math.Sin(x) - 3 + x)) + 2;
                y = Math.Round(y, 2);
                valueArray[cnt] = y;
                cnt++;
            }

            return valueArray;
        }
    }
}
