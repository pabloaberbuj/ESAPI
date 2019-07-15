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
    
    public partial class BillSysSentCharge
    {
        public long BillSysSentChargesSer { get; set; }
        public string TransId { get; set; }
        public long ActInstProcCodeSer { get; set; }
        public int ActInstProcCodeRevCount { get; set; }
        public string ChargeIndicator { get; set; }
        public string VoidCharge { get; set; }
        public string BillSysInstId { get; set; }
        public string BillSysId { get; set; }
        public Nullable<long> PatientSer { get; set; }
        public string MergeFlag { get; set; }
        public string BatchId { get; set; }
        public string Hl7MsgCntlId { get; set; }
        public Nullable<int> Hl7SetId { get; set; }
        public string FillerRefNo { get; set; }
        public Nullable<int> BillEventUnits { get; set; }
        public Nullable<decimal> BillCdBillPrice { get; set; }
        public string BillCdInvId { get; set; }
        public string SendSurpressed { get; set; }
        public string BillChargeStatus { get; set; }
        public string BillChargeStatusTxt { get; set; }
    
        public virtual ActInstProcCode ActInstProcCode { get; set; }
        public virtual Patient Patient { get; set; }
    }
}
