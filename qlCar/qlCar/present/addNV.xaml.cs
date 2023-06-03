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
    /// Interaction logic for addNV.xaml
    /// </summary>
    public partial class addNV : Window
    {
        public addNV()
        {
            InitializeComponent();
        }

        private void themBTN_Click(object sender, RoutedEventArgs e)
        {
            if (idTXT.Text != "" && tenTXT.Text != "" && mailTXT.Text != "" && sdtTXT.Text != "" && vitriTXT.Text != "" && kinhnghiemTXT.Text != "")
            {
                if(vitriTXT.Text=="QL" || vitriTXT.Text == "TN" || vitriTXT.Text == "Sale" || vitriTXT.Text == "MKT")
                {
                    try
                    {
                        nhanvienHand nvH = new nhanvienHand();
                        nvH.AddNhanvien(this);
                        System.Windows.MessageBox.Show("thêm thành công nhân viên");
                        this.Close();

                    }
                    catch(Exception ex) {
                        System.Windows.MessageBox.Show("thêm thất bại"+ex.Message);

                    } 
                    
                }
                else
                {
                   System.Windows.MessageBox.Show("nhập đúng thông tin cột chức vụ");

                }
            }
            else System.Windows.MessageBox.Show("hay nhập đầy đủ thông tin");
        }

        private void huyBTN_Click(object sender, RoutedEventArgs e)
        {
            this.Close();
        }

        private void ctrBar_MouseLeftButtonDown(object sender, MouseButtonEventArgs e)
        {
            this.DragMove();
        }
    }
}
