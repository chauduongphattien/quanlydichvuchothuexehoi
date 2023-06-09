﻿//------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated from a template.
//
//     Manual changes to this file may cause unexpected behavior in your application.
//     Manual changes to this file will be overwritten if the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------

namespace qlCar.DataAcess
{
    using System;
    using System.Data.Entity;
    using System.Data.Entity.Infrastructure;
    using System.Data.Entity.Core.Objects;
    using System.Linq;
    
    public partial class quanlyxehoiDATAEntities : DbContext
    {
        public quanlyxehoiDATAEntities()
            : base("name=quanlyxehoiDATAEntities")
        {
        }
    
        protected override void OnModelCreating(DbModelBuilder modelBuilder)
        {
            throw new UnintentionalCodeFirstException();
        }
    
        public virtual DbSet<BaoCao> BaoCaos { get; set; }
        public virtual DbSet<BaoTri> BaoTris { get; set; }
        public virtual DbSet<DatTruoc> DatTruocs { get; set; }
        public virtual DbSet<KHACHHANG> KHACHHANGs { get; set; }
        public virtual DbSet<NhanVien> NhanViens { get; set; }
        public virtual DbSet<sysdiagram> sysdiagrams { get; set; }
        public virtual DbSet<TaiKhoan> TaiKhoans { get; set; }
        public virtual DbSet<ThueXe> ThueXes { get; set; }
        public virtual DbSet<TinNhan> TinNhans { get; set; }
        public virtual DbSet<XEHOI> XEHOIs { get; set; }
        public virtual DbSet<Luong> Luongs { get; set; }
    
        public virtual int doiThongTin(string mail, string sdt, Nullable<int> id)
        {
            var mailParameter = mail != null ?
                new ObjectParameter("mail", mail) :
                new ObjectParameter("mail", typeof(string));
    
            var sdtParameter = sdt != null ?
                new ObjectParameter("sdt", sdt) :
                new ObjectParameter("sdt", typeof(string));
    
            var idParameter = id.HasValue ?
                new ObjectParameter("id", id) :
                new ObjectParameter("id", typeof(int));
    
            return ((IObjectContextAdapter)this).ObjectContext.ExecuteFunction("doiThongTin", mailParameter, sdtParameter, idParameter);
        }
    
        public virtual int dsp_datxe(string tebKh, string cmndKH, string sdtKH, string mailKH, string diachiKH, string sxe, Nullable<System.DateTime> ngayThue, Nullable<System.DateTime> ngaytra)
        {
            var tebKhParameter = tebKh != null ?
                new ObjectParameter("tebKh", tebKh) :
                new ObjectParameter("tebKh", typeof(string));
    
            var cmndKHParameter = cmndKH != null ?
                new ObjectParameter("cmndKH", cmndKH) :
                new ObjectParameter("cmndKH", typeof(string));
    
            var sdtKHParameter = sdtKH != null ?
                new ObjectParameter("sdtKH", sdtKH) :
                new ObjectParameter("sdtKH", typeof(string));
    
            var mailKHParameter = mailKH != null ?
                new ObjectParameter("mailKH", mailKH) :
                new ObjectParameter("mailKH", typeof(string));
    
            var diachiKHParameter = diachiKH != null ?
                new ObjectParameter("diachiKH", diachiKH) :
                new ObjectParameter("diachiKH", typeof(string));
    
            var sxeParameter = sxe != null ?
                new ObjectParameter("sxe", sxe) :
                new ObjectParameter("sxe", typeof(string));
    
            var ngayThueParameter = ngayThue.HasValue ?
                new ObjectParameter("ngayThue", ngayThue) :
                new ObjectParameter("ngayThue", typeof(System.DateTime));
    
            var ngaytraParameter = ngaytra.HasValue ?
                new ObjectParameter("ngaytra", ngaytra) :
                new ObjectParameter("ngaytra", typeof(System.DateTime));
    
            return ((IObjectContextAdapter)this).ObjectContext.ExecuteFunction("dsp_datxe", tebKhParameter, cmndKHParameter, sdtKHParameter, mailKHParameter, diachiKHParameter, sxeParameter, ngayThueParameter, ngaytraParameter);
        }
    
