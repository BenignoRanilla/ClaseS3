using DemoS3.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace DemoS3.Controllers
{
    public class ClienteController : Controller
    {

        public static List<Cliente> empList = new List<Cliente>
        {
            new Cliente
                {
                    ID = 1,
                    nombre = "Renato",
                    fechaRegistro= DateTime.Parse(DateTime.Today.ToString()),
                    edad = 30
                },

                new Cliente
                {
                    ID = 2,
                    nombre = "Patricio",
                    fechaRegistro= DateTime.Parse(DateTime.Today.ToString()),
                    edad = 32
                },
        };

        // GET: Cliente
        private EmpDbContext db = new EmpDbContext();
        public ActionResult Index()
        {
            var Clientes = from e in db.Cliente
                           orderby e.ID
                           select e;

            return View(Clientes);

        }

        // GET: Cliente/Details/5
        public ActionResult Details(int id)
        {
            return View();
        }

        // GET: Cliente/Create
        public ActionResult Create()
        {
            return View();
        }

        // POST: Cliente/Create
        [HttpPost]
        public ActionResult Create(Cliente emp)
        {
            try
            {
                db.Cliente.Add(emp);
                db.SaveChanges();
                return RedirectToAction("Index");
            }
            catch
            {
                return View();
            }
        }

        // GET: Cliente/Edit/5
        public ActionResult Edit(int id)
        {
            var Clientes = db.Cliente.Single(m => m.ID == id);
            return View(Clientes);
        }

        // POST: Cliente/Edit/5
        [HttpPost]
        public ActionResult Edit(int id, FormCollection collection)
        {
            try
            {
                // TODO: Add update logic here

                var Cliente = db.Cliente.Single(m => m.ID == id);
                if (TryUpdateModel(Cliente))
                {
                    db.SaveChanges();
                    return RedirectToAction("Index");
                }
                return View(Cliente);
            }
            catch
            {
                return View();
            }
        }

        // GET: Cliente/Delete/5
        public ActionResult Delete(int id)
        {
            return View();
        }

        // POST: Cliente/Delete/5
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

        [NonAction]
        public List<Cliente> TodosLosClientes()
        {
            return new List<Cliente>
            {
                new Cliente
                {
                    ID = 1,
                    nombre = "Renato",
                    fechaRegistro= DateTime.Parse(DateTime.Today.ToString()),
                    edad = 30
                },

                new Cliente
                {
                    ID = 2,
                    nombre = "Patricio",
                    fechaRegistro= DateTime.Parse(DateTime.Today.ToString()),
                    edad = 32
                }
            };
        }
    }
}
