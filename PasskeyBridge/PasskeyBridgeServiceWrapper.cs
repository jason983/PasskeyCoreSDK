// --------------------------------------------------------------------------------------------------------------------
// <summary>
//   The passkey bridge service wrapper.
// </summary>
// --------------------------------------------------------------------------------------------------------------------
namespace PasskeyCoreSDK.PasskeyBridge
{
    using System;
    using System.Xml.Serialization;

    using PasskeyCoreSDK.Domain;
    using PasskeyCoreSDK.Enums;
    using PasskeyCoreSDK.Helpers;
    using PasskeyCoreSDK.PasskeyBridgeWebReference;

    /// <summary>
    ///     The passkey bridge service wrapper.
    /// </summary>
    public class PasskeyBridgeServiceWrapper
    {
        #region Constants

        /// <summary>
        ///     The passkey web service mode.
        /// </summary>
        private const string PasskeyWebServiceMode = "S";

        /// <summary>
        ///     The passkey web service version.
        /// </summary>
        private const string PasskeyWebServiceVersion = "4.00.02";

        /// <summary>
        ///     The bridge service endpoint.
        /// </summary>
        private const string BridgeServiceEndpoint = "/axis/services/PasskeyBridge";

        /// <summary>
        ///     The production base url.
        /// </summary>
        private const string ProductionWebServiceBaseUrl = "https://api.passkey.com";

        /// <summary>
        ///     The training base url.
        /// </summary>
        private const string TrainingWebServiceBaseUrl = "https://training-api.passkey.com";

        /// <summary>
        /// The QA base url.
        /// </summary>
        private const string QAWebServiceBaseUrl = "https://qa-api.passkey.com";

        /// <summary>
        /// The production get res web redirect endpoint.
        /// </summary>
        private const string ProductionGetResWebRedirectEndpoint = "/RegLink/API";

        /// <summary>
        /// The training get res web redirect endpoint.
        /// </summary>
        private const string TrainingGetResWebRedirectEndpoint = "/RegLink/API";

        /// <summary>
        /// The QA get res web redirect endpoint.
        /// </summary>
        /// <remarks>
        /// The text "httpapi" must be lowercase.
        /// </remarks>
        private const string QAGetResWebRedirectEndpoint = "/httpapi/RegLink";

        #endregion

        #region Fields

        /// <summary>
        /// The web service base url.
        /// </summary>
        private string webServiceBaseUrl;

        /// <summary>
        /// The get for redirect res web url.
        /// </summary>
        private string getForRedirectResWebEndpoint;

        /// <summary>
        ///     The passkey security object.
        /// </summary>
        private PasskeySecurity passkeySecurity;

        /// <summary>
        ///     The Bridge service.
        /// </summary>
        private BridgeServiceService service;

        /// <summary>
        ///     The xml serializer namespaces.
        /// </summary>
        private XmlSerializerNamespaces xmlSerializerNamespaces;
        
        #endregion

        #region Constructors and Destructors

