using IbradnzMealBuilder.Utility;
using System;
using System.Collections.Generic;
using System.Text;

namespace IbradnzMealBuilder.Core
{
    public class TrainingDay : Entity
    {
        public int Day { get; set; }
        public int Week { get; set; }
        public Training_Program T_Program { get; set; }
        public string Name { get; set; }
    }
}
