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
    
    public partial class DOGADJAJ
    {
        public string ID_DOG { get; set; }
        public string NAZIV { get; set; }
        public decimal GODINA { get; set; }
        public string KONTAKT_IME { get; set; }
        public string KONTAKT_PRZ { get; set; }
        public string KONTAKT_BROJ { get; set; }
        public string U_GALERIJI_ID_DOG { get; set; }
        public string U_SALI_ID_DOG { get; set; }
    
        public virtual U_GALERIJI U_GALERIJI { get; set; }
        public virtual U_SALI U_SALI { get; set; }
    }
}