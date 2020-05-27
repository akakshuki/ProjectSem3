//------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated from a template.
//
//     Manual changes to this file may cause unexpected behavior in your application.
//     Manual changes to this file will be overwritten if the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------

namespace Domain.EF
{
    using System;
    using System.Collections.Generic;
    
    public partial class User
    {
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2214:DoNotCallOverridableMethodsInConstructors")]
        public User()
        {
            this.UserDonates = new HashSet<UserDonate>();
        }
    
        public string ID { get; set; }
        public string UserName { get; set; }
        public bool UserGender { get; set; }
        public string UserMail { get; set; }
        public System.DateTime UserDOB { get; set; }
        public string UserPwd { get; set; }
        public System.DateTime UserDateCreate { get; set; }
        public bool UserActive { get; set; }
        public int RoleID { get; set; }
        public bool UserVolunteer { get; set; }
        public decimal MoneyDonate { get; set; }
    
        public virtual Role Role { get; set; }
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<UserDonate> UserDonates { get; set; }
    }
}
