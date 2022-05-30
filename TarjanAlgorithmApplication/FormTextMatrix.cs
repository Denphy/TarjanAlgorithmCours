using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace TarjanAlgorithmApplication
{
    public partial class FormTextMatrix : Form
    {
        #region form
        public FormTextMatrix()
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
            FormInstructions fInstructions = new FormInstructions(3);
            fInstructions.Show();
        }
        #endregion
        #region functions
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
                int i = 0;
                for (int j = 1; j < allLines.Length; j++)
                {
                    lineS = allLines[j].Split(' ');
                    for(int k = 0; k < lineS.Length; k++)
                        if (int.Parse(lineS[k]) == 1)
                            graph[j-1, k] = true;
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
