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
    
    public partial class CodeStructureCode
    {
        public long CodeStructureCodeSer { get; set; }
        public string SourceCodeScheme { get; set; }
        public string SourceCodeValue { get; set; }
        public long TargetStructureCodeSer { get; set; }
        public string MappingContext { get; set; }
        public string HstryUserName { get; set; }
        public System.DateTime HstryDateTime { get; set; }
        public byte[] HstryTimeStamp { get; set; }
        public string HstryTaskName { get; set; }
    
        public virtual StructureCode StructureCode { get; set; }
    }
}
