﻿using System;
using System.Collections.Generic;
using System.Text;

namespace IbradnzMealBuilder.Core
{
    public class Muscle_Group : Entity
    {
        public string Name { get; set; }
        public int Order { get; set; }
        public string Description { get; set; }
        public string YoutubeDescription { get; set; }
    }
}
