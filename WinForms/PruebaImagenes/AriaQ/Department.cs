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
    
    public partial class Department
    {
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2214:DoNotCallOverridableMethodsInConstructors")]
        public Department()
        {
            this.AccountBillingCodes = new HashSet<AccountBillingCode>();
            this.ActInstProcCodes = new HashSet<ActInstProcCode>();
            this.ActivityCaptures = new HashSet<ActivityCapture>();
            this.ActivityCategories = new HashSet<ActivityCategory>();
            this.ActivityInstances = new HashSet<ActivityInstance>();
            this.ActivityPttrns = new HashSet<ActivityPttrn>();
            this.BillSysChrgWrks = new HashSet<BillSysChrgWrk>();
            this.BillSysHospDeptActivities = new HashSet<BillSysHospDeptActivity>();
            this.ChecklistGroups = new HashSet<ChecklistGroup>();
            this.ChecklistItems = new HashSet<ChecklistItem>();
            this.ConfigurationSets = new HashSet<ConfigurationSet>();
            this.DepartmentPttrnDetails = new HashSet<DepartmentPttrnDetail>();
            this.DeptGrpAssociations = new HashSet<DeptGrpAssociation>();
            this.PatientDepartments = new HashSet<PatientDepartment>();
            this.ProcedureCodes = new HashSet<ProcedureCode>();
            this.ResourceDepartments = new HashSet<ResourceDepartment>();
            this.ResourceGroups = new HashSet<ResourceGroup>();
            this.ScheduleHolidays = new HashSet<ScheduleHoliday>();
            this.Templates = new HashSet<Template>();
        }
    
        public long DepartmentSer { get; set; }
        public long HospitalSer { get; set; }
        public string DepartmentId { get; set; }
        public string DepartmentName { get; set; }
        public string ObjectStatus { get; set; }
        public string Comment { get; set; }
        public string HstryUserName { get; set; }
        public byte[] HstryTimeStamp { get; set; }
        public System.DateTime HstryDateTime { get; set; }
        public string HstryTaskName { get; set; }
    
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<AccountBillingCode> AccountBillingCodes { get; set; }
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<ActInstProcCode> ActInstProcCodes { get; set; }
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<ActivityCapture> ActivityCaptures { get; set; }
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<ActivityCategory> ActivityCategories { get; set; }
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<ActivityInstance> ActivityInstances { get; set; }
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<ActivityPttrn> ActivityPttrns { get; set; }
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<BillSysChrgWrk> BillSysChrgWrks { get; set; }
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<BillSysHospDeptActivity> BillSysHospDeptActivities { get; set; }
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<ChecklistGroup> ChecklistGroups { get; set; }
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<ChecklistItem> ChecklistItems { get; set; }
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<ConfigurationSet> ConfigurationSets { get; set; }
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<DepartmentPttrnDetail> DepartmentPttrnDetails { get; set; }
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<DeptGrpAssociation> DeptGrpAssociations { get; set; }
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<PatientDepartment> PatientDepartments { get; set; }
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<ProcedureCode> ProcedureCodes { get; set; }
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<ResourceDepartment> ResourceDepartments { get; set; }
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<ResourceGroup> ResourceGroups { get; set; }
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<ScheduleHoliday> ScheduleHolidays { get; set; }
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<Template> Templates { get; set; }
        public virtual Hospital Hospital { get; set; }
    }
}
