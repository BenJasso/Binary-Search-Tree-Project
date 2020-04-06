using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BinaryTreeSearch
{
    class Program
    {
        static void Main(string[] args)
        {


            BinaryTree tree = new BinaryTree();

            tree.add(32);
            tree.add(48);
            tree.add(52);
            tree.add(51);
            
            bool answer = tree.treeSearch(51);
            Console.WriteLine(answer);
            Console.ReadLine();


    }
    }
}
