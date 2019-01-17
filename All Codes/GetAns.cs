using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CalculatorGame
{
    class Ans
    {
        /*要求用户输入答案并与结果比较*/
        public int GetResult(MyNumber res,string yourans)
        {
            
            int formflag = CheckYourAnswer(yourans);        //判断答案格式是否正确
            if (formflag == 1)
            {
                //sign代表答案符号，ansnum[0]为分子，[1]为分母
                int[] ansnum = new int[] { 0, 1 };
                int sign = TurnToNumber(yourans, ansnum);
                if (ansnum[1] != 0)                         //判断分母是否为0
                {
                    MyNumber yourres = new MyNumber(ansnum[0], ansnum[1], sign);
                    if (yourres == res)
                    {
                        return 1;
                    }
                    //cout << "Right" << endl;
                    else
                    {
                        return 0;
                    }
                    //cout << "Wrong" << endl;
                }
                else
                    return 0;
            }
            else
                return 3;
        }

        /*判断答案格式*/
        int CheckYourAnswer(string yourans)
        {
            int[] flag =new int[50];
            int pos = 0;
            for (int i = 0; i<50; i++)
                flag[i] = 0;
            for (int i = 0; yourans[i] == ' '; i++)     //去除前置空格
                flag[i] = 1;
            while (pos<yourans.Length)                        //去除除号两侧空格
            {
                if (yourans[pos] == '/')
                {
                    for (int i = pos - 1; yourans[i] == ' '; i--)
                        flag[i] = 1;
                    for (int i = pos + 1; yourans[i] == ' '; i++)
                        flag[i] = 1;
                }
                pos++;
            }
            for (int i = pos - 1; i >= 0 && yourans[i] == ' '; i--)     //去除后置空格
                flag[i] = 1;
            string tempans="";
            for (int i = 0; i<yourans.Length; i++)
            {
                if (flag[i] == 0)
                    tempans =tempans + yourans[i];
            }
            yourans=tempans;
            int formflag = 1, divisioncnt = 0;

            /*判断格式，出现其余字符,或2个及以上除号，或负号位置不正确则格式错误*/
            for (int i = 0; i < yourans.Length; i++)
            {
                if (yourans[i] >= '0' && yourans[i] <= '9')
                    continue;
                else if (yourans[i] == '/' && divisioncnt < 1)
                {
                    divisioncnt++;
                    continue;
                }
                else if (yourans[i] == '-' && (i == 0 || yourans[i - 1] == '/' || yourans[i - 1] == '-'))
                    continue;
                else
                {
                    formflag = 0;
                    break;
                }
            }
            return formflag;
        }

        /*将答案字符串转为数字*/
        int TurnToNumber(string yourans, int[] ansnum)
        {
            int pos = 0, sign = 1;
            for (int i = 0; i<yourans.Length; i++)
            {
                if (yourans[i] == '-')
                    sign *= -1;
                if (yourans[i] >= '0' && yourans[i] <= '9')
                    ansnum[pos] = ansnum[pos] * 10 + yourans[i] - '0';
                else if (yourans[i] == '/')
                {
                    pos++;
                    ansnum[pos] = 0;
                }
            }
            return sign;
        }
    }
}
