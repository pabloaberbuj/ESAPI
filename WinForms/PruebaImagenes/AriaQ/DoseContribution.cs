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
    
    public partial class DoseContribution
    {
        public long RTPlanSer { get; set; }
        public long RefPointSer { get; set; }
        public Nullable<long> CacheKeySer { get; set; }
        public Nullable<double> DosePerFraction { get; set; }
        public int PrimaryFlag { get; set; }
        public int DicomSeqNumber { get; set; }
        public string Comment { get; set; }
        public string HstryUserName { get; set; }
        public System.DateTime HstryDateTime { get; set; }
        public byte[] HstryTimeStamp { get; set; }
        public string HstryTaskName { get; set; }
    
        public virtual RefPoint RefPoint { get; set; }
        public virtual RTPlan RTPlan { get; set; }
    }
}
