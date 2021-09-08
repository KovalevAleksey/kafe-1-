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
    public partial class Ассорти : Form
    {
        public Ассорти()
        {
            InitializeComponent();
        }

        private void button9_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            
        }

        private void button8_Click(object sender, EventArgs e)
        {
            
            double s = 0;
            if (checkBox1.Checked)
            {
                s = s + 25;
            }

            if (checkBox2.Checked)
            {
                s = s + 35;
            }
            if (checkBox3.Checked)
            {
                s = s + 40;
            }
            if (checkBox4.Checked)
            {
                s = s + 50;
            }
            if (checkBox5.Checked)
            {
                s = s + 110;
            }
            if (checkBox6.Checked)
            {
                s = s + 120;
            }
            if (checkBox7.Checked)
            {
                s = s + 140;
            }
            if (checkBox8.Checked)
            {
                s = s + 190;
            }
            if (checkBox9.Checked)
            {
                s = s + 80;
            }
            if (checkBox10.Checked)
            {
                s = s + 150;
            }
            if (checkBox11.Checked)
            {
                s = s + 200;
            }
            if (checkBox12.Checked)
            {
                s = s + 210;
            }
            if (checkBox13.Checked)
            {
                s = s + 220;
            }
            if (checkBox14.Checked)
            {
                s = s + 240;
            }
            if (checkBox15.Checked)
            {
                s = s + 310;
            }
            if (checkBox16.Checked)
            {
                s = s + 340;
            }
            if (checkBox17.Checked)
            {
                s = s + 190;
            }
            if (checkBox18.Checked)
            {
                s = s + 320;
            }
            if (checkBox19.Checked)
            {
                s = s + 500;
            }
            if (checkBox20.Checked)
            {
                s = s + 510;
            }
            if (radioButton1.Checked)
            {
                s = s - ((5 * s) / 100);
            }
            if (radioButton2.Checked)
            {
                s = s - ((15 * s) / 100);
            }
            textBox1.Text = Convert.ToString(s);


        }

        private void button7_Click(object sender, EventArgs e)
        {
            double s = 0;
            if (checkBox1.Checked)
            {
                s = s + 25;
            }

            if (checkBox2.Checked)
            {
                s = s + 35;
            }
            if (checkBox3.Checked)
            {
                s = s + 40;
            }
            if (checkBox4.Checked)
            {
                s = s + 50;
            }
            if (checkBox5.Checked)
            {
                s = s + 110;
            }
            if (checkBox6.Checked)
            {
                s = s + 120;
            }
            if (checkBox7.Checked)
            {
                s = s + 140;
            }
            if (checkBox8.Checked)
            {
                s = s + 190;
            }
            if (checkBox9.Checked)
            {
                s = s + 80;
            }
            if (checkBox10.Checked)
            {
                s = s + 150;
            }
            if (checkBox11.Checked)
            {
                s = s + 200;
            }
            if (checkBox12.Checked)
            {
                s = s + 210;
            }
            if (checkBox13.Checked)
            {
                s = s + 220;
            }
            if (checkBox14.Checked)
            {
                s = s + 240;
            }
            if (checkBox15.Checked)
            {
                s = s + 310;
            }
            if (checkBox16.Checked)
            {
                s = s + 340;
            }
            if (checkBox17.Checked)
            {
                s = s + 190;
            }
            if (checkBox18.Checked)
            {
                s = s + 320;
            }
            if (checkBox19.Checked)
            {
                s = s + 500;
            }
            if (checkBox20.Checked)
            {
                s = s + 510;
            }
            if (radioButton1.Checked)
            {
                s = s - ((5 * s) / 100);
            }
            if (radioButton2.Checked)
            {
                s = s - ((15 * s) / 100);
            }
        
            if (s == 0)
            {
                MessageBox.Show(Convert.ToString(s) + "-Вы ничего не выбрали  :(");
            }
            else
            {
                MessageBox.Show(Convert.ToString(s) + " - Это итоговая стоимость заказа. Заказ успешно оформлен!");
            }
        }

        private void button1_Click_1(object sender, EventArgs e)
        {
            О_нас formо_Нас = new О_нас();
            formо_Нас.Show();
        }

        private void perehod_Click(object sender, EventArgs e)
        {


            Form2 newFormMain2 = new Form2();
            newFormMain2.Show();
        }
    }
}
