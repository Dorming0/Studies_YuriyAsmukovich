﻿using Entity.Models;
using System.ComponentModel.DataAnnotations;
using System.Configuration;

namespace HomeWork16.Models
{
    public class UpdateMeetingRoomViewModel 
    {
        public Guid Id { get; set; }
        [Required(ErrorMessage = "Поле обязательно к заполнению")]
        public string NameRoom { get; set; } = string.Empty;
        [Range(1, 100, ErrorMessage = "Некорректное значение поля NumberOfPeople")]
        public int NumberOfPeople { get; set; }
        public uint PersonAge { get; set; }
        
        public TimeSpan MaxTime { get; set; }
        public UpdateMeetingRoomViewModel() { }

        public UpdateMeetingRoomViewModel(MeetingRoomModel meetingRoom) 
        { 
            NameRoom = meetingRoom.NameRoom;
            NumberOfPeople = meetingRoom.NumberOfPeople;
            PersonAge = meetingRoom.PersonAge;
            MaxTime = meetingRoom.MaxTime;

        }
       
    }
}
