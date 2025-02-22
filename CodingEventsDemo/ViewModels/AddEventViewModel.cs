﻿using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using CodingEventsDemo.Models;
using Microsoft.AspNetCore.Mvc.Rendering;

namespace CodingEventsDemo.ViewModels
{
    public class AddEventViewModel
    {
        [Required(ErrorMessage = "Name is required")]
        [StringLength(50, MinimumLength = 3, ErrorMessage = "Name must be between 3 and 50 chars")]
        public string Name { get; set; }

        [Required(ErrorMessage ="Description is required")]
        [StringLength(500, ErrorMessage = "Desciption is too long. It should be less than 500 chars")]
        public string Description { get; set; }

        [EmailAddress(ErrorMessage = "Email is not valid format")]
        public string ContactEmail { get; set; }

        [Required]
        public EventType Type { get; set; }
        public List<SelectListItem> EventTypes { get; set; } = new List<SelectListItem>
        {
            new SelectListItem(EventType.Conference.ToString(),((int)EventType.Conference).ToString()),
            new SelectListItem(EventType.Meetup.ToString(),((int)EventType.Meetup).ToString()),
            new SelectListItem(EventType.Workshop.ToString(),((int)EventType.Workshop).ToString()),
            new SelectListItem(EventType.Social.ToString(),((int)EventType.Social).ToString())

        };
        //<option value=?> conference<options
    }
}
