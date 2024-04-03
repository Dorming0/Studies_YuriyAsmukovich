using HomeWork16.Abstractions;
using Microsoft.AspNetCore.Mvc;

namespace HomeWork16.Controllers
{
  
    public class MeetingRoomController(IMRSService service) : Controller
    {
        private readonly IMRSService _meetingService = service;
        public IActionResult Index()
        {            var settings = _meetingService.GetSettings();
            return View(settings);
        }
    }
}
