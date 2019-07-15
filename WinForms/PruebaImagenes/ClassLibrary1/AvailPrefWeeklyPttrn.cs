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
    
    public partial class AvailPrefWeeklyPttrn
    {
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2214:DoNotCallOverridableMethodsInConstructors")]
        public AvailPrefWeeklyPttrn()
        {
            this.AvailPrefPttrnDetails = new HashSet<AvailPrefPttrnDetail>();
        }
    
        public long AvailPrefWeeklyPttrnSer { get; set; }
        public Nullable<long> ActivitySer { get; set; }
        public long ResourceDepartmentSer { get; set; }
        public int PrfrPttrnFlag { get; set; }
        public Nullable<System.DateTime> PatternStartDateTime { get; set; }
        public Nullable<System.DateTime> PatternEndDateTime { get; set; }
        public string HstryUserName { get; set; }
        public byte[] HstryTimeStamp { get; set; }
        public System.DateTime HstryDateTime { get; set; }
        public string HstryTaskName { get; set; }
        public Nullable<long> ActivityCategorySer { get; set; }
    
        public virtual Activity Activity { get; set; }
        public virtual ActivityCategory ActivityCategory { get; set; }
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<AvailPrefPttrnDetail> AvailPrefPttrnDetails { get; set; }
        public virtual ResourceDepartment ResourceDepartment { get; set; }
    }
}
