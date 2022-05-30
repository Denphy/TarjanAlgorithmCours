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

namespace TarjanAlgorithmApplication
{
    public partial class FormFileList : Form
    {
        #region form
        public FormFileList()
        {
            InitializeComponent();
        }

        private void buttonSelectFile_Click(object sender, EventArgs e)
        {
            OpenFileDialog dlg = new OpenFileDialog();
            if (Directory.Exists("TestFiles"))
                dlg.InitialDirectory = Environment.CurrentDirectory + "\\TestFiles";
            else
                dlg.InitialDirectory = Environment.CurrentDirectory;
            dlg.Filter = "Текстовые файлы (*.txt)|*.txt";
            dlg.ShowDialog();
            string filePath = dlg.FileName;
            if (filePath != "")
            {
                textOutput.Text = "";
                readFile(filePath);
            }
        }
        private void iconButton1_Click(object sender, EventArgs e)
        {
            FormInstructions fInstructions = new FormInstructions(2);
            fInstructions.Show();
        }
        #endregion
        #region functions
        private void readFile(string filePath)
        {

            try
            {
                bool[,] graph;
                int n;
                using (StreamReader sr = new StreamReader(filePath))
                {

                    string line = sr.ReadLine();
                    string[] lineS = line.Split(' ');
                    n = int.Parse(lineS[0]);
                    graph = new bool[n, n];
                    line = sr.ReadLine();

                    while (line != null)
                    {
                        lineS = line.Split(' ');
                        int[] buff = new int[2];

                        buff[0] = int.Parse(lineS[0]);
                        buff[1] = int.Parse(lineS[1]);

                        graph[buff[0] - 1, buff[1] - 1] = true;
                        line = sr.ReadLine();

                    }
                }
                Algorithm alg = new Algorithm();
                List<string> linesOutput = alg.strongConComponent(n, graph);

                foreach (var lineOutput in linesOutput)
                    textOutput.Text += lineOutput + "\n";
            }
            catch
            {
                MessageBox.Show("Проверьте правильность ввода данных", "Внимание!");
            }
        }
        #endregion

    }
}
