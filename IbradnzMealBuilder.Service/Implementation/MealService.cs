using IbradnzMealBuilder.Data.Contract;
using IbradnzMealBuilder.Data.Implementation;
using IbradnzMealBuilder.Service.Contract;
using System;
using System.Collections.Generic;
using System.Text;

namespace IbradnzMealBuilder.Service.Implementation
{
    public class MealService : IMealService
    {
        private readonly UnitOfWork _uow;
        public MealService(IUnitOfWork uow)
        {
            this._uow = uow as UnitOfWork;
        }

        public int GetMealCount()
        {
            return _uow.MealRepo.Count();
        }
    }
}
