using IbradnzMealBuilder.Core;
using System;
using System.Collections.Generic;
using System.Text;
using System.Threading.Tasks;

namespace IbradnzMealBuilder.Service.Contract
{
    public interface IMealTypeService
    {
        int GetMealTypeCount();
        Task AddMealType(MealType mealType);
        Task EditMealType(MealType mealType);
        IEnumerable<MealType> GetAllMealTypes();
        bool CheckIfMealTypeExist(string name, int id);
        MealType GetMealTypeById(int id, bool allowNull = false);
    }
}
