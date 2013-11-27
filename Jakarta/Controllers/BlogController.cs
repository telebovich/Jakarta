using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace Jakarta.Controllers
{
    public class BlogController : Controller
    {
		// public ActionResult Index()
		// {
		// 	ViewData ["Message"] = "Welcome to Blog!";
		//  return View ();
		// }

		public ActionResult Index(int id)
		{
			ViewData ["Message"] = string.Format ("Welcome to {0} Blog!", id);
			return View ();
		}
    }
}
