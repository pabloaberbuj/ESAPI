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
    
    public partial class BillSysHospDeptActivity
    {
        public long BillSysHospDeptActivitySer { get; set; }
        public string BillSysInstId { get; set; }
        public string BillSysId { get; set; }
        public long HospitalSer { get; set; }
        public long DepartmentSer { get; set; }
        public string CodeType { get; set; }
        public string HstryUserName { get; set; }
        public byte[] HstryTimeStamp { get; set; }
        public System.DateTime HstryDateTime { get; set; }
        public string HstryTaskName { get; set; }
    
        public virtual Department Department { get; set; }
        public virtual Hospital Hospital { get; set; }
    }
}
