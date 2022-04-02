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

namespace Arithmetic
{
    /// <summary>
    /// Interaction logic for AdditionTutorial.xaml
    /// </summary>
    public partial class AdditionTutorial : Window
    {
        public AdditionTutorial()
        {
            InitializeComponent();
        }

        void vedio_failed(object sender, ExceptionRoutedEventArgs e)
        {
            MessageBox.Show(e.ErrorException.Message);
        }
        private void backButton_Click(object sender, RoutedEventArgs e)
        {
            new ArithmeticWin().Show();
            this.Close();
        }

        private void Window_Loaded(object sender, RoutedEventArgs e)
        {
         //   vedio.Navigate("https://www.google.com/");
        }
    }
}
