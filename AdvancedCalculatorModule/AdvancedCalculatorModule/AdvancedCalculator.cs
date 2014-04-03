using StringCalc.Lib;

namespace AdvancedCalculatorModule
{
    public class AdvancedCalculator
    {
        public int SuperAdd(string input)
        {
            StringCalculator sc = new StringCalculator();

            return sc.Add(input) + 1;
        }
    }
}
