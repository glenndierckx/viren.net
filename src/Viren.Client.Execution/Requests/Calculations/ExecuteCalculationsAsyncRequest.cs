using System;
using System.Collections.Generic;
using Viren.Client.Execution.Dtos;

namespace Viren.Client.Execution.Requests.Calculations
{
    public class ExecuteCalculationsAsyncRequest
    {
        public ExecuteCalculationsAsyncRequest()
        {
            CalculationInputs = new List<CalculationInputDto>();
        }

        public Guid ImportId { get; set; }

        public string Project { get; set; }
        public string Model { get; set; }
        public int Version { get; set; }
        public int? Revision { get; set; }
        public string EntryPoint { get; set; }

        public int TotalCalculations { get; set; }

        public IList<CalculationInputDto> CalculationInputs { get; set; }

        public bool? Debug { get; set; }
        public bool? Full { get; set; }
    }

    public class ExecuteCalculationsAsyncResponse
    {
    }
}