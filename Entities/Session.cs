using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Threading.Tasks;

namespace ChargerInfo.API.Entities
{
    [Table("sessions")]
    public class Session
    {
        [Key]
        [DatabaseGenerated(DatabaseGeneratedOption.Identity)]
        public int id { get; set; }
        [Required]
        public DateTime sessionStartTime { get; set; }
        public DateTime sessionStopTime { get; set; }
        [Required]
        [MaxLength(7)]
        public string status { get; set; }
        public int ChargerId;
        
        

    }
}
