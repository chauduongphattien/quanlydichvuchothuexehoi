using qlCar.DataAcess;
using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Aspose.Words;
using System.Diagnostics;


namespace qlCar.Business
{
    public class baocaoHand
    {
        public List<DataAcess.BaoCao> BaoCaoList()
        {
            List<DataAcess.BaoCao> baocaos=new List<DataAcess.BaoCao> ();
            quanlyxehoiDATAEntities db = new quanlyxehoiDATAEntities();
            using (db)
            {
                var bc = from it in db.BaoCaos  select it;
                foreach(var i in bc)
                {
                    baocaos.Add(i);
                }
            }
            return baocaos;
        }


        public void xuatbaocao()
        {
            double tienchothue=0;
            double tienbaotri = 0;
            double loinhuan;
            
            quanlyxehoiDATAEntities db = new quanlyxehoiDATAEntities();
            using (db)
            {
                
               

                var thuexes = from i in db.ThueXes select i;
                foreach(var i in thuexes)
                {
                    tienchothue +=  (double)i.chiphi;
                }
                var baotris = from i in db.BaoTris select i;
                foreach(var i in baotris)
                {
                    tienbaotri += (double)i.chiphi;
                }
                loinhuan = tienchothue*100 - tienbaotri;
                DateTime ngaybaocao = DateTime.Now;
               
                var p1 = new SqlParameter("@p1", ngaybaocao);
                var p2 = new SqlParameter("@p2",(decimal)loinhuan);
               

               
                try
                {
                    db.Database.ExecuteSqlCommand("exec sp_xuatbaocao @p1,@p2", p1, p2); //them bao cao


                }
                catch(Exception ex)
                {
                    System.Windows.MessageBox.Show(ex.Message);
                }

               
                


            }
        }


        

        public void outWord(DataAcess.BaoCao bc)
        {
            string templateFilePath = "C:\\Users\\21110\\Documents\\pt.docx";

            // Tạo một đối tượng Document từ mẫu Word
            Document document = new Document(templateFilePath);

            // Thực hiện các thay thế dữ liệu trong mẫu Word
            document.Range.Replace("[soxe]", bc.tongSoXe.ToString());
            document.Range.Replace("[dathue]", bc.soXeDaThue.ToString());
            document.Range.Replace("[baotri]", bc.soxeDangBaoTri.ToString());
            document.Range.Replace("[conlai]", bc.soxeConLai.ToString());
            document.Range.Replace("[doanhthu]", bc.DoanThu.ToString());

            // Đường dẫn đến tệp đầu ra cho báo cáo
            // string outputFilePath = "C:\\Users\\21110\\Documents\\pt10.docx";
            string outputFilePath = $"storefile\\pt10.docx";

            // Lưu tài liệu tạo báo cáo vào tệp đầu ra
            document.Save(outputFilePath);
            Process.Start(outputFilePath);
        }

    }
}
