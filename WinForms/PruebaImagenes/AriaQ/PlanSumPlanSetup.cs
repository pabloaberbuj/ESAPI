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
    
    public partial class PlanSumPlanSetup
    {
        public long PlanSumSer { get; set; }
        public long PlanSetupSer { get; set; }
        public Nullable<long> CacheKeySer { get; set; }
        public int Sign { get; set; }
        public Nullable<double> RBEFactor { get; set; }
        public string HstryUserName { get; set; }
        public byte[] HstryTimeStamp { get; set; }
        public System.DateTime HstryDateTime { get; set; }
        public string HstryTaskName { get; set; }
        public Nullable<long> RegistrationToReferenceSer { get; set; }
        public Nullable<long> RegistrationFromReferenceSer { get; set; }
        public Nullable<double> NumberOfFractionsOverride { get; set; }
    
        public virtual PlanSetup PlanSetup { get; set; }
        public virtual PlanSum PlanSum { get; set; }
        public virtual SpatialRegistrationIOD SpatialRegistrationIOD { get; set; }
        public virtual SpatialRegistrationIOD SpatialRegistrationIOD1 { get; set; }
    }
}
