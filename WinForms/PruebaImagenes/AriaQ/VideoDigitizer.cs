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
    
    public partial class VideoDigitizer
    {
        public long ResourceSer { get; set; }
        public Nullable<int> DefStorageRes { get; set; }
        public Nullable<double> XYAspectRatio { get; set; }
        public string VideoBoard { get; set; }
    
        public virtual ImagingDevice ImagingDevice { get; set; }
    }
}