        public virtual int sp_AddNhanVien(Nullable<int> id, string ten, string sDT, string mail, string vitriCV, Nullable<int> soNamLV, Nullable<int> gioitinh)
        {
            var idParameter = id.HasValue ?
                new ObjectParameter("id", id) :
                new ObjectParameter("id", typeof(int));
    
            var tenParameter = ten != null ?
                new ObjectParameter("Ten", ten) :
                new ObjectParameter("Ten", typeof(string));
    
            var sDTParameter = sDT != null ?
                new ObjectParameter("SDT", sDT) :
                new ObjectParameter("SDT", typeof(string));
    
            var mailParameter = mail != null ?
                new ObjectParameter("mail", mail) :
                new ObjectParameter("mail", typeof(string));
    
            var vitriCVParameter = vitriCV != null ?
                new ObjectParameter("VitriCV", vitriCV) :
                new ObjectParameter("VitriCV", typeof(string));
    
            var soNamLVParameter = soNamLV.HasValue ?
                new ObjectParameter("SoNamLV", soNamLV) :
                new ObjectParameter("SoNamLV", typeof(int));
    
            var gioitinhParameter = gioitinh.HasValue ?
                new ObjectParameter("gioitinh", gioitinh) :
                new ObjectParameter("gioitinh", typeof(int));
    
            return ((IObjectContextAdapter)this).ObjectContext.ExecuteFunction("sp_AddNhanVien", idParameter, tenParameter, sDTParameter, mailParameter, vitriCVParameter, soNamLVParameter, gioitinhParameter);
        }
    
        public virtual int sp_alterdiagram(string diagramname, Nullable<int> owner_id, Nullable<int> version, byte[] definition)
        {
            var diagramnameParameter = diagramname != null ?
                new ObjectParameter("diagramname", diagramname) :
                new ObjectParameter("diagramname", typeof(string));
    
            var owner_idParameter = owner_id.HasValue ?
                new ObjectParameter("owner_id", owner_id) :
                new ObjectParameter("owner_id", typeof(int));
    
            var versionParameter = version.HasValue ?
                new ObjectParameter("version", version) :
                new ObjectParameter("version", typeof(int));
    
            var definitionParameter = definition != null ?
                new ObjectParameter("definition", definition) :
                new ObjectParameter("definition", typeof(byte[]));
    
            return ((IObjectContextAdapter)this).ObjectContext.ExecuteFunction("sp_alterdiagram", diagramnameParameter, owner_idParameter, versionParameter, definitionParameter);
        }
    
        public virtual int sp_baotri(string bienso, Nullable<System.DateTime> ngaybatdau, Nullable<decimal> chiphi, string dichvu)
        {
            var biensoParameter = bienso != null ?
                new ObjectParameter("bienso", bienso) :
                new ObjectParameter("bienso", typeof(string));
    
            var ngaybatdauParameter = ngaybatdau.HasValue ?
                new ObjectParameter("ngaybatdau", ngaybatdau) :
                new ObjectParameter("ngaybatdau", typeof(System.DateTime));
    
            var chiphiParameter = chiphi.HasValue ?
                new ObjectParameter("chiphi", chiphi) :
                new ObjectParameter("chiphi", typeof(decimal));
    
            var dichvuParameter = dichvu != null ?
                new ObjectParameter("dichvu", dichvu) :
                new ObjectParameter("dichvu", typeof(string));
    
            return ((IObjectContextAdapter)this).ObjectContext.ExecuteFunction("sp_baotri", biensoParameter, ngaybatdauParameter, chiphiParameter, dichvuParameter);
        }
    
        public virtual int sp_creatediagram(string diagramname, Nullable<int> owner_id, Nullable<int> version, byte[] definition)
        {
            var diagramnameParameter = diagramname != null ?
                new ObjectParameter("diagramname", diagramname) :
                new ObjectParameter("diagramname", typeof(string));
    
            var owner_idParameter = owner_id.HasValue ?
                new ObjectParameter("owner_id", owner_id) :
                new ObjectParameter("owner_id", typeof(int));
    
            var versionParameter = version.HasValue ?
                new ObjectParameter("version", version) :
                new ObjectParameter("version", typeof(int));
    
            var definitionParameter = definition != null ?
                new ObjectParameter("definition", definition) :
                new ObjectParameter("definition", typeof(byte[]));
    
            return ((IObjectContextAdapter)this).ObjectContext.ExecuteFunction("sp_creatediagram", diagramnameParameter, owner_idParameter, versionParameter, definitionParameter);
        }
    
