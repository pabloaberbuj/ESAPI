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
    
    public partial class RefPointLocation
    {
        public long ImageSer { get; set; }
        public long RefPointSer { get; set; }
        public Nullable<long> CacheKeySer { get; set; }
        public string RefPointLocationType { get; set; }
        public byte[] Location { get; set; }
        public string HstryUserName { get; set; }
        public byte[] HstryTimeStamp { get; set; }
        public System.DateTime HstryDateTime { get; set; }
        public string HstryTaskName { get; set; }
    
        public virtual Image Image { get; set; }
        public virtual RefPoint RefPoint { get; set; }
    }
}
