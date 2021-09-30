using System.Collections.Generic;
using SomeLibrary.Model;

namespace SomeLibrary.Data
{
    public interface IDataAccess
    {
        List<MeteringPointModel> GetMeteringPoints();
        
        MeteringPointModel GetMeteringPoint(int id);

        MeteringPointModel AddMeteringPoint(string type, bool connected);
    }
}