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
    
    public partial class RadiationDevice
    {
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2214:DoNotCallOverridableMethodsInConstructors")]
        public RadiationDevice()
        {
            this.Radiations = new HashSet<Radiation>();
            this.RadioactiveSources = new HashSet<RadioactiveSource>();
            this.Slots = new HashSet<Slot>();
            this.TreatmentRecords = new HashSet<TreatmentRecord>();
        }
    
        public long ResourceSer { get; set; }
        public string RadiationDeviceType { get; set; }
        public string Features { get; set; }
        public int CompletelyModelled { get; set; }
    
        public virtual BrachyUnit BrachyUnit { get; set; }
        public virtual ExternalBeam ExternalBeam { get; set; }
        public virtual Machine Machine { get; set; }
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<Radiation> Radiations { get; set; }
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<RadioactiveSource> RadioactiveSources { get; set; }
        public virtual Simulator Simulator { get; set; }
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<Slot> Slots { get; set; }
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<TreatmentRecord> TreatmentRecords { get; set; }
    }
}
