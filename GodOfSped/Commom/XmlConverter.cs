namespace GodOfSped.Commom;

public class XmlConverter
{
    public T Deserializer<T>(string input)
    {
        System.Xml.Serialization.XmlSerializer ser = new(typeof(T));
        using (StringReader sr = new StringReader(input))
        {
            return (T) ser.Deserialize(sr);
        }
    }
}