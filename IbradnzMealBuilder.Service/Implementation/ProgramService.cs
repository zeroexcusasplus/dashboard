using IbradnzMealBuilder.Core;
using IbradnzMealBuilder.Data.Contract;
using IbradnzMealBuilder.Data.Implementation;
using IbradnzMealBuilder.Service.Contract;
using IbradnzMealBuilder.Utility;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace IbradnzMealBuilder.Service.Implementation
{
    public class ProgramService : IProgramService
    {
        private readonly UnitOfWork _uow;
        public ProgramService(IUnitOfWork uow)
        {
            _uow = uow as UnitOfWork;
        }

        public async Task Add(Training_Program trainingProgram)
        {
            _uow.ProgramRepo.Add(trainingProgram);
            var trainingTypes = Enum.GetValues(typeof(TrainingType)).Cast<TrainingType>();
            var trainingDays = new List<TrainingDay>();
            for (int j = 1; j <= 12; j++)
            {
                for (int i = 1; i <= 5; i++)
                {
                    trainingDays.Add(new TrainingDay
                    {
                        Name = $"Program {trainingProgram.Name}, week {i} - day {j}",
                        Day = i,
                        Week = j,
                        T_Program = trainingProgram,
                    });
                }
            }
            _uow.TrainingDayRepo.AddRange(trainingDays);
            await _uow.Save();
        }

        public async Task Delete(Training_Program trainingProgram)
        {
            _uow.ProgramRepo.Remove(trainingProgram);
            await _uow.Save();
        }

        public async Task Edit(Training_Program trainingProgram)
        {
            _uow.ProgramRepo.Update(trainingProgram);
            await _uow.Save();
        }

        public Training_Program Get(int id)
        {
            return _uow.ProgramRepo.Get(id);
        }

        public IEnumerable<Training_Program> GetAll()
        {
            return _uow.ProgramRepo.GetAll();
        }

        public IEnumerable<Training_Program> GetAllByType(TrainingType type)
        {
            return _uow.ProgramRepo.Find(p => p.TrainingType == type);
        }
    }
}
