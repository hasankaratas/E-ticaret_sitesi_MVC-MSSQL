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
    
    public partial class tblKitap
    {
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2214:DoNotCallOverridableMethodsInConstructors")]
        public tblKitap()
        {
            this.tblFavoriler = new HashSet<tblFavoriler>();
            this.tblPromosyon = new HashSet<tblPromosyon>();
            this.tblSatinAlinanlar = new HashSet<tblSatinAlinanlar>();
            this.tblSepet = new HashSet<tblSepet>();
        }
    
        public int KitapID { get; set; }
        public string ISBNNo { get; set; }
        public string KitapAdi { get; set; }
        public string Yazar { get; set; }
        public int YayinEviID { get; set; }
        public int SayfaSayisi { get; set; }
        public int BasimYili { get; set; }
        public decimal Fiyati { get; set; }
        public string KapakResmi { get; set; }
        public string Aciklama { get; set; }
        public int Adet { get; set; }
        public Nullable<bool> StokDurumu { get; set; }
        public int TurID { get; set; }
        public Nullable<bool> SilindiMi { get; set; }
    
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<tblFavoriler> tblFavoriler { get; set; }
        public virtual tblKitapTur tblKitapTur { get; set; }
        public virtual tblYayinEvi tblYayinEvi { get; set; }
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<tblPromosyon> tblPromosyon { get; set; }
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<tblSatinAlinanlar> tblSatinAlinanlar { get; set; }
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<tblSepet> tblSepet { get; set; }
    }
}
