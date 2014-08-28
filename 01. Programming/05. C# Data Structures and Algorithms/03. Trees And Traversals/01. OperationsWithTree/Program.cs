using System;
using System.Collections.Generic;

class Program
{
    static void Main(string[] args)
    {
        int numberOfInputs = int.Parse(Console.ReadLine());

        var nodes = new TreeNode<int>[numberOfInputs];

        SetTheInputDataToTheTreeNodes(numberOfInputs, nodes);

        // Task a - find the root node.
        int rootNodeValue = FindTheRootNode(nodes);
        Console.WriteLine("Value Of Root Node is - " + rootNodeValue);

        // Task b - find the leaf nodes.
        var leafNodes = FindTheLeafNodes(nodes);
        Console.WriteLine("Leaf Nodes - " + string.Join(", ", leafNodes));

        // Task c - find the middle nodes.
        var middleNodes = FindTheMiddleNodes(nodes);
        Console.WriteLine("Middle Nodes - " + string.Join(", ", middleNodes));

        // task d - find the longest path into the tree.
        var longestPath = FindTheLongestPath(nodes[3]);
        Console.WriteLine("LongestPaths - " + string.Join(", ", longestPath));
    }

    private static int FindTheLongestPath(TreeNode<int> node)
    {
        if (node.ChildrenCount == 0)
        {
            return 0;
        }

        int maxPath = 0;

        foreach (var currentChild in node.GetChildNodes())
        {
            maxPath = Math.Max(maxPath, FindTheLongestPath(currentChild));
        }

        return maxPath + 1;
    }

    private static List<int> FindTheMiddleNodes(TreeNode<int>[] nodes)
    {
        List<int> middleNodes = new List<int>();

        foreach (var node in nodes)
        {
            if (node.HasParent == true && node.ChildrenCount > 0)
            {
                middleNodes.Add(node.Value);
            }
        }

        return middleNodes;
    }

    private static List<int> FindTheLeafNodes(TreeNode<int>[] nodes)
    {
        List<int> leafNodes = new List<int>();

        foreach (var node in nodes)
        {
            if (node.ChildrenCount == 0)
            {
                leafNodes.Add(node.Value);
            }
        }

        return leafNodes;
    }

    private static int FindTheRootNode(TreeNode<int>[] nodes)
    {
        int valueOfRootNode = default(int);

        foreach (var node in nodes)
        {
            if (node.HasParent == false)
            {
                valueOfRootNode = node.Value;
                break;
            }
        }

        return valueOfRootNode;
    }

    private static void SetTheInputDataToTheTreeNodes(int numberOfInputs, TreeNode<int>[] nodes)
    {
        for (int i = 0; i < numberOfInputs; i++)
        {
            nodes[i] = new TreeNode<int>(i);
        }

        for (int i = 1; i < numberOfInputs; i++)
        {
            string nodeInputDataLine = Console.ReadLine();
            var nodeParts = nodeInputDataLine.Split(' ');

            int parentID = int.Parse(nodeParts[0]);
            int childID = int.Parse(nodeParts[1]);

            nodes[parentID].AddChild(nodes[childID]);
        }
    }
}
