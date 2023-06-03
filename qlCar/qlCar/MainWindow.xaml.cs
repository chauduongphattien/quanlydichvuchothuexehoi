
using qlCar.present;
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

namespace qlCar
{
    /// <summary>
    /// Interaction logic for MainWindow.xaml
    /// </summary>
    /// 

    public partial class MainWindow : Window
    {

        login lg;

        string userName;
        string pass;
        string vitri; 
        int id;
        NhanVien nhan_vien;
        XeHoi Xe_hoi;
        KhachHang khach_hang;
        TaiKhoan tai_khoan;
        DatXe dat_xe;
        BaoTri bao_tri;
        BaoCao bao_cao;
        home trang_chu;
        public string UserName { get => userName; set => userName = value; }
        public string Pass { get => pass; set => pass = value; }
        public string Vitri { get => vitri; set => vitri = value; }
        public int Id { get => id; set => id = value; }

        public MainWindow()
        {
            lg = new login();
            lg.ShowDialog();
            InitializeComponent();
            Vitri = lg.vi_tri;
            Id = lg.id;
            homeBtn.IsChecked = true;
        }


        

        private void ctrBar_MouseLeftButtonDown(object sender, MouseButtonEventArgs e)
        {
            DragMove();
        }

        private void closeBtn_Click(object sender, RoutedEventArgs e)
        {
            Application.Current.Shutdown();
        }

        private void minBtn_Click(object sender, RoutedEventArgs e)
        {
            WindowState = WindowState.Minimized;
        }

       
        private void homeBtn_Checked(object sender, RoutedEventArgs e)
        {
            trang_chu = new home();
            mainFrame.Navigate(trang_chu);
        }

        private void taikhoanBtn_Checked(object sender, RoutedEventArgs e)
        {
            tai_khoan = new TaiKhoan(Id);
            mainFrame.Navigate(tai_khoan);
           // System.Windows.MessageBox.Show(Id.ToString());
        }

        private void carBtn_Checked(object sender, RoutedEventArgs e)
        {
            Xe_hoi = new XeHoi();
            mainFrame.Navigate(Xe_hoi);
        }

        private void NhanvienBtn_Checked(object sender, RoutedEventArgs e)
        {
            nhan_vien = new NhanVien(Id);
            mainFrame.Navigate(nhan_vien);
        }

        private void orderBtn_Checked(object sender, RoutedEventArgs e)
        {
            dat_xe = new DatXe();
            mainFrame.Navigate(dat_xe);
        }

        private void khachhang_Checked(object sender, RoutedEventArgs e)
        {
            khach_hang = new KhachHang();
            mainFrame.Navigate(khach_hang);
        }

        private void baotri_Checked(object sender, RoutedEventArgs e)
        {
            bao_tri = new BaoTri();
            mainFrame.Navigate(bao_tri);
        }

        private void baocaoBtn_Checked(object sender, RoutedEventArgs e)
        {
            bao_cao = new BaoCao(this.mainFrame);
            mainFrame.Navigate(bao_cao);
        }
    }
}
