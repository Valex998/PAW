﻿using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Web;

namespace PAW.Models
{
    public class Field
    {
        public int Id { get; set; }

        [Required]
        [Display(Name = "Field")]
        public string FieldName { get; set; }

        [Required]
        [Display(Name = "Description")]
        public string FieldDescription { get; set; }
    }
}