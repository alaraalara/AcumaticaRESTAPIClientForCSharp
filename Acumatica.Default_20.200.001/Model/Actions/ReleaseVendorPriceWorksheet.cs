using System.Collections.Generic;
using System.Runtime.Serialization;

using Newtonsoft.Json;

using Acumatica.RESTClient.Client;
using Acumatica.RESTClient.ContractBasedApi;
using Acumatica.RESTClient.ContractBasedApi.Model;

namespace Acumatica.Default_20_200_001.Model
{
	[DataContract]
	public class ReleaseVendorPriceWorksheet : EntityAction<VendorPriceWorksheet>
	{
		public ReleaseVendorPriceWorksheet(VendorPriceWorksheet entity) : base(entity)
		{ }
		public ReleaseVendorPriceWorksheet() : base()
		{ }
	}
}
