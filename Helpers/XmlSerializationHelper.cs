// --------------------------------------------------------------------------------------------------------------------
// <summary>
//   Xml Serialization Helper
// </summary>
// --------------------------------------------------------------------------------------------------------------------

namespace PasskeyCoreSDK.Helpers
{
    using System.IO;
    using System.Xml.Serialization;

    /// <summary>
    /// The xml serialization helper.
    /// </summary>
    public static class XmlSerializationHelper
    {
        #region Public Methods and Operators

        /// <summary>
        /// Deserialize an object from an XML string to type T
        /// </summary>
        /// <param name="xmlText">
        /// The xml text to deserialize to T
        /// </param>
        /// <typeparam name="T">
        /// The type of the object
        /// </typeparam>
        /// <returns>
        /// The <see cref="T"/>.
        /// </returns>
        public static T Deserialize<T>(string xmlText)
        {
            using (var stringReader = new StringReader(xmlText))
            {
                var serializer = new XmlSerializer(typeof(T));
                return (T)serializer.Deserialize(stringReader);
            }
        }

        /// <summary>
        /// Serialize an object to an XML string
        /// </summary>
        /// <param name="dataToSerialize">
        /// The object to serialize to Xml
        /// </param>
        /// <param name="ns">
        /// The Xml Serializer Namespaces
        /// </param>
        /// <typeparam name="T">
        /// Type of the object to serialize
        /// </typeparam>
        /// <returns>
        /// The <see cref="string"/>.
        /// </returns>
        public static string Serialize<T>(T dataToSerialize, XmlSerializerNamespaces ns = null)
        {
            using (var stringwriter = new Utf8StringWriter())
            {
                var serializer = new XmlSerializer(typeof(T));
                serializer.Serialize(stringwriter, dataToSerialize, ns);
                return stringwriter.ToString();
            }
        }

        #endregion
    }
}