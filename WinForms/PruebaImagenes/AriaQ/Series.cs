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
    
    public partial class Series
    {
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2214:DoNotCallOverridableMethodsInConstructors")]
        public Series()
        {
            this.DoseMatrices = new HashSet<DoseMatrix>();
            this.Images = new HashSet<Image>();
            this.RTPlans = new HashSet<RTPlan>();
            this.SessionProcedures = new HashSet<SessionProcedure>();
            this.Slice = new HashSet<Slouse>();
            this.SpatialRegistrationIODs = new HashSet<SpatialRegistrationIOD>();
            this.StructureSets = new HashSet<StructureSet>();
            this.Trackings = new HashSet<Tracking>();
            this.TreatmentRecords = new HashSet<TreatmentRecord>();
        }
    
        public long SeriesSer { get; set; }
        public Nullable<long> StudySer { get; set; }
        public string SeriesId { get; set; }
        public string SeriesName { get; set; }
        public Nullable<int> SeriesNumber { get; set; }
        public string SeriesUID { get; set; }
        public string SeriesType { get; set; }
        public System.DateTime CreationDate { get; set; }
        public string CreationUserName { get; set; }
        public string BodyPartExamined { get; set; }
        public string PatientOrientation { get; set; }
        public string SeriesModality { get; set; }
        public string AcquisitionType { get; set; }
        public string Comment { get; set; }
        public string ReconstructionType4D { get; set; }
        public Nullable<double> ReconstructionPhase4D { get; set; }
        public string PositionReferenceIndicator { get; set; }
        public string FrameOfReferenceUID { get; set; }
        public int ResampledSeriesFlag { get; set; }
        public string HstryUserName { get; set; }
        public byte[] HstryTimeStamp { get; set; }
        public System.DateTime HstryDateTime { get; set; }
        public string HstryTaskName { get; set; }
        public Nullable<long> ResourceSer { get; set; }
        public Nullable<long> RelatedCourseSer { get; set; }
        public Nullable<long> RelatedPlanSetupSer { get; set; }
        public Nullable<long> RelatedRadiationSer { get; set; }
        public Nullable<long> RelatedDiagnosisSer { get; set; }
    
        public virtual Course Course { get; set; }
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<DoseMatrix> DoseMatrices { get; set; }
        public virtual ExternalField ExternalField { get; set; }
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<Image> Images { get; set; }
        public virtual Machine Machine { get; set; }
        public virtual PlanSetup PlanSetup { get; set; }
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<RTPlan> RTPlans { get; set; }
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<SessionProcedure> SessionProcedures { get; set; }
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<Slouse> Slice { get; set; }
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<SpatialRegistrationIOD> SpatialRegistrationIODs { get; set; }
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<StructureSet> StructureSets { get; set; }
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<Tracking> Trackings { get; set; }
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<TreatmentRecord> TreatmentRecords { get; set; }
        public virtual Study Study { get; set; }
    }
}
