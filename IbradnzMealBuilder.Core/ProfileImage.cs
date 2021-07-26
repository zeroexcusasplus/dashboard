using System;
using System.Collections.Generic;
using System.Text;

namespace IbradnzMealBuilder.Core
{
    public class ProfileImage : Entity
    {
        public string ImageUrl { get; set; }
        public int CustomerId { get; set; }
        public Customer Customer { get; set; }
        public DateTime ImageDate { get; set; }
        public double Weight { get; set; }
    }
}
