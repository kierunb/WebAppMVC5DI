using AutoMapper;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using WebAppMVC5DI.Repositories;

namespace WebAppMVC5DI.Controllers
{
    public class HomeController : Controller
    {
        private readonly TestService _testService;
        private readonly IDrugiService _drugiService;
        private readonly ICustomerRepository _customerRepository;
        private readonly IMapper _mapper;

        public HomeController(
            TestService testService,
            IDrugiService drugiService,
            ICustomerRepository customerRepository,
            IMapper mapper)
        {
            _testService = testService;
            _drugiService = drugiService;
            _customerRepository = customerRepository;
            _mapper = mapper;
        }


        public ActionResult Index()
        {
            return View();
        }

        public ActionResult About()
        {
            //ViewBag.Message = _testService.GetCostam();
            //ViewBag.Message = _drugiService.ZrobCos("alala");
            ViewBag.Message = _customerRepository.GetAll();

            return View();
        }

        public ActionResult Contact()
        {
            ViewBag.Message = "Your contact page.";

            return View();
        }
    }
}