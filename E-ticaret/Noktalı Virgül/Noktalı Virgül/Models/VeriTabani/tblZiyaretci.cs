//------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated from a template.
//
//     Manual changes to this file may cause unexpected behavior in your application.
//     Manual changes to this file will be overwritten if the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------

namespace Noktalı_Virgül.Models.VeriTabani
{
    using System;
    using System.Collections.Generic;
    
    public partial class tblZiyaretci
    {
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2214:DoNotCallOverridableMethodsInConstructors")]
        public tblZiyaretci()
        {
            this.tblSepet = new HashSet<tblSepet>();
        }
    
        public int ZiyaretciID { get; set; }
        public string ZiyaretciMAC { get; set; }
    
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<tblSepet> tblSepet { get; set; }
    }
}
