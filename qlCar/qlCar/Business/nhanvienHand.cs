using qlCar.DataAcess;
using qlCar.present;
using System;
using System.CodeDom;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.IO;
using System.Linq;
using System.Net.Mail;
using System.Security.Cryptography.X509Certificates;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Controls;
using System.Windows.Forms;
using System.Windows.Media;
using System.Windows.Media.Imaging;

namespace qlCar.Business
{
    public  class nhanvienHand
    {
        public List<DataAcess.NhanVien> getAllNhanvien()
        {
            List<DataAcess.NhanVien> nhavienList=new List<DataAcess.NhanVien> ();
            quanlyxehoiDATAEntities db = new quanlyxehoiDATAEntities();
            using (db)
            {
                var nhanviens = from item in db.NhanViens  select item;
                foreach(var i in nhanviens)
                {
                    if (i.gioitinh == 1)
                    {
                        i.iconString = "Mars";
                        i.iconStringColor = "Blue";
                    }
                    else
                    {
                        i.iconString = "Venus";
                        i.iconStringColor = "Pink";
                    }
                    nhavienList.Add(i); 

                }
            }


            return nhavienList;
        }


        public void  DeleteNhanVien(int _id)
        {
            DialogResult result = System.Windows.Forms.MessageBox.Show("Bạn có chắc chắn muốn xoa nhan vien nay?", "Xác nhận", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
            if (result == System.Windows.Forms.DialogResult.Yes)
            {
                try
                {
                    quanlyxehoiDATAEntities db = new quanlyxehoiDATAEntities();

                    using (db)
                    {
                        var nhanvien = db.NhanViens.FirstOrDefault(i => i.id == _id);
                        db.NhanViens.Remove(nhanvien);
                        db.SaveChanges();
                    }
                }
                catch
                {
                    System.Windows.MessageBox.Show("không thể xóa!");
                }

            }



           
               
        }


        public void ChangeTTNhanVien(int _id, present.changeNVForm addf) 
        {

            DialogResult result = System.Windows.Forms.MessageBox.Show("Bạn có chắc chắn muốn xoa nhan vien nay?", "Xác nhận", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
            if (result == System.Windows.Forms.DialogResult.Yes)
            {
                try
                {
                    quanlyxehoiDATAEntities db = new quanlyxehoiDATAEntities();

                    using (db)
                    {
                        var nhanvien = db.NhanViens.FirstOrDefault(i => i.id == _id);
                        if (addf.tenmoitxt.Text != "")
                        {
                            nhanvien.Ten = addf.tenmoitxt.Text;
                        }
                        else if (addf.mailmoitxt.Text != "")
                        {
                            nhanvien.mail = addf.mailmoitxt.Text;
                        }
                        else if (addf.sdtmoitxt.Text != "")
                        {
                            nhanvien.sdt = addf.sdtmoitxt.Text;
                        }
                        else if (addf.tenmoitxt.Text == "" && addf.mailmoitxt.Text == "" && addf.sdtmoitxt.Text == "")
                        {
                            System.Windows.MessageBox.Show("bạn không có thông tin cần thay đổi");
                        }

                        db.SaveChanges();
                    }
                }
                catch
                {
                    System.Windows.MessageBox.Show("không thể thay đổi!");
                }

            }




           
        }

        public void AddNhanvien(present.addNV addnv) 
        {
            quanlyxehoiDATAEntities db = new quanlyxehoiDATAEntities();
            using (db)
            {
                var p1 = new SqlParameter("@p1", Convert.ToInt32(addnv.idTXT.Text));
                var p2 = new SqlParameter("@p2", addnv.tenTXT.Text);
                var p3 = new SqlParameter("@p3", addnv.mailTXT.Text);
                var p4=new SqlParameter("@p4", addnv.sdtTXT.Text);
                var p5 = new SqlParameter("@p5", addnv.vitriTXT.Text);
                var p6 = new SqlParameter("@p6", Convert.ToInt32(addnv.kinhnghiemTXT.Text));
                var p7 = new SqlParameter("@p7", Convert.ToInt32(0));
                if (addnv.namrdo.IsChecked == true)
                {
                    p7 = new SqlParameter("@p7", Convert.ToInt32(1));
                }
              
                db.Database.ExecuteSqlCommand("exec sp_AddNhanVien @p1,@p2,@p4,@p3,@p5,@p6,@p7", p1, p2, p4, p3, p5, p6, p7);
            }
        }




        public List<DataAcess.NhanVien> timnhanvientheoID(int _id)
        {
            List<DataAcess.NhanVien> ListNV = new List<DataAcess.NhanVien>();
            quanlyxehoiDATAEntities db = new quanlyxehoiDATAEntities();
            using (db)
            {
                var nhanvien=db.NhanViens.FirstOrDefault(i=>i.id==_id);
                ListNV.Add(nhanvien);
            }
            return ListNV;
        }



        public void loadImage(int _id, Border boder)
        {

            quanlyxehoiDATAEntities db = new quanlyxehoiDATAEntities();
            var nhanvien=db.TaiKhoans.FirstOrDefault(i=>i.id==_id);

            if (nhanvien != null)
            {
                BitmapImage bIm;

                using (db)
                {
                    var image = db.TaiKhoans.FirstOrDefault(e => e.id == _id);
                    byte[] byteImg = (byte[])image.avt;



                    BitmapImage bitmapImage = new BitmapImage();
                    using (MemoryStream ms = new MemoryStream(byteImg))
                    {
                        ms.Position = 0;
                        bitmapImage.BeginInit();
                        bitmapImage.CacheOption = BitmapCacheOption.OnLoad;
                        bitmapImage.StreamSource = ms;
                        bitmapImage.EndInit();
                    }
                    bIm = bitmapImage;
                }
                boder.Background = new ImageBrush(bIm);
            }
            else boder.Background = null;



        }



        public void tinhluong(int _id,thongtinNhanvien tt)
        {
            quanlyxehoiDATAEntities db = new quanlyxehoiDATAEntities();
            var nhanvien = db.NhanViens.FirstOrDefault(i => i.id == _id);
            var luong = db.Luongs.FirstOrDefault(i => i.namCongHien == nhanvien.soNamLV && i.vitri == nhanvien.vitriCV);
            double salary = (double)luong.huowngLuong;
            salary = salary * 1000000;
            if (nhanvien.vitriCV == "QL")
            {
                tt.lbChucvu.Content = "Quan ly";
            }
            else if (nhanvien.vitriCV == "Sale")
            {
                tt.lbChucvu.Content = "Sale";
            }
            else if (nhanvien.vitriCV == "MKt")
            {
                tt.lbChucvu.Content = "makerting";
            }
            else if (nhanvien.vitriCV == "TN")
            {
                tt.lbChucvu.Content = "kế toán";
            }

            tt.lbNamlv.Content = nhanvien.soNamLV;
            tt.outluongLB.Content = salary.ToString() + " VND";


        }
        public void guiTinNhan(int _idgui, int _idnhan, string noidung)
        {
           
        }

    }
}
