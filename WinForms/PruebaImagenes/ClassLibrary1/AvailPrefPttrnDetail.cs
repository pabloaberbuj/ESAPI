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
    
    public partial class AvailPrefPttrnDetail
    {
        public long AvailPrefPttrnDetailsSer { get; set; }
        public long AvailPrefWeeklyPttrnSer { get; set; }
        public Nullable<int> PatternDayOfWeek { get; set; }
        public Nullable<System.DateTime> PatternStartTime { get; set; }
        public Nullable<System.DateTime> PatternEndTime { get; set; }
        public string HstryUserName { get; set; }
        public byte[] HstryTimeStamp { get; set; }
        public System.DateTime HstryDateTime { get; set; }
        public string HstryTaskName { get; set; }
        public Nullable<long> ActivityCategorySer { get; set; }
        public Nullable<long> ActivitySer { get; set; }
    
        public virtual Activity Activity { get; set; }
        public virtual ActivityCategory ActivityCategory { get; set; }
        public virtual AvailPrefWeeklyPttrn AvailPrefWeeklyPttrn { get; set; }
    }
}
