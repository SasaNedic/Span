using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Globalization;

using System.Linq;
using System.Web;
using System.Data.Entity;

namespace SpanTest.Models
{
    public class PutniNalogForm
    {
        [Required]
        [Display(Name="Lista putnika")]
        public List<Putnik> Name { get; set; }

        [Required]
        [DataType(DataType.Date)]
        [Display(Name = "Datum početka")]
        [DisplayFormat(ApplyFormatInEditMode = true, DataFormatString = "{0:dd/MM/yyyy}")]
        public DateTime? StartingDay { get; set; }

        [Required]
        [DataType(DataType.Date)]
        [Display(Name = "Datum kraja")]
        [DisplayFormat(ApplyFormatInEditMode = true, DataFormatString = "{0:dd/MM/yyyy}")]
        public DateTime? EndingDay { get; set; }

        public List<string> VehicleDropDownList = new List<string>{
            "Autobus",
            "Automobil",
            "Vlak",
            "Zrakoplov",
        };

        [Required]
        [Display(Name="Prevozno sredstvo")]
        public string Vehicle { get; set; }

        [Required]
        [Display(Name = "Registracija vozila")]
        public string VehicleRegistration { get; set; }
        
        [Required]
        [Display(Name = "Vlasnik vozila")]
        public string VehicleOwner { get; set; }

        [Required]
        [Display(Name = "Razlog dolaska")]
        public string Reason { get; set; }

        [Required]
        [Display(Name = "Relacija putovanja")]
        public string TravelRelation { get; set; }

        [Required]
        [Display(Name = "Broj projekta")]
        public string ProjectNumber { get; set; }

        [Display(Name = "Potreban smještaj")]
        public bool Accommodation{ get; set; }

        [Display(Name = "Datumi noćenja")]
        public List<DateTime?> AccommodationNights { get; set; }

        [Required]
        [DataType(DataType.Date)]
        [Display(Name = "Ulaz u smještaj")]
        [DisplayFormat(ApplyFormatInEditMode = true, DataFormatString = "{0:dd/MM/yyyy}")]
        public DateTime? AccommodationEntry { get; set; }

        [Required]
        [DataType(DataType.Date)]
        [Display(Name = "Izlaz iz smještaj")]
        [DisplayFormat(ApplyFormatInEditMode = true, DataFormatString = "{0:dd/MM/yyyy}")]
        public DateTime? AccommodationExit { get; set; }

        [Display(Name = "Komentar")]
        public string Comment { get; set; }
    }
    public class Putnik
    {
        [Required]
        [Display(Name = "Ime")]
        public string Name { get; set; }

        [Display(Name = "Suvozač")]
        public bool Passenger { get; set; }

        [Display(Name = "Student")]
        public bool Student { get; set; }
    }
    

    public class PutniNalogFormContext : DbContext
    {
        public DbSet<PutniNalogForm> PutniNalozi { get; set; }
    }
}