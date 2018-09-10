using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Patient_Records.Services;

namespace Patient_Records.Controllers
{
    public class HospitalController : Controller
    {
        public IApptService ApptService { get; set; }

        public HospitalController(IApptService apptService)
        {
            ApptService = apptService;
        }

        public IActionResult ActionMethod([FromServices]IApptService apptService)
        {
            ViewData["Message"] = "Scheduled: " + apptService.ScheduleAppt();
            return View();
        }

        public string ProcessAppointment()
        {
            bool isSuccess = ApptService.ScheduleAppt();
            if (isSuccess)
                return "Success";
            else
                return "Failed";

        }

        public IActionResult Index()
        {
            return View();
        }
    }
}