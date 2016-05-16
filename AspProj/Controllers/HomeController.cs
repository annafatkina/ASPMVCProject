using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using System.Xml;
using System.Xml.Linq;
using System.Data;
using Newtonsoft.Json;


namespace AspProj.Controllers
{
    public class Usr
    {
        public string Id { get; set; }

        public string Name { get; set; }

        public string FirstName { get; set; }

        public string UserName { get; set; }

        public string Mail { get; set; }

    }

    public class HomeController : Controller
    {
        //public static XDocument DataB = XDocument.Load("App_Data/Database.xml");
        // GET: Home
        public ActionResult Index()
        {

            var user = new Usr()
            {
                Id = "404",
                Mail = "chernikov@gmail.com",
                UserName = "rollinx",
                Name = "Andrey",
                FirstName = "Andrey",
            };
            //var jsonusr = JsonConvert.DeserializeObject<Usr>("UserDataBase.json");

/*Попытки намутить json-овскую базу пользователей*/
            return View();
        }

        [AcceptVerbs(HttpVerbs.Get)]
        public ActionResult Login()
        {
            return View();
        }

        [HttpPost]
        public ActionResult Login(string login, string password)
        {

            this.ViewBag.User = login;
            return View("LoginSuccessful");
        }

        // GET: Home/Create
        public ActionResult Create()
        {
            return View();
        }

        // POST: Home/Create
        [HttpPost]
        public ActionResult Create(FormCollection collection)
        {
            try
            {
                // TODO: Add insert logic here

                return RedirectToAction("Index");
            }
            catch
            {
                return View();
            }
        }

        // GET: Home/Edit/5
        public ActionResult Edit(int id)
        {
            return View();
        }

        // POST: Home/Edit/5
        [HttpPost]
        public ActionResult Edit(int id, FormCollection collection)
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

        // GET: Home/Delete/5
        public ActionResult Delete(int id)
        {
            return View();
        }

        // POST: Home/Delete/5
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
