using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace A_Start_Console
{
    internal class A_Start_Algorithm
    {
        public int n;
        public int[,] matrix;
        public Node[] node;
        public int begin, end;
        public List<int> step = new List<int>();
        public List<string> openStatus = new List<string>();
        public List<string> closeStatus = new List<string>();

        public bool LoadMatrix(string path)
        {
            try
            {
                using (StreamReader sr = new StreamReader(path))
                {
                    n = int.Parse(sr.ReadLine());
                    matrix = new int[n, n];

                    for (int i = 0; i < n; i++)
                    {
                        string[] line = sr.ReadLine().Split(' ');
                        for (int j = 0; j < n; j++)
                        {
                            matrix[i, j] = int.Parse(line[j]);
                        }
                    }
                    return true;
                }
                step.Clear();
            }
            catch 
            { 
                return false;
            }
        }

        public string[] getRequest(string path) 
        {
            step.Clear();
            try
            {
                using (StreamReader sr = new StreamReader(path))
                {
                    node = new Node[n];
                    begin = int.Parse(sr.ReadLine());
                    end = int.Parse(sr.ReadLine());
                    string[] line = sr.ReadLine().Split(' ');
                    for (int i = 0; i < line.Length; i++)
                    {
                        node[i] = new Node();
                        node[i].setprev(-1);
                        node[i].setIndex(i);
                        node[i].sethValue(int.Parse(line[i]));
                    }
                    return line;
                }
            }
            catch
            {
                node = null;
                step.Clear() ;
                return null;
            }
        }

        private int[] JoinArray()
        {
            List<int> point = new List<int>();
            point.Add(end);
            int prev = node[end].getprev();
            while(prev != -1)
            {
                point.Add(prev);
                prev = node[prev].getprev();
            }
            int[] arr = new int[point.Count];
            for(int i=point.Count-1; i>=0; i--)
            {
                arr[point.Count - 1 - i] = point[i];
            }
            return arr;
        }

        private void JoinOpenCloseLog(List<Node> open, List<Node> close)
        {
            string source = "{";
            for(int i = 0;i < open.Count ; i++)
            {
                source += $"{open[i].getIndex() + 1} ({open[i].getfValue()}) ";
            }
            source += "}" ;
            openStatus.Add(source);
            source = "{";
            for (int i = 0; i < close.Count; i++)
            {
                source += $"{close[i].getIndex() + 1} ({close[i].getfValue()}) ";
            }
            source += "}";
            closeStatus.Add(source);
        }

        public int[] Calc()
        {
            openStatus.Clear();
            closeStatus.Clear();
            try
            {
                List<Node> open = new List<Node>();
                List<Node> close = new List<Node>();
                node[begin].setgValue(0);
                open.Add(node[begin]);
                JoinOpenCloseLog(open, close);
                while (open.Count != 0)
                {
                    int bestof = -1;
                    int min = 1000000000;
                    for (int i = 0; i < open.Count; i++)
                    {
                        if (min > open[i].getfValue())
                        {
                            bestof = i;
                            min = open[i].getfValue();
                        }
                    }
                    Node p = open[bestof];
                    step.Add(p.getIndex());
                    open.RemoveAt(bestof);
                    if (p.getIndex() == end)
                    {
                        JoinOpenCloseLog(open, close);
                        return JoinArray();
                    }
                    close.Add(p);
                    for (int q = 0; q < n; q++)
                    {
                        if (matrix[p.getIndex(), q] != 0)
                        {
                            if (q == 10)
                            {
                                Console.WriteLine();
                            }
                            bool check = false;
                            for (int j = 0; j < open.Count; j++)
                            {
                                if (open[j].getIndex() == q)
                                {
                                    check = true; break;
                                }
                            }
                            if (check)
                            {
                                if (node[q].getgValue() > (p.getgValue() + matrix[p.getIndex(), q]))
                                {
                                    node[q].setgValue(p.getgValue() + matrix[p.getIndex(), q]);
                                    node[q].setprev(p.getIndex());
                                }
                                continue;
                            }
                            for (int j = 0; j < close.Count; j++)
                            {
                                if (close[j].getIndex() == q)
                                {
                                    check = true; break;
                                }
                            }
                            if (check)
                            {
                                if (node[q].getgValue() > p.getgValue() + matrix[p.getIndex(), q])
                                {
                                    for (int j = 0; j < close.Count; j++)
                                    {
                                        if (close[j].gethValue() == q)
                                        {
                                            close.RemoveAt(j);
                                        }
                                    }
                                    open.Add(node[q]);
                                }
                                continue;
                            }
                            node[q].setgValue(p.getgValue() + matrix[p.getIndex(), q]);
                            node[q].setprev(p.getIndex());
                            open.Add(node[q]);
                        }
                    }
                    JoinOpenCloseLog(open, close);
                }
                return null;
            }
            catch
            {
                return new int[] { -1 };
            }
        }
    }
}
