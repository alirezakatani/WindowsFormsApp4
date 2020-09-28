using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WindowsFormsApp4
{
    public partial class Form1 : Form
    {
        double x, y, z;
        string op;

        public Form1()
        {
            InitializeComponent();
            
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            textBox1_TextChanged(null,null);

        }

        private void button17_Click(object sender, EventArgs e)
        {

        }

        private void panel1_Paint(object sender, PaintEventArgs e)
        {

        }

        private void operators(object sender, EventArgs e)
        {
            x =Convert.ToDouble(textBox1.Text);
            op = ((Button)sender).Text;
            textBox1.Text = "";
        }

        private void equal(object sender, EventArgs e)
        {
            y = Convert.ToDouble(textBox1.Text);
            switch(op)
            {
                case "+":
                    z = x + y;
                    break;
                case "-":
                    z = x - y;
                    break;
                case "÷":
                    z = x / y;
                    break;
                case "*":
                    z = x * y;
                    break;
            }
            textBox1.Text = z.ToString();
        }

        private void backspace(object sender, EventArgs e)
        {
            if(textBox1.Text.Length>0)
            {textBox1.Text = textBox1.Text.Substring(0,textBox1.Text.Length-1);

            }
            
        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {
            if(textBox1.Text.Contains("/"))
            {
                button16.Enabled = false;
            }
            button19.Enabled =Convert.ToBoolean(textBox1.Text.Length) ;
                
        }

        private void button4_Click(object sender, EventArgs e)
        {
            textBox1.Text += ((Button)sender).Text;
        }
    }
}
