//------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated from a template.
//
//     Manual changes to this file may cause unexpected behavior in your application.
//     Manual changes to this file will be overwritten if the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------

namespace WEB_Database.Database
{
    using System;
    using System.Collections.Generic;
    
    public partial class DM_SuKien
    {
        public System.Guid id { get; set; }
        public string ma_sukien { get; set; }
        public string ten_sukien { get; set; }
        public string ma_nhanh_gad { get; set; }
        public string is_gad { get; set; }
        public Nullable<System.DateTime> ngay_sukien { get; set; }
        public Nullable<System.DateTime> batdau_sukien { get; set; }
        public Nullable<System.DateTime> ketthuc_sukien { get; set; }
        public string diadiem_sukien { get; set; }
        public string noidung { get; set; }
        public string ma_nv_trinhbay { get; set; }
        public string ma_nv_phutrach { get; set; }
        public string is_online { get; set; }
        public string link_online { get; set; }
        public string is_chophep_diemdanh { get; set; }
        public Nullable<int> hoithao_hoanthanh { get; set; }
        public string nguoi_hoanthanh { get; set; }
        public Nullable<System.DateTime> ngay_hoanthanh { get; set; }
        public Nullable<int> soluong_dukien { get; set; }
        public Nullable<int> soluong_dangky { get; set; }
        public Nullable<int> soluong_thamgia { get; set; }
        public Nullable<int> stt { get; set; }
        public string ghichu { get; set; }
        public Nullable<int> khongsudung { get; set; }
        public Nullable<System.DateTime> ngaytao { get; set; }
        public string nguoitao { get; set; }
        public Nullable<System.DateTime> ngaysua { get; set; }
        public string nguoisua { get; set; }
        public Nullable<System.DateTime> ngayxoa { get; set; }
        public string nguoixoa { get; set; }
        public Nullable<int> daxoa { get; set; }
        public string phienban { get; set; }
        public string rowlog { get; set; }
        public string database_name { get; set; }
    }
}
