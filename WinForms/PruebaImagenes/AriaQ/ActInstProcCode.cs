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
    
    public partial class ActInstProcCode
    {
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2214:DoNotCallOverridableMethodsInConstructors")]
        public ActInstProcCode()
        {
            this.ActInstProcCodeMHs = new HashSet<ActInstProcCodeMH>();
            this.BillSysChrgWrks = new HashSet<BillSysChrgWrk>();
            this.BillSysSentCharges = new HashSet<BillSysSentCharge>();
            this.Credits = new HashSet<Credit>();
            this.WeeklyChargeLinks = new HashSet<WeeklyChargeLink>();
        }
    
        public long ActInstProcCodeSer { get; set; }
        public int ActInstProcCodeRevCount { get; set; }
        public long ActivityInstanceSer { get; set; }
        public int ActivityInstanceRevCount { get; set; }
        public long ProcedureCodeSer { get; set; }
        public int ProcedureCodeRevCount { get; set; }
        public Nullable<long> AccountBillingCodeSer { get; set; }
        public Nullable<int> AccountBillingCodeRevCount { get; set; }
        public Nullable<long> ModifierSer { get; set; }
        public Nullable<int> ActivityCodeMdRevCount { get; set; }
        public string Modifier { get; set; }
        public Nullable<long> Modifier2Ser { get; set; }
        public Nullable<int> ActivityCodeMd2RevCount { get; set; }
        public string Modifier2 { get; set; }
        public Nullable<long> Modifier3Ser { get; set; }
        public Nullable<int> ActivityCodeMd3RevCount { get; set; }
        public string Modifier3 { get; set; }
        public Nullable<long> Modifier4Ser { get; set; }
        public Nullable<int> ActivityCodeMd4RevCount { get; set; }
        public string Modifier4 { get; set; }
        public Nullable<long> Modifier5Ser { get; set; }
        public Nullable<int> ActivityCodeMd5RevCount { get; set; }
        public string Modifier5 { get; set; }
        public Nullable<long> Modifier6Ser { get; set; }
        public Nullable<int> ActivityCodeMd6RevCount { get; set; }
        public string Modifier6 { get; set; }
        public Nullable<long> Modifier7Ser { get; set; }
        public Nullable<int> ActivityCodeMd7RevCount { get; set; }
        public string Modifier7 { get; set; }
        public string ObjectStatus { get; set; }
        public string ChargeWaivedBy { get; set; }
        public Nullable<System.DateTime> FromDateOfService { get; set; }
        public Nullable<System.DateTime> ToDateOfService { get; set; }
        public string CompletedBy { get; set; }
        public Nullable<System.DateTime> CompletedDateTime { get; set; }
        public string MrkdCmpltdBy { get; set; }
        public Nullable<System.DateTime> MrkdCmpltdDateTime { get; set; }
        public string ReviewedBy { get; set; }
        public string ExportedBy { get; set; }
        public Nullable<System.DateTime> ExportedDateTime { get; set; }
        public string ReviewResetBy { get; set; }
        public string HstryUserName { get; set; }
        public byte[] HstryTimeStamp { get; set; }
        public System.DateTime HstryDateTime { get; set; }
        public string HstryTaskName { get; set; }
        public Nullable<long> DepartmentSer { get; set; }
        public Nullable<int> WeeklyChrgFlag { get; set; }
        public string Comment { get; set; }
    
        public virtual AccountBillingCode AccountBillingCode { get; set; }
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<ActInstProcCodeMH> ActInstProcCodeMHs { get; set; }
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<BillSysChrgWrk> BillSysChrgWrks { get; set; }
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<BillSysSentCharge> BillSysSentCharges { get; set; }
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<Credit> Credits { get; set; }
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<WeeklyChargeLink> WeeklyChargeLinks { get; set; }
        public virtual ActivityCodeMd ActivityCodeMd { get; set; }
        public virtual ActivityCodeMd ActivityCodeMd1 { get; set; }
        public virtual ActivityCodeMd ActivityCodeMd2 { get; set; }
        public virtual ActivityCodeMd ActivityCodeMd3 { get; set; }
        public virtual ActivityCodeMd ActivityCodeMd4 { get; set; }
        public virtual ActivityCodeMd ActivityCodeMd5 { get; set; }
        public virtual ActivityCodeMd ActivityCodeMd6 { get; set; }
        public virtual ActivityInstance ActivityInstance { get; set; }
        public virtual Department Department { get; set; }
        public virtual ProcedureCode ProcedureCode { get; set; }
    }
}
