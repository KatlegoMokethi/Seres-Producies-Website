using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace SeresProducoes.Controllers
{
    public class LabelsController : Controller
    {
        public IActionResult Labels()
        {
            return View();
        }
    }
}