        /// <summary>
        /// Initializes a new instance of the <see cref="PasskeyBridgeServiceWrapper"/> class.
        /// </summary>
        /// <param name="mode">
        /// The mode.
        /// </param>
        /// <param name="partnerId">
        /// The partner id.
        /// </param>
        /// <param name="userName">
        /// The user name.
        /// </param>
        /// <param name="password">
        /// The password.
        /// </param>
        public PasskeyBridgeServiceWrapper(PasskeyMode mode, uint partnerId, string userName, string password)
        {
            this.Init(this.webServiceBaseUrl + BridgeServiceEndpoint, partnerId, userName, password, mode);
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="PasskeyBridgeServiceWrapper"/> class.
        /// </summary>
        /// <param name="webserviceUrl">
        /// The URL to the Passkey Bridge Web Service
        /// </param>
        /// <param name="partnerId">
        /// Your Passkey partner ID.
        /// </param>
        /// <param name="userName">
        /// Your Passkey user name.
        /// </param>
        /// <param name="password">
        /// Your Passkey password.
        /// </param>
        /// <param name="mode">
        /// The mode.
        /// </param>
        public PasskeyBridgeServiceWrapper(string webserviceUrl, uint partnerId, string userName, string password, PasskeyMode mode = PasskeyMode.Production)
        {
            this.Init(webserviceUrl, partnerId, userName, password, mode);
        }

        #endregion

        #region Public Methods and Operators

        /// <summary>
        /// Builds an attendee-specific URL that is used to invoke the GroupMAX Attendee Website
        /// </summary>
        /// <param name="bridgeId">
        /// The bridge id.
        /// </param>
        /// <param name="lastName">
        /// The last name.
        /// </param>
        /// <returns>
        /// The <see cref="string"/>.
        /// </returns>
        public string BuildGetForRedirectResWebUrl(string bridgeId, string lastName)
        {
            PasskeyMessage message = CreatePasskeyMessage("GetForRedirectResWeb", "GetForRedirectResWeb");

            return
                string.Format(
                    "{0}{1}?PartnerID={2}&username={3}&Password={4}&OP={5}&Version={6}&Mode={7}&Destination=02&LastName={8}&BridgeID={9}", 
                    this.webServiceBaseUrl,
                    this.getForRedirectResWebEndpoint,
                    this.passkeySecurity.PartnerID, 
                    this.passkeySecurity.Login.UserName, 
                    this.passkeySecurity.Login.Password, 
                    message.OP, 
                    message.Version, 
                    message.Mode, 
                    lastName, 
                    bridgeId);
        }

        /// <summary>
        /// Cancel Passkey bridge record
        /// </summary>
        /// <param name="requestData">
        /// The request data.
        /// </param>
        /// <returns>
        /// The <see cref="PasskeyResponse"/>.
        /// </returns>
        public PasskeyResponse Cancel(CancelBridgeRequestData requestData)
        {
            if (requestData == null)
            {
                throw new ArgumentNullException("requestData");
            }

            PasskeyResponse passkeyResponse;
            string requestXmlString = string.Empty;
            string responseXmlString = string.Empty;

            try
            {
                var request = new CancelBridgeRequest
                                  {
                                      Security = this.passkeySecurity, 
                                      Message = CreatePasskeyMessage("CancelBridge", "CancelBridge"), 
                                      Data = requestData
                                  };

                requestXmlString = XmlSerializationHelper.Serialize(request, this.xmlSerializerNamespaces);
                responseXmlString = this.service.cancel(requestXmlString);
                passkeyResponse = XmlSerializationHelper.Deserialize<PasskeyResponse>(responseXmlString);
            }
            catch (Exception ex)
            {
                passkeyResponse = CreatePasskeyResponseFromException(ex);
            }

            passkeyResponse.RequestXML = requestXmlString;
            passkeyResponse.ResponseXML = responseXmlString;

            return passkeyResponse;
        }

        /// <summary>
        /// Create Passkey Bridge Record
        /// </summary>
        /// <param name="requestData">
        /// The request data.
        /// </param>
        /// <returns>
        /// The <see cref="PasskeyResponse"/>.
        /// </returns>
        public PasskeyResponse Create(CreateBridgeRequestData requestData)
        {
            if (requestData == null)
            {
                throw new ArgumentNullException("requestData");
            }

            PasskeyResponse passkeyResponse;
            string requestXmlString = string.Empty;
            string responseXmlString = string.Empty;

            try
            {
                var request = new CreateBridgeRequest
                                  {
                                      Security = this.passkeySecurity, 
                                      Message = CreatePasskeyMessage("CreateBridge", "CreateBridge"), 
                                      Data = requestData
                                  };

                requestXmlString = XmlSerializationHelper.Serialize(request, this.xmlSerializerNamespaces);
                responseXmlString = this.service.create(requestXmlString);
                passkeyResponse = XmlSerializationHelper.Deserialize<PasskeyResponse>(responseXmlString);
            }
            catch (Exception ex)
            {
                passkeyResponse = CreatePasskeyResponseFromException(ex);
            }

            passkeyResponse.RequestXML = requestXmlString;
            passkeyResponse.ResponseXML = responseXmlString;

            return passkeyResponse;
        }

        /// <summary>
        /// Get a Passkey Bridge record
        /// </summary>
        /// <param name="requestData">
        /// The request data.
        /// </param>
        /// <returns>
        /// The <see cref="PasskeyResponse"/>.
        /// </returns>
        public PasskeyResponse Get(GetBridgeRequestData requestData)
        {
            if (requestData == null)
            {
                throw new ArgumentNullException("requestData");
            }

            PasskeyResponse passkeyResponse;
            string requestXmlString = string.Empty;
            string responseXmlString = string.Empty;

            try
            {
                var request = new GetBridgeRequest
                                  {
                                      Security = this.passkeySecurity, 
                                      Message = CreatePasskeyMessage("GetBridge", "GetBridge"), 
                                      Data = requestData
                                  };

                requestXmlString = XmlSerializationHelper.Serialize(request, this.xmlSerializerNamespaces);
                responseXmlString = this.service.get(requestXmlString);
                passkeyResponse = XmlSerializationHelper.Deserialize<PasskeyResponse>(responseXmlString);
            }
            catch (Exception ex)
            {
                passkeyResponse = CreatePasskeyResponseFromException(ex);
            }

            passkeyResponse.RequestXML = requestXmlString;
            passkeyResponse.ResponseXML = responseXmlString;

            return passkeyResponse;
        }

        /// <summary>
        /// Modify Passkey Bridge record
        /// </summary>
        /// <param name="bridgeId">
        /// The bridge Id.
        /// </param>
        /// <param name="companyName">
        /// The company Name.
        /// </param>
        /// <param name="requestData">
        /// The request data.
        /// </param>
        /// <returns>
        /// The <see cref="PasskeyResponse"/>.
        /// </returns>
        public PasskeyResponse Modify(string bridgeId, string companyName, ModifyBridgeRequestData requestData)
        {
            if (string.IsNullOrEmpty(bridgeId))
            {
                throw new ArgumentNullException("bridgeId");
            }

            if (requestData == null)
            {
                throw new ArgumentNullException("requestData");
            }

            PasskeyResponse passkeyResponse;
            string requestXmlString = string.Empty;
            string responseXmlString = string.Empty;

            try
            {
                requestData.HotelReservationContainer.HotelReservations.HotelReservation.UniqueId = new UniqueId
                                                                                                        {
                                                                                                            Type = "BRD",
                                                                                                            Id = bridgeId,
                                                                                                            CompanyName = companyName
                                                                                                        };

                var request = new ModifyBridgeRequest
                                  {
                                      Security = this.passkeySecurity, 
                                      Message = CreatePasskeyMessage("ModifyBridge", "ModifyBridge"), 
                                      Data = requestData
                                  };

                requestXmlString = XmlSerializationHelper.Serialize(request, this.xmlSerializerNamespaces);
                responseXmlString = this.service.modify(requestXmlString);
                passkeyResponse = XmlSerializationHelper.Deserialize<PasskeyResponse>(responseXmlString);
            }
            catch (Exception ex)
            {
                passkeyResponse = CreatePasskeyResponseFromException(ex);
            }

            passkeyResponse.RequestXML = requestXmlString;
            passkeyResponse.ResponseXML = responseXmlString;

            return passkeyResponse;
        }

        #endregion

        #region Methods

        /// <summary>
        /// Create passkey message object what holds the version, mode, operation, service, locale, and GUID
        /// </summary>
        /// <param name="op">
        /// The operation
        /// </param>
        /// <param name="service">
        /// The service call
        /// </param>
        /// <param name="locale">
        /// The locale
        /// </param>
        /// <param name="guid">
        /// The GUID
        /// </param>
        /// <returns>
        /// The <see cref="PasskeyMessage"/>.
        /// </returns>
        private static PasskeyMessage CreatePasskeyMessage(
            string op, string service, string locale = "EN_US", string guid = null)
        {
            return new PasskeyMessage
                       {
                           Version = PasskeyWebServiceVersion, 
                           Mode = PasskeyWebServiceMode, 
                           OP = op, 
                           Service = service, 
                           Locale = locale, 
                           GUID = guid
                       };
        }

        /// <summary>
        /// Create a Passkey response from an exception.
        /// </summary>
        /// <param name="ex">
        /// The exception that occurred
        /// </param>
        /// <returns>
        /// The <see cref="PasskeyResponse"/>.
        /// </returns>
        private static PasskeyResponse CreatePasskeyResponseFromException(Exception ex)
        {
            var passkeyResponse = new PasskeyResponse
                                      {
                                          Message =
                                              new ResponseMessage
                                                  {
                                                      Errors =
                                                          new ResponseMessageErrors
                                                              {
                                                                  Error
                                                                      =
                                                                      ex
                                                                      .Message
                                                              }
                                                  }
                                      };
            return passkeyResponse;
        }

        /// <summary>
        /// Create a Passkey security object
        /// </summary>
        /// <param name="partnerId">
        /// Passkey Partner Id
        /// </param>
        /// <param name="userName">
        /// Passkey User Name
        /// </param>
        /// <param name="password">
        /// Passkey Password.
        /// </param>
        /// <returns>
        /// The <see cref="PasskeySecurity"/>.
        /// </returns>
        private static PasskeySecurity CreatePasskeySecurity(uint partnerId, string userName, string password)
        {
            return new PasskeySecurity
                       {
                           Login = new PasskeySecurityLogin { UserName = userName, Password = password }, 
                           PartnerID = partnerId, 
                           Token = " "
                       };
        }

        /// <summary>
        /// Initialization Section
        /// </summary>
        /// <param name="webserviceUrl">
        /// The web service url.
        /// </param>
        /// <param name="partnerId">
        /// The partner id.
        /// </param>
        /// <param name="userName">
        /// The user name.
        /// </param>
        /// <param name="password">
        /// The password.
        /// </param>
        /// <param name="mode">
        /// The mode.
        /// </param>
        /// <exception cref="ArgumentNullException">
        /// WebServiceURL, PartnerId, UserName, Password are required.
        /// </exception>
        private void Init(string webserviceUrl, uint partnerId, string userName, string password, PasskeyMode mode)
        {
            if (string.IsNullOrEmpty(webserviceUrl))
            {
                throw new ArgumentNullException("webserviceUrl");
            }

            if (partnerId == 0)
            {
                throw new ArgumentNullException("partnerId");
            }

            if (string.IsNullOrEmpty(userName))
            {
                throw new ArgumentNullException("userName");
            }

            if (string.IsNullOrEmpty(password))
            {
                throw new ArgumentNullException("password");
            }

            switch (mode)
            {
                case PasskeyMode.Training:
                    this.webServiceBaseUrl = TrainingWebServiceBaseUrl;
                    this.getForRedirectResWebEndpoint = TrainingGetResWebRedirectEndpoint;
                    break;
                case PasskeyMode.QA:
                    this.webServiceBaseUrl = QAWebServiceBaseUrl;
                    this.getForRedirectResWebEndpoint = QAGetResWebRedirectEndpoint;
                    break;
                default:
                    this.webServiceBaseUrl = ProductionWebServiceBaseUrl;
                    this.getForRedirectResWebEndpoint = ProductionGetResWebRedirectEndpoint;
                    break;
            }

            this.service = new BridgeServiceService { Url = webserviceUrl };
            this.passkeySecurity = CreatePasskeySecurity(partnerId, userName, password);
            this.xmlSerializerNamespaces = new XmlSerializerNamespaces();
            this.xmlSerializerNamespaces.Add("ota", "http://www.opentravel.org/OTA/2002/11");
        }

        #endregion
    }
}