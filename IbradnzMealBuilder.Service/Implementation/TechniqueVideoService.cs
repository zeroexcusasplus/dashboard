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
    public class TechniqueVideoService : ITechniqueVideoService
    {
        private readonly UnitOfWork _uow;
        public TechniqueVideoService(IUnitOfWork uow)
        {
            _uow = uow as UnitOfWork;
        }
        public int GetCount()
        {
            return _uow.TechniqueVideoRepo.Count();
        }

        public IEnumerable<TechniqueVideo> GetAll()
        {
            return _uow.TechniqueVideoRepo.GetAll();
        }

        public TechniqueVideo Get(int id)
        {
            return _uow.TechniqueVideoRepo.Get(id);
        }

        public IEnumerable<TechniqueVideo> GetAllForMuscleType(int muscle)
        {
            return _uow.TechniqueVideoRepo.FindInclude(v => v.Muscle_Group.Id == muscle);
        }

        public async Task Add(TechniqueVideo video)
        {
            if (!ValidateTechniqueVideoDetails(video))
                throw new Exception();

            _uow.TechniqueVideoRepo.Add(video);
            await _uow.Save();
        }

        public async Task Edit(TechniqueVideo video)
        {
            if (!ValidateTechniqueVideoDetails(video))
                throw new Exception();

            _uow.TechniqueVideoRepo.Update(video);
            await _uow.Save();
        }

        private bool ValidateTechniqueVideoDetails(TechniqueVideo video)
        {
            if (video == null)
                return false;
            if (string.IsNullOrEmpty(video.Title) || string.IsNullOrWhiteSpace(video.Title))
                return false;
            if (string.IsNullOrEmpty(video.UrlPath) || string.IsNullOrWhiteSpace(video.UrlPath))
                return false;

            return true;
        }
    }
}
