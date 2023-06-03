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
    /// Interaction logic for Gridtemplate.xaml
    /// </summary>
    public partial class Gridtemplate : UserControl
    {
        public int vt;
        public string ct;
        public Gridtemplate(int vitri,string content)
        {
            InitializeComponent();

            vt = vitri;
            ct = content;
            if (vitri == 0)
            {
                content0.Text = content;
            }
            else
            {
                content1.Text = content;
            }

        }

       
    }
}
