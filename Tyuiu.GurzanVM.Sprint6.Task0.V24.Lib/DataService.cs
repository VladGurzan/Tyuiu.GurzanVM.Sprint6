using tyuiu.cources.programming.interfaces.Sprint6;

namespace Tyuiu.GurzanVM.Sprint6.Task0.V24.Lib
{
    public class DataService : ISprint6Task0V24
    {
        public double Calculate(int x)
        {
            double res = Math.Pow(x - 1, 3 * x + 1);
            res = Math.Round(res, 3);
            return res;
        }
    }
}
