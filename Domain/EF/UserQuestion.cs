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
    
    public partial class UserQuestion
    {
        public int ID { get; set; }
        public int UserID { get; set; }
        public string QuesContent { get; set; }
        public System.DateTime QuesDateCreate { get; set; }
        public bool QuesHide { get; set; }
        public bool QuesNew { get; set; }
        public string AnswerContent { get; set; }
        public Nullable<System.DateTime> AnswerDateCreate { get; set; }
    
        public virtual User User { get; set; }
    }
}
