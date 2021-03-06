using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Domain.Models
{
    [Table("Person")]
    public class Person
    {
        [DatabaseGenerated(DatabaseGeneratedOption.Identity)]
        [Key]
        [Column("PersonID")]
        public int PersonID { set; get; }
        public string Name { get; set; }
        public string Telephone { set; get; }
        public string Document { set; get; }
        public int RolID { get; set; }
        //
        //Auditory
        public DateTime CreatedAt { get; set; }
        public DateTime? UpdatedAt { get; set; }
        [StringLength(50)]
        public string CreatedBy { get; set; }
        //
        public virtual Rol Rol { get; set; }

    }
}
