using IbradnzMealBuilder.Core;
using System;
using System.Collections.Generic;
using System.Text;
using System.Threading.Tasks;

namespace IbradnzMealBuilder.Service.Contract
{
    public interface IFaqService
    {
        Faq Get(int id);
        IEnumerable<Faq> GetAll();
        IEnumerable<Faq> GetUnAnsweredQuestion();
        IEnumerable<Faq> GetAnsweredQuestion();
        Task Add(Faq faq);
        Task Edit(Faq faq);
        Task Delete(Faq faq);
    }
}
