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
    
    public partial class UMETNICKO_DELO
    {
        public UMETNICKO_DELO()
        {
            this.U_GALERIJI = new HashSet<U_GALERIJI>();
            this.U_GALERIJI1 = new HashSet<U_GALERIJI>();
        }
    
        public string ID_UM_DELO { get; set; }
        public string NAZIV { get; set; }
        public string UMETNIK_IME { get; set; }
        public string UMETNIK_PRZ { get; set; }
        public string TIP_DELO_ID_TIP_DELO { get; set; }
    
        public virtual TIP_DELO TIP_DELO { get; set; }
        public virtual ICollection<U_GALERIJI> U_GALERIJI { get; set; }
        public virtual ICollection<U_GALERIJI> U_GALERIJI1 { get; set; }
    }
}
