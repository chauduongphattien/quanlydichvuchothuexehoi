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
using System.Windows.Forms;
using System.Windows.Input;
using System.Windows.Media;
using System.Windows.Media.Imaging;
using System.Windows.Shapes;

namespace qlCar.present
{
    /// <summary>
    /// Interaction logic for doiThongTin.xaml
    /// </summary>
    public partial class doiThongTin : Window
    {
        int id;

        public int Id { get => id; set => id = value; }

        public doiThongTin(int _id)
        {
            InitializeComponent();
            Id = _id;
        }

        private void ctrbar_MouseLeftButtonDown(object sender, MouseButtonEventArgs e)
        {
            this.DragMove();
        }

        private void okBut_Click(object sender, RoutedEventArgs e)
        {
            TaikhoanHand tk = new TaikhoanHand();
            DialogResult result =System.Windows.Forms.MessageBox.Show("Bạn có chắc chắn muốn thay đổi?", "Xác nhận", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
            if (result==System.Windows.Forms.DialogResult.Yes)
            {
                try
                {
                    tk.changeThoongTin(mailBox.Text, phoneBox.Text, Id);
                    this.Close();
                }
                catch
                {
                    System.Windows.MessageBox.Show("không thể thay đổi!");
                }
              
            }

           
        }

        private void canelBut_Click(object sender, RoutedEventArgs e)
        {
            this.Close();
        }
    }
}
