﻿using Entity.Models;
using HomeWork16.Abstractions;
using HomeWork16.Models;
using Microsoft.AspNetCore.Mvc;

namespace HomeWork16.Services
{
    public class MRSService : IMRSService
    {
        private List<MeetingRoomModel> _meetingSettings;
        public MRSService()
        {
            _meetingSettings = new List<MeetingRoomModel>(new[]
            {
                new MeetingRoomModel()
                {
                    Id = Guid.NewGuid(),
                    NameRoom = "Lesson",
                    PersonAge = 15,
                    NumberOfPeople = 6,
                    MaxTime = new TimeSpan(13,30, 0)
                }
            });

        }

        public MeetingRoomModel CreateRoomSettings(MeetingRoomModel meetingRoom)
        {
            if (meetingRoom == null)
                throw new ArgumentNullException(nameof(meetingRoom));

            _meetingSettings.Add(meetingRoom);

            return meetingRoom;
        }

        public void DeliteRoomSettings(MeetingRoomModel meetingRoom)
        {
            if (meetingRoom == null)
                throw new ArgumentNullException(nameof(meetingRoom));

            _meetingSettings.RemoveAll(x => x.NameRoom == meetingRoom.NameRoom);

        }

        public IEnumerable<MeetingRoomModel> GetSettings()
        {
            return _meetingSettings;
        }

        public MeetingRoomModel UpdateRoomSettings(MeetingRoomModel meetingRoom)
        {
            if (meetingRoom == null)
                throw new ArgumentNullException(nameof(meetingRoom));

            return meetingRoom;
        }
    }
}
