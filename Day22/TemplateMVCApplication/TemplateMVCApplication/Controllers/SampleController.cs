using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using TemplateMVCApplication.Services;

namespace TemplateMVCApplication.Controllers
{
    [Route("Gayathri")]
    public class SampleController : Controller
    {
        private SampleService _service;

        public SampleController(SampleService service)
        {
            _service = service;
        }
        [Route("G3")]
        public string Index()
        {
            return "The value is " + _service.PrintNumber();
        }
    }
}
