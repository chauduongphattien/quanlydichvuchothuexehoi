using qlCar.DataAcess;
using qlCar.present;
using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Data.SqlTypes;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace qlCar.Business
{
    public class tinnhanHand
    {
        public void guiTinNhan(int _idgui, int _idNhan, string content)
        {
            quanlyxehoiDATAEntities db = new quanlyxehoiDATAEntities();
            using (db)
            {
                var p1 = new SqlParameter("@p1", _idgui);
                var p2 = new SqlParameter("@p2", _idNhan);
                var p3 = new SqlParameter("@p3", content);

                db.Database.ExecuteSqlCommand("insert into TinNhan values(@p1,@p2,@p3)", p1, p2, p3);

               
            }
        }

        public List<Gridtemplate> getalltinnhan(int _id,int id_)
        {
            
            List<Gridtemplate> Gridtl=new List<Gridtemplate>();
            quanlyxehoiDATAEntities db = new quanlyxehoiDATAEntities();
            using (db)
            {
                var tinnhans = from it in db.TinNhans where ((it.idGui == _id && id_ == it.idNhan) || (it.idNhan == _id && it.idGui == id_)) select it;
               
               
                
                foreach(var i in tinnhans)
                {
                    if (i.idGui == _id && i.idNhan == id_)
                    {
                        Gridtemplate grtl = new Gridtemplate(1, i.noidung);
                        Gridtl.Add(grtl);
                        grtl = null;


                    }


                    else
                    {
                        Gridtemplate grtl = new Gridtemplate(0, i.noidung);
                        Gridtl.Add(grtl);
                    }

                }
                

            }
            return Gridtl;
        }
        /*public void checkin(int _id, int id_)
        {
            List<Gridtemplate> Gridtl = new List<Gridtemplate>();
            quanlyxehoiDATAEntities db = new quanlyxehoiDATAEntities();
            using (db)
            {
                var tinnhans = from it in db.TinNhans where ((it.idGui == _id && id_ == it.idNhan) || (it.idNhan == _id && it.idGui == id_)) select it;
                foreach (var i in db.TinNhans)
                {
                    if (i.idGui == _id && i.idNhan == id_)
                    {
                        Gridtemplate grtl = new Gridtemplate(1, i.noidung);
                        Gridtl.Add(grtl);
                        grtl = null;


                    }
                    

                    else
                    {
                        Gridtemplate grtl = new Gridtemplate(0, i.noidung);
                        Gridtl.Add(grtl);
                    }

                }


            }
        }*/
    }
}
