//------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated from a template.
//
//     Manual changes to this file may cause unexpected behavior in your application.
//     Manual changes to this file will be overwritten if the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------

namespace AdminPanel.Models
{
    using System;
    using System.Collections.Generic;
    
    public partial class tbl_Icerik
    {
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2214:DoNotCallOverridableMethodsInConstructors")]
        public tbl_Icerik()
        {
            this.tbl_Galeri = new HashSet<tbl_Galeri>();
        }
    
        public int ID { get; set; }
        public int ModulID { get; set; }
        public int UstID { get; set; }
        public int DilID { get; set; }
        public string Baslik { get; set; }
        public string Ozet { get; set; }
        public string Icerik { get; set; }
        public string AnaResimYolu { get; set; }
        public int OkunmaSayisi { get; set; }
        public int SiraNo { get; set; }
        public string Keyword { get; set; }
        public string Description { get; set; }
        public string Link { get; set; }
        public bool isAktif { get; set; }
        public System.DateTime EklenmeTarihi { get; set; }
    
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<tbl_Galeri> tbl_Galeri { get; set; }
        public virtual tbl_Modul tbl_Modul { get; set; }
        public virtual tbl_Dil tbl_Dil { get; set; }
    }
}
