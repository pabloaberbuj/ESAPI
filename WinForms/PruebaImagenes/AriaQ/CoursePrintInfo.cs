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
    
    public partial class CoursePrintInfo
    {
        public long CourseSer { get; set; }
        public Nullable<int> LastPrintedPageNum { get; set; }
        public Nullable<int> LastPrintedLineNum { get; set; }
        public string SessionsPrintedLineNum { get; set; }
        public Nullable<System.DateTime> SummaryPrintDate { get; set; }
        public Nullable<System.DateTime> PatientHisPrintDate { get; set; }
        public string ChartFormat { get; set; }
        public string HstryUserName { get; set; }
        public byte[] HstryTimeStamp { get; set; }
        public System.DateTime HstryDateTime { get; set; }
        public string HstryTaskName { get; set; }
    
        public virtual Course Course { get; set; }
    }
}
