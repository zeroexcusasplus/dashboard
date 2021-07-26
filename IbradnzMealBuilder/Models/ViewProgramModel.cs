using IbradnzMealBuilder.Core;
using IbradnzMealBuilder.Utility;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace IbradnzMealBuilder.Models
{
    public class ViewProgramModel
    {
        public int Id { get; set; }
        public string Name { get; set; }
        public string Description { get; set; }
        public int Order { get; set; }
        public string DescriptionYoutubeLink { get; set; }
        public string PreviewYoutubeLink { get; set; }
        public string TrainingType { get; set; }
        public ViewProgramModel(Training_Program program, bool shortenDesc = false)
        {
            Name = program.Name;
            Id = program.Id;
            if (shortenDesc)
                Description = program.Description.Length > 20
                    ? $"{program.Description.Substring(0, 17)} ..."
                    : program.Description;
            else
                Description = program.Description;
            Order = program.Order;
            DescriptionYoutubeLink = program.DescriptionYoutubeLink;
            PreviewYoutubeLink = program.PreviewYoutubeLink;
            TrainingType = EnumExtensions.GetDisplayName(program.TrainingType);
        }
    }

    public class AddProgramModel
    {
        public string Name { get; set; }
        public string Description { get; set; }
        public int Order { get; set; }

        [Display(Name="Description youtube link")]
        public string DescriptionYoutubeLink { get; set; }

        [Display(Name = "Preview youtube link")]
        public string PreviewYoutubeLink { get; set; }

        [Display(Name="Training type")]
        public TrainingType TrainingType { get; set; }
        public Training_Program Add()
        {
            return new Training_Program
            {
                Name = Name,
                Description = Description,
                Order = Order,
                DescriptionYoutubeLink = DescriptionYoutubeLink,
                PreviewYoutubeLink = PreviewYoutubeLink,
                TrainingType = TrainingType,
            };
        }
    }

    public class EditProgramModel
    {
        public int Id { get; set; }
        public string Name { get; set; }
        public string Description { get; set; }
        public int Order { get; set; }
        public string DescriptionYoutubeLink { get; set; }
        public string PreviewYoutubeLink { get; set; }
        [Display(Name = "Training type")]
        public TrainingType TrainingType { get; set; }
        public EditProgramModel()
        {

        }
        public EditProgramModel(Training_Program program)
        {
            Name = program.Name;
            Id = program.Id;
            Description = program.Description;
            Order = program.Order;
            DescriptionYoutubeLink = program.DescriptionYoutubeLink;
            PreviewYoutubeLink = program.PreviewYoutubeLink;
            TrainingType = program.TrainingType;
        }

        public Training_Program Edit(Training_Program program)
        {
            program.Name = Name;
            program.Description = Description;
            program.DescriptionYoutubeLink = DescriptionYoutubeLink;
            program.Order = Order;
            program.PreviewYoutubeLink = PreviewYoutubeLink;
            program.TrainingType = TrainingType;

            return program;
        }
    }
}
