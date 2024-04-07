using HomeWork16.Abstractions;
using HomeWork16.Models;
using Microsoft.AspNetCore.Mvc;
using Newtonsoft.Json;
using System.Net;

namespace HomeWork16.Controllers
{
  
    public class MeetingRoomController(IMRSService service) : Controller
    {
        private readonly IMRSService _meetingService = service;
      
        public IActionResult Index()
        {           
            var settings = _meetingService.GetSettings();
            return View(settings);
        }
        
        public IActionResult Create()
        {
            return View(new CreateMeetingRoomViewModel());
        }

        [HttpPost]
        public IActionResult Create(CreateMeetingRoomViewModel model)
        {
            if (!ModelState.IsValid)
               return View(model);

            var room = new MeetingRoomSettings(model.NameRoom, model.NumberOfPeople, model.PersonAge, model.MaxTime);

            _meetingService.CreateRoomSettings(room);

            //var json = JsonConvert.SerializeObject(room);

            //System.IO.File.Create("");
            
            return RedirectToAction("Index");
        }
        public IActionResult Edit(Guid id)
        {
            var room = (_meetingService.GetSettings()).FirstOrDefault(x => x.Id == id);
            if (room == null)
                return StatusCode((int)HttpStatusCode.NotFound);
            

            return View( new UpdateMeetingRoomViewModel(room));
        }
        [HttpPost]
        public IActionResult Edit(UpdateMeetingRoomViewModel model)
        {
            if (!ModelState.IsValid)
                return View(model);

            var room = _meetingService.GetSettings().FirstOrDefault(x => x.Id == model.Id);

            if (room is null)
                return StatusCode((int)HttpStatusCode.NotFound);

            room.NameRoom = model.NameRoom;
            room.PersonAge = model.PersonAge;
            room.NumberOfPeople = model.NumberOfPeople;
            room.MaxTime = model.MaxTime;

            _meetingService.UpdateRoomSettings(room);
            return RedirectToAction("Index");
        }

        [HttpGet]
        public IActionResult Delete(Guid id)
        {
            var room = _meetingService.GetSettings().FirstOrDefault(x => x.Id == id);
            if(room is null)
                return StatusCode((int)HttpStatusCode.NotFound);

            _meetingService.DeliteRoomSettings(room);
            return RedirectToAction("Index");
        }
        
        
    }
}
