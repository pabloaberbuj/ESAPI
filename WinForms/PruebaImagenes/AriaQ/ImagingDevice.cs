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
    
    public partial class ImagingDevice
    {
        public long ResourceSer { get; set; }
        public string ImagingDeviceType { get; set; }
        public string ImageModality { get; set; }
        public string Comment { get; set; }
        public int ConeBeamFlag { get; set; }
    
        public virtual CTScanner CTScanner { get; set; }
        public virtual CTSimulator CTSimulator { get; set; }
        public virtual LocalizationJig LocalizationJig { get; set; }
        public virtual PortImager PortImager { get; set; }
        public virtual SimulationImager SimulationImager { get; set; }
        public virtual VideoDigitizer VideoDigitizer { get; set; }
        public virtual Machine Machine { get; set; }
    }
}
