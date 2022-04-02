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
//using System.Windows.Shapes;
using System.IO;
using System.Speech.Synthesis;

namespace MathZone
{
    /// <summary>
    /// Interaction logic for MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        public MainWindow()
        {
            InitializeComponent();
            bg.ImageSource = new BitmapImage(new Uri(Path.Combine(Environment.CurrentDirectory, "image/", "pooh.jpg")));
        }

        private void arithmaticBtn_Click(object sender, RoutedEventArgs e)
        {
            new Arithmetic.ArithmeticWin().Show();
            this.Close();
        }

        private void ttBtn_Click(object sender, RoutedEventArgs e)
        {
            TTWindow tt = new TTWindow();
            tt.Show();
            this.Close();
        }

        private void gameBtn_Click(object sender, RoutedEventArgs e)
        {
            new Game.GameWindow().Show();
            this.Close();
        }

        private void unitsBtn_Click(object sender, RoutedEventArgs e)
        {
            new Formulas().Show();
            this.Close();
        }

        private void geometryBtn_Click(object sender, RoutedEventArgs e)
        {
            new Geometry().Show();
            this.Close();
        }

        private void biographyBtn_Click(object sender, RoutedEventArgs e)
        {
            new Biography().Show();
            this.Close();
        }

        Button btn = new Button();
        private void Btn_MouseEnter(object sender, MouseEventArgs e) //it occures more than one time. fix it.
        {
            if (sender.Equals(arithmaticBtn))
                btn = arithmaticBtn;
            else if (sender.Equals(ttBtn))
                btn = ttBtn;
            else if (sender.Equals(GeometryBtn))
                btn = GeometryBtn;
            else if (sender.Equals(gameBtn))
                btn = gameBtn;
            else if (sender.Equals(unitsBtn))
                btn = unitsBtn;
            else
                btn = biographyBtn;

            //Console.WriteLine("Mouse Enter: \n" + btn.Content.ToString());
            //btn.RenderTransform = new RotateTransform(5);
            btn.Height += 20;
            btn.Width += 20;
            SpeechSynthesizer reader = new SpeechSynthesizer();
            reader.SpeakAsync(btn.Content.ToString());
        }
        private void Btn_MouseLeave(object sender, MouseEventArgs e)
        {
            btn.Height -= 20;
            btn.Width -= 20;
//            btn.RenderTransform = new RotateTransform(0);
        }
    }
}
