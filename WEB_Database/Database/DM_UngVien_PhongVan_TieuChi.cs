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
    
    public partial class DM_UngVien_PhongVan_TieuChi
    {
        public System.Guid id { get; set; }
        public Nullable<System.Guid> id_uv { get; set; }
        public Nullable<int> stt { get; set; }
        public string ma_tieuchuan_ungtuyen { get; set; }
        public string ma_danhgia_ungtuyen { get; set; }
        public string ykien { get; set; }
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
