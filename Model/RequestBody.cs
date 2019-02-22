/* 
 * CyberSource Flex API
 *
 * Simple PAN tokenization service
 *
 * OpenAPI spec version: 0.0.1
 * 
 * Generated by: https://github.com/swagger-api/swagger-codegen.git
 */

using System;
using System.Linq;
using System.IO;
using System.Text;
using System.Text.RegularExpressions;
using System.Collections;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.Runtime.Serialization;
using Newtonsoft.Json;
using Newtonsoft.Json.Converters;
using System.ComponentModel.DataAnnotations;
using SwaggerDateConverter = CyberSource.Client.SwaggerDateConverter;

namespace CyberSource.Model
{
    /// <summary>
    /// RequestBody
    /// </summary>
    [DataContract]
    public partial class RequestBody :  IEquatable<RequestBody>, IValidatableObject
    {
        /// <summary>
        /// Gets or Sets ReportMimeType
        /// </summary>
        [JsonConverter(typeof(StringEnumConverter))]
        public enum ReportMimeTypeEnum
        {
            
            /// <summary>
            /// Enum ApplicationXml for "application/xml"
            /// </summary>
            [EnumMember(Value = "application/xml")]
            ApplicationXml,
            
            /// <summary>
            /// Enum TextCsv for "text/csv"
            /// </summary>
            [EnumMember(Value = "text/csv")]
            TextCsv
        }

        /// <summary>
        /// Gets or Sets ReportMimeType
        /// </summary>
        [DataMember(Name="reportMimeType", EmitDefaultValue=false)]
        public ReportMimeTypeEnum? ReportMimeType { get; set; }
        /// <summary>
        /// Initializes a new instance of the <see cref="RequestBody" /> class.
        /// </summary>
        [JsonConstructorAttribute]
        protected RequestBody() { }
        /// <summary>
        /// Initializes a new instance of the <see cref="RequestBody" /> class.
        /// </summary>
        /// <param name="OrganizationId">OrganizationId.</param>
        /// <param name="ReportDefinitionName">ReportDefinitionName (required).</param>
        /// <param name="ReportFields">ReportFields (required).</param>
        /// <param name="ReportMimeType">ReportMimeType.</param>
        /// <param name="ReportFrequency">ReportFrequency.</param>
        /// <param name="ReportName">ReportName (required).</param>
        /// <param name="Timezone">Timezone.</param>
        /// <param name="StartTime">StartTime.</param>
        /// <param name="StartDay">StartDay.</param>
        /// <param name="ReportFilters">ReportFilters.</param>
        /// <param name="ReportPreferences">ReportPreferences.</param>
        /// <param name="SelectedMerchantGroupName">SelectedMerchantGroupName.</param>
        public RequestBody(string OrganizationId = default(string), string ReportDefinitionName = default(string), List<string> ReportFields = default(List<string>), ReportMimeTypeEnum? ReportMimeType = default(ReportMimeTypeEnum?), string ReportFrequency = default(string), string ReportName = default(string), string Timezone = default(string), DateTime? StartTime = default(DateTime?), int? StartDay = default(int?), Dictionary<string, List<string>> ReportFilters = default(Dictionary<string, List<string>>), ReportingV3ReportSubscriptionsGet200ResponseReportPreferences ReportPreferences = default(ReportingV3ReportSubscriptionsGet200ResponseReportPreferences), string SelectedMerchantGroupName = default(string))
        {
            // to ensure "ReportDefinitionName" is required (not null)
            if (ReportDefinitionName == null)
            {
                throw new InvalidDataException("ReportDefinitionName is a required property for RequestBody and cannot be null");
            }
            else
            {
                this.ReportDefinitionName = ReportDefinitionName;
            }
            // to ensure "ReportFields" is required (not null)
            if (ReportFields == null)
            {
                throw new InvalidDataException("ReportFields is a required property for RequestBody and cannot be null");
            }
            else
            {
                this.ReportFields = ReportFields;
            }
            // to ensure "ReportName" is required (not null)
            if (ReportName == null)
            {
                throw new InvalidDataException("ReportName is a required property for RequestBody and cannot be null");
            }
            else
            {
                this.ReportName = ReportName;
            }
            this.OrganizationId = OrganizationId;
            this.ReportMimeType = ReportMimeType;
            this.ReportFrequency = ReportFrequency;
            this.Timezone = Timezone;
            this.StartTime = StartTime;
            this.StartDay = StartDay;
            this.ReportFilters = ReportFilters;
            this.ReportPreferences = ReportPreferences;
            this.SelectedMerchantGroupName = SelectedMerchantGroupName;
        }
        
