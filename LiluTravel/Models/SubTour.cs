using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Web;

namespace LiluTravel.Models
{
    [Table("SubTours", Schema = "tour")]
    public class SubTour
    {
        [Key]
        [Column("id")]
        public int Id { get; set; }

        [Column("name")]
        public string Name { get; set; }

        [Column("description")]
        public string Description { get; set; }

        [Column("tour_id")]
        public int TourId { get; set; }

        [Column("price")]
        public decimal Price { get; set; }


        [ForeignKey("TourId")]
        public virtual Tour Tour { get; set; }

        public virtual ICollection<SubTourImage> SubTourImages { get; set; }
    }
}