
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

        }

        private void taikhoanBtn_Checked(object sender, RoutedEventArgs e)
        {

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

        }

        private void khachhang_Checked(object sender, RoutedEventArgs e)
        {

        }

        private void baotri_Checked(object sender, RoutedEventArgs e)
        {

        }

        private void baocaoBtn_Checked(object sender, RoutedEventArgs e)
        {

        }
    }
}
