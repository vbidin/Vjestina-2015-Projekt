using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace SuperSubtitles.Controllers
{
    public class SubtitlesController : Controller
    {
        // GET: Subtitles/Search
        public ActionResult Search()
        {
            return View();
        }

		// GET: Subtitles/Upload
		public ActionResult Upload()
		{
			return View();
		}
    }
}