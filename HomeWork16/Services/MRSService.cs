using HomeWork16.Abstractions;
using HomeWork16.Models;
using Microsoft.AspNetCore.Mvc;

namespace HomeWork16.Services
{
    public class MRSService : IMRSService
    {
        private List<MeetingRoomSettings> _meetingSettings;
        public MRSService()
        {
            _meetingSettings = new List<MeetingRoomSettings>(new[]
            {
                new MeetingRoomSettings("Lesson", 15, 6, new TimeSpan(13, 30, 0))
            });
            
        }

        public MeetingRoomSettings CreateRoomSettings(MeetingRoomSettings meetingRoom)
        {
            if (meetingRoom == null)
                throw new ArgumentNullException(nameof(meetingRoom));

            _meetingSettings.Add(new MeetingRoomSettings(meetingRoom.NameRoom, meetingRoom.NumberOfPeople, meetingRoom.PersonAge, meetingRoom.MaxTime));

            return meetingRoom;
        }

        public void DeliteRoomSettings(MeetingRoomSettings meetingRoom)
        {
            if(meetingRoom == null)
                throw new ArgumentNullException(nameof(meetingRoom));

            _meetingSettings.RemoveAll(x=> x.NameRoom == meetingRoom.NameRoom);
           
        }

        public IEnumerable<MeetingRoomSettings> GetSettings()
        {
            return _meetingSettings;
        }

        public MeetingRoomSettings UpdateRoomSettings(MeetingRoomSettings meetingRoom)
        {
            if (meetingRoom == null)
                throw new ArgumentNullException(nameof(meetingRoom));

            return meetingRoom;
        }
    }
}
