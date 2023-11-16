using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using static System.Windows.Forms.VisualStyles.VisualStyleElement;

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
                if (textBox1.Text == "" || textBox2.Text == "" || textBox3.Text == "" || textBox4.Text == "")
                {
                    throw new Exception();
                }
                Person person = new Person(textBox1.Text, textBox2.Text, textBox3.Text, textBox4.Text);
                list.Add(person);
            }
            catch (Exception ex)
            {
                MessageBox.Show("Data problem");
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
                listView1.Items.Clear();
                for (int index = 0; index < list.Count; ++index)
                {
                    ListViewItem item = new ListViewItem(list[index].name);
                    item.SubItems.Add(list[index].surname);
                    item.SubItems.Add(list[index].date);
                    item.SubItems.Add(list[index].gender);
                    listView1.Items.Add(item);
                }
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
                int index = 0;
                if (listView1.SelectedIndices.Count > 0)
                {
                    index = listView1.SelectedIndices[0];
                }
                list.RemoveAt(index);
            }
            catch (Exception ex)
            {
                // Error 
            }
        }

        private void listView1_SelectedIndexChanged(object sender, EventArgs e)
        {
            try
            {
                int index = 0;
                if (listView1.SelectedIndices.Count > 0)
                {
                    index = listView1.SelectedIndices[0];
                }
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
    }
}
