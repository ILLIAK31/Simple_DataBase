using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace App5_Illia_Karmazin_
{
    public partial class Form1 : Form
    {
        private List<Person> list = new List<Person>();
        public Form1()
        {
            InitializeComponent();
            this.FormBorderStyle = FormBorderStyle.FixedSingle;
            this.MaximizeBox = false;
        }

        private void button1_Click(object sender, EventArgs e)
        {
            try
            {
                Person person = new Person(textBox1.Text, textBox2.Text, textBox3.Text, textBox4.Text);
                list.Add(person);
            }
            catch (Exception ex)
            {
                // Error
            }
        }
        public class Person
        {
            public string name = "";
            public string surname = "";
            public string date;
            public string gender = "";
            public Person(string n, string s, string d, string g)
            {
                name = n;
                surname = s;
                date = d;
                gender = g;
            }
        }

        private void button3_Click(object sender, EventArgs e)
        {
            try
            {
                listBox1.Items.Clear();
                for (int index = 1;index < list.Count+1; ++index)
                {
                    listBox1.Items.Add("Person " + index);
                }
            }
            catch (Exception ex)
            {
                // Error
            }
        }

        private void listBox1_SelectedIndexChanged(object sender, EventArgs e)
        {
            try
            {
                int index = listBox1.SelectedIndex;
                textBox1.Text = list[index].name;
                textBox2.Text = list[index].surname;
                textBox3.Text = list[index].date;
                textBox4.Text = list[index].gender;
            }
            catch (Exception ex)
            {
                // Error
            }
        }

        private void button2_Click(object sender, EventArgs e)
        {
            try
            {
                int index = listBox1.SelectedIndex;
                list.RemoveAt(index);
            }
            catch (Exception ex)
            {
                // Error 
            }
        }
    }
}
