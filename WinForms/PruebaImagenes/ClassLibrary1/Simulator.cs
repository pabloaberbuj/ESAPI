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
    
    public partial class Simulator
    {
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2214:DoNotCallOverridableMethodsInConstructors")]
        public Simulator()
        {
            this.CTSimulators = new HashSet<CTSimulator>();
            this.SimulationImagers = new HashSet<SimulationImager>();
        }
    
        public long ResourceSer { get; set; }
        public string CollMode { get; set; }
        public Nullable<double> BeamTime { get; set; }
        public string XRayUnit { get; set; }
    
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<CTSimulator> CTSimulators { get; set; }
        public virtual RadiationDevice RadiationDevice { get; set; }
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<SimulationImager> SimulationImagers { get; set; }
    }
}
