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
    
    public partial class PerformedProcedure
    {
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2214:DoNotCallOverridableMethodsInConstructors")]
        public PerformedProcedure()
        {
            this.ScheduledPerformedProcedures = new HashSet<ScheduledPerformedProcedure>();
            this.ObjectPointers = new HashSet<ObjectPointer>();
        }
    
        public long PerformedProcedureSer { get; set; }
        public string PerformedProcedureId { get; set; }
        public string PerformedProcedureUID { get; set; }
        public Nullable<System.DateTime> StartDateTime { get; set; }
        public Nullable<System.DateTime> EndDateTime { get; set; }
        public string Description { get; set; }
        public string Modality { get; set; }
        public string Operator1 { get; set; }
        public string Operator2 { get; set; }
        public string Operator3 { get; set; }
        public Nullable<long> DICOMCodeValueSer { get; set; }
        public string DiscReasonCodeMeaning { get; set; }
        public string Status { get; set; }
        public string ProtocolName { get; set; }
        public long ActivityInstanceSer { get; set; }
        public int ActivityInstanceRevCount { get; set; }
        public Nullable<double> Progress { get; set; }
        public string TransactionUID { get; set; }
        public string ObjectStatus { get; set; }
        public string HstryUserName { get; set; }
        public byte[] HstryTimeStamp { get; set; }
        public System.DateTime HstryDateTime { get; set; }
        public string HstryTaskName { get; set; }
    
        public virtual ActivityInstance ActivityInstance { get; set; }
        public virtual DICOMCodeValue DICOMCodeValue { get; set; }
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<ScheduledPerformedProcedure> ScheduledPerformedProcedures { get; set; }
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<ObjectPointer> ObjectPointers { get; set; }
    }
}
