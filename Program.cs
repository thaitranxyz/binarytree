using System;

namespace binarytree
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Hello World!");
        }

        class Node()
        {
            int key; 
            Node left, right; 

            public Node(int key)
            {
                this.key = key; 
                left = right = null;
            }

            public Node()
            {
                key = null; 
            }
        }


        public class BinaryTree()
        {
            Node root; 
            Node head; 

            public BinaryTree(int rootKey)
            {
                root = rootkey; 
            } 

            public BinaryTree()
            {
                root = null; 
                root.left = root.right = null; 
                head = root; 
            }

            public void Insert(int key)
            {
                if (root == null)
                {
                    root = key; 
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
                            head = head.left
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
                    
                }
            }
        }
    }
}
