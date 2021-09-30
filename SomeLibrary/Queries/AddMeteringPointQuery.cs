using MediatR;
using SomeLibrary.Model;

namespace SomeLibrary.Queries
{
    public class AddMeteringPointQuery : IRequest<MeteringPointModel>
    {
        public MeteringPointModel MeteringPointModel { get; }

        public AddMeteringPointQuery(MeteringPointModel meteringPointModel)
        {
            MeteringPointModel = meteringPointModel;
        }
    }
}