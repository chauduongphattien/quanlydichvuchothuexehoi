using qlCar.DataAcess;
using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Data.SqlTypes;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Media.Imaging;

namespace qlCar.Business
{
    public class TaikhoanHand
    {
       

        public DataAcess.NhanVien getinforNV(int _id)
        {
            quanlyxehoiDATAEntities db = new quanlyxehoiDATAEntities();
            DataAcess.NhanVien n = new DataAcess.NhanVien();
            using (db)
            {

                var _nv = db.NhanViens.FirstOrDefault(e => e.id == _id);
                n = _nv;
            }

            return n;
        }


        public void saveImage(byte[] image,int _id)
        {
            quanlyxehoiDATAEntities db = new quanlyxehoiDATAEntities();
            using (db)
            {
                var tk = db.TaiKhoans.FirstOrDefault(e => e.id == _id);
                tk.avt = image;
                db.SaveChanges();
            }
        }

        public void changeThoongTin(string email, string sdt, int _id)
        {
            quanlyxehoiDATAEntities db = new quanlyxehoiDATAEntities();
            using (db)
            {
                var p1 = new SqlParameter("@p1", email);
                var p2 = new SqlParameter("@p2", sdt);
                var p3 = new SqlParameter("@p3",  _id);
                try
                {
                    db.Database.ExecuteSqlCommand("exec doiThongTin @p1, @p2, @p3", p1, p2, p3);
                    
                }
                catch(Exception ee)
                {
                    System.Windows.MessageBox.Show(ee.Message);
                }
            }
        }

        public void change_pass(int _id,string newpass)
        {
            quanlyxehoiDATAEntities db = new quanlyxehoiDATAEntities();
            using (db)
            {
                var tk = db.TaiKhoans.FirstOrDefault(e => e.id == _id);
                tk.pass = newpass;
                db.SaveChanges();
            }
        }



        public BitmapImage loadImage(int _id)
        {
            BitmapImage bIm;
            quanlyxehoiDATAEntities db = new quanlyxehoiDATAEntities();
            using (db)
            {
                var image= db.TaiKhoans.FirstOrDefault(e=> e.id == _id);
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
                bIm=bitmapImage;
            }
            return bIm;

        }
    }
}
