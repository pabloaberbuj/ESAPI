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
    
    public partial class DICOMCodeScheme
    {
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2214:DoNotCallOverridableMethodsInConstructors")]
        public DICOMCodeScheme()
        {
            this.DICOMCodeValues = new HashSet<DICOMCodeValue>();
        }
    
        public long DICOMCodeSchemeSer { get; set; }
        public string Designator { get; set; }
        public string Version { get; set; }
        public string Registry { get; set; }
        public string UID { get; set; }
        public string ExternalID { get; set; }
        public string CommonName { get; set; }
        public string ResponsibleOrganization { get; set; }
    
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<DICOMCodeValue> DICOMCodeValues { get; set; }
    }
}
