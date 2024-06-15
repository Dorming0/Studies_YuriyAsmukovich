using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace Entity.Models
{
    [Table("MeetingRooms")]
    public class MeetingRoomModel
    {
        [Key]
        public Guid Id { get; set; }
        public string NameRoom { get; set; } = string.Empty;
        public int NumberOfPeople { get; set; }
        public uint PersonAge { get; set; }
        public TimeSpan MaxTime { get; set; }
        public MeetingRoomModel() { }
        public MeetingRoomModel(Guid id, string nameRoom, int number, uint personAge, TimeSpan time)
        {
            Id = id;
            NameRoom = nameRoom;
            NumberOfPeople = number;
            PersonAge = personAge;
            MaxTime = time;
        }
    }
}
