using System;

namespace binarytree
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Hello World!");
            BinaryTree bt = new BinaryTree();
            bt.Insert(1);
            bt.Print();
        }

        class Node
        {
            public int key; 
            public Node left, right; 

            public Node(int key)
            {
                this.key = key; 
                left = right = null;  
            }

            public Node()
            {
            }
        }


        public class BinaryTree
        {
            Node root; 
            Node left,right;
            Node head; 

            public BinaryTree(int key)
            {
                root = new Node(key);
                root.right = null; 
                root.left = null; 
                head = root; 
            } 

            public BinaryTree()
            {
                root = null;
            }

            public void Insert(int key)
            {
                if (root == null)
                {
                    root = new Node(key); 
                    head = root; 
                    root.left = null; 
                    root.right = null; 
                }
                else 
                { 
                    while (head != null)
                    {
                        if (key > head.key)
                        {
                            head = head.right; 
                        }
                        else 
                        {
                            head = head.left;
                        }
                    }
                    head.key = key; 
                }
            }

            public void Print()
            {
                if (root == null)
                {
                    Console.WriteLine("tree is empty");
                }
                else 
                {
                    System.Console.WriteLine("tree is not empty");
                }
            }
        }
    }
}
