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
using System.Windows.Media.Animation;
using System.Windows.Media.Imaging;
using System.Windows.Navigation;
using System.Windows.Shapes;
using static System.Math; 
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


                double N = Convert.ToDouble(TbNumberN.Text);
                double sum = 0;
                double A = 1, B = 1; // значения для r = 1
                double Ar, Br; // значения для r > 1

                for (int r = 1; r <= N; r++)
                {
                    
                    Ar = 0.5 * (Math.Sqrt(B) + 0.5 * Math.Sqrt(A));
                    Br = 2 * Math.Pow(A, 2) + B;
                    A = Ar;
                    B = Br;
                    sum += Ar * Br;
                }

                TextBlockAnswer.Text = $"Сумма элементов = " + sum;


             


                //double Answ = 0;
                //double Fact = 1;


                //for (int i = 1; i<=NumberN;i++)
                //{
                //    Fact *= i;
                //    Answ += Fact;
                //}
                //TextBlockAnswer.Text = $"Ответ: Сумма факториалов до N! = {Answ}";
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
