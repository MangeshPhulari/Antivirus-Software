using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Security.Cryptography;
using System.Security.Policy;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using static System.Windows.Forms.VisualStyles.VisualStyleElement;

namespace project_phase_1
{
    public partial class Form2 : Form
    {
        public Form2(string message, string tfcount)
        {
            InitializeComponent();

            label1.Text = message;
            label6.Text = message;
            label9.Text = message;
            label8.Text = tfcount;
        }


        public void textBox1_TextChanged(object sender, EventArgs e)
        {

        }

        public static void label1_Click(object sender, EventArgs e)
        {

        }

        public void Form2_Load(object sender, EventArgs e)
        {
            button6.Visible = false;
        }

        public void button1_Click(object sender, EventArgs e)
        {

        }


        public void ProcessDirectory(string targetDirectory)
        {

            // Process the list of files found in the directory.
            string[] fileEntries = Directory.GetFiles(targetDirectory);
            foreach (string fileName in fileEntries)
            {
                ProcessFile(fileName);
            }


            // Recurse into subdirectories of this directory.
            string[] subdirectoryEntries = Directory.GetDirectories(targetDirectory);
            foreach (string subdirectory in subdirectoryEntries)
                ProcessDirectory(subdirectory);
        }

        // Insert logic for processing found files here.

