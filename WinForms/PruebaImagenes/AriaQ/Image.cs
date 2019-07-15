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
    
    public partial class Image
    {
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2214:DoNotCallOverridableMethodsInConstructors")]
        public Image()
        {
            this.ExternalFields = new HashSet<ExternalField>();
            this.GraphicAnnotations = new HashSet<GraphicAnnotation>();
            this.Image1 = new HashSet<Image>();
            this.ImageMatchResults = new HashSet<ImageMatchResult>();
            this.ImageSlice = new HashSet<ImageSlouse>();
            this.PlanSetups = new HashSet<PlanSetup>();
            this.PlanSums = new HashSet<PlanSum>();
            this.Radiations = new HashSet<Radiation>();
            this.RefPointLocations = new HashSet<RefPointLocation>();
            this.SliceRTs = new HashSet<SliceRT>();
            this.SpatialRegistrationImages = new HashSet<SpatialRegistrationImage>();
            this.StructureSets = new HashSet<StructureSet>();
            this.TrackingImages = new HashSet<TrackingImage>();
        }
    
        public long ImageSer { get; set; }
        public long SeriesSer { get; set; }
        public string ImageId { get; set; }
        public string ImageName { get; set; }
        public System.DateTime CreationDate { get; set; }
        public string CreationUserName { get; set; }
        public System.DateTime StatusDate { get; set; }
        public string StatusUserName { get; set; }
        public string ImageType { get; set; }
        public string Status { get; set; }
        public Nullable<int> VolumetricPixelOffset { get; set; }
        public int ProcessedFlag { get; set; }
        public Nullable<long> DefaultProcessingSer { get; set; }
        public Nullable<long> OtherProcessingSer { get; set; }
        public Nullable<long> GeometricParentSer { get; set; }
        public Nullable<long> PatientSer { get; set; }
        public int ImageSizeX { get; set; }
        public int ImageSizeY { get; set; }
        public int ImageSizeZ { get; set; }
        public double ImageResX { get; set; }
        public double ImageResY { get; set; }
        public double ImageResZ { get; set; }
        public int InverseSliceOrder { get; set; }
        public Nullable<double> FocusX { get; set; }
        public Nullable<double> FocusY { get; set; }
        public Nullable<double> FocusZ { get; set; }
        public string Comment { get; set; }
        public string PatientOrientation { get; set; }
        public string UsageType { get; set; }
        public Nullable<int> ActWindow { get; set; }
        public Nullable<int> ActLevel { get; set; }
        public Nullable<double> VolumetricPixelSlope { get; set; }
        public string PixelUnit { get; set; }
        public int ImageNotesLen { get; set; }
        public string ImageNotes { get; set; }
        public byte[] Transformation { get; set; }
        public byte[] VolumeTransformation { get; set; }
        public byte[] UserOrigin { get; set; }
        public string UserOriginComment { get; set; }
        public byte[] DisplayTransformation { get; set; }
        public string ProcessingDefinition { get; set; }
        public int ProcessingDefinitionLen { get; set; }
        public Nullable<int> FractionNumber { get; set; }
        public Nullable<int> RefDicomSeqNumber { get; set; }
        public Nullable<long> Image4DSer { get; set; }
        public int Flags4D { get; set; }
        public string HstryUserName { get; set; }
        public byte[] HstryTimeStamp { get; set; }
        public System.DateTime HstryDateTime { get; set; }
        public string HstryTaskName { get; set; }
    
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<ExternalField> ExternalFields { get; set; }
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<GraphicAnnotation> GraphicAnnotations { get; set; }
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<Image> Image1 { get; set; }
        public virtual Image Image2 { get; set; }
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<ImageMatchResult> ImageMatchResults { get; set; }
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<ImageSlouse> ImageSlice { get; set; }
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<PlanSetup> PlanSetups { get; set; }
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<PlanSum> PlanSums { get; set; }
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<Radiation> Radiations { get; set; }
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<RefPointLocation> RefPointLocations { get; set; }
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<SliceRT> SliceRTs { get; set; }
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<SpatialRegistrationImage> SpatialRegistrationImages { get; set; }
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<StructureSet> StructureSets { get; set; }
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<TrackingImage> TrackingImages { get; set; }
        public virtual Image4D Image4D { get; set; }
        public virtual Patient Patient { get; set; }
        public virtual Processing Processing { get; set; }
        public virtual Processing Processing1 { get; set; }
        public virtual Series Series { get; set; }
    }
}
