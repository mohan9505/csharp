﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace WebApplication1.Controllers
{
    public class actionController : Controller
    {
        // GET: action
        public ActionResult Index()
        {
            return View();
        }
    }
}