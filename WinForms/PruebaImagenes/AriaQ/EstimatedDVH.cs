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
    
    public partial class EstimatedDVH
    {
        public long EstimatedDVHSer { get; set; }
        public long PlanSetupSer { get; set; }
        public long StructureSer { get; set; }
        public byte[] DVHArray { get; set; }
        public string Type { get; set; }
        public double BinWidth { get; set; }
        public string DoseUnit { get; set; }
        public string VolumeUnit { get; set; }
        public Nullable<double> TargetDoseLevel { get; set; }
        public string HstryUserName { get; set; }
        public System.DateTime HstryDateTime { get; set; }
        public byte[] HstryTimeStamp { get; set; }
        public string HstryTaskName { get; set; }
    
        public virtual PlanSetup PlanSetup { get; set; }
        public virtual Structure Structure { get; set; }
    }
}
