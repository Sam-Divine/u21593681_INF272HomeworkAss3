//------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated from a template.
//
//     Manual changes to this file may cause unexpected behavior in your application.
//     Manual changes to this file will be overwritten if the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------

namespace u21593681_INF272HomeworkAss3.Models
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    public partial class students
    {
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2214:DoNotCallOverridableMethodsInConstructors")]
        public students()
        {
            this.borrows = new HashSet<borrows>();
        }

        [Key]
        public int studentId { get; set; }

        [DataType(DataType.Text)]
        [Required(ErrorMessage = "Please enter the name of the student")]
        public string name { get; set; }

        [DataType(DataType.Text)]
        [Required(ErrorMessage = "Please enter the surname of the student")]
        public string surname { get; set; }

        [DataType(DataType.DateTime)]
        public Nullable<System.DateTime> birthdate { get; set; }
        
        [DataType(DataType.Text)]
        public string gender { get; set; }

        
        public string @class { get; set; }
        public Nullable<int> point { get; set; }
    
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<borrows> borrows { get; set; }
    }
}
