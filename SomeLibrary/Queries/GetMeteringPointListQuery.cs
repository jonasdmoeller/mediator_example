using System.Collections.Generic;
using MediatR;
using SomeLibrary.Model;

namespace SomeLibrary.Queries
{
    public class GetMeteringPointListQuery : IRequest<List<MeteringPointModel>>
    {
    }
}