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

namespace Game
{
    /// <summary>
    /// Interaction logic for MainWindow.xaml
    /// </summary>
    public partial class GameWindow : Window
    {
        public GameWindow()
        {
            InitializeComponent();
        }

        private void game1Btn_Click(object sender, RoutedEventArgs e)
        {
            Game1 gm = new Game1();
            gm.Show();
            this.Close();
        }

        private void game2Btn_Click(object sender, RoutedEventArgs e)
        {
            MathFight mf = new MathFight();
            mf.Show();
            this.Close();
        }
        private void backBtn_Click(object sender, RoutedEventArgs e)
        {
            MathZone.MainWindow mw = new MathZone.MainWindow();
            mw.Show();
            this.Close();
        }
    }
}