        public void ProcessFile(string path)
        {
            string box;
            byte[] fileBytes = File.ReadAllBytes(path);
            long flength = fileBytes.LongLength;
            //******************************************************************************************************************
            if (label1.Text == "Quick Scan")
            {
                box = BytesToString(GetHashMd5(path));
                using (FileStream file = File.OpenRead(@"C:\Mangesh\final exam project\project phase 1\project phase 1\database\\full_md5.txt"))
                {
                    using (StreamReader sr = new StreamReader(file))
                    {
                        while (!sr.EndOfStream)
                        {
                            string line = sr.ReadLine().ToLower();

                            if (line.Equals(box))
                            {
                                using (StreamWriter writer = new StreamWriter(@"C:\Mangesh\final exam project\project phase 1\project phase 1\database\\vcount.txt"))
                                {
                                    writer.WriteLine(path);
                                }
                            }

                        }
                    }
                }
                //******************************************************************************************************************

                if (flength < 101 && flength > 50)
                {/*
                    byte[] multibyte1 = new byte[50];
                    byte[] multibyte2 = new byte[50];
                    int flag1 = 1;
                    int flag2 = 0;
                    int flag3 = 0;
                    foreach (byte b in fileBytes)
                    {
                        if (flag1 <= 20)
                        {

                            multibyte1[flag2] = b;
                            flag2++;

                            string MD5Hash = CalculateMD5(multibyte1).ToLower();

                            using (FileStream file = File.OpenRead(@"C:\\Users\\DELL\\Desktop\\project phase 1\\project phase 1\\database\\full_md5.txt"))
                            {
                                using (StreamReader sr = new StreamReader(file))
                                {
                                    while (!sr.EndOfStream)
                                    {
                                        string line = sr.ReadLine().ToLower();

                                        if (line.Equals(MD5Hash))
                                        {
                                            using (StreamWriter writer = new StreamWriter(@"C:\\Users\\DELL\\Desktop\\project phase 1\\project phase 1\\database\\vcount.txt"))
                                            {
                                                writer.WriteLine(path);
                                            }
                                        }

                                    }
                                }
                            }
                        }
                        else if (flag1 >= (fileBytes.Length - 19))
                        {
                            multibyte2[flag3] = b;
                            flag3++;

                            string MD5Hash = CalculateMD5(multibyte2).ToLower();

                            using (FileStream file = File.OpenRead(@"C:\\Users\\DELL\\Desktop\\project phase 1\\project phase 1\\database\\full_md5.txt"))
                            {
                                using (StreamReader sr = new StreamReader(file))
                                {
                                    while (!sr.EndOfStream)
                                    {
                                        string line = sr.ReadLine().ToLower();

                                        if (line.Equals(MD5Hash))
                                        {
                                            using (StreamWriter writer = new StreamWriter(@"C:\\Users\\DELL\\Desktop\\project phase 1\\project phase 1\\database\\vcount.txt"))
                                            {
                                                writer.WriteLine(path);
                                            }
                                        }

                                    }
                                }
                            }
                        }
                        flag1++;
                    }
                */
                }
                //******************************************************************************************************************
                else if (flength < 1001 && flength > 101)
                {
                    byte[] multibyte1 = new byte[110];
                    byte[] multibyte2 = new byte[110];
                    int flag1 = 1;
                    int flag2 = 0;
                    int flag3 = 0;
                    foreach (byte b in fileBytes)
                    {
                        if (flag1 <= 80)
                        {

                            multibyte1[flag2] = b;
                            flag2++;

                            string MD5Hash = CalculateMD5(multibyte1).ToLower();

                            using (FileStream file = File.OpenRead(@"C:\Mangesh\final exam project\project phase 1\project phase 1\database\\full_md5.txt"))
                            {
                                using (StreamReader sr = new StreamReader(file))
                                {
                                    while (!sr.EndOfStream)
                                    {
                                        string line = sr.ReadLine().ToLower();

                                        if (line.Equals(MD5Hash))
                                        {
                                            using (StreamWriter writer = new StreamWriter(@"C:\Mangesh\final exam project\project phase 1\project phase 1\database\\vcount.txt"))
                                            {
                                                writer.WriteLine(path);
                                            }
                                        }

                                    }
                                }
                            }
                        }
                        else if (flag1 >= (fileBytes.Length - 79))
                        {
                            multibyte2[flag3] = b;
                            flag3++;

                            string MD5Hash = CalculateMD5(multibyte2).ToLower();

                            using (FileStream file = File.OpenRead(@"C:\Mangesh\final exam project\project phase 1\project phase 1\database\\full_md5.txt"))
                            {
                                using (StreamReader sr = new StreamReader(file))
                                {
                                    while (!sr.EndOfStream)
                                    {
                                        string line = sr.ReadLine().ToLower();

                                        if (line.Equals(MD5Hash))
                                        {
                                            using (StreamWriter writer = new StreamWriter(@"C:\Mangesh\final exam project\project phase 1\project phase 1\database\\vcount.txt"))
                                            {
                                                writer.WriteLine(path);
                                            }
                                        }

                                    }
                                }
                            }
                        }
                        flag1++;
                    }

                }
                //******************************************************************************************************************

                else if (flength > 1001 && flength < 10001)
                {
                    byte[] multibyte1 = new byte[210];
                    byte[] multibyte2 = new byte[210];
                    int flag1 = 1;
                    int flag2 = 0;
                    int flag3 = 0;

                    foreach (byte b in fileBytes)
                    {
                        if (flag1 <= 200)
                        {

                            multibyte1[flag2] = b;
                            flag2++;
                        }
                        if (flag1 % 10 == 0 && flag2 < 201)
                        {
                            string MD5Hash = CalculateMD5(multibyte1).ToLower();

                            using (FileStream file = File.OpenRead(@"C:\Mangesh\final exam project\project phase 1\project phase 1\database\\full_md5.txt"))
                            {
                                using (StreamReader sr = new StreamReader(file))
                                {
                                    while (!sr.EndOfStream)
                                    {
                                        string line = sr.ReadLine().ToLower();

                                        if (line.Equals(MD5Hash))
                                        {
                                            using (StreamWriter writer = new StreamWriter(@"C:\Mangesh\final exam project\project phase 1\project phase 1\database\\vcount.txt"))
                                            {
                                                writer.WriteLine(path);
                                            }
                                        }

                                    }
                                }
                            }
                        }

                        if (flag1 >= (fileBytes.Length - 199))
                        {
                            multibyte2[flag3] = b;
                            flag3++;

                        }
                        if (flag1 % 10 == 0 && flag3 < 201)
                        {
                            string MD5Hash = CalculateMD5(multibyte2).ToLower();

                            using (FileStream file = File.OpenRead(@"C:\Mangesh\final exam project\project phase 1\project phase 1\database\\full_md5.txt"))
                            {
                                using (StreamReader sr = new StreamReader(file))
                                {
                                    while (!sr.EndOfStream)
                                    {
                                        string line = sr.ReadLine().ToLower();

                                        if (line.Equals(MD5Hash))
                                        {
                                            using (StreamWriter writer = new StreamWriter(@"C:\Mangesh\final exam project\project phase 1\project phase 1\database\\vcount.txt"))
                                            {
                                                writer.WriteLine(path);
                                            }
                                        }

                                    }
                                }
                            }
                        }
                        flag1++;
                    }

                }
                //******************************************************************************************************************
                /*else if (flength > 10001 && flength < 100001)
                {
                    byte[] multibyte1 = new byte[1024];
                    byte[] multibyte2 = new byte[1024];
                    int flag1 = 1;
                    int flag2 = 0;
                    int flag3 = 0;

                    foreach (byte b in fileBytes)
                    {
                        if (flag1 <= 1000)
                        {

                            multibyte1[flag2] = b;
                            flag2++;
                        }
                        if (flag1 % 1000 == 0 && flag2 < 1001)
                        {
                            string MD5Hash = CalculateMD5(multibyte1).ToLower();

                            using (FileStream file = File.OpenRead(@"C:\\Users\\DELL\\Desktop\\project phase 1\\project phase 1\\database\\full_md5.txt"))
                            {
                                using (StreamReader sr = new StreamReader(file))
                                {
                                    while (!sr.EndOfStream)
                                    {
                                        string line = sr.ReadLine().ToLower();

                                        if (line.Equals(MD5Hash))
                                        {
                                            using (StreamWriter writer = new StreamWriter(@"C:\\Users\\DELL\\Desktop\\project phase 1\\project phase 1\\database\\vcount.txt"))
                                            {
                                                writer.WriteLine(path);
                                            }
                                        }

                                    }
                                }
                            }
                        }

                        if (flag1 >= (fileBytes.Length - 999))
                        {
                            multibyte2[flag3] = b;
                            flag3++;

                        }
                        if (flag1 % 1000 == 0 && flag3 < 1001)
                        {
                            string MD5Hash = CalculateMD5(multibyte2).ToLower();

                            using (FileStream file = File.OpenRead(@"C:\\Users\\DELL\\Desktop\\project phase 1\\project phase 1\\database\\full_md5.txt"))
                            {
                                using (StreamReader sr = new StreamReader(file))
                                {
                                    while (!sr.EndOfStream)
                                    {
                                        string line = sr.ReadLine().ToLower();

                                        if (line.Equals(MD5Hash))
                                        {
                                            using (StreamWriter writer = new StreamWriter(@"C:\\Users\\DELL\\Desktop\\project phase 1\\project phase 1\\database\\vcount.txt"))
                                            {
                                                writer.WriteLine(path);
                                            }
                                        }

                                    }
                                }
                            }
                        }
                        flag1++;
                    }

                }*/
                //******************************************************************************************************************
                /*
                 else if (flength > 100001 && flength < 5000001)
                 {
                     byte[] multibyte1 = new byte[30100];
                     byte[] multibyte2 = new byte[30100];
                     int flag1 = 1;
                     int flag2 = 0;
                     int flag3 = 0;

                     foreach (byte b in fileBytes)
                     {
                         if (flag1 <= 30000)
                         {

                             multibyte1[flag2] = b;
                             flag2++;
                         }
                         if (flag1 % 10000 == 0 && flag2 < 30001)
                         {
                             string MD5Hash = CalculateMD5(multibyte1).ToLower();

                             using (FileStream file = File.OpenRead(@"C:\\Users\\DELL\\Desktop\\project phase 1\\project phase 1\\database\\full_md5.txt"))
                             {
                                 using (StreamReader sr = new StreamReader(file))
                                 {
                                     while (!sr.EndOfStream)
                                     {
                                         string line = sr.ReadLine().ToLower();

                                         if (line.Equals(MD5Hash))
                                         {
                                             using (StreamWriter writer = new StreamWriter(@"C:\\Users\\DELL\\Desktop\\project phase 1\\project phase 1\\database\\vcount.txt"))
                                             {
                                                 writer.WriteLine(path);
                                             }
                                         }

                                     }
                                 }
                             }
                         }

                         if (flag1 >= (fileBytes.Length - 29999))
                         {
                             multibyte2[flag3] = b;
                             flag3++;

                         }
                         if (flag1 % 10000 == 0 && flag3 < 30001)
                         {
                             string MD5Hash = CalculateMD5(multibyte2).ToLower();

                             using (FileStream file = File.OpenRead(@"C:\\Users\\DELL\\Desktop\\project phase 1\\project phase 1\\database\\full_md5.txt"))
                             {
                                 using (StreamReader sr = new StreamReader(file))
                                 {
                                     while (!sr.EndOfStream)
                                     {
                                         string line = sr.ReadLine().ToLower();

                                         if (line.Equals(MD5Hash))
                                         {
                                             using (StreamWriter writer = new StreamWriter(@"C:\\Users\\DELL\\Desktop\\project phase 1\\project phase 1\\database\\vcount.txt"))
                                             {
                                                 writer.WriteLine(path);
                                             }
                                         }

                                     }
                                 }
                             }
                         }
                         flag1++;
                     }

                 }*/
                //******************************************************************************************************************
                /*
                    else if (flength > 10000001 && flength < 100000001)
                    {
                        byte[] multibyte1 = new byte[5000100];
                        byte[] multibyte2 = new byte[5000100];
                        int flag1 = 1;
                        int flag2 = 0;
                        int flag3 = 0;

                        foreach (byte b in fileBytes)
                        {
                            if (flag1 <= 5000000)
                            {

                                multibyte1[flag2] = b;
                                flag2++;
                            }
                            if (flag1 % 100000 == 0 && flag2 < 5000001)
                            {
                                string MD5Hash = CalculateMD5(multibyte1).ToLower();

                                using (FileStream file = File.OpenRead(@"C:\\Users\\DELL\\Desktop\\project phase 1\\project phase 1\\database\\full_md5.txt"))
                                {
                                    using (StreamReader sr = new StreamReader(file))
                                    {
                                        while (!sr.EndOfStream)
                                        {
                                            string line = sr.ReadLine().ToLower();

                                            if (line.Equals(MD5Hash))
                                            {
                                                using (StreamWriter writer = new StreamWriter(@"C:\\Users\\DELL\\Desktop\\project phase 1\\project phase 1\\database\\vcount.txt"))
                                                {
                                                    writer.WriteLine(path);
                                                }
                                            }

                                        }
                                    }
                                }
                            }

                            if (flag1 >= (fileBytes.Length - 4999999))
                            {
                                multibyte2[flag3] = b;
                                flag3++;

                            }
                            if (flag1 % 100000 == 0 && flag3 < 5000001)
                            {
                                string MD5Hash = CalculateMD5(multibyte2).ToLower();

                                using (FileStream file = File.OpenRead(@"C:\\Users\\DELL\\Desktop\\project phase 1\\project phase 1\\database\\full_md5.txt"))
                                {
                                    using (StreamReader sr = new StreamReader(file))
                                    {
                                        while (!sr.EndOfStream)
                                        {
                                            string line = sr.ReadLine().ToLower();

                                            if (line.Equals(MD5Hash))
                                            {
                                                using (StreamWriter writer = new StreamWriter(@"C:\\Users\\DELL\\Desktop\\project phase 1\\project phase 1\\database\\vcount.txt"))
                                                {
                                                    writer.WriteLine(path);
                                                }
                                            }

                                        }
                                    }
                                }
                            }
                            flag1++;
                        }
                    }*/

            }
            //******************************************************************************************************************
            //******************************************************************************************************************
            else if (label1.Text == "Deep Scan")
            {

                box = BytesToString(GetHashMd5(path));
                using (FileStream file = File.OpenRead(@"C:\Mangesh\final exam project\project phase 1\project phase 1\database\\full_md5.txt"))
                {
                    using (StreamReader sr = new StreamReader(file))
                    {
                        while (!sr.EndOfStream)
                        {
                            string line = sr.ReadLine().ToLower();

                            if (line.Equals(box))
                            {
                                using (StreamWriter writer = new StreamWriter(@"C:\Mangesh\final exam project\project phase 1\project phase 1\database\\vcount.txt"))
                                {
                                    writer.WriteLine(path);
                                }
                            }

                        }
                    }
                }
                //******************************************************************************************************************

                if (flength < 101 && flength > 50)
                {
                    byte[] multibyte1 = new byte[50];
                    byte[] multibyte2 = new byte[50];
                    int flag1 = 1;
                    int flag2 = 0;
                    int flag3 = 0;
                    foreach (byte b in fileBytes)
                    {
                        if (flag1 <= 20)
                        {

                            multibyte1[flag2] = b;
                            flag2++;

                            string MD5Hash = CalculateMD5(multibyte1).ToLower();

                            using (FileStream file = File.OpenRead(@"C:\Mangesh\final exam project\project phase 1\project phase 1\database\\full_md5.txt"))
                            {
                                using (StreamReader sr = new StreamReader(file))
                                {
                                    while (!sr.EndOfStream)
                                    {
                                        string line = sr.ReadLine().ToLower();

                                        if (line.Equals(MD5Hash))
                                        {
                                            using (StreamWriter writer = new StreamWriter(@"C:\Mangesh\final exam project\project phase 1\project phase 1\database\\vcount.txt"))
                                            {
                                                writer.WriteLine(path);
                                            }
                                        }

                                    }
                                }
                            }
                        }
                        else if (flag1 >= (fileBytes.Length - 19))
                        {
                            multibyte2[flag3] = b;
                            flag3++;

                            string MD5Hash = CalculateMD5(multibyte2).ToLower();

                            using (FileStream file = File.OpenRead(@"C:\Mangesh\final exam project\project phase 1\project phase 1\database\\full_md5.txt"))
                            {
                                using (StreamReader sr = new StreamReader(file))
                                {
                                    while (!sr.EndOfStream)
                                    {
                                        string line = sr.ReadLine().ToLower();

                                        if (line.Equals(MD5Hash))
                                        {
                                            using (StreamWriter writer = new StreamWriter(@"C:\Mangesh\final exam project\project phase 1\project phase 1\database\\vcount.txt"))
                                            {
                                                writer.WriteLine(path);
                                            }
                                        }

                                    }
                                }
                            }
                        }
                        flag1++;
                    }
                }
                //******************************************************************************************************************
                else if (flength < 1001 && flength > 101)
                {
                    byte[] multibyte1 = new byte[110];
                    byte[] multibyte2 = new byte[110];
                    int flag1 = 1;
                    int flag2 = 0;
                    int flag3 = 0;
                    foreach (byte b in fileBytes)
                    {
                        if (flag1 <= 40)
                        {

                            multibyte1[flag2] = b;
                            flag2++;

                            string MD5Hash = CalculateMD5(multibyte1).ToLower();

                            using (FileStream file = File.OpenRead(@"C:\Mangesh\final exam project\project phase 1\project phase 1\database\\full_md5.txt"))
                            {
                                using (StreamReader sr = new StreamReader(file))
                                {
                                    while (!sr.EndOfStream)
                                    {
                                        string line = sr.ReadLine().ToLower();

                                        if (line.Equals(MD5Hash))
                                        {
                                            using (StreamWriter writer = new StreamWriter(@"C:\Mangesh\final exam project\project phase 1\project phase 1\database\\vcount.txt"))
                                            {
                                                writer.WriteLine(path);
                                            }
                                        }

                                    }
                                }
                            }
                        }
                        else if (flag1 >= (fileBytes.Length - 39))
                        {
                            multibyte2[flag3] = b;
                            flag3++;

                            string MD5Hash = CalculateMD5(multibyte2).ToLower();

                            using (FileStream file = File.OpenRead(@"C:\Mangesh\final exam project\project phase 1\project phase 1\database\\full_md5.txt"))
                            {
                                using (StreamReader sr = new StreamReader(file))
                                {
                                    while (!sr.EndOfStream)
                                    {
                                        string line = sr.ReadLine().ToLower();

                                        if (line.Equals(MD5Hash))
                                        {
                                            using (StreamWriter writer = new StreamWriter(@"C:\Mangesh\final exam project\project phase 1\project phase 1\database\\vcount.txt"))
                                            {
                                                writer.WriteLine(path);
                                            }
                                        }

                                    }
                                }
                            }
                        }
                        flag1++;
                    }

                }
                //******************************************************************************************************************

                else if (flength > 1001 && flength < 10001)
                {
                    byte[] multibyte1 = new byte[210];
                    byte[] multibyte2 = new byte[210];
                    int flag1 = 1;
                    int flag2 = 0;
                    int flag3 = 0;

                    foreach (byte b in fileBytes)
                    {
                        if (flag1 <= 200)
                        {

                            multibyte1[flag2] = b;
                            flag2++;
                        }
                        if (flag1 % 10 == 0 && flag2 < 201)
                        {
                            string MD5Hash = CalculateMD5(multibyte1).ToLower();

                            using (FileStream file = File.OpenRead(@"C:\Mangesh\final exam project\project phase 1\project phase 1\database\\full_md5.txt"))
                            {
                                using (StreamReader sr = new StreamReader(file))
                                {
                                    while (!sr.EndOfStream)
                                    {
                                        string line = sr.ReadLine().ToLower();

                                        if (line.Equals(MD5Hash))
                                        {
                                            using (StreamWriter writer = new StreamWriter(@"C:\Mangesh\final exam project\project phase 1\project phase 1\database\\vcount.txt"))
                                            {
                                                writer.WriteLine(path);
                                            }
                                        }

                                    }
                                }
                            }
                        }

                        if (flag1 >= (fileBytes.Length - 199))
                        {
                            multibyte2[flag3] = b;
                            flag3++;

                        }
                        if (flag1 % 10 == 0 && flag3 < 201)
                        {
                            string MD5Hash = CalculateMD5(multibyte2).ToLower();

                            using (FileStream file = File.OpenRead(@"C:\Mangesh\final exam project\project phase 1\project phase 1\database\\full_md5.txt"))
                            {
                                using (StreamReader sr = new StreamReader(file))
                                {
                                    while (!sr.EndOfStream)
                                    {
                                        string line = sr.ReadLine().ToLower();

                                        if (line.Equals(MD5Hash))
                                        {
                                            using (StreamWriter writer = new StreamWriter(@"C:\Mangesh\final exam project\project phase 1\project phase 1\database\\vcount.txt"))
                                            {
                                                writer.WriteLine(path);
                                            }
                                        }

                                    }
                                }
                            }
                        }
                        flag1++;
                    }

                }
                //******************************************************************************************************************
                else if (flength > 10001 && flength < 100001)
                {
                    byte[] multibyte1 = new byte[1024];
                    byte[] multibyte2 = new byte[1024];
                    int flag1 = 1;
                    int flag2 = 0;
                    int flag3 = 0;

                    foreach (byte b in fileBytes)
                    {
                        if (flag1 <= 1000)
                        {

                            multibyte1[flag2] = b;
                            flag2++;
                        }
                        if (flag1 % 1000 == 0 && flag2 < 1001)
                        {
                            string MD5Hash = CalculateMD5(multibyte1).ToLower();

                            using (FileStream file = File.OpenRead(@"C:\Mangesh\final exam project\project phase 1\project phase 1\database\\full_md5.txt"))
                            {
                                using (StreamReader sr = new StreamReader(file))
                                {
                                    while (!sr.EndOfStream)
                                    {
                                        string line = sr.ReadLine().ToLower();

                                        if (line.Equals(MD5Hash))
                                        {
                                            using (StreamWriter writer = new StreamWriter(@"C:\Mangesh\final exam project\project phase 1\project phase 1\database\\vcount.txt"))
                                            {
                                                writer.WriteLine(path);
                                            }
                                        }

                                    }
                                }
                            }
                        }

                        if (flag1 >= (fileBytes.Length - 999))
                        {
                            multibyte2[flag3] = b;
                            flag3++;

                        }
                        if (flag1 % 1000 == 0 && flag3 < 1001)
                        {
                            string MD5Hash = CalculateMD5(multibyte2).ToLower();

                            using (FileStream file = File.OpenRead(@"C:\Mangesh\final exam project\project phase 1\project phase 1\database\\full_md5.txt"))
                            {
                                using (StreamReader sr = new StreamReader(file))
                                {
                                    while (!sr.EndOfStream)
                                    {
                                        string line = sr.ReadLine().ToLower();

                                        if (line.Equals(MD5Hash))
                                        {
                                            using (StreamWriter writer = new StreamWriter(@"C:\Mangesh\final exam project\project phase 1\project phase 1\database\\vcount.txt"))
                                            {
                                                writer.WriteLine(path);
                                            }
                                        }

                                    }
                                }
                            }
                        }
                        flag1++;
                    }

                }



            }
            else
            {

                box = BytesToString(GetHashMd5(path));

                using (FileStream file = File.OpenRead(@"C:\Mangesh\final exam project\project phase 1\project phase 1\database\\full_md5.txt"))
                {
                    using (StreamReader sr = new StreamReader(file))
                    {
                        while (!sr.EndOfStream)
                        {
                            string line = sr.ReadLine().ToLower();

                            if (line.Equals(box))
                            {
                                using (StreamWriter writer = new StreamWriter(@"C:\Mangesh\final exam project\project phase 1\project phase 1\database\\vcount.txt"))
                                {
                                    writer.WriteLine(path);
                                }
                            }

                        }
                    }
                }

                box = BytesToString(GetHashSha256(path));
                using (FileStream file = File.OpenRead(@"C:\Mangesh\final exam project\project phase 1\project phase 1\database\\full_sha256.txt"))
                {
                    using (StreamReader sr = new StreamReader(file))
                    {
                        while (!sr.EndOfStream)
                        {
                            string line = sr.ReadLine().ToLower();

                            if (line.Equals(box))
                            {
                                using (StreamWriter writer = new StreamWriter(@"C:\Mangesh\final exam project\project phase 1\project phase 1\database\\vcount.txt"))
                                {
                                    writer.WriteLine(path);
                                }
                            }

                        }
                    }
                }

                box = BytesToString(GetHashSha1(path));
                using (FileStream file = File.OpenRead(@"C:\Mangesh\final exam project\project phase 1\project phase 1\database\\full_sha1.txt"))
                {
                    using (StreamReader sr = new StreamReader(file))
                    {
                        while (!sr.EndOfStream)
                        {
                            string line = sr.ReadLine().ToLower();

                            if (line.Equals(box))
                            {
                                using (StreamWriter writer = new StreamWriter(@"C:\Mangesh\final exam project\project phase 1\project phase 1\database\\vcount.txt"))
                                {
                                    writer.WriteLine(path);
                                }
                            }

                        }
                    }
                }

                //******************************************************************************************************************

                if (flength < 101 && flength > 50)
                {
                    byte[] multibyte1 = new byte[50];
                    byte[] multibyte2 = new byte[50];
                    int flag1 = 1;
                    int flag2 = 0;
                    int flag3 = 0;
                    foreach (byte b in fileBytes)
                    {
                        if (flag1 <= 20)
                        {

                            multibyte1[flag2] = b;
                            flag2++;

                            string MD5Hash = CalculateMD5(multibyte1).ToLower();
                            string sha256Hash = CalculateSHA256(multibyte1).ToLower();
                            string sha1Hash = CalculateSHA1(multibyte1).ToLower();

                            using (FileStream file = File.OpenRead(@"C:\Mangesh\final exam project\project phase 1\project phase 1\database\\full_md5.txt"))
                            {
                                using (StreamReader sr = new StreamReader(file))
                                {
                                    while (!sr.EndOfStream)
                                    {
                                        string line = sr.ReadLine().ToLower();

                                        if (line.Equals(MD5Hash))
                                        {
                                            using (StreamWriter writer = new StreamWriter(@"C:\Mangesh\final exam project\project phase 1\project phase 1\database\\vcount.txt", true))
                                            {
                                                writer.Write(path + Environment.NewLine);

                                            }
                                        }

                                    }
                                }
                            }
                        }
                        else if (flag1 >= (fileBytes.Length - 19))
                        {
                            multibyte2[flag3] = b;
                            flag3++;

                            string MD5Hash = CalculateMD5(multibyte2).ToLower();
                            string sha256Hash = CalculateSHA256(multibyte1).ToLower();
                            string sha1Hash = CalculateSHA1(multibyte1).ToLower();

                            using (FileStream file = File.OpenRead(@"C:\Mangesh\final exam project\project phase 1\project phase 1\database\\full_md5.txt"))
                            {
                                using (StreamReader sr = new StreamReader(file))
                                {
                                    while (!sr.EndOfStream)
                                    {
                                        string line = sr.ReadLine().ToLower();

                                        if (line.Equals(sha1Hash) || line.Equals(sha256Hash) || line.Equals(MD5Hash))
                                        {
                                            using (StreamWriter writer = new StreamWriter(@"C:\Mangesh\final exam project\project phase 1\project phase 1\database\\vcount.txt"))
                                            {
                                                writer.WriteLine(path);
                                            }
                                        }

                                    }
                                }
                            }
                        }
                        flag1++;
                    }
                }
                else if (flength < 1001 && flength > 101)
                {
                    byte[] multibyte1 = new byte[110];
                    byte[] multibyte2 = new byte[110];
                    int flag1 = 1;
                    int flag2 = 0;
                    int flag3 = 0;
                    foreach (byte b in fileBytes)
                    {
                        if (flag1 <= 40)
                        {

                            multibyte1[flag2] = b;
                            flag2++;

                            string MD5Hash = CalculateMD5(multibyte1).ToLower();
                            string sha256Hash = CalculateSHA256(multibyte1).ToLower();
                            string sha1Hash = CalculateSHA1(multibyte1).ToLower();

                            using (FileStream file = File.OpenRead(@"C:\Mangesh\final exam project\project phase 1\project phase 1\database\\full_md5.txt"))
                            {
                                using (StreamReader sr = new StreamReader(file))
                                {
                                    while (!sr.EndOfStream)
                                    {
                                        string line = sr.ReadLine().ToLower();

                                        if (line.Equals(MD5Hash))
                                        {
                                            using (StreamWriter writer = new StreamWriter(@"C:\Mangesh\final exam project\project phase 1\project phase 1\database\\vcount.txt"))
                                            {
                                                writer.WriteLine(path);
                                            }
                                        }

                                    }
                                }
                            }
                        }
                        else if (flag1 >= (fileBytes.Length - 39))
                        {
                            multibyte2[flag3] = b;
                            flag3++;

                            string MD5Hash = CalculateMD5(multibyte2).ToLower();
                            string sha256Hash = CalculateSHA256(multibyte1).ToLower();
                            string sha1Hash = CalculateSHA1(multibyte1).ToLower();

                            using (FileStream file = File.OpenRead(@"C:\Mangesh\final exam project\project phase 1\project phase 1\database\\full_md5.txt"))
                            {
                                using (StreamReader sr = new StreamReader(file))
                                {
                                    while (!sr.EndOfStream)
                                    {
                                        string line = sr.ReadLine().ToLower();

                                        if (line.Equals(sha1Hash) || line.Equals(sha256Hash) || line.Equals(MD5Hash))
                                        {
                                            using (StreamWriter writer = new StreamWriter(@"C:\Mangesh\final exam project\project phase 1\project phase 1\database\\vcount.txt"))
                                            {
                                                writer.WriteLine(path);
                                            }
                                        }

                                    }
                                }
                            }
                        }
                        flag1++;
                    }

                }
                else if (flength > 1001 && flength < 10001)
                {
                    byte[] multibyte1 = new byte[210];
                    byte[] multibyte2 = new byte[210];
                    int flag1 = 1;
                    int flag2 = 0;
                    int flag3 = 0;

                    foreach (byte b in fileBytes)
                    {
                        if (flag1 <= 200)
                        {

                            multibyte1[flag2] = b;
                            flag2++;
                        }
                        if (flag1 % 10 == 0 && flag2 < 201)
                        {
                            string MD5Hash = CalculateMD5(multibyte1).ToLower();
                            string sha256Hash = CalculateSHA256(multibyte1).ToLower();
                            string sha1Hash = CalculateSHA1(multibyte1).ToLower();

                            using (FileStream file = File.OpenRead(@"C:\Mangesh\final exam project\project phase 1\project phase 1\database\\full_md5.txt"))
                            {
                                using (StreamReader sr = new StreamReader(file))
                                {
                                    while (!sr.EndOfStream)
                                    {
                                        string line = sr.ReadLine().ToLower();

                                        if (line.Equals(sha1Hash) || line.Equals(sha256Hash) || line.Equals(MD5Hash))
                                        {
                                            using (StreamWriter writer = new StreamWriter(@"C:\Mangesh\final exam project\project phase 1\project phase 1\database\\vcount.txt"))
                                            {
                                                writer.WriteLine(path);
                                            }
                                        }

                                    }
                                }
                            }
                        }

                        if (flag1 >= (fileBytes.Length - 199))
                        {
                            multibyte2[flag3] = b;
                            flag3++;

                        }
                        if (flag1 % 10 == 0 && flag3 < 201)
                        {
                            string MD5Hash = CalculateMD5(multibyte2).ToLower();
                            string sha256Hash = CalculateSHA256(multibyte1).ToLower();
                            string sha1Hash = CalculateSHA1(multibyte1).ToLower();

                            using (FileStream file = File.OpenRead(@"C:\Mangesh\final exam project\project phase 1\project phase 1\database\\full_md5.txt"))
                            {
                                using (StreamReader sr = new StreamReader(file))
                                {
                                    while (!sr.EndOfStream)
                                    {
                                        string line = sr.ReadLine().ToLower();

                                        if (line.Equals(sha1Hash) || line.Equals(sha256Hash) || line.Equals(MD5Hash))
                                        {
                                            using (StreamWriter writer = new StreamWriter(@"C:\Mangesh\final exam project\project phase 1\project phase 1\database\\vcount.txt"))
                                            {
                                                writer.WriteLine(path);
                                            }
                                        }

                                    }
                                }
                            }
                        }
                        flag1++;
                    }

                }

                else if (flength > 10001 && flength < 100001)
                {
                    byte[] multibyte1 = new byte[1024];
                    byte[] multibyte2 = new byte[1024];
                    int flag1 = 1;
                    int flag2 = 0;
                    int flag3 = 0;

                    foreach (byte b in fileBytes)
                    {
                        if (flag1 <= 1000)
                        {

                            multibyte1[flag2] = b;
                            flag2++;
                        }
                        if (flag1 % 1000 == 0 && flag2 < 1001)
                        {
                            string MD5Hash = CalculateMD5(multibyte1).ToLower();
                            string sha256Hash = CalculateSHA256(multibyte1).ToLower();
                            string sha1Hash = CalculateSHA1(multibyte1).ToLower();

                            using (FileStream file = File.OpenRead(@"C:\Mangesh\final exam project\project phase 1\project phase 1\database\\full_md5.txt"))
                            {
                                using (StreamReader sr = new StreamReader(file))
                                {
                                    while (!sr.EndOfStream)
                                    {
                                        string line = sr.ReadLine().ToLower();

                                        if (line.Equals(sha1Hash) || line.Equals(sha256Hash) || line.Equals(MD5Hash))
                                        {
                                            using (StreamWriter writer = new StreamWriter(@"C:\Mangesh\final exam project\project phase 1\project phase 1\database\\vcount.txt"))
                                            {
                                                writer.WriteLine(path);
                                            }
                                        }

                                    }
                                }
                            }
                        }

                        if (flag1 >= (fileBytes.Length - 999))
                        {
                            multibyte2[flag3] = b;
                            flag3++;

                        }
                        if (flag1 % 1000 == 0 && flag3 < 1001)
                        {
                            string MD5Hash = CalculateMD5(multibyte2).ToLower();
                            string sha256Hash = CalculateSHA256(multibyte1).ToLower();
                            string sha1Hash = CalculateSHA1(multibyte1).ToLower();

                            using (FileStream file = File.OpenRead(@"C:\Mangesh\final exam project\project phase 1\project phase 1\database\\full_md5.txt"))
                            {
                                using (StreamReader sr = new StreamReader(file))
                                {
                                    while (!sr.EndOfStream)
                                    {
                                        string line = sr.ReadLine().ToLower();

                                        if (line.Equals(sha1Hash) || line.Equals(sha256Hash) || line.Equals(MD5Hash))
                                        {
                                            using (StreamWriter writer = new StreamWriter(@"C:\Mangesh\final exam project\project phase 1\project phase 1\database\\vcount.txt"))
                                            {
                                                writer.WriteLine(path);
                                            }
                                        }

                                    }
                                }
                            }
                        }
                        flag1++;
                    }

                }
                else if (flength > 100001 && flength < 5000001)
                {
                    byte[] multibyte1 = new byte[30100];
                    byte[] multibyte2 = new byte[30100];
                    int flag1 = 1;
                    int flag2 = 0;
                    int flag3 = 0;

                    foreach (byte b in fileBytes)
                    {
                        if (flag1 <= 30000)
                        {

                            multibyte1[flag2] = b;
                            flag2++;
                        }
                        if (flag1 % 10000 == 0 && flag2 < 30001)
                        {
                            string MD5Hash = CalculateMD5(multibyte1).ToLower();
                            string sha256Hash = CalculateSHA256(multibyte1).ToLower();
                            string sha1Hash = CalculateSHA1(multibyte1).ToLower();

                            using (FileStream file = File.OpenRead(@"C:\Mangesh\final exam project\project phase 1\project phase 1\database\\full_md5.txt"))
                            {
                                using (StreamReader sr = new StreamReader(file))
                                {
                                    while (!sr.EndOfStream)
                                    {
                                        string line = sr.ReadLine().ToLower();

                                        if (line.Equals(sha1Hash) || line.Equals(sha256Hash) || line.Equals(MD5Hash))
                                        {
                                            using (StreamWriter writer = new StreamWriter(@"C:\\Users\\DELL\\Desktop\\project phase 1\\project phase 1\\database\\vcount.txt"))
                                            {
                                                writer.WriteLine(path);
                                            }
                                        }

                                    }
                                }
                            }
                        }

                        if (flag1 >= (fileBytes.Length - 29999))
                        {
                            multibyte2[flag3] = b;
                            flag3++;

                        }
                        if (flag1 % 10000 == 0 && flag3 < 30001)
                        {
                            string MD5Hash = CalculateMD5(multibyte2).ToLower();
                            string sha256Hash = CalculateSHA256(multibyte1).ToLower();
                            string sha1Hash = CalculateSHA1(multibyte1).ToLower();

                            using (FileStream file = File.OpenRead(@"C:\\Users\\DELL\\Desktop\\project phase 1\\project phase 1\\database\\full_md5.txt"))
                            {
                                using (StreamReader sr = new StreamReader(file))
                                {
                                    while (!sr.EndOfStream)
                                    {
                                        string line = sr.ReadLine().ToLower();

                                        if (line.Equals(sha1Hash) || line.Equals(sha256Hash) || line.Equals(MD5Hash))
                                        {
                                            using (StreamWriter writer = new StreamWriter(@"C:\\Users\\DELL\\Desktop\\project phase 1\\project phase 1\\database\\vcount.txt"))
                                            {
                                                writer.WriteLine(path);
                                            }
                                        }

                                    }
                                }
                            }
                        }
                        flag1++;
                    }

                }
                /*
                else if (flength > 10000001 && flength < 100000001)
                {
                    byte[] multibyte1 = new byte[5000100];
                    byte[] multibyte2 = new byte[5000100];
                    int flag1 = 1;
                    int flag2 = 0;
                    int flag3 = 0;

                    foreach (byte b in fileBytes)
                    {
                        if (flag1 <= 5000000)
                        {

                            multibyte1[flag2] = b;
                            flag2++;
                        }
                        if (flag1 % 100000 == 0 && flag2 < 5000001)
                        {
                            string MD5Hash = CalculateMD5(multibyte1).ToLower();
                            string sha256Hash = CalculateSHA256(multibyte1).ToLower();
                            string sha1Hash = CalculateSHA1(multibyte1).ToLower();

                            using (FileStream file = File.OpenRead(@"C:\\Users\\DELL\\Desktop\\project phase 1\\project phase 1\\database\\full_md5.txt"))
                            {
                                using (StreamReader sr = new StreamReader(file))
                                {
                                    while (!sr.EndOfStream)
                                    {
                                        string line = sr.ReadLine().ToLower();

                                        if (line.Equals(sha1Hash) || line.Equals(sha256Hash) || line.Equals(MD5Hash))
                                        {
                                            using (StreamWriter writer = new StreamWriter(@"C:\\Users\\DELL\\Desktop\\project phase 1\\project phase 1\\database\\vcount.txt"))
                                            {
                                                writer.WriteLine(path);
                                            }
                                        }

                                    }
                                }
                            }
                        }

                        if (flag1 >= (fileBytes.Length - 4999999))
                        {
                            multibyte2[flag3] = b;
                            flag3++;

                        }
                        if (flag1 % 100000 == 0 && flag3 < 5000001)
                        {
                            string MD5Hash = CalculateMD5(multibyte2).ToLower();
                            string sha256Hash = CalculateSHA256(multibyte1).ToLower();
                            string sha1Hash = CalculateSHA1(multibyte1).ToLower();

                            using (FileStream file = File.OpenRead(@"C:\\Users\\DELL\\Desktop\\project phase 1\\project phase 1\\database\\full_md5.txt"))
                            {
                                using (StreamReader sr = new StreamReader(file))
                                {
                                    while (!sr.EndOfStream)
                                    {
                                        string line = sr.ReadLine().ToLower();

                                        if (line.Equals(sha1Hash) || line.Equals(sha256Hash) || line.Equals(MD5Hash))
                                        {
                                            using (StreamWriter writer = new StreamWriter(@"C:\\Users\\DELL\\Desktop\\project phase 1\\project phase 1\\database\\vcount.txt"))
                                            {
                                                writer.WriteLine(path);
                                            }
                                        }

                                    }
                                }
                            }
                        }
                        flag1++;
                    }
                }*/

            }

            backgroundWorker1.ReportProgress(0, path);
        }

