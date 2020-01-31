/* 
 * DeviceHub/19.200.001
 *
 * No description provided (generated by Swagger Codegen https://github.com/swagger-api/swagger-codegen)
 *
 * OpenAPI spec version: 3
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
using Acumatica.RESTClient.Model;

namespace Acumatica.DeviceHub_19_200_001.Model
{
    /// <summary>
    /// PrintJob
    /// </summary>
    [DataContract]
    public partial class PrintJob : Entity,  IEquatable<PrintJob>, IValidatableObject
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="PrintJob" /> class.
        /// </summary>
        /// <param name="createdBy">createdBy.</param>
        /// <param name="creationDateTime">creationDateTime.</param>
        /// <param name="description">description.</param>
        /// <param name="jobID">jobID.</param>
        /// <param name="deviceHub">deviceHub.</param>
        /// <param name="printer">printer.</param>
        /// <param name="reportID">reportID.</param>
        /// <param name="selected">selected.</param>
        /// <param name="status">status.</param>
        public PrintJob(StringValue createdBy = default(StringValue), DateTimeValue creationDateTime = default(DateTimeValue), StringValue description = default(StringValue), IntValue jobID = default(IntValue), StringValue deviceHub = default(StringValue), StringValue printer = default(StringValue), StringValue reportID = default(StringValue), BooleanValue selected = default(BooleanValue), StringValue status = default(StringValue), Guid? id = default(Guid?), long? rowNumber = default(long?), string note = default(string), Dictionary<string, Dictionary<string, CustomField>> custom = default(Dictionary<string, Dictionary<string, CustomField>>), List<FileLink> files = default(List<FileLink>)) : base(id, rowNumber, note, custom, files)
        {
            this.CreatedBy = createdBy;
            this.CreationDateTime = creationDateTime;
            this.Description = description;
            this.JobID = jobID;
            this.DeviceHub = deviceHub;
            this.Printer = printer;
            this.ReportID = reportID;
            this.Selected = selected;
            this.Status = status;
        }
        
        /// <summary>
        /// Gets or Sets CreatedBy
        /// </summary>
        [DataMember(Name="CreatedBy", EmitDefaultValue=false)]
        public StringValue CreatedBy { get; set; }

        /// <summary>
        /// Gets or Sets CreationDateTime
        /// </summary>
        [DataMember(Name="CreationDateTime", EmitDefaultValue=false)]
        public DateTimeValue CreationDateTime { get; set; }

        /// <summary>
        /// Gets or Sets Description
        /// </summary>
        [DataMember(Name="Description", EmitDefaultValue=false)]
        public StringValue Description { get; set; }

        /// <summary>
        /// Gets or Sets JobID
        /// </summary>
        [DataMember(Name="JobID", EmitDefaultValue=false)]
        public IntValue JobID { get; set; }

        /// <summary>
        /// Gets or Sets DeviceHub
        /// </summary>
        [DataMember(Name="DeviceHub", EmitDefaultValue=false)]
        public StringValue DeviceHub { get; set; }

        /// <summary>
        /// Gets or Sets Printer
        /// </summary>
        [DataMember(Name="Printer", EmitDefaultValue=false)]
        public StringValue Printer { get; set; }

        /// <summary>
        /// Gets or Sets ReportID
        /// </summary>
        [DataMember(Name="ReportID", EmitDefaultValue=false)]
        public StringValue ReportID { get; set; }

        /// <summary>
        /// Gets or Sets Selected
        /// </summary>
        [DataMember(Name="Selected", EmitDefaultValue=false)]
        public BooleanValue Selected { get; set; }

        /// <summary>
        /// Gets or Sets Status
        /// </summary>
        [DataMember(Name="Status", EmitDefaultValue=false)]
        public StringValue Status { get; set; }

        /// <summary>
        /// Returns the string presentation of the object
        /// </summary>
        /// <returns>String presentation of the object</returns>
        public override string ToString()
        {
            var sb = new StringBuilder();
            sb.Append("class PrintJob {\n");
            sb.Append("  ").Append(base.ToString().Replace("\n", "\n  ")).Append("\n");
            sb.Append("  CreatedBy: ").Append(CreatedBy).Append("\n");
            sb.Append("  CreationDateTime: ").Append(CreationDateTime).Append("\n");
            sb.Append("  Description: ").Append(Description).Append("\n");
            sb.Append("  JobID: ").Append(JobID).Append("\n");
            sb.Append("  DeviceHub: ").Append(DeviceHub).Append("\n");
            sb.Append("  Printer: ").Append(Printer).Append("\n");
            sb.Append("  ReportID: ").Append(ReportID).Append("\n");
            sb.Append("  Selected: ").Append(Selected).Append("\n");
            sb.Append("  Status: ").Append(Status).Append("\n");
            sb.Append("}\n");
            return sb.ToString();
        }
  
        /// <summary>
        /// Returns the JSON string presentation of the object
        /// </summary>
        /// <returns>JSON string presentation of the object</returns>
        public override string ToJson()
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
            return this.Equals(input as PrintJob);
        }

        /// <summary>
        /// Returns true if PrintJob instances are equal
        /// </summary>
        /// <param name="input">Instance of PrintJob to be compared</param>
        /// <returns>Boolean</returns>
        public bool Equals(PrintJob input)
        {
            if (input == null)
                return false;

            return base.Equals(input) && 
                (
                    this.CreatedBy == input.CreatedBy ||
                    (this.CreatedBy != null &&
                    this.CreatedBy.Equals(input.CreatedBy))
                ) && base.Equals(input) && 
                (
                    this.CreationDateTime == input.CreationDateTime ||
                    (this.CreationDateTime != null &&
                    this.CreationDateTime.Equals(input.CreationDateTime))
                ) && base.Equals(input) && 
                (
                    this.Description == input.Description ||
                    (this.Description != null &&
                    this.Description.Equals(input.Description))
                ) && base.Equals(input) && 
                (
                    this.JobID == input.JobID ||
                    (this.JobID != null &&
                    this.JobID.Equals(input.JobID))
                ) && base.Equals(input) && 
                (
                    this.DeviceHub == input.DeviceHub ||
                    (this.DeviceHub != null &&
                    this.DeviceHub.Equals(input.DeviceHub))
                ) && base.Equals(input) && 
                (
                    this.Printer == input.Printer ||
                    (this.Printer != null &&
                    this.Printer.Equals(input.Printer))
                ) && base.Equals(input) && 
                (
                    this.ReportID == input.ReportID ||
                    (this.ReportID != null &&
                    this.ReportID.Equals(input.ReportID))
                ) && base.Equals(input) && 
                (
                    this.Selected == input.Selected ||
                    (this.Selected != null &&
                    this.Selected.Equals(input.Selected))
                ) && base.Equals(input) && 
                (
                    this.Status == input.Status ||
                    (this.Status != null &&
                    this.Status.Equals(input.Status))
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
                int hashCode = base.GetHashCode();
                if (this.CreatedBy != null)
                    hashCode = hashCode * 59 + this.CreatedBy.GetHashCode();
                if (this.CreationDateTime != null)
                    hashCode = hashCode * 59 + this.CreationDateTime.GetHashCode();
                if (this.Description != null)
                    hashCode = hashCode * 59 + this.Description.GetHashCode();
                if (this.JobID != null)
                    hashCode = hashCode * 59 + this.JobID.GetHashCode();
                if (this.DeviceHub != null)
                    hashCode = hashCode * 59 + this.DeviceHub.GetHashCode();
                if (this.Printer != null)
                    hashCode = hashCode * 59 + this.Printer.GetHashCode();
                if (this.ReportID != null)
                    hashCode = hashCode * 59 + this.ReportID.GetHashCode();
                if (this.Selected != null)
                    hashCode = hashCode * 59 + this.Selected.GetHashCode();
                if (this.Status != null)
                    hashCode = hashCode * 59 + this.Status.GetHashCode();
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
            foreach(var x in BaseValidate(validationContext)) yield return x;
            yield break;
        }
    }

}
