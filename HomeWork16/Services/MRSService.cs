using HomeWork16.Abstractions;
using HomeWork16.Models;

namespace HomeWork16.Services
{
    public class MRSService : IMRSService
    {
        private readonly MeetingRoomSettings _meetingSettings;
        public MRSService()
        {
            _meetingSettings = new MeetingRoomSettings
            {
                NumberOfPeople = 10,
                MaxTime = TimeSpan.FromHours(4) + TimeSpan.FromMinutes(55)
            };
        }
        public 
            IEnumerable<MeetingRoomSettings> GetSettings()
        {
            return new[] { _meetingSettings };
        }
    }
}
