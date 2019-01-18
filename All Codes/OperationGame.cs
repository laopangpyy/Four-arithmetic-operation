using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Threading;
using System.IO;

 
namespace CalculatorGame
{
    public partial class OperationGame : Form
    {
        public int[] save = new int[50];
        Calculate calculate = new Calculate();
        public static Random rd = new Random();
        Build build = new Build();
        private bool IsFirstBuild = true;
        int createquestion = 1;
        private int score = 0;
        int totalTime = 20;
        int modemode = 0;
        int onequestion = 0;
        int qn, mn;
        int selectpow = 0;//1为** 2为^
        private int chance=10;
        List<BinaryTree> TreeList = new List<BinaryTree>();
        List<string> StrList = new List<string>();

        public OperationGame()
        {
            InitializeComponent();
            
        }

        private void button1_Click(object sender, EventArgs e)
        {
            

            bool a = int.TryParse(this.questionnum.Text, out qn);
            bool b = int.TryParse(this.textBox1.Text, out mn);




            if (modemode == 0)
                MessageBox.Show("请选择是否进行乘方运算");
            else if (modemode == 3 && selectpow == 0)
                MessageBox.Show("请选择乘方符号");
            else if (a == false)
                MessageBox.Show("请输入正确格式的题目个数");
            else if (b == false)
                MessageBox.Show("请输入正确格式的数字范围");
            else
            {
               
                if (createquestion == 1)
                {

                    string ExerPath = "Exercises.txt";

                    Build build = new Build();
                    int count = 0;
                    while (true)
                    {

                        if (count == qn)
                            break;

                        build.BuildExp(modemode, mn);//选择模式和数字范围，生成算式

                        if (selectpow < 2)
                            build.PrintExp1();
                        else if (selectpow == 2)
                            build.PrintExp2();


                        build.TurnToHou();

                        BinaryTree tree = build.createtree();//将后缀表达式转换为二叉树


                        tree.preordercalc(tree.getroot());//计算最终的结果并存在根节点

                        /*对生成的树进行比较*/
                        tree.adjustTree(tree.getroot());
                        int result = 1;
                        for (int i = 0; i < TreeList.Count; i++)
                        {
                            result = build.compareTree(TreeList[i], tree);
                            if (result == 0)
                            {
                                break;
                            }

                        }
                        if (result == 0)
                            continue;
                        else
                        {
                            count++;
                            TreeList.Add(tree);
                            StrList.Add(build.strsave);
                        }
                    }

                    //this.li = li;
                    System.IO.File.WriteAllText(ExerPath, string.Empty);//清空Exercises.txt内容
                    using (System.IO.StreamWriter file = new System.IO.StreamWriter(ExerPath, true))
                    {
                        int i = 0;
                        foreach (string s in StrList)
                        {
                            ++i;
                            file.WriteLine(Convert.ToString(i) + ".    " + s);
                        }
                        file.Flush();
                        file.Close();
                    }
                    createquestion = 0;
                }

           
                if (IsFirstBuild)
                {
                    label1.Visible = true;//这是题目
                    ansText.Visible = true;
                    button1.Visible = false;
                    label2.Visible = false;
                    button2.Visible = true;
                    timerText.Visible = true;
                    history.Visible = true;
                    groupBox1.Visible = false;
                    scoreText.Text = "得分：" + score.ToString();
                    hp.Text = "剩余次数" + chance.ToString();
                    timer1.Start();
                }
                ansText.Focus();
                if (onequestion >= qn)
                {
                    history_Click(null, null);
                }
                else
                {
                    label1.Text = StrList[onequestion];
                }
               



            }


        }

