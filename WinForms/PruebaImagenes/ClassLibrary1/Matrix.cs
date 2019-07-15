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
    
    public partial class Matrix
    {
        public long MatrixSer { get; set; }
        public string MatrixId { get; set; }
        public string MatrixName { get; set; }
        public string MatrixType { get; set; }
        public string MatrixDataType { get; set; }
        public string UsageType { get; set; }
        public string MatrixFileName { get; set; }
        public Nullable<int> SizeX { get; set; }
        public Nullable<int> SizeY { get; set; }
        public string Comment { get; set; }
        public string ContextDetails { get; set; }
        public int GantryCoordinates { get; set; }
        public string HstryUserName { get; set; }
        public byte[] HstryTimeStamp { get; set; }
        public System.DateTime HstryDateTime { get; set; }
        public string HstryTaskName { get; set; }
        public Nullable<long> MLCPlanSer { get; set; }
        public Nullable<long> RadiationSer { get; set; }
        public Nullable<long> CompensatorSer { get; set; }
    
        public virtual Compensator Compensator { get; set; }
        public virtual ExternalField ExternalField { get; set; }
        public virtual MLCPlan MLCPlan { get; set; }
    }
}