        public SHA1 Sha1 = SHA1.Create();
        public SHA256 Sha256 = SHA256.Create();
        public MD5 Md5 = MD5.Create();

        // Compute the file's hash.
        public byte[] GetHashSha1(string filename)
        {
            using (FileStream stream = File.OpenRead(filename))
            {
                return Sha1.ComputeHash(stream);
            }
        }

        public byte[] GetHashSha256(string filename)
        {
            using (FileStream stream = File.OpenRead(filename))
            {
                return Sha256.ComputeHash(stream);
            }
        }

        public byte[] GetHashMd5(string filename)
        {
            using (FileStream stream = File.OpenRead(filename))
            {
                return Md5.ComputeHash(stream);
            }
        }

        // Return a byte array as a sequence of hex values.
        public static string BytesToString(byte[] bytes)
        {
            string result = "";
            foreach (byte b in bytes) result += b.ToString("x2");
            return result;
        }

        private void button5_Click(object sender, EventArgs e)
        {
            pictureBox1.Enabled = true;
            progressBar1.Value = 0;
            int val3 = 0;
            bool val2 = int.TryParse(label8.Text, out val3);
            progressBar1.Maximum = val3;
            button5.Enabled = false;
            string filepath = "C:\\Mangesh\\final exam project\\project phase 1\\project phase 1\\database\\vcount.txt";
            File.WriteAllText(filepath, String.Empty);

            backgroundWorker1.RunWorkerAsync();

        }

