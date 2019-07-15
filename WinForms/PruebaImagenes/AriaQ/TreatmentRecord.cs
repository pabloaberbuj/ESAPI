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
    
    public partial class TreatmentRecord
    {
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2214:DoNotCallOverridableMethodsInConstructors")]
        public TreatmentRecord()
        {
            this.RadiationHstries = new HashSet<RadiationHstry>();
        }
    
        public long TreatmentRecordSer { get; set; }
        public long PatientSer { get; set; }
        public long SeriesSer { get; set; }
        public Nullable<long> RTPlanSer { get; set; }
        public long PlanSOPClassSer { get; set; }
        public long TreatmentRecordSOPClassSer { get; set; }
        public string PlanUID { get; set; }
        public string TreatmentRecordUID { get; set; }
        public string FileName { get; set; }
        public Nullable<long> ActualMachineSer { get; set; }
        public string ActualMachineAuthorization { get; set; }
        public byte MachOverrideFlag { get; set; }
        public string HstryUserName { get; set; }
        public System.DateTime HstryDateTime { get; set; }
        public byte[] HstryTimeStamp { get; set; }
        public string HstryTaskName { get; set; }
        public string StructureSetUID { get; set; }
        public Nullable<System.DateTime> TreatmentRecordDateTime { get; set; }
        public Nullable<int> NoOfFractions { get; set; }
        public string CharacterSet { get; set; }
    
        public virtual Patient Patient { get; set; }
        public virtual RadiationDevice RadiationDevice { get; set; }
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<RadiationHstry> RadiationHstries { get; set; }
        public virtual RTPlan RTPlan { get; set; }
        public virtual Series Series { get; set; }
        public virtual SOPClass SOPClass { get; set; }
        public virtual SOPClass SOPClass1 { get; set; }
    }
}
