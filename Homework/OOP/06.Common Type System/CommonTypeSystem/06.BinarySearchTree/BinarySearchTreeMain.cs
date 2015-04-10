/*
    Define the data structure binary search tree with operations for "adding new element", "searching element" and "deleting elements". It is not necessary to keep the tree balanced.
    Implement the standard methods from System.Object – ToString(), Equals(…), GetHashCode() and the operators for comparison == and !=.
    Add and implement the ICloneable interface for deep copy of the tree.

Remark: Use two types – structure BinarySearchTree (for the tree) and class TreeNode (for the tree elements). Implement IEnumerable<T> to traverse the tree.*/
// I haven't solved Problem 6, it is taken from a colleague's homework. My knowledge still lacks those matters, so you may ignore this project while evaluating the rest of the Problems.

namespace _06.BinarySearchTree
    {
    using System;

    public class BinarySearchTreeMain
        {
        public static void Main()
            {
            var bst = new BinarySearchTree<int>();

            for (int i = 0; i < 20; i++)
                {
                bst.Insert(i + 1);
                }

            Console.WriteLine("Initially: {0}", bst);
            bst.BalanceTree();

            Console.WriteLine("Balanced: {0}", bst);
            Console.WriteLine("Traverse and print (DFS)");
            bst.TraverseDFS();

            var bst2 = new BinarySearchTree<int>();
            for (int i = 0; i < 20; i++)
                {
                bst2.Insert(i + 1);
                }
            bst2.BalanceTree();
            Console.WriteLine("Second tree (balanced): {0}", bst2);

            // returns true only if both trees have the same number of nodes, 
            // nodes hold equal values, and trees are balanced in the same way
            Console.WriteLine("First tree equals second tree? {0}", bst.Equals(bst2));

            var bst3 = (BinarySearchTree<int>)bst2.Clone();
            Console.WriteLine("Third tree, cloned from second: {0}", bst3);
            Console.WriteLine("Traverse and print cloned tree (DFS)");
            bst3.TraverseDFS();
            }
        }
    }
