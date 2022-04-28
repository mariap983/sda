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

namespace SDA_2
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            ArrayList citiesOfDunabe = new ArrayList();
            citiesOfDunabe.Add("Видин");
            citiesOfDunabe.Add("Оряхово");
            citiesOfDunabe.Add("Никопол");
            citiesOfDunabe.Add("Белене");
            ShowArrayList2(sender, citiesOfDunabe, "Първи списък на градове");

            string[] newCities = new string[] { "Лом", "Козлодуй" };
            ArrayList moreCities = new ArrayList();
            moreCities.Add("Свищов");
            moreCities.Add("Русе");
            moreCities.Add("Тутракан");
            moreCities.Add("Силистра");

            citiesOfDunabe.InsertRange(1, newCities);

            citiesOfDunabe.AddRange(moreCities);
            ShowArrayList2(sender, citiesOfDunabe, "Списък след добавяне чрез InsertRange & AddRange");

            ArrayList someCities = citiesOfDunabe.GetRange(2, 4);
            ShowArrayList2(sender, someCities, "Списък получен с метода GetRange()");

            Object[] arrCities;
            arrCities = citiesOfDunabe.ToArray();
            richTextBox1.Text += String.Format("\n Списък получен с метода ToArray()\n");
            for (int i = 0; i <= arrCities.GetUpperBound(0); i++)
            {
                richTextBox1.Text += String.Format("Позиция = {0} \t Стойност = {1}\n", i, arrCities[i]);
            }

        }
        private void ShowArrayList2(object sender, ArrayList arr, string title)
        {
            int position = 0;
            richTextBox1.Text += String.Format("\n{0}:\n", title);
            foreach (Object obj in arr)
            {
                richTextBox1.Text += String.Format("Позиция = {0} \t Стойност = {1}\n", position++, obj.ToString());
            }

        }

        private void richTextBox1_TextChanged(object sender, EventArgs e)
        {

        }
    }
}
