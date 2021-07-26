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
using Microsoft.Office.Interop.Excel;

namespace IbradnzMealBuilder.Service.Implementation
{
    public class MealTypeService : IMealTypeService
    {
        private readonly UnitOfWork _uow;
        public MealTypeService(IUnitOfWork uow)
        {
            this._uow = uow as UnitOfWork;
        }

        public async Task AddMealType(MealType mealType)
        {
            if (!ValidateMealTypeDetails(mealType))
                throw new Exception();

            _uow.MealTypeRepo.Add(mealType);
            await _uow.Save();
        }

        public async Task EditMealType(MealType mealType)
        {
            if (!ValidateMealTypeDetails(mealType))
                throw new Exception();

            _uow.MealTypeRepo.Update(mealType);
            await _uow.Save();
        }

        public bool CheckIfMealTypeExist(string name,int id)
        {
            var mealTypes = _uow.MealTypeRepo.GetAll()
                .Where(m => string.Compare(m.Name, name, true)==0 && m.Id!=id);
            if (mealTypes.Count() > 0)
                return true;
            else
                return false;
        }



        public IEnumerable<MealType> GetAllMealTypes()
        {
            return _uow.MealTypeRepo.GetAll();
        }

        public MealType GetMealTypeById(int id, bool allowNull=false)
        {
            var mealType = _uow.MealTypeRepo.Get(id);
            if (!allowNull && mealType == null)
                throw new Exception();
            return mealType;
        }

        public int GetMealTypeCount()
        {
            return _uow.MealTypeRepo.Count();
        }

        private bool ValidateMealTypeDetails(MealType mealType)
        {
            if (mealType == null)
                return false;

            if (string.IsNullOrEmpty(mealType.Name) || string.IsNullOrWhiteSpace(mealType.Name) || !char.IsLetterOrDigit(mealType.Name[0]))
                return false;

            return true;
        }
    }
}
