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
//using System.Windows.Shapes;
using System.Windows.Threading;
using System.IO;

namespace Game
{
    /// <summary>
    /// Interaction logic for Game1.xaml
    /// </summary>
    public partial class Game1 : Window
    {
        Random randomizer = new Random();
        DispatcherTimer timer;
        int num1, num2, score = -1;
        int timeleft = 20, lavelTime = 0;
        int defficult = 15;
        char[] oparator = { '+', '-', '*', '/' };

        public Game1()
        {
            InitializeComponent();
            timeBar.Value = 100;
            cancelBtn.IsEnabled = false;
            componentVisibility(Visibility.Hidden);
        }

        private void componentVisibility(Visibility done)
        {
            timeBar.Visibility = done;
            oprtrlbl.Visibility = done;
            equallbl.Visibility = done;
            txtNum.Visibility = done;
            numlbl1.Visibility = done;
            numlbl2.Visibility = done;
            scoreLbl.Visibility = done;
            emoticon.Visibility = done;
        }
        private void startBtn_Click(object sender, RoutedEventArgs e)
        {
            goToNext();
            componentVisibility(Visibility.Visible);
            timeBar.Foreground = Brushes.Green;
            timer.Start();

            startBtn.IsEnabled = false;
            cancelBtn.IsEnabled = true;

            MediaPlayer bgsnd = new MediaPlayer();
            var path = Path.Combine(Environment.CurrentDirectory, "sound", "tick.mp3");
            bgsnd.Open(new Uri(path));
            bgsnd.Play();

        }

        private void goToNext()
        {
            score++;
            defficult += 5;
            num1 = randomizer.Next(defficult - 19, defficult);
            num2 = randomizer.Next(defficult);

            oprtrlbl.Content = oparator[randomizer.Next(4)].ToString();

            if (oprtrlbl.Content.Equals("-"))
            {
                if (num1 < num2)
                {
                    int temp = num1;
                    num1 = num2;
                    num2 = temp;
                }
            }

            if (oprtrlbl.Content.Equals("*"))
            {
                num1 = randomizer.Next(defficult / 4);
                num2 = randomizer.Next(defficult / 4);
            }

            if (oprtrlbl.Content.Equals("/"))
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

            numlbl1.Content = num1.ToString();
            numlbl2.Content = num2.ToString();

            scoreLbl.Content = "Score : " + score.ToString();
            statuslbl.Content = "";

            lavelTime = timeleft + 10;
            timeleft = lavelTime;
            txtNum.Value = null;
            var path = Path.Combine(Environment.CurrentDirectory, "image", "happy.jpg");
            var bitmap = new BitmapImage(new Uri(path));
            emoticon.Source = bitmap;
        }

        private void timer_Tick(object sender, EventArgs e)
        {
            if (checkTheAns())
            {
                goToNext();
            }

            else if (timeleft >= 0)
            {
                MediaPlayer bgsnd = new MediaPlayer();
                var sndPath = Path.Combine(Environment.CurrentDirectory, "sound", "tick.mp3");
                bgsnd.Open(new Uri(sndPath));
                bgsnd.Play();
                bgsnd.SpeedRatio = 5;

                if (timeleft > 30)
                    timeleft = 30;
                timeBar.Value = (int)((100.00 / 30.00) * timeleft);

                if (timeBar.Value < 75 && timeBar.Value >= 50)
                {
                    timeBar.Foreground = Brushes.GreenYellow;
                    var path = Path.Combine(Environment.CurrentDirectory, "image", "warning.jpg");
                    var bitmap = new BitmapImage(new Uri(path));
                    emoticon.Source = bitmap;
                }
                else if (timeBar.Value < 50 && timeBar.Value >= 25)
                {
                    timeBar.Foreground = Brushes.Yellow;
                }
                else if (timeBar.Value < 25 && timeBar.Value > 12)
                {
                    timeBar.Foreground = Brushes.OrangeRed;
                    var path = Path.Combine(Environment.CurrentDirectory, "image", "panic.jpg");
                    var bitmap = new BitmapImage(new Uri(path));
                    emoticon.Source = bitmap;
                }
                else if (timeBar.Value <= 12)
                    timeBar.Foreground = Brushes.Red;

                statuslbl.Content = "Time Left : " + timeleft.ToString();
                timeleft--;
            }

            else
            {
                timer.Stop();
                statuslbl.Content = "Time's Up";
                timeleft = 20;
                defficult = 0;
                // ansField.Value = num1 + num2; //remove or edit
                lavelTime = 0; timeleft = 20;
                score = -1;
                startBtn.IsEnabled = true;
                cancelBtn.IsEnabled = false;
                var path = Path.Combine(Environment.CurrentDirectory, "image", "sad.jpg");
                var bitmap = new BitmapImage(new Uri(path));
                emoticon.Source = bitmap;

                MediaPlayer bgsnd = new MediaPlayer();
                var sndPath = Path.Combine(Environment.CurrentDirectory, "sound", "KO.mp3");
                bgsnd.Open(new Uri(sndPath));
                bgsnd.Play();
                bgsnd.SpeedRatio = 5;
            }
        }

        private bool checkTheAns()
        {
            var Ans = txtNum.Value;
            if ((string)oprtrlbl.Content == "+")
            {
                if (num1 + num2 == Ans)
                    return true;
                else
                    return false;
            }
            else if ((string)oprtrlbl.Content == "-")
            {
                if (num1 - num2 == Ans)
                    return true;
                else
                    return false;
            }
            else if ((string)oprtrlbl.Content == "*")
            {
                if (num1 * num2 == Ans)
                    return true;
                else
                    return false;
            }
            else
            {
                if (num1 / num2 == Ans)
                    return true;
                else
                    return false;
            }
        }

        private void cancelBtn_Click(object sender, RoutedEventArgs e)
        {
            timer.Stop();
            componentVisibility(Visibility.Hidden);
            startBtn.IsEnabled = true;
            cancelBtn.IsEnabled = false;
            timeleft = 50;
            defficult = 0;
        }

        private void game_Loaded(object sender, RoutedEventArgs e)
        {
            timer = new DispatcherTimer();
            timer.Tick += new EventHandler(timer_Tick);
            timer.Interval = new TimeSpan(0, 0, 1);
        }
        private void backButton_Click(object sender, RoutedEventArgs e)
        {
            new MathZone.MainWindow().Show();
            this.Close();
        }
    }
}
