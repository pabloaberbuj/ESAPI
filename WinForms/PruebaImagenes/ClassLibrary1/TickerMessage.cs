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
    
    public partial class TickerMessage
    {
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2214:DoNotCallOverridableMethodsInConstructors")]
        public TickerMessage()
        {
            this.TickerMessageChannels = new HashSet<TickerMessageChannel>();
        }
    
        public long TickerMessageSer { get; set; }
        public string FromMachine { get; set; }
        public string MessageType { get; set; }
        public string MsgUID { get; set; }
        public System.DateTime CreationTime { get; set; }
        public System.DateTime ExpirationTime { get; set; }
        public string Message { get; set; }
        public string ObjectStatus { get; set; }
        public string HstryUserName { get; set; }
        public byte[] HstryTimeStamp { get; set; }
        public System.DateTime HstryDateTime { get; set; }
        public string HstryTaskName { get; set; }
    
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<TickerMessageChannel> TickerMessageChannels { get; set; }
    }
}
