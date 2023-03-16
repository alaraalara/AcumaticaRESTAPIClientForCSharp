using Acumatica.RESTClient.Client;
using Acumatica.Manufacturing_20_200_001.Model;

namespace Acumatica.Manufacturing_20_200_001.Api
{
	public class DisassemblyEntryApi : BaseEndpointApi<DisassemblyEntry>
	{
		public DisassemblyEntryApi(ApiClient client) : base(client)
		{ }
	}
}