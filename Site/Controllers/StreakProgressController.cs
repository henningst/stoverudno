﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace Site.Controllers
{
    public class StreakProgressController : Controller
    {
        // GET: StreakProgress
        public ActionResult Index(string p)
        {
            var percent = 0;
            int.TryParse(p, out percent);
            if (percent < 0)
            {
                percent = 0;
            }
            if (percent > 100)
            {
                percent = 100;
            }
            return View(percent);
        }
    }
}