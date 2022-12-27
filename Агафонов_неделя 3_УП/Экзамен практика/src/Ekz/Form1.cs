using System;
using System.Windows.Forms;

namespace Ekz
{
    public partial class Form1 : Form
    {
        bool flag = false;
        bool select;
        double x, y;
        public Form1()
        {
            InitializeComponent();
        }

        private void выходToolStripMenuItem_Click(object sender, EventArgs e)
        {
            this.Close();
        }
        void f1()
        {
            if(Double.TryParse(textBox1.Text, out x) && Double.TryParse(textBox2.Text, out y))
            {
                if (x > 2 && x * x - y * y < 36)
                {
                    MessageBox.Show("Находится внутри функций");
                    toolStripStatusLabel1.Text = "Находится внутри функций";
                }
                else if (x == 2 || x* x -y * y ==36)
                {
                    MessageBox.Show("Находится на функциях");
                    toolStripStatusLabel1.Text = "Находится на функциях";
                }
                else
                {
                    MessageBox.Show("Находится вне функций");
                    toolStripStatusLabel1.Text = "Находится вне функций";
                }
            }
            else
            {
                MessageBox.Show("Точки должны определяться вещественным числом");
            }
        }
        void f2()
        {
            if (Double.TryParse(textBox1.Text, out x) && Double.TryParse(textBox2.Text, out y))
            {
                if ((x > -1 && y>0 && y<-x)||(x*x+y*y<1&&x>0&&y<0))
                {
                    MessageBox.Show("Находится внутри функций");
                    toolStripStatusLabel1.Text = "Находится внутри функций";
                }
                else if ((x == -1 || y == 0 || y == -x) || (x * x + y * y == 1 || x == 0 || y == 0))
                {
                    MessageBox.Show("Находится на функциях");
                    toolStripStatusLabel1.Text = "Находится на функциях";
                }
                else
                {
                    MessageBox.Show("Находится вне функций");
                    toolStripStatusLabel1.Text = "Находится вне функций";
                }
            }
            else
            {
                MessageBox.Show("Точки должны определяться вещественным числом");
            }
        }
        private void открытьToolStripMenuItem_Click(object sender, EventArgs e)
        {
            webBrowser1.AllowWebBrowserDrop = false;
            openFileDialog1.Filter = "TextFiles(*.html)|*.html|AllFiles(*.*)|*.*";
            openFileDialog1.ShowDialog();
            if(!flag)
            {
                this.Height += 100;
                flag = true;                
            }
            string[] repSplit = openFileDialog1.FileName.Split('\\');
            string curFile = repSplit[repSplit.Length - 1];
            if (curFile == "1.html")
            {
                webBrowser1.Navigate(openFileDialog1.FileName);
                select = true;
            }
            else if (curFile == "2.html")
            {
                webBrowser1.Navigate(openFileDialog1.FileName);
                select = false;
            }
            else
            {
                MessageBox.Show($"Нет решения для {curFile}. Попробуйте выбрать файлы 1.html и 2.html");
            }
        }

        private void оПрограммеToolStripMenuItem_Click(object sender, EventArgs e)
        {
            MessageBox.Show("Программу разработал:\nСтудент группы ПКсп-119\nCусалев Андрей Сергеевич\nВариант 2.");
        }


        private void button1_Click(object sender, EventArgs e)
        {
            if (select)
            {
                f1();
            }
            else
            {
                f2();
            }
        }
    }
}