using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;

namespace BasicCRUD_Operation_DesignPattern.Controllers
{
    public class StudentInfoController : Controller
    {
        // GET: StudentInfo
        public ActionResult Index()
        {
            return View();
        }

        // GET: StudentInfo/Details/5
        public ActionResult Details(int id)
        {
            return View();
        }

        // GET: StudentInfo/Create
        public ActionResult Create()
        {
            return View();
        }

        // POST: StudentInfo/Create
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Create(IFormCollection collection)
        {
            try
            {
                // TODO: Add insert logic here

                return RedirectToAction(nameof(Index));
            }
            catch
            {
                return View();
            }
        }

        // GET: StudentInfo/Edit/5
        public ActionResult Edit(int id)
        {
            return View();
        }

        // POST: StudentInfo/Edit/5
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Edit(int id, IFormCollection collection)
        {
            try
            {
                // TODO: Add update logic here

                return RedirectToAction(nameof(Index));
            }
            catch
            {
                return View();
            }
        }

        // GET: StudentInfo/Delete/5
        public ActionResult Delete(int id)
        {
            return View();
        }

        // POST: StudentInfo/Delete/5
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Delete(int id, IFormCollection collection)
        {
            try
            {
                // TODO: Add delete logic here

                return RedirectToAction(nameof(Index));
            }
            catch
            {
                return View();
            }
        }
    }
}