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
    
    public partial class VolumeCode
    {
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2214:DoNotCallOverridableMethodsInConstructors")]
        public VolumeCode()
        {
            this.PatientVolumes = new HashSet<PatientVolume>();
        }
    
        public long VolumeCodeSer { get; set; }
        public string LanguageId { get; set; }
        public string VolumeCode1 { get; set; }
        public string VolumeCodeTable { get; set; }
        public Nullable<long> MaterialSer { get; set; }
        public string Description { get; set; }
        public Nullable<double> SearchCTLow { get; set; }
        public Nullable<double> SearchCTHigh { get; set; }
        public Nullable<double> SegmentLimit { get; set; }
        public Nullable<double> SurfaceTension { get; set; }
        public Nullable<double> RelativeSize { get; set; }
        public Nullable<int> IsletSize { get; set; }
        public string DetectionAlgorithm { get; set; }
        public string ObjectStatus { get; set; }
        public Nullable<double> EUDAlpha { get; set; }
        public Nullable<double> TCPAlpha { get; set; }
        public Nullable<double> TCPBeta { get; set; }
        public Nullable<double> TCPGamma { get; set; }
        public Nullable<double> DefaultRBEProton { get; set; }
        public Nullable<double> DefaultRBEBrachy { get; set; }
        public string HstryUserName { get; set; }
        public System.DateTime HstryDateTime { get; set; }
        public byte[] HstryTimeStamp { get; set; }
        public string HstryTaskName { get; set; }
    
        public virtual LanguageLookup LanguageLookup { get; set; }
        public virtual Material Material { get; set; }
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<PatientVolume> PatientVolumes { get; set; }
    }
}