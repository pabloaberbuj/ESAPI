//------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated from a template.
//
//     Manual changes to this file may cause unexpected behavior in your application.
//     Manual changes to this file will be overwritten if the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------

namespace AriaQ
{
    using System;
    using System.Collections.Generic;
    
    public partial class AccountBillingCodeMH
    {
        public long AccountBillingCodeSer { get; set; }
        public int AccountBillingCodeRevCount { get; set; }
        public long PatientSer { get; set; }
        public string AccountBillingCodeId { get; set; }
        public Nullable<long> HospitalSer { get; set; }
        public Nullable<long> DepartmentSer { get; set; }
        public string BillAccountName { get; set; }
        public Nullable<System.DateTime> EffDate { get; set; }
        public Nullable<System.DateTime> ExpiryDate { get; set; }
        public string ObjectStatus { get; set; }
        public string ValidEntryInd { get; set; }
        public Nullable<long> AttendingOncologistSer { get; set; }
        public Nullable<long> ReferringDoctorSer { get; set; }
        public Nullable<int> InPatientFlag { get; set; }
        public string IntfExternalField1 { get; set; }
        public string IntfExternalField2 { get; set; }
        public string IntfExternalField3 { get; set; }
        public string IntfExternalField4 { get; set; }
        public string IntfExternalField5 { get; set; }
        public string HstryUserName { get; set; }
        public byte[] HstryTimeStamp { get; set; }
        public System.DateTime HstryDateTime { get; set; }
        public string HstryTaskName { get; set; }
    
        public virtual AccountBillingCode AccountBillingCode { get; set; }
    }
}
