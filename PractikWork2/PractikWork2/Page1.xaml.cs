using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows;
using System.Windows.Controls;
using System.Windows.Data;
using System.Windows.Documents;
using System.Windows.Input;
using System.Windows.Media;
using System.Windows.Media.Imaging;
using System.Windows.Navigation;
using System.Windows.Shapes;

namespace PractikWork2
{
    /// <summary>
    /// Логика взаимодействия для Page1.xaml
    /// </summary>
    public partial class Page1 : Page
    {
        public Page1()
        {
            InitializeComponent();
        }

        private void CompliteButton_Click(object sender, RoutedEventArgs e)
        {
            AnswerTextBox.Clear();
            int a, b, s;

            if (String.IsNullOrEmpty(NumberATextBox.Text) || String.IsNullOrEmpty(NumberBTextBox.Text))
            {
                return;
            }
            if (!int.TryParse(NumberATextBox.Text, out a))
            {
                AnswerTextBox.Text += "Введены некоректные данные";
            }
            if (!int.TryParse(NumberBTextBox.Text, out b))
            {
                AnswerTextBox.Text += "Введены некоректные данные";
            }
            if(a > 0 && b > 0 && a > b)
            {
                s = a % b;
                AnswerTextBox.Text += $"Не занятая часть = {s}";
            }
            else
            {
                AnswerTextBox.Text += "Введены некоректные данные";
            }
        }
    }
}
