using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Web;

namespace LiluTravel.Models
{
    [Table("Tours", Schema = "tour")]
    public class Tour
    {
        [Key]
        [Column("id")]
        public int Id { get; set; }

        [Column("name")]
        public string Name { get; set; }

        [Column("description")]
        public string Description { get; set; }


        public virtual ICollection<SubTour> SubTours { get; set; }
        public virtual ICollection<TourImage> TourImages { get; set; }
    }
}