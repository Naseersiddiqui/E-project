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
    
    public partial class tb_Services
    {
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2214:DoNotCallOverridableMethodsInConstructors")]
        public tb_Services()
        {
            this.tb_Sub_Services = new HashSet<tb_Sub_Services>();
        }
    
        public int service_id { get; set; }
        public string service_name { get; set; }
        public string description { get; set; }
        public int admin_id { get; set; }
    
        public virtual tb_Users tb_Users { get; set; }
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<tb_Sub_Services> tb_Sub_Services { get; set; }
    }
}
