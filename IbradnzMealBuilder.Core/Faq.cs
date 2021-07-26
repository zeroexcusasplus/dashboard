using System;
using System.Collections.Generic;
using System.Text;

namespace IbradnzMealBuilder.Core
{
    public class Faq : Entity
    {
        public string Question { get; set; }
        public string Answer { get; set; }
        public bool IsQuestionAnswered { get; set; }
    }
}
