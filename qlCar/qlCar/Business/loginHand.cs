using qlCar.DataAcess;
using System;
using System.Collections.Generic;
using System.Data.Entity.SqlServer;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace qlCar.Business
{

    
    public class loginHand
    {
        quanlyxehoiDATAEntities db;
        public loginHand() {
           db = new quanlyxehoiDATAEntities();
        }
        public string blog(string user, string pass)
        {
            string result="";
            using (db)
            {
                var pa1 = new SqlParameter("@p1",user);
                var pa2 = new SqlParameter("@p2", pass);
               var result_ = db.Database.SqlQuery<string>("exec sp_login @p1,@p2",pa1,pa2).FirstOrDefault();
                result=result_.ToString();
               
            }

            return result;
        }
        public int getID(string sdt)
        {
            quanlyxehoiDATAEntities db1 = new quanlyxehoiDATAEntities();
            int id; 
            using (db1)
            {
                var p1 = new SqlParameter("@p", sdt);
                var kq = db1.Database.SqlQuery<int>("select dbo.get_ID (@p)",p1).FirstOrDefault();
                id = Convert.ToInt32(kq);
                //System.Windows.MessageBox.Show(kq.ToString());
            }

            return id;
        }

    }
    
}
