using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using BasicCRUD_Operation_DesignPattern.BLL.Contracts;
using BasicCRUD_Operation_DesignPattern.Models.EntityModels;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;

namespace BasicCRUD_Operation_DesignPattern.Controllers
{
    public class DepartmentController : Controller
    {
        private readonly IDepartmentManager _iDepartmentManager;

        public DepartmentController(IDepartmentManager iDepartmentManager)
        {
            _iDepartmentManager = iDepartmentManager;
        }
        // GET: Department
        public ActionResult Index()
        {
            return View(_iDepartmentManager.GetAll());
        }

        // GET: Department/Details/5
        public ActionResult Details(int? id)
        {
            if (id==null)
            {
                return NotFound();
            }
            var department = _iDepartmentManager.GetById(id);
            if (department == null)
            {
                return NotFound();
            }
            return View();
        }

        // GET: Department/Create
        public ActionResult Create()
        {
            return View();
        }

        // POST: Department/Create
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Create(Department department)
        {
            if(ModelState.IsValid)
            {
                _iDepartmentManager.Add(department);

                return RedirectToAction(nameof(Index));
            }
            
                return View(department);
           
        }

        // GET: Department/Edit/5
        public ActionResult Edit(int? id)
        {
            if (id == null)
            {
                return NotFound();
            }
            var department = _iDepartmentManager.GetById(id);
            if (department == null)
            {
                return NotFound();
            }
            return View(department);
        }

        // POST: Department/Edit/5
        [HttpPost]
        [ValidateAntiForgeryToken]
        public IActionResult Edit(long id, Department department)
        {
            if (id != department.Id)
            {
                return NotFound();
            }

            if (ModelState.IsValid)
            {
                try
                {
                    _iDepartmentManager.Update(department);
                 

                }
                catch (DbUpdateConcurrencyException)
                {
                    if (!DepartmentExists(department.Id))
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
            return View(department);
        }
        

        private bool DepartmentExists(int id)
        {
            return _iDepartmentManager.GetAll().Any(c => c.Id == id);
        }

        // GET: Department/Delete/5
        public ActionResult Delete(int? id)
        {
            if (id == null)
            {
                return NotFound();
            }
            var department = _iDepartmentManager.GetById(id);
            if (department == null)
            {
                return NotFound();
            }
            return View(department);
        }

        // POST: Department/Delete/5
        [HttpPost,ActionName("Delete")]
        [ValidateAntiForgeryToken]
        public ActionResult DeleteConfirmed(int id)
        {

            var department = _iDepartmentManager.GetById(id);  // TODO: Add delete logic here
            _iDepartmentManager.Remove(department);
                return RedirectToAction(nameof(Index));
            
           
        }
    }
}