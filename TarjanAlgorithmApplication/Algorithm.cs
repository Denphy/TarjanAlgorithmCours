using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TarjanAlgorithmApplication
{
    public class Algorithm
    {
        private static int time = 0;
        private static List<string> linesOutput;
        private void findComponent(int vertex, int[] discoveryTime, int[] lowLink, Stack<int> stack, bool[] stackItem, bool[,] graph)
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
                        findComponent(i, discoveryTime, lowLink, stack, stackItem, graph);
                        lowLink[vertex] = Math.Min(lowLink[vertex], lowLink[i]);
                    }
                    else if (stackItem[i])
                    {
                        lowLink[vertex] = Math.Min(lowLink[vertex], discoveryTime[i]);
                    }
                }
            }

            int poppedItem;
            if (lowLink[vertex] == discoveryTime[vertex])
            {
                List<int> elements = new List<int>();
                linesOutput.Add("Компонента сильной связности: ");
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
        public List<string> strongConComponent(int n, bool[,] graph)
        {
            linesOutput = new List<string>();   
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
                    findComponent(i, discoveryTime, lowLink, stack, stackItem, graph);
            }
            return linesOutput;
        }
    }
}
