using qlCar.Business;
using qlCar.DataAcess;
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
    /// Interaction logic for DatXe.xaml
    /// </summary>
    public partial class DatXe : UserControl
    {
        List<int> ghes=new List<int> {4,7,16 };
        List<string> hangs = new List<string> {"TOYOTA","KIA","MEC" };
        public DatXe()
        {
            InitializeComponent();
            datxxeHand datxe = new datxxeHand();
            list_datxe.ItemsSource=datxe.getAllxethue();
            ghecombo.ItemsSource = ghes;
            hangcombo.ItemsSource=hangs;
        }

        private void checkBtn_Click(object sender, RoutedEventArgs e)
        {
            if(ghecombo.SelectedItem!=null && hangcombo.SelectedItem != null)
            {
                datxxeHand dxHand = new datxxeHand();
                list_datxe.ItemsSource = dxHand.checkinfor(Convert.ToInt32(ghecombo.SelectedItem),hangcombo.SelectedItem.ToString());
            }
        }

        private void hoanttatBtn_Click(object sender, RoutedEventArgs e)
        {
            var xehoiBaotri = list_datxe.SelectedItem as DataAcess.ThueXe;
            try
            {
                datxxeHand dxH = new datxxeHand();
                dxH.hoantat(xehoiBaotri.SoXe);
                System.Windows.MessageBox.Show("Xe da hoan lai");
                datxxeHand datxe = new datxxeHand();
                list_datxe.ItemsSource = datxe.getAllxethue();

            }
            catch
            {
                System.Windows.MessageBox.Show("hoan tra that bai");

            }
        }
    }
}
