using LearningProject.Models;
using LearningProject.Repository;
using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.Logging;
using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Threading.Tasks;

namespace LearningProject.Controllers
{
    public class HomeController : Controller
    {
        private readonly ProjectRepository projectRepository;
        public HomeController(ProjectRepository _projectRepository)
        {
            projectRepository = _projectRepository;
        }
        public IActionResult Index()
        {

            return View();
        }


        public ActionResult InsertProductConfirm(ViewModels.VM_Product vM_Product)
        {
            return View();
        }






        //public ActionResult InsertProductConfirm(string name , int price , string des)
        //{
        //    return View();
        //}
        //public ContentResult ContentResult()
        //{
        //    return Content("");
        //}
    }
}
