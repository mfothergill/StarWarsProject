using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.ComponentModel.DataAnnotations.Schema;
using System.ComponentModel.DataAnnotations;

namespace WebApplication6.Models
{
    public class Ships
    {
        [Key]
        public string ShipName { get; set; }
        public string ShipType { get; set; }
        public string MainWeapons { get; set; }
        public string SecondaryWeapons { get; set; }
        public bool EquippedWithShield { get; set; }
        public string ShipReview { get; set; }
    }
}