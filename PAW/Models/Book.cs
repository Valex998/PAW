using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Web;

namespace PAW.Models
{
    public class Book
    {
        public int Id { get; set; }

        [Display(Name ="Book Title")]
        public string BookTitle { get; set; }

        [Display(Name = "Book content")]
        public string BookContent { get; set; }

        [Display(Name = "Book date added")]
        [DataType(DataType.Date)]
        [DisplayFormat(ApplyFormatInEditMode =true, DataFormatString ="{0:dd/MM/yyyy}")]
        public DateTime BookDateAdded { get; set; }

        [Display(Name = "Reading duration")]
        public string ReadingDuration { get; set; }

        [Display(Name = "Book image")]
        public string BookImage { get; set; }

        public int FieldId { get; set; }

        public virtual Field Field { get; set;  }

    }
}