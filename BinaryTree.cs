using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WindowsFormsApp8
{
    internal class BinaryTree
    {
        Node root;
        public BinaryTree()
        {
            root = null;
        }
        public BinaryTree(Node root)
        {
            this.root = root;
        }
        public void clearTree()
        {
            root = null;
        }
        public void insertInTree(Customer value)
        {
            root = insertNode(root, value);
        }
        private Node insertNode(Node root, Customer value)
        {
            if (root == null)
            {
                root = new Node(value);
                return root;
            }
            if (root.data.isLessThan(value))
                root.left = insertNode(root.left, value);
            else if (root.data.isGreaterThan(value))
                root.right = insertNode(root.right, value);

            return root;
        }
        public int countTree()
        {
            return countNode(root);
        }
        private int countNode(Node root)
        {
            if (root == null)
                return 0;

            return countNode(root.left) + countNode(root.right) + 1;
        }
        private string showResult(string result)
        {
            if (result == "")
            {
                return "Binary Tree is Empty";
            }
            return result;
        }
        public string preOrderTree()
        {
            return showResult(preOrder(root));
        }
        private string preOrder(Node root)
        {
            string result = "";
            if (root != null)
            {
                result += root.data.GetInformation() + ",\n";
                result += preOrder(root.left);
                result += preOrder(root.right);
            }
            return result;
        }
        public string inOrderTree()
        {
            return showResult(inOrder(root));
        }
        private string inOrder(Node root)
        {
            string result = "";
            if (root != null)
            {
                result += inOrder(root.left);
                result += root.data.GetInformation() + ",\n";
                result += inOrder(root.right);
            }
            return result;
        }
        public string postOrderTree()
        {
            return showResult(postOrder(root));
        }
        private string postOrder(Node root)
        {
            string result = "";
            if (root != null)
            {
                result += postOrder(root.left);
                result += postOrder(root.right);
                result += root.data.GetInformation() + ",\n";
            }
            return result;
        }

        public string searchCustomerByName(string name)
        {
            var customer = depthFirstSearch(root, name);
            if (customer == null)
            {
                return "No Customer found with name '" + name + "'.";
            }
            return customer.GetInformation();
        }

        private Customer depthFirstSearch(Node root, string name)
        {
            if (root == null)
                return null;

            if (root.data.Name == name)
                return root.data;

            Customer foundInLeft = depthFirstSearch(root.left, name);
            if (foundInLeft != null)
                return foundInLeft;

            Customer foundInRight = depthFirstSearch(root.right, name);
            if (foundInRight != null)
                return foundInRight;

            return null;
        }
    }
}
