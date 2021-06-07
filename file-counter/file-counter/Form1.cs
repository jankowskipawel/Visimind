using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace file_counter
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void pickDirectoryButton_Click(object sender, EventArgs e)
        {
            directoryFolderBrowserDialog.ShowDialog();
            directoryTextBox.Text = directoryFolderBrowserDialog.SelectedPath;
        }

        private void pickLogDirectoryButton_Click(object sender, EventArgs e)
        {
            logFolderBrowserDialog.ShowDialog();
            logDirectoryTextBox.Text = logFolderBrowserDialog.SelectedPath;
        }

        private void checkDirectoryButton_Click(object sender, EventArgs e)
        {
            //parse parameter
            int MAX_DIFF = Int32.Parse(parameterTextBox.Text.Trim());

            //get all directories from directory
            string[] directories = Directory.GetDirectories(directoryTextBox.Text);

            //remove non camera directories
            List<string> filteredDirectories = FilterDirectories(directories);

        }

        private List<string> FilterDirectories(string[] directories)
        {
            List<string> filteredDirectories = new List<string>();
            Regex rx = new Regex("camera \\d+$");

            foreach (var directory in directories)
            {
                string directoryName = directory.Split('\\').Last().ToLower();
                if (rx.IsMatch(directoryName))
                {
                    filteredDirectories.Add(directory);
                }
            }
            return filteredDirectories;
        }
    }
}
