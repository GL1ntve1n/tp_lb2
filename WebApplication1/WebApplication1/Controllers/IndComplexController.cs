using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using WebApplication1.Models;

namespace WebApplication3.Controllers
{
    public class NirsController : Controller
    {
        private static List<IndComplexModel> records = new List<IndComplexModel>
        {
            new IndComplexModel { id = "1", Name = "Кирилл", Surname = "Карпович", ShiftNumber = "2", DateOfBirth = new DateTime(2003, 09, 07), PhoneNumber = "+7 (960) 373-64-72" },
            new IndComplexModel { id = "2", Name = "Исследование 2", Surname = "Петров Петр", ShiftNumber = "МФТИ", DateOfBirth = new DateTime(2022, 2, 1), PhoneNumber = "+7 (001) 123-24-54" },
            new IndComplexModel { id = "3", Name = "Исследование 3", Surname = "Сидоров Сидор", ShiftNumber = "СПбГУ", DateOfBirth = new DateTime(2022, 3, 1), PhoneNumber = "+7 (254) 748-34-12" }
        };

        // GET: Nirs
        public ActionResult Index()
        {
            return View(records);
        }

        // GET: Nirs/Create
        public ActionResult Create()
        {
            return View();
        }

        // POST: Nirs/Create
        [HttpPost]
        public ActionResult Create(IndComplexModel model)
        {
            if (ModelState.IsValid)
            {
                records.Add(model);
                return RedirectToAction("Index");
            }
            return View(model);
        }

        // GET: Nirs/Delete/5
        public ActionResult Delete(int id)
        {
            var recordToDelete = records[id];
            return View(recordToDelete);
        }

        // POST: Nirs/Delete/5
        [HttpPost]
        public ActionResult Delete(int id, FormCollection collection)
        {
            try
            {
                records.RemoveAt(id);
                return RedirectToAction("Index");
            }
            catch
            {
                return View();
            }
        }

        // GET: Nirs/Edit/5
        public ActionResult Edit(int id)
        {
            var recordToEdit = records[id];
            return View(recordToEdit);
        }

        // POST: Nirs/Edit/5
        [HttpPost]
        public ActionResult Edit(int id, IndComplexModel model)
        {
            if (ModelState.IsValid)
            {
                records[id] = model;
                return RedirectToAction("Index");
            }
            return View(model);
        }



    }
}
