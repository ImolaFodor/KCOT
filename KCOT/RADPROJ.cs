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
    
    public partial class RADPROJ
    {
        public decimal SPR { get; set; }
        public decimal MBR { get; set; }
        public decimal BRC { get; set; }
    
        public virtual PROJEKAT PROJEKAT { get; set; }
        public virtual RADNIK RADNIK { get; set; }
    }
}
