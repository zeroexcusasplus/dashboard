using IbradnzMealBuilder.Core;
using IbradnzMealBuilder.Data.Contract;
using IbradnzMealBuilder.Data.Implementation;
using IbradnzMealBuilder.Service.Contract;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace IbradnzMealBuilder.Service.Implementation
{
    public class ProfileImageService : IProfileImageService
    {
        private readonly UnitOfWork _uow;
        public ProfileImageService(IUnitOfWork uow)
        {
            this._uow = uow as UnitOfWork;
        }

        public int GetCount()
        {
            return _uow.ProfileImageRepo.Count();
        }

        public ProfileImage Get(int id)
        {
            return _uow.ProfileImageRepo.Get(id);
        }

        public IEnumerable<ProfileImage> GetAllForCustomer(int customerId)
        {
            return _uow.ProfileImageRepo.Find(p => p.CustomerId == customerId);
        }

        public async Task AddRange(IEnumerable<ProfileImage> profileImages)
        {
            _uow.ProfileImageRepo.AddRange(profileImages);
            await _uow.Save();
        }

        public async Task Delete (ProfileImage profileImage)
        {
            _uow.ProfileImageRepo.Remove(profileImage);
            await _uow.Save();
        }
    }
}
