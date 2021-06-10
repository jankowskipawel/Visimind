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
            logDirectoryTextBox.Text = directoryFolderBrowserDialog.SelectedPath;
        }

        private void pickLogDirectoryButton_Click(object sender, EventArgs e)
        {
            logFolderBrowserDialog.ShowDialog();
            logDirectoryTextBox.Text = logFolderBrowserDialog.SelectedPath;
        }

        public static int ParseParameter(string parameterString)
        {
            if (parameterString.Length == 0)
            {
                throw new ArgumentException("Parameter cannot be empty");
            }
            if (!Int32.TryParse(parameterString.Trim(), out var parsedParameter))
            {
                throw new ArgumentException($"Can't parse {parameterString} as int");
            }
            return parsedParameter;
        }

        public static void CheckDirectoryPath(string path)
        {
            if (path.Length == 0)
            {
                throw new ArgumentException("Directory path cannot be empty");
            }

            if (!Directory.Exists(path) || !IsPathValid(path))
            {
                throw new ArgumentException($"{path} is not a valid directory");
            }
        }

        private void checkDirectoryButton_Click(object sender, EventArgs e)
        {
            try
            {
                CheckDirectoryPath(directoryTextBox.Text);
            }
            catch (Exception exception)
            {
                MessageBox.Show(exception.Message);
                return;
            }
            
            // parse parameter
            int MAX_DIFF;
            try
            {
                MAX_DIFF = ParseParameter(parameterTextBox.Text);
            }
            catch (Exception exception)
            {
                MessageBox.Show(exception.Message);
                return;
            }

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
            bool[] isMaxDiffExceeded = new bool[numberOfFilesInDirectories.Length];
            for (int i = 0; i < numberOfFilesInDirectories.Length; i++)
            {
                for (int j = 0; j < numberOfFilesInDirectories.Length; j++)
                {
                    if (Math.Abs(numberOfFilesInDirectories[i] - numberOfFilesInDirectories[j]) > MAX_DIFF)
                    {
                        isMaxDiffExceeded[i] = true;
                        isMaxDiffExceeded[j] = true;
                    }
                }
            }
            //print info
            PrintColoredText($"MAX_DIFF: {MAX_DIFF}", Color.Green, true);
            for (int i = 0; i < numberOfFilesInDirectories.Length; i++)
            {
                string cameraNumber = filteredDirectories[i].Split('\\').Last().Split(' ').Last();
                if (isMaxDiffExceeded[i] == true)
                {
                    PrintColoredText($"Camera {cameraNumber}: {numberOfFilesInDirectories[i]} files", Color.Red, true);
                }
                else
                {
                    PrintColoredText($"Camera {cameraNumber}: {numberOfFilesInDirectories[i]} files", Color.Black, true);
                }
            }
            PrintColoredText("", Color.Black, true);
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

        private void clearLogButton_Click(object sender, EventArgs e)
        {
            logTextBox.Text = "";
        }

        private void saveLogButton_Click(object sender, EventArgs e)
        {
            try
            {
                CheckDirectoryPath(logDirectoryTextBox.Text);
            }
            catch (Exception exception)
            {
                MessageBox.Show(exception.Message);
                return;
            }
            DateTime date = DateTime.Now;
            string directoryName = directoryTextBox.Text.Split('\\').Last();
            StreamWriter sw =
                new StreamWriter($"{logDirectoryTextBox.Text}\\{directoryName}_{date.ToString("yyyyMMdd_hhmmss")}.txt");
            sw.Write(logTextBox.Text);
            sw.Close();
        }

        public static bool IsPathValid(string filePath)
        {
            HashSet<char> _invalidCharacters = new HashSet<char>(Path.GetInvalidPathChars());
            return !string.IsNullOrEmpty(filePath) && !filePath.Any(pc => _invalidCharacters.Contains(pc));
        }
    }
}
