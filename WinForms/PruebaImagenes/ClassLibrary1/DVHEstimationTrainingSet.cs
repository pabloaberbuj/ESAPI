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
    
    public partial class DVHEstimationTrainingSet
    {
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2214:DoNotCallOverridableMethodsInConstructors")]
        public DVHEstimationTrainingSet()
        {
            this.DVHEstimationTrainingSetPlanSetups = new HashSet<DVHEstimationTrainingSetPlanSetup>();
            this.DVHEstimationTrainingSetStructures = new HashSet<DVHEstimationTrainingSetStructure>();
        }
    
        public long DVHEstimationTrainingSetSer { get; set; }
        public Nullable<System.Guid> PlanningModelLibraryModelGuid { get; set; }
        public string HstryUserName { get; set; }
        public System.DateTime HstryDateTime { get; set; }
        public byte[] HstryTimeStamp { get; set; }
        public string HstryTaskName { get; set; }
    
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<DVHEstimationTrainingSetPlanSetup> DVHEstimationTrainingSetPlanSetups { get; set; }
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<DVHEstimationTrainingSetStructure> DVHEstimationTrainingSetStructures { get; set; }
    }
}
