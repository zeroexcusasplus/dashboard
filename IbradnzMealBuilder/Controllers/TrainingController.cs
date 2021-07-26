using System;
using System.Collections.Generic;
using System.Linq;
using System.Security.Claims;
using System.Threading.Tasks;
using IbradnzMealBuilder.Core;
using IbradnzMealBuilder.CustomFilters;
using IbradnzMealBuilder.Models;
using IbradnzMealBuilder.Service.Contract;
using IbradnzMealBuilder.Utility;
using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Identity;
using Microsoft.AspNetCore.Mvc;

namespace IbradnzMealBuilder.Controllers
{
    [Authorize(Roles = AppConstant.CustomerRole)]
    [CheckIfAccountIsComplete_TrainingController]
    public class TrainingController : Controller
    {
        private readonly UserManager<ApplicationUser> _userManager;
        private readonly SignInManager<ApplicationUser> _signInManager;
        private readonly ICustomerService _customerService;
        private readonly ITrainingVideoService _trainingVidService;
        private readonly ITechniqueVideoService _techniqueVideoService;
        private readonly ILiveZoomService _liveZoomService;
        private readonly ITrainingDayService _trainingDayService;
        private readonly IProgramService _programService;
        private readonly IMuscleGroupService _muscleGroupService;

        public TrainingController(UserManager<ApplicationUser> userManager, SignInManager<ApplicationUser> signInManager, ICustomerService customerService, ITrainingVideoService trainingVidService, ITechniqueVideoService techniqueVideoService, ILiveZoomService liveZoomService, ITrainingDayService trainingDayService, IProgramService programService, IMuscleGroupService muscleGroupService)
        {
            _userManager = userManager;
            _signInManager = signInManager;
            _customerService = customerService;
            _trainingVidService = trainingVidService;
            _techniqueVideoService = techniqueVideoService;
            _liveZoomService = liveZoomService;
            _trainingDayService = trainingDayService;
            _programService = programService;
            _muscleGroupService = muscleGroupService;
        }

        public IActionResult Index()
        {
            //return View();
            return RedirectToAction(nameof(GymTraining));
        }

        [AllowAnonymous]
        public IActionResult ChangeWeek(int changeBy, int currentWeek, int program)
        {
            int week = 1;
            if (currentWeek == AppConstant.TotalTrainingWeeks && changeBy > 0)
                week = changeBy;
            else if (currentWeek == 1 && changeBy < 0)
                week = AppConstant.TotalTrainingWeeks;
            else
                week = currentWeek + changeBy;
            var model = GetTrainingModel(week, program);
            return PartialView("_TrainingVideos", model);
        }

        public IActionResult HomeTraining()
        {
            ViewBag.Training = "HOME";
            return View(new HomeTrainingModel(_programService.GetAllByType(TrainingType.Home).OrderBy(p=>p.Order)));
        }

        public IActionResult HomeTrainingProgram(int id)
        {
            ViewBag.Training = "HOME";
            var model = GetTrainingModel(1, id);
            return View(model);
        }

        public IActionResult GymTraining()
        {
            ViewBag.Training = "GYM";
            return View(new GymTrainingModel(_programService.GetAllByType(TrainingType.Gym).OrderBy(p => p.Order)));
        }

        public IActionResult GymTrainingProgram(int id)
        {
            ViewBag.Training = "GYM";
            var model = GetTrainingModel(1, id);
            return View(model);
        }

        public IActionResult TechniqueAndTutorials()
        {
            var muscleGroups = _muscleGroupService.GetAll();
            var model = muscleGroups.Select(m => new ViewMuscleGroupModel(m)).OrderBy(m=>m.Order);
            ViewBag.Training = "TECHNIQUE";
            return View(model);
        }

        public IActionResult TechniqueTraining(int id)
        {
            var techniqueVideos = _techniqueVideoService.GetAllForMuscleType(id);
            var muscle = _muscleGroupService.Get(id);
            var model = new ViewTechniqueForMuscle(techniqueVideos, muscle.Name, GetLoggedInCustomer());
            ViewBag.Training = "TECHNIQUE";
            return View(model);
        }

        public IActionResult LiveZoom()
        {
            var liveZooms = _liveZoomService.GetAll();
            var model = liveZooms.Select(l => new ViewLiveZoomModel(l));
            return View(model);
        }

        public ApplicationUser GetLoggedInUser()
        {
            var userId = User.FindFirstValue(ClaimTypes.NameIdentifier);
            var user = _userManager.Users.Where(u => u.Id == userId).ToList().FirstOrDefault();
            return user;
        }

        public TrainingIndexViewModel GetTrainingModel(int week, int programId)
        {
            var trainingVideos = _trainingVidService.GetByTypeProgramAndWeek(programId, week).ToList();
            var program = _programService.Get(programId);
            var trainingVideoGroups = (from trainingVids in trainingVideos
                                       group trainingVids by trainingVids.Day into groups
                                       select new { Day = groups.Key, Videos = groups.OrderBy(d => d.Order) });
            var combo = trainingVideoGroups
                        .Select(groups =>
                            new TrainingComboModel(
                                program.TrainingType,
                                program,
                                week,
                                groups.Day,
                                groups.Videos
                                    .Select(t => new ViewTrainingVideos(t)).ToList()
                                    )).ToList();
            var trainingDays = _trainingDayService.GetAll().Select(t => new ViewTrainingDayModel(t));
            var model = new TrainingIndexViewModel(combo, trainingDays, week, program.TrainingType, program, GetLoggedInCustomer());
            return model;
        }

        public IActionResult PlayVideo(int id,int type)
        {
            if (type == 1)
            {
                var video = _trainingVidService.GetById(id);
                return PartialView("_PlayVideo",new VideoPlayer(video));
            }
            else
            {
                var video = _techniqueVideoService.Get(id);
                return PartialView("_PlayVideo", new VideoPlayer(video));
            }
        }

        public IActionResult GetTechniqueVideo(int id)
        {
            var video = _techniqueVideoService.Get(id);
            return PartialView("_PlayVideo", new VideoPlayer(video));
        }

        private Customer GetLoggedInCustomer()
        {
            var user = GetLoggedInUser();
            if (user == null)
                throw new Exception();
            return _customerService.GetCustomerByUserId(user.Id);
        }
    }
}
