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
    
    public partial class PortImager
    {
        public long ResourceSer { get; set; }
        public long ExtBeamResourceSer { get; set; }
        public int DefaultFlag { get; set; }
        public Nullable<double> SAD { get; set; }
        public Nullable<double> Gantry { get; set; }
        public Nullable<double> GantryPitch { get; set; }
        public Nullable<double> RadSourceGantryDelta { get; set; }
    
        public virtual ExternalBeam ExternalBeam { get; set; }
        public virtual ImagingDevice ImagingDevice { get; set; }
    }
}
