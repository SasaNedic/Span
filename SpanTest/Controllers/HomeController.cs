using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace SpanTest.Controllers
{
    public class HomeController : Controller
    {
        public ActionResult Index()
        {
            ViewBag.Message = "Header";

            return View();
        }

        public ActionResult About()
        {
            return View();
        }

        public ActionResult PutniNalogForm()
        {
            SpanTest.Models.PutniNalogForm Nalog = new SpanTest.Models.PutniNalogForm();
            Nalog.Accommodation = true;
            return View(Nalog);
        }

        [HttpPost]
        public ActionResult Email(SpanTest.Models.PutniNalogForm model)
        {
            using (SpanTest.Models.NalogDBEntryContext db = new SpanTest.Models.NalogDBEntryContext())
            {
                SpanTest.Models.NalogDBEntry Nalog = new SpanTest.Models.NalogDBEntry();

                foreach (SpanTest.Models.Putnik b in model.Name)
                {
                    Nalog.AccommodationNights = "";
                    Nalog.AccommodationPeople = "";
                    if (b.Name != null && b.Name != "")
                    {
                        if (b.Student == false)
                        {
                            Nalog.Name = b.Name;
                            Nalog.Passenger = b.Passenger;
                            Nalog.Student = b.Student;
                            Nalog.StartingDay = model.StartingDay;
                            Nalog.EndingDay = model.EndingDay;
                            Nalog.Vehicle = model.Vehicle;
                            Nalog.VehicleRegistration = model.VehicleRegistration;
                            Nalog.VehicleOwner = model.VehicleOwner;
                            Nalog.Reason = model.Reason;
                            Nalog.TravelRelation = model.TravelRelation;
                            Nalog.Accommodation = model.Accommodation;
                            Nalog.AccommodationEntry = model.AccommodationEntry;
                            Nalog.AccommodationExit = model.AccommodationExit;
                            foreach (DateTime? f in model.AccommodationNights)
                            {
                                if (f != null)
                                {
                                    Nalog.AccommodationNights = Nalog.AccommodationNights + f.ToString() + " ; ";
                                }
                            }
                            foreach (SpanTest.Models.Putnik c in model.Name)
                            {
                                if (c.Name != null && c.Name != "")
                                {
                                    Nalog.AccommodationPeople = Nalog.AccommodationPeople + c.Name;
                                    if (c.Student != false)
                                    {
                                        Nalog.AccommodationPeople = Nalog.AccommodationPeople + " (student)";
                                    }
                                    Nalog.AccommodationPeople = Nalog.AccommodationPeople + " ; ";
                                }
                            }
                            db.NalogDBEntrys.Add(Nalog);
                            db.SaveChanges();
                        }
                    }
                    else
                    {
                    }
                }
            }
            return View();
        }
    }
}