        /// <summary>
        /// Gets or Sets OrganizationId
        /// </summary>
        [DataMember(Name="organizationId", EmitDefaultValue=false)]
        public string OrganizationId { get; set; }

        /// <summary>
        /// Gets or Sets ReportDefinitionName
        /// </summary>
        [DataMember(Name="reportDefinitionName", EmitDefaultValue=false)]
        public string ReportDefinitionName { get; set; }

        /// <summary>
        /// Gets or Sets ReportFields
        /// </summary>
        [DataMember(Name="reportFields", EmitDefaultValue=false)]
        public List<string> ReportFields { get; set; }


        /// <summary>
        /// Gets or Sets ReportFrequency
        /// </summary>
        [DataMember(Name="reportFrequency", EmitDefaultValue=false)]
        public string ReportFrequency { get; set; }

        /// <summary>
        /// Gets or Sets ReportName
        /// </summary>
        [DataMember(Name="reportName", EmitDefaultValue=false)]
        public string ReportName { get; set; }

        /// <summary>
        /// Gets or Sets Timezone
        /// </summary>
        [DataMember(Name="timezone", EmitDefaultValue=false)]
        public string Timezone { get; set; }

        /// <summary>
        /// Gets or Sets StartTime
        /// </summary>
        [DataMember(Name="startTime", EmitDefaultValue=false)]
        public DateTime? StartTime { get; set; }

        /// <summary>
        /// Gets or Sets StartDay
        /// </summary>
        [DataMember(Name="startDay", EmitDefaultValue=false)]
        public int? StartDay { get; set; }

        /// <summary>
        /// Gets or Sets ReportFilters
        /// </summary>
        [DataMember(Name="reportFilters", EmitDefaultValue=false)]
        public Dictionary<string, List<string>> ReportFilters { get; set; }

        /// <summary>
        /// Gets or Sets ReportPreferences
        /// </summary>
        [DataMember(Name="reportPreferences", EmitDefaultValue=false)]
        public ReportingV3ReportSubscriptionsGet200ResponseReportPreferences ReportPreferences { get; set; }

        /// <summary>
        /// Gets or Sets SelectedMerchantGroupName
        /// </summary>
        [DataMember(Name="selectedMerchantGroupName", EmitDefaultValue=false)]
        public string SelectedMerchantGroupName { get; set; }

        /// <summary>
        /// Returns the string presentation of the object
        /// </summary>
        /// <returns>String presentation of the object</returns>
        public override string ToString()
        {
            var sb = new StringBuilder();
            sb.Append("class RequestBody {\n");
            sb.Append("  OrganizationId: ").Append(OrganizationId).Append("\n");
            sb.Append("  ReportDefinitionName: ").Append(ReportDefinitionName).Append("\n");
            sb.Append("  ReportFields: ").Append(ReportFields).Append("\n");
            sb.Append("  ReportMimeType: ").Append(ReportMimeType).Append("\n");
            sb.Append("  ReportFrequency: ").Append(ReportFrequency).Append("\n");
            sb.Append("  ReportName: ").Append(ReportName).Append("\n");
            sb.Append("  Timezone: ").Append(Timezone).Append("\n");
            sb.Append("  StartTime: ").Append(StartTime).Append("\n");
            sb.Append("  StartDay: ").Append(StartDay).Append("\n");
            sb.Append("  ReportFilters: ").Append(ReportFilters).Append("\n");
            sb.Append("  ReportPreferences: ").Append(ReportPreferences).Append("\n");
            sb.Append("  SelectedMerchantGroupName: ").Append(SelectedMerchantGroupName).Append("\n");
            sb.Append("}\n");
            return sb.ToString();
        }
  
        /// <summary>
        /// Returns the JSON string presentation of the object
        /// </summary>
        /// <returns>JSON string presentation of the object</returns>
        public string ToJson()
        {
            return JsonConvert.SerializeObject(this, Formatting.Indented);
        }

