using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Web;

namespace KisiselSayfa.Models.Classes
{
    public class Icons
    {
        [Key]
        public int id { get; set; }
        public string icon { get; set; }
        public string link { get; set; }
    }
}