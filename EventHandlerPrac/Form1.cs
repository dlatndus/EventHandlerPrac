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
    }
}
