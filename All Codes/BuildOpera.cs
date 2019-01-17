using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace CalculatorGame
{
    class Build
    {
        public int p = 0;
        public int flag = 0;
        public int[] Expression = new int[100];
        public string strsave;
        Random rd = new Random();
        //mode=1 基础，mode=2 带分数，mode=3，带乘方。
        int RandExpLen()
        {
            return OperationGame.rd.Next(2, 11);
        }
        int RandExpNum(int maxnum)
        {
            return OperationGame.rd.Next(0, maxnum);
        }
        int RandSymbol(int mode)
        {
            int randnum = -1;
            if (mode == 1)
                randnum = OperationGame.rd.Next(0, 4) + 101;
            else if (mode == 2)
                randnum = OperationGame.rd.Next(0, 4) + 101;
            else if (mode == 3)
                randnum = OperationGame.rd.Next(0, 5) + 101;
            else if (mode == 4)
                randnum = OperationGame.rd.Next(0, 5);
            return randnum;
        }
        int PownumEasy()
        {
            return OperationGame.rd.Next(0, 3) + 1;
        }
        public void PrintExp2()
        {
            char[] save = new char[100];
            Array.Clear(save, '\0', save.Length);
            int savep = 0;
            for (int i = 0; i < p; i++)
            {
                if (Expression[i] == 101)
                    save[savep++] = '+';
                else if (Expression[i] == 102)
                    save[savep++] = '-';
                else if (Expression[i] == 103)
                    save[savep++] = '*';
                else if (Expression[i] == 104)
                    save[savep++] = '/';
                else if (Expression[i] == 105)               
                    save[savep++] = '^';
                else if (Expression[i] == 106)
                    save[savep++] = '(';
                else if (Expression[i] == 107)
                    save[savep++] = ')';
                else
                {
                    int m = Expression[i];
                    char[] aha = new char[10];
                    int flag1 = 0;
                    while (m / 10 != 0)
                    {

                        aha[flag1++] = (char)(m % 10 + 48);
                        m = m / 10;
                    }
                    aha[flag1++] = (char)(m % 10 + 48);
                    for (int j = flag1 - 1; j >= 0; j--)
                        save[savep++] = aha[j];
                }
                   // save[savep++] = (char)(Expression[i] + 48);
            }
            strsave = null;
            for (int i = 0; i < savep; i++)
            {
                strsave = strsave + save[i];
            }
            //strsave = new string(save,p);

            //strsave += "= \r\n";
        }

          public void PrintExp1()
        {
            char[] save = new char[100];
            Array.Clear(save, '\0', save.Length);
            int savep = 0;
            for (int i = 0; i < p; i++)
            {
                if (Expression[i] == 101)
                    save[savep++] = '+';
                else if (Expression[i] == 102)
                    save[savep++] = '-';
                else if (Expression[i] == 103)
                    save[savep++] = '*';
                else if (Expression[i] == 104)
                    save[savep++] = '/';
                else if (Expression[i] == 105)
                {
                    save[savep++] = '*';
                    save[savep++] = '*';
                }               
                    
                else if (Expression[i] == 106)
                    save[savep++] = '(';
                else if (Expression[i] == 107)
                    save[savep++] = ')';
                else
                {
                    int m = Expression[i];
                    char[] aha = new char[10];
                    int flag1 = 0;
                    while (m / 10 != 0)
                    {

                        aha[flag1++] = (char)(m % 10 + 48);
                        m = m / 10;
                    }
                    aha[flag1++] = (char)(m % 10 + 48);
                    for (int j = flag1 - 1; j >= 0; j--)
                        save[savep++] = aha[j];
                }
            }
            strsave = null;
            for (int i = 0; i < savep; i++)
            {
                strsave = strsave + save[i];
            }
            //strsave = new string(save,p);

            //strsave += "= \r\n";
        }

   
        //根据选择模式生成表达式
        public int[] BuildExp(int mode,int maxnum)
        {
            int lastbracket = 0;
            p = 0;
            bool HavePow = false;
            int expnum = RandExpLen();
            for (int j = 1; j <= expnum; j++)
            {
                if (j == expnum)//最后一个数字的判断
                {
                    Expression[p++] = RandExpNum(maxnum);
                    if (p > 1 && Expression[p - 2] == 105)
                        Expression[p - 1] = PownumEasy();
                    if (p > 1 && Expression[p - 2] == 104 && Expression[p - 1] == 0)//判断分母0
                        Expression[p - 1] = 1;
                    if (lastbracket != 0)//若有未匹配左括号，则最后一位强制添加右括号
                        Expression[p++] = 107;
                    break;
                }
                else
                {
                    Expression[p++] = RandExpNum(maxnum);//生成随机数
                    if (p > 1 && Expression[p - 2] == 105)
                        Expression[p - 1] = PownumEasy();
                    if (p > 1 && Expression[p - 2] == 104 && Expression[p - 1] == 0)//判断分母0
                        Expression[p - 1] = 1;
                    if (RandSymbol(4) == 1 && lastbracket > 2)//右括号
                    {
                        Expression[p++] = 107;
                        lastbracket = 0;
                    }
                    Expression[p++] = RandSymbol(mode);//生成随机符号
                                                       //检查乘方个数
                    if (Expression[p - 1] == 105 && HavePow)
                        Expression[p - 1] = RandSymbol(1);
                    else if (Expression[p - 1] == 105)
                        HavePow = true;

                    if (RandSymbol(4) == 1 && j < expnum - 1 && lastbracket == 0 && Expression[p - 1] < 104)//左括号
                    {
                        Expression[p++] = 106;
                        lastbracket = 1;
                    }
                }
                if (lastbracket != 0)
                    lastbracket++;
            }
            return Expression;
        }

        //将算式转化为后缀表达式
        public void TurnToHou()
        {
            flag = 0;

            int[] hou = new int[100];
            Stack<int> operators = new Stack<int>();
            operators.Push(-1);
           // Stack<int> operations = new Stack<int>(); ;
            for (int i = 0; i < p; i++)
            {
                if (Expression[i] >= 0 && Expression[i] <= 100)
                {
                    hou[flag++] = Expression[i];
                    //operations.Push(Expression[i]);
                }
                else if (Expression[i] == 105 || Expression[i] == 106)    //左括号与乘方必定入栈
                    operators.Push(Expression[i]);
                else if (Expression[i] == 103 || Expression[i] == 104)    //乘除会弹出乘方与乘除
                {
                    while (operators.Count != 0 && (operators.Peek() == 103 || operators.Peek() == 104 || operators.Peek() == 105))
                    {


                        //int a1 = operations.Pop();
                        //int a2 = operations.Pop();
                        int opera = operators.Pop();
                        
                       
                        //if (a1 == -1) ;
                       // else hou[flag++] = a1;
                        //if (a2 == -1) ;
                       // else hou[flag++] = a2;
                        if (opera == -1) ;
                        else hou[flag++] = opera;

                        //operations.Push(-1);
                    }
                    operators.Push(Expression[i]);
                }
                else if (Expression[i] == 101 || Expression[i] == 102)        //加减可能弹出乘除与乘方
                {
                    while (operators.Count != 0 && (operators.Peek() != 106 && operators.Peek() != 107))
                    {
                        //int a1 = operations.Pop();
                        //int a2 = operations.Pop();
                        int opera = operators.Pop();

                        //if (a1 == -1) ;
                        //else hou[flag++] = a1;
                        //if (a2 == -1) ;
                        //else hou[flag++] = a2;
                        if (opera == -1) ;
                        else hou[flag++] = opera;

                        //operations.Push(-1);
                    }
                    operators.Push(Expression[i]);
                }
                else if (Expression[i] == 107)               //右括号会一直弹出直至左括号
                {
                    while (operators.Peek() != 106)
                    {
                       // int a1 = operations.Pop();
                       // int a2 = operations.Pop();
                        int opera = operators.Pop();

                       // if (a1 == -1) ;
                       // else hou[flag++] = a1;
                        //if (a2 == -1) ;
                       // else hou[flag++] = a2;
                        if (opera == -1) ;
                        else hou[flag++] = opera;

                       // operations.Push(-1);
                    }
                    operators.Pop();
                }
            }
            while (operators.Count != 0)
            {
                //int a1 = operations.Pop();
                //int a2 = operations.Pop();
                int opera = operators.Pop();

                //if (a1 == -1) ;
                //else hou[flag++] = a1;
               // if (a2 == -1) ;
               // else hou[flag++] = a2;
                if (opera == -1) ;
                else hou[flag++] = opera;

                //operations.Push(-1);
            }
            Expression = hou;
        }
     
        //将后缀表达式转换为二叉树
        public BinaryTree createtree()
        {
            //flag 为expression的长度 
            Stack<TreeNode> nodestack = new Stack<TreeNode>();
            int opnum=0;//记录运算符数量
            for (int i=0; i<flag; i++)
            {
                TreeNode node = new TreeNode();
                int m = Expression[i];
                if (m <= 100)
                {
                    NumNode num1 = new NumNode(new MyNumber(m));
                    nodestack.Push(num1);

                }             
                else{
                    opnum++;
                    OpNode opnode = new OpNode(m);
                    TreeNode rightnode = nodestack.Pop();
                    TreeNode leftnode = nodestack.Pop();
                    opnode.left = leftnode;
                    opnode.right = rightnode;
                    nodestack.Push(opnode);
                }
              
               
            }

            BinaryTree tree = new BinaryTree(nodestack.Pop(),opnum);
            return tree;

        }
      




        //创建多个表达式,用list存储
        public List<BinaryTree> createQList(int totle, int span, int max_len)
        {
            List<BinaryTree> temp = new List<BinaryTree>();
            BinaryTree s = null;
            for (int i = 0; i < totle; i++)
            {
                int m_len = rd.Next(2, max_len + 1);
                //s = this.createQues(span, m_len);
                s.adjustTree(s.getroot());
                temp.Add(s);
            }
            return temp;
        }


        //比较树结构查重
        public int compareTree(BinaryTree tree1, BinaryTree tree2)
        {
            //1.树的运算符数量不同
            if (tree1.getnumber() != tree2.getnumber())
            {
                return 1;
            }
            //2.树的高度不同
            if (tree1.getheight() != tree2.getheight())
            {
                return 1;
            }
            //3.树的结构不同
            if (compareNode(tree1.getroot(), tree2.getroot()) == 1)
            {
                return 1;
            }
            return 0;
        }
        public int compareNode(TreeNode node1, TreeNode node2)
        {
            //比较节点的类型
            if (node1.type != node2.type)
            {
                return 1;
            }
            else
            {
                int l = 0, r = 0;
                if (node1.left != null && node2.left != null)
                {
                    l = compareNode(node1.left, node2.left);
                }
                if (node1.right != null && node2.right != null)
                {
                    r = compareNode(node1.right, node2.right);
                }

                if (l == 0 && r == 0 && node1.value.getnumerator() == node2.value.getnumerator() && node1.value.getdenominator() == node2.value.getdenominator())
                {
                    return 0;
                }

                return 1;

            }
        }
    }
}
