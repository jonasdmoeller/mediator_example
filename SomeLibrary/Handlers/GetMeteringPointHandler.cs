using System.Threading;
using System.Threading.Tasks;
using MediatR;
using SomeLibrary.Data;
using SomeLibrary.Model;
using SomeLibrary.Queries;

namespace SomeLibrary.Handlers
{
    public class GetMeteringPointHandler : IRequestHandler<GetMeteringPointQuery, MeteringPointModel>
    {
        private readonly IDataAccess _dataAccess;

        public GetMeteringPointHandler(IDataAccess dataAccess)
        {
            _dataAccess = dataAccess;
        }

        public Task<MeteringPointModel> Handle(GetMeteringPointQuery request, CancellationToken cancellationToken)
        {
            return Task.FromResult(_dataAccess.GetMeteringPoint(request.MeteringPointId));
        }
    }
}