using LiveCharts;
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
using LiveCharts.Wpf;


namespace bieudotron
{
    /// <summary>
    /// Interaction logic for MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        public SeriesCollection Series { get; set; }
        public MainWindow()
        {
            InitializeComponent();
                Series = new SeriesCollection
            {
                new PieSeries { Title = "Xe được thuê", Values = new ChartValues<double> { xedat } },
                new PieSeries { Title = "Xe bao trì", Values = new ChartValues<double> { xebaotri } },
                new PieSeries { Title = "Còn lại", Values = new ChartValues<double> { conlai } },
              
            };

            DataContext = this;
        }
    }
}
