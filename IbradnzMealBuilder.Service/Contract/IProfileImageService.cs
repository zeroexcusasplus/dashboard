using IbradnzMealBuilder.Core;
using System;
using System.Collections.Generic;
using System.Text;
using System.Threading.Tasks;

namespace IbradnzMealBuilder.Service.Contract
{
    public interface IProfileImageService
    {
        int GetCount();
        ProfileImage Get(int id);
        IEnumerable<ProfileImage> GetAllForCustomer(int customerId);
        Task AddRange(IEnumerable<ProfileImage> profileImages);
        Task Delete(ProfileImage profileImage);
    }
}
