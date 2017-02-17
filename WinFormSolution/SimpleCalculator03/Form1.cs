using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace SimpleCalculator01
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }


        private void sum(int a)
        {
            int x = int.Parse(textBox1.Text);//將textbox1內輸入的數值轉成整數型態存入變數x
            int y = int.Parse(textBox2.Text);//將textbox2內輸入的數值轉成整數型態存入變數y
            switch (a)
            {
                case 1:
                    label1.Text = (x + y).ToString();//把最後的值轉成字串顯示
                    break;
                case 2:
                    label1.Text = (x - y).ToString();//把最後的值轉成字串顯示
                    break;
                case 3:
                    label1.Text = (x * y).ToString();//把最後的值轉成字串顯示
                    break;
                case 4:
                    label1.Text = (x / y).ToString();//把最後的值轉成字串顯示
                    break;
            }
        }

        private void button1_Click(object sender, EventArgs e)
        {
            sum(1);//當按下加鍵時會產生1進入sum副程式內去執行case1
        }

        private void button2_Click(object sender, EventArgs e)
        {
            sum(2);//當按下減鍵時會產生2進入sum副程式內去執行case2
        }

        private void button3_Click(object sender, EventArgs e)
        {
            sum(3);//當按下乘鍵時會產生3進入sum副程式內去執行case3
        }

        private void button4_Click(object sender, EventArgs e)
        {
            sum(4);//當按下除鍵時會產生4進入sum副程式內去執行case4
        }
    }
}
