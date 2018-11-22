using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Text;

namespace Com.Kuswandanu.Learn.ExtCore.ExtensionA.Controllers
{
    public class DefaultController : Controller
    {
        public ActionResult Index()
        {
            return this.View();
        }
    }
}
