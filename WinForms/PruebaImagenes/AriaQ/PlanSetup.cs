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
    
    public partial class PlanSetup
    {
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2214:DoNotCallOverridableMethodsInConstructors")]
        public PlanSetup()
        {
            this.BrachySolidApplicators = new HashSet<BrachySolidApplicator>();
            this.DoseMatrices = new HashSet<DoseMatrix>();
            this.DVHs = new HashSet<DVH>();
            this.DVHEstimationTrainingSetPlanSetups = new HashSet<DVHEstimationTrainingSetPlanSetup>();
            this.EstimatedDVHs = new HashSet<EstimatedDVH>();
            this.PlanSetupStructureModelStructures = new HashSet<PlanSetupStructureModelStructure>();
            this.PlanSumPlanSetups = new HashSet<PlanSumPlanSetup>();
            this.PlanVariations = new HashSet<PlanVariation>();
            this.Radiations = new HashSet<Radiation>();
            this.RTPlans = new HashSet<RTPlan>();
            this.Series = new HashSet<Series>();
            this.SliceRTs = new HashSet<SliceRT>();
            this.Trackings = new HashSet<Tracking>();
            this.VolOptConstraints = new HashSet<VolOptConstraint>();
        }
    
        public long PlanSetupSer { get; set; }
        public Nullable<long> PatientSupportDeviceSer { get; set; }
        public Nullable<long> PrescriptionSer { get; set; }
        public long CourseSer { get; set; }
        public string PlanSetupId { get; set; }
        public string PlanSetupName { get; set; }
        public System.DateTime CreationDate { get; set; }
        public string CreationUserName { get; set; }
        public string Status { get; set; }
        public string StatusUserName { get; set; }
        public System.DateTime StatusDate { get; set; }
        public Nullable<double> PlanNormFactor { get; set; }
        public string PlanNormMethod { get; set; }
        public string Comment { get; set; }
        public string TreatmentTechnique { get; set; }
        public string ApplicationSetupType { get; set; }
        public Nullable<int> ApplicationSetupNumber { get; set; }
        public string TreatmentType { get; set; }
        public string CalcModelOptions { get; set; }
        public int CalcModelOptionsLen { get; set; }
        public string TreatmentOrientation { get; set; }
        public Nullable<double> PrescribedPercentage { get; set; }
        public Nullable<long> PrimaryPTVSer { get; set; }
        public int IrregFlag { get; set; }
        public string FieldRules { get; set; }
        public int FieldRulesLen { get; set; }
        public Nullable<double> SkinFlashMargin { get; set; }
        public string ProtocolPhaseId { get; set; }
        public int MultiFieldOptFlag { get; set; }
        public Nullable<long> CopyOfSer { get; set; }
        public Nullable<long> StructureSetSer { get; set; }
        public Nullable<long> EquipmentSer { get; set; }
        public string HstryUserName { get; set; }
        public System.DateTime HstryDateTime { get; set; }
        public byte[] HstryTimeStamp { get; set; }
        public string HstryTaskName { get; set; }
        public byte[] RaySearchPrivateData { get; set; }
        public int RaySearchPrivateDataLen { get; set; }
        public string Intent { get; set; }
        public byte[] ViewingPlane { get; set; }
        public byte[] ViewingPlaneULCorner { get; set; }
        public byte[] ViewingPlaneLRCorner { get; set; }
        public Nullable<double> BrachyPdrPulseInterval { get; set; }
        public Nullable<int> BrachyPdrNoOfPulses { get; set; }
        public string TransactionId { get; set; }
        public Nullable<long> ImageSer { get; set; }
    
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<BrachySolidApplicator> BrachySolidApplicators { get; set; }
        public virtual Course Course { get; set; }
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<DoseMatrix> DoseMatrices { get; set; }
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<DVH> DVHs { get; set; }
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<DVHEstimationTrainingSetPlanSetup> DVHEstimationTrainingSetPlanSetups { get; set; }
        public virtual Equipment Equipment { get; set; }
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<EstimatedDVH> EstimatedDVHs { get; set; }
        public virtual Image Image { get; set; }
        public virtual PatientSupportDevice PatientSupportDevice { get; set; }
        public virtual PatientVolume PatientVolume { get; set; }
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<PlanSetupStructureModelStructure> PlanSetupStructureModelStructures { get; set; }
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<PlanSumPlanSetup> PlanSumPlanSetups { get; set; }
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<PlanVariation> PlanVariations { get; set; }
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<Radiation> Radiations { get; set; }
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<RTPlan> RTPlans { get; set; }
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<Series> Series { get; set; }
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<SliceRT> SliceRTs { get; set; }
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<Tracking> Trackings { get; set; }
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<VolOptConstraint> VolOptConstraints { get; set; }
        public virtual Prescription Prescription { get; set; }
        public virtual StructureSet StructureSet { get; set; }
    }
}
