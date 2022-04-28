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
using System.IO;

namespace SDA_6
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }
        private Hashtable g = new Hashtable();

        private void BuildGlossary(Hashtable g)
        {
            StreamReader inFile;
            string line;
            string[] words;
            inFile = File.OpenText("dictionary.txt");
            char[] delimiter = new char[] { '#' };
            while (inFile.Peek() != -1)
            {
                line = inFile.ReadLine();
                words = line.Split(delimiter);
                g.Add(words[0], words[1]);
            }
            inFile.Close();
        }
        private void DisplayWords(Hashtable g)
        {
            Object[] words = new Object[g.Count];
            g.Keys.CopyTo(words, 0);
            for (int i = 0; i <= words.GetUpperBound(0); i++)
            {
                if (!(words[i] == null))
                    lbWord.Items.Add((words[i]));
            }
        }
        private void richTextBox1_TextChanged(object sender, EventArgs e)
        {

        }

        private void lbWord_SelectedIndexChanged(object sender, EventArgs e)
        {
            Object word;
            word = lbWord.SelectedItem;
            richTextBox1.Text = g[word].ToString();
        }

        private void Form1_Load_1(object sender, EventArgs e)
        {
            BuildGlossary(g);
            DisplayWords(g);
            lbWord.SelectedIndex = 0;
            Object word;
            word = lbWord.SelectedItem;
            richTextBox1.Text = g[word].ToString();
        }
    }
}
