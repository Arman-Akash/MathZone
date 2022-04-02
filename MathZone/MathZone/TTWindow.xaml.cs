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

namespace MathZone
{
    /// <summary>
    /// Interaction logic for MainWindow.xaml
    /// </summary>
    public partial class TTWindow : Window
    {
        public TTWindow()
        {
            InitializeComponent();
            loads();
        }

        void loads()
        {
            ex1.Content = tableOf(1);
            ex2.Content = tableOf(2);
            ex3.Content = tableOf(3);
            ex4.Content = tableOf(4);
            ex5.Content = tableOf(5);
            ex6.Content = tableOf(6);
            ex7.Content = tableOf(7);
            ex8.Content = tableOf(8);
            ex9.Content = tableOf(9);
            ex10.Content = tableOf(10);
            ex11.Content = tableOf(11);
            ex12.Content = tableOf(12);
            ex13.Content = tableOf(13);
            ex14.Content = tableOf(14);
            ex15.Content = tableOf(15);
            ex16.Content = tableOf(16);
            ex17.Content = tableOf(17);
            ex18.Content = tableOf(18);
            ex19.Content = tableOf(19);
            ex20.Content = tableOf(20);
        }

        string tableOf(int num)
        {
            string cntnt = "";

            for (int i = 1; i <= 10; i++)
            {
                cntnt = cntnt + num + " * " + i + " = " + num * i + "\n";
            }
            return cntnt;
        }

        private void ExpendersCloseExcept(object sender, RoutedEventArgs e)
        {
            if (sender != ex1)
                ex1.IsExpanded = false;
            if (sender != ex2)
                ex2.IsExpanded = false;
            if (sender != ex3)
                ex3.IsExpanded = false;
            if (sender != ex4)
                ex4.IsExpanded = false;
            if (sender != ex5)
                ex5.IsExpanded = false;
            if (sender != ex6)
                ex6.IsExpanded = false;
            if (sender != ex7)
                ex7.IsExpanded = false;
            if (sender != ex8)
                ex8.IsExpanded = false;
            if (sender != ex9)
                ex9.IsExpanded = false;
            if (sender != ex10)
                ex10.IsExpanded = false;
            if (sender != ex11)
                ex11.IsExpanded = false;
            if (sender != ex12)
                ex12.IsExpanded = false;
            if (sender != ex13)
                ex13.IsExpanded = false;
            if (sender != ex14)
                ex14.IsExpanded = false;
            if (sender != ex15)
                ex15.IsExpanded = false;
            if (sender != ex16)
                ex16.IsExpanded = false;
            if (sender != ex17)
                ex17.IsExpanded = false;
            if (sender != ex18)
                ex18.IsExpanded = false;
            if (sender != ex19)
                ex19.IsExpanded = false;
            if (sender != ex20)
                ex20.IsExpanded = false;
        }

        private void show_click(object sender, RoutedEventArgs e)
        {
            int? val = tableVal.Value;
            if (val == null)
                MessageBox.Show("Enter a number: then press Show...");
            else
            {
                childWin.Content = tableOf(Convert.ToInt32(val));
                childWin.WindowState = Xceed.Wpf.Toolkit.WindowState.Open;
                Console.WriteLine("dfd");
            }
        }

        private void childWin_closed(object sender, EventArgs e)
        {
        }

        private void childWin_closing(object sender, EventArgs e)
        {
            childWin.WindowState = Xceed.Wpf.Toolkit.WindowState.Closed;
        }
        private void backBtn_Click(object sender, RoutedEventArgs e)
        {
            MathZone.MainWindow mw = new MathZone.MainWindow();
            mw.Show();
            this.Close();
        }
     }
}
