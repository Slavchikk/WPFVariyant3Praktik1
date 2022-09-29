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

namespace Praktik1
{
    /// <summary>
    /// Логика взаимодействия для MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {

    

        string unit = "";
        public MainWindow()
        {
            InitializeComponent();
        }



        private void RBKmMeters_Checked(object sender, RoutedEventArgs e)
        {
            SPEnterRmMeters.Visibility = Visibility.Visible;
            SPEnterOthersEqual.Visibility = Visibility.Collapsed;
            SPOutputKm.Visibility = Visibility.Collapsed;

        }

        private void RBOtherEqual_Checked(object sender, RoutedEventArgs e)
        {
            SPEnterOthersEqual.Visibility = Visibility.Visible;
            SPEnterRmMeters.Visibility = Visibility.Collapsed;
          
            SPOutputOthers.Visibility = Visibility.Collapsed;
        }

        private void Btn_enter(object sender, RoutedEventArgs e)
        {
            CBTreagle.Visibility = Visibility.Visible;
            CBTreagle.IsEnabled = true;
            TBEDIz.Visibility=Visibility.Visible;
        }

        private void CBTreagle_SelectionChanged(object sender, SelectionChangedEventArgs e)
        {
            switch (CBTreagle.SelectedIndex) 
            {
                case 0:
                    double metters = Convert.ToDouble(TBKm.Text) * 1000 + Convert.ToDouble(TBMetters.Text);
                    double milles = Math.Round(metters / 1609.34, 5);
                    SPOutputOthers.Visibility = Visibility.Visible;
                    TBlResultOthers.Text = Convert.ToString(milles);
                    break;
                case 1:
                    metters = Convert.ToDouble(TBKm.Text) * 1000 + Convert.ToDouble(TBMetters.Text);
                    double verst = Math.Round(metters / 1066.8, 5);
                    SPOutputOthers.Visibility = Visibility.Visible;
                    TBlResultOthers.Text = Convert.ToString(verst);
                    break;
                case 2:
                    metters = Convert.ToDouble(TBKm.Text) * 1000 + Convert.ToDouble(TBMetters.Text);
                    double yards = Math.Round(metters * 1.09361, 5);
                    SPOutputOthers.Visibility = Visibility.Visible;
                    TBlResultOthers.Text = Convert.ToString(yards);
                    break;
                case 3:

                    metters = Convert.ToDouble(TBKm.Text) * 1000 + Convert.ToDouble(TBMetters.Text);
                    double dyim = Math.Round(metters * 39.3701, 5);
                    SPOutputOthers.Visibility = Visibility.Visible;
                    TBlResultOthers.Text = Convert.ToString(dyim);
                    break;
                case 4:

                    metters = Convert.ToDouble(TBKm.Text) * 1000 + Convert.ToDouble(TBMetters.Text);
                    double futs = Math.Round(metters * 3.28084, 5);
                    SPOutputOthers.Visibility = Visibility.Visible;
                    TBlResultOthers.Text = Convert.ToString(futs);
                    break;
            }
        }
       
        private void CBTreagle_SelectionChangedFirst(object sender, SelectionChangedEventArgs e)
        {
            switch (CBTreagles.SelectedIndex)
            {
                case 0:
                    TBFromOther.Visibility = Visibility.Visible;
                    BtnFromother.Visibility = Visibility.Visible;
                    unit = "Мили";
                                        break;
                case 1:
                    TBFromOther.Visibility = Visibility.Visible;
                    BtnFromother.Visibility = Visibility.Visible;
                    unit = "Версты";
                    break;
                case 2:
                    TBFromOther.Visibility = Visibility.Visible;
                    BtnFromother.Visibility = Visibility.Visible;
                    unit = "Ярды";
                    break;
                case 3:
                    TBFromOther.Visibility = Visibility.Visible;
                    BtnFromother.Visibility = Visibility.Visible;
                    unit = "Дюймы";
                    break;
                case 4:
                    TBFromOther.Visibility = Visibility.Visible;
                    BtnFromother.Visibility = Visibility.Visible;
                    unit = "Фунты";
                    break;


            }
        }

        private void Btn_enters(object sender, RoutedEventArgs e)
        {
            switch(unit)
            {
                case "Мили":
                   double metters = Convert.ToDouble(TBFromOther.Text) * 1609.34;
                    int km = (int)metters / 1000;
                    metters = metters - km * 1000;
                    metters = Math.Round(metters, 5);
                    SPOutputKm.Visibility = Visibility.Visible;
                    TBlResultKm.Text = km.ToString();
                    TBlResultMeters.Text = metters.ToString();
                    break;
                case "Версты":
                    metters = Convert.ToDouble(TBFromOther.Text) * 1066.8;
                    km = (int)metters / 1000;
                    metters = metters - km * 1000;
                    metters = Math.Round(metters, 5);
                    SPOutputKm.Visibility = Visibility.Visible;
                    TBlResultKm.Text = km.ToString();
                    TBlResultMeters.Text = metters.ToString();
                    break;
                case "Ярды":
                    metters = Convert.ToDouble(TBFromOther.Text) / 1.09361;
                    km = (int)metters / 1000;
                    metters = metters - km * 1000;
                    metters = Math.Round(metters, 5);
                    SPOutputKm.Visibility = Visibility.Visible;
                    TBlResultKm.Text = km.ToString();
                    TBlResultMeters.Text = metters.ToString();
                    break;
                case "Дюймы":
                    metters = Convert.ToDouble(TBFromOther.Text) / 39.3701;
                    km = (int)metters / 1000;
                    metters = metters - km * 1000;
                    metters = Math.Round(metters, 5);
                    SPOutputKm.Visibility = Visibility.Visible;
                    TBlResultKm.Text = km.ToString();
                    TBlResultMeters.Text = metters.ToString();
                    break;
                case "Фунты":
                    metters = Convert.ToDouble(TBFromOther.Text) / 3.28084;
                    km = (int)metters / 1000;
                    metters = metters - km * 1000;
                    metters = Math.Round(metters, 5);
                    SPOutputKm.Visibility = Visibility.Visible;
                    TBlResultKm.Text = km.ToString();
                    TBlResultMeters.Text = metters.ToString();
                    break;

            }
        }

        private void checkIfInputDigits(object sender, TextCompositionEventArgs e)
        {
            e.Handled = "0123456789 ,".IndexOf(e.Text) < 0;
        }
    }
}
