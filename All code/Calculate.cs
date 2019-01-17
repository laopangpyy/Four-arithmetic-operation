using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CalculatorGame
{
    class Calculate
    {
        public MyNumber OneStepCalculate(MyNumber num1, MyNumber num2, int opera)
        {
            if (opera == 101)
                return num1 + num2;
            else if (opera == 102)
                return num1 - num2;
            else if (opera == 103)
                return num1 * num2;
            else if (opera == 104)
                return num1 / num2;
            else if (opera == 105)
                return num1 ^ num2;
            else
            {
                MyNumber error = new MyNumber(-1);
                return error;
            }
        }
      
    }
}