        /// <summary>
        /// Returns true if objects are equal
        /// </summary>
        /// <param name="obj">Object to be compared</param>
        /// <returns>Boolean</returns>
        public override bool Equals(object obj)
        {
            // credit: http://stackoverflow.com/a/10454552/677735
            return this.Equals(obj as RequestBody);
        }

        /// <summary>
        /// Returns true if RequestBody instances are equal
        /// </summary>
        /// <param name="other">Instance of RequestBody to be compared</param>
        /// <returns>Boolean</returns>
        public bool Equals(RequestBody other)
        {
            // credit: http://stackoverflow.com/a/10454552/677735
            if (other == null)
                return false;

            return 
                (
                    this.OrganizationId == other.OrganizationId ||
                    this.OrganizationId != null &&
                    this.OrganizationId.Equals(other.OrganizationId)
                ) && 
                (
                    this.ReportDefinitionName == other.ReportDefinitionName ||
                    this.ReportDefinitionName != null &&
                    this.ReportDefinitionName.Equals(other.ReportDefinitionName)
                ) && 
                (
                    this.ReportFields == other.ReportFields ||
                    this.ReportFields != null &&
                    this.ReportFields.SequenceEqual(other.ReportFields)
                ) && 
                (
                    this.ReportMimeType == other.ReportMimeType ||
                    this.ReportMimeType != null &&
                    this.ReportMimeType.Equals(other.ReportMimeType)
                ) && 
                (
                    this.ReportFrequency == other.ReportFrequency ||
                    this.ReportFrequency != null &&
                    this.ReportFrequency.Equals(other.ReportFrequency)
                ) && 
                (
                    this.ReportName == other.ReportName ||
                    this.ReportName != null &&
                    this.ReportName.Equals(other.ReportName)
                ) && 
                (
                    this.Timezone == other.Timezone ||
                    this.Timezone != null &&
                    this.Timezone.Equals(other.Timezone)
                ) && 
                (
                    this.StartTime == other.StartTime ||
                    this.StartTime != null &&
                    this.StartTime.Equals(other.StartTime)
                ) && 
                (
                    this.StartDay == other.StartDay ||
                    this.StartDay != null &&
                    this.StartDay.Equals(other.StartDay)
                ) && 
                (
                    this.ReportFilters == other.ReportFilters ||
                    this.ReportFilters != null &&
                    this.ReportFilters.SequenceEqual(other.ReportFilters)
                ) && 
                (
                    this.ReportPreferences == other.ReportPreferences ||
                    this.ReportPreferences != null &&
                    this.ReportPreferences.Equals(other.ReportPreferences)
                ) && 
                (
                    this.SelectedMerchantGroupName == other.SelectedMerchantGroupName ||
                    this.SelectedMerchantGroupName != null &&
                    this.SelectedMerchantGroupName.Equals(other.SelectedMerchantGroupName)
                );
        }

        /// <summary>
        /// Gets the hash code
        /// </summary>
        /// <returns>Hash code</returns>
        public override int GetHashCode()
        {
            // credit: http://stackoverflow.com/a/263416/677735
            unchecked // Overflow is fine, just wrap
            {
                int hash = 41;
                // Suitable nullity checks etc, of course :)
                if (this.OrganizationId != null)
                    hash = hash * 59 + this.OrganizationId.GetHashCode();
                if (this.ReportDefinitionName != null)
                    hash = hash * 59 + this.ReportDefinitionName.GetHashCode();
                if (this.ReportFields != null)
                    hash = hash * 59 + this.ReportFields.GetHashCode();
                if (this.ReportMimeType != null)
                    hash = hash * 59 + this.ReportMimeType.GetHashCode();
                if (this.ReportFrequency != null)
                    hash = hash * 59 + this.ReportFrequency.GetHashCode();
                if (this.ReportName != null)
                    hash = hash * 59 + this.ReportName.GetHashCode();
                if (this.Timezone != null)
                    hash = hash * 59 + this.Timezone.GetHashCode();
                if (this.StartTime != null)
                    hash = hash * 59 + this.StartTime.GetHashCode();
                if (this.StartDay != null)
                    hash = hash * 59 + this.StartDay.GetHashCode();
                if (this.ReportFilters != null)
                    hash = hash * 59 + this.ReportFilters.GetHashCode();
                if (this.ReportPreferences != null)
                    hash = hash * 59 + this.ReportPreferences.GetHashCode();
                if (this.SelectedMerchantGroupName != null)
                    hash = hash * 59 + this.SelectedMerchantGroupName.GetHashCode();
                return hash;
            }
        }

