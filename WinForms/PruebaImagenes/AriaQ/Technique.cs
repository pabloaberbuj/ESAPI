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
    
    public partial class Technique
    {
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2214:DoNotCallOverridableMethodsInConstructors")]
        public Technique()
        {
            this.ConfiguredEMTs = new HashSet<ConfiguredEMT>();
            this.DemExternalBeams = new HashSet<DemExternalBeam>();
            this.ExternalFieldCommons = new HashSet<ExternalFieldCommon>();
            this.OperatingLimits = new HashSet<OperatingLimit>();
        }
    
        public long TechniqueSer { get; set; }
        public long ResourceSer { get; set; }
        public string TechniqueId { get; set; }
        public string ObjectStatus { get; set; }
        public Nullable<int> DefaultFlag { get; set; }
        public string DisplayCode { get; set; }
        public Nullable<int> InternalCode { get; set; }
        public Nullable<int> LevelCode { get; set; }
        public string Comment { get; set; }
        public string HstryUserName { get; set; }
        public byte[] HstryTimeStamp { get; set; }
        public System.DateTime HstryDateTime { get; set; }
        public string HstryTaskName { get; set; }
    
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<ConfiguredEMT> ConfiguredEMTs { get; set; }
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<DemExternalBeam> DemExternalBeams { get; set; }
        public virtual ExternalBeam ExternalBeam { get; set; }
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<ExternalFieldCommon> ExternalFieldCommons { get; set; }
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<OperatingLimit> OperatingLimits { get; set; }
    }
}
