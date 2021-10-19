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

namespace _4
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

        private void txtbDaysWorked_TextChanged(object sender, TextChangedEventArgs e)
        {

        }

        private void Button_Click(object sender, RoutedEventArgs e)
        {
            double Salary = Convert.ToInt32(txtbSalary.Text);
            double DistrictCoefficient = Convert.ToInt32(txtbDistrictCoefficient.Text);
            double WorkingDays = Convert.ToInt32(txtbWorkingDays.Text);
            double DaysWorked = Convert.ToInt32(txtbDaysWorked.Text);
            double Prize = Convert.ToInt32(txtbPrize.Text);
            double PolnaiaZarplata;
            double ZarplataNaRuki;
            double NDFL;

            PolnaiaZarplata = Salary * DistrictCoefficient * DaysWorked / WorkingDays + Prize;

            NDFL = PolnaiaZarplata * 0.13;

            ZarplataNaRuki = PolnaiaZarplata - NDFL;


            txtblockPolnaiaZarplata.Text = $"{PolnaiaZarplata}";
            txtblockNdfl.Text = $"{NDFL}";
            txtblockZarplataNaRuki.Text = $"{ZarplataNaRuki}";



        }

        private void Button_Click_1(object sender, RoutedEventArgs e)
        {
            txtbSalary.Clear();
            txtbDistrictCoefficient.Clear();
            txtbWorkingDays.Clear();
            txtbDaysWorked.Clear();
            txtbPrize.Clear();
            txtblockPolnaiaZarplata.Text = "";
            txtblockNdfl.Text = "";
            txtblockZarplataNaRuki.Text = "";
        }
    }
}