        private void button2_Click(object sender, EventArgs e)
        {
            if (ansText.Text == "")
            {
                ansText.Focus();
                return;
            }
            Ans ans = new Ans();
         
            TreeList[onequestion].getroot().value.Reduction();//对分子分母进行化简

            MyNumber correctAnswer = TreeList[onequestion].getroot().value;
            int ansflag = ans.GetResult(correctAnswer, this.ansText.Text);
            string correctAnswerStr = correctAnswer.M_ToString();
           
            if (ansflag == 1)
            {
                timer1.Stop();
                MessageBox.Show("回答正确\n");
                timer1.Start();
                score++;
                scoreText.Text = "得分：" + score.ToString();
               
                this.ansText.Text = "";
                totalTime = 20;
            }
            else if (ansflag == 0)
            {
                timer1.Stop();
                MessageBox.Show("回答错误\n"+ "正确答案是：" + correctAnswerStr);
                timer1.Start();
                chance=chance-1;
                if (chance <= 0)
                {
                    re.Visible = true;
                    record.Visible = true;
                    ansText.Visible = false;
                    button2.Visible = false;
                    timerText.Visible = false;
                    scoreText.Visible = false;
                    hp.Visible = false;
                    history.Visible = false;
                    label1.Visible = false;
                    timer1.Stop();
                    reto.Visible = false;

                    MessageBox.Show("很遗憾，您的错误次数过多\n请点击确定查看您的答题情况");
                    MessageBox.Show("您一共答对" + score + "道题，答错10道题\n请继续加油喔");

                    Application.Exit();
                }
                hp.Text = "剩余机会：" + chance.ToString();
               
                this.ansText.Text = "";
                totalTime = 20;
            }
            else
            {
                timer1.Stop();
                MessageBox.Show("请输入正确的答案格式");
                timer1.Start();
                this.ansText.Text = "";
                this.ansText.Focus();
            }

            record.Text += StrList[onequestion] +"="+ correctAnswerStr + "\r\n";
            onequestion++;//题目加1
            button1_Click(null, null);
        }
        
        private void timer1_Tick(object sender, EventArgs e)
        {
            timerText.Text = "倒计时："+(totalTime--).ToString();

            if(totalTime==-1)
            {
                timer1.Stop();
                timerText.Visible = false;
                MessageBox.Show("时间到！");
                chance -= 1;
                hp.Text = "剩余次数" + chance.ToString();
                onequestion++;
                button1_Click(null, null);
                totalTime = 20;
            }
            
        }

        private void history_Click(object sender, EventArgs e)
        {
            
            re.Visible = true;
            record.Visible = true;
            //reto.Visible = true;
            ansText.Visible = false;
            button2.Visible = false;
            timerText.Visible =false;
            scoreText.Visible = false;
            hp.Visible = false;
            history.Visible = false;
            label1.Visible = false;
            //button4.Visible = false;
            timer1.Stop();
            if (onequestion >= qn)
            {
                int tempp = 10 - chance;
                reto.Visible = false;
                MessageBox.Show("恭喜您完成您设置生成的所有题\n请点击确定查看您的答题情况");
                MessageBox.Show("您一共答对" + score + "道题，答错" +tempp+ "道题\n请继续加油喔");
                Application.Exit();

            }
            else reto.Visible = true;

        }

        private void Question_Load(object sender, EventArgs e)
        {
            skinEngine1.SkinFile = Application.StartupPath + @"/Skins/MacOS.ssk";
        }
       
        private void reto_Click(object sender, EventArgs e)
        {
            re.Visible = false;
            record.Visible = false;
            reto.Visible = false;
            ansText.Visible = true;
            button2.Visible = true;
            timerText.Visible = true;
            scoreText.Visible = true;
            hp.Visible = true;
            history.Visible = true;
            label1.Visible = true;
            timer1.Start();
        }

        private void re_Click(object sender, EventArgs e)
        {

        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void button3_Click(object sender, EventArgs e)
        {
            label2.Visible = true;
            button1.Visible = true;
            label1.Visible = false;
            button3.Visible = false;
            groupBox1.Visible = true;

        }

        private void label3_Click(object sender, EventArgs e)
        {

        }

        private void radioButton1_CheckedChanged(object sender, EventArgs e)
        {
            
            modemode = 3;
        }

        private void radioButton2_CheckedChanged(object sender, EventArgs e)
        {
            modemode = 2;
        }

        private void questionnum_TextChanged(object sender, EventArgs e)
        {

        }

        private void radioButton3_CheckedChanged(object sender, EventArgs e)
        {
            selectpow = 1;
        }

        private void radioButton4_CheckedChanged(object sender, EventArgs e)
        {
            selectpow = 2;
        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }

        private void button4_Click(object sender, EventArgs e)
        {

        }

        private void groupBox1_Enter(object sender, EventArgs e)
        {

        }

        private void label7_Click(object sender, EventArgs e)
        {

        }

        private void panel3_Paint(object sender, PaintEventArgs e)
        {

        }
    }
}
