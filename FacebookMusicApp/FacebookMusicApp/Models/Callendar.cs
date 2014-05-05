using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.ComponentModel.DataAnnotations;
using System.Data.Entity;

namespace FacebookMusicApp.Models
{
    public class Callendar
    {
        public Callendar()
        {

        }
        public virtual User User { get; set; }
        [Key]
        public int DataIdField { get; set; }
        public string DataTextField { get; set; }
        public DateTime DataStartField { get; set; }
        public DateTime DataEndField { get; set; }
    }
}