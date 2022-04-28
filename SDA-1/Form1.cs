using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Collections;
using System.Windows.Forms;

namespace SDA_1
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }
        public class Int16Collection : CollectionBase
        {
            public Int16 this[int index]
            {
                get
                {
                    return ((Int16)List[index]);
                }
                set
                {
                    List[index] = value;
                }
            }
            public int Add(Int16 value)
            {
                return (List.Add(value));
            }
            public int IndexOf(Int16 value)
            {
                return (List.IndexOf(value));
            }
            public void Insert(int index, Int16 value)
            {
                List.Insert(index, value);
            }
            public void Remove(Int16 value)
            {
                List.Remove(value);
            }
            public bool Contains(Int16 value)
            {
                return (List.Contains(value));
            }

        }
        private string ShowIndexAndValues(Int16Collection myCol)
        {
            string str = "";
            for (int i = 0; i < myCol.Count; i++)
            {
                str += String.Format(" [{0}]: {1}\n", i, myCol[i]);
            }
            return str;
        }
        private string ShowValues1(Int16Collection myCol)
        {
            string str = "";
            foreach (Int16 i16 in myCol)
            {
                str += String.Format(" {0}\n", i16);
            }
            return str;
        }
        private string ShowValues2(Int16Collection myCol)
        {
            string str = "";
            System.Collections.IEnumerator myEnumerator = myCol.GetEnumerator();
            while (myEnumerator.MoveNext())
            {
                str += String.Format(" {0}\n", myEnumerator.Current);
            }
            return str;
        }

        private void button1_Click(object sender, EventArgs e)
        {
            Int16Collection myInt16 = new Int16Collection();

            myInt16.Add((Int16)1);
            myInt16.Add((Int16)2);
            myInt16.Add((Int16)3);
            myInt16.Add((Int16)5);
            myInt16.Add((Int16)7);

            richTextBox1.Text = "Съдържанието на колекцията (използва се foreach):\n";
            richTextBox1.Text += ShowValues1(myInt16);

            richTextBox1.Text += "Съдържание на колекцията (изпозва се enumator):\n";
            richTextBox1.Text += ShowValues2(myInt16);

            richTextBox1.Text += "Първоначално съдържание на колекцията (иползва се count & Item):\n";
            richTextBox1.Text += ShowIndexAndValues(myInt16);

            richTextBox1.Text += String.Format("В колекцията има ли стойност 3? - {0}\n", myInt16.Contains(3));
            richTextBox1.Text += String.Format(" Стойността 7 е в елемент с индекс {0}.\n", myInt16.IndexOf(7));

            myInt16.Insert(3, (Int16)12);
            richTextBox1.Text += "Съдържание на колекцията след добавяне на индекс 3:\n";
            richTextBox1.Text += ShowIndexAndValues(myInt16);

            myInt16[4] = 23;
            richTextBox1.Text += "Съдържание на колекцията след задаване на стойност 23 в индекс 4:\n";
            richTextBox1.Text += ShowIndexAndValues(myInt16);

            myInt16.Remove((Int16)2);
            richTextBox1.Text += "Съдържание на колекцията след премахване на елемент 2:\n";
            richTextBox1.Text += ShowIndexAndValues(myInt16);
        }

        private void richTextBox1_TextChanged(object sender, EventArgs e)
        {

        }
    }
}
