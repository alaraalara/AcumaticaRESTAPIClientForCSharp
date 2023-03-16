using Acumatica.RESTClient.Client;
using Acumatica.Manufacturing_21_200_001.Model;

namespace Acumatica.Manufacturing_21_200_001.Api
{
	public class ToolApi : BaseEndpointApi<Tool>
	{
		public ToolApi(ApiClient client) : base(client)
		{ }
	}
}