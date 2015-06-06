using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using WebApplicationDemo.Models;

namespace WebApplicationDemo.Controllers
{
    public class PatientController : Controller
    {
        //
        // GET: /Patient/
        public ActionResult Index()
        {
            return View();
        }

        //
        // GET: /Patient/Details/5
        public ActionResult Details(int id)
        {
            return View();
        }

        public ActionResult View1(Patient patient)
        {
            return View(patient);
        }

        //
        // GET: /Patient/Create
        public ActionResult Create()
        {
            return View();
        }

        //
        // POST: /Patient/Create
        [HttpPost]
        public ActionResult Create(Patient patient)
        {
            try
            {
                var dateOfBirth = DateTime.Now.AddYears(- patient.Age);

                // TODO: Add insert logic here
                var db = new DataAccess.DemoDataContext();
                var id = db.Add_Patient(patient.Name, patient.Phone, patient.Address, dateOfBirth);
                patient.PatientId = id;

                return RedirectToAction("View1", patient);
            }
            catch(Exception ex)
            {
                return Content(ex.Message);
            }
        }

        //
        // GET: /Patient/Edit/5
        public ActionResult Edit(int id)
        {
            //TODO: get it from Db
            var patient = new Patient {PatientId = 11, Name = "moh"};

            return View("Edit",patient);
        }

        //
        // POST: /Patient/Edit/5
        [HttpPost]
        public ActionResult SaveEdit(Patient patient)
        {
            try
            {
                // TODO: Add update logic here

                return RedirectToAction("Index");
            }
            catch
            {
                return View();
            }
        }

        //
        // GET: /Patient/Delete/5
        public ActionResult Delete(int id)
        {
            return View();
        }

        //
        // POST: /Patient/Delete/5
        [HttpPost]
        public ActionResult Delete(int id, FormCollection collection)
        {
            try
            {
                // TODO: Add delete logic here

                return RedirectToAction("Index");
            }
            catch
            {
                return View();
            }
        }
    }
}
