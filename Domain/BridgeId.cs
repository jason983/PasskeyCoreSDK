using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PasskeyCoreSDK.Domain
{

    /// <remarks/>
    [System.Xml.Serialization.XmlTypeAttribute(AnonymousType = true, Namespace = "http://www.passkey.com/apiSchema")]
    [System.Xml.Serialization.XmlRootAttribute(Namespace = "http://www.passkey.com/apiSchema", IsNullable = false)]
    public partial class ModifyBridgeRQ
    {

        private ModifyBridgeRQSecurity securityField;

        private ModifyBridgeRQMessage messageField;

        private ModifyBridgeRQData dataField;

        /// <remarks/>
        public ModifyBridgeRQSecurity Security
        {
            get
            {
                return this.securityField;
            }
            set
            {
                this.securityField = value;
            }
        }

        /// <remarks/>
        public ModifyBridgeRQMessage Message
        {
            get
            {
                return this.messageField;
            }
            set
            {
                this.messageField = value;
            }
        }

        /// <remarks/>
        public ModifyBridgeRQData Data
        {
            get
            {
                return this.dataField;
            }
            set
            {
                this.dataField = value;
            }
        }
    }

    /// <remarks/>
    [System.Xml.Serialization.XmlTypeAttribute(AnonymousType = true, Namespace = "http://www.passkey.com/apiSchema")]
    public partial class ModifyBridgeRQSecurity
    {

        private ModifyBridgeRQSecurityLogin loginField;

        private uint partnerIDField;

        private object tokenField;

        /// <remarks/>
        public ModifyBridgeRQSecurityLogin Login
        {
            get
            {
                return this.loginField;
            }
            set
            {
                this.loginField = value;
            }
        }

        /// <remarks/>
        public uint PartnerID
        {
            get
            {
                return this.partnerIDField;
            }
            set
            {
                this.partnerIDField = value;
            }
        }

        /// <remarks/>
        public object Token
        {
            get
            {
                return this.tokenField;
            }
            set
            {
                this.tokenField = value;
            }
        }
    }

    /// <remarks/>
    [System.Xml.Serialization.XmlTypeAttribute(AnonymousType = true, Namespace = "http://www.passkey.com/apiSchema")]
    public partial class ModifyBridgeRQSecurityLogin
    {

        private string userNameField;

        private string passwordField;

        /// <remarks/>
        public string UserName
        {
            get
            {
                return this.userNameField;
            }
            set
            {
                this.userNameField = value;
            }
        }

        /// <remarks/>
        public string Password
        {
            get
            {
                return this.passwordField;
            }
            set
            {
                this.passwordField = value;
            }
        }
    }

    /// <remarks/>
    [System.Xml.Serialization.XmlTypeAttribute(AnonymousType = true, Namespace = "http://www.passkey.com/apiSchema")]
    public partial class ModifyBridgeRQMessage
    {

        private string gUIDField;

        private string versionField;

        private string modeField;

        private string opField;

        private string serviceField;

        private string localeField;

        /// <remarks/>
        public string GUID
        {
            get
            {
                return this.gUIDField;
            }
            set
            {
                this.gUIDField = value;
            }
        }

        /// <remarks/>
        public string Version
        {
            get
            {
                return this.versionField;
            }
            set
            {
                this.versionField = value;
            }
        }

        /// <remarks/>
        public string Mode
        {
            get
            {
                return this.modeField;
            }
            set
            {
                this.modeField = value;
            }
        }

        /// <remarks/>
        public string OP
        {
            get
            {
                return this.opField;
            }
            set
            {
                this.opField = value;
            }
        }

        /// <remarks/>
        public string Service
        {
            get
            {
                return this.serviceField;
            }
            set
            {
                this.serviceField = value;
            }
        }

        /// <remarks/>
        public string Locale
        {
            get
            {
                return this.localeField;
            }
            set
            {
                this.localeField = value;
            }
        }
    }

    /// <remarks/>
    [System.Xml.Serialization.XmlTypeAttribute(AnonymousType = true, Namespace = "http://www.passkey.com/apiSchema")]
    public partial class ModifyBridgeRQData
    {

        private OTA_HotelResRQ oTA_HotelResRQField;

        /// <remarks/>
        [System.Xml.Serialization.XmlElementAttribute(Namespace = "http://www.opentravel.org/OTA/2002/11")]
        public OTA_HotelResRQ OTA_HotelResRQ
        {
            get
            {
                return this.oTA_HotelResRQField;
            }
            set
            {
                this.oTA_HotelResRQField = value;
            }
        }
    }

    /// <remarks/>
    [System.Xml.Serialization.XmlTypeAttribute(AnonymousType = true, Namespace = "http://www.opentravel.org/OTA/2002/11")]
    [System.Xml.Serialization.XmlRootAttribute(Namespace = "http://www.opentravel.org/OTA/2002/11", IsNullable = false)]
    public partial class OTA_HotelResRQ
    {

        private OTA_HotelResRQHotelReservations hotelReservationsField;

        /// <remarks/>
        public OTA_HotelResRQHotelReservations HotelReservations
        {
            get
            {
                return this.hotelReservationsField;
            }
            set
            {
                this.hotelReservationsField = value;
            }
        }
    }

    /// <remarks/>
    [System.Xml.Serialization.XmlTypeAttribute(AnonymousType = true, Namespace = "http://www.opentravel.org/OTA/2002/11")]
    public partial class OTA_HotelResRQHotelReservations
    {

        private OTA_HotelResRQHotelReservationsHotelReservation hotelReservationField;

        /// <remarks/>
        public OTA_HotelResRQHotelReservationsHotelReservation HotelReservation
        {
            get
            {
                return this.hotelReservationField;
            }
            set
            {
                this.hotelReservationField = value;
            }
        }
    }

    /// <remarks/>
    [System.Xml.Serialization.XmlTypeAttribute(AnonymousType = true, Namespace = "http://www.opentravel.org/OTA/2002/11")]
    public partial class OTA_HotelResRQHotelReservationsHotelReservation
    {

        private UniqueId uniqueIdField;

        private OTA_HotelResRQHotelReservationsHotelReservationResGuest[] resGuestsField;

        private OTA_HotelResRQHotelReservationsHotelReservationResGlobalInfo resGlobalInfoField;

        private OTA_HotelResRQHotelReservationsHotelReservationTPA_Extensions tPA_ExtensionsField;

        /// <remarks/>
        public UniqueId UniqueId
        {
            get
            {
                return this.uniqueIdField;
            }
            set
            {
                this.uniqueIdField = value;
            }
        }

        /// <remarks/>
        [System.Xml.Serialization.XmlArrayItemAttribute("ResGuest", IsNullable = false)]
        public OTA_HotelResRQHotelReservationsHotelReservationResGuest[] ResGuests
        {
            get
            {
                return this.resGuestsField;
            }
            set
            {
                this.resGuestsField = value;
            }
        }

        /// <remarks/>
        public OTA_HotelResRQHotelReservationsHotelReservationResGlobalInfo ResGlobalInfo
        {
            get
            {
                return this.resGlobalInfoField;
            }
            set
            {
                this.resGlobalInfoField = value;
            }
        }

        /// <remarks/>
        public OTA_HotelResRQHotelReservationsHotelReservationTPA_Extensions TPA_Extensions
        {
            get
            {
                return this.tPA_ExtensionsField;
            }
            set
            {
                this.tPA_ExtensionsField = value;
            }
        }
    }

    /// <remarks/>
    [System.Xml.Serialization.XmlTypeAttribute(AnonymousType = true, Namespace = "http://www.opentravel.org/OTA/2002/11")]
    public partial class OTA_HotelResRQHotelReservationsHotelReservationResGuest
    {

        private OTA_HotelResRQHotelReservationsHotelReservationResGuestProfiles profilesField;

        /// <remarks/>
        public OTA_HotelResRQHotelReservationsHotelReservationResGuestProfiles Profiles
        {
            get
            {
                return this.profilesField;
            }
            set
            {
                this.profilesField = value;
            }
        }
    }

    /// <remarks/>
    [System.Xml.Serialization.XmlTypeAttribute(AnonymousType = true, Namespace = "http://www.opentravel.org/OTA/2002/11")]
    public partial class OTA_HotelResRQHotelReservationsHotelReservationResGuestProfiles
    {

        private OTA_HotelResRQHotelReservationsHotelReservationResGuestProfilesProfileInfo profileInfoField;

        /// <remarks/>
        public OTA_HotelResRQHotelReservationsHotelReservationResGuestProfilesProfileInfo ProfileInfo
        {
            get
            {
                return this.profileInfoField;
            }
            set
            {
                this.profileInfoField = value;
            }
        }
    }

    /// <remarks/>
    [System.Xml.Serialization.XmlTypeAttribute(AnonymousType = true, Namespace = "http://www.opentravel.org/OTA/2002/11")]
    public partial class OTA_HotelResRQHotelReservationsHotelReservationResGuestProfilesProfileInfo
    {

        private OTA_HotelResRQHotelReservationsHotelReservationResGuestProfilesProfileInfoProfile profileField;

        /// <remarks/>
        public OTA_HotelResRQHotelReservationsHotelReservationResGuestProfilesProfileInfoProfile Profile
        {
            get
            {
                return this.profileField;
            }
            set
            {
                this.profileField = value;
            }
        }
    }

    /// <remarks/>
    [System.Xml.Serialization.XmlTypeAttribute(AnonymousType = true, Namespace = "http://www.opentravel.org/OTA/2002/11")]
    public partial class OTA_HotelResRQHotelReservationsHotelReservationResGuestProfilesProfileInfoProfile
    {

        private OTA_HotelResRQHotelReservationsHotelReservationResGuestProfilesProfileInfoProfileCustomer customerField;

        private OTA_HotelResRQHotelReservationsHotelReservationResGuestProfilesProfileInfoProfilePrefCollections prefCollectionsField;

        private OTA_HotelResRQHotelReservationsHotelReservationResGuestProfilesProfileInfoProfileCompanyInfo companyInfoField;

        /// <remarks/>
        public OTA_HotelResRQHotelReservationsHotelReservationResGuestProfilesProfileInfoProfileCustomer Customer
        {
            get
            {
                return this.customerField;
            }
            set
            {
                this.customerField = value;
            }
        }

        /// <remarks/>
        public OTA_HotelResRQHotelReservationsHotelReservationResGuestProfilesProfileInfoProfilePrefCollections PrefCollections
        {
            get
            {
                return this.prefCollectionsField;
            }
            set
            {
                this.prefCollectionsField = value;
            }
        }

        /// <remarks/>
        public OTA_HotelResRQHotelReservationsHotelReservationResGuestProfilesProfileInfoProfileCompanyInfo CompanyInfo
        {
            get
            {
                return this.companyInfoField;
            }
            set
            {
                this.companyInfoField = value;
            }
        }
    }

    /// <remarks/>
    [System.Xml.Serialization.XmlTypeAttribute(AnonymousType = true, Namespace = "http://www.opentravel.org/OTA/2002/11")]
    public partial class OTA_HotelResRQHotelReservationsHotelReservationResGuestProfilesProfileInfoProfileCustomer
    {

        private OTA_HotelResRQHotelReservationsHotelReservationResGuestProfilesProfileInfoProfileCustomerPersonName personNameField;

        private OTA_HotelResRQHotelReservationsHotelReservationResGuestProfilesProfileInfoProfileCustomerTelephone[] telephoneField;

        private string emailField;

        private OTA_HotelResRQHotelReservationsHotelReservationResGuestProfilesProfileInfoProfileCustomerAddress addressField;

        private OTA_HotelResRQHotelReservationsHotelReservationResGuestProfilesProfileInfoProfileCustomerEmployeeInfo employeeInfoField;

        /// <remarks/>
        public OTA_HotelResRQHotelReservationsHotelReservationResGuestProfilesProfileInfoProfileCustomerPersonName PersonName
        {
            get
            {
                return this.personNameField;
            }
            set
            {
                this.personNameField = value;
            }
        }

        /// <remarks/>
        [System.Xml.Serialization.XmlElementAttribute("Telephone")]
        public OTA_HotelResRQHotelReservationsHotelReservationResGuestProfilesProfileInfoProfileCustomerTelephone[] Telephone
        {
            get
            {
                return this.telephoneField;
            }
            set
            {
                this.telephoneField = value;
            }
        }

        /// <remarks/>
        public string Email
        {
            get
            {
                return this.emailField;
            }
            set
            {
                this.emailField = value;
            }
        }

        /// <remarks/>
        public OTA_HotelResRQHotelReservationsHotelReservationResGuestProfilesProfileInfoProfileCustomerAddress Address
        {
            get
            {
                return this.addressField;
            }
            set
            {
                this.addressField = value;
            }
        }

        /// <remarks/>
        public OTA_HotelResRQHotelReservationsHotelReservationResGuestProfilesProfileInfoProfileCustomerEmployeeInfo EmployeeInfo
        {
            get
            {
                return this.employeeInfoField;
            }
            set
            {
                this.employeeInfoField = value;
            }
        }
    }

    /// <remarks/>
    [System.Xml.Serialization.XmlTypeAttribute(AnonymousType = true, Namespace = "http://www.opentravel.org/OTA/2002/11")]
    public partial class OTA_HotelResRQHotelReservationsHotelReservationResGuestProfilesProfileInfoProfileCustomerPersonName
    {

        private string namePrefixField;

        private string givenNameField;

        private string middleNameField;

        private string surnamePrefixField;

        private string surnameField;

        private string nameSuffixField;

        private string nameTitleField;

        /// <remarks/>
        public string NamePrefix
        {
            get
            {
                return this.namePrefixField;
            }
            set
            {
                this.namePrefixField = value;
            }
        }

        /// <remarks/>
        public string GivenName
        {
            get
            {
                return this.givenNameField;
            }
            set
            {
                this.givenNameField = value;
            }
        }

        /// <remarks/>
        public string MiddleName
        {
            get
            {
                return this.middleNameField;
            }
            set
            {
                this.middleNameField = value;
            }
        }

        /// <remarks/>
        public string SurnamePrefix
        {
            get
            {
                return this.surnamePrefixField;
            }
            set
            {
                this.surnamePrefixField = value;
            }
        }

        /// <remarks/>
        public string Surname
        {
            get
            {
                return this.surnameField;
            }
            set
            {
                this.surnameField = value;
            }
        }

        /// <remarks/>
        public string NameSuffix
        {
            get
            {
                return this.nameSuffixField;
            }
            set
            {
                this.nameSuffixField = value;
            }
        }

        /// <remarks/>
        public string NameTitle
        {
            get
            {
                return this.nameTitleField;
            }
            set
            {
                this.nameTitleField = value;
            }
        }
    }

    /// <remarks/>
    [System.Xml.Serialization.XmlTypeAttribute(AnonymousType = true, Namespace = "http://www.opentravel.org/OTA/2002/11")]
    public partial class OTA_HotelResRQHotelReservationsHotelReservationResGuestProfilesProfileInfoProfileCustomerTelephone
    {

        private byte phoneTechTypeField;

        private uint phoneNumberField;

        /// <remarks/>
        [System.Xml.Serialization.XmlAttributeAttribute()]
        public byte PhoneTechType
        {
            get
            {
                return this.phoneTechTypeField;
            }
            set
            {
                this.phoneTechTypeField = value;
            }
        }

        /// <remarks/>
        [System.Xml.Serialization.XmlAttributeAttribute()]
        public uint PhoneNumber
        {
            get
            {
                return this.phoneNumberField;
            }
            set
            {
                this.phoneNumberField = value;
            }
        }
    }

    /// <remarks/>
    [System.Xml.Serialization.XmlTypeAttribute(AnonymousType = true, Namespace = "http://www.opentravel.org/OTA/2002/11")]
    public partial class OTA_HotelResRQHotelReservationsHotelReservationResGuestProfilesProfileInfoProfileCustomerAddress
    {

        private string streetNmbrField;

        private string bldgRoomField;

        private string addressLineField;

        private string cityNameField;

        private uint postalCodeField;

        private string countyField;

        private string stateProvField;

        private OTA_HotelResRQHotelReservationsHotelReservationResGuestProfilesProfileInfoProfileCustomerAddressCountryName countryNameField;

        /// <remarks/>
        public string StreetNmbr
        {
            get
            {
                return this.streetNmbrField;
            }
            set
            {
                this.streetNmbrField = value;
            }
        }

        /// <remarks/>
        public string BldgRoom
        {
            get
            {
                return this.bldgRoomField;
            }
            set
            {
                this.bldgRoomField = value;
            }
        }

        /// <remarks/>
        public string AddressLine
        {
            get
            {
                return this.addressLineField;
            }
            set
            {
                this.addressLineField = value;
            }
        }

        /// <remarks/>
        public string CityName
        {
            get
            {
                return this.cityNameField;
            }
            set
            {
                this.cityNameField = value;
            }
        }

        /// <remarks/>
        public uint PostalCode
        {
            get
            {
                return this.postalCodeField;
            }
            set
            {
                this.postalCodeField = value;
            }
        }

        /// <remarks/>
        public string County
        {
            get
            {
                return this.countyField;
            }
            set
            {
                this.countyField = value;
            }
        }

        /// <remarks/>
        public string StateProv
        {
            get
            {
                return this.stateProvField;
            }
            set
            {
                this.stateProvField = value;
            }
        }

        /// <remarks/>
        public OTA_HotelResRQHotelReservationsHotelReservationResGuestProfilesProfileInfoProfileCustomerAddressCountryName CountryName
        {
            get
            {
                return this.countryNameField;
            }
            set
            {
                this.countryNameField = value;
            }
        }
    }

    /// <remarks/>
    [System.Xml.Serialization.XmlTypeAttribute(AnonymousType = true, Namespace = "http://www.opentravel.org/OTA/2002/11")]
    public partial class OTA_HotelResRQHotelReservationsHotelReservationResGuestProfilesProfileInfoProfileCustomerAddressCountryName
    {

        private string codeField;

        private string valueField;

        /// <remarks/>
        [System.Xml.Serialization.XmlAttributeAttribute()]
        public string Code
        {
            get
            {
                return this.codeField;
            }
            set
            {
                this.codeField = value;
            }
        }

        /// <remarks/>
        [System.Xml.Serialization.XmlTextAttribute()]
        public string Value
        {
            get
            {
                return this.valueField;
            }
            set
            {
                this.valueField = value;
            }
        }
    }

    /// <remarks/>
    [System.Xml.Serialization.XmlTypeAttribute(AnonymousType = true, Namespace = "http://www.opentravel.org/OTA/2002/11")]
    public partial class OTA_HotelResRQHotelReservationsHotelReservationResGuestProfilesProfileInfoProfileCustomerEmployeeInfo
    {

        private string employeeTitleField;

        private string valueField;

        /// <remarks/>
        [System.Xml.Serialization.XmlAttributeAttribute()]
        public string EmployeeTitle
        {
            get
            {
                return this.employeeTitleField;
            }
            set
            {
                this.employeeTitleField = value;
            }
        }

        /// <remarks/>
        [System.Xml.Serialization.XmlTextAttribute()]
        public string Value
        {
            get
            {
                return this.valueField;
            }
            set
            {
                this.valueField = value;
            }
        }
    }

    /// <remarks/>
    [System.Xml.Serialization.XmlTypeAttribute(AnonymousType = true, Namespace = "http://www.opentravel.org/OTA/2002/11")]
    public partial class OTA_HotelResRQHotelReservationsHotelReservationResGuestProfilesProfileInfoProfilePrefCollections
    {

        private OTA_HotelResRQHotelReservationsHotelReservationResGuestProfilesProfileInfoProfilePrefCollectionsPrefCollection prefCollectionField;

        /// <remarks/>
        public OTA_HotelResRQHotelReservationsHotelReservationResGuestProfilesProfileInfoProfilePrefCollectionsPrefCollection PrefCollection
        {
            get
            {
                return this.prefCollectionField;
            }
            set
            {
                this.prefCollectionField = value;
            }
        }
    }

    /// <remarks/>
    [System.Xml.Serialization.XmlTypeAttribute(AnonymousType = true, Namespace = "http://www.opentravel.org/OTA/2002/11")]
    public partial class OTA_HotelResRQHotelReservationsHotelReservationResGuestProfilesProfileInfoProfilePrefCollectionsPrefCollection
    {

        private OTA_HotelResRQHotelReservationsHotelReservationResGuestProfilesProfileInfoProfilePrefCollectionsPrefCollectionHotelPref hotelPrefField;

        /// <remarks/>
        public OTA_HotelResRQHotelReservationsHotelReservationResGuestProfilesProfileInfoProfilePrefCollectionsPrefCollectionHotelPref HotelPref
        {
            get
            {
                return this.hotelPrefField;
            }
            set
            {
                this.hotelPrefField = value;
            }
        }
    }

    /// <remarks/>
    [System.Xml.Serialization.XmlTypeAttribute(AnonymousType = true, Namespace = "http://www.opentravel.org/OTA/2002/11")]
    public partial class OTA_HotelResRQHotelReservationsHotelReservationResGuestProfilesProfileInfoProfilePrefCollectionsPrefCollectionHotelPref
    {

        private byte physChallFeaturePrefField;

        private byte smokingAllowedField;

        /// <remarks/>
        public byte PhysChallFeaturePref
        {
            get
            {
                return this.physChallFeaturePrefField;
            }
            set
            {
                this.physChallFeaturePrefField = value;
            }
        }

        /// <remarks/>
        [System.Xml.Serialization.XmlAttributeAttribute()]
        public byte SmokingAllowed
        {
            get
            {
                return this.smokingAllowedField;
            }
            set
            {
                this.smokingAllowedField = value;
            }
        }
    }

    /// <remarks/>
    [System.Xml.Serialization.XmlTypeAttribute(AnonymousType = true, Namespace = "http://www.opentravel.org/OTA/2002/11")]
    public partial class OTA_HotelResRQHotelReservationsHotelReservationResGuestProfilesProfileInfoProfileCompanyInfo
    {

        private string companyNameField;

        private object addressInfoField;

        private OTA_HotelResRQHotelReservationsHotelReservationResGuestProfilesProfileInfoProfileCompanyInfoTelephoneInfo telephoneInfoField;

        /// <remarks/>
        public string CompanyName
        {
            get
            {
                return this.companyNameField;
            }
            set
            {
                this.companyNameField = value;
            }
        }

        /// <remarks/>
        public object AddressInfo
        {
            get
            {
                return this.addressInfoField;
            }
            set
            {
                this.addressInfoField = value;
            }
        }

        /// <remarks/>
        public OTA_HotelResRQHotelReservationsHotelReservationResGuestProfilesProfileInfoProfileCompanyInfoTelephoneInfo TelephoneInfo
        {
            get
            {
                return this.telephoneInfoField;
            }
            set
            {
                this.telephoneInfoField = value;
            }
        }
    }

    /// <remarks/>
    [System.Xml.Serialization.XmlTypeAttribute(AnonymousType = true, Namespace = "http://www.opentravel.org/OTA/2002/11")]
    public partial class OTA_HotelResRQHotelReservationsHotelReservationResGuestProfilesProfileInfoProfileCompanyInfoTelephoneInfo
    {

        private ulong phoneNumberField;

        /// <remarks/>
        [System.Xml.Serialization.XmlAttributeAttribute()]
        public ulong PhoneNumber
        {
            get
            {
                return this.phoneNumberField;
            }
            set
            {
                this.phoneNumberField = value;
            }
        }
    }

    /// <remarks/>
    [System.Xml.Serialization.XmlTypeAttribute(AnonymousType = true, Namespace = "http://www.opentravel.org/OTA/2002/11")]
    public partial class OTA_HotelResRQHotelReservationsHotelReservationResGlobalInfo
    {

        private OTA_HotelResRQHotelReservationsHotelReservationResGlobalInfoTimeSpan timeSpanField;

        private object membershipsField;

        private OTA_HotelResRQHotelReservationsHotelReservationResGlobalInfoSpecialRequests specialRequestsField;

        private OTA_HotelResRQHotelReservationsHotelReservationResGlobalInfoGuarantee guaranteeField;

        /// <remarks/>
        public OTA_HotelResRQHotelReservationsHotelReservationResGlobalInfoTimeSpan TimeSpan
        {
            get
            {
                return this.timeSpanField;
            }
            set
            {
                this.timeSpanField = value;
            }
        }

        /// <remarks/>
        public object Memberships
        {
            get
            {
                return this.membershipsField;
            }
            set
            {
                this.membershipsField = value;
            }
        }

        /// <remarks/>
        public OTA_HotelResRQHotelReservationsHotelReservationResGlobalInfoSpecialRequests SpecialRequests
        {
            get
            {
                return this.specialRequestsField;
            }
            set
            {
                this.specialRequestsField = value;
            }
        }

        /// <remarks/>
        public OTA_HotelResRQHotelReservationsHotelReservationResGlobalInfoGuarantee Guarantee
        {
            get
            {
                return this.guaranteeField;
            }
            set
            {
                this.guaranteeField = value;
            }
        }
    }

    /// <remarks/>
    [System.Xml.Serialization.XmlTypeAttribute(AnonymousType = true, Namespace = "http://www.opentravel.org/OTA/2002/11")]
    public partial class OTA_HotelResRQHotelReservationsHotelReservationResGlobalInfoTimeSpan
    {

        private OTA_HotelResRQHotelReservationsHotelReservationResGlobalInfoTimeSpanStartDateWindow startDateWindowField;

        /// <remarks/>
        public OTA_HotelResRQHotelReservationsHotelReservationResGlobalInfoTimeSpanStartDateWindow StartDateWindow
        {
            get
            {
                return this.startDateWindowField;
            }
            set
            {
                this.startDateWindowField = value;
            }
        }
    }

    /// <remarks/>
    [System.Xml.Serialization.XmlTypeAttribute(AnonymousType = true, Namespace = "http://www.opentravel.org/OTA/2002/11")]
    public partial class OTA_HotelResRQHotelReservationsHotelReservationResGlobalInfoTimeSpanStartDateWindow
    {

        private System.DateTime earliestDateField;

        private System.DateTime latestDateField;

        /// <remarks/>
        [System.Xml.Serialization.XmlAttributeAttribute(DataType = "date")]
        public System.DateTime EarliestDate
        {
            get
            {
                return this.earliestDateField;
            }
            set
            {
                this.earliestDateField = value;
            }
        }

        /// <remarks/>
        [System.Xml.Serialization.XmlAttributeAttribute(DataType = "date")]
        public System.DateTime LatestDate
        {
            get
            {
                return this.latestDateField;
            }
            set
            {
                this.latestDateField = value;
            }
        }
    }

    /// <remarks/>
    [System.Xml.Serialization.XmlTypeAttribute(AnonymousType = true, Namespace = "http://www.opentravel.org/OTA/2002/11")]
    public partial class OTA_HotelResRQHotelReservationsHotelReservationResGlobalInfoSpecialRequests
    {

        private OTA_HotelResRQHotelReservationsHotelReservationResGlobalInfoSpecialRequestsSpecialRequest specialRequestField;

        /// <remarks/>
        public OTA_HotelResRQHotelReservationsHotelReservationResGlobalInfoSpecialRequestsSpecialRequest SpecialRequest
        {
            get
            {
                return this.specialRequestField;
            }
            set
            {
                this.specialRequestField = value;
            }
        }
    }

    /// <remarks/>
    [System.Xml.Serialization.XmlTypeAttribute(AnonymousType = true, Namespace = "http://www.opentravel.org/OTA/2002/11")]
    public partial class OTA_HotelResRQHotelReservationsHotelReservationResGlobalInfoSpecialRequestsSpecialRequest
    {

        private string textField;

        /// <remarks/>
        public string Text
        {
            get
            {
                return this.textField;
            }
            set
            {
                this.textField = value;
            }
        }
    }

    /// <remarks/>
    [System.Xml.Serialization.XmlTypeAttribute(AnonymousType = true, Namespace = "http://www.opentravel.org/OTA/2002/11")]
    public partial class OTA_HotelResRQHotelReservationsHotelReservationResGlobalInfoGuarantee
    {

        private OTA_HotelResRQHotelReservationsHotelReservationResGlobalInfoGuaranteeGuaranteeAccepted[] guaranteesAcceptedField;

        /// <remarks/>
        [System.Xml.Serialization.XmlArrayItemAttribute("GuaranteeAccepted", IsNullable = false)]
        public OTA_HotelResRQHotelReservationsHotelReservationResGlobalInfoGuaranteeGuaranteeAccepted[] GuaranteesAccepted
        {
            get
            {
                return this.guaranteesAcceptedField;
            }
            set
            {
                this.guaranteesAcceptedField = value;
            }
        }
    }

    /// <remarks/>
    [System.Xml.Serialization.XmlTypeAttribute(AnonymousType = true, Namespace = "http://www.opentravel.org/OTA/2002/11")]
    public partial class OTA_HotelResRQHotelReservationsHotelReservationResGlobalInfoGuaranteeGuaranteeAccepted
    {

        private OTA_HotelResRQHotelReservationsHotelReservationResGlobalInfoGuaranteeGuaranteeAcceptedPaymentCard paymentCardField;

        /// <remarks/>
        public OTA_HotelResRQHotelReservationsHotelReservationResGlobalInfoGuaranteeGuaranteeAcceptedPaymentCard PaymentCard
        {
            get
            {
                return this.paymentCardField;
            }
            set
            {
                this.paymentCardField = value;
            }
        }
    }

    /// <remarks/>
    [System.Xml.Serialization.XmlTypeAttribute(AnonymousType = true, Namespace = "http://www.opentravel.org/OTA/2002/11")]
    public partial class OTA_HotelResRQHotelReservationsHotelReservationResGlobalInfoGuaranteeGuaranteeAcceptedPaymentCard
    {

        private string cardHolderNameField;

        private object cardIssuerNameField;

        private OTA_HotelResRQHotelReservationsHotelReservationResGlobalInfoGuaranteeGuaranteeAcceptedPaymentCardAddress addressField;

        private string cardCodeField;

        private ulong cardNumberField;

        private byte expireDateField;

        /// <remarks/>
        public string CardHolderName
        {
            get
            {
                return this.cardHolderNameField;
            }
            set
            {
                this.cardHolderNameField = value;
            }
        }

        /// <remarks/>
        public object CardIssuerName
        {
            get
            {
                return this.cardIssuerNameField;
            }
            set
            {
                this.cardIssuerNameField = value;
            }
        }

        /// <remarks/>
        public OTA_HotelResRQHotelReservationsHotelReservationResGlobalInfoGuaranteeGuaranteeAcceptedPaymentCardAddress Address
        {
            get
            {
                return this.addressField;
            }
            set
            {
                this.addressField = value;
            }
        }

        /// <remarks/>
        [System.Xml.Serialization.XmlAttributeAttribute()]
        public string CardCode
        {
            get
            {
                return this.cardCodeField;
            }
            set
            {
                this.cardCodeField = value;
            }
        }

        /// <remarks/>
        [System.Xml.Serialization.XmlAttributeAttribute()]
        public ulong CardNumber
        {
            get
            {
                return this.cardNumberField;
            }
            set
            {
                this.cardNumberField = value;
            }
        }

        /// <remarks/>
        [System.Xml.Serialization.XmlAttributeAttribute()]
        public byte ExpireDate
        {
            get
            {
                return this.expireDateField;
            }
            set
            {
                this.expireDateField = value;
            }
        }
    }

    /// <remarks/>
    [System.Xml.Serialization.XmlTypeAttribute(AnonymousType = true, Namespace = "http://www.opentravel.org/OTA/2002/11")]
    public partial class OTA_HotelResRQHotelReservationsHotelReservationResGlobalInfoGuaranteeGuaranteeAcceptedPaymentCardAddress
    {

        private string streetNmbrField;

        private string bldgRoomField;

        private string addressLineField;

        private string cityNameField;

        private uint postalCodeField;

        private string countyField;

        private string stateProvField;

        private OTA_HotelResRQHotelReservationsHotelReservationResGlobalInfoGuaranteeGuaranteeAcceptedPaymentCardAddressCountryName countryNameField;

        /// <remarks/>
        public string StreetNmbr
        {
            get
            {
                return this.streetNmbrField;
            }
            set
            {
                this.streetNmbrField = value;
            }
        }

        /// <remarks/>
        public string BldgRoom
        {
            get
            {
                return this.bldgRoomField;
            }
            set
            {
                this.bldgRoomField = value;
            }
        }

        /// <remarks/>
        public string AddressLine
        {
            get
            {
                return this.addressLineField;
            }
            set
            {
                this.addressLineField = value;
            }
        }

        /// <remarks/>
        public string CityName
        {
            get
            {
                return this.cityNameField;
            }
            set
            {
                this.cityNameField = value;
            }
        }

        /// <remarks/>
        public uint PostalCode
        {
            get
            {
                return this.postalCodeField;
            }
            set
            {
                this.postalCodeField = value;
            }
        }

        /// <remarks/>
        public string County
        {
            get
            {
                return this.countyField;
            }
            set
            {
                this.countyField = value;
            }
        }

        /// <remarks/>
        public string StateProv
        {
            get
            {
                return this.stateProvField;
            }
            set
            {
                this.stateProvField = value;
            }
        }

        /// <remarks/>
        public OTA_HotelResRQHotelReservationsHotelReservationResGlobalInfoGuaranteeGuaranteeAcceptedPaymentCardAddressCountryName CountryName
        {
            get
            {
                return this.countryNameField;
            }
            set
            {
                this.countryNameField = value;
            }
        }
    }

    /// <remarks/>
    [System.Xml.Serialization.XmlTypeAttribute(AnonymousType = true, Namespace = "http://www.opentravel.org/OTA/2002/11")]
    public partial class OTA_HotelResRQHotelReservationsHotelReservationResGlobalInfoGuaranteeGuaranteeAcceptedPaymentCardAddressCountryName
    {

        private string codeField;

        private string valueField;

        /// <remarks/>
        [System.Xml.Serialization.XmlAttributeAttribute()]
        public string Code
        {
            get
            {
                return this.codeField;
            }
            set
            {
                this.codeField = value;
            }
        }

        /// <remarks/>
        [System.Xml.Serialization.XmlTextAttribute()]
        public string Value
        {
            get
            {
                return this.valueField;
            }
            set
            {
                this.valueField = value;
            }
        }
    }

    /// <remarks/>
    [System.Xml.Serialization.XmlTypeAttribute(AnonymousType = true, Namespace = "http://www.opentravel.org/OTA/2002/11")]
    public partial class OTA_HotelResRQHotelReservationsHotelReservationTPA_Extensions
    {

        private OTA_HotelResRQHotelReservationsHotelReservationTPA_ExtensionsPK_Info pK_InfoField;

        /// <remarks/>
        public OTA_HotelResRQHotelReservationsHotelReservationTPA_ExtensionsPK_Info PK_Info
        {
            get
            {
                return this.pK_InfoField;
            }
            set
            {
                this.pK_InfoField = value;
            }
        }
    }

    /// <remarks/>
    [System.Xml.Serialization.XmlTypeAttribute(AnonymousType = true, Namespace = "http://www.opentravel.org/OTA/2002/11")]
    public partial class OTA_HotelResRQHotelReservationsHotelReservationTPA_ExtensionsPK_Info
    {

        private uint eventIDField;

        private string attendeeCodeField;

        private bool sendAckField;

        private byte howBookedField;

        private string receivedFromField;

        private string paymentTypeField;

        private uint blockIDField;

        private OTA_HotelResRQHotelReservationsHotelReservationTPA_ExtensionsPK_InfoOtherPayment otherPaymentField;

        private OTA_HotelResRQHotelReservationsHotelReservationTPA_ExtensionsPK_InfoBillPhone billPhoneField;

        private byte primaryGuestRPHField;

        private OTA_HotelResRQHotelReservationsHotelReservationTPA_ExtensionsPK_InfoCustomFields customFieldsField;

        private string referrerField;

        /// <remarks/>
        public uint EventID
        {
            get
            {
                return this.eventIDField;
            }
            set
            {
                this.eventIDField = value;
            }
        }

        /// <remarks/>
        public string AttendeeCode
        {
            get
            {
                return this.attendeeCodeField;
            }
            set
            {
                this.attendeeCodeField = value;
            }
        }

        /// <remarks/>
        public bool SendAck
        {
            get
            {
                return this.sendAckField;
            }
            set
            {
                this.sendAckField = value;
            }
        }

        /// <remarks/>
        public byte HowBooked
        {
            get
            {
                return this.howBookedField;
            }
            set
            {
                this.howBookedField = value;
            }
        }

        /// <remarks/>
        public string ReceivedFrom
        {
            get
            {
                return this.receivedFromField;
            }
            set
            {
                this.receivedFromField = value;
            }
        }

        /// <remarks/>
        public string PaymentType
        {
            get
            {
                return this.paymentTypeField;
            }
            set
            {
                this.paymentTypeField = value;
            }
        }

        /// <remarks/>
        public uint BlockID
        {
            get
            {
                return this.blockIDField;
            }
            set
            {
                this.blockIDField = value;
            }
        }

        /// <remarks/>
        public OTA_HotelResRQHotelReservationsHotelReservationTPA_ExtensionsPK_InfoOtherPayment OtherPayment
        {
            get
            {
                return this.otherPaymentField;
            }
            set
            {
                this.otherPaymentField = value;
            }
        }

        /// <remarks/>
        public OTA_HotelResRQHotelReservationsHotelReservationTPA_ExtensionsPK_InfoBillPhone BillPhone
        {
            get
            {
                return this.billPhoneField;
            }
            set
            {
                this.billPhoneField = value;
            }
        }

        /// <remarks/>
        public byte PrimaryGuestRPH
        {
            get
            {
                return this.primaryGuestRPHField;
            }
            set
            {
                this.primaryGuestRPHField = value;
            }
        }

        /// <remarks/>
        public OTA_HotelResRQHotelReservationsHotelReservationTPA_ExtensionsPK_InfoCustomFields CustomFields
        {
            get
            {
                return this.customFieldsField;
            }
            set
            {
                this.customFieldsField = value;
            }
        }

        /// <remarks/>
        public string Referrer
        {
            get
            {
                return this.referrerField;
            }
            set
            {
                this.referrerField = value;
            }
        }
    }

    /// <remarks/>
    [System.Xml.Serialization.XmlTypeAttribute(AnonymousType = true, Namespace = "http://www.opentravel.org/OTA/2002/11")]
    public partial class OTA_HotelResRQHotelReservationsHotelReservationTPA_ExtensionsPK_InfoOtherPayment
    {

        private OTA_HotelResRQHotelReservationsHotelReservationTPA_ExtensionsPK_InfoOtherPaymentOPayAmt oPayAmtField;

        private System.DateTime oPayDateField;

        private string oPayReferenceNumField;

        private ushort oPayCheckNumField;

        private bool oPayReceivedField;

        private string oPayCommentsField;

        private string oPayNameField;

        private OTA_HotelResRQHotelReservationsHotelReservationTPA_ExtensionsPK_InfoOtherPaymentOBillAddress oBillAddressField;

        private OTA_HotelResRQHotelReservationsHotelReservationTPA_ExtensionsPK_InfoOtherPaymentOPhone oPhoneField;

        /// <remarks/>
        public OTA_HotelResRQHotelReservationsHotelReservationTPA_ExtensionsPK_InfoOtherPaymentOPayAmt OPayAmt
        {
            get
            {
                return this.oPayAmtField;
            }
            set
            {
                this.oPayAmtField = value;
            }
        }

        /// <remarks/>
        [System.Xml.Serialization.XmlElementAttribute(DataType = "date")]
        public System.DateTime OPayDate
        {
            get
            {
                return this.oPayDateField;
            }
            set
            {
                this.oPayDateField = value;
            }
        }

        /// <remarks/>
        public string OPayReferenceNum
        {
            get
            {
                return this.oPayReferenceNumField;
            }
            set
            {
                this.oPayReferenceNumField = value;
            }
        }

        /// <remarks/>
        public ushort OPayCheckNum
        {
            get
            {
                return this.oPayCheckNumField;
            }
            set
            {
                this.oPayCheckNumField = value;
            }
        }

        /// <remarks/>
        public bool OPayReceived
        {
            get
            {
                return this.oPayReceivedField;
            }
            set
            {
                this.oPayReceivedField = value;
            }
        }

        /// <remarks/>
        public string OPayComments
        {
            get
            {
                return this.oPayCommentsField;
            }
            set
            {
                this.oPayCommentsField = value;
            }
        }

        /// <remarks/>
        public string OPayName
        {
            get
            {
                return this.oPayNameField;
            }
            set
            {
                this.oPayNameField = value;
            }
        }

        /// <remarks/>
        public OTA_HotelResRQHotelReservationsHotelReservationTPA_ExtensionsPK_InfoOtherPaymentOBillAddress OBillAddress
        {
            get
            {
                return this.oBillAddressField;
            }
            set
            {
                this.oBillAddressField = value;
            }
        }

        /// <remarks/>
        public OTA_HotelResRQHotelReservationsHotelReservationTPA_ExtensionsPK_InfoOtherPaymentOPhone OPhone
        {
            get
            {
                return this.oPhoneField;
            }
            set
            {
                this.oPhoneField = value;
            }
        }
    }

    /// <remarks/>
    [System.Xml.Serialization.XmlTypeAttribute(AnonymousType = true, Namespace = "http://www.opentravel.org/OTA/2002/11")]
    public partial class OTA_HotelResRQHotelReservationsHotelReservationTPA_ExtensionsPK_InfoOtherPaymentOPayAmt
    {

        private ushort amountField;

        /// <remarks/>
        [System.Xml.Serialization.XmlAttributeAttribute()]
        public ushort Amount
        {
            get
            {
                return this.amountField;
            }
            set
            {
                this.amountField = value;
            }
        }
    }

    /// <remarks/>
    [System.Xml.Serialization.XmlTypeAttribute(AnonymousType = true, Namespace = "http://www.opentravel.org/OTA/2002/11")]
    public partial class OTA_HotelResRQHotelReservationsHotelReservationTPA_ExtensionsPK_InfoOtherPaymentOBillAddress
    {

        private string[] addressLineField;

        private string cityNameField;

        private ushort postalCodeField;

        private string stateProvField;

        private OTA_HotelResRQHotelReservationsHotelReservationTPA_ExtensionsPK_InfoOtherPaymentOBillAddressCountryName countryNameField;

        /// <remarks/>
        [System.Xml.Serialization.XmlElementAttribute("AddressLine")]
        public string[] AddressLine
        {
            get
            {
                return this.addressLineField;
            }
            set
            {
                this.addressLineField = value;
            }
        }

        /// <remarks/>
        public string CityName
        {
            get
            {
                return this.cityNameField;
            }
            set
            {
                this.cityNameField = value;
            }
        }

        /// <remarks/>
        public ushort PostalCode
        {
            get
            {
                return this.postalCodeField;
            }
            set
            {
                this.postalCodeField = value;
            }
        }

        /// <remarks/>
        public string StateProv
        {
            get
            {
                return this.stateProvField;
            }
            set
            {
                this.stateProvField = value;
            }
        }

        /// <remarks/>
        public OTA_HotelResRQHotelReservationsHotelReservationTPA_ExtensionsPK_InfoOtherPaymentOBillAddressCountryName CountryName
        {
            get
            {
                return this.countryNameField;
            }
            set
            {
                this.countryNameField = value;
            }
        }
    }

    /// <remarks/>
    [System.Xml.Serialization.XmlTypeAttribute(AnonymousType = true, Namespace = "http://www.opentravel.org/OTA/2002/11")]
    public partial class OTA_HotelResRQHotelReservationsHotelReservationTPA_ExtensionsPK_InfoOtherPaymentOBillAddressCountryName
    {

        private string codeField;

        private string valueField;

        /// <remarks/>
        [System.Xml.Serialization.XmlAttributeAttribute()]
        public string Code
        {
            get
            {
                return this.codeField;
            }
            set
            {
                this.codeField = value;
            }
        }

        /// <remarks/>
        [System.Xml.Serialization.XmlTextAttribute()]
        public string Value
        {
            get
            {
                return this.valueField;
            }
            set
            {
                this.valueField = value;
            }
        }
    }

    /// <remarks/>
    [System.Xml.Serialization.XmlTypeAttribute(AnonymousType = true, Namespace = "http://www.opentravel.org/OTA/2002/11")]
    public partial class OTA_HotelResRQHotelReservationsHotelReservationTPA_ExtensionsPK_InfoOtherPaymentOPhone
    {

        private ulong phoneNumberField;

        /// <remarks/>
        [System.Xml.Serialization.XmlAttributeAttribute()]
        public ulong PhoneNumber
        {
            get
            {
                return this.phoneNumberField;
            }
            set
            {
                this.phoneNumberField = value;
            }
        }
    }

    /// <remarks/>
    [System.Xml.Serialization.XmlTypeAttribute(AnonymousType = true, Namespace = "http://www.opentravel.org/OTA/2002/11")]
    public partial class OTA_HotelResRQHotelReservationsHotelReservationTPA_ExtensionsPK_InfoBillPhone
    {

        private ulong phoneNumberField;

        /// <remarks/>
        [System.Xml.Serialization.XmlAttributeAttribute()]
        public ulong PhoneNumber
        {
            get
            {
                return this.phoneNumberField;
            }
            set
            {
                this.phoneNumberField = value;
            }
        }
    }

    /// <remarks/>
    [System.Xml.Serialization.XmlTypeAttribute(AnonymousType = true, Namespace = "http://www.opentravel.org/OTA/2002/11")]
    public partial class OTA_HotelResRQHotelReservationsHotelReservationTPA_ExtensionsPK_InfoCustomFields
    {

        private string customField1Field;

        private string customField2Field;

        private string customField3Field;

        private string customField4Field;

        private string customField5Field;

        /// <remarks/>
        public string CustomField1
        {
            get
            {
                return this.customField1Field;
            }
            set
            {
                this.customField1Field = value;
            }
        }

        /// <remarks/>
        public string CustomField2
        {
            get
            {
                return this.customField2Field;
            }
            set
            {
                this.customField2Field = value;
            }
        }

        /// <remarks/>
        public string CustomField3
        {
            get
            {
                return this.customField3Field;
            }
            set
            {
                this.customField3Field = value;
            }
        }

        /// <remarks/>
        public string CustomField4
        {
            get
            {
                return this.customField4Field;
            }
            set
            {
                this.customField4Field = value;
            }
        }

        /// <remarks/>
        public string CustomField5
        {
            get
            {
                return this.customField5Field;
            }
            set
            {
                this.customField5Field = value;
            }
        }
    }


}
