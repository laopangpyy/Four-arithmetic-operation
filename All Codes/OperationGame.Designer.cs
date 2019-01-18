namespace CalculatorGame
{
    partial class OperationGame
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            this.label1 = new System.Windows.Forms.Label();
            this.button1 = new System.Windows.Forms.Button();
            this.button2 = new System.Windows.Forms.Button();
            this.ansText = new System.Windows.Forms.TextBox();
            this.timerText = new System.Windows.Forms.Label();
            this.timer1 = new System.Windows.Forms.Timer(this.components);
            this.history = new System.Windows.Forms.Button();
            this.re = new System.Windows.Forms.Label();
            this.record = new System.Windows.Forms.Label();
            this.reto = new System.Windows.Forms.Button();
            this.skinEngine1 = new Sunisoft.IrisSkin.SkinEngine();
            this.label2 = new System.Windows.Forms.Label();
            this.button3 = new System.Windows.Forms.Button();
            this.label3 = new System.Windows.Forms.Label();
            this.questionnum = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.radioButton1 = new System.Windows.Forms.RadioButton();
            this.radioButton2 = new System.Windows.Forms.RadioButton();
            this.label5 = new System.Windows.Forms.Label();
            this.textBox1 = new System.Windows.Forms.TextBox();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.panel2 = new System.Windows.Forms.Panel();
            this.radioButton4 = new System.Windows.Forms.RadioButton();
            this.radioButton3 = new System.Windows.Forms.RadioButton();
            this.label6 = new System.Windows.Forms.Label();
            this.panel1 = new System.Windows.Forms.Panel();
            this.scoreText = new System.Windows.Forms.Label();
            this.hp = new System.Windows.Forms.Label();
            this.groupBox1.SuspendLayout();
            this.panel2.SuspendLayout();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("STXihei", 22.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.label1.Location = new System.Drawing.Point(104, 33);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(318, 41);
            this.label1.TabIndex = 0;
            this.label1.Text = "        四则运算游戏";
            this.label1.Click += new System.EventHandler(this.label1_Click);
            // 
            // button1
            // 
            this.button1.Font = new System.Drawing.Font("SimSun", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.button1.Location = new System.Drawing.Point(208, 349);
            this.button1.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(180, 38);
            this.button1.TabIndex = 1;
            this.button1.Text = "确认开始游戏";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Visible = false;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // button2
            // 
            this.button2.Font = new System.Drawing.Font("SimHei", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.button2.Location = new System.Drawing.Point(405, 225);
            this.button2.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(119, 33);
            this.button2.TabIndex = 2;
            this.button2.Text = "提交答案";
            this.button2.UseVisualStyleBackColor = true;
            this.button2.Visible = false;
            this.button2.Click += new System.EventHandler(this.button2_Click);
            // 
            // ansText
            // 
            this.ansText.Font = new System.Drawing.Font("Times New Roman", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.ansText.Location = new System.Drawing.Point(77, 231);
            this.ansText.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.ansText.Name = "ansText";
            this.ansText.Size = new System.Drawing.Size(165, 34);
            this.ansText.TabIndex = 3;
            this.ansText.Visible = false;
            // 
            // timerText
            // 
            this.timerText.AutoSize = true;
            this.timerText.Font = new System.Drawing.Font("SimHei", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.timerText.Location = new System.Drawing.Point(77, 152);
            this.timerText.Name = "timerText";
            this.timerText.Size = new System.Drawing.Size(0, 24);
            this.timerText.TabIndex = 4;
            this.timerText.Visible = false;
            // 
            // timer1
            // 
            this.timer1.Interval = 1000;
            this.timer1.Tick += new System.EventHandler(this.timer1_Tick);
            // 
            // history
            // 
            this.history.Font = new System.Drawing.Font("SimHei", 14F);
            this.history.Location = new System.Drawing.Point(405, 287);
            this.history.Margin = new System.Windows.Forms.Padding(4);
            this.history.Name = "history";
            this.history.Size = new System.Drawing.Size(119, 36);
            this.history.TabIndex = 7;
            this.history.Text = "历史记录";
            this.history.UseVisualStyleBackColor = true;
            this.history.Visible = false;
            this.history.Click += new System.EventHandler(this.history_Click);
            // 
            // re
            // 
            this.re.AutoSize = true;
            this.re.Font = new System.Drawing.Font("SimHei", 14F);
            this.re.Location = new System.Drawing.Point(13, 11);
            this.re.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.re.Name = "re";
            this.re.Size = new System.Drawing.Size(118, 24);
            this.re.TabIndex = 8;
            this.re.Text = "历史记录:";
            this.re.Visible = false;
            this.re.Click += new System.EventHandler(this.re_Click);
            // 
            // record
            // 
            this.record.AutoSize = true;
            this.record.Font = new System.Drawing.Font("SimHei", 14F);
            this.record.Location = new System.Drawing.Point(19, 50);
            this.record.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.record.Name = "record";
            this.record.Size = new System.Drawing.Size(0, 24);
            this.record.TabIndex = 9;
            this.record.Visible = false;
            // 
            // reto
            // 
            this.reto.Font = new System.Drawing.Font("SimHei", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.reto.Location = new System.Drawing.Point(405, 290);
            this.reto.Margin = new System.Windows.Forms.Padding(4);
            this.reto.Name = "reto";
            this.reto.Size = new System.Drawing.Size(110, 32);
            this.reto.TabIndex = 10;
            this.reto.Text = "返回";
            this.reto.UseVisualStyleBackColor = true;
            this.reto.Visible = false;
            this.reto.Click += new System.EventHandler(this.reto_Click);
            // 
            // skinEngine1
            // 
            this.skinEngine1.@__DrawButtonFocusRectangle = true;
            this.skinEngine1.DisabledButtonTextColor = System.Drawing.Color.Gray;
            this.skinEngine1.DisabledMenuFontColor = System.Drawing.SystemColors.GrayText;
            this.skinEngine1.InactiveCaptionColor = System.Drawing.SystemColors.InactiveCaptionText;
            this.skinEngine1.SerialNumber = "";
            this.skinEngine1.SkinFile = null;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("STXihei", 22.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.label2.Location = new System.Drawing.Point(191, 11);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(213, 41);
            this.label2.TabIndex = 11;
            this.label2.Text = "游戏前设置";
            this.label2.Visible = false;
            // 
            // button3
            // 
            this.button3.Font = new System.Drawing.Font("SimSun", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.button3.Location = new System.Drawing.Point(239, 349);
            this.button3.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.button3.Name = "button3";
            this.button3.Size = new System.Drawing.Size(121, 43);
            this.button3.TabIndex = 12;
            this.button3.Text = "进入游戏";
            this.button3.UseVisualStyleBackColor = true;
            this.button3.Click += new System.EventHandler(this.button3_Click);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(32, 30);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(165, 15);
            this.label3.TabIndex = 13;
            this.label3.Text = "#请在下方输入题目个数";
            this.label3.Click += new System.EventHandler(this.label3_Click);
            // 
            // questionnum
            // 
            this.questionnum.Location = new System.Drawing.Point(79, 48);
            this.questionnum.Name = "questionnum";
            this.questionnum.Size = new System.Drawing.Size(71, 25);
            this.questionnum.TabIndex = 14;
            this.questionnum.TextChanged += new System.EventHandler(this.questionnum_TextChanged);
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(8, 149);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(210, 15);
            this.label4.TabIndex = 15;
            this.label4.Text = "#请在下方选择是否有乘方运算";
            // 
            // radioButton1
            // 
            this.radioButton1.AutoSize = true;
            this.radioButton1.Location = new System.Drawing.Point(96, 167);
            this.radioButton1.Name = "radioButton1";
            this.radioButton1.Size = new System.Drawing.Size(43, 19);
            this.radioButton1.TabIndex = 17;
            this.radioButton1.TabStop = true;
            this.radioButton1.Text = "是";
            this.radioButton1.UseVisualStyleBackColor = true;
            this.radioButton1.CheckedChanged += new System.EventHandler(this.radioButton1_CheckedChanged);
            // 
            // radioButton2
            // 
            this.radioButton2.AutoSize = true;
            this.radioButton2.Location = new System.Drawing.Point(96, 192);
            this.radioButton2.Name = "radioButton2";
            this.radioButton2.Size = new System.Drawing.Size(43, 19);
            this.radioButton2.TabIndex = 18;
            this.radioButton2.TabStop = true;
            this.radioButton2.Text = "否";
            this.radioButton2.UseVisualStyleBackColor = true;
            this.radioButton2.CheckedChanged += new System.EventHandler(this.radioButton2_CheckedChanged);
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(22, 88);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(180, 15);
            this.label5.TabIndex = 19;
            this.label5.Text = "#请在下方输入数字最大值\r\n";
            // 
            // textBox1
            // 
            this.textBox1.Location = new System.Drawing.Point(79, 106);
            this.textBox1.Name = "textBox1";
            this.textBox1.Size = new System.Drawing.Size(71, 25);
            this.textBox1.TabIndex = 20;
            this.textBox1.TextChanged += new System.EventHandler(this.textBox1_TextChanged);
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.panel2);
            this.groupBox1.Controls.Add(this.label6);
            this.groupBox1.Controls.Add(this.textBox1);
            this.groupBox1.Controls.Add(this.label5);
            this.groupBox1.Controls.Add(this.radioButton2);
            this.groupBox1.Controls.Add(this.radioButton1);
            this.groupBox1.Controls.Add(this.label4);
            this.groupBox1.Controls.Add(this.questionnum);
            this.groupBox1.Controls.Add(this.label3);
            this.groupBox1.Controls.Add(this.panel1);
            this.groupBox1.Location = new System.Drawing.Point(167, 68);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(267, 274);
            this.groupBox1.TabIndex = 21;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "设置";
            this.groupBox1.Visible = false;
            this.groupBox1.Enter += new System.EventHandler(this.groupBox1_Enter);
            // 
            // panel2
            // 
            this.panel2.Controls.Add(this.radioButton4);
            this.panel2.Controls.Add(this.radioButton3);
            this.panel2.Location = new System.Drawing.Point(43, 237);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(153, 31);
            this.panel2.TabIndex = 24;
            // 
            // radioButton4
            // 
            this.radioButton4.AutoSize = true;
            this.radioButton4.Location = new System.Drawing.Point(95, 3);
            this.radioButton4.Name = "radioButton4";
            this.radioButton4.Size = new System.Drawing.Size(36, 19);
            this.radioButton4.TabIndex = 23;
            this.radioButton4.TabStop = true;
            this.radioButton4.Text = "^";
            this.radioButton4.UseVisualStyleBackColor = true;
            this.radioButton4.CheckedChanged += new System.EventHandler(this.radioButton4_CheckedChanged);
            // 
            // radioButton3
            // 
            this.radioButton3.AutoSize = true;
            this.radioButton3.Location = new System.Drawing.Point(17, 3);
            this.radioButton3.Name = "radioButton3";
            this.radioButton3.Size = new System.Drawing.Size(44, 19);
            this.radioButton3.TabIndex = 22;
            this.radioButton3.TabStop = true;
            this.radioButton3.Text = "**";
            this.radioButton3.UseVisualStyleBackColor = true;
            this.radioButton3.CheckedChanged += new System.EventHandler(this.radioButton3_CheckedChanged);
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(4, 222);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(240, 15);
            this.label6.TabIndex = 21;
            this.label6.Text = "#若选择乘方运算，请选择乘方符号";
            // 
            // panel1
            // 
            this.panel1.Location = new System.Drawing.Point(86, 167);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(64, 52);
            this.panel1.TabIndex = 22;
            // 
            // scoreText
            // 
            this.scoreText.AutoSize = true;
            this.scoreText.Font = new System.Drawing.Font("SimHei", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.scoreText.Location = new System.Drawing.Point(405, 90);
            this.scoreText.Name = "scoreText";
            this.scoreText.Size = new System.Drawing.Size(0, 24);
            this.scoreText.TabIndex = 5;
            // 
            // hp
            // 
            this.hp.AutoSize = true;
            this.hp.Font = new System.Drawing.Font("SimHei", 14F);
            this.hp.Location = new System.Drawing.Point(405, 140);
            this.hp.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.hp.Name = "hp";
            this.hp.Size = new System.Drawing.Size(0, 24);
            this.hp.TabIndex = 6;
            // 
            // OperationGame
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.ClientSize = new System.Drawing.Size(567, 398);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.button2);
            this.Controls.Add(this.reto);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.button3);
            this.Controls.Add(this.record);
            this.Controls.Add(this.re);
            this.Controls.Add(this.history);
            this.Controls.Add(this.ansText);
            this.Controls.Add(this.timerText);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.hp);
            this.Controls.Add(this.scoreText);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.Name = "OperationGame";
            this.Text = "OperationGame";
            this.Load += new System.EventHandler(this.Question_Load);
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.panel2.ResumeLayout(false);
            this.panel2.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
      
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button button1;//确认开始游戏
        private System.Windows.Forms.Button button2;
        private System.Windows.Forms.TextBox ansText;
        private System.Windows.Forms.Label timerText;
        private System.Windows.Forms.Timer timer1;
        private System.Windows.Forms.Button history;
        private System.Windows.Forms.Label re;
        private System.Windows.Forms.Label record;
        private System.Windows.Forms.Button reto;
        private Sunisoft.IrisSkin.SkinEngine skinEngine1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Button button3;//进入游戏
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox questionnum;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.RadioButton radioButton1;
        private System.Windows.Forms.RadioButton radioButton2;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.TextBox textBox1;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.RadioButton radioButton3;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.RadioButton radioButton4;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Label scoreText;
        private System.Windows.Forms.Label hp;
    }
}
