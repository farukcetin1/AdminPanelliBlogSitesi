﻿using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using System.Web;

namespace KisiselSayfa.Models.Classes
{
    public class Context : DbContext
    {
        public DbSet<Admin> Admins { get; set; }
        public DbSet<MainPage> MainPages { get; set; }
        public DbSet<Icons> Iconses { get; set; }

    }
}