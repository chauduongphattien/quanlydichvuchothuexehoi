using LiveCharts;
using LiveCharts.Wpf;
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
    /// Interaction logic for bieudo.xaml
    /// </summary>
    public partial class bieudo : Page
    {
        public SeriesCollection Series { get; set; }

        public bieudo(int xedat, int xethue, int conlai)
        {
            InitializeComponent();
            Series = new SeriesCollection
        {
            new PieSeries { Title = "Xe được thuê", Values = new ChartValues<double> { xedat } },
            new PieSeries { Title = "Xe đang bảo trì", Values = new ChartValues<double> { xethue } },
            new PieSeries { Title = "Xe còn lại", Values = new ChartValues<double> { conlai } },
            
        };
            DataContext = this;

        }
    }
}
