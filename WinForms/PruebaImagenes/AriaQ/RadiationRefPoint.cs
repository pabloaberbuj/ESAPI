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
    
    public partial class RadiationRefPoint
    {
        public long RadiationSer { get; set; }
        public long RefPointSer { get; set; }
        public long RTPlanSer { get; set; }
        public Nullable<long> CacheKeySer { get; set; }
        public Nullable<double> FieldDose { get; set; }
        public int DoseSpecificationFlag { get; set; }
        public Nullable<double> Depth { get; set; }
        public Nullable<double> PSSD { get; set; }
        public int DominantFieldFlag { get; set; }
        public string HstryUserName { get; set; }
        public byte[] HstryTimeStamp { get; set; }
        public System.DateTime HstryDateTime { get; set; }
        public string HstryTaskName { get; set; }
        public int NominalFlag { get; set; }
    
        public virtual Radiation Radiation { get; set; }
        public virtual RTPlan RTPlan { get; set; }
        public virtual RefPoint RefPoint { get; set; }
    }
}
