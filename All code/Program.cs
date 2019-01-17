using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.IO;
using System.Windows.Forms;
/// <summary>
/// mode=1 基础，mode=2 带分数，mode=3，带乘方。
/// 何神的bug没有改
/// </summary>
namespace CalculatorGame
{
    static class Program
    {
        static void Main()
        {
            Application.Run(new OperationGame());
        }
    }
}
