using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace BookStore.Site.Controllers
{
    public class MembersController : Controller
    {
        // GET: Members
        public ActionResult Register()
        {
            return View();
        }
    }
}