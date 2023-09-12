using com.DoctorsAppointment.Data;
using com.DoctorsAppointment.Models;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;

namespace com.DoctorsAppointment.Controllers
{
    public class DoctorController : Controller
    {
        private readonly AppDbContext _context;

        public DoctorController(AppDbContext context)
        {
            _context=context;
        }
        // GET: DoctorController
        public ActionResult Index()
        {

            return View(_context.Doctor);
        }

        // GET: DoctorController/Details/5
        public ActionResult Details(int id)
        {

            return View(_context.Doctor.Find(id));
        }

        // GET: DoctorController/Create
        public ActionResult Create()
        {

            return View();
        }

        // POST: DoctorController/Create
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Create(Doctor model)
        {
            try
            {
                _context.Doctor.Add(model);
                _context.SaveChanges();
                return RedirectToAction(nameof(Index));
            }
            catch
            {
                return View();
            }
        }

        // GET: DoctorController/Edit/5
        public ActionResult Edit(int id)
        {

            return View(_context.Doctor.Find(id ));
        }

        // POST: DoctorController/Edit/5
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Edit(int id, Doctor model)
        {
            try
            {
                if (ModelState.IsValid) 
                {
                    _context.Doctor.Update(model); 
                    _context.SaveChanges();
                    return RedirectToAction(nameof(Index));
                }
                return View();
            }

            catch
            {
                return View();
            }
        }

        // GET: DoctorController/Delete/5
        public ActionResult Delete(int id)
        {

            return View(_context.Doctor.Find(id));
        }

        // POST: DoctorController/Delete/5
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Delete(int id, IFormCollection collection)
        {
            try
            {
                if (ModelState.IsValid) 
                {
                    _context.Doctor.Remove(_context.Doctor.Find(id));
                    _context.SaveChanges();
                    return RedirectToAction(nameof(Index));

                }
                return RedirectToAction(nameof(Index));
            }
            catch
            {
                return View();
            }
        }
    }
}
