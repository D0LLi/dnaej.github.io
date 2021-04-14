using System;

/* Creator: Denee Jones
 * Program:
 * This program creates nodes and and inserts them into a binary tree, given the root node and prints out the contents in
 * Breadth-First traversal (without the use of recursion)
 * I've placed the objects in separate classes from the main method
 */
namespace JonesDenee_BinaryTreeCodingChallenge
{
    public class JonesDenee_BinaryTreeCodingChallenge
    {



        static void Main()
        {
            //establish the Binary Tree
            BinaryTree bTree = new BinaryTree();

            Console.WriteLine("-----Traversing Binary Tree Breadth-First-----");

            //Call the insert function to insert nodes

            //root (level 0)
            bTree.Insert(50);

            bTree.Insert(20); //level 1
            bTree.Insert(15); //level 2
            bTree.Insert(48); //level 2
            bTree.Insert(3);  //level 3
            bTree.Insert(18); //level 3
            bTree.Insert(30); //level 3
            bTree.Insert(49); //level 3

            bTree.Insert(60); //level 1
            bTree.Insert(55); //level 2
            bTree.Insert(70); //level 2
            bTree.Insert(85); //level 3
            bTree.Insert(65); //level 3
            bTree.Insert(52); //level 3

            bTree.Insert(16); //level 4
            bTree.Insert(68); //level 4


            //Call the order function to order it Breadth-First, given the root
            bTree.BreadthFirstOrder(bTree.ReturnTheRoot());

            //read next input to pause console
            Console.WriteLine("");
            Console.Write("press any key to end...");
            Console.Read();
            return;
        }
    }

}
