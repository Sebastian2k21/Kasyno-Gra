using System;
using System.Collections.Generic;
using System.Globalization;
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

namespace Kasyno
{
    public partial class MainWindow : Window
    {
        public MainWindow()
        {
            CultureInfo.CurrentCulture = CultureInfo.GetCultureInfo("en-US");
            InitializeComponent();
        }

        private void BtnGoIn_Click(object sender, RoutedEventArgs e)
        {
            WindowEntry window = new WindowEntry();
            this.Hide();
            window.ShowDialog();
            this.Close();
        }
        private void BtnAuthor_Click(object sender, RoutedEventArgs e)
        {
            WindowAuthor window = new WindowAuthor();
            this.Hide();
            window.ShowDialog();
            this.Show();
        }

        private void BtnExit_Click(object sender, RoutedEventArgs e)
        {
            Environment.Exit(0);
        }
    }
}
