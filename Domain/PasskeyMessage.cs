using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Xml.Serialization;

namespace PasskeyCoreSDK.Domain
{
    /// <summary>
    ///     The create bridge rq message.
    /// </summary>
    public class PasskeyMessage
    {
        #region Public Properties

        /// <summary>
        ///     Gets or sets the locale.
        /// </summary>
        public string Locale { get; set; }

        /// <summary>
        ///     Gets or sets the mode.
        /// </summary>
        public string Mode { get; set; }

        /// <summary>
        ///     Gets or sets the op.
        /// </summary>
        public string OP { get; set; }

        /// <summary>
        ///     Gets or sets the service.
        /// </summary>
        public string Service { get; set; }

        /// <summary>
        ///     Gets or sets the version.
        /// </summary>
        public string Version { get; set; }

        /// <summary>
        ///     Gets or sets the GUID.
        /// </summary>
        public string GUID { get; set; }

        #endregion
    }
}
