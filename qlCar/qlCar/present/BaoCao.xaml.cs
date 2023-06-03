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
    /// Interaction logic for BaoCao.xaml
    /// </summary>
    public partial class BaoCao : UserControl
    {

        Frame Mfr = new Frame();
        public BaoCao(Frame mfr)
        {
            InitializeComponent();
            baocaoHand bcH = new baocaoHand();
            listBC.ItemsSource = bcH.BaoCaoList();
            Mfr = mfr;
        }

        private void xuatvalubaocao_Click(object sender, RoutedEventArgs e)
        {
            if (listBC !=null && listBC.SelectedItems.Count==1)
            {
                quanlyxehoiDATAEntities db = new quanlyxehoiDATAEntities();
                using (db)
                {
                    var bc = listBC.SelectedItem as DataAcess.BaoCao;
                    try
                    {
                        baocaoHand bcH = new baocaoHand();
                        bcH.outWord(bc);
                    }
                    catch(Exception ex)
                    {
                        System.Windows.MessageBox.Show(ex.Message);
                    }

                }
            }

           
            
        }

        private void thembaocao_Click(object sender, RoutedEventArgs e)
        {
            baocaoHand bcH = new baocaoHand();
            bcH.xuatbaocao();
            listBC.ItemsSource = bcH.BaoCaoList();
        }

        private void bieudoBut_Click(object sender, RoutedEventArgs e)
        {
            if (listBC.SelectedItem != null)
            {
                var item = listBC.SelectedItem as DataAcess.BaoCao;

                Mfr.Navigate(new bieudo(item.soXeDaThue, item.soxeDangBaoTri, item.soxeConLai));
            }
          


        }
    }
}
