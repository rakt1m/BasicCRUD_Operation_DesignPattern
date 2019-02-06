using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using BasicCRUD_Operation_DesignPattern.BLL.Contracts;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.Rendering;
using Microsoft.EntityFrameworkCore;
using BasicCRUD_Operation_DesignPattern.DbContext.ApplicationDbCOntext;
using BasicCRUD_Operation_DesignPattern.Models.EntityModels;

namespace BasicCRUD_Operation_DesignPattern.Controllers
{
    public class StudentInfoesController : Controller
    {
        private readonly IStudentInfoManager _iStudentInfoManager;
        private readonly IDepartmentManager _iDepartmentManager;

        public StudentInfoesController(IDepartmentManager iDepartmentManager,IStudentInfoManager isStudentInfoManager)
        {
            _iDepartmentManager = iDepartmentManager;
            _iStudentInfoManager = isStudentInfoManager;
        }

        // GET: StudentInfoes
        public IActionResult Index()
        {
            var studentInfo = _iStudentInfoManager.GetAll().ToList();
            return View(studentInfo);
        }

        // GET: StudentInfoes/Details/5
        public IActionResult Details(int? id)
        {
            if (id == null)
            {
                return NotFound();
            }

            var studentInfo = _iStudentInfoManager.GetById(id);
            if (studentInfo == null)
            {
                return NotFound();
            }

            return View(studentInfo);
        }

        // GET: StudentInfoes/Create
        public IActionResult Create()
        {
            ViewData["DepartmentId"] = new SelectList(_iDepartmentManager.GetAll(), "Id", "Name");
            return View();
        }

        // POST: StudentInfoes/Create
        // To protect from overposting attacks, please enable the specific properties you want to bind to, for 
        // more details see http://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public IActionResult Create( StudentInfo studentInfo)
        {
            if (ModelState.IsValid)
            {
                _iStudentInfoManager.Add(studentInfo);
                return RedirectToAction(nameof(Index));
            }
            ViewData["DepartmentId"] = new SelectList(_iDepartmentManager.GetAll(), "Id", "Name",studentInfo.DepartmentId);
            return View(studentInfo);
        }

        // GET: StudentInfoes/Edit/5
        public IActionResult Edit(int? id)
        {
            if (id == null)
            {
                return NotFound();
            }

            var studentInfo = _iStudentInfoManager.GetById(id);
            if (studentInfo == null)
            {
                return NotFound();
            }
            ViewData["DepartmentId"] = new SelectList(_iDepartmentManager.GetAll(), "Id", "Name", studentInfo.DepartmentId);
            return View(studentInfo);
        }

        // POST: StudentInfoes/Edit/5
        // To protect from overposting attacks, please enable the specific properties you want to bind to, for 
        // more details see http://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public IActionResult Edit(int id,StudentInfo studentInfo)
        {
            if (id != studentInfo.Id)
            {
                return NotFound();
            }

            if (ModelState.IsValid)
            {
                try
                {
                   _iStudentInfoManager.Update(studentInfo);
                    
                }
                catch (DbUpdateConcurrencyException)
                {
                    if (!StudentInfoExists(studentInfo.Id))
                    {
                        return NotFound();
                    }
                    else
                    {
                        throw;
                    }
                }
                return RedirectToAction(nameof(Index));
            }
            ViewData["DepartmentId"] = new SelectList(_iDepartmentManager.GetAll(), "Id", "Name", studentInfo.DepartmentId);
            return View(studentInfo);
        }

        // GET: StudentInfoes/Delete/5
        public IActionResult Delete(int? id)
        {
            if (id == null)
            {
                return NotFound();
            }

            var studentInfo = _iStudentInfoManager.GetById(id);
            if (studentInfo == null)
            {
                return NotFound();
            }

            return View(studentInfo);
        }

        // POST: StudentInfoes/Delete/5
        [HttpPost, ActionName("Delete")]
        [ValidateAntiForgeryToken]
        public IActionResult DeleteConfirmed(int id)
        {
            var studentInfo = _iStudentInfoManager.GetById(id);
            _iStudentInfoManager.Remove(studentInfo);
            return RedirectToAction(nameof(Index));
        }

        private bool StudentInfoExists(int id)
        {
            return _iStudentInfoManager.GetAll().Any(e => e.Id == id);
        }
    }
}
