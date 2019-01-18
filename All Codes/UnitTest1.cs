using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using Microsoft.VisualStudio.TestTools.UnitTesting;
using CalculatorGame;
namespace CalculatorTest1
{
    [TestClass]
    public class UnitTest1
    {
        [TestMethod]
        public void TestMethod1()
        {//测试加减乘除的计算正确性
            Build build = new Build();
            build.Expr[0] = 1;
            build.Expr[1] = 101;
            build.Expr[2] = 7;
            build.Expr[3] = 102;
            build.Expr[4] = 6;
            build.Expr[5] = 103;
            build.Expr[6] = 3;
            build.Expr[7] = 104;
            build.Expr[8] = 2;
 
            build.flag = 9;
            build.p = 9;
            //表达式是1+7-6*3/2
            build.TurnToHou();           
            BinaryTree tree;
            tree = build.createtree();//将后缀表达式转换为二叉树
            tree.preordercalc(tree.getroot());//计算最终的结果并存在根节点
            Ans ans = new Ans();
            tree.getroot().value.Reduction();
         
            MyNumber correctAnswer = tree.getroot().value;//这里保存了计算出来的答案
            int ansflag = ans.GetResult(correctAnswer, "-1");
            Assert.AreEqual(1, ansflag);
        }

        [TestMethod]
        public void TestMethod2()
        {//测试括号和乘方的计算正确性
            Build build = new Build();
            build.Expr[0] = 1;
            build.Expr[1] = 101;

            build.Expr[2] = 106;
            build.Expr[3] = 7;
            build.Expr[4] = 102;
            build.Expr[5] = 6;
            build.Expr[6] = 107;

            build.Expr[7] = 105;
            build.Expr[8] = 3;
            build.Expr[9] = 104;
            build.Expr[10] = 2;
           
            build.flag = 11;
            build.p = 11;
            //表达式是1+(7-6)^3/2
            build.TurnToHou();

            BinaryTree tree;
            tree = build.createtree();//将后缀表达式转换为二叉树
            tree.preordercalc(tree.getroot());//计算最终的结果并存在根节点
            Ans ans = new Ans();
            tree.getroot().value.Reduction();

            MyNumber correctAnswer = tree.getroot().value;//这里保存了计算出来的答案
            int ansflag = ans.GetResult(correctAnswer, "3/2");
            Assert.AreEqual(1, ansflag);
        }

        [TestMethod]
        public void TestMethod3()
        {//测试输入答案的格式不正确的识别情况
            Build build = new Build();
            build.Expr[0] = 1;
            build.Expr[1] = 101;
            build.Expr[2] = 7;
            build.Expr[3] = 102;
            build.Expr[4] = 6;
            build.Expr[5] = 103;
            build.Expr[6] = 3;
            build.Expr[7] = 104;
            build.Expr[8] = 2;
          
            build.flag = 9;
            build.p = 9;
            //表达式是1+7-6*3/2
            build.TurnToHou();
            BinaryTree tree;
            tree = build.createtree();//将后缀表达式转换为二叉树
            tree.preordercalc(tree.getroot());//计算最终的结果并存在根节点
            Ans ans = new Ans();
            tree.getroot().value.Reduction();

            MyNumber correctAnswer = tree.getroot().value;//这里保存了计算出来的答案
            int ansflag = ans.GetResult(correctAnswer, "-1’");
            Assert.AreEqual(2, ansflag);
        }

        [TestMethod]
        public void TestMethod4()
        {//测试输入错误答案的识别情况
            Build build = new Build();
            build.Expr[0] = 1;
            build.Expr[1] = 101;
            build.Expr[2] = 7;
            build.Expr[3] = 102;
            build.Expr[4] = 6;
            build.Expr[5] = 103;
            build.Expr[6] = 3;
            build.Expr[7] = 104;
            build.Expr[8] = 2;

            build.flag = 9;
            build.p = 9;
            //表达式是1+7-6*3/2
            build.TurnToHou();
            BinaryTree tree;
            tree = build.createtree();//将后缀表达式转换为二叉树
            tree.preordercalc(tree.getroot());//计算最终的结果并存在根节点
            Ans ans = new Ans();
            tree.getroot().value.Reduction();

            MyNumber correctAnswer = tree.getroot().value;//这里保存了计算出来的答案
            int ansflag = ans.GetResult(correctAnswer, "-3");
            Assert.AreEqual(0, ansflag);
        }

        //下面测试查重函数***************************************************//
        [TestMethod]
        public void TestMethod5()
        {//测试1+2+3和3+（2+1）
            Build build1 = new Build();
            build1.Expr[0] = 1;
            build1.Expr[1] = 101;
            build1.Expr[2] = 2;
            build1.Expr[3] = 101;
            build1.Expr[4] = 3;
           
            build1.flag = 5;
            build1.p = 5;
            //表达式是1+2+3
            build1.TurnToHou();
            BinaryTree tree1 = build1.createtree();
            tree1.preordercalc(tree1.getroot());//计算最终的结果并存在根节点
            tree1.adjustTree(tree1.getroot());

            Build build2 = new Build();
            build2.Expr[0] = 3;
            build2.Expr[1] = 101;
            build2.Expr[2] = 106;
            build2.Expr[3] = 2;
            build2.Expr[4] = 101;
            build2.Expr[5] = 1;
            build2.Expr[6] = 107;
            build2.flag = 7;
            build2.p = 7;
            //表达式是3+(2+1)
            build2.TurnToHou();
            BinaryTree tree2= build2.createtree();
            tree2.preordercalc(tree2.getroot());//计算最终的结果并存在根节点
            tree2.adjustTree(tree2.getroot());

            int flag = build1.compareTree(tree1, tree2);
            Assert.AreEqual(0, flag);

            //Ans ans = new Ans();
            //tree.getroot().value.Reduction();

           
        }

        [TestMethod]
        public void TestMethod6()
        {//测试1+2+3和3+（2+1）
            Build build1 = new Build();
            build1.Expr[0] = 6;
            build1.Expr[1] = 103;
            build1.Expr[2] = 8;
           
            build1.flag = 3;
            build1.p = 3;
            //表达式是6*8
            build1.TurnToHou();
            BinaryTree tree1 = build1.createtree();
            tree1.preordercalc(tree1.getroot());//计算最终的结果并存在根节点
            tree1.adjustTree(tree1.getroot());

            Build build2 = new Build();
            build2.Expr[0] = 8;
            build2.Expr[1] = 103;
            build2.Expr[2] = 6;
           
            build2.flag = 3;
            build2.p = 3;
            //表达式是8*6
            build2.TurnToHou();
            BinaryTree tree2 = build2.createtree();
            tree2.preordercalc(tree2.getroot());//计算最终的结果并存在根节点
            tree2.adjustTree(tree2.getroot());

            int flag = build1.compareTree(tree1, tree2);
            Assert.AreEqual(1, flag);

            //Ans ans = new Ans();
            //tree.getroot().value.Reduction();


        }


    }
}
