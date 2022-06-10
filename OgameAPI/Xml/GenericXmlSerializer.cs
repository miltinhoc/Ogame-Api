using System;
using System.IO;
using System.Xml.Serialization;

namespace OgameAPI.Xml
{
    internal class GenericXmlSerializer
    {
        public static T Serialize<T>(string xml)
        {
            try
            {
                XmlSerializer serializer = new XmlSerializer(typeof(T));
                StringReader rdr = new StringReader(xml);

                return (T)serializer.Deserialize(rdr);
            }
            catch (Exception)
            {
                throw;
            }
        }
    }
}
