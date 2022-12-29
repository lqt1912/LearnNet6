using LearnNet6.Data.Entity;
using Newtonsoft.Json;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Text.Json.Serialization;

namespace LearnNet6.Models
{
    public class AdUser
    {

        [Column("UserPrincipalName")]
        public string userPrincipalName { get; set; }

        [Column("DisplayName")]
        public string displayName { get; set; }

        [Column("Surname")]
        public string surname { get; set; }

        [Column("Mail")]
        public string mail { get; set; }

        [Column("GivenName")]
        public string givenName { get; set; }

        [Column("OId")]
        [JsonProperty("OId")]
        [JsonPropertyName("OId")]
        public string id { get; set; }

        [Column("UserType")]
        public string userType { get; set; }

        [Column("JobTitle")]
        public string jobTitle { get; set; }

        [Column("Department")]
        public string department { get; set; }

        [Column("AccountEnabled")]
        public string accountEnabled { get; set; }

        [Column("UsageLocation")]
        public string usageLocation { get; set; }

        [Column("StreetAddress")]
        public string streetAddress { get; set; }
        
        [Column("State")]
        public string state { get; set; }
        
        [Column("Country")]
        public string country { get; set; }
        
        [Column("OfficeLocation")]
        public string officeLocation { get; set; }
        
        [Column("City")]
        public string city { get; set; }
        
        [Column("PostalCode")]
        public string postalCode { get; set; }
        
        [Column("TelephoneNumber")]
        public string telephoneNumber { get; set; }

        [Column("MobilePhone")]
        public string mobilePhone { get; set; }

        [Column("AlternateEmailAddress")]
        public string alternateEmailAddress { get; set; }

        [Column("AgeGroup")]
        public string ageGroup { get; set; }

        [Column("ConsentProvidedForMinor")]
        public string consentProvidedForMinor { get; set; }

        [Column("LegalAgeGroupClassification")]
        public string legalAgeGroupClassification { get; set; }

        [Column("CompanyName")]
        public string companyName { get; set; }

        [Column("CreationType")]
        public string creationType { get; set; }

        [Column("DirectorySynced")]
        public string directorySynced { get; set; }

        [Column("InvitationState")]
        public string invitationState { get; set; }

        [Column("IdentityIssuer")]
        public string identityIssuer { get; set; }

        [Column("CreatedDateTime")]
        public string createdDateTime { get; set; }
        [Key]
        public Guid Id { get; set; }


        public virtual List<NotificationToken> NotificationTokens { get; set; }

    }
}
