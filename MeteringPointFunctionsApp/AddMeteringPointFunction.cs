using System.IO;
using System.Net;
using System.Text.Json.Serialization;
using System.Threading.Tasks;
using MediatR;
using Microsoft.Azure.Functions.Worker;
using Microsoft.Azure.Functions.Worker.Http;
using SomeLibrary.Model;
using SomeLibrary.Queries;
using Newtonsoft.Json;

namespace MeteringPointFunctionsApp
{
    public class AddMeteringPointFunction
    {
        private readonly IMediator _mediator;

        public AddMeteringPointFunction(IMediator mediator)
        {
            _mediator = mediator;
        }

        [Function("AddMeteringPointFunction")]
        public async Task<MeteringPointModel> Run(
            [HttpTrigger(AuthorizationLevel.Function, "get", "post")] HttpRequestData req)
        {
            var requestBody = await new StreamReader(req.Body).ReadToEndAsync();
            var newMeteringPoint = JsonConvert.DeserializeObject<MeteringPointModel>(requestBody);
            var meteringPoint = await _mediator.Send(new AddMeteringPointQuery(newMeteringPoint));
            return meteringPoint;
        }
    }
}