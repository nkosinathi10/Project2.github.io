using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace OrganisationX.Controllers
{
    public class UserController : Controller
    {
        [Authorize(Roles="User")]
        public IActionResult Index()
        {
            return View();
        }
    }
}
