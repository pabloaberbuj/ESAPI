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
    
    public partial class VolOptMatrix
    {
        public long VolOptMatrixSer { get; set; }
        public long VolOptConstraintsSer { get; set; }
        public int SizeX { get; set; }
        public int SizeY { get; set; }
        public int SizeZ { get; set; }
        public double ResX { get; set; }
        public double ResY { get; set; }
        public double ResZ { get; set; }
        public byte[] Transformation { get; set; }
        public string MatrixType { get; set; }
        public string MatrixDataType { get; set; }
        public string MatrixDataFile { get; set; }
        public int Priority { get; set; }
        public string HstryUserName { get; set; }
        public System.DateTime HstryDateTime { get; set; }
        public byte[] HstryTimeStamp { get; set; }
        public string HstryTaskName { get; set; }
    
        public virtual VolOptConstraint VolOptConstraint { get; set; }
    }
}
