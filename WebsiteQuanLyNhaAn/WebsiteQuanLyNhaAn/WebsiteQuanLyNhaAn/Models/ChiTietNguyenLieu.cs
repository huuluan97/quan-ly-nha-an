//------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated from a template.
//
//     Manual changes to this file may cause unexpected behavior in your application.
//     Manual changes to this file will be overwritten if the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------

namespace WebsiteQuanLyNhaAn.Models
{
    using System;
    using System.Collections.Generic;
    
    public partial class ChiTietNguyenLieu
    {
        public int MaNguyenLieu { get; set; }
        public int MaMonAn { get; set; }
        public decimal DonGiaNL { get; set; }
        public int SoLuong { get; set; }
    
        public virtual MonAn MonAn { get; set; }
        public virtual NguyenLieu NguyenLieu { get; set; }
    }
}