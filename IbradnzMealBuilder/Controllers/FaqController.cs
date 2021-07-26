using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using IbradnzMealBuilder.Models;
using IbradnzMealBuilder.Service.Contract;
using Microsoft.AspNetCore.Mvc;

namespace IbradnzMealBuilder.Controllers
{
    public class FaqController : Controller
    {
        private readonly IFaqService _faqService;
        public FaqController(IFaqService faqService)
        {
            _faqService = faqService;
        }

        public IActionResult Index()
        {
            var faq = _faqService.GetAnsweredQuestion();
            var model = faq.Select(f => new ViewFaqModel(f));
            return View(model);
        }

        [HttpPost]
        public async Task<IActionResult> SubumitQuestion(string question)
        {
            var faq = new AddFaqModel().AddQuestion(question);
            await _faqService.Add(faq);
            return Json(new { success = true });
        }
    }
}
