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
    
    public partial class ChargesControl
    {
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2214:DoNotCallOverridableMethodsInConstructors")]
        public ChargesControl()
        {
            this.BillSysChrgWrks = new HashSet<BillSysChrgWrk>();
        }
    
        public long ChargesControlSer { get; set; }
        public Nullable<long> HospitalSer { get; set; }
        public string TmpltType { get; set; }
        public int ExtBillCodDisp { get; set; }
        public int ExtBillCodExport { get; set; }
        public string ExportType { get; set; }
        public int RVUExport { get; set; }
        public Nullable<double> RVUMultiplier { get; set; }
        public string HstryUserName { get; set; }
        public byte[] HstryTimeStamp { get; set; }
        public System.DateTime HstryDateTime { get; set; }
        public string HstryTaskName { get; set; }
    
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<BillSysChrgWrk> BillSysChrgWrks { get; set; }
        public virtual Hospital Hospital { get; set; }
    }
}
