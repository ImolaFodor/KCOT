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
    
    public partial class SEDISTE
    {
        public SEDISTE()
        {
            this.REZERVISANO_SEDISTE = new HashSet<REZERVISANO_SEDISTE>();
        }
    
        public string ID_SEDISTE { get; set; }
        public decimal RED { get; set; }
        public decimal BROJ { get; set; }
        public string SALA_ID_SALA { get; set; }
    
        public virtual ICollection<REZERVISANO_SEDISTE> REZERVISANO_SEDISTE { get; set; }
        public virtual SALA SALA { get; set; }
    }
}