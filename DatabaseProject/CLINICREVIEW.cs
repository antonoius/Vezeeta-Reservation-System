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
    
    public partial class CLINICREVIEW
    {
        public string REV_CONTENT { get; set; }
        public System.DateTime REV_DATE { get; set; }
        public decimal PATIENT_ID { get; set; }
        public decimal CLNC_ID { get; set; }
    
        public virtual CLINIC CLINIC { get; set; }
        public virtual PATIENT PATIENT { get; set; }
    }
}