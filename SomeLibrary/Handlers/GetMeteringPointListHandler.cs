using System.Collections.Generic;
using System.Threading;
using System.Threading.Tasks;
using MediatR;
using SomeLibrary.Data;
using SomeLibrary.Model;
using SomeLibrary.Queries;

namespace SomeLibrary.Handlers
{
    public class GetMeteringPointListHandler : IRequestHandler<GetMeteringPointListQuery, List<MeteringPointModel>>
    {
        private readonly IDataAccess _dataAccess;

        public GetMeteringPointListHandler(IDataAccess dataAccess)
        {
            _dataAccess = dataAccess;
        }

        public Task<List<MeteringPointModel>> Handle(GetMeteringPointListQuery request, CancellationToken cancellationToken)
        {
            return Task.FromResult(_dataAccess.GetMeteringPoints());
        }
    }
}