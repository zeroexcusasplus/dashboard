using IbradnzMealBuilder.Core;
using IbradnzMealBuilder.Utility;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc.Rendering;
using Microsoft.EntityFrameworkCore.Storage.ValueConversion.Internal;
using Newtonsoft.Json;
using Newtonsoft.Json.Converters;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace IbradnzMealBuilder.Models
{
    public class AddTrainingVideosViewModel
    {
        [Display(Name = "Dia")]
        [Required(ErrorMessage = "Se requiere un dia")]
        [Range(1, AppConstant.TotalTrainingDays, ErrorMessage = "El día está fuera de rango")]
        public int Day { get; set; }

        [Display(Name = "Semana")]
        [Required(ErrorMessage = "Se requiere semana")]
        [Range(1, AppConstant.TotalTrainingWeeks, ErrorMessage = "La semana está fuera de rango")]
        public int Week { get; set; }

        [Display(Name = "Sets")]
        [Required(ErrorMessage = "Se requieren conjuntos")]
        [Range(0, int.MaxValue, ErrorMessage = "Sets está fuera de rango")]
        public int Sets { get; set; }

        [Required(ErrorMessage = "Se requieren representantes")]
        [Range(0, int.MaxValue, ErrorMessage = "Las repeticiones están fuera de rango")]
        public int Reps { get; set; }

        [Display(Name = "Descanso, por ejemplo, 60 s, 5 min, 1 h.")]
        [Required(ErrorMessage = "se requiere tiempo de descanso")]
        public string Time { get; set; }

        [Display(Name = "Título")]
        [Required(ErrorMessage = "Se requiere título")]
        public string Title { get; set; }

        [Display(Name = "Enlace de Youtube")]
        public string YouTubeUrl { get; set; }

        //[Display(Name = "Tipo de entrenamiento")]
        //[Required(ErrorMessage = "Se requiere tipo de entrenamiento")]
        //public TrainingType TrainingType { get; set; }

        [Display(Name = "Programa")]
        [Required(ErrorMessage = "Se requiere programa")]
        public int TrainingProgram { get; set; }
        public IEnumerable<SelectListItem> Programs { get; set; }

        public int Order { get; set; }
        public string PrevVideoUrl { get; set; }
        public IEnumerable<SelectListItem> PrevVideos { get; set; }
        public AddTrainingVideosViewModel() { }
        public AddTrainingVideosViewModel(IEnumerable<PrevVideoModel> _prevVideos,IEnumerable<Training_Program> programs)
        {
            var prevVideos = new List<SelectListItem>();
            prevVideos.Add(new SelectListItem("Select prev video", ""));
            foreach (var prevVideo in _prevVideos)
                prevVideos.Add(new SelectListItem(prevVideo.Title, prevVideo.Url));
            PrevVideos = prevVideos;

            var _programs = new List<SelectListItem>();
            foreach (var prog in programs.OrderBy(p=>p.TrainingType))
                _programs.Add(new SelectListItem($"{prog.Name} - {EnumExtensions.GetDisplayName(prog.TrainingType)}", prog.Id.ToString()));
            Programs = _programs;

        }
        public TrainingVideos AddVideo(string videoPath, Training_Program program)
        {
            return new TrainingVideos()
            {
                Title = Title,
                Day = Day,
                Week = Week,
                Sets = Sets,
                Reps = Reps,
                BreakTime = Time,
                TrainingType = program.TrainingType,
                Program = program,
                UrlPath = videoPath,
                Order = Order,
            };
        }
    }

    public class TrainingIndexViewModel
    {
        public ViewProgramModel Program { get; set; }
        public IEnumerable<ViewTrainingDayModel> TrainingDays { get; set; }
        public bool IsCustomerSubscribed { get; set; }
        [JsonConverter(typeof(StringEnumConverter))]
        public TrainingType TrainingType { get; set; }
        public int TrainingProgramId { get; set; }
        public int DayOfWeek { get; set; }
        public IEnumerable<TrainingComboModel> TrainingCombos { get; set; }
        public TrainingIndexViewModel(IEnumerable<TrainingComboModel> combos, IEnumerable<ViewTrainingDayModel> trainingDays,
            int dayOfWeek, TrainingType type, Training_Program program, Customer customer)
        {
            TrainingCombos = combos.OrderBy(c => c.Day);
            TrainingDays = trainingDays;
            DayOfWeek = dayOfWeek;
            TrainingType = type;
            TrainingProgramId = program.Id;
            Program = new ViewProgramModel(program);
            IsCustomerSubscribed = GeneralFunction.IsCustomerSubscribed(customer.SubscriptionExpiringDateUtc);
        }
    }

    public class TrainingComboModel
    {
        public TrainingType TrainingType { get; set; }
        public Training_Program TrainingProgram { get; set; }
        public int Week { get; set; }
        public int Day { get; set; }
        public IEnumerable<ViewTrainingVideos> TrainingVideos { get; set; }
        public TrainingComboModel(TrainingType type, Training_Program trainingProgram, int week, int day, IEnumerable<ViewTrainingVideos> videos)
        {
            TrainingType = type;
            Day = day;
            Week = week;
            TrainingProgram = trainingProgram;
            TrainingVideos = videos;
        }
    }

    public class ViewTrainingVideos
    {
        public int Id { get; set; }
        public int Day { get; set; }
        public int Week { get; set; }
        public int Sets { get; set; }
        public int Reps { get; set; }
        public string Time { get; set; }
        public string Title { get; set; }
        public string VideoPath { get; set; }
        public string TrainingType { get; set; }
        public int ProgramId { get; set; }
        public string ProgramName { get; set; }
        public int Order { get; set; }
        public DateTime DateCreated { get; set; }
        public ViewTrainingVideos(TrainingVideos trainingVideos)
        {
            DateCreated = trainingVideos.DateCreated;
            Id = trainingVideos.Id;
            Day = trainingVideos.Day;
            Week = trainingVideos.Week;
            Sets = trainingVideos.Sets;
            Reps = trainingVideos.Reps;
            Time = trainingVideos.BreakTime;
            Title = trainingVideos.Title;
            Order = trainingVideos.Order;
            ProgramId = trainingVideos.Program.Id;
            ProgramName = trainingVideos.Program.Name;
            TrainingType = EnumExtensions.GetDisplayName(trainingVideos.TrainingType);
            VideoPath = GeneralFunction.GetUrlPath(trainingVideos.UrlPath);
        }
    }

    public class EditTrainingVideo
    {
        public int Id { get; set; }

        [Display(Name = "Dia")]
        [Required(ErrorMessage = "Se requiere un dia")]
        [Range(1, 5, ErrorMessage = "El día debe estar entre 1 y 5")]
        public int Day { get; set; }

        [Display(Name = "Semana")]
        [Required(ErrorMessage = "Se requiere semana")]
        [Range(1, 12, ErrorMessage = "La semana debe estar entre 1 y 12")]
        public int Week { get; set; }

        [Display(Name = "Sets")]
        [Required(ErrorMessage = "Se requieren conjuntos")]
        public int Sets { get; set; }

        [Required(ErrorMessage = "Se requieren representantes")]
        public int Reps { get; set; }

        [Display(Name = "Descanso, por ejemplo, 60 s, 5 min, 1 h.")]
        [Required(ErrorMessage = "se requiere tiempo de descanso")]
        public string Time { get; set; }
        [Display(Name = "Título")]
        [Required(ErrorMessage = "Se requiere título")]
        public string Title { get; set; }

        [Display(Name = "Enlace de Youtube")]
        public string YouTubeUrl { get; set; }
        //[Display(Name = "Editar archivo de video (.mp4 .mkv)")]
        //public IFormFile VideoFile { get; set; }

      

        [Display(Name = "Programa")]
        [Required(ErrorMessage = "Se requiere programa")]
        public int TrainingProgram { get; set; }
        public IEnumerable<SelectListItem> Programs { get; set; }

        public int Order { get; set; }
        public string PrevVideoUrl { get; set; }
        public IEnumerable<SelectListItem> PrevVideos { get; set; }
        public EditTrainingVideo() { }
        public EditTrainingVideo(TrainingVideos trainingVid, IEnumerable<PrevVideoModel> _prevVideos, IEnumerable<Training_Program> programs)
        {
            Id = trainingVid.Id;
            Day = trainingVid.Day;
            Week = trainingVid.Week;
            Sets = trainingVid.Sets;
            Reps = trainingVid.Reps;
            Time = trainingVid.BreakTime;
            Title = trainingVid.Title;
            YouTubeUrl = trainingVid.UrlPath;
            TrainingProgram = trainingVid.Program.Id;
            Order = trainingVid.Order;
            var prevVideos = new List<SelectListItem>();
            prevVideos.Add(new SelectListItem("Select prev video", ""));
            foreach (var prevVideo in _prevVideos)
                prevVideos.Add(new SelectListItem(prevVideo.Title, prevVideo.Url));
            PrevVideos = prevVideos;

            var _programs = new List<SelectListItem>();
            foreach (var prog in programs)
                _programs.Add(new SelectListItem($"{prog.Name} - {EnumExtensions.GetDisplayName(prog.TrainingType)}", prog.Id.ToString(), prog.Id==TrainingProgram));
            Programs = _programs;
        }

        public TrainingVideos Edit(TrainingVideos trainingVid, string urlPath, Training_Program program)
        {
            trainingVid.Day = Day;
            trainingVid.Week = Week;
            trainingVid.Sets = Sets;
            trainingVid.Reps = Reps;
            trainingVid.BreakTime = Time;
            trainingVid.Title = Title;
            trainingVid.TrainingType = program.TrainingType;
            trainingVid.Program = program;
            trainingVid.UrlPath = string.IsNullOrEmpty(urlPath) ? trainingVid.UrlPath : urlPath;
            trainingVid.Order = Order;

            return trainingVid;
        }
    }

    public class DeleteTrainingVideo
    {
        public int Id { get; set; }
        public string DayHeader { get; set; }
        public string Title { get; set; }
        public string VideoPath { get; set; }
        public string TrainingType { get; set; }
        [Display(Name = "Contraseña")]
        public string Password { get; set; }
        public DeleteTrainingVideo() { }
        public DeleteTrainingVideo(TrainingVideos trainingVideos)
        {
            Id = trainingVideos.Id;
            //DayHeader = trainingVideos.DayHeader;
            Title = trainingVideos.Title;
            TrainingType = EnumExtensions.GetDisplayName(trainingVideos.TrainingType);
            VideoPath = GeneralFunction.GetUrlPath(trainingVideos.UrlPath);
        }
    }

    public class HomeTrainingModel
    {
        public IEnumerable<ViewProgramModel> Programs { get; set; }
        public HomeTrainingModel(IEnumerable<Training_Program> programs)
        {
            Programs = programs.Select(p => new ViewProgramModel(p));
        }
    }

    public class GymTrainingModel
    {
        public IEnumerable<ViewProgramModel> Programs { get; set; }
        public GymTrainingModel(IEnumerable<Training_Program> programs)
        {
            Programs = programs.Select(p => new ViewProgramModel(p));
        }
    }

    public class AdminTrainingViewModel
    {
        public TrainingType? TrainingType { get; set; }
        public Training_Program Program { get; set; }
        public int ProgramId { get; set; }
        public IEnumerable<ViewProgramModel> Programs { get; set; }
        public int Week { get; set; }
        public int Day { get; set; }
        public IEnumerable<ViewTrainingVideos> Training { get; set; }
        public AdminTrainingViewModel(TrainingType type, Training_Program program, int week, int day, IEnumerable<ViewTrainingVideos> training, IEnumerable<Training_Program> programs)
        {
            TrainingType = type;
            Program = program;
            ProgramId = program==null?0: program.Id;
            Week = week;
            Day = day;
            Training = training.OrderBy(t=>t.Order);
            Programs = programs.Select(p => new ViewProgramModel(p)).OrderBy(p=>p.Order);
        }
    }

    public class PrevVideoModel
    {
        public string Url { get; set; }
        public string Title { get; set; }
        public PrevVideoModel(string url, string title)
        {
            Url = url;
            Title = title;
        }
    }
}
