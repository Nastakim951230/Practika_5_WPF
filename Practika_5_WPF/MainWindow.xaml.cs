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

namespace Practika_5_WPF
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
        private void CBV_SelectionChanged(object sender, SelectionChangedEventArgs e)
        {
            if (CBV.SelectedIndex == 0)
            {
                SPRub.Visibility = Visibility.Visible;
                Rub.Visibility = Visibility.Visible;
                SPins.Visibility = Visibility.Collapsed;
                RezulRub.Text = "";
                RezulKop.Text = "";
                TxtDe.Text = "";
                SpRez.Visibility = Visibility.Collapsed;
                CBRub.IsEnabled = true;
            }
            else
            {
                SPRub.Visibility = Visibility.Collapsed;
                Rub.Visibility = Visibility.Collapsed;
                SPins.Visibility = Visibility.Visible;
                SpItog.Visibility = Visibility.Collapsed;
                TxtBRub.Text = "";
                TxtKop.Text = "";
                Itog.Text = "";
                SpItog.Visibility = Visibility.Collapsed;
                if (CBV.SelectedIndex == 1)
                {
                    TBIm.Text = "Введите количество Долларов США: ";
                }
                if (CBV.SelectedIndex == 1)
                {
                    TBIm.Text = "Введите количество Долларов США: ";
                }
                if (CBV.SelectedIndex == 2)
                {
                    TBIm.Text = "Введите количество Евро: ";
                }
                if (CBV.SelectedIndex == 3)
                {
                    TBIm.Text = "Введите количество Гонгонских долларов: ";
                }
                if (CBV.SelectedIndex == 4)
                {
                    TBIm.Text = "Введите количество Японских иенов: ";
                }
                if (CBV.SelectedIndex == 5)
                {
                    TBIm.Text = "Введите количество Бразильских реалов: ";
                }
            }
        }

        private void BTItog_Click(object sender, RoutedEventArgs e)
        {
            try
            {
                if ((TxtBRub.Text == "") || (TxtKop.Text == ""))
                {
                    MessageBox.Show("Обязательные поля пусты", "Ошибка", MessageBoxButton.OK, MessageBoxImage.Error);
                }
                else
                {
                    if ((Convert.ToDouble(TxtBRub.Text) < 0) || (Convert.ToDouble(TxtKop.Text) < 0))
                    {
                        MessageBox.Show(" Число должно быть больше 0", "Ошибка", MessageBoxButton.OK, MessageBoxImage.Error);
                    }
                    else
                    {
                        SpItog.Visibility = Visibility.Visible;

                        double Rub = Convert.ToDouble(TxtBRub.Text);
                        double Kop = Convert.ToDouble(TxtKop.Text);
                        double rez;
                        if (CBRub.SelectedIndex == 0)
                        {
                            rez = (Rub + (Kop / 100)) / 58.82;
                            Itog.Text = Math.Round(rez, 2) + "";

                        }
                        if (CBRub.SelectedIndex == 1)
                        {

                            rez = (Rub + (Kop / 100)) / 55.55;
                            Itog.Text = Math.Round(rez, 2) + "";
                        }
                        if (CBRub.SelectedIndex == 2)
                        {

                            rez = (Rub + (Kop / 100)) / 7.69;
                            Itog.Text = Math.Round(rez, 2) + "";
                        }
                        if (CBRub.SelectedIndex == 3)
                        {
                            rez = (Rub + (Kop / 100)) / 0.40;
                            Itog.Text = Math.Round(rez, 2) + "";
                        }
                        if (CBRub.SelectedIndex == 4)
                        {
                            rez = (Rub + (Kop / 100)) / 11.11;
                            Itog.Text = Math.Round(rez, 2) + "";
                        }
                    }
                }
            }
            catch
            {
                MessageBox.Show("Должно быть число ", "Ошибка", MessageBoxButton.OK, MessageBoxImage.Error);
            }
        }

        private void Clear_Click(object sender, RoutedEventArgs e)
        {
            TxtBRub.Text = "";
            TxtKop.Text = "";
            Itog.Text = "";
            SpItog.Visibility = Visibility.Collapsed;
        }

        private void BTRez_Click(object sender, RoutedEventArgs e)
        {
            try
            {
                if (TxtDe.Text == null)
                {
                    MessageBox.Show("Обязательные поля пусты", "Ошибка", MessageBoxButton.OK, MessageBoxImage.Error);
                }
                else
                {
                    if (Convert.ToDouble(TxtDe.Text) < 0)
                    {
                        MessageBox.Show("Число должно быть больше 0", "Ошибка", MessageBoxButton.OK, MessageBoxImage.Error);
                    }
                    else
                    {
                        SpRez.Visibility = Visibility.Visible;
                        double Val = Convert.ToDouble(TxtDe.Text);
                        double Rezultat;
                        string rez;
                        if (CBV.SelectedIndex == 1)
                        {

                            Rezultat = Val * 58.82;
                            rez = Rezultat + "";
                            string[] subs = rez.Split(',');
                            RezulRub.Text = subs[0];
                            RezulKop.Text = subs[1];
                        }
                        if (CBV.SelectedIndex == 2)
                        {

                            Rezultat = Val * 55.55;
                            rez = Rezultat + "";
                            string[] subs = rez.Split(',');
                            RezulRub.Text = subs[0];
                            RezulKop.Text = subs[1];
                        }
                        if (CBV.SelectedIndex == 3)
                        {

                            Rezultat = Val * 7.69;
                            rez = Rezultat + "";
                            string[] subs = rez.Split(',');
                            RezulRub.Text = subs[0];
                            RezulKop.Text = subs[1];
                        }
                        if (CBV.SelectedIndex == 4)
                        {

                            Rezultat = Val * 0.40;
                            rez = Rezultat + "";
                            string[] subs = rez.Split(',');
                            RezulRub.Text = subs[0];
                            RezulKop.Text = subs[1];
                        }
                        if (CBV.SelectedIndex == 5)
                        {

                            Rezultat = Val * 11.11;
                            rez = Rezultat + "";
                            string[] subs = rez.Split(',');
                            RezulRub.Text = subs[0];
                            RezulKop.Text = subs[1];
                        }
                    }
                }
            }
            catch
            {
                MessageBox.Show("Должно быть число ", "Ошибка", MessageBoxButton.OK, MessageBoxImage.Error);
            }
        }

        private void Clear_rez_Click(object sender, RoutedEventArgs e)
        {
            RezulRub.Text = "";
            RezulKop.Text = "";
            TxtDe.Text = "";
            SpRez.Visibility = Visibility.Collapsed;
        }

        private void CBRub_SelectionChanged(object sender, SelectionChangedEventArgs e)
        {
            BTItog.Visibility = Visibility.Visible;
        }
    }
}
