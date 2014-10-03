using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Xml.Serialization;

namespace PasskeyCoreSDK.Domain
{
    /// <summary>
    ///     The ot a_ hotel res rq hotel reservations hotel reservation res guest profiles profile info profile customer address.
    /// </summary>
    [XmlType(AnonymousType = true, Namespace = "http://www.opentravel.org/OTA/2002/11")]
    public class ProfileCustomerAddress
    {
        #region Public Properties

        /// <summary>
        ///     Gets or sets the address line.
        /// </summary>
        [XmlElement("AddressLine")]
        public string[] AddressLine { get; set; }

        /// <summary>
        ///     Gets or sets the city name.
        /// </summary>
        public string CityName { get; set; }

        /// <summary>
        ///     Gets or sets the country name.
        /// </summary>
        public ProfileCustomerAddressCountryName CountryName { get; set; }

        /// <summary>
        ///     Gets or sets the postal code.
        /// </summary>
        public string PostalCode { get; set; }

        /// <summary>
        ///     Gets or sets the state prov.
        /// </summary>
        public string StateProv { get; set; }

        #endregion
    }
}
