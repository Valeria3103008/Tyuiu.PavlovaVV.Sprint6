using tyuiu.cources.programming.interfaces.Sprint6;

namespace Tyuiu.PavlovaVV.Sprint6.Task1.V10.Lib
{
    public class DataService : ISprint6Task1V10
    {
        public double[] GetMassFunction(int startValue, int stopValue)
        {
            double[] valueArray; // объявляется пустой массив 
            int len = (stopValue - startValue) + 1; //вычисляем длинну массива
            valueArray = new double[len];//создаем массив с указанной длинной 
            double y;
            int count = 0;
            for (int x = startValue; x <= stopValue; x++)
            {
                y = Math.Round((Math.Sin(x)) + (2 / ((3 * x) + 0.5)) - (2 * Math.Cos(x)) * (2 * x), 2);// округлили до 2 знаков
                valueArray[count] = y;
                count++;
            }
            return valueArray;
        }
    }
}
