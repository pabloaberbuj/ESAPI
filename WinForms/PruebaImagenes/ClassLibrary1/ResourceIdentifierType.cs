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
    
    public partial class ResourceIdentifierType
    {
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2214:DoNotCallOverridableMethodsInConstructors")]
        public ResourceIdentifierType()
        {
            this.ResourceIdentifiers = new HashSet<ResourceIdentifier>();
        }
    
        public long ResourceIdentifierTypeSer { get; set; }
        public int ResourceTypeNum { get; set; }
        public string ResourceDescription { get; set; }
        public int ActiveFlag { get; set; }
        public int RequiredFlag { get; set; }
        public int UniqueFlag { get; set; }
        public int UniqueHistoryFlag { get; set; }
        public string HstryUserName { get; set; }
        public byte[] HstryTimeStamp { get; set; }
        public System.DateTime HstryDateTime { get; set; }
        public string HstryTaskName { get; set; }
        public Nullable<int> CodeType { get; set; }
        public string SSCodeValue { get; set; }
    
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<ResourceIdentifier> ResourceIdentifiers { get; set; }
        public virtual ResourceType ResourceType { get; set; }
    }
}
