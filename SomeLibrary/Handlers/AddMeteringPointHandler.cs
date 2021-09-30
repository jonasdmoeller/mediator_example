using System.Threading;
using System.Threading.Tasks;
using MediatR;
using SomeLibrary.Data;
using SomeLibrary.Model;
using SomeLibrary.Queries;

namespace SomeLibrary.Handlers
{
    public class AddMeteringPointHandler : IRequestHandler<AddMeteringPointQuery, MeteringPointModel>
    {
        private readonly IDataAccess _dataAccess;

        public AddMeteringPointHandler(IDataAccess dataAccess)
        {
            _dataAccess = dataAccess;
        }

        public Task<MeteringPointModel> Handle(AddMeteringPointQuery request, CancellationToken cancellationToken)
        {
            var meteringPoint = request.MeteringPointModel;
            return Task.FromResult(_dataAccess.AddMeteringPoint(meteringPoint.Type, meteringPoint.Connected));
        }
    }
}