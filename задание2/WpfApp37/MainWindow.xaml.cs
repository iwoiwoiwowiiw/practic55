﻿using System;
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
                int k = -1;
                int n = Convert.ToInt32(ListBoxData.Items.Count);
                int sum = 0;
                for (int i = 0; i < n; i++)
                {
                    int m = Convert.ToInt32(ListBoxData.Items[i]);
                    if (m % 10 == 4&& m % 6 == 0)
                    {
                        sum += m ;
                        k = 0;
                    }
                }
                if (k != -1)
                {
                    TextBlockAnswer.Text = $"Ответ:\n{sum}";

                }
                else
                {
                    TextBlockAnswer.Text = $"Ответ:\n Чисел оканчивающихся на 2, и кратным 7 нет";
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
    

        private void BtnAdd_Click(object sender, RoutedEventArgs e)
        {
        if ((String.IsNullOrEmpty(TbNumber.Text)))
        {
            return;
        }
        try
        {
            int xa = Convert.ToInt32(TbNumber.Text);
        }
        catch (FormatException)
        {
            MessageBox.Show("Введены не корректные данные");
        }
        catch (Exception ex)
        {
            MessageBox.Show(ex.Message);
        }
        ListBoxData.Items.Add(TbNumber.Text);
    }
    }
}
