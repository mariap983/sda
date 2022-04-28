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

namespace SDA_7
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        SortedList phoneBookSL = new SortedList();

        private void btnAdd_Click(object sender, EventArgs e)
        {
            string key = tbKey.Text;
            string value = tbValue.Text;

            if (key.Length == 0)
            {
                richTextBox1.Text += String.Format("Полето [Служител] е разно!\n");
            }
            else if (value.Length == 0)
            {
                richTextBox1.Text += String.Format("Полето [Телефон] е празно!\n");
            }
            else if (phoneBookSL.ContainsKey(key) && phoneBookSL.ContainsValue(value))
            {
                richTextBox1.Text += String.Format(" Служител [{0}] и телефон [{1}] вече са въведени!\n", value, key);
            }
            else if (phoneBookSL.ContainsKey(key))
            {
                richTextBox1.Text += String.Format("Телефонен номер [{0}] вече е въведен!\n", key);
            }
            else
            {
                phoneBookSL.Add(key, value);
                richTextBox1.Text += String.Format("{0}: {1}\n", value, key);
            }
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            phoneBookSL.Add("555", "IT отдел");
            phoneBookSL.Add("556", "IT отдел");
            phoneBookSL.Add("111", "Директор");
            phoneBookSL.Add("222", "Мниистър председателя");
            phoneBookSL.Add("333", "Бай ти Гошо");
            phoneBookSL.Add("444", "Хари от 10-тия етаж");
        }
        private void ShowPhoneBook()
        {
            if (phoneBookSL.Count != 0)
            {
                richTextBox1.Text += String.Format("Съдържание на речника-телефонен указател: \n");
                richTextBox1.Text += String.Format("Ключ\tСтойност\n");
                int i = 0;
                foreach (DictionaryEntry element in phoneBookSL)
                {
                    richTextBox1.Text += String.Format("{0}\t {1}\n", element.Key, element.Value);
                    i++;
                }
            }
            else richTextBox1.Text += String.Format("Телефонният указател е празен.\n");
        }

        private void btnRemove_Click(object sender, EventArgs e)
        {
            string key = tbKey.Text;
            string value = tbValue.Text;
            if (key.Length == 0)
            {
                richTextBox1.Text += String.Format("Полето [Служител] е празно!\n");
            }
            else if (value.Length == 0)
            {
                richTextBox1.Text += String.Format("Полето [телефон] е празно!\n");
            }
            else if (phoneBookSL.ContainsKey(key) && phoneBookSL.ContainsValue(value))
            {
                richTextBox1.Text += String.Format("Изтриване на обект с данни: Служител: [{0}], телефон: [{1}]\n", value, key);
                phoneBookSL.Remove(key);
            }
            else
            {
                richTextBox1.Text += String.Format("Не е намерен служител с данни: Служител: [{0}], телефон: [{1}]\n", value, key);
            }
        }

        private void btnRemoveAgent_Click(object sender, EventArgs e)
        {
            int id;
            string value = tbValue.Text;

            if (value.Length == 0)
            {
                richTextBox1.Text += String.Format("Полето [Служител] е празно!\n");
            }
            else if (phoneBookSL.ContainsValue(value))
            {
                do
                {
                    id = phoneBookSL.IndexOfValue(value);
                    richTextBox1.Text += String.Format("Изтриване на Служител: [{0}], телефон : [{1}]\n", value, phoneBookSL.GetKey(id).ToString());
                    phoneBookSL.RemoveAt(id);
                } while (phoneBookSL.ContainsValue(value));

            }
            else
            {
                richTextBox1.Text += String.Format("Не е намерен Служител: [{0}]\n", value);
            }
        }

        private void btnRemovePhone_Click(object sender, EventArgs e)
        {
            string key = tbKey.Text;
            int id;
            if (key.Length == 0)
            {
                richTextBox1.Text += String.Format("Полето [Телефон] е празно!\n");
            }
            else if (phoneBookSL.ContainsKey(key))
            {
                id = phoneBookSL.IndexOfKey(key);
                richTextBox1.Text += String.Format("Изтриване на Телефон: [{0}], Служител: [{1}]\n", key, phoneBookSL.GetByIndex(id).ToString());
                phoneBookSL.Remove(key);
            }
            else
            {
                richTextBox1.Text += String.Format("Не е намерен телефон: [{0}]\n", key);
            }
        }

        private void btnAgentSearch_Click(object sender, EventArgs e)
        {
            string value = tbValue.Text.ToString();
            if (value.Length == 0)
            {
                richTextBox1.Text += String.Format("Полето [Служител] е празно\n");
            }
            else
            {
                richTextBox1.Text += String.Format("Търсене на служител: [{0}]\n", value);
                if (phoneBookSL.ContainsValue(value))
                {
                    int id = phoneBookSL.IndexOfValue(value);
                    for (int i = id; i < phoneBookSL.Count; i++)
                    {
                        if (phoneBookSL.GetByIndex(i).ToString() == value)
                        {
                            richTextBox1.Text += String.Format("Служител: [{0}], Телефон: [{1}]\n", value, phoneBookSL.GetKey(i).ToString());
                        }
                    }
                }
                else
                {
                    richTextBox1.Text += String.Format("Не е намерен Служител: [{0}]\n", value);
                }
            }
        }

        private void btnPhoneSearch_Click(object sender, EventArgs e)
        {
            string key = tbKey.Text;
            if (key.Length == 0)
            {
                richTextBox1.Text += String.Format("Полето [Телефон] е празно!\n");
            }
            else
            {
                richTextBox1.Text += String.Format("Търсене на телефон: [{0}]\n", key);
                if (phoneBookSL.ContainsKey(key))
                {
                    int id = phoneBookSL.IndexOfKey(key);
                    richTextBox1.Text += String.Format("Телефон: [{0}], Служител: [{1}]\n", key, phoneBookSL.GetByIndex(id).ToString());
                }
                else
                {
                    richTextBox1.Text += String.Format("Не е намерен телефон: [{0}]\n", key);
                }
            }
        }

        private void btnCopyTo_Click(object sender, EventArgs e)
        {
            DictionaryEntry[] arrPhoneBook = new DictionaryEntry[phoneBookSL.Count];
            phoneBookSL.CopyTo(arrPhoneBook, 0);
            richTextBox1.Text += String.Format("Създаване на масив arrPhoneBook\n"
                + "чрез метода CopyTo от речника phoneBook.\n"
                + "Съдърание на масива arrPhoneBook:\n");
            foreach (DictionaryEntry element in arrPhoneBook)
            {
                richTextBox1.Text += String.Format("{0}\t {1}\n", element.Key, element.Value);
            }
        }
    }
}

