//------------------------------------------------------------------------------
// <auto-generated>
//    This code was generated from a template.
//
//    Manual changes to this file may cause unexpected behavior in your application.
//    Manual changes to this file will be overwritten if the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------

namespace DatabaseProject
{
    using System;
    using System.Collections.Generic;
    
    public partial class SPECIALTY
    {
        public SPECIALTY()
        {
            this.DOCTORs = new HashSet<DOCTOR>();
        }
    
        public string SPEC_NAME { get; set; }
        public decimal SPEC_ID { get; set; }
    
        public virtual ICollection<DOCTOR> DOCTORs { get; set; }
    }
}
