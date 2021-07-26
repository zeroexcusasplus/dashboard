using IbradnzMealBuilder.Core;
using System;
using System.Collections.Generic;
using System.Text;
using System.Threading.Tasks;

namespace IbradnzMealBuilder.Service.Contract
{
    public interface ITrainingDayService
    {
        Task Update(TrainingDay trainingDay);
        TrainingDay Get(int id);
        IEnumerable<TrainingDay> GetAll();
        Task DeleteRange(IEnumerable<TrainingDay> trainingDays);
    }
}
