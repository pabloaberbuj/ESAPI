namespace AriaEntities
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    [Table("Image")]
    public partial class Image
    {
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2214:DoNotCallOverridableMethodsInConstructors")]
        public Image()
        {
            Image1 = new HashSet<Image>();
            PlanSetups = new HashSet<PlanSetup>();
        }

        [Key]
        [DatabaseGenerated(DatabaseGeneratedOption.None)]
        public long ImageSer { get; set; }

        public long SeriesSer { get; set; }

        [Required]
        [StringLength(16)]
        public string ImageId { get; set; }

        [StringLength(64)]
        public string ImageName { get; set; }

        public DateTime CreationDate { get; set; }

        [StringLength(32)]
        public string CreationUserName { get; set; }

        public DateTime StatusDate { get; set; }

        [Required]
        [StringLength(32)]
        public string StatusUserName { get; set; }

        [StringLength(30)]
        public string ImageType { get; set; }

        [Required]
        [StringLength(64)]
        public string Status { get; set; }

        public int? VolumetricPixelOffset { get; set; }

        public int ProcessedFlag { get; set; }

        public long? DefaultProcessingSer { get; set; }

        public long? OtherProcessingSer { get; set; }

        public long? GeometricParentSer { get; set; }

        public long? PatientSer { get; set; }

        public int ImageSizeX { get; set; }

        public int ImageSizeY { get; set; }

        public int ImageSizeZ { get; set; }

        public double ImageResX { get; set; }

        public double ImageResY { get; set; }

        public double ImageResZ { get; set; }

        public int InverseSliceOrder { get; set; }

        public double? FocusX { get; set; }

        public double? FocusY { get; set; }

        public double? FocusZ { get; set; }

        [StringLength(254)]
        public string Comment { get; set; }

        [StringLength(16)]
        public string PatientOrientation { get; set; }

        [StringLength(64)]
        public string UsageType { get; set; }

        public int? ActWindow { get; set; }

        public int? ActLevel { get; set; }

        public double? VolumetricPixelSlope { get; set; }

        [StringLength(32)]
        public string PixelUnit { get; set; }

        public int ImageNotesLen { get; set; }

        public string ImageNotes { get; set; }

        [MaxLength(96)]
        public byte[] Transformation { get; set; }

        [MaxLength(96)]
        public byte[] VolumeTransformation { get; set; }

        [MaxLength(24)]
        public byte[] UserOrigin { get; set; }

        [StringLength(254)]
        public string UserOriginComment { get; set; }

        [MaxLength(96)]
        public byte[] DisplayTransformation { get; set; }

        public string ProcessingDefinition { get; set; }

        public int ProcessingDefinitionLen { get; set; }

        public int? FractionNumber { get; set; }

        public int? RefDicomSeqNumber { get; set; }

        public long? Image4DSer { get; set; }

        public int Flags4D { get; set; }

        [Required]
        [StringLength(32)]
        public string HstryUserName { get; set; }

        [Column(TypeName = "timestamp")]
        [DatabaseGenerated(DatabaseGeneratedOption.Computed)]
        [MaxLength(8)]
        public byte[] HstryTimeStamp { get; set; }

        public DateTime HstryDateTime { get; set; }

        [StringLength(32)]
        public string HstryTaskName { get; set; }

        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<Image> Image1 { get; set; }

        public virtual Image Image2 { get; set; }

        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<PlanSetup> PlanSetups { get; set; }

        public virtual Patient Patient { get; set; }
    }
}
