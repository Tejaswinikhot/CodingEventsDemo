using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using CodingEventsDemo.Data;
using CodingEventsDemo.Models;
using CodingEventsDemo.ViewModels;
using Microsoft.AspNetCore.Mvc;

// For more information on enabling MVC for empty projects, visit https://go.microsoft.com/fwlink/?LinkID=397860

namespace coding_events_practice.Controllers
{
    public class EventsController : Controller
    {
        //static private List<Event> Events = new List<Event>();
        // GET: /<controller>/
        [HttpGet]
        public IActionResult Index()
        {

            /* Events.Add("Code With Pride");
             Events.Add("Apple WWDC");
             Events.Add("Strange Loop");*/

            //ViewBag.events = EventData.GetAll();

            List<Event> events = new List<Event>(EventData.GetAll());
            return View(events);
        }

        [HttpGet]
        [Route("/Events/Add")]
        public IActionResult Add()
        {
            AddEventViewModel addEventViewModel = new AddEventViewModel();

            return View(addEventViewModel);
        }

        [HttpPost]
        //[Route("/Events/Add")]
        public IActionResult Add(AddEventViewModel addEventViewModel)//Event newEvent)
            //string name, string desc ="No Description Available", string contactEmail="No Email")
        {
            if(ModelState.IsValid)
            {
                Event newEvent = new Event
                {
                    Name = addEventViewModel.Name,
                    Description = addEventViewModel.Description,
                    ContactEmail = addEventViewModel.ContactEmail,
                    Type = addEventViewModel.Type
                };
                EventData.Add(newEvent);
                //new Event(name, desc, contactEmail));

                return Redirect("/Events");
            }
            return View(addEventViewModel);
        }

        [HttpGet]
        public IActionResult Delete ()
        {
            ViewBag.events = EventData.GetAll();
            return View();
        }

        [HttpPost]
        public IActionResult Delete(int[] eventIds)
        {
            foreach(int eventId in eventIds)
            {
                EventData.Remove(eventId);

            }
            return Redirect("/Events");
        }
    }
}
