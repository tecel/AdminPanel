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
    
    public partial class tbl_DilCeviri
    {
        public int ID { get; set; }
        public int DilID { get; set; }
        public string Name { get; set; }
        public string Value { get; set; }
    
        public virtual tbl_Dil tbl_Dil { get; set; }
    }
}
