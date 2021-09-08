using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace kafe_1_
{
    public partial class Form2 : Form
    {
        public Form2()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            if (textBox1.Text != null && textBox1.Text != ""
                && textBox2.Text !=null && textBox2.Text != ""   
                )
            {
                double math;
                math = Convert.ToDouble(textBox1.Text);
                double puc;
                puc = Convert.ToDouble(textBox2.Text);
                if (math > 2.5 && math < 3.5)
                {
                    MessageBox.Show("удов");
                }
                if (math > 3.5 && math < 4.5)
                {
                    MessageBox.Show("Хорошо");
                }
            }
            else
            {
                MessageBox.Show("Вы ввели не все значения","error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
           
        }
    }
}
