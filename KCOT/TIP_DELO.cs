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
    
    public partial class TIP_DELO
    {
        public TIP_DELO()
        {
            this.UMETNICKO_DELO = new HashSet<UMETNICKO_DELO>();
        }
    
        public string ID_TIP_DELO { get; set; }
        public string NAZIV { get; set; }
    
        public virtual ICollection<UMETNICKO_DELO> UMETNICKO_DELO { get; set; }
    }
}
