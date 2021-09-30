using System.Collections.Generic;
using System.Net;
using System.Threading.Tasks;
using MediatR;
using Microsoft.Azure.Functions.Worker;
using Microsoft.Azure.Functions.Worker.Http;
using SomeLibrary.Model;
using SomeLibrary.Queries;

namespace MeteringPointFunctionsApp
{
    public class GetMeteringPointsFunction
    {
        private readonly IMediator _mediator;

        public GetMeteringPointsFunction(IMediator mediator)
        {
            _mediator = mediator;
        }

        [Function("GetMeteringPointsFunction")]
        public Task<List<MeteringPointModel>> Run(
            [HttpTrigger(AuthorizationLevel.Function, "get")] HttpRequestData req)
        {
            return _mediator.Send(new GetMeteringPointListQuery());
        }
    }
}