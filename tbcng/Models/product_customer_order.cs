//------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated from a template.
//
//     Manual changes to this file may cause unexpected behavior in your application.
//     Manual changes to this file will be overwritten if the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------

namespace tbcng.Models
{
    using System;
    using System.Collections.Generic;
    
    public partial class product_customer_order
    {
        public long id { get; set; }
        public Nullable<int> customer_id { get; set; }
        public string customer_email { get; set; }
        public string customer_phone { get; set; }
        public string session { get; set; }
        public Nullable<double> g { get; set; }
        public Nullable<long> ship_fee { get; set; }
        public Nullable<long> total_fee { get; set; }
        public Nullable<long> total { get; set; }
        public string ordercode { get; set; }
        public Nullable<System.DateTime> date_time { get; set; }
        public Nullable<int> status { get; set; }
    }
}
