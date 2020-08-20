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
    
    public partial class Prescription
    {
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2214:DoNotCallOverridableMethodsInConstructors")]
        public Prescription()
        {
            this.PlanSetups = new HashSet<PlanSetup>();
            this.PrescriptionAnatomies = new HashSet<PrescriptionAnatomy>();
            this.PrescriptionProperties = new HashSet<PrescriptionProperty>();
            this.Prescription1 = new HashSet<Prescription>();
        }
    
        public long PrescriptionSer { get; set; }
        public string PrescriptionName { get; set; }
        public long TreatmentPhaseSer { get; set; }
        public Nullable<long> PredecessorPrescriptionSer { get; set; }
        public string PhaseType { get; set; }
        public string Gating { get; set; }
        public Nullable<int> SimulationNeeded { get; set; }
        public string BolusFrequency { get; set; }
        public string BolusThickness { get; set; }
        public string Notes { get; set; }
        public string Status { get; set; }
        public Nullable<int> NumberOfFractions { get; set; }
        public string Technique { get; set; }
        public string Site { get; set; }
        public Nullable<long> PrescriptionTemplateSer { get; set; }
        public Nullable<System.DateTime> CreationDate { get; set; }
        public string CreationUserName { get; set; }
        public string HstryUserName { get; set; }
        public System.DateTime HstryDateTime { get; set; }
        public byte[] HstryTimeStamp { get; set; }
        public string HstryTaskName { get; set; }
    
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<PlanSetup> PlanSetups { get; set; }
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<PrescriptionAnatomy> PrescriptionAnatomies { get; set; }
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<PrescriptionProperty> PrescriptionProperties { get; set; }
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<Prescription> Prescription1 { get; set; }
        public virtual Prescription Prescription2 { get; set; }
        public virtual PrescriptionTemplate PrescriptionTemplate { get; set; }
        public virtual TreatmentPhase TreatmentPhase { get; set; }
    }
}