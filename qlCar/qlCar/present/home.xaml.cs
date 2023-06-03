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

namespace qlCar.present
{
    /// <summary>
    /// Interaction logic for home.xaml
    /// </summary>
    public partial class home : UserControl
    {
        string path;
        int index=1;
        List<string> backgr = new List<string> { "../../image/340175410_232008729346432_6103797438936527641_n.jpg", "../../image/car.jpg", "../../image/xedo.jpg" };
        List<string> contenl = new List<string> { "Mẫu xinh", "Xe xịn", "Sang trọng" };
        string content;
        public home()
        {
            InitializeComponent();
            path = backgr[index].ToString();
            content = contenl[index];

           
              slide.ImageSource = new BitmapImage(new Uri(path, UriKind.RelativeOrAbsolute));
            ctLB.Content= content;
           
        }

        private void tranferright_Click(object sender, RoutedEventArgs e)
        {
            index++;
            if (index == 3) index = 0;
            content = contenl[index];
            path = backgr[index];
            slide.ImageSource = new BitmapImage(new Uri(path, UriKind.RelativeOrAbsolute));
            ctLB.Content = content;
            /*ImageBrush im = new ImageBrush();
            im.ImageSource = new BitmapImage(new Uri(path, UriKind.Relative));
            slide.Background = im;*/





        }

        private void tranferleft_Click(object sender, RoutedEventArgs e)
        {

            index--;
            if (index == -1) index = 2;
            path = backgr[index];
            path = backgr[index];
            slide.ImageSource = new BitmapImage(new Uri(path, UriKind.RelativeOrAbsolute));
            ctLB.Content = content;
        }
    }
}
