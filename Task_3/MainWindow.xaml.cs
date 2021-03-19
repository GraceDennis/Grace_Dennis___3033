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

namespace Task_3
{
    /// <summary>
    /// Interaction logic for MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        public MainWindow()
        {
            InitializeComponent();
        }
        private void Button_Click(object sender, RoutedEventArgs e)
        {

            if (!string.IsNullOrEmpty(firstnameBox.Text))
            {
                MessageBox.Show("Please enter a first name.");
                firstnameBox.Text = "";
            }
            if (!string.IsNullOrEmpty(lastnameBox.Text))
            {
                MessageBox.Show("Please enter a last name.");
                lastnameBox.Text = "";
            }
            if (!int.TryParse(phonenumber.Text, out int a))
            {
                MessageBox.Show("Please enter a valid phone number.");
                phonenumber.Text = "";
            }
            else
            {
                // calc age: 
                DateTime d1 = DateTime.Now;
                DateTime d2 = new DateTime(1978, 4, 5);
                TimeSpan difference = d1.Subtract(d2);
                (difference.TotalDays / 365.25).ToString();
                string g = "";
                g = $"{lastnameBox.Text}, {firstnameBox.Text} ({difference}): {phonenumber}";
                infobox.Items.Add(g);

                lastnameBox.Text = "";
                firstnameBox.Text = "";
            }
        }

        private void Button_Click_1(object sender, RoutedEventArgs e)
        {
            Close();
        }

    }
}