        /// <summary>
        /// To validate all properties of the instance
        /// </summary>
        /// <param name="validationContext">Validation context</param>
        /// <returns>Validation Result</returns>
        IEnumerable<System.ComponentModel.DataAnnotations.ValidationResult> IValidatableObject.Validate(ValidationContext validationContext)
        {
            // OrganizationId (string) pattern
            Regex regexOrganizationId = new Regex(@"[a-zA-Z0-9-_]+", RegexOptions.CultureInvariant);
            if (false == regexOrganizationId.Match(this.OrganizationId).Success)
            {
                yield return new System.ComponentModel.DataAnnotations.ValidationResult("Invalid value for OrganizationId, must match a pattern of " + regexOrganizationId, new [] { "OrganizationId" });
            }

            // ReportDefinitionName (string) maxLength
            if(this.ReportDefinitionName != null && this.ReportDefinitionName.Length > 80)
            {
                yield return new System.ComponentModel.DataAnnotations.ValidationResult("Invalid value for ReportDefinitionName, length must be less than 80.", new [] { "ReportDefinitionName" });
            }

            // ReportDefinitionName (string) minLength
            if(this.ReportDefinitionName != null && this.ReportDefinitionName.Length < 1)
            {
                yield return new System.ComponentModel.DataAnnotations.ValidationResult("Invalid value for ReportDefinitionName, length must be greater than 1.", new [] { "ReportDefinitionName" });
            }

            // ReportDefinitionName (string) pattern
            Regex regexReportDefinitionName = new Regex(@"[a-zA-Z0-9-]+", RegexOptions.CultureInvariant);
            if (false == regexReportDefinitionName.Match(this.ReportDefinitionName).Success)
            {
                yield return new System.ComponentModel.DataAnnotations.ValidationResult("Invalid value for ReportDefinitionName, must match a pattern of " + regexReportDefinitionName, new [] { "ReportDefinitionName" });
            }

            // ReportName (string) maxLength
            if(this.ReportName != null && this.ReportName.Length > 128)
            {
                yield return new System.ComponentModel.DataAnnotations.ValidationResult("Invalid value for ReportName, length must be less than 128.", new [] { "ReportName" });
            }

            // ReportName (string) minLength
            if(this.ReportName != null && this.ReportName.Length < 1)
            {
                yield return new System.ComponentModel.DataAnnotations.ValidationResult("Invalid value for ReportName, length must be greater than 1.", new [] { "ReportName" });
            }

            // ReportName (string) pattern
            Regex regexReportName = new Regex(@"[a-zA-Z0-9-_ ]+", RegexOptions.CultureInvariant);
            if (false == regexReportName.Match(this.ReportName).Success)
            {
                yield return new System.ComponentModel.DataAnnotations.ValidationResult("Invalid value for ReportName, must match a pattern of " + regexReportName, new [] { "ReportName" });
            }

            // StartDay (int?) maximum
            if(this.StartDay > (int?)7)
            {
                yield return new System.ComponentModel.DataAnnotations.ValidationResult("Invalid value for StartDay, must be a value less than or equal to 7.", new [] { "StartDay" });
            }

            // StartDay (int?) minimum
            if(this.StartDay < (int?)1)
            {
                yield return new System.ComponentModel.DataAnnotations.ValidationResult("Invalid value for StartDay, must be a value greater than or equal to 1.", new [] { "StartDay" });
            }

            // SelectedMerchantGroupName (string) pattern
            Regex regexSelectedMerchantGroupName = new Regex(@"[0-9]*", RegexOptions.CultureInvariant);
            if (false == regexSelectedMerchantGroupName.Match(this.SelectedMerchantGroupName).Success)
            {
                yield return new System.ComponentModel.DataAnnotations.ValidationResult("Invalid value for SelectedMerchantGroupName, must match a pattern of " + regexSelectedMerchantGroupName, new [] { "SelectedMerchantGroupName" });
            }

            yield break;
        }
    }

}
