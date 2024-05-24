using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Ex_3
{
    public partial class Pyramid_with_square_base : Form
    {
        public Pyramid_with_square_base()
        {
            InitializeComponent();
        }

        private void textBox2_TextChanged(object sender, EventArgs e)
        {

        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }

        private void textBox3_TextChanged(object sender, EventArgs e)
        {

        }

        private void textBox4_TextChanged(object sender, EventArgs e)
        {

        }

        private void textBox5_TextChanged(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            int length = (int)Convert.ToInt64(textBox2.Text);
            int width = (int)Convert.ToInt64(textBox1.Text);
            int heigth = (int)Convert.ToInt64(textBox3.Text);

            Pyramid pyramid = new Pyramid(length, width, heigth);

            textBox4.Text = Convert.ToString(pyramid.BaseArea(width, length));
            textBox5.Text = Convert.ToString(pyramid.PyramidVol(width, heigth, length));
        }
    }
}
