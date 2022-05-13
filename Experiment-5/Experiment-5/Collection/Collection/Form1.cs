using System;
using System.Collections;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Collection
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void button3_Click(object sender, EventArgs e)
        {

            Hashtable ht = new Hashtable();
            ht.Add(1, "C");
            ht.Add(2, "CPP");
            ht.Add(3, "Java");
            ht.Add(4, "Python");
            ht.Add(5, "C#");

            string txt = "";
            foreach (DictionaryEntry d in ht)
            {
                txt = txt + " " + (d.Key + " " + d.Value);

            }
            txt_Output.Text = txt;

        }

        private void button2_Click(object sender, EventArgs e)
        {
            SortedList sortedList = new SortedList();

            sortedList.Add(1, "One");
            sortedList.Add(2, "Two");
            sortedList.Add(3, "Three");
            sortedList.Add(4, "Four");
            sortedList.Add(5, "Five");

            string ans = "";

            foreach(DictionaryEntry d in sortedList)
            {
                ans = ans + d.Key + "   " + d.Value + "   ";
            }

            txt_Output.Text = ans;
        }

        private void btn_ArrayList_Click(object sender, EventArgs e)
        {
            ArrayList al = new ArrayList();
            al.Add(100);
            al.Add("Hello world");
            al.Add(null);
            al.Add('A');
            al.Add(12345);
            string ans = "";
            foreach (var str in al)
            {
                //Console.WriteLine(i);

                ans = ans + "    " + str;

            }
            txt_Output.Text = ans;

        }

        private void btn_Exit_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void btn_Stack_Click(object sender, EventArgs e)
        {
            Stack stack = new Stack();

            stack.Push(1);
            stack.Push(2);
            stack.Push(3);
            stack.Push(4);
            stack.Push(5);
            stack.Push(6);
            stack.Push(7);

            stack.Pop();

            stack.Peek();

            string ans = "";
            foreach(var str in stack)
            {
                ans += str + "    ";
            }

            txt_Output.Text=ans;
        }

        private void btn_Queue_Click(object sender, EventArgs e)
        {
            Queue queue = new Queue();

            queue.Enqueue(1);
            queue.Enqueue(2);
            queue.Enqueue(3);
            queue.Dequeue();
            queue.Enqueue(4);
            queue.Enqueue(5);
            queue.Dequeue();

            string ans = "";
            foreach(var str in queue)
            {
                ans += str + "   ";
            }

            txt_Output.Text = ans;
        }
    }
}
