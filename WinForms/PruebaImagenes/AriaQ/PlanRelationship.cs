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
    
    public partial class PlanRelationship
    {
        public long PlanRelationshipSer { get; set; }
        public long RTPlanSer { get; set; }
        public Nullable<long> RelatedRTPlanSer { get; set; }
        public string RelatedPlanUID { get; set; }
        public Nullable<long> RelatedPlanSOPClassSer { get; set; }
        public string RelationshipType { get; set; }
        public string HstryUserName { get; set; }
        public byte[] HstryTimeStamp { get; set; }
        public System.DateTime HstryDateTime { get; set; }
        public string HstryTaskName { get; set; }
    
        public virtual RTPlan RTPlan { get; set; }
        public virtual RTPlan RTPlan1 { get; set; }
        public virtual SOPClass SOPClass { get; set; }
    }
}
