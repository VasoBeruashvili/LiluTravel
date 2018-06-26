using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Web;

namespace LiluTravel.Models
{
    [Table("SubTourImages", Schema = "tour")]
    public class SubTourImage
    {
        [Key]
        [Column("id")]
        public int Id { get; set; }

        [Column("image")]
        public string Image { get; set; }

        [Column("sub_tour_id")]
        public int SubTourId { get; set; }

        [ForeignKey("SubTourId")]
        public virtual SubTour SubTour { get; set; }
    }
}