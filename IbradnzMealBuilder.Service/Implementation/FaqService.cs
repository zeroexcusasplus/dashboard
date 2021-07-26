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
    public class FaqService : IFaqService
    {
        private readonly UnitOfWork _uow;
        public FaqService(IUnitOfWork uow)
        {
            _uow = uow as UnitOfWork;
        }

        public async Task Add(Faq faq)
        {
            if (!ValidateFaqDetails(faq))
                throw new Exception();

            _uow.FaqRepo.Add(faq);
            await _uow.Save();
        }

        public async Task Edit(Faq faq)
        {
            if (!ValidateFaqDetails(faq))
                throw new Exception();

            _uow.FaqRepo.Update(faq);
            await _uow.Save();
        }

        public Faq Get(int id)
        {
            return _uow.FaqRepo.Get(id);
        }

        public IEnumerable<Faq> GetAll()
        {
            return _uow.FaqRepo.GetAll();
        }

        public IEnumerable<Faq> GetAnsweredQuestion()
        {
            return _uow.FaqRepo.GetAll().Where(f => f.IsQuestionAnswered);
        }

        public IEnumerable<Faq> GetUnAnsweredQuestion()
        {
            return _uow.FaqRepo.GetAll().Where(f => !f.IsQuestionAnswered);
        }

        public async Task Delete(Faq faq)
        {
            _uow.FaqRepo.Remove(faq);
            await _uow.Save();
        }

        public bool ValidateFaqDetails(Faq faq)
        {
            if (faq == null)
                return false;

            if (string.IsNullOrEmpty(faq.Question) || string.IsNullOrWhiteSpace(faq.Question))
                return false;

            if ((string.IsNullOrEmpty(faq.Answer) || string.IsNullOrWhiteSpace(faq.Answer)) && faq.IsQuestionAnswered)
                return false;

            return true;
        }
    }
}
