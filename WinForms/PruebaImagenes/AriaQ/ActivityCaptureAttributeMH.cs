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
    
    public partial class ActivityCaptureAttributeMH
    {
        public long ActivityCaptureAttributeSer { get; set; }
        public int ActivityCaptureAttrRevCount { get; set; }
        public long ActivityCaptureSer { get; set; }
        public int ActivityCaptureRevCount { get; set; }
        public long ActivityAttributeSer { get; set; }
        public int ActivityAttributeRevCount { get; set; }
        public string AttributeValue { get; set; }
        public string ObjectStatus { get; set; }
        public string HstryUserName { get; set; }
        public byte[] HstryTimeStamp { get; set; }
        public System.DateTime HstryDateTime { get; set; }
        public string HstryTaskName { get; set; }
    
        public virtual ActivityCaptureAttribute ActivityCaptureAttribute { get; set; }
    }
}
