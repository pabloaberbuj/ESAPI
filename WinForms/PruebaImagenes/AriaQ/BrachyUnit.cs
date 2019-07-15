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
    
    public partial class BrachyUnit
    {
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2214:DoNotCallOverridableMethodsInConstructors")]
        public BrachyUnit()
        {
            this.Channels = new HashSet<Channel>();
        }
    
        public long ResourceSer { get; set; }
        public Nullable<double> MaxDwellTimePerChannel { get; set; }
        public Nullable<double> MaxDwellTimePerPos { get; set; }
        public Nullable<double> MaxDwellTimePerTreatment { get; set; }
        public Nullable<double> TimeResolution { get; set; }
        public string SourceMovementType { get; set; }
        public Nullable<double> MinStepSize { get; set; }
        public Nullable<double> MaxStepSize { get; set; }
        public Nullable<int> NumOfDwellPosPerChannel { get; set; }
        public Nullable<double> StepSizeResolution { get; set; }
        public Nullable<double> PosToSourceDist { get; set; }
        public string DoseRateMode { get; set; }
        public string ExportDirectory { get; set; }
        public string ExportPostProcessor { get; set; }
    
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<Channel> Channels { get; set; }
        public virtual RadiationDevice RadiationDevice { get; set; }
    }
}
