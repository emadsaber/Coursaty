//------------------------------------------------------------------------------
// <auto-generated>
//    This code was generated from a template.
//
//    Manual changes to this file may cause unexpected behavior in your application.
//    Manual changes to this file will be overwritten if the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------

namespace Coursaty.Models
{
    using System;
    using System.Collections.Generic;
    
    public partial class Comment
    {
        public Comment()
        {
            this.Comments1 = new HashSet<Comment>();
        }
    
        public int id { get; set; }
        public Nullable<System.DateTime> currDate { get; set; }
        public string comment1 { get; set; }
        public Nullable<int> ReplyTo { get; set; }
        public Nullable<int> userId { get; set; }
        public int courseId { get; set; }
        public bool ToDelete { get; set; }
    
        public virtual User User { get; set; }
        public virtual ICollection<Comment> Comments1 { get; set; }
        public virtual Comment Comment2 { get; set; }
        public virtual Course Cours { get; set; }
    }
}
