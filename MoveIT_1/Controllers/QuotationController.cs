﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace MoveIT_1.Controllers
{
    public class QuotationController : Controller
    {
        // GET: Quotation
        public ActionResult Index()
        {
            return View();
        }

        public ActionResult Submit()
        {
            return View();
        }
    }
}