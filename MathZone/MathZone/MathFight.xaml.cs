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
using System.Windows.Threading;

namespace Game
{
    /// <summary>
    /// Interaction logic for MathFight.xaml
    /// </summary>
    public partial class MathFight : Window
    {  Random randomizer = new Random();
        DispatcherTimer timer, delay;
        int num1, num2, ans, usrScore, comScore;
        int time = 0, delaytime = 0;
        int defficult = 15;
        char[] oparator = { '+', '-', '*', '/' };
        public MathFight()
        {
            InitializeComponent();
            componentVisibility(Visibility.Hidden);
            status.Content = "\t\tAre you ready!\n Let's see who can first make 5 points";
            timer = new DispatcherTimer();
            delay = new DispatcherTimer();
            timer.Tick += new EventHandler(timer_Tick);
            delay.Tick += new EventHandler(delay_Tick);
            timer.Interval = new TimeSpan(0, 0, 1);
            delay.Interval = new TimeSpan(0, 0, 1);
        }

        private void componentVisibility(Visibility done)
        {
            numlbl1.Visibility = done;
            numlbl2.Visibility = done;
            _lbl.Visibility = done;
            AnsField.Visibility = done;
            submitBtn.Visibility = done;
            numlblc1.Visibility = done;
            numlblc2.Visibility = done;
            _lblc.Visibility = done;
            AnsFieldc.Visibility = done;
        }

        private void delay_Tick(object sender, EventArgs e)
        {
            
            if(delaytime == 3)
            {
                delay.Stop();
                goToNext();
            }
            else
            {
                delaytime++;
                submitBtn.IsEnabled = false;
                AnsField.IsEnabled = false;
            }
        }
        private void backButton_Click(object sender, RoutedEventArgs e)
        {
            GameWindow gm = new GameWindow();
            gm.Show();
            this.Close();
        }

        private void startButton_Click(object sender, RoutedEventArgs e)
        {
            goToNext();
            componentVisibility(Visibility.Visible);
            status.Content = "";
            startBtn.IsEnabled = false;
            usrScore = comScore = 0;
        }

        string oprtr;

        private void goToNext()
        {
            if(usrScore == 5) // make those nuber perfect, also the time.
            {
                status.Content = "Hurrey!!! You Win...";
                status.Foreground = Brushes.BlueViolet;
                startBtn.IsEnabled = true;
            }
            else if(comScore == 5)
            {
                status.Content = "You Failed. Computer Win...";
                status.Foreground = Brushes.PaleVioletRed;
                startBtn.IsEnabled = true;
            }
            else
            {
                submitBtn.IsEnabled = false;
                usrScorelbl.Content = "Score: " + usrScore;
                comScorelbl.Content = "Score: " + comScore;
                status.Content = "";
                
                time = randomizer.Next(8, 11 + defficult / 20);
                num1 = randomizer.Next(defficult - 15, defficult);
                num2 = randomizer.Next(defficult);

                oprtr = oparator[randomizer.Next(4)].ToString();

                if (oprtr.Equals("-"))
                {
                    if (num1 < num2) //if num1 is small, interchange.
                    {
                        int temp = num1;
                        num1 = num2;
                        num2 = temp;
                    }
                }

                else if (oprtr.Equals("*"))
                {
                    num1 = randomizer.Next(defficult / 4);
                    num2 = randomizer.Next(defficult / 4);
                }

                else if (oprtr.Equals("/"))
                {
                    while (true)
                    {
                        if (num2 == 0)
                            num2 = randomizer.Next(defficult);
                        else if (num1 % num2 == 0)
                            break;
                        else
                        {
                            num1 = randomizer.Next(defficult);
                            num2 = randomizer.Next(defficult);
                        }
                    }
                }

                AnsField.IsEnabled = true;
                AnsField.Value = null;
                AnsFieldc.Clear();
                numlbl1.Content = numlblc1.Content = num1.ToString();
                numlbl2.Content = numlblc2.Content = oprtr + "\t" + num2.ToString();
                timer.Start();

                if (oprtr == "+")
                    ans = num1 + num2;
                else if (oprtr == "-")
                    ans = num1 - num2;
                else if (oprtr == "*")
                    ans = num1 * num2;
                else if (oprtr == "/")
                    ans = num1 / num2;

                defficult += 20;
            }
        }
        private void timer_Tick(object sender, EventArgs e)
        {
            if (time == 0)
            {
                timer.Stop();
                AnsFieldc.Text = ans.ToString();
                status.Content = "Computer got the Ans...";
                status.Foreground = Brushes.Red;
                delay.Start();
                comScore++;
                comScorelbl.Content = "Score: " + comScore;
            }
            else
                time--;
        }
        private void submitBtn_Click(object sender, RoutedEventArgs e)
        {
            var val = AnsField.Value;

            if (ans == val)
            {
                timer.Stop();
                status.Content = "Correct Ans!";
                status.Foreground = Brushes.Green;
                usrScore++;
                usrScorelbl.Content = "Score: " + usrScore;
                delay.Start();
            }
            else
            {
                status.Content = "Wrong Ans";
                status.Foreground = Brushes.Red;
                defficult += 10;
            }
        }
        private void ans_Changed(object sender, RoutedPropertyChangedEventArgs<object> e)
        {
            if (AnsField.Value == null || time == 0)
                submitBtn.IsEnabled = false;
            else
                submitBtn.IsEnabled = true;
        }
    }
}
