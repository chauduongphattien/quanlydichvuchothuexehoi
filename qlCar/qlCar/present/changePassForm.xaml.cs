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
using System.Windows.Shapes;

namespace qlCar.present
{
    /// <summary>
    /// Interaction logic for changePassForm.xaml
    /// </summary>
    public partial class changePassForm : Window
    {
        int id;
        public changePassForm(int id)
        {
            InitializeComponent();
            Id = id;
        }

        public int Id { get => id; set => id = value; }

        private void closeBut_Click(object sender, RoutedEventArgs e)
        {
            this.Close();
        }

        private void moveBar_MouseLeftButtonDown(object sender, MouseButtonEventArgs e)
        {
            this.DragMove();
        }

        private void saveBut_Click(object sender, RoutedEventArgs e)
        {
            if(userBox.Password !="" && passBox.Password != "" && userBox.Password==passBox.Password)
            {
                TaikhoanHand tkH = new TaikhoanHand();
                tkH.change_pass(Id, userBox.Password);
                this.Close();
            }
            else { tbLB.Content = "đổi thất bại!"; }

        }
    }
}
