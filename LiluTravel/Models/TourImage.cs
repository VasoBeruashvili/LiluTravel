using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Web;

namespace LiluTravel.Models
{
    [Table("TourImages", Schema = "tour")]
    public class TourImage
    {
        [Key]
        [Column("id")]
        public int Id { get; set; }

        [Column("image")]
        public string Image { get; set; }

        [Column("tour_id")]
        public int TourId { get; set; }

        [ForeignKey("TourId")]
        public virtual Tour Tour { get; set; }
    }
}