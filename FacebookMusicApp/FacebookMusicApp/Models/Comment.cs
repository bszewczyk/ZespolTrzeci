using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.ComponentModel.DataAnnotations;
using System.Data.Entity;
namespace FacebookMusicApp.Models
{
    public class Comment
    {
        public Comment()
        {

        }
        [Key]
        public int IDComment { get; set; }
        public virtual User UserAdd  { get; set; }
        public virtual User UserRec { get; set; }
        public string Content { get; set; }
        public DateTime Date { get; set; }
       
    }
}