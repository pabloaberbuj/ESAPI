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
    
    public partial class ActivityPttrnToSchedActivity
    {
        public long ScheduledActivitySer { get; set; }
        public long ActivityPttrnPerCycleSer { get; set; }
        public string HstryUserName { get; set; }
        public byte[] HstryTimeStamp { get; set; }
        public System.DateTime HstryDateTime { get; set; }
        public string HstryTaskName { get; set; }
    
        public virtual ActivityPttrnPerCycle ActivityPttrnPerCycle { get; set; }
        public virtual ScheduledActivity ScheduledActivity { get; set; }
    }
}
