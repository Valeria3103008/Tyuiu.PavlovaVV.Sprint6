using Tyuiu.PavlovaVV.Sprint6.Task1.V10.Lib;
namespace Tyuiu.PavlovaVV.Sprint6.Task1.V10.Test
{
    [TestClass]
    public sealed class DataServiceTest
    {
        [TestMethod]
        public void ValidGetMassFunction()
        {
            DataService ds = new DataService();

            int startValue = -5;
            int stopValue = 5;

            int len = stopValue - startValue + 1;

            double[] valueWaitArray;
            valueWaitArray = new double[len];

            valueWaitArray[0] = 6.49;
            valueWaitArray[1] = -9.88;
            valueWaitArray[2] = -12.26;
            valueWaitArray[3] = -4.60;
            valueWaitArray[4] = 0.52;
            valueWaitArray[5] = 4.00;
            valueWaitArray[6] = -0.75;
            valueWaitArray[7] = 4.55;
            valueWaitArray[8] = 12.23;
            valueWaitArray[9] = 9.86;
            valueWaitArray[10] = -6.50;

            double[] res;
            res = new double[len];
            res = ds.GetMassFunction(startValue, stopValue);
            CollectionAssert.AreEqual(valueWaitArray, res);
        }
    }
}
