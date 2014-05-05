using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.ComponentModel.DataAnnotations;
using System.Data.Entity;

namespace FacebookMusicApp.Models
{
    public class Rate
    {
        public Rate()
        {

        }
        public int IDRate { get; set; }
        [Key]
        public int ID { get; set; }
        public int RateValue { get; set; }
        public virtual User User { get; set; }
    }
}