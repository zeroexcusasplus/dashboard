using IbradnzMealBuilder.Utility;
using System;
using System.Collections.Generic;
using System.Text;

namespace IbradnzMealBuilder.Core
{
    public class Training_Program : Entity
    {
        public string Name { get; set; }
        public string Description { get; set; }
        public string DescriptionYoutubeLink { get; set; }
        public string PreviewYoutubeLink { get; set; }
        public TrainingType TrainingType { get; set; }
        public int Order { get; set; }
        public IEnumerable<TrainingVideos> TrainingVideos { get; set; }
    }
}
