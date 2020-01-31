using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.Linq;
using Acumatica.RESTClient.Api;
using Acumatica.RESTClient.Client;
using Acumatica.DeviceHub_19_200_001.Model;

namespace Acumatica.DeviceHub_19_200_001.Api
{
    public partial class PrintJobApi : EntityAPI<PrintJob>
    {
        public PrintJobApi() : base()
        {
        }
        public PrintJobApi(Configuration configuration) : base(configuration)
        {
        }
    }
}
