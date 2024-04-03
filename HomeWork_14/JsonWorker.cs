using System.Text.Json;

namespace HomeWork_14
{
    public class JsonWorker
    {
        public static User JsonPars(string filePath)
        {
            string jsonFile = File.ReadAllText(filePath);
            return JsonSerializer.Deserialize<User>(jsonFile);
        }
        public static void JsonCreate(User user, string jsonName)
        {
            string jsonContent = JsonSerializer.Serialize(user);
            File.WriteAllText(jsonName, jsonContent);
        }

    }
}
