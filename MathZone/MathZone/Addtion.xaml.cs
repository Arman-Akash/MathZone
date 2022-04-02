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
    /// Interaction logic for Addtion.xaml
    /// </summary>
    public partial class Addtion : Window
    {
        bool flag2D = true;
        bool flag3D = false;
        bool flag4D = false;
        Random Randomizer = new Random();
        int num1, num2, num3, num4, maxDifficulty = 10, minDifficulty = 0, increase = 20;
        int count = 0;
        public Addtion()
        {
            InitializeComponent();
        }
        private void additionLoaded(object sender, RoutedEventArgs e)
        {
            lbl4.Visibility = Visibility.Hidden;
            lbl3.Visibility = Visibility.Hidden;
            _2DAddBtn.IsEnabled = false;
            nextBtn.IsEnabled = false;
            ViewBtn.IsEnabled = false;
            rb1.IsChecked = true;
          //  refreshPanel();
        }
        private void _2DAddBtn_Click(object sender, RoutedEventArgs e)
        {
            initializedDifficulty();
            flag2D = true;
            _2DAddBtn.IsEnabled = false;
            flag3D = false;
            _3DAddBtn.IsEnabled = true;
            flag4D = false;
            _4DAddBtn.IsEnabled = true;
            lbl3.Visibility = Visibility.Hidden;
            lbl4.Visibility = Visibility.Hidden;
            refreshPanel();
        }

        private void _3DAddBtn_Click(object sender, RoutedEventArgs e)
        {
            initializedDifficulty();
            flag3D = true;
            _3DAddBtn.IsEnabled = false;
            flag2D = false;
            _2DAddBtn.IsEnabled = true;
            flag4D = false;
            _4DAddBtn.IsEnabled = true;
            lbl4.Visibility = Visibility.Hidden;
            refreshPanel();            
        }
        private void _4DAddBtn_Click(object sender, RoutedEventArgs e)
        {
            initializedDifficulty();
            flag4D = true;
            _4DAddBtn.IsEnabled = false;
            flag3D = false;
            _3DAddBtn.IsEnabled = true;
            flag2D = false;
            _2DAddBtn.IsEnabled = true;
            refreshPanel();
        }
        private void refreshPanel()
        {
            count++;
            if(count > 2)
            {
                count = 0;
                maxDifficulty += increase; 
            }
            num1 = Randomizer.Next(10, maxDifficulty);
            num2 = Randomizer.Next(minDifficulty, maxDifficulty);

            lbl1.Content = "+       " + num1.ToString();
            lbl2.Content = num2.ToString();
            if (flag3D) 
            {
                num3 = Randomizer.Next(minDifficulty, maxDifficulty);
                lbl3.Content = num3.ToString();
                lbl3.Visibility = Visibility.Visible;
            }
            else if(flag4D)
            {
                num3 = Randomizer.Next(10, maxDifficulty);
                lbl3.Content = num3.ToString();
                lbl3.Visibility = Visibility.Visible;
                num4 = Randomizer.Next(minDifficulty, maxDifficulty);
                lbl4.Content = num4.ToString();
                lbl4.Visibility = Visibility.Visible;
            }
            AnsField.Value = null;
            AnsField.BorderBrush = Brushes.Gray;
            cmntlbl.Content = "";
            chckBtn.IsEnabled = true;
        }

        private void chckBtn_Click(object sender, RoutedEventArgs e)
        {
            int? usrAns = AnsField.Value;
            int ans;
            if (usrAns == null)
                MessageBox.Show("please, fill the Ans Box...At least try once before quiting...");
            else
            {
                if (flag2D)
                {
                    ans = num1 + num2;
                }
                else if (flag3D)
                    ans = num1 + num2 + num3;
                else 
                    ans = num1 + num2 + num3 + num4;

                if(usrAns == ans)
                {
                    cmntlbl.Content = "Correct! Good.";
                    chckBtn.IsEnabled = false;
                }
               else
                   cmntlbl.Content = "InCorrect!\n let's give a one more try";

               ViewBtn.IsEnabled = true;
               nextBtn.IsEnabled = true;
            }
        }

        private void nextBtn_Click(object sender, RoutedEventArgs e)
        {
            refreshPanel();
        }

        private void viewBtn_Click(object sender, RoutedEventArgs e)
        {
            int ans;
            if (flag2D)
            {
                ans = num1 + num2;
            }
            else if (flag3D)
                ans = num1 + num2 + num3;
            else
                ans = num1 + num2 + num3 + num4;

            AnsField.Value = ans;
            AnsField.BorderBrush = Brushes.Red;
            chckBtn.IsEnabled = false;
        }

        private void backButton_Click(object sender, RoutedEventArgs e)
        {
            ArithmeticWin aw = new ArithmeticWin();
            aw.Show();
            this.Close();
        }

        private void RadioButton_Checked(object sender, RoutedEventArgs e)
        {
            initializedDifficulty();
            refreshPanel();
        }

        private void initializedDifficulty()
        {
            if (rb1.IsChecked == true)
            {
                minDifficulty = 1;
                maxDifficulty = 20;
                increase = 20;
            }
            else if (rb2.IsChecked == true)
            {
                minDifficulty = 500;
                maxDifficulty = 520;
                increase = 40;
            }
            else if (rb3.IsChecked == true)
            {
                minDifficulty = 1000;
                maxDifficulty = 1020;
                increase = 100;
            }
        }

    }
}
