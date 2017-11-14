using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;

namespace MiddlewareExample.Controllers
{
    public class ExceptionController : Controller
    {
        public IActionResult Index()
        {
            throw new Exception("Woah, what happened");
        }
    }
}