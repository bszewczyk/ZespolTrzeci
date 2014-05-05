using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.ComponentModel.DataAnnotations;
using System.Data.Entity;

namespace FacebookMusicApp.Models
{
    public class Advert
    {public Advert()
        {

        }
        [Key]
        public int IDAdvert { get; set; }
        public virtual User User { get; set; }
        public string Content { get; set; }
        public DateTime DataStart { get; set; }
        public DateTime DataEnd { get; set; }
        public string Subject { get; set; }





    }
}