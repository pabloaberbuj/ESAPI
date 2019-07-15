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
    
    public partial class ContrastBolu
    {
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2214:DoNotCallOverridableMethodsInConstructors")]
        public ContrastBolu()
        {
            this.ContrastBolusCodes = new HashSet<ContrastBolusCode>();
            this.ContrastFlows = new HashSet<ContrastFlow>();
        }
    
        public long ContrastBolusSer { get; set; }
        public string Agent { get; set; }
        public string Route { get; set; }
        public Nullable<double> Volume { get; set; }
        public Nullable<System.DateTime> StartTime { get; set; }
        public Nullable<System.DateTime> StopTime { get; set; }
        public Nullable<double> TotalDose { get; set; }
        public string Ingredient { get; set; }
        public Nullable<double> IngredientConcentration { get; set; }
        public string HstryUserName { get; set; }
        public byte[] HstryTimeStamp { get; set; }
        public System.DateTime HstryDateTime { get; set; }
        public string HstryTaskName { get; set; }
        public long SliceSer { get; set; }
    
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<ContrastBolusCode> ContrastBolusCodes { get; set; }
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<ContrastFlow> ContrastFlows { get; set; }
        public virtual Slouse Slouse { get; set; }
    }
}
