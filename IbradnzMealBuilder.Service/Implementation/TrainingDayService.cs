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
    public class TrainingDayService : ITrainingDayService
    {
        private readonly UnitOfWork _uow;
        public TrainingDayService(IUnitOfWork uow)
        {
            _uow = uow as UnitOfWork;
        }

        public TrainingDay Get(int id)
        {
            return _uow.TrainingDayRepo.GetInclude(id);
        }

        public IEnumerable<TrainingDay> GetAll()
        {
            return _uow.TrainingDayRepo.GetAllInclude();
        }

        public async Task Update(TrainingDay trainingDay)
        {
            _uow.TrainingDayRepo.Update(trainingDay);
            await _uow.Save();
        }

        public async Task DeleteRange(IEnumerable<TrainingDay> trainingDays)
        {
            _uow.TrainingDayRepo.DeleteRangeFromDb(trainingDays);
            await _uow.Save();
        }
    }
}
