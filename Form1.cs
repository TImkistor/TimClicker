using System;
using System.IO;
using System.Windows.Forms;

namespace Clicker
{
    public partial class Form1 : Form
    {
        private int score;
        private int zaklik = 1;
        private int zasec;

        public Form1()
        {
            InitializeComponent();
            timer1.Tick += Timer1OnTick;
        }

        private void Timer1OnTick(object? sender, EventArgs e)
        {
            score += zasec;
            textBox7.Text = "Всего очков: " + score;
            saveDataToFile();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            score += zaklik;
            textBox7.Text = "Всего очков: " + score;
        }

        private void button4_Click(object sender, EventArgs e)
        {
            if (score >= Convert.ToInt32(textBox1.Text))
            {
                score -= Convert.ToInt32(textBox1.Text);
                textBox1.Text = Convert.ToInt32(Convert.ToDouble(textBox1.Text) * 1.4).ToString();
                zaklik += Convert.ToInt32((sender as Button).Text);
                textBox5.Text = "Очков за Клик " + zaklik;
                textBox7.Text = "Всего очков: " + score;
            }
        }

        private void button2_Click(object sender, EventArgs e)
        {
            if (score >= Convert.ToInt32(textBox2.Text))
            {
                score -= Convert.ToInt32(textBox2.Text);
                textBox2.Text = Convert.ToInt32(Convert.ToDouble(textBox2.Text) * 1.4).ToString();
                zaklik += Convert.ToInt32((sender as Button).Text);
                textBox5.Text = "Очков за Клик " + zaklik;
                textBox7.Text = "Всего очков: " + score;
            }
        }

        private void button3_Click(object sender, EventArgs e)
        {
            if (score >= Convert.ToInt32(textBox3.Text))
            {
                score -= Convert.ToInt32(textBox3.Text);
                textBox3.Text = Convert.ToInt32(Convert.ToDouble(textBox3.Text) * 1.4).ToString();
                zasec += Convert.ToInt32((sender as Button).Text);
                textBox6.Text = "Очков за Автоклик " + zasec;
                textBox7.Text = "Всего очков: " + score;
            }
        }

        private void button5_Click(object sender, EventArgs e)
        {
            if (score >= Convert.ToInt32(textBox4.Text))
            {
                score -= Convert.ToInt32(textBox4.Text);
                textBox4.Text = Convert.ToInt32(Convert.ToDouble(textBox4.Text) * 1.4).ToString();
                zasec += Convert.ToInt32((sender as Button).Text);
                textBox6.Text = "Очков за Автоклик " + zasec;
                textBox7.Text = "Всего очков: " + score;
            }
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void label4_Click(object sender, EventArgs e)
        {

        }

        private void textBox7_TextChanged(object sender, EventArgs e)
        {

        }

        private void button6_Click(object sender, EventArgs e)
        {
            if (score >= Convert.ToInt32(textBox8.Text))
            {
                score -= Convert.ToInt32(textBox8.Text);
                textBox8.Text = Convert.ToInt32(Convert.ToDouble(textBox8.Text) * 1.4).ToString();
                zaklik += Convert.ToInt32((sender as Button).Text);
                textBox5.Text = "Очков за Клик " + zaklik;
                textBox7.Text = "Всего очков: " + score;
            }
        }

        private void textBox5_TextChanged(object sender, EventArgs e)
        {

        }

        private void label2_Click(object sender, EventArgs e)
        {

        }

        private void button7_Click(object sender, EventArgs e)
        {
            if (score >= Convert.ToInt32(textBox9.Text))
            {
                score -= Convert.ToInt32(textBox9.Text);
                textBox9.Text = Convert.ToInt32(Convert.ToDouble(textBox9.Text) * 1.4).ToString();
                zaklik += Convert.ToInt32((sender as Button).Text);
                textBox5.Text = "Очков за Клик " + zaklik;
                textBox7.Text = "Всего очков: " + score;
            }
        }

        private void textBox2_TextChanged(object sender, EventArgs e)
        {

        }

        private void button10_Click(object sender, EventArgs e)
        {
            if (score >= Convert.ToInt32(textBox10.Text))
            {
                score -= Convert.ToInt32(textBox10.Text);
                textBox10.Text = Convert.ToInt32(Convert.ToDouble(textBox10.Text) * 1.4).ToString();
                zasec += Convert.ToInt32((sender as Button).Text);
                textBox6.Text = "Очков за Автоклик " + zasec;
                textBox7.Text = "Всего очков: " + score;
            }
        }

        private void button9_Click(object sender, EventArgs e)
        {
            if (score >= Convert.ToInt32(textBox11.Text))
            {
                score -= Convert.ToInt32(textBox11.Text);
                textBox11.Text = Convert.ToInt32(Convert.ToDouble(textBox11.Text) * 1.4).ToString();
                zasec += Convert.ToInt32((sender as Button).Text);
                textBox6.Text = "Очков за Автоклик " + zasec;
                textBox7.Text = "Всего очков: " + score;
            }
        }

        private void saveDataToFile()
        {
            StreamWriter sw = new StreamWriter("./save.txt");
            sw.WriteLineAsync($"{score}");
            sw.WriteLineAsync($"{textBox1}");
            sw.WriteLineAsync($"{textBox2}");
            sw.WriteLineAsync($"{textBox3}");
            sw.WriteLineAsync($"{textBox4}");
            sw.WriteLineAsync($"{textBox5}");
            sw.WriteLineAsync($"{textBox6}");
            sw.WriteLineAsync($"{textBox7}");
            sw.WriteLineAsync($"{textBox8}");
            sw.WriteLineAsync($"{textBox9}");
            sw.WriteLineAsync($"{textBox10}");
            sw.WriteLineAsync($"{textBox11}");
            sw.Close();
        }

        private void textBox4_TextChanged(object sender, EventArgs e)
        {

        }

        private void textBox12_TextChanged(object sender, EventArgs e)
        {

        }

        private void textBox6_TextChanged(object sender, EventArgs e)
        {

        }

        private void textBox3_TextChanged(object sender, EventArgs e)
        {

        }
    }
}