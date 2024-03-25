namespace HomeWork_14
{
    public class XmlWorker
    {
        public void XmlCreate(User user, string xmlName)
        {
            using (FileStream stream = new FileStream(xmlName, FileMode.Create))
            {
                System.Xml.Serialization.XmlSerializer serializer = new System.Xml.Serialization.XmlSerializer(typeof(User));
                serializer.Serialize(stream, user);
            }
        }
    }
}
