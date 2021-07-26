using IbradnzMealBuilder.Core;
using IbradnzMealBuilder.Data.Contract;
using IbradnzMealBuilder.Data.Implementation;
using IbradnzMealBuilder.Service.Contract;
using IbradnzMealBuilder.Utility;
using System;
using System.Collections.Generic;
using System.Text;
using System.Threading.Tasks;

namespace IbradnzMealBuilder.Service.Implementation
{
    public class TrainingVideoService : ITrainingVideoService
    {
        private readonly UnitOfWork _uow;
        public TrainingVideoService(IUnitOfWork uow)
        {
            this._uow = uow as UnitOfWork;
        }

        public int GetTotalCount()
        {
            return _uow.TrainingVideoRepo.Count();
        }

        public IEnumerable<TrainingVideos> GetAll()
        {
            return _uow.TrainingVideoRepo.GetAllInclude();
        }

        public TrainingVideos GetById(int id)
        {
             return _uow.TrainingVideoRepo.GetInclude(id);
        }

        public IEnumerable<TrainingVideos> GetByTypeAndWeek(TrainingType type, int week)
        {
            return _uow.TrainingVideoRepo.Find(t => t.TrainingType == type && t.Week == week);
        }

        public IEnumerable<TrainingVideos> GetByTypeProgramAndWeek( int programId, int week)
        {
            return _uow.TrainingVideoRepo.FindInclude(t =>t.Program.Id == programId && t.Week == week);
        }

        public async Task Add(TrainingVideos trainingVideo)
        {
            if (!ValidateTrainingVideo(trainingVideo))
                throw new Exception();

            _uow.TrainingVideoRepo.Add(trainingVideo);
            await _uow.Save();
        }

        public async Task AddRange(IEnumerable<TrainingVideos> videos)
        {
            _uow.TrainingVideoRepo.AddRange(videos);
            await _uow.Save();
        }

        public async Task Edit(TrainingVideos trainingVideo)
        {
            if (!ValidateTrainingVideo(trainingVideo))
                throw new Exception();

            _uow.TrainingVideoRepo.Update(trainingVideo);
            await _uow.Save();
        }

        public bool ValidateTrainingVideo(TrainingVideos trainingVideo)
        {
            if (trainingVideo == null)
                return false;
            if (trainingVideo.Day < 1 || trainingVideo.Day > AppConstant.TotalTrainingDays)
                return false;
            if (trainingVideo.Week < 1 || trainingVideo.Week > AppConstant.TotalTrainingWeeks)
                return false;
            if (trainingVideo.Sets < 0 || trainingVideo.Reps < 0)
                return false;
            if (string.IsNullOrEmpty(trainingVideo.BreakTime) || string.IsNullOrWhiteSpace(trainingVideo.BreakTime))
                return false;
            if (string.IsNullOrEmpty(trainingVideo.Title) || string.IsNullOrWhiteSpace(trainingVideo.Title))
                return false;

            return true;
        }

    }
}
