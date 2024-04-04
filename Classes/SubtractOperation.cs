using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SimpleCalculatorApp
{
    public class SubtractOperation: MathOperation
    {
        public override double Calculate(double firstoperand, double lastoperand)
        {
            double result_Sub = firstoperand - lastoperand;
            return result_Sub;
        }
    }
}
