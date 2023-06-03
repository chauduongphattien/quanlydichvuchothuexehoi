using qlCar.DataAcess;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace qlCar.present
{
    public class xehoiHand
    {
        public List<DataAcess.XEHOI> getAllxeHoi()
        {
            List<DataAcess.XEHOI> lXH=new List<DataAcess.XEHOI> ();

            quanlyxehoiDATAEntities db = new quanlyxehoiDATAEntities();
            using (db)
            {
                var qr = from item in db.XEHOIs select item;
                foreach(var item in qr)
                {
                    
                    lXH.Add(item);

                }
            }


            return lXH;

        }



        public  List<DataAcess.XEHOI> timkiemXe(int trangthai, int ghe)
        {
            List<DataAcess.XEHOI> listXe = new List<DataAcess.XEHOI>();
            quanlyxehoiDATAEntities db = new quanlyxehoiDATAEntities();
            using (db)
            {
               var xhois=db.XEHOIs.Where(e=>(e.TrangThai==trangthai && e.SoGhe==ghe));
                listXe = xhois.ToList();
            }

            return listXe;
        }

    }
}
