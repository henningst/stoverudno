using System;
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
            var goal = new DateTime(2016, 05, 05);
            var daysLeft = goal.Subtract(DateTime.Today).Days;
            var percent = (int)((50-daysLeft)/(double)50*100);

            if (!string.IsNullOrEmpty(p))
            {
                int.TryParse(p, out percent);
                if (percent < 0)
                {
                    percent = 0;
                }
                if (percent > 100)
                {
                    percent = 100;
                }
            }
            return View(percent);
        }
    }
}
