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
    
    public partial class ProtonCompensator
    {
        public long CompensatorSer { get; set; }
        public int BolusFlag { get; set; }
        public Nullable<double> CompMillingToolDiameter { get; set; }
        public Nullable<double> CompStoppingPowerRatio { get; set; }
        public string MillingMachineId { get; set; }
    
        public virtual Compensator Compensator { get; set; }
    }
}
