using HomeWork16.Models;

namespace HomeWork16.Abstractions
{
    public interface IMRSService
    { 
      IEnumerable<MeetingRoomSettings> GetSettings();
    }
}
