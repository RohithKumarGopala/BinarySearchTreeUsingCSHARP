﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BinarySearchTreeUsingCSHARP
{
    internal class CustomBinarySearchTree
    {
        private class Node
        {
            public int Data;
            public Node Left;
            public Node Right;

            public Node(int data)
            {
                Data = data;
            }
        }
        private Node Root;
        public void Add(int data)
        {
            Node newNode = new Node(data);

            if (Root == null)
            {
                Root = newNode;
                return;
            }

            Node temp = Root;

            while (temp != null)
            {
                if (newNode.Data < temp.Data)
                {
                    if (temp.Left == null)
                    {
                        temp.Left = newNode;
                        return;
                    }

                    temp = temp.Left;
                }
                else if (newNode.Data > temp.Data)
                {
                    if (temp.Right == null)
                    {
                        temp.Right = newNode;
                        return;
                    }
                    temp = temp.Right;
                }
                else
                {
                    Console.WriteLine($"{data} is already present in the tree");
                    return;
                }
            }
        }
        public bool Search(int data)

        {
            if (Root == null)
            {
                return false;
            }

            Node temp = Root;

            while (temp != null)
            {
                if (data == temp.Data)
                {
                    return true;
                }
                else if (data < temp.Data)
                {
                    temp = temp.Left;
                }
                else if (data > temp.Data)
                {
                    temp = temp.Right;
                }
            }
            return false;
        }
    }
}