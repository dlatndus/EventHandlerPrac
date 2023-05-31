using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace EventHandlerPrac
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            Button btn = (Button)sender;
            if(btn == button1)
            {
                button1.Enabled = false;
                button2.Enabled = true;
            }
            else if(btn == button2)
            {
                button1.Enabled = true;
                button2.Enabled = false;
            }

            MessageBox.Show(btn.Text + "버튼이 클릭되었습니다.");
        }

        private void Form1_FormClosed(object sender, FormClosedEventArgs e)
        {
            MessageBox.Show(e.CloseReason.ToString());
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private int time = 0;

        private void timer1_Tick(object sender, EventArgs e)
        {
            time++;
            label1.Text = time + "초";
            textBox1.Text = time + "초";
        }

        private void button3_Click(object sender, EventArgs e)
        {
            timer1.Enabled = !timer1.Enabled;
            if(timer1.Enabled) {
                button3.Text = "타이머 끄기";

            }
            else
            {
                button3.Text = "타이머 켜기";
            }
        }
    }
}
