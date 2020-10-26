//------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated from a template.
//
//     Manual changes to this file may cause unexpected behavior in your application.
//     Manual changes to this file will be overwritten if the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------

namespace NZJobFInder.Models
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    public partial class Employer
    {
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2214:DoNotCallOverridableMethodsInConstructors")]
        public Employer()
        {
            this.Jobs = new HashSet<Job>();
        }
    
        public int employerId { get; set; }


        [Required(ErrorMessage = "Employer name is required"),MinLength(3),MaxLength(10)]
        public string employerName { get; set; }
        public string employerAddress { get; set; }

        [Required(ErrorMessage = "Phone is required"),MinLength(8),MaxLength(12)]
        public string employerPhoneNum { get; set; }
        public string employerUserName { get; set; }
        public string employerPassword { get; set; }


        [Required(ErrorMessage = "email is required")]
        [StringLength(20, ErrorMessage = "email must be less than 20 characters" )]
        [RegularExpression(@"^[a-zA-Z0-9]+@[a-zA-Z0-9]+(\.[a-zA-Z]+)*$", ErrorMessage ="Email is not valid")]
        public string employerEmailAddress { get; set; }
    
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<Job> Jobs { get; set; }
    }
}
