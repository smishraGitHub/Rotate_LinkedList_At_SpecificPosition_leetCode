using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Rotate_LinkedList_At_SpecificPosition
{
    class Program
    {
        public class Node
        {
            public int data;
            public Node next;
            public Node(int data)
            {
                this.data = data;
                next = null;
            }
        }

        public class LinkedList
        {
            Node root;

            public LinkedList()
            {
                root = null;
            }

            public void insertRoot(int val)
            {
                Node newNode = new Node(val);
                if(this.root !=null)
                {
                    newNode.next = root;
                }
                this.root = newNode;
            }

            public void showList()
            {
                showList_func(root);
            }
            private void showList_func(Node root)
            {
                while(root !=null)
                {
                    Console.Write(root.data + " ");
                    root = root.next;
                }
            }

            //Rotate Function to rotate List at specific position
            public void RotateListAtSpecificPosition()
            {
                root=RotateListAtSpecificPosition_func(root, 3);
            }

            private Node RotateListAtSpecificPosition_func(Node root,int k)
            {
                if (root == null)
                {
                    return root;
                }
                else
                {
                    Node p = root;
                    Node q, newNode;

                    while(k >0)
                    {
                        k--;
                        p = p.next;
                    }
                    newNode = p.next;
                    p.next = null;
                    q = newNode;

                    while(q.next !=null)
                    {
                        q = q.next;
                    }
                    q.next = root;

                    return newNode;
                }
            }

        }
        static void Main(string[] args)
        {
            LinkedList ls = new LinkedList();
            ls.insertRoot(1);
            ls.insertRoot(2);
            ls.insertRoot(3);
            ls.insertRoot(4);
            ls.insertRoot(5);
            ls.insertRoot(6);
            ls.insertRoot(7);
            ls.insertRoot(8);

            ls.showList();
            Console.WriteLine("");
            ls.RotateListAtSpecificPosition();
            ls.showList();
            Console.ReadLine();

        }
    }
}
