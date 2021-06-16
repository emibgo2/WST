using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WinFormsApp2
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void trackBar1_Scroll(object sender, EventArgs e)
        {
            label1.Text = Convert.ToString(trackBar1.Value);
            int labInt = Convert.ToInt32(label1.Text);
            int time = trackBar1.Value;
            int hour = time % 3600%60;
            int minutes = time % 3600 / 60;
            textBox2.Text = label1.Text;
            int test=0;

            test += 1;
            textBox2.Text= Convert.ToString(hour);
            textBox1.Text = Convert.ToString(minutes);
            
        }

        private void button2_Click(object sender, EventArgs e)
        {
            int hour = Convert.ToInt32(textBox1.Text) * 60;
            int minute = Convert.ToInt32(textBox2.Text) * 60;
            int time2 = (hour * 60) + minute;
            System.Diagnostics.Process.Start("shutdown.exe", "-s -t " + time2);
            DateTime now = DateTime.Now;

            textBox3.Text += $"{DateTime.Now.ToString("h:mm tt")}:      {textBox1.Text}시  {textBox2.Text}분 뒤 종료 설정\r\n";
            DateTime result = now.AddSeconds(time2); //초 추가
            label4.Text = $"{result}에 종료 됩니다.";
        }

        private void textBox2_TextChanged(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            System.Diagnostics.Process.Start("shutdown.exe", "-a");
            textBox3.Text = "";

        }
    }
}
