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
    
    public partial class BrachyApplicator
    {
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2214:DoNotCallOverridableMethodsInConstructors")]
        public BrachyApplicator()
        {
            this.BrachyFields = new HashSet<BrachyField>();
        }
    
        public long BrachyApplicatorSer { get; set; }
        public string BrachyApplicatorId { get; set; }
        public string BrachyApplicatorName { get; set; }
        public string BrachyApplicatorTypeInfo { get; set; }
        public Nullable<double> DefaultLength { get; set; }
        public string ManufacturerName { get; set; }
        public Nullable<int> NoOfShapePoints { get; set; }
        public byte[] Shape { get; set; }
        public Nullable<int> NoOfSourceGeom { get; set; }
        public byte[] SourceGeometry { get; set; }
        public string WallMaterialId { get; set; }
        public Nullable<double> WallNominalTransmission { get; set; }
        public string Comment { get; set; }
        public Nullable<double> StepSize { get; set; }
        public Nullable<double> FirstSourcePosition { get; set; }
        public Nullable<double> LastSourcePosition { get; set; }
        public int SeparateSources { get; set; }
        public Nullable<int> DefaultChannelNumber { get; set; }
        public string HstryUserName { get; set; }
        public System.DateTime HstryDateTime { get; set; }
        public byte[] HstryTimeStamp { get; set; }
        public string HstryTaskName { get; set; }
    
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<BrachyField> BrachyFields { get; set; }
    }
}
