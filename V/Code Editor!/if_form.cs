using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Code_Editor_
{
    public partial class @if : Form
    {
        public @if()
        {
            string Code = System.IO.File.ReadAllText(AppDomain.CurrentDomain.BaseDirectory + @"\if\if_01.v");
            string Code2 = System.IO.File.ReadAllText(AppDomain.CurrentDomain.BaseDirectory + @"\if\if_02.v");
            string Code3 = System.IO.File.ReadAllText(AppDomain.CurrentDomain.BaseDirectory + @"\if\if_03.v");
            string Code4 = System.IO.File.ReadAllText(AppDomain.CurrentDomain.BaseDirectory + @"\if\if_04.v");
            string Code5 = System.IO.File.ReadAllText(AppDomain.CurrentDomain.BaseDirectory + @"\if\if_05.v");
            InitializeComponent();
            class_01_code.Text = Code;
            richTextBox1.Text = Code2;
            richTextBox2.Text = Code3;
            richTextBox3.Text = Code4;
            richTextBox4.Text = Code5;
        }

        private void button1_Click(object sender, EventArgs e)
        {
            System.IO.File.WriteAllText(AppDomain.CurrentDomain.BaseDirectory + @"\if\if_01.v", class_01_code.Text);
        }

        private void button2_Click(object sender, EventArgs e)
        {
            System.IO.File.WriteAllText(AppDomain.CurrentDomain.BaseDirectory + @"\if\if_02.v", richTextBox1.Text);
        }

        private void button3_Click(object sender, EventArgs e)
        {
            System.IO.File.WriteAllText(AppDomain.CurrentDomain.BaseDirectory + @"\if\if_03.v", richTextBox2.Text);
        }

        private void button4_Click(object sender, EventArgs e)
        {
            System.IO.File.WriteAllText(AppDomain.CurrentDomain.BaseDirectory + @"\if\if_04.v", richTextBox3.Text);
        }

        private void button5_Click(object sender, EventArgs e)
        {
            System.IO.File.WriteAllText(AppDomain.CurrentDomain.BaseDirectory + @"\if\if_05.v", richTextBox4.Text);
        }

        private void if_Load(object sender, EventArgs e)
        {

        }
    }
}
