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
    
    public partial class SKOLA
    {
        public SKOLA()
        {
            this.REZs = new HashSet<REZ>();
        }
    
        public string ID_SKOLA { get; set; }
        public string NAZIV { get; set; }
        public string KONTAKT_IME { get; set; }
        public string KONTAKT_BROJ { get; set; }
    
        public virtual ICollection<REZ> REZs { get; set; }
    }
}
