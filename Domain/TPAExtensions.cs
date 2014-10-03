namespace PasskeyCoreSDK.Domain
{
    using System.Xml.Serialization;

    /// <summary>
    ///     The ot a_ hotel res rq hotel reservations hotel reservation tp a_ extensions.
    /// </summary>
    [XmlType(AnonymousType = true, Namespace = "http://www.opentravel.org/OTA/2002/11")]    
    public class TPAExtensions
    {
        #region Public Properties

        /// <summary>
        ///     Gets or sets the p k_ info.
        /// </summary>
        public TPAExtensionsPKInfo PK_Info { get; set; }

        #endregion
    }
}
