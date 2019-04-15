using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Diagnostics;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Code_Editor_
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            string Code = System.IO.File.ReadAllText(AppDomain.CurrentDomain.BaseDirectory + @"\program.v");
            string class_s = System.IO.File.ReadAllText(AppDomain.CurrentDomain.BaseDirectory + @"\class.s");
            InitializeComponent();
            richTextBox1.Text = Code;
        }

        private void fileToolStripMenuItem_Click(object sender, EventArgs e)
        {

        }

        private void Run_Click(object sender, EventArgs e)
        {
            Process.Start("v.exe");
            Process.Start("Program.exe");
        }

        private void Open_Click(object sender, EventArgs e)
        {

        }

        private void Undo_Click(object sender, EventArgs e)
        {
            richTextBox1.Undo
                
                
                ();
        }

        private void Redo_Click(object sender, EventArgs e)
        {
            richTextBox1.Redo();
        }

        private void richTextBox1_TextChanged(object sender, EventArgs e)
        {

        }

        private void Save_Click(object sender, EventArgs e)
        {
            System.IO.File.WriteAllText(AppDomain.CurrentDomain.BaseDirectory + @"\program.v", richTextBox1.Text);
        }

        private void undoToolStripMenuItem_Click(object sender, EventArgs e)
        {
        }

        private void undoToolStripMenuItem_Click_1(object sender, EventArgs e)
        {
            richTextBox1.Undo();
        }

        private void redoToolStripMenuItem_Click(object sender, EventArgs e)
        {
            richTextBox1.Redo();
        }

        private void saveToolStripMenuItem_Click(object sender, EventArgs e)
        {
            System.IO.File.WriteAllText(AppDomain.CurrentDomain.BaseDirectory + @"\program.v", richTextBox1.Text);
        }

        private void toolStripComboBox1_Click(object sender, EventArgs e)
        {

        }

        private void checkBox1_CheckedChanged(object sender, EventArgs e)
        {
            if (checkBox1.Checked)
            {
                System.IO.File.WriteAllText(AppDomain.CurrentDomain.BaseDirectory + @"\class.s", "true");
            }
            else
            {
                System.IO.File.WriteAllText(AppDomain.CurrentDomain.BaseDirectory + @"\class.s", "false");
            }
        }

        private void customClassToolStripMenuItem_Click(object sender, EventArgs e)
        {
            settings frm2 = new settings();
            frm2.ShowDialog();
        }

        private void ifFunctionsToolStripMenuItem_Click(object sender, EventArgs e)
        {
            @if frm2 = new @if();
            frm2.ShowDialog();
        }

        private void CompileToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Process.Start("v.exe");
        }

        private void RunToolStripMenuItem1_Click(object sender, EventArgs e)
        {
            Process.Start("Program.exe");
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void Button1_Click(object sender, EventArgs e)
        {
            reset frm2 = new reset();
            frm2.ShowDialog();
        }
    }
}
