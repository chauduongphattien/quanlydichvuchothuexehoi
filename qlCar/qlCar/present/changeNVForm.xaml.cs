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
    /// Interaction logic for addNVForm.xaml
    /// </summary>
    public partial class changeNVForm : Window
    {
        int id;
        public changeNVForm(int _id)
        {
            InitializeComponent();
            this.id = _id;
        }

        private void okbtn_Click(object sender, RoutedEventArgs e)
        {
            nhanvienHand nvH = new nhanvienHand();

            try
            {
                nvH.ChangeTTNhanVien(id, this);
                System.Windows.MessageBox.Show("Thành công");
                this.Close();

            }
            catch
            {
            }
        }

        private void huybtn_Click(object sender, RoutedEventArgs e)
        {
            this.Close();
        }

        private void ctrBar_MouseLeftButtonDown(object sender, MouseButtonEventArgs e)
        {
            this.DragMove();
        }
    }
}
