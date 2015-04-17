﻿using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Globalization;

using System.Linq;
using System.Web;
using System.Data.Entity;

namespace SpanTest.Models
{
    public class PutniNalog
    {
        [Required]
        [Display(Name="Lista putnika")]
        public List<Putnik> Name { get; set; }

        [Required]
        [Display(Name = "Datum početka")]
        [DisplayFormat(ApplyFormatInEditMode = true, DataFormatString = "{dd/MM/yyyy}")]
        public string StartingDay { get; set; }

        [Required]
        [Display(Name = "Datum kraja")]
        [DisplayFormat(ApplyFormatInEditMode = true, DataFormatString = "{dd/MM/yyyy}")]
        public string EndingDay { get; set; }

        public List<string> VehicleDropDownList = new List<string>{
            "Autobus",
            "Automobil",
            "Vlak",
            "Zrakoplov",
        };

        [Required]
        [Display(Name="Prevozno sredstvo")]
        public string Vehicle { get; set; }

        [Display(Name = "Registracija vozila")]
        public string VehicleRegistration { get; set; }

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
        public int ProjectNumber { get; set; }

        [Display(Name = "Potreban smještaj")]
        public bool Accommodation{ get; set; }

        [Display(Name = "Datumi noćenja")]
        public List<DateTime> AccommodationNights { get; set; } 

        [Display(Name = "Ulaz u smještaj")]
        public string AccommodationEntry { get; set; }

        [Display(Name = "Izlaz iz smještaj")]
        public string AccommodationExit { get; set; }

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
    

    public class PutniNalogContext : DbContext
    {
        public DbSet<PutniNalog> PutniNalozi { get; set; }
    }
}