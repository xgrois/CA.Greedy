using System;
using System.Collections.Generic;

namespace GraphColoring
{
    class Graph
    {
        public List<Node> Nodes { get; set; }
        public Graph(List<Node> allNodes)
        {
            Nodes = allNodes;
        }

        internal void PrintColors()
        {
            foreach (var n in Nodes)
            {
                Console.WriteLine($"Node {n.Id}, color: {n.ColorId}");
            }
        }

        internal void GreedyColoring()
        {
            int colorId = 0;
            foreach (var n in Nodes)
            {
                colorId = 1;
                while (true)
                {
                    if (IsSafe(colorId, n))
                    {
                        n.ColorId = colorId;
                        break;
                    }
                    else colorId++;
                }
            }
        }

        private bool IsSafe(int colorId, Node n)
        {
            foreach (var neigh in n.Neighs)
            {
                if (neigh.ColorId == colorId) return false;
            }
            return true;
        }
    }
    class Node
    {
        public int Id { get; set; }
        public int ColorId { get; set; } = -1;
        public List<Node> Neighs { get; set; } = new List<Node>();

        public Node(int id)
        {
            Id = id;
        }
    }
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("::: Graph Coloring :::");

            Node n0 = new Node(0);
            Node n1 = new Node(1);
            Node n2 = new Node(2);
            Node n3 = new Node(3);
            Node n4 = new Node(4);
            Node n5 = new Node(5);

            n0.Neighs.Add(n1); n0.Neighs.Add(n4); n0.Neighs.Add(n5);

            n1.Neighs.Add(n0); n1.Neighs.Add(n3); n1.Neighs.Add(n4);

            n2.Neighs.Add(n3); n2.Neighs.Add(n4);

            n3.Neighs.Add(n1); n3.Neighs.Add(n2);

            n4.Neighs.Add(n0); n4.Neighs.Add(n1); n4.Neighs.Add(n2);

            n5.Neighs.Add(n0); n5.Neighs.Add(n4);

            List<Node> allNodes = new List<Node>() { n0, n1, n2, n3, n4, n5 };
            Graph g = new Graph(allNodes);

            g.GreedyColoring();

            g.PrintColors();

        }
    }
}
