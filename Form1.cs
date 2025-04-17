using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WindowsFormsApp8
{
    public partial class Form1 : Form
    {
        private BinaryTree tree;
        public Form1()
        {
            InitializeComponent();
            tree = new BinaryTree();
        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }

        private void button5_Click(object sender, EventArgs e)
        {
            string name = textBox1.Text;
            int age = int.Parse(textBox2.Text);
            string address = textBox3.Text;
            float amountOwed = float.Parse(textBox4.Text);

            Customer customer = new Customer(name, age, address, amountOwed);

            tree.insertInTree(customer);
            showMsg("Value is added in the Binary Tree.");
            updateDisplayOfCounter();
        }
        private void updateDisplayOfCounter()
        {
            textBox7.Text = tree.countTree().ToString();
        }
        private void showMsg(string msg)
        {
            textBox6.Text = msg;
        }

        private void button1_Click(object sender, EventArgs e)
        {
            showMsg(tree.searchCustomerByName(textBox5.Text));
        }

        private void textBox5_TextChanged(object sender, EventArgs e)
        {

        }

        private void textBox7_TextChanged(object sender, EventArgs e)
        {

        }

        private void textBox6_TextChanged(object sender, EventArgs e)
        {

        }

        private void button6_Click(object sender, EventArgs e)
        {
            tree.clearTree();
            showMsg("Binary Tree is cleared.");
            updateDisplayOfCounter();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            showMsg(tree.preOrderTree());
        }

        private void button3_Click(object sender, EventArgs e)
        {
            showMsg(tree.inOrderTree());
        }

        private void button4_Click(object sender, EventArgs e)
        {
            showMsg(tree.postOrderTree());
        }
    }
}
