//------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated from a template.
//
//     Manual changes to this file may cause unexpected behavior in your application.
//     Manual changes to this file will be overwritten if the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------

namespace Model
{
    using System;
    using System.Collections.Generic;
    
    public partial class HocSinh
    {
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2214:DoNotCallOverridableMethodsInConstructors")]
        public HocSinh()
        {
            this.HoaDons = new HashSet<HoaDon>();
        }
    
        public string MaHS { get; set; }
        public string TenHS { get; set; }
        public System.DateTime NgaySinh { get; set; }
        public Nullable<System.DateTime> NgayNhapHoc { get; set; }
        public string TenChaMe { get; set; }
        public string SDTChaMe { get; set; }
        public string DiaChi { get; set; }
        public string LopHC { get; set; }
    
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<HoaDon> HoaDons { get; set; }
        public virtual LopHanhChinh LopHanhChinh { get; set; }
    }
}
