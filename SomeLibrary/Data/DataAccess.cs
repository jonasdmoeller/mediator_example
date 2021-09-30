using System.Collections.Generic;
using System.Linq;
using SomeLibrary.Model;

namespace SomeLibrary.Data
{
    public class DataAccess : IDataAccess
    {
        private readonly List<MeteringPointModel> _meteringPoints = new();
        
        public DataAccess()
        {
            _meteringPoints.Add(new MeteringPointModel { Id = 1, Type = "E17", Connected = true });
            _meteringPoints.Add(new MeteringPointModel { Id = 2, Type = "E18", Connected = false });
        }

        public List<MeteringPointModel> GetMeteringPoints()
        {
            return _meteringPoints;
        }

        public MeteringPointModel GetMeteringPoint(int id)
        {
            return _meteringPoints.Find(mp => mp.Id == id);
        }

        public MeteringPointModel AddMeteringPoint(string type, bool connected)
        {
            var meteringPoint = new MeteringPointModel
            {
                Type = type,
                Connected = connected,
                Id = _meteringPoints.Max(x => x.Id) + 1
            };
            
            _meteringPoints.Add(meteringPoint);

            return meteringPoint;
        }
    }
}