using Foundation;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;


namespace Taxi.Web.Data.Entities
{
    public class TaxiEntity
    {
        public int ID { get; set; }

        [StringLength(6, MinimumLength = 6, ErrorMessage = "The Field must have {1} characteres.")]
        [Required(ErrorMessage = "The Field {0} is mandatory.")]
        public string Plaque { get; set; }

        public ICollection<TripEntity> Trips { get; set; }
    }
}
