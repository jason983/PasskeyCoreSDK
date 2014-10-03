namespace PasskeyCoreSDK.Domain
{
    using System.Xml.Serialization;

    /// <summary>
    ///     The ot a_ hotel res rq hotel reservations hotel reservation tp a_ extensions p k_ info bill phone.
    /// </summary>
    [XmlType(AnonymousType = true, Namespace = "http://www.opentravel.org/OTA/2002/11")]
    public class BillingPhoneNumber
    {
        #region Public Properties

        /// <summary>
        ///     Gets or sets the phone number.
        /// </summary>
        [XmlAttribute]
        public ulong PhoneNumber { get; set; }

        #endregion
    }
}
