//------------------------------------------------------------------------------
// <auto-generated>
//    This code was generated from a template.
//
//    Manual changes to this file may cause unexpected behavior in your application.
//    Manual changes to this file will be overwritten if the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------

namespace KCOT
{
    using System;
    using System.Collections.Generic;
    
    public partial class PROJEKAT
    {
        public PROJEKAT()
        {
            this.RADPROJs = new HashSet<RADPROJ>();
        }
    
        public decimal SPR { get; set; }
        public decimal RUK { get; set; }
        public string NAP { get; set; }
        public string NAR { get; set; }
    
        public virtual RADNIK RADNIK { get; set; }
        public virtual ICollection<RADPROJ> RADPROJs { get; set; }
    }
}
