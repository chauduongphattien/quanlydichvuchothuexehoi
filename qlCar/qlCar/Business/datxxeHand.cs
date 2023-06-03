using qlCar.DataAcess;
using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Media.Animation;

namespace qlCar.Business
{
    public class datxxeHand
    {
        public void datxe(string tenKH,string cmnd,string sdtKH,string mailKH,string diachiKH,string bienso,DateTime ngaynmhan, DateTime ngaytra) {
            quanlyxehoiDATAEntities db = new quanlyxehoiDATAEntities();
            using (db)
            {
                var p1 = new SqlParameter("@p1", tenKH);
                var p2 = new SqlParameter("@p2", cmnd);
                var p3 = new SqlParameter("@p3", sdtKH);
                var p4 = new SqlParameter("@p4", mailKH);
                var p5 = new SqlParameter("@p5", diachiKH);
                var p6 = new SqlParameter("@p6", bienso);
                var p7 = new SqlParameter("@p7", ngaynmhan);
                var p8 = new SqlParameter("@p8", ngaytra);
                try
                {

                    db.Database.ExecuteSqlCommand("exec dsp_datxe @p1,@p2,@p3,@p4,@p5,@p6,@p7,@p8", p1, p2, p3, p4, p5,p6,p7,p8);

                    System.Windows.MessageBox.Show("đặt thành công");
                }
                catch (Exception ee)
                {
                    System.Windows.MessageBox.Show(ee.Message);
                }

            }

        } 



        public List<DataAcess.ThueXe> getAllxethue()
        {
            List<DataAcess.ThueXe> dsthue=new List<ThueXe> ();
            quanlyxehoiDATAEntities db = new quanlyxehoiDATAEntities();
            using(db){
                var qr = from item in db.ThueXes select item;
                foreach (var item in qr)
                {

                    dsthue.Add(item);

                }
            }
            return dsthue;
        }

        public List<DataAcess.ThueXe> checkinfor(int soghe, string hXe)
        {
            List<DataAcess.ThueXe> dsthue = new List<ThueXe>();
            quanlyxehoiDATAEntities db = new quanlyxehoiDATAEntities();
            using (db)
            {

                

                var qr = from item in db.XEHOIs where(item.TrangThai==1 && item.SoGhe==soghe && item.HangXe==hXe) select item;
                foreach (var item in qr)
                {
                    var sethue = from it in db.ThueXes where (it.SoXe == item.bienSo) select it;
                    foreach(var p in sethue)
                    {
                        dsthue.Add(p);
                    }
                    

                }
            }
            return dsthue;
        }



        public void hoantat(string _id)
        {
            quanlyxehoiDATAEntities db = new quanlyxehoiDATAEntities();
            using (db)
            {
                var xehoi = db.XEHOIs.FirstOrDefault(i => i.bienSo == _id);
                xehoi.TrangThai = 0;
                var thues = db.ThueXes.FirstOrDefault(i => i.SoXe == _id);
                db.ThueXes.Remove(thues);
                db.SaveChanges();
            }
        }
    }
}
