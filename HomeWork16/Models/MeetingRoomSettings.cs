using System.CodeDom;

namespace HomeWork16.Models
{
    public class MeetingRoomSettings
    {
        public Guid Id { get; set; }
        public string NameRoom { get; set; } = string.Empty;
        public int NumberOfPeople { get; set; }
        public uint PersonAge { get; set; }
        public TimeSpan MaxTime { get; set; }
        public MeetingRoomSettings() 
        { 
            Id = Guid.NewGuid();
        }
        public MeetingRoomSettings(string nameRoom, int numberOfPeople, uint personAge, TimeSpan time)
        {
            Id = Guid.NewGuid();
            NameRoom = nameRoom;
            NumberOfPeople = numberOfPeople;
            PersonAge = personAge;
            MaxTime = time;
        }
    }
}
