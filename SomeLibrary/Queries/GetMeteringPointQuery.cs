using MediatR;
using SomeLibrary.Model;

namespace SomeLibrary.Queries
{
    public class GetMeteringPointQuery : IRequest<MeteringPointModel>
    {
        public int MeteringPointId { get; }

        public GetMeteringPointQuery(int meteringPointId)
        {
            MeteringPointId = meteringPointId;
        }
    }
}