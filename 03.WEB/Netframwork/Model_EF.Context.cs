//------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated from a template.
//
//     Manual changes to this file may cause unexpected behavior in your application.
//     Manual changes to this file will be overwritten if the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------

namespace Netframwork
{
    using System;
    using System.Data.Entity;
    using System.Data.Entity.Infrastructure;
    
    public partial class the15901_TWL_ERP_ProEntities : DbContext
    {
        public the15901_TWL_ERP_ProEntities()
            : base("name=the15901_TWL_ERP_ProEntities")
        {
        }
    
        protected override void OnModelCreating(DbModelBuilder modelBuilder)
        {
            throw new UnintentionalCodeFirstException();
        }
    
        public virtual DbSet<pks_cohoivieclam> pks_cohoivieclam { get; set; }
        public virtual DbSet<pks_nhucaukhachhang> pks_nhucaukhachhang { get; set; }
        public virtual DbSet<pks_nhucaukhachhang_ct> pks_nhucaukhachhang_ct { get; set; }
        public virtual DbSet<pks_nhucaukhachhang_dm_nhucau> pks_nhucaukhachhang_dm_nhucau { get; set; }
        public virtual DbSet<pks_duhoc_capquyenuutien> pks_duhoc_capquyenuutien { get; set; }
        public virtual DbSet<pks_duhoc_capquyenuutien_ct> pks_duhoc_capquyenuutien_ct { get; set; }
    }
}
