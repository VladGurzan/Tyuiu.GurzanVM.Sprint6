using tyuiu.cources.programming.interfaces.Sprint6;

namespace Tyuiu.GurzanVM.Sprint6.Task1.V3.Lib
{
    public class DataService : ISprint6Task1V3
    {
        public double[] GetMassFunction(int startValue, int stopValue)
        {
            int index = 0;
            double[] mass = new double[stopValue - startValue + 1];
            for (int i = startValue; i <= stopValue; i++)
            {
                mass[index] = double.Round(5 - (3 * i) + ((1 + Math.Sin(i)) / ((2 * i) - 0.5)), 2);
                index++;
            }
            return mass;
        }
    }
}
