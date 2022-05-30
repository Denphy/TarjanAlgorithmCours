﻿using System;
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
        private static bool[,] graph;
        private static List<string> linesOutput;
        private static int n;
        private static int time = 0;
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
        private void readFile(string filePath)
        {

            try
            {
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
                linesOutput = new List<string>();
                FormFileList exec = new FormFileList();
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
            FormInstructions fInstructions = new FormInstructions(2);
            fInstructions.Show();
        }
    }
}