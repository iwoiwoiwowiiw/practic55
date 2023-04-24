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

namespace WpfApp37
{
    /// <summary>
    /// Логика взаимодействия для MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        public MainWindow()
        {
            InitializeComponent();
        }

        private void BtnCancel_Click(object sender, RoutedEventArgs e)
        {
            Close();
        }

        private void BtnOK_Click(object sender, RoutedEventArgs e)
        {
            try
            {
                int Answ = 0;
                int NumberA = Convert.ToInt32(TbNumberA.Text);
                int NumberB = Convert.ToInt32(TbNumberB.Text);
                if(NumberA < NumberB)
                {
                    for (int i = NumberA; i <= NumberB; i++)
                    {
                        Answ += i * i;
                    }
                    TextBlockAnswer.Text = $"сумма квадратов от числа А и Б = {Answ}";
                }
                else 
                {
                    TextBlockAnswer.Text = "Число А больше Б";
                }
            }
            catch (FormatException)
            {
                MessageBox.Show("Введены не корректные данные");
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }
    

      

    }
}
