using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace SDA_4
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        LinkedList<string> ll = new LinkedList<string>();
        LinkedListNode<string> current = new LinkedListNode<string>(null);

        private void Print(LinkedList<string> ll)
        {
            LinkedListNode<string> aNode = ll.First;
            richTextBox1.Text += String.Format("Списък: ");
            while (aNode != null)
            {
                richTextBox1.Text += String.Format("{0} -> ", aNode.Value);
                aNode = aNode.Next;
            }
            richTextBox1.Text += String.Format("\n");
        }

        private void btnAddFirst_Click(object sender, EventArgs e)
        {
            string itemValue = textValue.Text;
            LinkedListNode<string> node = new LinkedListNode<string>(itemValue);
            ll.AddFirst(node);
            textValue.Text = "";
            Print(ll);
        }

        private void btnAddAfter_Click(object sender, EventArgs e)
        {
            string itemValue = textValue.Text;
            string textCurr = textCurrent.Text;
            if ((textCurr != "") && (itemValue != ""))
            {
                LinkedListNode<string> node = new LinkedListNode<string>(itemValue);
                ll.AddAfter(current, node);
                textValue.Text = "";
                Print(ll);
            }
        }

        private void btnFind_Click(object sender, EventArgs e)
        {
            string itemValue = textValue.Text;
            current = ll.Find(itemValue);
            if (current != null)
            {
                textCurrent.Text = current.Value;
            }
            textValue.Text = "";
        }

        private void btnRemove_Click(object sender, EventArgs e)
        {
            string textCurr = textCurrent.Text;
            if ((textCurr != ""))
            {
                ll.Remove(current);
                Print(ll);
                current = ll.First;
                if (current != null)
                {
                    textCurrent.Text = current.Value;
                }
                else
                {
                    textCurrent.Text = "";
                }
            }
        }

        private void btnAddLast_Click(object sender, EventArgs e)
        {
            string itemValue = textValue.Text;
            LinkedListNode<string> node = new LinkedListNode<string>(itemValue);
            ll.AddAfter(ll.Last, node);
            textValue.Text = "";
            Print(ll);
        }

        private void textValue_TextChanged(object sender, EventArgs e)
        {

        }

        private void richTextBox1_TextChanged(object sender, EventArgs e)
        {

        }

    }
}
