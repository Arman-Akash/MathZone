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
    /// Interaction logic for Formulas.xaml
    /// </summary>
    public partial class Formulas : Window
    {
        public Formulas()
        {
            InitializeComponent();
        }

        private void backBtn_Click(object sender, RoutedEventArgs e)
        {
            new MainWindow().Show();
            this.Close();
        }

        private void lenghtEx_Expanded(object sender, RoutedEventArgs e)
        {
            lenghtEx.Content = "2.54 centimtre = 1 inch\n" 
                             + "12 inches = 1 foot \n"
                             + "3 foots = 1 yard \n"
                             + "1760 yards = 1 mile \n"
                             + "10 milimetre  = 1 centimetre \n" 
                             + "10 centimetre = 1 decimetre \n"
                             + "10 decimetre = 1 metre \n"
                             + "10 metre = 1 decametre\n"
                             + "10 decametre = 1 hectometre \n"
                             + "10 hectometre = 1 kilometre \n";
        }

        private void areaEx_Expanded(object sender, RoutedEventArgs e)
        {
            areaEx.Content = "    1 square unit = length (of that unit) * length (of that unit).\tFor Example: "
                           + "    1 square foot = 1 foot * 1 foot\n"
                           + "                  = 12 inches * 12 inches\n"
                           + "so, 1 square foot = 144 square inches\n.That's how: \n\n"
                           + "1 square centimetre = 1000 square milimetre\n"
                           + "1 square yard = 9 square feet\n"
                           + "1 acre = 4840 square yard \n";
        }
        private void volumeEx_Expanded(object sender, RoutedEventArgs e)
        {

        }
        private void weightEx_Expanded(object sender, RoutedEventArgs e)
        {

        }
        private void temperatureEx_Expanded(object sender, RoutedEventArgs e)
        {

        }
        private void LCEx_Expanded(object sender, RoutedEventArgs e)
        {

        }
        private void timeEx_Expanded(object sender, RoutedEventArgs e)
        {
            TimeEx.Content = "60 seconds = 1 minute\n"
                           + "60 minutes = 1 hour\n"
                           + "24 hours = 1 day\n"
                           + "7 days = 1 week\n"
                           + "365 days = 1 year\n"
                           + "12 years = 1 era\n"
                           + "25 years = 1 silver jubilee\n"
                           + "50 years = 1 Golden jubilee\n"
                           + "100 years = 1 Century";
        }
        private void perimeterEx_Expanded(object sender, RoutedEventArgs e)
        {
            perimeterEx.Content = "Peimeter of a -\nsquare and rhombus: 4*s\n\ts: length of one side\n\n"
                                + "rectangle ans parallelogram: 2*(l+W)\n\tl: length\n\tw: width\n\n"
                                + "other quadrilateral: a + b + c + d\n\t a, b, c and d: length of the 4 sides of quadrilateral\n\n"
                                + "triangle: a + b + c\n\ta, b and c: length of the 3 sides\n\n"
                                + "circle: 4(pi)r\n\tpi: 3.1416\n\tr: radius of the circle\n\n";
        }
        private void geoAreaEx_Expanded(object sender, RoutedEventArgs e)
        {
            geoAreaEx.Content = "Area of a - \n"
                              + "square and rhombus: s * s\n\ts: length of one side\n\n"
                              + "rectangleans parallelogram: l * w\n\tl: length\n\tw: width\n\n"
                              + "triangle: (b * h) / 2\n\tb: length of base\n\th: length of height\n\n"
                              + "trapozoid: (b1 + b2) * h/2\n\tb1 and b2: parallel sides or the bases\n\th: length of height"
                              + "circle: (pi)*r*r\n\tpi: 3.1416\n\tr: radius of the circle\n\n";
        }
        private void geoVolumeEx_Expanded(object sender, RoutedEventArgs e)
        {

        }
    }
}
