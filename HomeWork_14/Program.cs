using HomeWork_14;

string filePath = Console.ReadLine();
if (string.IsNullOrEmpty(filePath))
    throw new FileNotFoundException("Файл не найден");

User user = JsonWorker.JsonPars(filePath);

string jsonFileName = $"user_{user.FirstName}_{user.LastName}.json";
JsonWorker.JsonCreate(user, jsonFileName);

string xmlFileName = $"user_{user.FirstName}_{user.LastName}.xml";
XmlWorker.XmlCreate(user, xmlFileName);
