using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BezorgApp.MVVM.Model
{
    public class DeliveryPerson
    {
        [Required]
        public int Id { get; set; }
        [Required]
        public string? Name { get; set; }
        [Required]
        public int WorkId { get; set; }
    }
}
