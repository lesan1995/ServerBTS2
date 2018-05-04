﻿using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Web;

namespace ServerBTS2.Models
{
    public class NhaMang
    {
        [Key]
        public int IDNhaMang { get; set; }
        [Required(ErrorMessage = "TenNhaMang is required")]
        public string TenNhaMang { get; set; }
        [RegularExpression(@"^.*\.(jpg|jpeg|gif|JPG|png|PNG)$", ErrorMessage = "Image is not valid")]
        public string Image { get; set; }
    }
}