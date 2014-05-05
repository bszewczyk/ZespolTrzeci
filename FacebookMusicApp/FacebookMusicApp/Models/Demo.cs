using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.ComponentModel.DataAnnotations;
using System.Data.Entity;

namespace FacebookMusicApp.Models
{
    public class Demo
    {
        public Demo()
        {


        }
        [Key]
        public int IDDemo { get; set; }
        public virtual User User{ get; set; }
        public string media { get; set; }
        public DateTime AddedDate  { get; set; }
    }
}