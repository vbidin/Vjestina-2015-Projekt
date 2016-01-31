using System;
using System.Collections.Generic;
using System.Data;
using System.Data.Entity;
using System.Linq;
using System.Net;
using System.Web;
using System.Web.Mvc;
using SuperSubtitles.Models;
using Microsoft.AspNet.Identity;

namespace SuperSubtitles.Controllers
{
    public class SubtitleController : Controller
    {
        private ApplicationDbContext db = new ApplicationDbContext();

        // GET: Subtitle
        public ActionResult Index(string search)
        {
			var subs = from s in db.Subtitles select s;
			subs = subs.OrderBy(s => s.Date);
			if (!String.IsNullOrEmpty(search))
				subs = subs.Where(s => s.Movie.Contains(search));

			return View(subs.ToList());
        }

        // GET: Subtitle/Details/5
        public ActionResult Details(int? id)
        {
            if (id == null)
            {
                return new HttpStatusCodeResult(HttpStatusCode.BadRequest);
            }
            Subtitle subtitle = db.Subtitles.Find(id);
            if (subtitle == null)
            {
                return HttpNotFound();
            }
            return View(subtitle);
        }

		// GET: Subtitle/Upload
		[Authorize]
		public ActionResult Upload()
        {
            return View();
        }


		// POST: Subtitle/Upload
		// To protect from overposting attacks, please enable the specific properties you want to bind to, for 
		// more details see http://go.microsoft.com/fwlink/?LinkId=317598.
		[HttpPost]
        [ValidateAntiForgeryToken]
		[Authorize]
		public ActionResult Upload([Bind(Include = "SubtitleId,AuthorId,Name,Movie,Date")] Subtitle subtitle, HttpPostedFileBase upload)
        {
            if (ModelState.IsValid)
			{
				if (upload != null && upload.ContentLength > 0)
				{
					string date = DateTime.Now.ToString("dd/MM/yyyy");
					string authorId = User.Identity.GetUserId();

					byte[] file;
					using (var reader = new System.IO.BinaryReader(upload.InputStream))
					{
						file = reader.ReadBytes(upload.ContentLength);
					}

					subtitle.Date = date;
					subtitle.AuthorId = authorId;
					subtitle.File = file;

					db.Subtitles.Add(subtitle);
					db.SaveChanges();
					return RedirectToAction("Success");
				}			
            }

			return RedirectToAction("Failure");
        }

		public ActionResult Success()
		{
			return View();
		}

		public ActionResult Failure()
		{
			return View();
		}

		public FileResult Download(int id)
		{
			Subtitle subtitle = db.Subtitles.First(c => c.SubtitleId == id);
			byte[] file = subtitle.File;
			string name = subtitle.Movie + " - " + subtitle.Name;

			return File(file, System.Net.Mime.MediaTypeNames.Application.Octet, name + ".srt");
		}

		// GET: Subtitle/Edit/5
		public ActionResult Edit(int? id)
        {
            if (id == null)
            {
                return new HttpStatusCodeResult(HttpStatusCode.BadRequest);
            }
            Subtitle subtitle = db.Subtitles.Find(id);
            if (subtitle == null)
            {
                return HttpNotFound();
            }
            return View(subtitle);
        }

        // POST: Subtitle/Edit/5
        // To protect from overposting attacks, please enable the specific properties you want to bind to, for 
        // more details see http://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Edit([Bind(Include = "SubtitleId,AuthorId,Name,Movie,Date")] Subtitle subtitle)
        {
            if (ModelState.IsValid)
            {
                db.Entry(subtitle).State = EntityState.Modified;
                db.SaveChanges();
                return RedirectToAction("Index");
            }
            return View(subtitle);
        }

        // GET: Subtitle/Delete/5
        public ActionResult Delete(int? id)
        {
            if (id == null)
            {
                return new HttpStatusCodeResult(HttpStatusCode.BadRequest);
            }
            Subtitle subtitle = db.Subtitles.Find(id);
            if (subtitle == null)
            {
                return HttpNotFound();
            }
            return View(subtitle);
        }

        // POST: Subtitle/Delete/5
        [HttpPost, ActionName("Delete")]
        [ValidateAntiForgeryToken]
        public ActionResult DeleteConfirmed(int id)
        {
            Subtitle subtitle = db.Subtitles.Find(id);
            db.Subtitles.Remove(subtitle);
            db.SaveChanges();
            return RedirectToAction("Index");
        }

        protected override void Dispose(bool disposing)
        {
            if (disposing)
            {
                db.Dispose();
            }
            base.Dispose(disposing);
        }
    }
}
