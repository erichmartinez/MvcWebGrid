using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

using MvcWebGrid.Models;

namespace MvcWebGrid.Controllers
{
    public class PersonController : Controller
    {
        // GET: Person
        public ActionResult Index()
        {
            PersonModel model = new PersonModel();
            model.PageSize = 4;

            List<PersonDBHandler> people = PersonDBHandler.GetPersonList();

            if (people != null)
            {
                model.TotalCount = people.Count();
                model.People = people;
            }

            return View(model);
        }
    }
}
