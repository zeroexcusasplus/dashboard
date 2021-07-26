using IbradnzMealBuilder.Core;
using System;
using System.Collections.Generic;
using System.Text;
using System.Threading.Tasks;

namespace IbradnzMealBuilder.Service.Contract
{
    public interface IMuscleGroupService
    {
        Muscle_Group Get(int id);
        IEnumerable<Muscle_Group> GetAll();
        Task Add(Muscle_Group muscleGroup);
        Task Edit(Muscle_Group muscleGroup);
    }
}
