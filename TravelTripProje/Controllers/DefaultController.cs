﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using TravelTripProje.Models;
using TravelTripProje.Models.Siniflar;

namespace TravelTripProje.Controllers
{
    public class DefaultController : Controller
    {
        // GET: Default


       Context c=new Context();

        public ActionResult Index()
        {
           var degerler=c.Blogs.Take(4).ToList();
            return View(degerler);
        }

        public ActionResult About() 
        { 

            return View(); 
        
        }

        public PartialViewResult Partial1 ()
        {

            var degerler = c.Blogs.OrderByDescending(x=>x.ID).Take(3).ToList();

            return PartialView(degerler);
        }
       
        public PartialViewResult Partial3()
        {
            var degerler = c.Blogs.ToList();
            return PartialView(degerler);
        }

        public PartialViewResult Partial4()
        {
            var degerler = c.Blogs.Take(3).ToList();
            return PartialView(degerler);
        }

    }
}