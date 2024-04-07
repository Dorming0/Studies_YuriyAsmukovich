using HomeWork16.Models;

namespace HomeWork16.Abstractions
{
    public interface IMRSService
    { 
      IEnumerable<MeetingRoomSettings> GetSettings();
        MeetingRoomSettings CreateRoomSettings(MeetingRoomSettings meetingRoom);
        MeetingRoomSettings UpdateRoomSettings(MeetingRoomSettings meetingRoom);
       void DeliteRoomSettings(MeetingRoomSettings meetingRoom);
    }
}
