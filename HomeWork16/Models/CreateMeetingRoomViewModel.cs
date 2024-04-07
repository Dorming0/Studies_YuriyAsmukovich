using System.ComponentModel.DataAnnotations;

namespace HomeWork16.Models
{
    public class CreateMeetingRoomViewModel 
    {
        public Guid Id { get; set; }
        [Required (ErrorMessage = "Поле обязательно для заполнения")]
        public string NameRoom { get; set; } = string.Empty;
        [Range(1,100)]
        public int NumberOfPeople { get; set; }
        public int PersonAge { get; set; }
        public TimeSpan MaxTime { get; set; }
        public CreateMeetingRoomViewModel() { }
       

        public CreateMeetingRoomViewModel(string nameRoom, int numberOfPeople, int personAge, TimeSpan time)
        {
            Id = Guid.NewGuid();
            NameRoom = nameRoom;
            NumberOfPeople = numberOfPeople;
            PersonAge = personAge;
            MaxTime = time;
        }
    }
}
