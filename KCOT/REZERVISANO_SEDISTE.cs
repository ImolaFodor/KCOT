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
    
    public partial class REZERVISANO_SEDISTE
    {
        public string ID_REZ_SED { get; set; }
        public string SEDISTE_ID_SEDISTE { get; set; }
        public string SEDISTE_ID_SALA { get; set; }
        public string REZ_IDREZ { get; set; }
        public string REZ_ID_DOG { get; set; }
    
        public virtual REZ REZ { get; set; }
        public virtual SEDISTE SEDISTE { get; set; }
    }
}
