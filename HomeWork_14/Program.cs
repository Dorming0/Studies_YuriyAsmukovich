

using HomeWork_14;

string filePath = Console.ReadLine();
if (string.IsNullOrEmpty(filePath))
    throw new FileNotFoundException("Файл не найден");

User user = JsonWorker.JsonPars(filePath);

string jsonFileName = $"user_{user.FirstName}_{user.LastName}.json";
JsonWorker jsonWorker = new JsonWorker();
jsonWorker.JsonCreate(user, jsonFileName);

string xmlFileName = $"user_{user.FirstName}_{user.LastName}.xml";
XmlWorker xmlWorker = new XmlWorker();
xmlWorker.XmlCreate(user, xmlFileName);
