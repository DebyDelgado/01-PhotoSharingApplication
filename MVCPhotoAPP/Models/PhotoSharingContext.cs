﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Data.Entity;

namespace MVCPhotoAPP.Models
{
    public class PhotoSharingContext : DbContext
    {
        public PhotoSharingContext(): base("PhotoSharingDB") { }
        public DbSet<Photo> Photos {get; set;}
        public DbSet<Comment> Comments { get; set; }

    }
}