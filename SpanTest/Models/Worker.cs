using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Globalization;

using System.Linq;
using System.Web;
using System.Data.Entity;

namespace SpanTest.Models
{
    public class Worker
    {
        [Required]
        [Key]
        public int ID { get; set; }

        [Required]
        [Display(Name = "Ime")]
        public string FirstName { get; set; }

        [Required]
        [Display(Name = "Prezime")]
        public string LastName { get; set; }

        [Required]
        [DataType(DataType.Date)]
        [Display(Name = "Datum rođenja")]
        [DisplayFormat(ApplyFormatInEditMode = true, DataFormatString = "{0:dd/MM/yyyy}")]
        public DateTime Birthday { get; set; }
    }
    public class WorkerContext : DbContext
    {
        public DbSet<Worker> Workers { get; set; }
    }
}