using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ДЗ__Работа_с_одномерным_и_двумерным_массивами_
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            richTextBox1.Text = ""; // очищаем текстбоксы после каждого нажатия кнопки
            richTextBox2.Text = "";
            int[,] arr = new int[10, 10]; // двумерный массив 10 на 10

            Random R = new Random();

            for (int i = 0; i<10;i++)
            {
                for(int j=0; j < 10; j++ )
                {
                    arr[i, j] = R.Next(100, 1000);
                    richTextBox1.Text += arr[i,j] + " ";
                }
                richTextBox1.Text += "\n";
            }
            for(int i =0 ;i < 10; i++)
            {
                for(int j = 0; j < 10; j++)
                {
                    if (arr[i,j] > 500)
                    {
                        arr[i, j] = 0;
                    }
                    richTextBox2.Text += arr[i,j] + " ";
                }
                richTextBox2.Text += "\n";
            }
        }

        private void button2_Click(object sender, EventArgs e)
        {
            richTextBox1.Text = "";
            richTextBox2.Text = "";
            int[] arr = new int[10];

            Random R = new Random();

            for (int i = 0; i < 10; i++)
            {
                arr[i] = R.Next(1, 20);
                richTextBox1.Text += arr[i] + "\n";
            }
            for(int i = 0; i<10; i++)
            {
                while (arr[i]<10)
                {
                    arr[i] = R.Next(1, 20);
                }
                richTextBox2.Text += arr[i] + "\n";
            }
        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {
            try
            {

                if (textBox1.Text != "" && textBox1.Text != "-")
                {
                    int a = Convert.ToInt32(textBox1.Text);
                    if (a < 0)
                    {
                        button1.BackColor = Color.DarkBlue;
                        button1.ForeColor = Color.White;
                    }
                    else if (a > 0)
                    {
                        button1.BackColor = Color.Orange;
                    }
                    else
                    {
                        button1.BackColor = Color.Blue;
                    }
                }
            }
            catch
            {

            }
        }


        private void button4_Click(object sender, EventArgs e)
        {
            try 
            { 
                int a = 5, b = 0, c = a / b; 
            }
            catch(Exception exp)
            {
                MessageBox.Show(exp.ToString(), "Error", MessageBoxButtons.YesNoCancel, MessageBoxIcon.Error);
            }
        }

        private void textBox1_KeyDown(object sender, KeyEventArgs e)
        {
           
        }

        private void textBox1_KeyPress(object sender, KeyPressEventArgs e)
        {
            if((e.KeyChar < 48 || e.KeyChar > 57) && e.KeyChar != 8 && e.KeyChar != 45)
            {
                e.Handled = true;
            }
        }

        private void textBox2_KeyDown(object sender, KeyEventArgs e)
        {
            if(e.KeyCode == Keys.Enter)
            {
                Application.Exit();
            }
            if(e.KeyCode == Keys.Escape)
            {
                Application.Restart();
            }
        }
    }
}
