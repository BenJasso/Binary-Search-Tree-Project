using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BinaryTreeSearch
{
    public class BinaryTree
    {
        //member variables
        public Node root;
        public Node temp;
        public bool methodSwitch;






        //constructor
        public BinaryTree()
        {



        }



        //member methods

        public void add(int value)
        {
            methodSwitch = true;
            // if root is empty
            temp = new Node(value);
            if (root == null)
            {
                root = new Node(value);
            }


            //if root exists
            else
            {
               
                Node parent;
                Node child = root;
                while (methodSwitch == true)
                {
                    parent = child;
                    if (value < child.data)
                    {
                        child = child.left;
                        if (child == null)
                        {
                            parent.left = temp;
                            methodSwitch = false;
                        }

                    }
                    else
                    {
                        child = child.right;
                        if (child == null)
                        {
                            parent.right = temp;
                            methodSwitch = false;

                        }
                    }
                }
                methodSwitch = true;


            }




        }
        public bool treeSearch(int value)
        {
            bool answer = false;
            methodSwitch = true;
            Node child = root;
            Node parent;
            while (methodSwitch == true)
            {


                parent = child;
                if(value == child.data)
                {
                    answer = true;
                    methodSwitch = false;
                }
                else if (value < child.data)
                {
                    child = child.left;
                    if (child == null)
                    {
                        answer = false;
                        methodSwitch = false;
                        
                       
                    }
                    
                   
                }
                else if (value > child.data)
                {
                    child = child.right;
                    if (child == null)
                    {
                        answer = false;
                        methodSwitch = false;

                    }
                   
                    
                }
                

            }
            return answer;
        }
    }



    



}
