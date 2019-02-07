﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using ClientValidation.Models; 

namespace ClientValidation.Controllers
{
    public class ValidationController : Controller
    {
        //
        // GET: /Validation/
        public ActionResult Index()
        {
            return View();
        }


        [HttpPost]
        public ActionResult Index(Validation model)
        {
            if (ModelState.IsValid)
            {
                //bind the model attributes to send it to view//
                ViewBag.Name = model.Name;
                ViewBag.Phone = model.Phone;
                ViewBag.Email = model.Email;
                ViewBag.Gender = model.Gender; 
                //clear the model once data is submitted// 
                ModelState.Clear();

                TempData["Success Message"] = "data saved successfully";

                return View();


                
            }
            return View(model); 
            
        }
        
	}
}