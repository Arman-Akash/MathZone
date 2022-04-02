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
    /// Interaction logic for Multiplication.xaml
    /// </summary>
    public partial class Multiplication : Window
    {
        Random randomizer = new Random();
        int num1, num2, difficulty = 10, count = 0;
        public Multiplication()
        {
            InitializeComponent();
        }

        private void refreshPanel()
        {
            count++;
            if (count > 5)
            {
                count = 0;
                difficulty += 10;
            }
            num1 = randomizer.Next(0, difficulty);
            num2 = randomizer.Next(0, difficulty);

            if (num1 >= num2)
            {
                lbl1.Content = num1.ToString();
                lbl2.Content = "*\t" + num2.ToString();
            }
            else
            {
                lbl1.Content = num2.ToString();
                lbl2.Content = "*\t" + num1.ToString();
            }

            chckBtn.IsEnabled = true;
            ViewBtn.IsEnabled = false;
            nextBtn.IsEnabled = false;
            AnsField.Value = null;
            AnsField.BorderBrush = Brushes.Gray;
            cmntlbl.Content = "";
            chckBtn.IsEnabled = true;
        }

        private void chckBtn_Click(object sender, RoutedEventArgs e)
        {
            int? usrAns = AnsField.Value;
            if (usrAns == null)
                MessageBox.Show("please, fill the Ans Box...At least try once before quiting...");
            else
            {
                if (usrAns == num1 * num2)
                {
                    cmntlbl.Content = "Correct! Good...";
                    chckBtn.IsEnabled = false;
                }
                else
                    cmntlbl.Content = "InCorrect!\n let's give a one more try";

                ViewBtn.IsEnabled = true;
                nextBtn.IsEnabled = true;
            }
        }
        private void viewBtn_Click(object sender, RoutedEventArgs e)
        {
            AnsField.Value = num1 * num2;
            AnsField.BorderBrush = Brushes.Red;
            chckBtn.IsEnabled = false;
        }

        private void nextBtn_Click(object sender, RoutedEventArgs e)
        {
            refreshPanel();
        }

        private void backButton_Click(object sender, RoutedEventArgs e)
        {
            ArithmeticWin aw = new ArithmeticWin();
            aw.Show();
            this.Close();
        }

        private void windowLoaded(object sender, RoutedEventArgs e)
        {
            refreshPanel();
        }
    }
}
