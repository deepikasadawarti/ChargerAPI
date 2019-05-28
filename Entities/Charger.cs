using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Threading.Tasks;

namespace ChargerInfo.API.Entities
{
    [Table("chargers")]
    public class Charger
    {
        [Key]
        [DatabaseGenerated(DatabaseGeneratedOption.Identity)]
        public int id { get; set; }
        [Required]
        [MaxLength(50)]
        public string chargerStationType { get; set; }
        public int powerInVolt { get; set; }
    }
}