        public virtual int sp_dropdiagram(string diagramname, Nullable<int> owner_id)
        {
            var diagramnameParameter = diagramname != null ?
                new ObjectParameter("diagramname", diagramname) :
                new ObjectParameter("diagramname", typeof(string));
    
            var owner_idParameter = owner_id.HasValue ?
                new ObjectParameter("owner_id", owner_id) :
                new ObjectParameter("owner_id", typeof(int));
    
            return ((IObjectContextAdapter)this).ObjectContext.ExecuteFunction("sp_dropdiagram", diagramnameParameter, owner_idParameter);
        }
    
        public virtual ObjectResult<sp_helpdiagramdefinition_Result> sp_helpdiagramdefinition(string diagramname, Nullable<int> owner_id)
        {
            var diagramnameParameter = diagramname != null ?
                new ObjectParameter("diagramname", diagramname) :
                new ObjectParameter("diagramname", typeof(string));
    
            var owner_idParameter = owner_id.HasValue ?
                new ObjectParameter("owner_id", owner_id) :
                new ObjectParameter("owner_id", typeof(int));
    
            return ((IObjectContextAdapter)this).ObjectContext.ExecuteFunction<sp_helpdiagramdefinition_Result>("sp_helpdiagramdefinition", diagramnameParameter, owner_idParameter);
        }
    
        public virtual ObjectResult<sp_helpdiagrams_Result> sp_helpdiagrams(string diagramname, Nullable<int> owner_id)
        {
            var diagramnameParameter = diagramname != null ?
                new ObjectParameter("diagramname", diagramname) :
                new ObjectParameter("diagramname", typeof(string));
    
            var owner_idParameter = owner_id.HasValue ?
                new ObjectParameter("owner_id", owner_id) :
                new ObjectParameter("owner_id", typeof(int));
    
            return ((IObjectContextAdapter)this).ObjectContext.ExecuteFunction<sp_helpdiagrams_Result>("sp_helpdiagrams", diagramnameParameter, owner_idParameter);
        }
    
        public virtual ObjectResult<string> sp_login(string sdt, string pass)
        {
            var sdtParameter = sdt != null ?
                new ObjectParameter("sdt", sdt) :
                new ObjectParameter("sdt", typeof(string));
    
            var passParameter = pass != null ?
                new ObjectParameter("pass", pass) :
                new ObjectParameter("pass", typeof(string));
    
            return ((IObjectContextAdapter)this).ObjectContext.ExecuteFunction<string>("sp_login", sdtParameter, passParameter);
        }
    
        public virtual int sp_renamediagram(string diagramname, Nullable<int> owner_id, string new_diagramname)
        {
            var diagramnameParameter = diagramname != null ?
                new ObjectParameter("diagramname", diagramname) :
                new ObjectParameter("diagramname", typeof(string));
    
            var owner_idParameter = owner_id.HasValue ?
                new ObjectParameter("owner_id", owner_id) :
                new ObjectParameter("owner_id", typeof(int));
    
            var new_diagramnameParameter = new_diagramname != null ?
                new ObjectParameter("new_diagramname", new_diagramname) :
                new ObjectParameter("new_diagramname", typeof(string));
    
            return ((IObjectContextAdapter)this).ObjectContext.ExecuteFunction("sp_renamediagram", diagramnameParameter, owner_idParameter, new_diagramnameParameter);
        }
    
        public virtual int sp_upgraddiagrams()
        {
            return ((IObjectContextAdapter)this).ObjectContext.ExecuteFunction("sp_upgraddiagrams");
        }
    
        public virtual int sp_xuatbaocao(Nullable<System.DateTime> ngaybaaocao, Nullable<decimal> doanhthu)
        {
            var ngaybaaocaoParameter = ngaybaaocao.HasValue ?
                new ObjectParameter("ngaybaaocao", ngaybaaocao) :
                new ObjectParameter("ngaybaaocao", typeof(System.DateTime));
    
            var doanhthuParameter = doanhthu.HasValue ?
                new ObjectParameter("doanhthu", doanhthu) :
                new ObjectParameter("doanhthu", typeof(decimal));
    
            return ((IObjectContextAdapter)this).ObjectContext.ExecuteFunction("sp_xuatbaocao", ngaybaaocaoParameter, doanhthuParameter);
        }
    }
}
