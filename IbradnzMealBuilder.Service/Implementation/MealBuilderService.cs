using IbradnzMealBuilder.Core;
using IbradnzMealBuilder.Data.Contract;
using IbradnzMealBuilder.Data.Implementation;
using IbradnzMealBuilder.Service.Contract;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Linq.Expressions;
using System.Text;
using System.Threading.Tasks;

namespace IbradnzMealBuilder.Service.Implementation
{
    public class MealBuilderService : IMealBuilderService
    {
        private readonly UnitOfWork _uow;
        public MealBuilderService(IUnitOfWork uow)
        {
            this._uow = uow as UnitOfWork;
        }

        public int GetMealBuilderCount()
        {
            return _uow.MealBuilderRepo.Count();
        }

        public MealBuilder Find(Expression<Func<MealBuilder, bool>> predicate, bool allowNull = false)
        {
            var mealBuilder = _uow.MealBuilderRepo.FindInclude(predicate).FirstOrDefault();
            if (!allowNull && mealBuilder == null)
                throw new Exception();
            else
                return mealBuilder;
        }

        public async Task AddMealBuilder(MealBuilder mealBuilder)
        {
            if (!ValidateMealBuilderDetails(mealBuilder))
                throw new Exception();

            _uow.MealBuilderRepo.Add(mealBuilder);
            await _uow.Save();
        }

        public async Task Update(MealBuilder mealBuilder)
        {
            _uow.MealBuilderRepo.Update(mealBuilder);
            await _uow.Save();
        }

        public IEnumerable<MealBuilder> GetMealBuilders()
        {
            return _uow.MealBuilderRepo.GetAll();
        }

        public IEnumerable<MealBuilder> GetMealBuildersForCustomer(int customerId)
        {
            return _uow.MealBuilderRepo.Find(meal => meal.Customer.Id == customerId).ToList();
        }

        public MealBuilder GetMealBuilderById(int id,bool allowNull=false)
        {
            var mealBuilder = _uow.MealBuilderRepo.GetByIdWithRelationships(id);
            if (!allowNull && mealBuilder == null)
                throw new Exception();
            return mealBuilder;
        }

        private bool ValidateMealBuilderDetails(MealBuilder mealBuilder)
        {
            if (mealBuilder == null)
                return false;

            if (mealBuilder.Customer == null)
                return false;

            if (mealBuilder.Meals.ToList().Count() < 1)
                return false;

            if (mealBuilder.WaterIntake < 0.01M)
                return false;

            if (mealBuilder.NumberOfMeals < 1)
                return false;
            
            return true;
        }
    }
}
