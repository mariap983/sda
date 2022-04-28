using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Collections;

namespace SDA_3
{
    public partial class Form1 : Form
    {
        private PriorityQueue<string> Queue = new PriorityQueue<string>();

        public Form1()
        {
            InitializeComponent();
        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }

        private void btnDequeue_Click(object sender, EventArgs e)
        {
            string top_value;
            int top_priority;
            Queue.Dequeue(out top_value, out top_priority);
            txtValue.Text = top_value;
            txtPriority.Text = top_priority.ToString();
            btnDequeue.Enabled = (Queue.NumItems > 0);
        }


        class PriorityQueue<T>
        {
            List<T> Values = new List<T>();
            List<int> Priorities = new List<int>();

            public int NumItems
            {
                get
                {
                    return Values.Count;
                }
            }

            public void Enqueue(T new_value, int new_priority)
            {
                Values.Add(new_value);
                Priorities.Add(new_priority);
            }

            public void Dequeue(out T top_value, out int top_priority)
            {
                int best_index = 0;
                int best_priority = Priorities[0];
                for (int i = 1; i < Priorities.Count; i++)
                {
                    if (best_priority > Priorities[i])
                    {
                        best_priority = Priorities[i];
                        best_index++;
                    }
                }
                top_value = Values[best_index];
                top_priority = best_priority;
                Values.RemoveAt(best_index);
                Priorities.RemoveAt(best_index);
            }
        }

        private void btnEnqueue_Click(object sender, EventArgs e)
        {
            string name;
            int priority;

            if (txtValue.Text != "")
            {
                name = txtValue.Text;
            }
            else
            {
                MessageBox.Show("Полето 'Процес' не може да бъде празно");
                return;
            }

            bool result = int.TryParse(txtPriority.Text, out priority);
            if (result)
            {
                priority = int.Parse(txtPriority.Text);
            }
            else
            {
                MessageBox.Show("В полето ' Приоритет' трябва да има число");
                return;
            }

            Queue.Enqueue(name, priority);
            richTextBox1.Text += String.Format("Процес [{0}]\t Приоритет = {1}.\n", name, priority);
            txtValue.Clear();
            txtPriority.Clear();
            txtValue.Focus();
            btnDequeue.Enabled = true;
        }
    }
}
