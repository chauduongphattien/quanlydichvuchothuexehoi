
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
        int vitri; // 0 là quản lý, 1 là nhân viên thông thương , 2 là kế toán
        NhanVien nhan_vien;
        XeHoi Xe_hoi;
        KhachHang khach_hang;
        TaiKhoan tai_khoan;
        DatXe dat_xe;
        BaoTri bao_tri;
        BaoCao bao_cao = new BaoCao();
        home trang_chu;
        public string UserName { get => userName; set => userName = value; }
        public string Pass { get => pass; set => pass = value; }
        public int Vitri { get => vitri; set => vitri = value; }

        public MainWindow()
        {
            lg = new login();
            lg.ShowDialog();
           
            InitializeComponent();
            UserName = lg.txtUser.Text;
            nhan_vien = new NhanVien();
            Xe_hoi=new XeHoi();
            khach_hang = new KhachHang();
            tai_khoan= new TaiKhoan();
            dat_xe = new DatXe();
            bao_tri = new BaoTri();

            trang_chu = new home();
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
            mainFrame.Navigate(trang_chu);
        }

        private void taikhoanBtn_Checked(object sender, RoutedEventArgs e)
        {
            mainFrame.Navigate(tai_khoan);
        }

        private void carBtn_Checked(object sender, RoutedEventArgs e)
        {
            mainFrame.Navigate(Xe_hoi);
        }

        private void NhanvienBtn_Checked(object sender, RoutedEventArgs e)
        {
            mainFrame.Navigate(nhan_vien);
        }

        private void orderBtn_Checked(object sender, RoutedEventArgs e)
        {
            mainFrame.Navigate(dat_xe);
        }

        private void khachhang_Checked(object sender, RoutedEventArgs e)
        {
            mainFrame.Navigate(khach_hang);
        }

        private void baotri_Checked(object sender, RoutedEventArgs e)
        {
            mainFrame.Navigate(bao_tri);
        }

        private void baocaoBtn_Checked(object sender, RoutedEventArgs e)
        {
            mainFrame.Navigate(bao_cao);
        }
    }
}
