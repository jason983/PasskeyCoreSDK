// <summary>
//   The passkey bridge service wrapper.
// </summary>
// --------------------------------------------------------------------------------------------------------------------
namespace PasskeyCoreSDK.PasskeyBridge
{
    using System;
    using System.Xml.Serialization;

    using PasskeyCoreSDK.Domain;
    using PasskeyCoreSDK.Helpers;
    using PasskeyCoreSDK.PasskeyBridgeWebReference;

    /// <summary>
    ///     The passkey bridge service wrapper.
    /// </summary>
    public class PasskeyBridgeServiceWrapper
    {
        #region Constants

        /// <summary>
        /// The passkey web service mode.
        /// </summary>
        private const string PasskeyWebServiceMode = "S";

        /// <summary>
        /// The passkey web service version.
        /// </summary>
        private const string PasskeyWebServiceVersion = "4.00.02";

        #endregion

        #region Fields

        /// <summary>
        ///     The passkey security object.
        /// </summary>
        private readonly PasskeySecurity passkeySecurity;

        /// <summary>
        ///     The Bridge service.
        /// </summary>
        private readonly BridgeServiceService service;

        /// <summary>
        ///     The xml serializer namespaces.
        /// </summary>
        private readonly XmlSerializerNamespaces xmlSerializerNamespaces;

        #endregion

        #region Constructors and Destructors

        /// <summary>
        /// Initializes a new instance of the <see cref="PasskeyBridgeServiceWrapper"/> class.
        /// </summary>
        /// <param name="webserviceUrl">
        /// The web service url.
        /// Training/Certification URL: https://training-api.passkey.com/axis/services/PasskeyBridge
        /// Production URL: https://api.passkey.com/axis/services/PasskeyBridge
        /// </param>
        /// <param name="partnerId">
        /// Your Passkey partner id.
        /// </param>
        /// <param name="userName">
        /// Your Passkey user name.
        /// </param>
        /// <param name="password">
        /// Your Passkey password.
        /// </param>
        public PasskeyBridgeServiceWrapper(string webserviceUrl, uint partnerId, string userName, string password)
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

            this.service = new BridgeServiceService { Url = webserviceUrl };
            this.passkeySecurity = CreatePasskeySecurity(partnerId, userName, password);
            this.xmlSerializerNamespaces = new XmlSerializerNamespaces();
            this.xmlSerializerNamespaces.Add("ota", "http://www.opentravel.org/OTA/2002/11");
        }

        #endregion

        #region Public Methods and Operators

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
        /// <param name="requestData">
        /// The request data.
        /// </param>
        /// <returns>
        /// The <see cref="PasskeyResponse"/>.
        /// </returns>
        public PasskeyResponse Modify(ModifyBridgeRequestData requestData)
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
                                                                  Error = ex.Message
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

        #endregion
    }
}