using System;

namespace graf

{
    class Program
    {
        static void Main(string[] args)
        {
            RadoGraph g = new RadoGraph();
            /*
            MatrixGraph g = new MatrixGraph(20);
            g.SetEdge(0, 1);
            g.SetEdge(0, 2);
            g.SetEdge(1, 3);
            g.SetEdge(1, 4);             
            g.SetEdge(2, 5);
            g.SetEdge(2, 6);
            g.SetEdge(3, 7);
            g.SetEdge(3, 8);
            g.SetEdge(4, 9);
            g.SetEdge(4, 10);
            g.SetEdge(5, 11);
            g.SetEdge(5, 12);
            g.SetEdge(6, 13);
            g.SetEdge(6, 14);
            */

            var test = g.GetTraversalEnumerator(TraversalStrategyEnum.DFS);

            test.OnAllChildrenVisited += delegate (int node)
            {
                Console.WriteLine($"Node {node}'s children had been visited.");
            };
            test.OnHasNoChildren += delegate (int node)
            {
                Console.WriteLine($"Node {node} has no children.");
            };

            while (test.MoveNext())
            {
                Console.WriteLine(test.Current);
                Console.WriteLine("---");
                Console.ReadKey();
            }
        }
    }
}
