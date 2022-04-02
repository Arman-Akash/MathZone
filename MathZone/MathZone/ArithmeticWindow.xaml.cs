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
using System.Speech.Synthesis;
using System.IO;

namespace Arithmetic
{
    /// <summary>
    /// Interaction logic for MainWindow.xaml
    /// </summary>
    public partial class ArithmeticWin : Window
    {
        public ArithmeticWin()
        {
            InitializeComponent();
            bg.ImageSource = new BitmapImage(new Uri(Path.Combine(Environment.CurrentDirectory, "image/", "aw.jpg")));
        }

        private void Additionbtn_Click(object sender, RoutedEventArgs e)
        {
            Addtion add = new Addtion();
            add.Show();
            this.Close();
        }

        private void subtractBtn_Click(object sender, RoutedEventArgs e)
        {
            Subtraction sub = new Subtraction();
            sub.Show();
            this.Close();
        }

        private void mulBtn_Click(object sender, RoutedEventArgs e)
        {
            Multiplication mul = new Multiplication();
            mul.Show();
            this.Close();
        }

        private void divBtn_Click(object sender, RoutedEventArgs e)
        {
            Division div = new Division();
            div.Show();
            this.Close();
        }

        private void backBtn_Click(object sender, RoutedEventArgs e)
        {
            MathZone.MainWindow mw = new MathZone.MainWindow();
            mw.Show();
            this.Close();
        }

        private void AddTutorialbtn_Click(object sender, RoutedEventArgs e)
        {
            new AdditionTutorial().Show();
            this.Close();
        }

        Button btn = new Button();
        private void Btn_MouseEnter(object sender, MouseEventArgs e)
        {
            if (sender.Equals(Additionbtn))
                btn = Additionbtn;
            else if(sender.Equals(subtractBtn))
                btn = subtractBtn;
            else if(sender.Equals(mulBtn))
                btn = mulBtn;
            else if(sender.Equals(divBtn))
                btn = divBtn;
            else if(sender.Equals(AddTutorbtn))
                btn = AddTutorbtn;

            btn.Height += 20;
            btn.Width += 20;
            SpeechSynthesizer reader = new SpeechSynthesizer();
            reader.SpeakAsync(btn.Content.ToString());
        }

        private void Btn_MouseLeave(object sender, MouseEventArgs e)
        {
            btn.Height -= 20;
            btn.Width -= 20;
        }

    }
}
