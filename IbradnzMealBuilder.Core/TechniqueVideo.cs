using IbradnzMealBuilder.Utility;
using System;
using System.Collections.Generic;
using System.Text;

namespace IbradnzMealBuilder.Core
{
    public class TechniqueVideo : Entity
    {
        public string Title { get; set; }
        public string UrlPath { get; set; }
        public int Order { get; set; }
        public Muscle_Group Muscle_Group { get; set; }
        //public MuscleGroup MuscleGroup { get; set; }
    }
}
