using Entity.Models;
using HomeWork16.Models;

namespace HomeWork16.Abstractions
{
    public interface IMRSService
    {
        IEnumerable<MeetingRoomModel> GetSettings();
        MeetingRoomModel CreateRoomSettings(MeetingRoomModel meetingRoom);
        MeetingRoomModel UpdateRoomSettings(MeetingRoomModel meetingRoom);
        void DeliteRoomSettings(MeetingRoomModel meetingRoom);
    }
}
