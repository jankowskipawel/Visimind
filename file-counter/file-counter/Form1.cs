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

            //count files
            int[] numberOfFilesInDirectories = new int[filteredDirectories.Count];
            for (int i = 0; i < filteredDirectories.Count; i++)
            {
                numberOfFilesInDirectories[i] = Directory.GetFiles(filteredDirectories[i]).Length;
            }

            //check file count difference
            bool[] isMaxDiffExceded = new bool[numberOfFilesInDirectories.Length];
            for (int i = 0; i < numberOfFilesInDirectories.Length; i++)
            {
                for (int j = 0; j < numberOfFilesInDirectories.Length; j++)
                {
                    if (Math.Abs(numberOfFilesInDirectories[i] - numberOfFilesInDirectories[j]) > MAX_DIFF)
                    {
                        isMaxDiffExceded[i] = true;
                        isMaxDiffExceded[j] = true;
                    }
                }
            }

            //print info
            for (int i = 0; i < numberOfFilesInDirectories.Length; i++)
            {
                string cameraNumber = filteredDirectories[i].Split('\\').Last().Split(' ').Last();
                if (isMaxDiffExceded[i] == true)
                {
                    PrintColoredText($"Camera {cameraNumber}: {numberOfFilesInDirectories[i]} files", Color.Red, true);
                }
                else
                {
                    PrintColoredText($"Camera {cameraNumber}: {numberOfFilesInDirectories[i]} files", Color.Black, true);
                }
            }
            PrintColoredText("", Color.Black, true);
            //save log
        }

        //checks every directory name using regex and returns list with only matching names
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

        //prints colored text to log
        public void PrintColoredText(string text, Color color, bool addNewLine=false)
        {
            logTextBox.SelectionColor = color;
            logTextBox.AppendText(text);
            if (addNewLine)
            {
                logTextBox.AppendText(Environment.NewLine);
            }
        }
    }
}
