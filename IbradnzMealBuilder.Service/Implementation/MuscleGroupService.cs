using IbradnzMealBuilder.Core;
using IbradnzMealBuilder.Data.Contract;
using IbradnzMealBuilder.Data.Implementation;
using IbradnzMealBuilder.Service.Contract;
using System;
using System.Collections.Generic;
using System.Text;
using System.Threading.Tasks;

namespace IbradnzMealBuilder.Service.Implementation
{
    public class MuscleGroupService : IMuscleGroupService
    {
        private readonly UnitOfWork _uow;
        public MuscleGroupService(IUnitOfWork uow)
        {
            _uow = uow as UnitOfWork;
        }
        public async Task Add(Muscle_Group muscleGroup)
        {
            _uow.MuscleGroupRepo.Add(muscleGroup);
            await _uow.Save();
        }

        public async Task Edit(Muscle_Group muscleGroup)
        {
            _uow.MuscleGroupRepo.Update(muscleGroup);
            await _uow.Save();
        }

        public Muscle_Group Get(int id)
        {
            return _uow.MuscleGroupRepo.Get(id);
        }

        public IEnumerable<Muscle_Group> GetAll()
        {
            return _uow.MuscleGroupRepo.GetAll();
        }
    }
}
