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

namespace lab_1
{
    /// <summary>
    /// Логика взаимодействия для MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        private Point2D P;
        private Rectangle R;
        private Triangle T;

        private void drawP(Point2D P)
        {
            Ellipse ellipse = new Ellipse();
            ellipse.Width = 4;
            ellipse.Height = 4;
            ellipse.Stroke = Brushes.Black;
            ellipse.StrokeThickness = 2;
            ellipse.Margin = new Thickness(P.getX() - 2, P.getY() - 2, 0, 0);

            Scene.Children.Add(ellipse);
        }

        private void drawR(Rectangle R)
        {
            Line L1 = new Line();
            L1.Stroke = Brushes.Black;
            Line L2 = new Line();
            L2.Stroke = Brushes.Black;
            Line L3 = new Line();
            L3.Stroke = Brushes.Black;
            Line L4 = new Line();
            L4.Stroke = Brushes.Black;

            L1.X1 = R.getP1().getX();
            L1.Y1 = R.getP1().getY();
            L1.X2 = R.getP2().getX();
            L1.Y2 = R.getP2().getY();

            L2.X1 = R.getP2().getX();
            L2.Y1 = R.getP2().getY();
            L2.X2 = R.getP4().getX();
            L2.Y2 = R.getP4().getY();

            L3.X1 = R.getP4().getX();
            L3.Y1 = R.getP4().getY();
            L3.X2 = R.getP3().getX();
            L3.Y2 = R.getP3().getY();

            L4.X1 = R.getP3().getX();
            L4.Y1 = R.getP3().getY();
            L4.X2 = R.getP1().getX();
            L4.Y2 = R.getP1().getY();

            Scene.Children.Add(L1);
            Scene.Children.Add(L2);
            Scene.Children.Add(L3);
            Scene.Children.Add(L4);
        }

        private void drawT(Triangle T)
        {
            Line L1 = new Line();
            L1.Stroke = Brushes.Black;
            Line L2 = new Line();
            L2.Stroke = Brushes.Black;
            Line L3 = new Line();
            L3.Stroke = Brushes.Black;

            L1.X1 = T.getP1().getX();
            L1.Y1 = T.getP1().getY();
            L1.X2 = T.getP2().getX();
            L1.Y2 = T.getP2().getY();

            L2.X1 = T.getP2().getX();
            L2.Y1 = T.getP2().getY();
            L2.X2 = T.getP3().getX();
            L2.Y2 = T.getP3().getY();

            L3.X1 = T.getP3().getX();
            L3.Y1 = T.getP3().getY();
            L3.X2 = T.getP1().getX();
            L3.Y2 = T.getP1().getY();

            Scene.Children.Add(L1);
            Scene.Children.Add(L2);
            Scene.Children.Add(L3);
        }

        public MainWindow()
        {
            InitializeComponent();
        }

        private void PointBt_Click(object sender, RoutedEventArgs e)
        {
            Scene.Children.Clear();

            this.P = Generation.DrawPoint2D();
            this.R = null;
            this.T = null;

            drawP(this.P);

            Perimeter.Content = "Периметр: ";
            Area.Content = "Площадь: ";
            XY.Content = "Координаты точки: ( " + Math.Round(P.getX(), 2) + "; " + Math.Round(P.getY(), 2) + " )";
        }

        private void RectangleBt_Click(object sender, RoutedEventArgs e)
        {
            Scene.Children.Clear();

            this.P = null;
            this.R = Generation.DrawRectangle();
            this.T = null;

            drawR(this.R);

            Perimeter.Content = "Периметр: " + Math.Round(R.getPerimeter(), 2);
            Area.Content = "Площадь: " + Math.Round(R.getArea(), 2);
            XY.Content = "Координаты вершин: ( " + Math.Round(R.getP1().getX(), 2) + "; " + Math.Round(R.getP1().getY(), 2) + " )" + ", " + "( " + Math.Round(R.getP2().getX(), 2) + "; " + Math.Round(R.getP2().getY(), 2) + " )" + ", " + "( " + Math.Round(R.getP3().getX(), 2) + "; " + Math.Round(R.getP3().getY(), 2) + " )" + ", " + "( " + Math.Round(R.getP4().getX(), 2) + "; " + Math.Round(R.getP4().getY(), 2) + " )";
        }

        private void TriangleBt_Click(object sender, RoutedEventArgs e)
        {

            Scene.Children.Clear();

            this.P = null;
            this.R = null;
            this.T = Generation.DrawTriangle();

            drawT(this.T);
            Perimeter.Content = "Периметр: " + Math.Round(T.getPerimeter(), 2);
            Area.Content = "Площадь: " + Math.Round(T.getArea(), 2);
            XY.Content = "Координаты вершин: ( " + Math.Round(T.getP1().getX(), 2) + "; " + Math.Round(T.getP1().getY(), 2) + " )" + ", " + "( " + Math.Round(T.getP2().getX(), 2) + "; " + Math.Round(T.getP2().getY(), 2) + " )" + ", " + "( " + Math.Round(T.getP3().getX(), 2) + "; " + Math.Round(T.getP3().getY(), 2) + " )";
        }

        private void xSlider_ValueChanged(object sender, RoutedPropertyChangedEventArgs<double> e)
        {

        }

        private void Slider_ValueChanged(object sender, RoutedPropertyChangedEventArgs<double> e)
        {

        }
    }
}
