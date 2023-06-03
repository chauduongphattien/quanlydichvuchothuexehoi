using qlCar.Business;
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
using System.Windows.Shapes;

namespace qlCar.present
{
    /// <summary>
    /// Interaction logic for thongtinNhanvien.xaml
    /// </summary>
    public partial class thongtinNhanvien : Window
    {
        int id;
        public thongtinNhanvien(int _id)
        {
            InitializeComponent();
            this.id = _id;
            nhanvienHand nvH = new nhanvienHand();
            nvH.loadImage(_id, avtNhanvien);
            nvH.tinhluong(_id, this);
            
        }

        private void okBut_Click(object sender, RoutedEventArgs e)
        {
            this.Close();
        }

        private void avtNhanvien_MouseLeftButtonDown(object sender, MouseButtonEventArgs e)
        {
            this.DragMove();
        }
    }
}
