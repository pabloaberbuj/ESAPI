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
    
    public partial class ScheduleHoliday
    {
        public long HolidaySer { get; set; }
        public Nullable<long> DepartmentSer { get; set; }
        public string HolidayId { get; set; }
        public string HolidayName { get; set; }
        public System.DateTime StartDateTime { get; set; }
        public System.DateTime EndDateTime { get; set; }
        public long RecurrenceRuleSer { get; set; }
        public int HsptlBusShutdown { get; set; }
        public string HstryUserName { get; set; }
        public byte[] HstryTimeStamp { get; set; }
        public System.DateTime HstryDateTime { get; set; }
        public string HstryTaskName { get; set; }
    
        public virtual Department Department { get; set; }
        public virtual RecurrenceRule RecurrenceRule { get; set; }
    }
}
