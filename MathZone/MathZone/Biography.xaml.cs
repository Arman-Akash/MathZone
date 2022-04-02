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
using System.Windows.Shapes;

namespace MathZone
{
    /// <summary>
    /// Interaction logic for Biography.xaml
    /// </summary>
    public partial class Biography : Window
    {
        public Biography()
        {
            InitializeComponent();
            browser.Navigate("https://en.wikipedia.org/wiki/Euclid");
        }

        private void backBtn_Click(object sender, RoutedEventArgs e)
        {
            new MainWindow().Show();
            this.Close();
        }
    }
}
