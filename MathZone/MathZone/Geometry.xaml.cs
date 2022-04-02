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
using System.IO;

namespace MathZone
{
    /// <summary>
    /// Interaction logic for Geometry.xaml
    /// </summary>
    public partial class Geometry : Window
    {
        public Geometry()
        {
            InitializeComponent();
        }

        private void backBtn_Click(object sender, RoutedEventArgs e)
        {
            new MainWindow().Show();
            this.Close();
        }

        private void Window_Loaded(object sender, RoutedEventArgs e)
        {
            bg.ImageSource = new BitmapImage(new Uri(Path.Combine(Environment.CurrentDirectory, "image", "gm.jpg")));
            //images
            etshapes.Source = new BitmapImage(new Uri(Path.Combine(Environment.CurrentDirectory, "image", "Triangle.Equilateral.png")));
            istshapes.Source = new BitmapImage(new Uri(Path.Combine(Environment.CurrentDirectory, "image", "Triangle.Isosceles.png")));
            stshapes.Source = new BitmapImage(new Uri(Path.Combine(Environment.CurrentDirectory, "image", "Triangle.Scalene.png")));
            rtshapes.Source = new BitmapImage(new Uri(Path.Combine(Environment.CurrentDirectory, "image", "Triangle.Right.png")));
            otshapes.Source = new BitmapImage(new Uri(Path.Combine(Environment.CurrentDirectory, "image", "Triangle.Obtuse.png")));
            atshapes.Source = new BitmapImage(new Uri(Path.Combine(Environment.CurrentDirectory, "image", "Triangle.Acute.png")));

            //Definations
            lineDefinatn.Content = "There are mainly two types of line.\n"
                                  + "  1. Straight line \n  2. Curve";

            QuadDefinatn.Content = "A quadrilateral is a polygon with four edges (or sides) and four vertices or corners."
                                 + "Sometimes, the term quadrangle is used, by analogy with triangle and sometimes tetragon.\n"
                                 + "The total interior angles of a quadrilaterals is 360 degrees. Degree is a measurement unit of angles"
                                 + "There are several types of quadrilaterals:\n"
                                 + "   1. Square\n   2. Rhombus\n   3. Rectangle\n   4. Parallelogram\n   5.Trapezoid\n";
            squareDefinatn.Content = "A square is a four-sided shape where all sides have equal length and every angle is a right angle (90 degrees). \n"
                                   + "Also opposite sides are parallel.";
            rhmbsDefinatn.Content = "A rhombus is four-sided shape where all sides have equal length but angles are not the right angle (90 degrees).\n"
                                  + "Also opposite sides are parallel and opposite angles are equal.\n"
                                  + "A rhombus is sometimes called a thomb or a diamond";
            rectangleDefinatn.Content = "A rectangle is a four-sided shape where every angle is a right angle (90 degree).\n"
                                   + "The opposite sides are paraller and equal length. But not the four sides are equal like square.";
            pgDefinatn.Content = "A parallelogram has opposite sides parallel and equal in lenght. Also opposite angles are equal."
                               + "The angles are not the right angles(90 degrees)";
            tzDefinatn.Content = "A trapezoid has a pair of opposite sides parallel. They might not be the same length.\n\n"
                               + "It is called an Isosceles trapezoid if the sides that aren't parallel are equal in length and\n both angles coming from a parallel side are equal.\n\n"
                               + "And a trapezium is a qudrilateral with no parallel sides.\n";

            triangleDefinatn.Content = "A triangle is a polygon with three edges and three vertices.\n"
                                     + "By lengths of side there are three types of triangle:\n  "
                                     + "1. Equilateral triangles\n  2. Isosceles triangle\n  3. Scalene triangle\n"
                                     + "And by internal angles there are three types of triangle\n  "
                                     + "1. Right triangle\n  2. Obtuse triangle\n  3. Acute triangle\n";
            etDefinatn.Content = "An equilateral triangle has all sides the same length." 
                               + "An equilateral triangle is also a regualr polygon with all angles measuring 60 degrees.\n";
            iscDefinatn.Content = "An isosceles triangle has two sides of equal length.\nAn isosceles triangle also has two angles of the same measure; namely, "
                                + "The angles opposdite to the two sides of the same length.\n";
            sclnDefinatn.Content = "A scalene triangle has all ots isdes fo different lengths.\n"
                                 + "Equivalently, it has all angles of different measure.\n";
            rtDefinatn.Content = "A right traingle has one of its interior angles measuring 90 degrees (a right angle).\n"
                               + "The side opposite to the right angles is the hypotenuse, the longest side of the triangle.\nThe other two sides are called the legs or cathet of the triangle.\n"
                               + "it also called right-angled triangle, formerly called a rectangled triangle\n";
            otDefinatn.Content = "A triangle with one interior angle measuring more than 90 degrees is an obtuse traingle or obtuse-angled triangle.\n";
            atDefinatn.Content = "A tringle with all interion angels measuring less than 90 degrees is an acute traingle or acute-angled triangel.\n";

            circleDefinatn.Content = "A circle is the set of all points in a plane that are at a given distance from a given point, the centre.\n"; //if posible give all the defination related to circle like radiaus, diamerer.
        }

        private void backButton_Click(object sender, RoutedEventArgs e)
        {
            new MainWindow().Show();
            this.Hide();
        }
    }
}
