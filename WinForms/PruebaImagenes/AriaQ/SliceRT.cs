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
    
    public partial class SliceRT
    {
        public long SliceSer { get; set; }
        public Nullable<long> DoubleExposureSer { get; set; }
        public string ReportedValuesOrigin { get; set; }
        public Nullable<double> IDUPosLat { get; set; }
        public Nullable<double> IDUPosLng { get; set; }
        public Nullable<double> IDUSID { get; set; }
        public Nullable<double> IDURtn { get; set; }
        public Nullable<int> Energy { get; set; }
        public Nullable<double> SAD { get; set; }
        public string PrimaryDosimeterUnit { get; set; }
        public Nullable<double> MetersetExposure { get; set; }
        public Nullable<int> ExposureTime { get; set; }
        public Nullable<double> CollX1 { get; set; }
        public Nullable<double> CollX2 { get; set; }
        public Nullable<double> CollY1 { get; set; }
        public Nullable<double> CollY2 { get; set; }
        public string SliceRTType { get; set; }
        public int OpenField { get; set; }
        public Nullable<int> DoseRate { get; set; }
        public Nullable<double> StartCumulativeMeterset { get; set; }
        public Nullable<double> EndCumulativeMeterset { get; set; }
        public string AcqNote { get; set; }
        public Nullable<double> GantryAngle { get; set; }
        public Nullable<double> CollRtn { get; set; }
        public Nullable<double> BladeX1 { get; set; }
        public Nullable<double> BladeX2 { get; set; }
        public Nullable<double> BladeY1 { get; set; }
        public Nullable<double> BladeY2 { get; set; }
        public Nullable<double> IDUCorrectionLat { get; set; }
        public Nullable<double> IDUCorrectionLng { get; set; }
        public Nullable<int> XRayTubeCurrent { get; set; }
        public Nullable<double> RTImagePositionX { get; set; }
        public Nullable<double> RTImagePositionY { get; set; }
        public Nullable<double> OffPlaneAngle { get; set; }
        public Nullable<double> IsoCenterPositionX { get; set; }
        public Nullable<double> IsoCenterPositionY { get; set; }
        public Nullable<double> IsoCenterPositionZ { get; set; }
        public string PrimaryFluenceModeId { get; set; }
        public Nullable<long> RadiationSer { get; set; }
        public Nullable<long> PlanSetupSer { get; set; }
        public int UpdateOnBeamChange { get; set; }
        public int ReferenceImage { get; set; }
        public string RadiationMachineName { get; set; }
    
        public virtual Image Image { get; set; }
        public virtual PlanSetup PlanSetup { get; set; }
        public virtual Radiation Radiation { get; set; }
        public virtual Slouse Slouse { get; set; }
    }
}
