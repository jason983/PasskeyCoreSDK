﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Xml.Serialization;

namespace PasskeyCoreSDK.Domain
{
    [XmlType(AnonymousType = true, Namespace = "http://www.passkey.com/apiSchema")]
    [XmlRoot(Namespace = "http://www.passkey.com/apiSchema", IsNullable = false, ElementName = "CancelBridgeRQ")]
    public class CancelBridgeRequest
    {
        #region Public Properties

        /// <summary>
        ///     Gets or sets the data.
        /// </summary>
        public CancelBridgeRequestData Data { get; set; }

        /// <summary>
        ///     Gets or sets the message.
        /// </summary>
        public PasskeyMessage Message { get; set; }

        /// <summary>
        ///     Gets or sets the security.
        /// </summary>
        public PasskeySecurity Security { get; set; }

        #endregion
    }
}