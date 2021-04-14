using System;
using System.Collections.Generic;

namespace JonesDenee_BinaryTreeCodingChallenge
{
    public class BinaryTree
    {
        protected Node root;

        /// <summary>
        /// constructor
        /// </summary>
        public BinaryTree()
        {
            root = null;
        }

        /// <summary>
        /// Returns the root node of the tree
        /// </summary>
        /// <returns>Node</returns>
        public Node ReturnTheRoot()
        {
            return root;
        }

        /// <summary>
        /// Inserts node data
        /// </summary>
        /// <param name="dataItem"></param>
        public void Insert(int dataItem)
        {
            Node newNode = new Node();

            newNode.DataItem = dataItem;

            //if root doesn't exist, create the root with the new Node
            if (root == null)
            {
                root = newNode;

            }

            //if root exists, set the current node to it and add the new Node as a child
            // depending on if the new Node is lesser than, or greater than the parent
            else
            {
                Node currNode = root;
                Node parentNode;
                while (true)
                {
                    parentNode = currNode;

                    //if the inserted number is less than the current node set it as the left node of the parent
                    if (dataItem < currNode.DataItem)
                    {
                        currNode = currNode.Left;
                        if (currNode == null)
                        {
                            parentNode.Left = newNode;
                            return;
                        }
                    }

                    //else if the inserted number is less than the current node, set it as the right node of the parent
                    else
                    {
                        currNode = currNode.Right;
                        if (currNode == null)
                        {
                            parentNode.Right = newNode;
                            return;
                        }
                    }
                }
            }
        }

        /// <summary>
        /// Orders by Breadth-First w/ no recursion
        /// </summary>
        /// <param name="root"></param>
        public void BreadthFirstOrder(Node root)
        {
            //return if root is null because then there's no tree to traverse
            if (root == null)
            {
                Console.WriteLine("Root cannot be null, please insert node data");
                return;
            }

            //using a queue for FIFO & to discard node after retrieving dataItem from it
            Queue<Node> queue = new Queue<Node>();
            queue.Enqueue(root); //adding to end of queue

            //while there are nodes in the queue, dequeue to display them one level at a time until queue is empty
            while (queue.Count > 0)
            {
                Node curNode = queue.Dequeue();

                //if the current node is null start the loop over with the next node
                if (curNode == null)
                {
                    continue;
                }

                queue.Enqueue(curNode.Left); //adding left node to end of queue
                queue.Enqueue(curNode.Right); //adding right node to end of queue
                Console.Write(curNode.DataItem + " "); //output data of current node in loop
            }
        }



    }

    /// <summary>
    /// Gets/Sets the Node of the Tree
    /// </summary>
    public class Node
    {
        public int DataItem { get; set; }
        public Node Left { get; set; } //always less than the parent
        public Node Right { get; set; } //always greater than the parent
    }

}

