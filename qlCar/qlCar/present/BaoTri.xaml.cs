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
    /// Interaction logic for BaoTri.xaml
    /// </summary>
    public partial class BaoTri : UserControl
    {
        public BaoTri()
        {
            InitializeComponent();
            baotriHand btH=new baotriHand();
            List<DataAcess.BaoTri> bt=new List<DataAcess.BaoTri>();
            bt = btH.getXe_baotri();
            listviewBaotri.ItemsSource = bt;
        }

        private void xemthongtinbut_Click(object sender, RoutedEventArgs e)
        {
            var _baotri = listviewBaotri.SelectedItem as DataAcess.BaoTri;

            tBInfor.Text = _baotri.LoaiDV.ToString();
        }

       
        private void hoantatbtn_Click(object sender, RoutedEventArgs e)
        {
            if (listviewBaotri.SelectedItems.Count == 1)
            {
                var _baotri = listviewBaotri.SelectedItem as DataAcess.BaoTri;
                string idxe = _baotri.SoXe.ToString();
                quanlyxehoiDATAEntities db = new quanlyxehoiDATAEntities();
                using (db)
                {
                    var xebt = db.BaoTris.FirstOrDefault(i => i.SoXe == idxe);
                    if (xebt.ngayKetThuc == null)
                    {
                        xebt.ngayKetThuc = DateTime.Now;
                        var car = db.XEHOIs.FirstOrDefault(i => i.bienSo == idxe);
                        car.TrangThai = 0;
                        db.SaveChanges();
                        baotriHand btH = new baotriHand();
                        List<DataAcess.BaoTri> bt = new List<DataAcess.BaoTri>();
                        bt = btH.getXe_baotri();
                        listviewBaotri.ItemsSource = bt;
                    }
                  
                   

                }
            }
           
        }

        private void demxebaotri_Click(object sender, RoutedEventArgs e)
        {
            quanlyxehoiDATAEntities db = new quanlyxehoiDATAEntities();
            using (db)
            {
                var xes = from item in db.XEHOIs where (item.TrangThai==-1) select item;
                tBInfor.Text = xes.Count().ToString();
            }
        }
    }
}
