using project_phase_1.Properties;
using System.ComponentModel.DataAnnotations.Schema;
using System.IO;
using System.Security.Cryptography;
using System.Windows.Forms;
using System.Windows.Forms.VisualStyles;
using static System.Windows.Forms.VisualStyles.VisualStyleElement.ListView;

namespace project_phase_1
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        public void Form1_Load(object sender, EventArgs e)
        {
            dashpanel.Show();
            fscanpanel.Hide();
            folscanpanel.Hide();
            histpanel.Hide();
            dashbutton.Focus();
            string systname = Environment.MachineName.ToString();
            string osname = Environment.OSVersion.ToString();
            string source2 = "C:\\Mangesh\\final exam project\\project phase 1\\project phase 1\\database\\Records.txt";

            string[] line2 = File.ReadAllLines(source2);

            //int totalfcount = Directory.EnumerateFiles(@"D:\\Anime", "*.*", SearchOption.AllDirectories).Count();
            int totalfcount = 0;
            string source = "C:\\Mangesh\\final exam project\\project phase 1\\project phase 1\\database\\fcount.txt";

            if (new FileInfo(source).Length == 0)
            {

                DriveInfo[] alldrives = DriveInfo.GetDrives();
                foreach (DriveInfo drive in alldrives)
                {
                    try
                    {
                        string field = drive.Name;
                        DirectoryInfo fieldinfo = new DirectoryInfo(field);
                        DirectoryInfo[] fieldfiles = fieldinfo.GetDirectories();
                        foreach (DirectoryInfo file in fieldfiles)
                        {
                            try
                            {
                                totalfcount += Directory.EnumerateFiles(file.FullName, "*.*", SearchOption.AllDirectories).Count();
                            }
                            catch (Exception)
                            {
                                continue;
                            }
                        }
                    }
                    catch (Exception)
                    {
                        continue;
                    }
                }
                label21.Text = totalfcount.ToString();

                DateTime date = DateTime.Now;
                File.AppendAllText(source, "" + label21.Text + Environment.NewLine);

            }
            else
            {
                string[] line = File.ReadAllLines(source);
                bool val = int.TryParse(line[0], out totalfcount);
                label21.Text = totalfcount.ToString();
                
            }




            label1.Text = "System Name               :       " + systname;
            label2.Text = "Operating System         :       " + osname;
            string lastscan2;
            if (new FileInfo(source2).Length == 0)
            {
                lastscan2 = "Not Yet scanned";
                label3.Text = "Last Scanned On           :           " + lastscan2.ToString();
            }
            else
            {
                lastscan2 = line2[line2.Length - 7];
                label3.Text = "Last " + lastscan2.ToString();

            }


            label4.Text = "Total Files                      :       " + totalfcount.ToString();
            label5.Text = "Scan Recommended     :        YES";
            label18.Text = "Subscription Type          :        Premium";
            label16.Text = "Activation Date              :        01/01/2023";
            label17.Text = "Expiration Date              :        31/12/2023";
            label19.Text = "Publisher                       :        Mangesh Phuari and Sk.Md.Umer";

            ShieldButton.Image = Properties.Resources.main_shield_50;
            ShieldButton.Text = "SAFE";


        }

        public void pictureBox1_Click(object sender, EventArgs e)
        {

        }

        public void button1_Click(object sender, EventArgs e)
        {
            dashpanel.Show();
            fscanpanel.Show();
            folscanpanel.Hide();
            histpanel.Hide();

            string drivename;
            int drivecount = 0;

            DriveInfo[] allDrives = DriveInfo.GetDrives();
            foreach (DriveInfo d in allDrives)
            {
                drivename = d.Name;
                drivecount++;
                if (drivecount == 1)
                {
                    label6.Text = "Drive C Total Space :           " + (d.TotalSize / 1073741824) + " GB";
                    label7.Text = "Used Space              :          " + ((d.TotalSize - d.AvailableFreeSpace) / 1073741824) + " GB";
                    label8.Text = "Free Space                :          " + (d.AvailableFreeSpace / 1073741824) + " GB";

                }
                if (drivecount == 2)
                {
                    label9.Text = "Drive D Total Space :           " + (d.TotalSize / 1073741824) + " GB";
                    label10.Text = "Used Space              :          " + ((d.TotalSize - d.AvailableFreeSpace) / 1073741824) + "  GB";
                    label11.Text = "Free Space                :          " + (d.AvailableFreeSpace / 1073741824) + "  GB";
                }
                if (drivecount == 3)
                {
                    label12.Text = "Drive E Total Space :           " + (d.TotalSize / 1073741824) + " GB";
                    label13.Text = "Used Space              :          " + ((d.TotalSize - d.AvailableFreeSpace) / 1073741824) + "  GB";
                    label14.Text = "Free Space                :          " + (d.AvailableFreeSpace / 1073741824) + "  GB";
                }
                else
                {
                    label12.Hide();
                    label13.Hide();
                    label14.Hide();
                }


            }



        }

        public void button4_Click(object sender, EventArgs e)
        {
            dashpanel.Show();
            fscanpanel.Hide();
            folscanpanel.Hide();
            histpanel.Hide();
        }

        public void folscanbutton_Click(object sender, EventArgs e)
        {
            dashpanel.Show();
            histpanel.Hide();
            folscanpanel.Show();
            fscanpanel.Show();

            textBox1.Text = "";

        }

        public void histbutton_Click(object sender, EventArgs e)
        {

            dashpanel.Show();
            fscanpanel.Show();
            folscanpanel.Show();
            histpanel.Show();
            string source3 = "C:\\Mangesh\\final exam project\\project phase 1\\project phase 1\\database\\Records.txt";
            string[] line4 = File.ReadAllLines(source3);

            if (line4.Length > 0)
            {
                label22.Text = line4[line4.Length - 7];
                label23.Text = line4[line4.Length - 6];
                label24.Text = line4[line4.Length - 5];
                label26.Text = line4[line4.Length - 4];
                label27.Text = line4[line4.Length - 3];
            }
            else
            {
                label22.Text = "Empty Record";
                label23.Text = "Empty Record";
                label24.Text = "Empty Record";
                label26.Text = "Empty Record";
                label27.Text = "Empty Record";
            }
            if (line4.Length > 9)
            {
                label28.Text = line4[line4.Length - 14];
                label29.Text = line4[line4.Length - 13];
                label30.Text = line4[line4.Length - 12];
                label31.Text = line4[line4.Length - 11];
                label32.Text = line4[line4.Length - 10];
            }
            else
            {
                label28.Text = "Empty Record";
                label29.Text = "Empty Record";
                label30.Text = "Empty Record";
                label31.Text = "Empty Record";
                label32.Text = "Empty Record";
            }
            if (line4.Length > 17)
            {

                label33.Text = line4[line4.Length - 21];
                label34.Text = line4[line4.Length - 20];
                label35.Text = line4[line4.Length - 19];
                label36.Text = line4[line4.Length - 18];
                label37.Text = line4[line4.Length - 17];
            }
            else
            {

                label33.Text = "Empty Record";
                label34.Text = "Empty Record";
                label35.Text = "Empty Record";
                label36.Text = "Empty Record";
                label37.Text = "Empty Record";
            }



        }

        public void dashpanel_Paint(object sender, PaintEventArgs e)
        {

        }

        public void label1_Click(object sender, EventArgs e)
        {

        }

        public void label3_Click(object sender, EventArgs e)
        {

        }

        public void button2_Click(object sender, EventArgs e)
        {
            textBox1.Text = "Quick Scan";
            Form2 f2 = new Form2(textBox1.Text, label21.Text);
            f2.Show();
        }

        public void button1_Click_1(object sender, EventArgs e)
        {

        }

        public void label10_Click(object sender, EventArgs e)
        {

        }

        public void fscanpanel_Paint(object sender, PaintEventArgs e)
        {

        }

        public void label13_Click(object sender, EventArgs e)
        {

        }

        public void label11_Click(object sender, EventArgs e)
        {

        }

        public void label18_Click(object sender, EventArgs e)
        {

        }

        public void openFileDialog1_FileOk(object sender, System.ComponentModel.CancelEventArgs e)
        {

        }

        public void folscanpanel_Paint(object sender, PaintEventArgs e)
        {

        }

        public void pictureBox2_Click(object sender, EventArgs e)
        {

        }

        public void ShieldButton_Click(object sender, EventArgs e)
        {


        }

        public void SelectaFolder_Click(object sender, EventArgs e)
        {
            FolderBrowserDialog folder = new FolderBrowserDialog();
            if (folder.ShowDialog() == System.Windows.Forms.DialogResult.OK)
            {
                textBox1.Text = folder.SelectedPath;

            }
            else
            {
                textBox1.Text = "";
            }

        }

        public void SelectaFile_Click(object sender, EventArgs e)
        {
            OpenFileDialog openFileDialog1 = new OpenFileDialog();
            openFileDialog1.Title = "Select File";
            openFileDialog1.InitialDirectory = @"C:\";
            openFileDialog1.Filter = "All files (*.*)|*.*|Text File (*.txt)|*.txt";
            openFileDialog1.FilterIndex = 2;
            openFileDialog1.ShowDialog();
            if (openFileDialog1.FileName != "")
            {
                textBox1.Text = openFileDialog1.FileName;
            }
            else
            {
                textBox1.Text = "You didn't select file";
            }
        }

        public void button1_Click_2(object sender, EventArgs e)
        {
            textBox1.Text = "";
        }

        public void ScanButton_Click(object sender, EventArgs e)
        {
            if (File.Exists(textBox1.Text))
            {
                label4.Text = "1";
            }
            else
            {


                label4.Text = (Directory.EnumerateFiles(textBox1.Text, "*.*", SearchOption.AllDirectories).Count()).ToString();


            }
            Form2 f2 = new Form2(textBox1.Text, label4.Text);
            f2.Show();

        }

        private void textBox2_TextChanged(object sender, EventArgs e)
        {

        }

        public void textBox1_TextChanged(object sender, EventArgs e)
        {

        }

        private void Dscanbutton_Click(object sender, EventArgs e)
        {
            textBox1.Text = "Deep Scan";
            Form2 f2 = new Form2(textBox1.Text, label21.Text);
            f2.Show();
        }
    }
}