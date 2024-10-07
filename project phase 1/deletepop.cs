using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using static System.Windows.Forms.LinkLabel;

namespace project_phase_1
{
    public partial class deletepop : Form
    {
        public deletepop()
        {
            InitializeComponent();
        }

        private void deletepop_Load(object sender, EventArgs e)
        {
            string source3 = @"C:\\Users\\DELL\\Desktop\\project phase 1\\project phase 1\\database\\vcount.txt";
            string[] line3 = File.ReadAllLines(source3);
            foreach (string line in line3)
            {
                textBox1.Text = textBox1.Text + line + Environment.NewLine;
            }
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            string source5 = @"C:\\Users\\DELL\\Desktop\\project phase 1\\project phase 1\\database\\vcount.txt";
            string[] line5 = File.ReadAllLines(source5);
            foreach (string line in line5)
            {
                if (File.Exists(line))
                {
                    File.Delete(line);
                }
            }
            MessageBox.Show("All the viruses deleted successfully!");
            File.WriteAllText(source5, String.Empty);
        }
    }
}
