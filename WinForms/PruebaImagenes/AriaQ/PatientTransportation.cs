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
    
    public partial class PatientTransportation
    {
        public long PatientTransportationSer { get; set; }
        public long PatientSer { get; set; }
        public Nullable<long> TransportationSer { get; set; }
        public string TransportationName { get; set; }
        public string TransportationPhone { get; set; }
        public string TransportationComment { get; set; }
        public int PrimaryFlag { get; set; }
        public string HstryUserName { get; set; }
        public byte[] HstryTimeStamp { get; set; }
        public System.DateTime HstryDateTime { get; set; }
        public string HstryTaskName { get; set; }
    
        public virtual Patient Patient { get; set; }
        public virtual Transportation Transportation { get; set; }
    }
}
