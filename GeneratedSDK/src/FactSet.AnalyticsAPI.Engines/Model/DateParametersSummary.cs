/* 
 * Engines API
 *
 * Allow clients to fetch Engines Analytics through APIs.
 *
 * The version of the OpenAPI document: 2
 * Contact: analytics.api.support@factset.com
 * Generated by: https://github.com/openapitools/openapi-generator.git
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
using OpenAPIDateConverter = FactSet.AnalyticsAPI.Engines.Client.OpenAPIDateConverter;

namespace FactSet.AnalyticsAPI.Engines.Model
{
    /// <summary>
    /// DateParametersSummary
    /// </summary>
    [DataContract]
    public partial class DateParametersSummary :  IEquatable<DateParametersSummary>, IValidatableObject
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="DateParametersSummary" /> class.
        /// </summary>
        /// <param name="startdate">Start date in YYYYMMDD format..</param>
        /// <param name="enddate">End date in YYYYMMDD format..</param>
        public DateParametersSummary(string startdate = default(string), string enddate = default(string))
        {
            this.Startdate = startdate;
            this.Enddate = enddate;
        }
        
        /// <summary>
        /// Start date in YYYYMMDD format.
        /// </summary>
        /// <value>Start date in YYYYMMDD format.</value>
        [DataMember(Name="startdate", EmitDefaultValue=false)]
        public string Startdate { get; set; }

        /// <summary>
        /// End date in YYYYMMDD format.
        /// </summary>
        /// <value>End date in YYYYMMDD format.</value>
        [DataMember(Name="enddate", EmitDefaultValue=false)]
        public string Enddate { get; set; }

        /// <summary>
        /// Returns the string presentation of the object
        /// </summary>
        /// <returns>String presentation of the object</returns>
        public override string ToString()
        {
            var sb = new StringBuilder();
            sb.Append("class DateParametersSummary {\n");
            sb.Append("  Startdate: ").Append(Startdate).Append("\n");
            sb.Append("  Enddate: ").Append(Enddate).Append("\n");
            sb.Append("}\n");
            return sb.ToString();
        }
  
        /// <summary>
        /// Returns the JSON string presentation of the object
        /// </summary>
        /// <returns>JSON string presentation of the object</returns>
        public virtual string ToJson()
        {
            return JsonConvert.SerializeObject(this, Formatting.Indented);
        }

        /// <summary>
        /// Returns true if objects are equal
        /// </summary>
        /// <param name="input">Object to be compared</param>
        /// <returns>Boolean</returns>
        public override bool Equals(object input)
        {
            return this.Equals(input as DateParametersSummary);
        }

        /// <summary>
        /// Returns true if DateParametersSummary instances are equal
        /// </summary>
        /// <param name="input">Instance of DateParametersSummary to be compared</param>
        /// <returns>Boolean</returns>
        public bool Equals(DateParametersSummary input)
        {
            if (input == null)
                return false;

            return 
                (
                    this.Startdate == input.Startdate ||
                    (this.Startdate != null &&
                    this.Startdate.Equals(input.Startdate))
                ) && 
                (
                    this.Enddate == input.Enddate ||
                    (this.Enddate != null &&
                    this.Enddate.Equals(input.Enddate))
                );
        }

        /// <summary>
        /// Gets the hash code
        /// </summary>
        /// <returns>Hash code</returns>
        public override int GetHashCode()
        {
            unchecked // Overflow is fine, just wrap
            {
                int hashCode = 41;
                if (this.Startdate != null)
                    hashCode = hashCode * 59 + this.Startdate.GetHashCode();
                if (this.Enddate != null)
                    hashCode = hashCode * 59 + this.Enddate.GetHashCode();
                return hashCode;
            }
        }

        /// <summary>
        /// To validate all properties of the instance
        /// </summary>
        /// <param name="validationContext">Validation context</param>
        /// <returns>Validation Result</returns>
        IEnumerable<System.ComponentModel.DataAnnotations.ValidationResult> IValidatableObject.Validate(ValidationContext validationContext)
        {
            yield break;
        }
    }

}
