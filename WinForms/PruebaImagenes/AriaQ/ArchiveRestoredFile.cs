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
    
    public partial class ArchiveRestoredFile
    {
        public long ArchiveRestoredFileSer { get; set; }
        public long PatientSer { get; set; }
        public string FileName { get; set; }
        public string OriginalFileName { get; set; }
        public string DocumentType { get; set; }
        public Nullable<System.DateTime> ArchiveDate { get; set; }
        public string Comment { get; set; }
        public string HstryUserName { get; set; }
        public byte[] HstryTimeStamp { get; set; }
        public System.DateTime HstryDateTime { get; set; }
        public string HstryTaskName { get; set; }
    
        public virtual Patient Patient { get; set; }
    }
}
