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
    
    public partial class tbl_Galeri
    {
        public int ID { get; set; }
        public int IcerikID { get; set; }
        public string ResimYolu { get; set; }
        public int GoruntulenmeSayisi { get; set; }
        public int SiraNo { get; set; }
        public System.DateTime EklenmeTarihi { get; set; }
    
        public virtual tbl_Icerik tbl_Icerik { get; set; }
    }
}