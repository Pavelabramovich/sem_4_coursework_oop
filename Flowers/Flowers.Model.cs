using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CourseProjectOpp;

public class FlowersModel
{
    private FlowersDb _db;

    public FlowersModel()
    {
        _db = FlowersDb.Instance;
    }

    public IEnumerable<Flower> Flowers => _db.Flowers; 
}
