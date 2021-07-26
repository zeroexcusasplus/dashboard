using IbradnzMealBuilder.Core;
using IbradnzMealBuilder.Utility;
using System;
using System.Collections.Generic;
using System.Text;
using System.Threading.Tasks;

namespace IbradnzMealBuilder.Service.Contract
{
    public interface IProgramService
    {
        Task Add(Training_Program trainingProgram);
        Task Delete(Training_Program trainingProgram);
        Task Edit(Training_Program trainingProgram);
        Training_Program Get(int id);
        IEnumerable<Training_Program> GetAll();
        IEnumerable<Training_Program> GetAllByType(TrainingType type);
    }
}
