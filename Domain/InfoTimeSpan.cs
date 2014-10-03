﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Xml.Serialization;

namespace PasskeyCoreSDK.Domain
{
    /// <summary>
    ///     The ot a_ hotel res rq hotel reservations hotel reservation res global info time span.
    /// </summary>
    [XmlType(AnonymousType = true, Namespace = "http://www.opentravel.org/OTA/2002/11")]
    public class InfoTimeSpan
    {
        #region Public Properties

        /// <summary>
        ///     Gets or sets the start date window.
        /// </summary>
        public InfoTimeSpanStartDateWindow StartDateWindow { get; set; }

        #endregion
    }
}
