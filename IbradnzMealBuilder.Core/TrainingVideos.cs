using IbradnzMealBuilder.Utility;
using System;
using System.Collections.Generic;
using System.Text;

namespace IbradnzMealBuilder.Core
{
    public class TrainingVideos : Entity
    {
        public int Day { get; set; }
        public int Week { get; set; }
        public int Sets { get; set; }
        public int Reps { get; set; }
        public string BreakTime { get; set; }
        public string Title { get; set; }
        public string UrlPath { get; set; }
        public int Order { get; set; }
        public TrainingType TrainingType { get; set; }

        public Training_Program Program { get; set; }
        public int TutProgramId { get; set; }
    }
}
