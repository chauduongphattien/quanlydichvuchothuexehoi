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
    /// Interaction logic for datxeForm.xaml
    /// </summary>
    public partial class datxeForm : Window  // form bao tri do dặt tên lộn
    {
        DataAcess.XEHOI xh;
        public datxeForm(DataAcess.XEHOI xe_hoi)
        {
            InitializeComponent();
            xh = xe_hoi;
        }

        private void ctrBar_MouseLeftButtonDown(object sender, MouseButtonEventArgs e)
        {
            this.DragMove();
        }

        private void huyBut_Click(object sender, RoutedEventArgs e)
        {
            this.Close();
        }

        private void okBut_Click(object sender, RoutedEventArgs e)
        {
            baotriHand btHand = new baotriHand();
            try
            {
                btHand.themBaotri(xh.bienSo, Convert.ToDateTime(datetimePickerNhan.SelectedDate),  Convert.ToDecimal(chiphitxt.Text), motatxt.Text);
                this.Close();
            }
            catch(Exception ex) 
            {
                System.Windows.MessageBox.Show(ex.Message);
            }
        }
    }
}
