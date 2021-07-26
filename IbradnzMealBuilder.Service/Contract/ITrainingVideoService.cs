using IbradnzMealBuilder.Core;
using IbradnzMealBuilder.Utility;
using System;
using System.Collections.Generic;
using System.Text;
using System.Threading.Tasks;

namespace IbradnzMealBuilder.Service.Contract
{
    public interface ITrainingVideoService
    {
        int GetTotalCount();
        Task Add(TrainingVideos trainingVideo);
        Task AddRange(IEnumerable<TrainingVideos> videos);
        IEnumerable<TrainingVideos> GetAll();
        TrainingVideos GetById(int id);
        Task Edit(TrainingVideos trainingVideo);
        IEnumerable<TrainingVideos> GetByTypeAndWeek(TrainingType type, int week);
        IEnumerable<TrainingVideos> GetByTypeProgramAndWeek(int programId, int week);
    }
}
