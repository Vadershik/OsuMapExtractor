using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.IO;
using System.IO.Compression;
using System.Threading;

namespace OsuMapExtractor
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void InputFolderChangeButton_Click(object sender, EventArgs e)
        {
            if(folderBrowserDialog1.ShowDialog()==DialogResult.OK)
            {
                InputBoxFolder.Text = folderBrowserDialog1.SelectedPath;
            }
        }

        private void OutPutFolderChangeButton_Click(object sender, EventArgs e)
        {
            if (folderBrowserDialog1.ShowDialog() == DialogResult.OK)
            {
                OutputBoxFolder.Text = folderBrowserDialog1.SelectedPath;
            }
        }

        private void Start_Click(object sender, EventArgs e)
        {
            string inputfilefolder = InputBoxFolder.Text;
            DirectoryInfo dir = new DirectoryInfo(inputfilefolder);
            DirectoryInfo[] fi;
            string zipfilefolder;
            bool containsNotNull = false;
            new Thread(() =>
            {
                fi = dir.GetDirectories();
                for (int i = 0; i < ((textBox1.Text == "" || textBox1.Text == " " || 
                textBox1.Text == "max") ? fi.Length :
                Convert.ToInt32(textBox1.Text)); i++)
                {
                    zipfilefolder = $"{OutputBoxFolder.Text}/{fi[i].Name}.osz";
                    if (SearchBox.Text != "")
                    {
                        if (SearchBox.Text.Contains("*")) {
                            SearchBox.Text.Replace("*","_");
                        }
                        if (fi[i].Name.ToLower().Contains(SearchBox.Text.ToLower()))
                        {
                            containsNotNull = true;
                            try
                            {
                                ZipFile.CreateFromDirectory($"{inputfilefolder}/{fi[i].Name}", zipfilefolder);
                            }
                            catch
                            {
                                continue;
                            }
                        }
                    }
                    else
                    {
                        containsNotNull = true;
                        try
                        {
                            ZipFile.CreateFromDirectory($"{inputfilefolder}/{fi[i].Name}", zipfilefolder);
                        }
                        catch
                        {
                            continue;
                        }
                    }
                }
                if(!containsNotNull)
                {
                    MessageBox.Show("Map with contains this not found\nSorry :(");
                }
                else
                {
                    MessageBox.Show("Done");
                }
            })
            {
                IsBackground = true
            }.Start();
        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }
    }
}
