using IbradnzMealBuilder.Core;
using System;
using System.Collections.Generic;
using System.Linq.Expressions;
using System.Text;
using System.Threading.Tasks;

namespace IbradnzMealBuilder.Service.Contract
{
    public interface IMealBuilderService
    {
        int GetMealBuilderCount();
        Task AddMealBuilder(MealBuilder mealBuilder);
        Task Update(MealBuilder mealBuilder);
        IEnumerable<MealBuilder> GetMealBuilders();
        IEnumerable<MealBuilder> GetMealBuildersForCustomer(int customerId);
        MealBuilder GetMealBuilderById(int id, bool allowNull = false);
        MealBuilder Find(Expression<Func<MealBuilder, bool>> predicate, bool allowNull = false);
    }
}
