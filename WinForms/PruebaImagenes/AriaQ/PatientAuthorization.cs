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
    
    public partial class PatientAuthorization
    {
        public long PatientAuthorizationSer { get; set; }
        public long PatientPayorSer { get; set; }
        public int PatientPayorRevCount { get; set; }
        public string AuthorizationId { get; set; }
        public string Comment { get; set; }
        public System.DateTime AuthorizationDateTime { get; set; }
        public string AuthorizedBy { get; set; }
        public string AuthorizationPhone { get; set; }
        public string AuthorizationFAX { get; set; }
        public string HstryUserName { get; set; }
        public byte[] HstryTimeStamp { get; set; }
        public System.DateTime HstryDateTime { get; set; }
        public string HstryTaskName { get; set; }
    
        public virtual PatientPayor PatientPayor { get; set; }
    }
}
