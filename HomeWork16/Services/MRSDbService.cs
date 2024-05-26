using Entity;
using Entity.Models;
using HomeWork16.Abstractions;
using HomeWork16.Models;

namespace HomeWork16.Services
{
    public class MRSDbService : IMRSService
    {
        private readonly RoomDbContext _roomDbContext;

        public MRSDbService(RoomDbContext roomDbContext)
        {
            _roomDbContext = roomDbContext;
        }

        public MeetingRoomModel CreateRoomSettings(MeetingRoomModel meetingRoom)
        {
            if (meetingRoom == null)
                throw new ArgumentNullException(nameof(meetingRoom));

            _roomDbContext.Add(meetingRoom);
            _roomDbContext.SaveChanges();
            return meetingRoom;
        }

        public void DeliteRoomSettings(MeetingRoomModel meetingRoom)
        {
            if (meetingRoom == null)
                throw new ArgumentNullException(nameof(meetingRoom));

            var removeRoom = _roomDbContext.Set<MeetingRoomModel>().Find(new object[] { meetingRoom.Id });

            if (removeRoom != null)
            {
                _roomDbContext.Entry(removeRoom).State = Microsoft.EntityFrameworkCore.EntityState.Deleted;
                _roomDbContext.SaveChanges();
            }
        }

        public IEnumerable<MeetingRoomModel> GetSettings()
        {
            return _roomDbContext.MeetingRooms.ToList();
        }

        public MeetingRoomModel UpdateRoomSettings(MeetingRoomModel meetingRoom)
        {
            if (meetingRoom == null)
                throw new ArgumentNullException(nameof(meetingRoom));

            _roomDbContext.Update(meetingRoom);

            _roomDbContext.SaveChanges();
            return meetingRoom;
        }
    }
}
