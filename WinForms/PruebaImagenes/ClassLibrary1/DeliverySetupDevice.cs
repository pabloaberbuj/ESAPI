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
    
    public partial class DeliverySetupDevice
    {
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2214:DoNotCallOverridableMethodsInConstructors")]
        public DeliverySetupDevice()
        {
            this.DeliverySetupDeviceMachines = new HashSet<DeliverySetupDeviceMachine>();
            this.RadiationDeliverySetupDevices = new HashSet<RadiationDeliverySetupDevice>();
        }
    
        public long DeliverySetupDeviceSer { get; set; }
        public string DeliverySetupDeviceId { get; set; }
        public string DeliverySetupDeviceName { get; set; }
        public string Comment { get; set; }
        public string DeviceType { get; set; }
        public string DeviceCode { get; set; }
        public string DeviceCategory { get; set; }
        public string ObjectStatus { get; set; }
        public string GeometricDefinition { get; set; }
        public int GeometricDefinitionLen { get; set; }
        public string HstryUserName { get; set; }
        public byte[] HstryTimeStamp { get; set; }
        public System.DateTime HstryDateTime { get; set; }
        public string HstryTaskName { get; set; }
    
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<DeliverySetupDeviceMachine> DeliverySetupDeviceMachines { get; set; }
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<RadiationDeliverySetupDevice> RadiationDeliverySetupDevices { get; set; }
    }
}