﻿using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Web;

namespace Blog.Models
{
    public class Upload
    {

        [Key]
        public int Id { get; set; }

        public string Image { get; set; }

        
    }
}