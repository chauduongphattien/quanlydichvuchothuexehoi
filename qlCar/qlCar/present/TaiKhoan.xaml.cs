using Microsoft.Win32;
using qlCar.Business;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Security.Cryptography;
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
    /// Interaction logic for TaiKhoan.xaml
    /// </summary>
    public partial class TaiKhoan : UserControl
    {
       
        private void fillInfor(DataAcess.NhanVien nv)
        {
            
            
            this.tenLB.Content = nv.Ten;
            this.MailLB.Content = nv.mail;
            this.idLB.Content = nv.id; ;
            this.sdtLB.Content= nv.sdt;
            string gt;
            if (nv.gioitinh == 1) { gt = "Nam"; }
            else gt = "NỮ";
            this.gioitinhLB.Content = gt;
           
            if (nv.vitriCV == "QL") vitriLB.Content = "Quản Lý";
            else if (nv.vitriCV == "MKT") vitriLB.Content = "makerting";
            else if (nv.vitriCV == "Sale") vitriLB.Content = "Sale";
            else { }
        
           
        }


        int id;

        public int Id { get => id; set => id = value; }

        public TaiKhoan(int _id)
        {
            InitializeComponent();
            TaikhoanHand tkH = new TaikhoanHand();
            DataAcess.NhanVien mainNV = tkH.getinforNV(_id);
            fillInfor(mainNV);
            Id = _id;
            BitmapImage bmII = tkH.loadImage(Id);
            AvtBackGr.Background = new ImageBrush(bmII);

        }

        private void thâyvtBtn_Click(object sender, RoutedEventArgs e)
        {
            TaikhoanHand tkH = new TaikhoanHand();
            OpenFileDialog openFile = new OpenFileDialog();
            if(openFile.ShowDialog() == true)
            {
                string filepath=openFile.FileName;
                byte[] fileByte=System.IO.File.ReadAllBytes(filepath);
                try
                {
                    tkH.saveImage(fileByte, Id);
                    BitmapImage bmI = tkH.loadImage(Id);
                    AvtBackGr.Background = new ImageBrush(bmI);

                }
                catch
                {
                    System.Windows.MessageBox.Show("lỗi tải ảnh!");
                        
                }
            }

        }

        private void doiMKBut_Click(object sender, RoutedEventArgs e)
        {
            changePassForm cF = new changePassForm(id);
            cF.ShowDialog();
        }

        private void doittBut_Click(object sender, RoutedEventArgs e)
        {
            try {
                doiThongTin dtt = new doiThongTin(Id);
                dtt.ShowDialog();
                TaikhoanHand tkH = new TaikhoanHand();
                DataAcess.NhanVien mainNV = tkH.getinforNV(Id);
                fillInfor(mainNV);
                Id = Id;
                BitmapImage bmII = tkH.loadImage(Id);
                AvtBackGr.Background = new ImageBrush(bmII);
            }
            catch(Exception ex)
            {
                System.Windows.MessageBox.Show(ex.Message);
            }
           
            
        }

        private void chatBut_Click(object sender, RoutedEventArgs e)
        {
           /* chatBox chat = new chatBox();
            chat.ShowDialog();*/
        }
    }
}
