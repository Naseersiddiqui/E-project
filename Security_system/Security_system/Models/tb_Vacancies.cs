//------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated from a template.
//
//     Manual changes to this file may cause unexpected behavior in your application.
//     Manual changes to this file will be overwritten if the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------

namespace Security_system.Models
{
    using System;
    using System.Collections.Generic;
    
    public partial class tb_Vacancies
    {
        public int job_id { get; set; }
        public string job_title { get; set; }
        public string job_description { get; set; }
        public string job_requirements { get; set; }
        public string job_department { get; set; }
        public int sub_service_id { get; set; }
        public int admin_id { get; set; }
    
        public virtual tb_Sub_Services tb_Sub_Services { get; set; }
        public virtual tb_Users tb_Users { get; set; }
    }
}
