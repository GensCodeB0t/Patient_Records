using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using System.Text.Encodings.Web;

namespace Patient_Records.Controllers
{
    public class PatientController : Controller
    {
        public IActionResult Index()
        {
            return View();
        }

        public IActionResult Details(int id, string name)
        {
            ViewData["PatientId"] = id;
            ViewData["PatientName"] = name;
            return View();
        }
    }
}