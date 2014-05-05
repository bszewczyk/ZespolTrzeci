using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.ComponentModel.DataAnnotations;
using System.Data.Entity;

namespace FacebookMusicApp.Models
{
    public class User
    {
        public User()
        {

        }
        [Key]
        public int ID { get; set; }
        public string NameAndSurname { get; set; }
        public string Email { get; set; }
        public virtual ICollection<Rate> Rate { get; set; }
        public virtual ICollection<Messages> Messages { get; set; }
        public virtual ICollection<Advert> Advert { get; set; }
        public virtual ICollection<Demo> Demo { get; set; }
        public virtual ICollection<Comment> Comment { get; set; }
        public virtual Callendar Callendar { get; set; }


}
}