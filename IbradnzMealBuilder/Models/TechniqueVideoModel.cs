using IbradnzMealBuilder.Core;
using IbradnzMealBuilder.Utility;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc.Rendering;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace IbradnzMealBuilder.Models
{
    public class ViewTechniqueVideoModel
    {
        public int Id { get; set; }
        public string Title { get; set; }
        public string UrlPath { get; set; }
        public string MuscleGroupName { get; set; }
        public int MuscleGroupId { get; set; }
        public int Order { get; set; }
        public ViewTechniqueVideoModel(TechniqueVideo techniqueVideo)
        {
            Id = techniqueVideo.Id;
            Title = techniqueVideo.Title;
            UrlPath =GeneralFunction.GetUrlPath(techniqueVideo.UrlPath);
            MuscleGroupName = techniqueVideo.Muscle_Group.Name;
            MuscleGroupId = techniqueVideo.Muscle_Group.Id;
            Order = techniqueVideo.Order;
        }
    }

    public class AddTechniqueVideoModel
    {

        [Display(Name = "Título")]
        [Required(ErrorMessage = "Se requiere título")]
        public string Title { get; set; }

        [Display(Name = "Enlace de Youtube")]
        public string YouTubeUrl { get; set; }

        [Display(Name = "Grupo muscular")]
        [Required(ErrorMessage = "Se requiere grupo muscular")]
        public int MuscleGroup { get; set; }

        public IEnumerable<SelectListItem> MuscleGroups { get; set; }

        public int Order { get; set; }
        public string PrevVideoUrl { get; set; }
        public IEnumerable<SelectListItem> PrevVideos { get; set; }
        public AddTechniqueVideoModel() {  }
        public AddTechniqueVideoModel(IEnumerable<PrevVideoModel> _prevVideos, IEnumerable<Muscle_Group> muscleGroups)
        {
            var prevVideos = new List<SelectListItem>();
            prevVideos.Add(new SelectListItem("Select prev video", ""));
            foreach (var prevVideo in _prevVideos)
                prevVideos.Add(new SelectListItem(prevVideo.Title, prevVideo.Url));
            PrevVideos = prevVideos;
            MuscleGroups = muscleGroups.Select(m => new SelectListItem(m.Name, m.Id.ToString()));
        }

        public TechniqueVideo Add(string path, Muscle_Group muscleGroup)
        {
            return new TechniqueVideo()
            {
                Title = Title,
                Muscle_Group = muscleGroup,
                UrlPath = path,
                Order = Order,
            };
        }
    }

    public class EditTechniqueVideoModel
    {
        public int Id { get; set; }

        [Display(Name = "Título")]
        [Required(ErrorMessage = "Se requiere título")]
        public string Title { get; set; }

        [Display(Name = "Enlace de Youtube")]
        public string YouTubeUrl { get; set; }

        [Display(Name = "Grupo muscular")]
        [Required(ErrorMessage = "Se requiere grupo muscular")]
        public int MuscleGroup { get; set; }

        public IEnumerable<ViewMuscleGroupModel> MuscleGroups { get; set; }

        public int Order { get; set; }
        public string PrevVideoUrl { get; set; }
        public IEnumerable<SelectListItem> PrevVideos { get; set; }
        public EditTechniqueVideoModel() {}
        public EditTechniqueVideoModel(TechniqueVideo video, IEnumerable<PrevVideoModel> _prevVideos, IEnumerable<Muscle_Group> muscleGroup)
        {
            var prevVideos = new List<SelectListItem>();
            prevVideos.Add(new SelectListItem("Select prev video", ""));
            foreach (var prevVideo in _prevVideos)
                prevVideos.Add(new SelectListItem(prevVideo.Title, prevVideo.Url));
            PrevVideos = prevVideos;
            Id = video.Id;
            Title = video.Title;
            MuscleGroups = muscleGroup.Select(m => new ViewMuscleGroupModel(m));
            Order = video.Order;
            YouTubeUrl = video.UrlPath;
            MuscleGroup = video.Muscle_Group.Id;
        }
        public TechniqueVideo Edit(TechniqueVideo video, string urlPath, Muscle_Group muscleGroup)
        {
            video.Title = Title;
            video.Muscle_Group = muscleGroup;
            video.UrlPath = string.IsNullOrEmpty(urlPath) ? video.UrlPath : urlPath;
            video.Order = Order;

            return video;
        }
    }
    public class DeleteTechniqueVideo
    {
        public int Id { get; set; }
        public string Title { get; set; }
        public string VideoPath { get; set; }
        public string MuscleType { get; set; }
        [Display(Name = "Contraseña")]
        public string Password { get; set; }
        public DeleteTechniqueVideo() { }
        public DeleteTechniqueVideo(TechniqueVideo techniqueVideo)
        {
            Id = techniqueVideo.Id;
            Title = techniqueVideo.Title;
            //MuscleType = techniqueVideo.Muscle_Group.Name;
            VideoPath = GeneralFunction.GetUrlPath(techniqueVideo.UrlPath);
        }
    }

    public class ViewTechniqueForMuscle
    {
        public bool IsCustomerSubscribed { get; set; }
        public string MuscleGroup { get; set; }
        public IEnumerable<ViewTechniqueVideoModel> TechniqueVideos { get; set; }
        public ViewTechniqueForMuscle(IEnumerable<TechniqueVideo> techniqueVideos, string muscle, Customer customer)
        {
            MuscleGroup = muscle.ToUpper();
            TechniqueVideos = techniqueVideos.Select(t => new ViewTechniqueVideoModel(t)).OrderBy(v => v.Order);
            IsCustomerSubscribed = GeneralFunction.IsCustomerSubscribed(customer.SubscriptionExpiringDateUtc);
        }
    }

    public class AdminTechniqueVideosViewModel
    {
        public int MuscleGroupId { get; set; }
        public IEnumerable<ViewTechniqueVideoModel> TechniqueVideos { get; set; }
        public IEnumerable<ViewMuscleGroupModel> MuscleGroups { get; set; }
        public AdminTechniqueVideosViewModel(int muscleGroupId, IEnumerable<ViewTechniqueVideoModel> techniqueVideos, IEnumerable<Muscle_Group> muscleGroups)
        {
            MuscleGroupId = muscleGroupId;
            TechniqueVideos = techniqueVideos;
            MuscleGroups = muscleGroups.Select(m => new ViewMuscleGroupModel(m)).OrderBy(m=>m.Order);
        }
    }

    public class VideoPlayer
    {
        public string Url { get; set; }
        public VideoPlayer(TrainingVideos trainingVideo)
        {
            Url = trainingVideo.UrlPath;// GeneralFunction.GetUrlPath(trainingVideo.UrlPath);
        }
        public VideoPlayer(TechniqueVideo techniqueVideo)
        {
            Url = techniqueVideo.UrlPath; //GeneralFunction.GetUrlPath(techniqueVideo.UrlPath);
        }
    }
}
