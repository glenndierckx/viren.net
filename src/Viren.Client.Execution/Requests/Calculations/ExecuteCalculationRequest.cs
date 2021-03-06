using System;
using System.Collections.Generic;
using Viren.Client.Execution.Core.Dtos;

namespace Viren.Client.Execution.Requests.Calculations
{
    public class ExecuteCalculationRequest
    {
        public string RequestId = Guid.NewGuid().ToString();

        public IDictionary<string, object> Globals = new Dictionary<string, object>();

        public IDictionary<string, object> Root = new Dictionary<string, object>();

        public string Project { get; set; }

        public string Model { get; set; }

        public int Version { get; set; }

        public int? Revision { get; set; }

        public string EntryPoint { get; set; }

        public bool? Debug { get; set; }

        public bool? Full { get; set; }
    }

    public class ExecuteCalculationResponse
    {
        public IDictionary<string, object> Result { get; set; }

        public bool IsValid { get; set; }

        public IList<ValidationMessage> ValidationMessages { get; set; }
    }
}