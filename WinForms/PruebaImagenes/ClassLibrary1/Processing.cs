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
    
    public partial class Processing
    {
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2214:DoNotCallOverridableMethodsInConstructors")]
        public Processing()
        {
            this.ChildProcessings = new HashSet<ChildProcessing>();
            this.ChildProcessings1 = new HashSet<ChildProcessing>();
            this.Images = new HashSet<Image>();
            this.Images1 = new HashSet<Image>();
        }
    
        public long ProcessingSer { get; set; }
        public string ProcessingId { get; set; }
        public string ProcessingName { get; set; }
        public Nullable<int> RootFlag { get; set; }
        public string FunctionName { get; set; }
        public Nullable<int> ProcessingStatus { get; set; }
        public string ImageTypes { get; set; }
        public byte[] ParameterList { get; set; }
        public int ParameterListLen { get; set; }
        public string Comment { get; set; }
        public string HstryUserName { get; set; }
        public byte[] HstryTimeStamp { get; set; }
        public System.DateTime HstryDateTime { get; set; }
        public string HstryTaskName { get; set; }
    
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<ChildProcessing> ChildProcessings { get; set; }
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<ChildProcessing> ChildProcessings1 { get; set; }
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<Image> Images { get; set; }
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<Image> Images1 { get; set; }
    }
}