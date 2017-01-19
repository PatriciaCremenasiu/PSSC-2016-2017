using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using University.Commands;
using University.Reporting;
using University.Exceptions;
using University.Service;
using University.EventHandlers;

namespace University.Controllers.ControllerCqrs
{
    public class HomeController : Controller
    {

        public ActionResult Index()
        {
            ViewBag.Model = ServiceLocator.ReportDatabase.GetItems();
            return View();
        }

        public ActionResult Add()
        {
            return View();
        }

        public ActionResult Delete(Guid id)
        {
            var item = ServiceLocator.ReportDatabase.GetById(id);
            ServiceLocator.CommandBus.Send(new DeleteStudyYearCommand(item.Id, item.Version));
            return RedirectToAction("Index");
        }

        [HttpPost]
        public ActionResult Add(StudyYearDto item)
        {
            ServiceLocator.CommandBus.Send(new CreateStudyYearCommand(Guid.NewGuid(), item._definedSubjects, item.Version));

            return RedirectToAction("Index");
        }
    }
 }