        public void backgroundWorker1_DoWork(object sender, DoWorkEventArgs e)
        {

            if (File.Exists(label1.Text))
            {
                ProcessFile(label1.Text);
            }

            else if (label1.Text == "Quick Scan")
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
                            Label label7 = new Label();
                            label7.Text = file.FullName;
                            if (!(Directory.Exists(label7.Text)))
                            {
                                continue;
                            }
                            try
                            {
                                string[] filename = Directory.GetFiles(label7.Text, "*.*", SearchOption.AllDirectories);

                                foreach (string path in filename)
                                {
                                    if (File.Exists(path))
                                    {
                                        // This path is a file                        
                                        ProcessFile(path);

                                    }
                                    else if (Directory.Exists(path))
                                    {
                                        // This path is a directory
                                        ProcessDirectory(path);
                                    }
                                    else
                                    {
                                        label1.Text = path + " is not a valid file or directory";
                                    }

                                }
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
            }
            else if (label1.Text == "Deep Scan")
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
                            Label label7 = new Label();
                            label7.Text = file.FullName;
                            if (!(Directory.Exists(label7.Text)))
                            {
                                continue;
                            }
                            try
                            {
                                string[] filename = Directory.GetFiles(label7.Text, "*.*", SearchOption.AllDirectories);

                                foreach (string path in filename)
                                {
                                    if (File.Exists(path))
                                    {
                                        // This path is a file                        
                                        ProcessFile(path);

                                    }
                                    else if (Directory.Exists(path))
                                    {
                                        // This path is a directory
                                        ProcessDirectory(path);
                                    }
                                    else
                                    {
                                        label1.Text = path + " is not a valid file or directory";
                                    }

                                }
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
            }
            else if (Directory.Exists(label1.Text))
            {
                string[] filename = Directory.GetFiles(label1.Text, "*.*", SearchOption.AllDirectories);

                foreach (string path in filename)
                {
                    if (File.Exists(path))
                    {
                        // This path is a file                        
                        ProcessFile(path);

                    }
                    else if (Directory.Exists(path))
                    {
                        // This path is a directory
                        ProcessDirectory(path);
                    }
                    else
                    {
                        label1.Text = path + " is not a valid file or directory";
                    }

                }
            }
        }

