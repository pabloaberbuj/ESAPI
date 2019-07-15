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
    
    public partial class ActivityMH
    {
        public long ActivitySer { get; set; }
        public int ActivityRevCount { get; set; }
        public long ActivityCategorySer { get; set; }
        public string ActivityCode { get; set; }
        public string ActivityType { get; set; }
        public Nullable<long> DerivedFromActivitySer { get; set; }
        public Nullable<int> NoEditFlag { get; set; }
        public string ObjectStatus { get; set; }
        public Nullable<long> ResourceGroupSer { get; set; }
        public Nullable<int> DefaultDuration { get; set; }
        public int ExclusiveFlag { get; set; }
        public Nullable<int> NotificationPriorTime { get; set; }
        public int AssignableFlag { get; set; }
        public string Description { get; set; }
        public byte[] ForeGroundColor { get; set; }
        public byte[] Icon { get; set; }
        public string HstryUserName { get; set; }
        public byte[] HstryTimeStamp { get; set; }
        public System.DateTime HstryDateTime { get; set; }
        public string HstryTaskName { get; set; }
        public Nullable<long> DICOMCodeValueSer { get; set; }
        public int NotificationPriorTimeFlag { get; set; }
        public Nullable<long> EscalationGroupSer { get; set; }
        public Nullable<long> TreatmentCycleSer { get; set; }
        public int ReviewFlag { get; set; }
        public Nullable<long> UpdCPResourceGroupSer { get; set; }
        public Nullable<long> UpdCPEscalationGroupSer { get; set; }
        public int AutoGenerateFlag { get; set; }
        public int NoAutoPostFlag { get; set; }
    
        public virtual Activity Activity { get; set; }
    }
}
