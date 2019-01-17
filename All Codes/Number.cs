using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.IO;

namespace CalculatorGame
{
    internal class MyNumber
    {
        private int numerator;      //分子
        private int denominator;    //分母
        private int myGcd;          //公约数

        private int mySign;         //符号
        private int flag;           //防止化简进行多次，设置化简标志
        private float value;

        public MyNumber(int numerator, int denominator)
        {
            this.numerator = numerator;
            this.denominator = denominator;
            this.value = (float)numerator / (float)denominator;
        }
        public int getnumerator()
        {
            return this.numerator;
        }
        public int getdenominator()
        {
            return this.denominator;
        }
        public float getvalue()
        {
            return this.value;
        }

        private void Gcd(int x, int y)
        {
            if (y == 0)
                myGcd = x;
            else
                Gcd(y, x % y);
        }

        public void Reduction()    //化简
        {
            if (numerator != 0)     //分子不为0
            {
                mySign = mySign * (numerator / System.Math.Abs(numerator)) * (denominator / System.Math.Abs(denominator));
                numerator = System.Math.Abs(numerator);
                denominator = System.Math.Abs(denominator);
                Gcd(numerator, denominator);
            }
            else                   //分子为0
            {
                denominator = 1;
                myGcd = 1;
                mySign = 1;
            }
            flag = 1;
        }

        public static MyNumber operator +(MyNumber a, MyNumber b)
        {
            MyNumber c = new MyNumber();
            c.numerator = a.numerator * b.denominator + a.denominator * b.numerator;
            c.denominator = a.denominator * b.denominator;
            return c;
        }
        public static MyNumber operator -(MyNumber a, MyNumber b)
        {
            MyNumber c = new MyNumber
            {
                numerator = a.numerator * b.denominator - a.denominator * b.numerator,
                denominator = a.denominator * b.denominator
            };
            return c;
        }
        public static MyNumber operator *(MyNumber a, MyNumber b)
        {
            MyNumber c = new MyNumber
            {
                numerator = a.numerator * b.numerator,
                denominator = a.denominator * b.denominator
            };
            return c;
        }
        public static MyNumber operator /(MyNumber a, MyNumber b)
        {
            MyNumber c = new MyNumber
            {
                numerator = a.numerator * b.denominator,
                denominator = a.denominator * b.numerator
            };
            return c;
        }
        public static MyNumber operator ^(MyNumber a, MyNumber b)
        {
            MyNumber c = new MyNumber(1);
            for (int i = 0; i < b.numerator; i++)
                c = c * a;
            return c;
        }
        public static bool operator ==(MyNumber a, MyNumber b)
        {
            if (a.flag == 0)
                a.Reduction();
            if (b.flag == 0)
                b.Reduction();
            if (a.mySign != b.mySign)
                return false;
            else if (a.numerator / a.myGcd != b.numerator / b.myGcd || a.denominator / a.myGcd != b.denominator / b.myGcd)
                return false;
            else
                return true;
        }
        public static bool operator !=(MyNumber a, MyNumber b)
        {
            if (a.flag == 0)
                a.Reduction();
            if (b.flag == 0)
                b.Reduction();
            if (a.mySign != b.mySign)
                return true;
            else if (a.numerator / a.myGcd == b.numerator / b.myGcd && a.denominator / a.myGcd == b.denominator / b.myGcd)
                return true;
            else
                return false;
        }

        public MyNumber()
        {
            numerator = 0;
            denominator = 1;
            mySign = 1;
            flag = 0;
        }
        public MyNumber(int x)
        {
            numerator = x;
            denominator = 1;
            mySign = 1;
            flag = 0;
        }
        public MyNumber(int x, int y, int sign)
        {
            numerator = x;
            denominator = y;
            mySign = sign;
            flag = 0;
        }

        public void Print()
        {
            if (flag == 0)
                Reduction();
            if (mySign < 0)
                Console.Write("-");
            Console.Write("{0}", numerator / myGcd);
            if (denominator / myGcd != 1)
                Console.Write("/{0}", denominator / myGcd);
            // cout << "/" << denominator / mygcd;
            Console.Write("\n");
            //cout << endl;
        }
        public void Print(String formula, FileStream fileStream)
        {
            if (flag == 0)
                Reduction();
            byte[] Byte0 = System.Text.Encoding.UTF8.GetBytes(formula + "=");
            fileStream.Write(Byte0, 0, Byte0.Length);
            if (mySign < 0)
            {
                byte[] Byte1 = System.Text.Encoding.UTF8.GetBytes("-");
                fileStream.Write(Byte1, 0, Byte1.Length);
            }
            byte[] Byte2 = System.Text.Encoding.UTF8.GetBytes((numerator / myGcd).ToString());
            fileStream.Write(Byte2, 0, Byte2.Length);
            if (denominator / myGcd != 1)
            {
                byte[] Byte3 = System.Text.Encoding.UTF8.GetBytes("/" + (denominator / myGcd).ToString());
                fileStream.Write(Byte3, 0, Byte3.Length);
            }
            byte[] Byte4 = System.Text.Encoding.UTF8.GetBytes("\r\n");
            fileStream.Write(Byte4, 0, Byte4.Length);
        }

        public string M_ToString()
        {
            string res = "";
            if (mySign == -1)
                res += "-";
            res = res + (numerator / myGcd).ToString();
            if (denominator / myGcd != 1)
            {
                res = res + "/";
                res = res + (denominator / myGcd).ToString();
            }
            return res;
        }
    }
}
