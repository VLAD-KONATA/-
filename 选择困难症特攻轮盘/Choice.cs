using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace 选择困难症特攻轮盘
{
    public partial class Choice : System.Windows.Forms.Form
    {
        public Choice()
        {
            InitializeComponent();
        }
        Random random;
        int counts;
        private void Reset_Click(object sender, EventArgs e)
        {
            Result.Clear();
            Choices.Clear();
            Maintheme.Clear();
        }

        private void Choose_Click(object sender, EventArgs e)
        {
            random = new Random();
            Result.Clear();
            string[] choices = Choices.Text.Split('\n');
            Result.Text += "--------------START------------\n";
            Result.Text += "今天选择困难的是：" + Maintheme.Text+"\n";
            for (int i = 0; i < choices.Length; i++)
                Result.Text += (i+1).ToString()+"."+choices[i]+"\n";
            switch(Counts.SelectedIndex)
            {
                case 1:Result.Text += "\n一共选择3次\n"; counts = 3; break;
                case 2: Result.Text += "\n一共选择5次\n"; counts = 5; break;
                case 3: Result.Text += "\n一共选择10次\n"; counts = 10; break;
                default: Result.Text += "\n一共选择1次\n"; counts = 1; break;
            }
            for (int i = 0; i < counts; i++)
            {
                Result.Text += "\n第" + (i + 1).ToString() + "次选择：\n";
                Result.Text += "结果：\t" + choices[random.Next(0, choices.Length)] + "\n";
                Thread.Sleep(100);
            }
            Result.Text += "--------------END--------------";        
        }
    }
}
