using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.ComponentModel.DataAnnotations;
using System.Data.Entity;

namespace FacebookMusicApp.Models
{
    public class Messages
    {
        public Messages()
        {

        }
        [Key]
        public int IDMessages { get; set; }
        public string content { get; set; }
        public DateTime Data { get; set; }

        public int IDUser { get; set; }
        public virtual ICollection<User>User{ get; set; }
        public virtual ICollection<Advert> Advert { get; set; }
    }
}