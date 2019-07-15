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
    
    public partial class StructureSet
    {
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2214:DoNotCallOverridableMethodsInConstructors")]
        public StructureSet()
        {
            this.PlanSetups = new HashSet<PlanSetup>();
            this.Structures = new HashSet<Structure>();
        }
    
        public long StructureSetSer { get; set; }
        public long SeriesSer { get; set; }
        public long ImageSer { get; set; }
        public string StructureSetUID { get; set; }
        public string StructureSetId { get; set; }
        public string StructureSetName { get; set; }
        public string Comment { get; set; }
        public Nullable<System.DateTime> ModifiedDateTime { get; set; }
        public Nullable<int> InstanceNumber { get; set; }
        public Nullable<long> EquipmentSer { get; set; }
        public string HstryUserName { get; set; }
        public byte[] HstryTimeStamp { get; set; }
        public System.DateTime HstryDateTime { get; set; }
        public string HstryTaskName { get; set; }
        public string ROIMaterialVersion { get; set; }
    
        public virtual Equipment Equipment { get; set; }
        public virtual Image Image { get; set; }
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<PlanSetup> PlanSetups { get; set; }
        public virtual Series Series { get; set; }
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<Structure> Structures { get; set; }
    }
}
