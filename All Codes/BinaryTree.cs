using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CalculatorGame
{
    //节点
    class TreeNode
    {
        public int type;
        public int op;///从string改成int了
        //public string s;
        public MyNumber value;
        public TreeNode left;
        public TreeNode right;
    }
    //值节点
    class NumNode : TreeNode
    {
        public NumNode(MyNumber value)
        {
            this.type = 1;
            this.value = value;
            this.left = null;
            this.right = null;
        }
    }
    //运算符节点
    class OpNode : TreeNode
    {
        public OpNode(int op)
        {
            this.type = 2;
            this.op = op;
            this.value = null;
            this.left = null;
            this.right = null;
        }
     
    }
    //二叉树定义
    class BinaryTree
    {
        TreeNode root;//根节点
        int height;//高度
        int number;//长度即包含的运算符数量
        public TreeNode getroot()
        {
            return root;
        }
        public int getheight()
        {
            return height;
        }
        public int getnumber()
        {
            return number;
        }
        public BinaryTree(TreeNode root, int number)
        {
            this.root = root;
            this.height = 0;
            this.number = number;
        }

        //调整为左子树永远比右子树大
        public void adjustTree(TreeNode root)
        {
            if (root.left != null)
            {
                adjustTree(root.left);
            }
            if (root.right != null)
            {
                adjustTree(root.right);
            }
            if (root.left != null && root.right != null)
            {
                if (root.left.value.getvalue() < root.right.value.getvalue())
                {
                    TreeNode tmp = root.right;
                    root.right = root.left;
                    root.left = tmp;
                }
            }
        }
    
        //计算表达式，并将计算结果保存在二叉树的根节点上
        public MyNumber preordercalc(TreeNode root)
        {
            MyNumber num1, num2, result;
            if (root.type==2)//为符号
            {
                num1 = preordercalc(root.left);
                num2 = preordercalc(root.right);
                Calculate cal = new Calculate();
                result = cal.OneStepCalculate(num1, num2, root.op);
                root.value = result;
                return result;
            }
            return root.value;
        }


      
    }


}
