using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace TareaMusica
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            Console.Beep(264,300);
        }
        private void button2_Click(object sender, EventArgs e)
        {
            Console.Beep(297, 300);
        }

        private void button3_Click(object sender, EventArgs e)
        {
            Console.Beep(330, 300);
        }

        private void button4_Click(object sender, EventArgs e)
        {
            Console.Beep(352, 300);
        }

        private void button5_Click(object sender, EventArgs e)
        {
            Console.Beep(396, 300);
        }

        private void button6_Click(object sender, EventArgs e)
        {
            Console.Beep(440, 300);
        }

        private void button7_Click(object sender, EventArgs e)
        {
            Console.Beep(495, 300);   
        }

        private void button8_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }
    }
}