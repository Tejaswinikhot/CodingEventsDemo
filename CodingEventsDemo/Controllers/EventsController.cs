using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using CodingEventsDemo.Models;
using Microsoft.AspNetCore.Mvc;

// For more information on enabling MVC for empty projects, visit https://go.microsoft.com/fwlink/?LinkID=397860

namespace coding_events_practice.Controllers
{
    public class EventsController : Controller
    {
        static private List<Event> Events = new List<Event>();
        // GET: /<controller>/
        [HttpGet]
        public IActionResult Index()
        {
            
           /* Events.Add("Code With Pride");
            Events.Add("Apple WWDC");
            Events.Add("Strange Loop");*/

            ViewBag.events = Events;
            return View();
        }

        [HttpGet]
        [Route("/Events/Add")]
        public IActionResult Add()
        {
            return View();
        }

        [HttpPost]
        [Route("/Events/Add")]
        public IActionResult NewEvent(string name, string desc ="No Description Available", string contactEmail="No Email")
        {
            Events.Add( new Event(name, desc, contactEmail));

            return Redirect("/Events");
        }
    }
}
