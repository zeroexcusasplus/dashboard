using IbradnzMealBuilder.Core;
using IbradnzMealBuilder.Utility;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace IbradnzMealBuilder.Models
{
    //public class ViewMuscleGroupViewModel
    //{
    //    public MuscleGroup Muscle { get; set; }
    //    public string Name { get; set; }
    //    public string Description { get; set; }
    //    public ViewMuscleGroupViewModel(MuscleGroup muscleGroup)
    //    {
    //        Muscle = muscleGroup;
    //        Name = EnumExtensions.GetDisplayName(muscleGroup);
    //        Description = EnumExtensions.GetDescription(muscleGroup);
    //    }
    //}

    public class ViewMuscleGroupModel
    {
        public int Id { get; set; }
        public int Order { get; set; }
        public string Name { get; set; }
        public string Description { get; set; }
        [Display(Name="Youtube link")]
        public string YoutubeDescriptionLink { get; set; }
        public ViewMuscleGroupModel(Muscle_Group muscleGroup, bool shortenDesc = false)
        {
            Order = muscleGroup.Order;
            Id = muscleGroup.Id;
            Name = muscleGroup.Name;
            if (shortenDesc)
                Description = muscleGroup.Description.Length > 20
                    ? $"{muscleGroup.Description.Substring(0, 17)} ..."
                    : muscleGroup.Description;
            else
                Description = muscleGroup.Description;
            YoutubeDescriptionLink = muscleGroup.YoutubeDescription;
        }
    }

    public class AddMuscleGroupModel
    {
        [Required(ErrorMessage ="Muscle group name is required")]
        public string Name { get; set; }
        public string Description { get; set; }
        public int Order { get; set; }
        [Display(Name = "Youtube link")]
        public string YoutubeDescription { get; set; }
        public Muscle_Group Add()
        {
            return new Muscle_Group
            {
                Name = Name,
                Description = Description,
                Order = Order,
                YoutubeDescription = YoutubeDescription,
            };
        }
    }

    public class EditMuscleGroupModel
    {
        public int Id { get; set; }

        [Required(ErrorMessage = "Muscle group name is required")]
        public string Name { get; set; }
        public string Description { get; set; }

        [Display(Name="Youtube link")]
        public string YoutubeDescription { get; set; }
        public int Order { get; set; }
        public EditMuscleGroupModel()
        {

        }
        public EditMuscleGroupModel(Muscle_Group muscleGroup)
        {
            Id = muscleGroup.Id;
            Name = muscleGroup.Name;
            Order = muscleGroup.Order;
            Description = muscleGroup.Description;
            YoutubeDescription = muscleGroup.YoutubeDescription;
        }

        public Muscle_Group Edit(Muscle_Group muscleGroup)
        {
            muscleGroup.Name = Name;
            muscleGroup.Description = Description;
            muscleGroup.Order = Order;
            muscleGroup.YoutubeDescription = YoutubeDescription;

            return muscleGroup;
        }
    }
}
