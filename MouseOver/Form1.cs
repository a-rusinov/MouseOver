using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace MouseOver
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }
        string FText = "Отображение текста в строке состояния при наведении курсора мыши на элемент управления";
        private void Form1_Load(object sender, EventArgs e)
        {
            this.Text = FText;
        }

        private void button1_MouseMove(object sender, MouseEventArgs e)
        {
            toolStripStatusLabel1.Text = "Вы навели указатель Мыши на элемент управления Кнопка  " + button1.Text; 
        }

        private void button5_MouseMove(object sender, MouseEventArgs e)
        {
            toolStripStatusLabel1.Text = "Вы навели указатель Мыши на элемент управления Кнопка  " + button5.Text;

        }

        private void button4_MouseMove(object sender, MouseEventArgs e)
        {
            toolStripStatusLabel1.Text = "Вы навели указатель Мыши на элемент управления Кнопка  " + button4.Text;

        }

        private void button3_MouseMove(object sender, MouseEventArgs e)
        {
            toolStripStatusLabel1.Text = "Вы навели указатель Мыши на элемент управления Кнопка  " + button3.Text;

        }

        private void button2_MouseMove(object sender, MouseEventArgs e)
        {
            toolStripStatusLabel1.Text = "Вы навели указатель Мыши на элемент управления Кнопка  " + button2.Text;

        }
    }
}
