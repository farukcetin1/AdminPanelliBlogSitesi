﻿using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Web;

namespace KisiselSayfa.Models.Classes
{
    public class MainPage
    {
        [Key]
        public int id { get; set; }
        public string profil { get; set; }
        public string isim { get; set; }
        public string unvan { get; set; }
        public string aciklama { get; set; }
        public string iletisim { get; set; }
    }
}