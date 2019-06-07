using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using WindowsFormsApp1;

namespace WindowsFormsApp1
{
    public partial class Form2 : Form
    {
        bool is_open2;
        public Form2(bool is_open2)
        {
            this.is_open2 = is_open2;
            InitializeComponent();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            if (is_open2 == true)
            {
                if (textBox1.Text != "")
                    Class_public.fps = Convert.ToInt32(textBox1.Text);
                if (textBox2.Text != "")
                    Class_public.width = Convert.ToInt32(textBox2.Text);
                if (textBox3.Text != "")
                    Class_public.height = Convert.ToInt32(textBox3.Text);
                this.Close();
            }
            else
            {
                MessageBox.Show("请先打开摄像头");
                this.Close();
            }
        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }
    }
}
