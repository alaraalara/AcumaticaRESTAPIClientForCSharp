using System.Collections.Generic;
using System.Runtime.Serialization;

using Newtonsoft.Json;

using Acumatica.RESTClient.Client;
using Acumatica.RESTClient.ContractBasedApi;
using Acumatica.RESTClient.ContractBasedApi.Model;

namespace Acumatica.Default_22_200_001.Model
{
	[DataContract]
	public class Budget : Entity
	{

		[DataMember(Name="Branch", EmitDefaultValue=false)]
		public StringValue Branch { get; set; }

		[DataMember(Name="ComparetoBranch", EmitDefaultValue=false)]
		public StringValue ComparetoBranch { get; set; }

		[DataMember(Name="ComparetoLedger", EmitDefaultValue=false)]
		public StringValue ComparetoLedger { get; set; }

		[DataMember(Name="ComparetoYear", EmitDefaultValue=false)]
		public StringValue ComparetoYear { get; set; }

		[DataMember(Name="Details", EmitDefaultValue=false)]
		public List<BudgetDetail> Details { get; set; }

		[DataMember(Name="FinancialYear", EmitDefaultValue=false)]
		public StringValue FinancialYear { get; set; }

		[DataMember(Name="Ledger", EmitDefaultValue=false)]
		public StringValue Ledger { get; set; }

		[DataMember(Name="SubaccountFilter", EmitDefaultValue=false)]
		public StringValue SubaccountFilter { get; set; }

		[DataMember(Name="TreeNodeFilter", EmitDefaultValue=false)]
		public StringValue TreeNodeFilter { get; set; }

	}
}