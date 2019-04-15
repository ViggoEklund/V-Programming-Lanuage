using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO.Compression;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Code_Editor_
{
    public partial class reset : Form
    {
        public reset()
        {
            InitializeComponent();
        }

        private void Button1_Click(object sender, EventArgs e)
        {
            string zipPath = AppDomain.CurrentDomain.BaseDirectory + @"\Data\New_reset.zip";
            string extractPath = AppDomain.CurrentDomain.BaseDirectory + @"\";

            ZipFile.ExtractToDirectory(zipPath, extractPath);
            this.Close();
        }

        private void Button2_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
