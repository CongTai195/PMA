//------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated from a template.
//
//     Manual changes to this file may cause unexpected behavior in your application.
//     Manual changes to this file will be overwritten if the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------

namespace UIDesign
{
    using System;
    using System.Collections.Generic;
    
    public partial class TaiKhoan
    {
        public int id { get; set; }
        public string Type { get; set; }
        public int nvID { get; set; }
        public string UserName { get; set; }
        public string Pass { get; set; }
    
        public virtual NhanVien NhanVien { get; set; }
    }
}
