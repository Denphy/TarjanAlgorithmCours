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
        private static bool[,] graph;
        private static List<string> linesOutput;
        private static int n;
        private static int time = 0;
        public FormTextMatrix()
        {
            InitializeComponent();
        }

        private void buttonFindComponents_Click(object sender, EventArgs e)
        {
            textOutput.Text = "";
            readText();
        }
        private void readText()
        {

            try
            {
                string[] allLines = textInput.Lines;
                string[] lineS = allLines[0].Split(' ');
                n = int.Parse(lineS[0]);
                graph = new bool[n, n];
                int i = 0;
                /*for (int i = 0; i < n; i++)
                {
                    lineS = line.Split(' ');
                    for (int j = 0; j < n; j++)
                        if (int.Parse(lineS[i]) == 1)
                            graph[i, j] = true;
                }*/
                for (int j = 1; j < allLines.Length; j++)
                {
                    lineS = allLines[j].Split(' ');
                    for(int k = 0; k < lineS.Length; k++)
                        if (int.Parse(lineS[k]) == 1)
                            graph[j-1, k] = true;
                }
                linesOutput = new List<string>();
                FormTextMatrix exec = new FormTextMatrix();
                /*for (int k = 0; k < n; k++)
                {
                    for (int j = 0; j < n; j++)
                        textOutput.Text += graph[k, j] + " ";
                    textOutput.Text += "\n";
                }*/
                exec.strongConComponent();
                foreach (var lineOutput in linesOutput)
                    textOutput.Text += lineOutput + "\n";
            }
            catch
            {
                MessageBox.Show("Проверьте правильность ввода данных", "Внимание!");
            }
        }
        void findComponent(int vertex, int[] discoveryTime, int[] lowLink, Stack<int> stack, bool[] stackItem)
        {
            discoveryTime[vertex] = lowLink[vertex] = ++time;
            stack.Push(vertex);
            stackItem[vertex] = true;

            for (int i = 0; i < discoveryTime.Length; i++)
            {
                if (graph[vertex, i])
                {
                    if (discoveryTime[i] == -1)
                    {
                        findComponent(i, discoveryTime, lowLink, stack, stackItem);
                        lowLink[vertex] = Math.Min(lowLink[vertex], lowLink[i]);
                    }
                    else if (stackItem[i])
                    {
                        lowLink[vertex] = Math.Min(lowLink[vertex], discoveryTime[i]);
                    }
                }
            }

            int poppedItem = 0;
            if (lowLink[vertex] == discoveryTime[vertex])
            {
                List<int> elements = new List<int>();
                linesOutput.Add("Компонента связи: ");
                while (stack.Peek() != vertex)
                {
                    poppedItem = stack.Peek();
                    elements.Add(poppedItem + 1);
                    stackItem[poppedItem] = false;
                    stack.Pop();
                }
                poppedItem = stack.Peek();
                elements.Add(poppedItem + 1);
                elements.Sort();
                foreach (int element in elements)
                    linesOutput[linesOutput.Count - 1] += element.ToString() + " ";
                stackItem[poppedItem] = false;
                stack.Pop();
            }
        }
        private void strongConComponent()
        {

            int[] discoveryTime = new int[n];
            int[] lowLink = new int[n];
            bool[] stackItem = new bool[n];
            Stack<int> stack = new Stack<int>();
            for (int i = 0; i < n; i++)
            {
                discoveryTime[i] = -1;
                lowLink[i] = -1;
                stackItem[i] = false;
            }

            for (int i = 0; i < n; i++)
            {
                if (discoveryTime[i] == -1)
                    findComponent(i, discoveryTime, lowLink, stack, stackItem);
            }
        }

        private void iconButton1_Click(object sender, EventArgs e)
        {
            FormInstructions fInstructions = new FormInstructions(3);
            fInstructions.Show();
        }
    }
}
