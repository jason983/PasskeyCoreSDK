using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Xml.Serialization;

namespace PasskeyCoreSDK.Domain
{
    /// <summary>
    ///     The profiles.
    /// </summary>
    [XmlType(AnonymousType = true, Namespace = "http://www.opentravel.org/OTA/2002/11")]
    public class Profiles
    {
        #region Public Properties

        /// <summary>
        ///     Gets or sets the profile info.
        /// </summary>
        public ProfileInfo ProfileInfo { get; set; }

        #endregion
    }
}
