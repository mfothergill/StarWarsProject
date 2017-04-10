using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace WebApplication6.Models
{
    public class LightSabers
    {
         [Key]
        public bool AvailableForDarksideOnly { get; set; }
        public string SaberType { get; set; }
        public string SaberColor { get; set; }
        public int SaberLength { get; set; }
        public string LightSaberReview { get; set; }

        
        
    }
}