using System.Collections.Generic;
using System.Runtime.Serialization;

using Newtonsoft.Json;

using Acumatica.RESTClient.Client;
using Acumatica.RESTClient.ContractBasedApi;
using Acumatica.RESTClient.ContractBasedApi.Model;

namespace Acumatica.Manufacturing_23_100_001.Model
{
	[DataContract]
	public class RoughCutPlanning : Entity
	{

		[DataMember(Name="Detail", EmitDefaultValue=false)]
		public List<RoughCutPlanningDetail> Detail { get; set; }

		[DataMember(Name="ExcludeFirmOrders", EmitDefaultValue=false)]
		public BooleanValue ExcludeFirmOrders { get; set; }

		[DataMember(Name="ExcludePlanningOrders", EmitDefaultValue=false)]
		public BooleanValue ExcludePlanningOrders { get; set; }

		[DataMember(Name="ProcessAction", EmitDefaultValue=false)]
		public StringValue ProcessAction { get; set; }

		[DataMember(Name="ReleaseOrders", EmitDefaultValue=false)]
		public BooleanValue ReleaseOrders { get; set; }

	}
}