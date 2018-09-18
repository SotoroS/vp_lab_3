using System;
using System.Windows.Forms;

namespace figure
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        // Проверка введенных значений в поля формы
        private void textBox_KeyPress(object sender, KeyPressEventArgs e)
        {
            char number = e.KeyChar;

            if (!Char.IsDigit(number) && number != 8 && number != 44) // цифры, клавиша BackSpace и запятая
            {
                e.Handled = true;
            }
        }

        // Проверка на пустоту значения текстовых полей 
        private void textBox_TextChanged(object sender, EventArgs e)
        {
            TextBox textBox = ((TextBox)sender);

            // Проверка на пустату строки
            if (textBox.Text == String.Empty)
            {
                textBox.Text = "0";
            }
        }

        private void buttonCalc_Click(object sender, EventArgs e)
        {
            // Формируем параллелограмм
            Parallelepiped paral = new Parallelepiped(
                Convert.ToDouble(textBoxParallelepipedA.Text),
                Convert.ToDouble(textBoxParallelepipedB.Text),
                Convert.ToDouble(textBoxParallelepipedC.Text)
            );

            // Формируем шар
            Ball ball = new Ball(Convert.ToDouble(textBoxBallR.Text));

            // Выводим значение площадей 
            textBoxParallelepipedS.Text = paral.Area().ToString();
            textBoxBallS.Text = ball.Area().ToString();

            // Выводим значение объемов 
            textBoxParallelepipedV.Text = paral.Volume().ToString();
            textBoxBallV.Text = ball.Volume().ToString();

        }
    }
}
