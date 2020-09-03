using System;
using System.Collections.Generic;

namespace CountNodes
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Hi Scott!");

            // Create a root node
            TreeNode rootNode = new TreeNode("Scott");

            // Create some other nodes and add them under the root
            TreeNode nodeA = new TreeNode("A");
            TreeNode nodeB = new TreeNode("B");
            TreeNode nodeC = new TreeNode("C");
            TreeNode nodeD = new TreeNode("D");

            rootNode.childNodes.Add(nodeA);
            rootNode.childNodes.Add(nodeB);
            rootNode.childNodes.Add(nodeC);
            rootNode.childNodes.Add(nodeD);

            // Add a node under node B
            TreeNode nodeBA = new TreeNode("BA");
            nodeB.childNodes.Add(nodeBA);

            // Add a node under node BA
            TreeNode nodeBAA = new TreeNode("BAA");
            nodeBA.childNodes.Add(nodeBAA);

            // Add a node under D
            TreeNode nodeDA = new TreeNode("DA");
            nodeD.childNodes.Add(nodeDA);

            Console.Out.WriteLine("Printing Nodes:");
            Console.WriteLine("Total nodes including the root: " + PrintNodes(rootNode));


        }

        static int PrintNodes(TreeNode treeNode)
        {
            // Initialize the counter for the one node we have
            int count = 1;

            // Print the current TreeNode
            Console.WriteLine("Node Name: " + treeNode.nodeName);

            // Recursively print any child nodes
            foreach(TreeNode tn in treeNode.childNodes)
            {
                count += PrintNodes(tn);
            }

            return count;
        }
    }
}
