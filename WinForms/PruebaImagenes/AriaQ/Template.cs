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
    
    public partial class Template
    {
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2214:DoNotCallOverridableMethodsInConstructors")]
        public Template()
        {
            this.Template1 = new HashSet<Template>();
            this.TemplateCycles = new HashSet<TemplateCycle>();
            this.TemplateDiagnosis = new HashSet<TemplateDiagnosi>();
            this.TemplateMHs = new HashSet<TemplateMH>();
        }
    
        public long TemplateSer { get; set; }
        public int TemplateRevCount { get; set; }
        public Nullable<long> PatientSer { get; set; }
        public Nullable<long> DiagnosisStageSer { get; set; }
        public Nullable<long> PayorSer { get; set; }
        public Nullable<long> ResourceSer { get; set; }
        public Nullable<long> DepartmentSer { get; set; }
        public Nullable<long> DerivedFromSer { get; set; }
        public System.DateTime CreationDate { get; set; }
        public string TemplateID { get; set; }
        public Nullable<long> CourseSer { get; set; }
        public string ObjectStatus { get; set; }
        public int DefaultFlag { get; set; }
        public string Comment { get; set; }
        public string HstryUserName { get; set; }
        public byte[] HstryTimeStamp { get; set; }
        public System.DateTime HstryDateTime { get; set; }
        public string HstryTaskName { get; set; }
    
        public virtual Course Course { get; set; }
        public virtual Department Department { get; set; }
        public virtual DiagnosisStage DiagnosisStage { get; set; }
        public virtual Patient Patient { get; set; }
        public virtual Payor Payor { get; set; }
        public virtual Resource Resource { get; set; }
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<Template> Template1 { get; set; }
        public virtual Template Template2 { get; set; }
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<TemplateCycle> TemplateCycles { get; set; }
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<TemplateDiagnosi> TemplateDiagnosis { get; set; }
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<TemplateMH> TemplateMHs { get; set; }
    }
}
