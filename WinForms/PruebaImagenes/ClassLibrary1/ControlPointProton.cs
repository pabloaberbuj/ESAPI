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
    
    public partial class ControlPointProton
    {
        public long ControlPointSer { get; set; }
        public Nullable<long> AddOnSer { get; set; }
        public Nullable<double> SnoutPosition { get; set; }
        public Nullable<double> NozzleEquivalentRange { get; set; }
        public Nullable<double> PeakRange { get; set; }
        public Nullable<int> NumberOfSpots { get; set; }
        public Nullable<int> NumberOfPaintings { get; set; }
        public Nullable<double> SpotSizeX { get; set; }
        public Nullable<double> SpotSizeY { get; set; }
        public Nullable<double> RangeMod1InterruptStart { get; set; }
        public Nullable<double> RangeMod1InterruptStop { get; set; }
        public Nullable<double> RangeMod1WeTStart { get; set; }
        public Nullable<double> RangeMod1WeTStop { get; set; }
        public Nullable<int> RangeMod1DicomSeqNumb { get; set; }
        public Nullable<double> RangeMod2InterruptStart { get; set; }
        public Nullable<double> RangeMod2InterruptStop { get; set; }
        public Nullable<double> RangeMod2WeTStart { get; set; }
        public Nullable<double> RangeMod2WeTStop { get; set; }
        public Nullable<int> RangeMod2DicomSeqNumb { get; set; }
        public Nullable<double> IsocenterToRangeMod1Dist { get; set; }
        public Nullable<double> IsocenterToRangeMod2Dist { get; set; }
        public string LateralSpreadDev1Setting { get; set; }
        public Nullable<double> LateralSpreadDev1WeT { get; set; }
        public Nullable<double> IsoToLatSpreadDev1Dist { get; set; }
        public Nullable<int> LatSpreadDev1DcmSeqNumb { get; set; }
        public string LateralSpreadDev2Setting { get; set; }
        public Nullable<double> LateralSpreadDev2WeT { get; set; }
        public Nullable<double> IsoToLatSpreadDev2Dist { get; set; }
        public Nullable<int> LatSpreadDev2DcmSeqNumb { get; set; }
        public string LateralSpreadDev3Setting { get; set; }
        public Nullable<double> LateralSpreadDev3WeT { get; set; }
        public Nullable<double> IsoToLatSpreadDev3Dist { get; set; }
        public Nullable<int> LatSpreadDev3DcmSeqNumb { get; set; }
        public string RangeShifter1Setting { get; set; }
        public Nullable<double> RangeShifter1WeT { get; set; }
        public Nullable<double> IsoToRangeShifter1Dist { get; set; }
        public Nullable<int> RangeShifter1DcmSeqNumb { get; set; }
        public string RangeShifter2Setting { get; set; }
        public Nullable<double> RangeShifter2WeT { get; set; }
        public Nullable<double> IsoToRangeShifter2Dist { get; set; }
        public Nullable<int> RangeShifter2DcmSeqNumb { get; set; }
        public string RangeShifter3Setting { get; set; }
        public Nullable<double> RangeShifter3WeT { get; set; }
        public Nullable<double> IsoToRangeShifter3Dist { get; set; }
        public Nullable<int> RangeShifter3DcmSeqNumb { get; set; }
        public int UserPreselectEnergy { get; set; }
        public byte[] ApertureShape { get; set; }
    
        public virtual AddOn AddOn { get; set; }
        public virtual ControlPoint ControlPoint { get; set; }
    }
}
