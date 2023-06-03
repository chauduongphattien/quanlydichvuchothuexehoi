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
    /// Interaction logic for baotriForm.xaml
    /// </summary>
    public partial class baotriForm : Window    // form dat xe  do dat ten lộn
    {
        DataAcess.XEHOI xehoi=new DataAcess.XEHOI();
        public baotriForm(DataAcess.XEHOI xh)
        {
            InitializeComponent();
            xehoi = xh;
            
        }

        private void ctrBar_MouseLeftButtonDown(object sender, MouseButtonEventArgs e)
        {
            this.DragMove();
        }

        private void XNbut_Click(object sender, RoutedEventArgs e)
        {
            datxxeHand dxH=new datxxeHand();
            try
            {
                dxH.datxe(tenKHtxt.Text, cmndKhTXT.Text, sdtKHTxt.Text, mailKHtxt.Text, diachiKHtxt.Text, xehoi.bienSo, Convert.ToDateTime(ngaynhanPicker.SelectedDate), Convert.ToDateTime(ngaytraPicker.SelectedDate));
                this.Close();
            }
            catch
            {
                System.Windows.MessageBox.Show("đặt thất bại");
            }


        }

        private void dongbut_Click(object sender, RoutedEventArgs e)
        {
            this.Close();
        }
    }
}
