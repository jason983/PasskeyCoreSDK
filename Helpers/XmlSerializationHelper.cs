using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Xml.Serialization;
using System.IO;

namespace PasskeyCoreSDK.Helpers
{
    public static class XmlSerializationHelper
    {
        public static string Serialize<T>(T dataToSerialize, XmlSerializerNamespaces ns = null)
        {
            try
            {
                using (var stringwriter = new Utf8StringWriter())
                {
                    var serializer = new XmlSerializer(typeof(T));
                    serializer.Serialize(stringwriter, dataToSerialize, ns);
                    return stringwriter.ToString();
                }                
            }
            catch
            {
                throw;
            }
        }

        public static T Deserialize<T>(string xmlText)
        {
            try
            {
                using (var stringReader = new StringReader(xmlText))
                {
                    var serializer = new XmlSerializer(typeof(T));
                    return (T)serializer.Deserialize(stringReader);
                }
            }
            catch
            {
                throw;
            }
        }
    }
}
