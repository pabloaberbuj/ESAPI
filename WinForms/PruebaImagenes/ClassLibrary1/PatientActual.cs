//------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated from a template.
//
//     Manual changes to this file may cause unexpected behavior in your application.
//     Manual changes to this file will be overwritten if the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------

namespace ClassLibrary1
{
    using System;
    using System.Collections.Generic;
    
    public partial class PatientActual
    {
        public long PatientSer { get; set; }
        public string PatientIdUpper { get; set; }
        public string PatientId2Upper { get; set; }
        public string FirstNameUpper { get; set; }
        public string LastNameUpper { get; set; }
        public string SSN { get; set; }
        public string PatientType { get; set; }
        public Nullable<long> HospitalSer { get; set; }
        public int InPatientFlag { get; set; }
        public string PatientLocation { get; set; }
        public Nullable<System.DateTime> ArrivalTime { get; set; }
        public string PatientStatus { get; set; }
        public Nullable<int> SelectionStatus { get; set; }
        public Nullable<System.DateTime> LastImagePIDate { get; set; }
        public Nullable<System.DateTime> LastImageSIDate { get; set; }
        public Nullable<System.DateTime> LastOtherImageDate { get; set; }
        public int DirectiveAskedFlag { get; set; }
    
        public virtual Patient Patient { get; set; }
    }
}
