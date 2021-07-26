using IbradnzMealBuilder.Core;
using IbradnzMealBuilder.Utility;
using System;
using System.Collections.Generic;
using System.Text;
using System.Threading.Tasks;

namespace IbradnzMealBuilder.Service.Contract
{
    public interface ITechniqueVideoService
    {
        int GetCount();
        IEnumerable<TechniqueVideo> GetAll();
        IEnumerable<TechniqueVideo> GetAllForMuscleType(int muscle);
        TechniqueVideo Get(int id);
        Task Add(TechniqueVideo video);
        Task Edit(TechniqueVideo video);
    }
}
