using qlCar.DataAcess;
using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace qlCar.present
{
    public class baotriHand
    {
        public void themBaotri( string bienso,DateTime batdau, decimal chiphi, string dichvu)
        {
            quanlyxehoiDATAEntities db = new quanlyxehoiDATAEntities();
            using (db)
            {
                var p1 = new SqlParameter("@p1", bienso);
                var p2 = new SqlParameter("@p2",batdau);
               
                var p4 = new SqlParameter("@p4", chiphi);
                var p5 = new SqlParameter("@p5", dichvu);
                try
                {
                    db.Database.ExecuteSqlCommand("exec sp_baotri @p1,@p2,@p4,@p5", p1, p2, p4, p5);
                    
                }
                catch (Exception ee)
                {
                    System.Windows.MessageBox.Show(ee.Message);
                }

            }
        }

        public List<DataAcess.BaoTri> getXe_baotri()
        {
            List<DataAcess.BaoTri> xeBTs=new List<DataAcess.BaoTri> ();
            quanlyxehoiDATAEntities db=new quanlyxehoiDATAEntities ();
            using (db)
            {
                var qr = from item in db.BaoTris select item;
                foreach (var item in qr)
                {
                    xeBTs.Add(item);

                }
            }
            return xeBTs;
        }

    }
}
