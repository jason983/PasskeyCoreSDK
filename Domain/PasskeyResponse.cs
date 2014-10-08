// --------------------------------------------------------------------------------------------------------------------
// <summary>
//   The passkey response and its related classes
// </summary>
// --------------------------------------------------------------------------------------------------------------------

namespace PasskeyCoreSDK.Domain
{
    using System.Xml.Serialization;

    /// <summary>
    /// The passkey response.
    /// </summary>
    [XmlType(AnonymousType = true, Namespace = "http://www.passkey.com/apiSchema")]
    [XmlRoot(Namespace = "http://www.passkey.com/apiSchema", IsNullable = false, ElementName = "PasskeyRS")]
    public class PasskeyResponse
    {
        #region Public Properties

        /// <summary>
        /// Gets or sets the data.
        /// </summary>
        public ResponseData Data { get; set; }

        /// <summary>
        /// Gets or sets the message.
        /// </summary>
        public ResponseMessage Message { get; set; }

        /// <summary>
        /// Gets or sets the request xml.
        /// </summary>
        public string RequestXML { get; set; }

        /// <summary>
        /// Gets or sets the response xml.
        /// </summary>
        public string ResponseXML { get; set; }

        #endregion
    }

    /// <summary>
    /// The response message.
    /// </summary>
    [XmlType(AnonymousType = true, Namespace = "http://www.passkey.com/apiSchema", TypeName = "PasskeyRS")]
    public class ResponseMessage
    {
        #region Public Properties

        /// <summary>
        /// Gets or sets the errors.
        /// </summary>
        public ResponseMessageErrors Errors { get; set; }

        /// <summary>
        /// Gets or sets the guid.
        /// </summary>
        [XmlAttribute]
        public string GUID { get; set; }

        /// <summary>
        /// Gets or sets the status.
        /// </summary>
        public ResponseMessageStatus Status { get; set; }

        #endregion
    }

    /// <summary>
    /// The response message status.
    /// </summary>
    [XmlType(AnonymousType = true, Namespace = "http://www.passkey.com/apiSchema")]
    public class ResponseMessageStatus
    {
        #region Public Properties

        /// <summary>
        /// Gets or sets the id.
        /// </summary>
        [XmlAttribute]
        public byte ID { get; set; }

        /// <summary>
        /// Gets or sets the value.
        /// </summary>
        [XmlText]
        public string Value { get; set; }

        #endregion
    }

    /// <summary>
    /// The response data.
    /// </summary>
    [XmlType(AnonymousType = true, Namespace = "http://www.passkey.com/apiSchema")]
    public class ResponseData
    {
        #region Public Properties

        /// <summary>
        /// Gets or sets the response hotel reservation container.
        /// </summary>
        [XmlElement(Namespace = "http://www.opentravel.org/OTA/2002/11", ElementName = "OTA_HotelResRS")]
        public ResponseHotelReservationContainer ResponseHotelReservationContainer { get; set; }

        #endregion
    }

    /// <summary>
    /// The response hotel reservation container.
    /// </summary>
    [XmlType(AnonymousType = true, Namespace = "http://www.opentravel.org/OTA/2002/11")]
    [XmlRoot(Namespace = "http://www.opentravel.org/OTA/2002/11", IsNullable = false)]
    public class ResponseHotelReservationContainer
    {
        #region Public Properties

        /// <summary>
        /// Gets or sets the hotel reservations.
        /// </summary>
        public ResponseHotelReservations HotelReservations { get; set; }

        #endregion
    }

    /// <summary>
    /// The response hotel reservations.
    /// </summary>
    [XmlType(AnonymousType = true, Namespace = "http://www.opentravel.org/OTA/2002/11")]
    public class ResponseHotelReservations
    {
        #region Public Properties

        /// <summary>
        /// Gets or sets the hotel reservation.
        /// </summary>
        public ResponseHotelReservation HotelReservation { get; set; }

        #endregion
    }

    /// <summary>
    /// The response hotel reservation.
    /// </summary>
    [XmlType(AnonymousType = true, Namespace = "http://www.opentravel.org/OTA/2002/11")]
    public class ResponseHotelReservation
    {
        #region Public Properties

        /// <summary>
        /// Gets or sets the unique id.
        /// </summary>
        public ResponseBridgeId UniqueId { get; set; }

        #endregion
    }

    /// <summary>
    /// The response bridge id.
    /// </summary>
    [XmlType(AnonymousType = true, Namespace = "http://www.opentravel.org/OTA/2002/11")]
    public class ResponseBridgeId
    {
        #region Public Properties

        /// <summary>
        /// Gets or sets the id.
        /// </summary>
        [XmlAttribute]
        public string Id { get; set; }

        /// <summary>
        /// Gets or sets the type.
        /// </summary>
        [XmlAttribute]
        public string Type { get; set; }

        #endregion
    }

    /// <summary>
    /// The response message errors.
    /// </summary>
    [XmlType(AnonymousType = true, Namespace = "http://www.passkey.com/apiSchema")]
    public class ResponseMessageErrors
    {
        #region Public Properties

        /// <summary>
        /// Gets or sets the error.
        /// </summary>
        public string Error { get; set; }

        #endregion
    }
}