using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Domain.Models
{
    [Table("Persons")]
    public class Person
    {
        [DatabaseGenerated(DatabaseGeneratedOption.Identity)]
        [Key]
        [Column("EmployeeID")]
        public int PersonID { set; get; }
        public string Name { get; set; }
        [StringLength(20)]
        public string Telephone { set; get; }
        public string Document { set; get; }
        //
    }
}
