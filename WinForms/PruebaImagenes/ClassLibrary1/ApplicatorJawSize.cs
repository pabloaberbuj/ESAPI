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
    
    public partial class ApplicatorJawSize
    {
        public long ApplicatorJawSizeSer { get; set; }
        public long ApplicatorSer { get; set; }
        public long EnergyModeSer { get; set; }
        public Nullable<double> CollX { get; set; }
        public Nullable<double> CollY { get; set; }
        public string HstryUserName { get; set; }
        public byte[] HstryTimeStamp { get; set; }
        public System.DateTime HstryDateTime { get; set; }
        public string HstryTaskName { get; set; }
    
        public virtual Applicator Applicator { get; set; }
        public virtual EnergyMode EnergyMode { get; set; }
    }
}
