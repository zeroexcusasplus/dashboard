using IbradnzMealBuilder.Core;
using System;
using System.Collections.Generic;
using System.Text;

namespace IbradnzMealBuilder.Data.Contract
{
    public interface IMealBuilderRepo : ICoreRepo<MealBuilder>
    {
        IEnumerable<MealBuilder> GetAllWithRelationships();
        MealBuilder GetByIdWithRelationships(int id);
    }
}
