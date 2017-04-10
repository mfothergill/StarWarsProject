using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.ComponentModel.DataAnnotations.Schema;
using System.ComponentModel.DataAnnotations;

namespace WebApplication6.Models
{
    public class Droids
    {
        [Key]
        public string DroidName { get; set; }
        public string DroidClass { get; set; }
        public int Accuracy { get; set; }
        public int MovementRating { get; set; }
        public bool RequiresLevel5ProgrammingAbility { get; set; }
        public string ReviewofDroid { get; set; }

        

    }
}