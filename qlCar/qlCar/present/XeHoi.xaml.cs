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

namespace qlCar.present
{
    /// <summary>
    /// Interaction logic for XeHoi.xaml
    /// </summary>
    public partial class XeHoi : UserControl
    {
        List<int> trangthai = new List<int> {  -1, 0, 1};
        List<int> soghe = new List<int> { 4, 7, 16 };
        public XeHoi()
        {
            InitializeComponent();
            xehoiHand xhH = new xehoiHand();
            List<DataAcess.XEHOI> lxh=new List<DataAcess.XEHOI> ();
            lxh = xhH.getAllxeHoi();
            listViewXeHoi.ItemsSource = lxh;
            comboTrangthai.ItemsSource = trangthai;
            comboboxSoghe.ItemsSource = soghe;
        }

        private void Button_Click(object sender, RoutedEventArgs e)   // xử lý bảo trì
        {
            Button btn=(Button)sender;

            DataAcess.XEHOI xh = (DataAcess.XEHOI)btn.CommandParameter;
            datxeForm dxf = new datxeForm(xh);
            dxf.ShowDialog();
            xehoiHand xhH = new xehoiHand();
            List<DataAcess.XEHOI> lxh = new List<DataAcess.XEHOI>();
            lxh = xhH.getAllxeHoi();
            listViewXeHoi.ItemsSource = lxh;

        }

        private void Button_Click_1(object sender, RoutedEventArgs e) //xử lý đặt xe
        {
            Button btn = (Button)sender;
            DataAcess.XEHOI xh = (DataAcess.XEHOI)btn.CommandParameter;
            baotriForm btF = new baotriForm(xh);
            btF.ShowDialog();
            xehoiHand xhH = new xehoiHand();
            List<DataAcess.XEHOI> lxh = new List<DataAcess.XEHOI>();
            lxh = xhH.getAllxeHoi();
            listViewXeHoi.ItemsSource = lxh;

        }

        private void timkiemBut_Click(object sender, RoutedEventArgs e)
        {
            xehoiHand xehand = new xehoiHand();
            try
            {
                if(comboTrangthai.SelectedItem == null || comboboxSoghe.SelectedItem==null) {
                    System.Windows.MessageBox.Show("mhap day du thong tin để tìm kiếm ");
                }
                else
                {
                    List<DataAcess.XEHOI> listXe = xehand.timkiemXe(Convert.ToInt32(comboTrangthai.SelectedValue), Convert.ToInt32(comboboxSoghe.SelectedValue));
                    listViewXeHoi.ItemsSource = listXe;
                }

                
            }
            catch(Exception ex)
            {
                System.Windows.MessageBox.Show(ex.Message);
            }
         
        }
    }
}
