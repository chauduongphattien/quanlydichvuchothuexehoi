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
    /// Interaction logic for NhanVien.xaml
    /// </summary>
    public partial class NhanVien : UserControl
    {
        int idTK;
        public NhanVien(int _idTK)
        {
            InitializeComponent();
            idTK = _idTK;
            nhanvienHand nvH = new nhanvienHand();
            listViewNhanVien.ItemsSource = nvH.getAllNhanvien();

            
        }

        private void listViewNhanVien_SelectionChanged(object sender, SelectionChangedEventArgs e)
        {

        }

        private void Button_Click(object sender, RoutedEventArgs e)
        {

            Button btn=(Button)sender;
            DataAcess.NhanVien nv= (DataAcess.NhanVien)btn.CommandParameter;
            changeNVForm changeNV = new changeNVForm(nv.id);
            changeNV.ShowDialog();
            nhanvienHand nvH = new nhanvienHand();
            listViewNhanVien.ItemsSource = nvH.getAllNhanvien();
        }

        private void Button_Click_1(object sender, RoutedEventArgs e)
        {
            Button but = (Button)sender;
            DataAcess.NhanVien nv =(DataAcess.NhanVien)but.CommandParameter;
            nhanvienHand nvH = new nhanvienHand();
            nvH.DeleteNhanVien(nv.id);

        }

        private void themnvBut_Click(object sender, RoutedEventArgs e)
        {
            addNV addnv = new addNV();
            addnv.ShowDialog();
            nhanvienHand nvH = new nhanvienHand();
            listViewNhanVien.ItemsSource = nvH.getAllNhanvien();

        }

        private void findBtn_Click(object sender, RoutedEventArgs e)
        {
            nhanvienHand nvH = new nhanvienHand();
            if (idFindTXT.Text != "")
            {
                listViewNhanVien.ItemsSource = nvH.timnhanvientheoID(Convert.ToInt32(idFindTXT.Text));
            }
           
        }

        private void Button_Click_2(object sender, RoutedEventArgs e)
        {
            Button btn = (Button)sender;
            DataAcess.NhanVien nv = (DataAcess.NhanVien)btn.CommandParameter;
            thongtinNhanvien ttnv = new thongtinNhanvien(nv.id);
            ttnv.ShowDialog();
        }

        private void Button_Click_3(object sender, RoutedEventArgs e)
        {
            Button but =  (Button)sender;
            DataAcess.NhanVien nv = (DataAcess.NhanVien)but.CommandParameter;
            

            chatBox chatB = new chatBox(idTK, nv.id);
            chatB.ShowDialog();
        }
    }
}
