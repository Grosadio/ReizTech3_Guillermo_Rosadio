using System;
using System.Collections.Generic;
using System.Text;


// Guillermo Rosadio


// Create tha class node
public class Node
{
    public int data;
    public Node left, right;

    public Node(int item)
    {
        data = item;
        left = right = null;
    }
}
// Create the class tree
class BinaryTree
{
    public Node root;

    public BinaryTree()
    {
        root = null;
    }
    // use recursive function
    public int Height()
    {
        return HeightRecursive(root);
    }

    private int HeightRecursive(Node current)
    {
        if (current == null)
        {
            return 0;
        }

        int leftHeight = HeightRecursive(current.left);
        int rightHeight = HeightRecursive(current.right);

        return Math.Max(leftHeight, rightHeight) + 1;
    }
    /* Driver code */
    public static void Main(String[] args)
    {
        BinaryTree tree = new BinaryTree();

        tree.root = new Node(1);
        tree.root.left = new Node(2);
        tree.root.right = new Node(3);
        tree.root.left.left = new Node(4);
        tree.root.right.left = new Node(5);
        tree.root.right.right = new Node(6);
        tree.root.right.left.left = new Node(7);
        tree.root.right.right.left = new Node(8);
        tree.root.right.right.right = new Node(9);
        tree.root.right.right.left.left = new Node(10);

        Console.WriteLine("Depth of tree is : " +
                                    tree.Height());
    }

}