        public void backgroundWorker1_ProgressChanged(object sender, ProgressChangedEventArgs e)
        {
            label6.Text = (string)e.UserState;
            progressBar1.Value += 1;
            label10.Text = progressBar1.Value.ToString();


            var linecount = File.ReadLines(@"C:\Mangesh\final exam project\project phase 1\project phase 1\database\\vcount.txt").Count();
            label11.Text = linecount.ToString();



        }

        public void backgroundWorker1_RunWorkerCompleted(object sender, RunWorkerCompletedEventArgs e)
        {
            pictureBox1.Enabled = false;
            progressBar1.Value = int.Parse(label8.Text);
            button6.Visible = true;
            button6.Enabled = false;

            MessageBox.Show("Scan Completed\nTotal Files: " + label8.Text + "\nFiles Scanned: " + label10.Text + "\nVirus Found: " + label11.Text + "\nMalware Found: " + label12.Text);
            int type = int.Parse(label8.Text);
            int vir = int.Parse(label11.Text);
            if (vir > 0)
            {
                button6.Enabled = true;
            }
            DateTime dateTime = DateTime.Now;
            string source = "C:\\Mangesh\\final exam project\\project phase 1\\project phase 1\\database\\Records.txt";

            if (type == 1)
            {
                File.AppendAllText(source, "Scanned On         :      " + dateTime + Environment.NewLine);
                File.AppendAllText(source, "Scan Type           :       File Scan" + Environment.NewLine);
                File.AppendAllText(source, "Files Scanned      :       " + label10.Text + Environment.NewLine);
                File.AppendAllText(source, "Virus Found        :       " + vir + Environment.NewLine);
                File.AppendAllText(source, "Scan Result         :       Scan Complete" + Environment.NewLine);
                File.AppendAllText(source, "" + Environment.NewLine);
                File.AppendAllText(source, "" + Environment.NewLine);
            }
            else if (label9.Text == "Quick Scan")
            {
                File.AppendAllText(source, "Scanned On         :      " + dateTime + Environment.NewLine);
                File.AppendAllText(source, "Scan Type           :       Quick Scan" + Environment.NewLine);
                File.AppendAllText(source, "Files Scanned      :       " + label10.Text + Environment.NewLine);
                File.AppendAllText(source, "Virus Found        :       " + vir + Environment.NewLine);
                File.AppendAllText(source, "Scan Result         :       Scan Complete" + Environment.NewLine);
                File.AppendAllText(source, "" + Environment.NewLine);
                File.AppendAllText(source, "" + Environment.NewLine);
            }
            else if (label9.Text == "Deep Scan")
            {
                File.AppendAllText(source, "Scanned On         :       " + dateTime + Environment.NewLine);
                File.AppendAllText(source, "Scan Type           :       Deep Scan" + Environment.NewLine);
                File.AppendAllText(source, "Files Scanned      :       " + label10.Text + Environment.NewLine);
                File.AppendAllText(source, "Virus Found        :       " + vir + Environment.NewLine);
                File.AppendAllText(source, "Scan Result         :       Scan Complete" + Environment.NewLine);
                File.AppendAllText(source, "" + Environment.NewLine);
                File.AppendAllText(source, "" + Environment.NewLine);
            }
            else
            {
                File.AppendAllText(source, "Scanned On         :      " + dateTime + Environment.NewLine);
                File.AppendAllText(source, "Scan Type           :       Folder Scan" + Environment.NewLine);
                File.AppendAllText(source, "Files Scanned      :       " + label10.Text + Environment.NewLine);
                File.AppendAllText(source, "Virus Found        :       " + vir + Environment.NewLine);
                File.AppendAllText(source, "Scan Result         :       Scan Complete" + Environment.NewLine);
                File.AppendAllText(source, "" + Environment.NewLine);
                File.AppendAllText(source, "" + Environment.NewLine);
            }




        }

