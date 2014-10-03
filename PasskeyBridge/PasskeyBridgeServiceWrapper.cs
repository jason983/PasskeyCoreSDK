using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Xml.Serialization;
using PasskeyCoreSDK.Domain;
using PasskeyCoreSDK.Helpers;
using PasskeyCoreSDK.PasskeyBridgeWebReference;

namespace PasskeyCoreSDK.PasskeyBridge
{
    public class PasskeyBridgeServiceWrapper
    {
        private BridgeServiceService service;
        private PasskeySecurity passkeySecurity;

        public PasskeyBridgeServiceWrapper(string webserviceUrl, uint partnerId, string userName, string password)
        {
            if (!string.IsNullOrEmpty(webserviceUrl))
            {
                this.service = new BridgeServiceService();
                this.service.Url = webserviceUrl;
            }

            this.passkeySecurity = CreatePasskeySecurity(partnerId, userName, password);
        }

        public PasskeyResponse Get(GetBridgeRequestData requestData)
        {
            PasskeyResponse passkeyResponse;
            var requestXmlString = string.Empty;
            var responseXmlString = string.Empty;

            try
            {
                var request = new GetBridgeRequest
                {
                    Security = passkeySecurity,
                    Message = CreatePasskeyMessage("GetBridge", "GetBridge"),
                    Data = requestData
                };

                XmlSerializerNamespaces ns = new XmlSerializerNamespaces();
                ns.Add("ota", "http://www.opentravel.org/OTA/2002/11");

                requestXmlString = XmlSerializationHelper.Serialize(request, ns);
                responseXmlString = this.service.get(requestXmlString);
                passkeyResponse = XmlSerializationHelper.Deserialize<PasskeyResponse>(responseXmlString);
            }
            catch (Exception ex)
            {
                passkeyResponse = new PasskeyResponse
                {
                    Message = new ResponseMessage
                    {
                        Errors = new ResponseMessageErrors
                        {
                            Error = ex.Message
                        }
                    }
                };
            }

            passkeyResponse.RequestXML = requestXmlString;
            passkeyResponse.ResponseXML = responseXmlString;

            return passkeyResponse;
        }

        public PasskeyResponse Create(CreateBridgeRequestData requestData)
        {            
            PasskeyResponse passkeyResponse;
            var requestXmlString = string.Empty;
            var responseXmlString = string.Empty;

            try
            {
                var request = new CreateBridgeRequest
                {
                    Security = passkeySecurity,
                    Message = CreatePasskeyMessage("CreateBridge", "CreateBridge"),
                    Data = requestData
                };

                XmlSerializerNamespaces ns = new XmlSerializerNamespaces();
                ns.Add("ota", "http://www.opentravel.org/OTA/2002/11");

                requestXmlString = XmlSerializationHelper.Serialize(request, ns);
                responseXmlString = this.service.create(requestXmlString);
                passkeyResponse = XmlSerializationHelper.Deserialize<PasskeyResponse>(responseXmlString);
            }
            catch (Exception ex)
            {
                passkeyResponse = new PasskeyResponse
                    {
                        Message = new ResponseMessage
                        {
                            Errors = new ResponseMessageErrors
                            {
                                Error = ex.Message
                            }
                        }
                    };
            }

            passkeyResponse.RequestXML = requestXmlString;
            passkeyResponse.ResponseXML = responseXmlString;

            return passkeyResponse;
        }

        public PasskeyResponse Modify(ModifyBridgeRequestData requestData)
        {
            PasskeyResponse passkeyResponse;
            var requestXmlString = string.Empty;
            var responseXmlString = string.Empty;

            try
            {
                var request = new ModifyBridgeRequest
                {
                    Security = passkeySecurity,
                    Message = CreatePasskeyMessage("ModifyBridge", "ModifyBridge"),
                    Data = requestData
                };

                requestXmlString = XmlSerializationHelper.Serialize(request);
                responseXmlString = this.service.modify(requestXmlString);
                passkeyResponse = XmlSerializationHelper.Deserialize<PasskeyResponse>(responseXmlString);
            }
            catch (Exception ex)
            {
                passkeyResponse = new PasskeyResponse
                {
                    Message = new ResponseMessage
                    {
                        Errors = new ResponseMessageErrors
                        {
                            Error = ex.Message
                        }
                    }
                };
            }

            passkeyResponse.RequestXML = requestXmlString;
            passkeyResponse.ResponseXML = responseXmlString;

            return passkeyResponse;
        }

        public PasskeyResponse Cancel(CancelBridgeRequestData requestData)
        {
            PasskeyResponse passkeyResponse;
            var requestXmlString = string.Empty;
            var responseXmlString = string.Empty;

            try
            {
                var request = new CancelBridgeRequest
                {
                    Security = passkeySecurity,
                    Message = CreatePasskeyMessage("CancelBridge", "CancelBridge"),
                    Data = requestData
                };

                XmlSerializerNamespaces ns = new XmlSerializerNamespaces();
                ns.Add("ota", "http://www.opentravel.org/OTA/2002/11");

                requestXmlString = XmlSerializationHelper.Serialize(request, ns);
                responseXmlString = this.service.cancel(requestXmlString);
                passkeyResponse = XmlSerializationHelper.Deserialize<PasskeyResponse>(responseXmlString);
            }
            catch (Exception ex)
            {
                passkeyResponse = new PasskeyResponse
                {
                    Message = new ResponseMessage
                    {
                        Errors = new ResponseMessageErrors
                        {
                            Error = ex.Message
                        }
                    }
                };
            }

            passkeyResponse.RequestXML = requestXmlString;
            passkeyResponse.ResponseXML = responseXmlString;

            return passkeyResponse;
        }

        /// <summary>
        ///     The create bridge rq security.
        /// </summary>
        /// <returns>
        ///     The <see cref="CreateBridgeRQSecurity" />.
        /// </returns>
        private static PasskeySecurity CreatePasskeySecurity(uint partnerId, string userName, string password)
        {
            return new PasskeySecurity
            {
                Login =
                    new PasskeySecurityLogin
                    {
                        UserName = userName,
                        Password = password
                    },
                PartnerID = partnerId,
                Token = " "
            };
        }

        /// <summary>
        ///     The create bridge rq message.
        /// </summary>
        /// <returns>
        ///     The <see cref="CreateBridgeRQMessage" />.
        /// </returns>
        private static PasskeyMessage CreatePasskeyMessage(string op, string service)
        {
            return new PasskeyMessage
            {
                Version = "4.00.02",
                Mode = "S",
                OP = op,
                Service = service,
                Locale = "EN_US",
                GUID = "Text"
            };
        }
    }
}
