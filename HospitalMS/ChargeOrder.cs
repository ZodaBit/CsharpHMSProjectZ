//------------------------------------------------------------------------------
// <auto-generated>
//    This code was generated from a template.
//
//    Manual changes to this file may cause unexpected behavior in your application.
//    Manual changes to this file will be overwritten if the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------

namespace HospitalMS
{
    using System;
    using System.Collections.Generic;
    
    public partial class ChargeOrder
    {
        public int ID { get; set; }
        public string PatientID { get; set; }
        public string ChargeType { get; set; }
        public string Date { get; set; }
        public string Time { get; set; }
        public string PatientName { get; set; }
        public string ChargeAmount { get; set; }
        public string ChargeState { get; set; }
        public string OrderDepartment { get; set; }
        public string Orderby { get; set; }
        public string StaffName { get; set; }
        public string Remarks { get; set; }
    }
}
