namespace PasskeyCoreSDK.Domain
{
    using System.Xml.Serialization;

    /// <summary>
    ///     The ot a_ hotel res rq hotel reservations hotel reservation res global info guarantee guarantees accepted guarantee accepted payment card address country name.
    /// </summary>
    [XmlType(AnonymousType = true, Namespace = "http://www.opentravel.org/OTA/2002/11")]
    public class PaymentCardAddressCountryName
    {
        #region Public Properties

        /// <summary>
        ///     Gets or sets the code.
        /// </summary>
        [XmlAttribute]
        public string Code { get; set; }

        /// <summary>
        ///     Gets or sets the value.
        /// </summary>
        [XmlText]
        public string Value { get; set; }

        #endregion
    }
}
