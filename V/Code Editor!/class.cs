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
    public partial class settings : Form
    {
        public settings()
        {
            InitializeComponent();
            string name_01 = System.IO.File.ReadAllText(AppDomain.CurrentDomain.BaseDirectory + @"\class\function_01.n");
            string code_01 = System.IO.File.ReadAllText(AppDomain.CurrentDomain.BaseDirectory + @"\class\function_01_event.n");
            string name_02 = System.IO.File.ReadAllText(AppDomain.CurrentDomain.BaseDirectory + @"\class\function_02.n");
            string code_02 = System.IO.File.ReadAllText(AppDomain.CurrentDomain.BaseDirectory + @"\class\function_02_event.n");
            string name_03 = System.IO.File.ReadAllText(AppDomain.CurrentDomain.BaseDirectory + @"\class\function_03.n");
            string code_03 = System.IO.File.ReadAllText(AppDomain.CurrentDomain.BaseDirectory + @"\class\function_03_event.n");
            string name_04 = System.IO.File.ReadAllText(AppDomain.CurrentDomain.BaseDirectory + @"\class\function_04.n");
            string code_04 = System.IO.File.ReadAllText(AppDomain.CurrentDomain.BaseDirectory + @"\class\function_04_event.n");
            string name_05 = System.IO.File.ReadAllText(AppDomain.CurrentDomain.BaseDirectory + @"\class\function_05.n");
            string code_05 = System.IO.File.ReadAllText(AppDomain.CurrentDomain.BaseDirectory + @"\class\function_05_event.n");
            class_01_name.Text = name_01;
            class_01_code.Text = code_01;
            textBox1.Text = name_02;
            richTextBox1.Text = code_02;
            textBox2.Text = name_03;
            richTextBox2.Text = code_03;
            textBox3.Text = name_04;
            richTextBox3.Text = code_04;
            textBox4.Text = name_05;
            richTextBox4.Text = code_05;
        }

        private void button1_Click(object sender, EventArgs e)
        {
            System.IO.File.WriteAllText(AppDomain.CurrentDomain.BaseDirectory + @"\class\function_01.n", class_01_name.Text);
            System.IO.File.WriteAllText(AppDomain.CurrentDomain.BaseDirectory + @"\class\function_01_event.n", class_01_code.Text);
        }

        private void button2_Click(object sender, EventArgs e)
        {
            System.IO.File.WriteAllText(AppDomain.CurrentDomain.BaseDirectory + @"\class\function_02.n", textBox1.Text);
            System.IO.File.WriteAllText(AppDomain.CurrentDomain.BaseDirectory + @"\class\function_02_event.n", richTextBox1.Text);
        }

        private void button3_Click(object sender, EventArgs e)
        {
            System.IO.File.WriteAllText(AppDomain.CurrentDomain.BaseDirectory + @"\class\function_03.n", textBox2.Text);
            System.IO.File.WriteAllText(AppDomain.CurrentDomain.BaseDirectory + @"\class\function_03_event.n", richTextBox2.Text);
        }

        private void button4_Click(object sender, EventArgs e)
        {
            System.IO.File.WriteAllText(AppDomain.CurrentDomain.BaseDirectory + @"\class\function_04.n", textBox3.Text);
            System.IO.File.WriteAllText(AppDomain.CurrentDomain.BaseDirectory + @"\class\function_04_event.n", richTextBox3.Text);
        }

        private void button5_Click(object sender, EventArgs e)
        {
            System.IO.File.WriteAllText(AppDomain.CurrentDomain.BaseDirectory + @"\class\function_05.n", textBox4.Text);
            System.IO.File.WriteAllText(AppDomain.CurrentDomain.BaseDirectory + @"\class\function_05_event.n", richTextBox4.Text);
        }

        private void Settings_Load(object sender, EventArgs e)
        {

        }
    }
}