        private void label1_Click_1(object sender, EventArgs e)
        {

        }

        private void label7_Click(object sender, EventArgs e)
        {

        }

        private void label3_Click(object sender, EventArgs e)
        {

        }

        private void label4_Click(object sender, EventArgs e)
        {

        }

        private void button2_Click(object sender, EventArgs e)
        {

        }

        private void label11_Click(object sender, EventArgs e)
        {

        }

        private void button4_Click(object sender, EventArgs e)
        {

        }

        static string CalculateSHA1(byte[] inputBytes)
        {
            using (SHA1 sha1 = SHA1.Create())
            {
                // Calculate the SHA-1 hash
                byte[] hashBytes = sha1.ComputeHash(inputBytes);

                // Convert the byte array to a hexadecimal string
                StringBuilder sb = new StringBuilder();
                foreach (byte b in hashBytes)
                {
                    sb.Append(b.ToString("x2"));
                }

                return sb.ToString();
            }
        }

        static string CalculateMD5(byte[] inputBytes)
        {
            using (MD5 md5 = MD5.Create())
            {
                // Calculate the SHA-1 hash
                byte[] hashBytes = md5.ComputeHash(inputBytes);

                // Convert the byte array to a hexadecimal string
                StringBuilder sb = new StringBuilder();
                foreach (byte b in hashBytes)
                {
                    sb.Append(b.ToString("x2"));
                }

                return sb.ToString();
            }
        }


        static string CalculateSHA256(byte[] inputBytes)
        {
            using (SHA256 sha256 = SHA256.Create())
            {
                // Calculate the SHA-1 hash
                byte[] hashBytes = sha256.ComputeHash(inputBytes);

                // Convert the byte array to a hexadecimal string
                StringBuilder sb = new StringBuilder();
                foreach (byte b in hashBytes)
                {
                    sb.Append(b.ToString("x2"));
                }

                return sb.ToString();
            }
        }

        private void button6_Click(object sender, EventArgs e)
        {
            deletepop f3 = new deletepop();
            f3.Show();
        }
    }
}
