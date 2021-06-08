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

namespace fffdfdfsdsf
{
    public partial class MainWindow : Window
    {
        public MainWindow()
        {
            InitializeComponent();
        }
        private void Button2_Click(object sender, RoutedEventArgs e)
        {
            email.Text.ToLower();
            string[] FIO1 = Fio.Text.Split(' ');
            string[] email1 = email.Text.Split('@');
            if (FIO1.Length != 3)
            {
                MessageBox.Show("Вы некорректно ввели ФИО.\nПопробуйте еще раз", "PersonInfo v1", MessageBoxButton.OK, MessageBoxImage.Error);
            }
            else
            {
              Fio.Text.ToString();
            }
            if (email1.Length == 1 && email.Text.Contains("com") || email.Text.Contains("ru") || email.Text.Contains("net") || email.Text.Contains("uk") || email.Text.Contains("co") || email.Text.Contains("рф"))
            {
                email.Text.ToString();
            }
            else
            {
                MessageBox.Show("Вы некорректно ввели Email.\nПопробуйте еще раз", "PersonInfo v1", MessageBoxButton.OK, MessageBoxImage.Error);
            }
            if (Tel.Text.Length == 11)
            {
                float.Parse(Tel.Text.ToString());
            }
            else
            {
                MessageBox.Show("Вы некорректно ввели телефонный номер.\nПопробуйте еще раз", "PersonInfo v1", MessageBoxButton.OK, MessageBoxImage.Error);
            }
            if (snil.Text.Length == 11)
            {
                snil.Text.ToString();
            }
            else
            {
                MessageBox.Show("Вы некорректно ввели снилс.\nПопробуйте еще раз", "PersonInfo v1", MessageBoxButton.OK, MessageBoxImage.Error);
            }
            MessageBox.Show("Данные успешно добавлены", "PersonInfo v1", MessageBoxButton.OK, MessageBoxImage.Information);

        }
    } 
}
