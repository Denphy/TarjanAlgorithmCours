using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Diagnostics;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace TarjanAlgorithmApplication
{
    public partial class FormTextList : Form
    {
        #region form
        public FormTextList()
        {
            InitializeComponent();
        }

        private void buttonFindComponents_Click(object sender, EventArgs e)
        {
            textOutput.Text = "";
            readText();
        }
        private void iconButton1_Click(object sender, EventArgs e)
        {
            FormInstructions fInstructions = new FormInstructions(4);
            fInstructions.Show();
        }
        #endregion
        #region form
        private void readText()
        {
            bool[,] graph;
            int n;
            try
            {
                string[] allLines = textInput.Lines;
                string[] lineS = allLines[0].Split(' ');
                n = int.Parse(lineS[0]);
                graph = new bool[n, n];
                for(int j = 1; j < allLines.Length; j++)
                {
                    lineS = allLines[j].Split(' ');
                    int[] buff = new int[2];

                    buff[0] = int.Parse(lineS[0]);
                    buff[1] = int.Parse(lineS[1]);

                    graph[buff[0] - 1, buff[1] - 1] = true;
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
