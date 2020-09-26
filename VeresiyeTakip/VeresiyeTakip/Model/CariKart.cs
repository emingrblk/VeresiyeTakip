//------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated from a template.
//
//     Manual changes to this file may cause unexpected behavior in your application.
//     Manual changes to this file will be overwritten if the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------

namespace VeresiyeTakip.Model
{
    using System;
    using System.Collections.Generic;
    
    public partial class CariKart
    {
        public int id { get; set; }
        public string unvani { get; set; }
        public string yetkili { get; set; }
        public string telefonNo { get; set; }
        public string vergiDairesi { get; set; }
        public string adres { get; set; }
        public string ePosta { get; set; }
        public string gsm { get; set; }
        public string faksNo { get; set; }
        public string webAdresi { get; set; }
        public Nullable<decimal> cariLimit { get; set; }
        public string notu { get; set; }
        public Nullable<System.DateTime> tarih { get; set; }
        public string vergiNo { get; set; }
        public Nullable<int> firmaId { get; set; }
        public Nullable<int> ilId { get; set; }
        public Nullable<int> ilce { get; set; }
        public Nullable<int> borcId { get; set; }
        public Nullable<int> hesapId { get; set; }
    
        public virtual Borc Borc { get; set; }
        public virtual Firma Firma { get; set; }
        public virtual Hesap Hesap { get; set; }
        public virtual iller iller { get; set; }
    }
}
