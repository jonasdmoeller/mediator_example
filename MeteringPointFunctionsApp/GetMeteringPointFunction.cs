using System.Threading.Tasks;
using MediatR;
using Microsoft.Azure.Functions.Worker;
using Microsoft.Azure.Functions.Worker.Http;
using SomeLibrary.Model;
using SomeLibrary.Queries;

namespace MeteringPointFunctionsApp
{
    public class GetMeteringPointFunction
    {
        private readonly IMediator _mediator;

        public GetMeteringPointFunction(IMediator mediator)
        {
            _mediator = mediator;
        }

        [Function("GetMeteringPointFunction")]
        public Task<MeteringPointModel> Run(
            [HttpTrigger(AuthorizationLevel.Function, "get")] HttpRequestData req, int meteringPointId)
        {
            return _mediator.Send(new GetMeteringPointQuery(meteringPointId));
        }
    }
}