using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WindowsFormsApp
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            string dirName = @"C:\Temp\"; // Any path with folders

            var directory = new DirectoryInfo(dirName); // Gets info about given path of folder

            if (directory.Exists) // Checks directory exists 
            {
                Console.WriteLine("Directory:");

                DirectoryInfo[] dirs = directory.GetDirectories(); // Gets all directories of given path
                foreach (DirectoryInfo dir in dirs) // Сycles through all directories
                {
                    comboBox1.Items.Add(dir.Name);
                }
            }
        }

        private void comboBox1_SelectionChangeCommitted(object sender, EventArgs e)
        {
            comboBox2.Items.Clear();
            string item = comboBox1.SelectedItem.ToString();
            string dirName = @"C:\Temp\" + item + @"\";

            var directory = new DirectoryInfo(dirName);

            if (directory.Exists)
            {
                Console.WriteLine("Directory:");

                DirectoryInfo[] dirs = directory.GetDirectories();
                foreach (DirectoryInfo dir in dirs)
                {
                    comboBox2.Items.Add(dir.Name);
                }
            }
        }
    }
}
