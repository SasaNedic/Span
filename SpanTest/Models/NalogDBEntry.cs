using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Globalization;

using System.Linq;
using System.Web;
using System.Data.Entity;

namespace SpanTest.Models
{
    public class NalogDBEntry
    {
        [Required]
        [Key]
        public int ID { get; set; }

        [Display(Name = "Ime osobe")]
        public string Name { get; set; }

        [Display(Name = "Suvozač")]
        public bool Passenger { get; set; }

        [Display(Name = "Student")]
        public bool Student { get; set; }

        [DataType(DataType.Date)]
        [Display(Name = "Datum početka")]
        [DisplayFormat(ApplyFormatInEditMode = true, DataFormatString = "{0:dd/MM/yyyy}")]
        public DateTime StartingDay { get; set; }

        [DataType(DataType.Date)]
        [Display(Name = "Datum kraja")]
        [DisplayFormat(ApplyFormatInEditMode = true, DataFormatString = "{0:dd/MM/yyyy}")]
        public DateTime EndingDay { get; set; }

        [Display(Name = "Prevozno sredstvo")]
        public string Vehicle { get; set; }

        [Display(Name = "Registracija vozila")]
        public string VehicleRegistration { get; set; }

        [Display(Name = "Vlasnik vozila")]
        public string VehicleOwner { get; set; }

        [Display(Name = "Razlog dolaska")]
        public string Reason { get; set; }

        [Display(Name = "Relacija putovanja")]
        public string TravelRelation { get; set; }

        [Display(Name = "Broj projekta")]
        public string ProjectNumber { get; set; }

        [Display(Name = "Potreban smještaj")]
        public bool Accommodation { get; set; }

        [Display(Name = "Datumi noćenja")]
        public string AccommodationNights { get; set; }

        [DataType(DataType.Date)]
        [Display(Name = "Ulaz u smještaj")]
        [DisplayFormat(ApplyFormatInEditMode = true, DataFormatString = "{0:dd/MM/yyyy}")]
        public DateTime? AccommodationEntry { get; set; }

        [DataType(DataType.Date)]
        [Display(Name = "Izlaz iz smještaj")]
        [DisplayFormat(ApplyFormatInEditMode = true, DataFormatString = "{0:dd/MM/yyyy}")]
        public DateTime? AccommodationExit { get; set; }

        [Display(Name = "Komentar")]
        public string Comment { get; set; }

        [Display(Name="Imena ljudi za koje treba smještaj")]
        public string AccommodationPeople { get; set; }
    }
    public class NalogDBEntryContext : DbContext
    {
        public DbSet<NalogDBEntry> NalogDBEntrys { get; set; }
    }
}