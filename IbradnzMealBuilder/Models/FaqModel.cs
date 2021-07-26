using IbradnzMealBuilder.Core;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace IbradnzMealBuilder.Models
{
    public class ViewFaqAdminModel
    {
        public IEnumerable<ViewFaqModel> AnsweredQuestions { get; set; }
        public IEnumerable<ViewFaqModel> UnAnsweredQuestions { get; set; }
        public ViewFaqAdminModel(IEnumerable<ViewFaqModel> answeredQuestions, IEnumerable<ViewFaqModel> unAnsweredQuestions)
        {
            AnsweredQuestions = answeredQuestions;
            UnAnsweredQuestions = unAnsweredQuestions;
        }
    }

    public class ViewFaqModel
    {
        public int Id { get; set; }
        public string Question { get; set; }
        public string Answer { get; set; }
        public DateTime DateOrder { get; set; }
        public ViewFaqModel(Faq faq)
        {
            Id = faq.Id;
            Question = faq.Question;
            Answer = faq.Answer;
            DateOrder = faq.DateCreated;
        }
    }

    public class AddFaqModel
    {
        [Required(ErrorMessage ="Question is required")]
        public string Question { get; set; }

        [Required(ErrorMessage ="Answer is required")]
        public string Answer { get; set; }
        public bool IsQuestionAnswered { get; set; }
        public Faq Add()
        {
            return new Faq
            {
                Question = Question,
                Answer = Answer,
                IsQuestionAnswered = true,
            };
        }

        public Faq AddQuestion(string question)
        {
            return new Faq
            {
                Question = question,
                IsQuestionAnswered = false,
                Answer = "",
            };
        }
    }

    public class EditFaqModel
    {
        public int Id { get; set; }

        [Required(ErrorMessage = "Question is required")]
        public string Question { get; set; }

        [Required(ErrorMessage = "Answer is required")]
        public string Answer { get; set; }
        public EditFaqModel()
        {

        }

        public EditFaqModel(Faq faq)
        {
            Id = faq.Id;
            Question = faq.Question;
            Answer = faq.Answer;
        }

        public Faq Edit(Faq faq)
        {
            faq.Question = Question;
            faq.Answer = Answer;
            faq.IsQuestionAnswered = true;
            return faq;
        }
    }
}
