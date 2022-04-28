using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Collections;

namespace SDA_9
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }
        Graph g = new Graph();

        public class Vertex
        {
            public bool wasVisited;
            public string label;
            public Vertex(string label)
            {
                this.label = label;
                wasVisited = false;
            }
        }

        public class DistanceFromFirstVertex
        {
            public int distance, parentVert;
            public DistanceFromFirstVertex(int pv, int d)
            {
                distance = d;
                parentVert = pv;
            }
        }

        public class Graph
        {
            private const int max_verts = 20;
            int infinity = Int32.MaxValue;
            Vertex[] vertexList;
            int[,] adjMatrix;
            int nVerts, nTree, currentVert, startToCurrent;
            string str = "";
            DistanceFromFirstVertex[] shortPath;

            public Graph()
            {
                vertexList = new Vertex[max_verts];
                adjMatrix = new int[max_verts, max_verts];
                nVerts = 0;
                nTree = 0;
                for (int j = 1; j <= nVerts - 1; j++)
                    for (int k = 1; k <= nVerts - 1; k++)
                        adjMatrix[j, k] = infinity;
                shortPath = new DistanceFromFirstVertex[max_verts];
            }
            public int GetMin()
            {
                int minDist = infinity;
                int indexMin = 0;
                for (int j = 1; j <= nVerts - 1; j++)
                {
                    if (!(vertexList[j].wasVisited) && shortPath[j].distance < minDist)
                    {
                        minDist = shortPath[j].distance;
                        indexMin = j;
                    }
                }
                return indexMin;
            }
            public void Path()
            {
                int startTree = 0;
                vertexList[startTree].wasVisited = true;
                nTree = 1;
                for (int j = 0; j < nVerts; j++)
                {
                    int tempDist = adjMatrix[startTree, j];
                    shortPath[j] = new DistanceFromFirstVertex(startTree, tempDist);
                }
                for (int i = 0; i < nVerts; i++)
                {
                    str += i + "=" + shortPath[i].distance + ", ";
                }
                while (nTree < nVerts)
                {
                    int indexMin = GetMin();
                    currentVert = indexMin;
                    int minDist = shortPath[indexMin].distance;
                    startToCurrent = shortPath[indexMin].distance;
                    vertexList[currentVert].wasVisited = true;
                    CalculateShortPath();
                    nTree++;
                }
            }
            public void CalculateShortPath()
            {
                int idVerts = 1;
                while (idVerts < nVerts)
                {
                    if (vertexList[idVerts].wasVisited)
                    {
                        idVerts++;
                    }
                    else
                    {
                        int currentToFringe = adjMatrix[currentVert, idVerts];
                        if (currentToFringe == infinity)
                        {
                            idVerts++;
                            continue;
                        }
                        int startToFringe = startToCurrent + currentToFringe;
                        int sPathDist = shortPath[idVerts].distance;
                        if (startToFringe < sPathDist)
                        {
                            shortPath[idVerts].parentVert = currentVert;
                            shortPath[idVerts].distance = startToFringe;
                        }
                        idVerts++;
                    }
                }
            }
            public string DisplaySolution()
            {
                string s = "\nРешение:\n";
                s += String.Format("{0,8} {1,8} {2,5}\n", "До възел", "Родител", "Път");
                for (int j = 0; j < nVerts; j++)
                {
                    s += String.Format("     {0,5}   ", vertexList[j].label);
                    string parent = vertexList[shortPath[j].parentVert].label;
                    s += String.Format("     {0,5}  ", parent);
                    if (shortPath[j].distance == infinity)
                        s += String.Format("    {0,5}   \n", " inf");
                    else
                        s += String.Format("     {0,5}   \n", shortPath[j].distance.ToString());
                }
                return s;
            }
            public void AddVertex(string lab)
            {
                vertexList[nVerts] = new Vertex(lab);
                nVerts++;
            }
            public void AddEdge(int start, int theEnd, int weight)
            {
                adjMatrix[start, theEnd] = weight;
                adjMatrix[theEnd, start] = weight;
            }
            public string showVertex(int v)
            {
                return (vertexList[v].label);
            }
            public int Count()
            {
                return nVerts;
            }
            public void ClearGraph()
            {
                for (int i = 0; i < nVerts; i++)
                    vertexList[i].wasVisited = false;
                for (int i = 0; i < nVerts; i++)
                    vertexList[i] = null;
                for (int j = 0; j < nVerts; j++)
                    for (int k = 0; k < nVerts; k++)
                        adjMatrix[j, k] = infinity;

                nVerts = 0;
                nTree = 0;
            }
            public string ShowMatrix()
            {
                if (nVerts == 0)
                    return "";
                string s = "    |";
                for (int i = 0; i < nVerts; i++)
                    s += String.Format("    {0} |", showVertex(i));
                s += "\n";
                for (int i = 0; i <= nVerts; i++)
                    s += "===|";
                s += "\n";
                for (int i = 0; i < nVerts; i++)
                {
                    s += String.Format("    {0} |", showVertex(i));
                    for (int k = 0; k < nVerts; k++)
                    {
                        if (HasEdge(i, k))
                        {
                            s += " 1 |";
                        }
                        else
                        {
                            s += " 0 |";
                        }
                    }
                    s += "\n";
                }
                return s;
            }
            public bool HasEdge(int start, int end)
            {
                if (adjMatrix[start, end] == infinity)
                    return false;
                else
                    return true;
            }

        }

        private void btnCreateGraph3_Click(object sender, EventArgs e)
        {
            g.ClearGraph();
            g.AddVertex("A");
            g.AddVertex("B");
            g.AddVertex("C");
            g.AddVertex("D");
            g.AddVertex("E");
            g.AddEdge(0, 1, 5);
            g.AddEdge(1, 0, 5);
            g.AddEdge(0, 2, 2);
            g.AddEdge(2, 0, 2);
            g.AddEdge(1, 2, 2);
            g.AddEdge(2, 1, 2);
            g.AddEdge(1, 4, 4);
            g.AddEdge(4, 1, 4);
            g.AddEdge(2, 3, 2);
            g.AddEdge(3, 2, 2);
            g.AddEdge(3, 4, 1);
            g.AddEdge(4, 3, 1);
            richTextBox1.Text = g.ShowMatrix();
        }

        private void btnCreateGraph2_Click(object sender, EventArgs e)
        {
            g.ClearGraph();
            g.AddVertex("A");
            g.AddVertex("B");
            g.AddVertex("C");
            g.AddVertex("D");
            g.AddVertex("E");
            g.AddEdge(0, 1, 5);
            g.AddEdge(1, 0, 5);
            g.AddEdge(0, 2, 2);
            g.AddEdge(2, 0, 2);
            g.AddEdge(1, 2, 2);
            g.AddEdge(2, 1, 2);
            g.AddEdge(1, 4, 4);
            g.AddEdge(4, 1, 4);
            g.AddEdge(2, 3, 6);
            g.AddEdge(3, 2, 6);
            g.AddEdge(3, 4, 1);
            g.AddEdge(4, 3, 1);
            richTextBox1.Text = g.ShowMatrix();
        }

        private void btnCreateGraph1_Click(object sender, EventArgs e)
        {
            g.ClearGraph();
            g.AddVertex("A");
            g.AddVertex("B");
            g.AddVertex("C");
            g.AddVertex("D");
            g.AddVertex("E");
            g.AddEdge(0, 1, 5);
            g.AddEdge(1, 0, 5);
            g.AddEdge(0, 2, 2);
            g.AddEdge(2, 0, 2);
            g.AddEdge(1, 2, 2);
            g.AddEdge(2, 1, 2);
            g.AddEdge(1, 4, 4);
            g.AddEdge(4, 1, 4);
            g.AddEdge(2, 3, 8);
            g.AddEdge(3, 2, 8);
            g.AddEdge(3, 4, 10);
            g.AddEdge(4, 3, 10);
            richTextBox1.Text = g.ShowMatrix();
        }

        private void btnClearGraph_Click(object sender, EventArgs e)
        {
            g.ClearGraph();
            richTextBox1.Text = "";
        }

        private void btnDijkstra_Click(object sender, EventArgs e)
        {
            g.Path();
            g.DisplaySolution();
        }
    }
}
