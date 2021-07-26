using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Security.Claims;
using System.Threading.Tasks;
using IbradnzMealBuilder.Core;
using IbradnzMealBuilder.Models;
using IbradnzMealBuilder.Service.Contract;
using IbradnzMealBuilder.Utility;
using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Identity;
using Microsoft.AspNetCore.Mvc;

namespace IbradnzMealBuilder.Controllers
{
    [Authorize(Roles = AppConstant.AdminRole)]
    public class AdminController : Controller
    {
        private readonly IMealTypeService _mealTypeService;
        private readonly ITrainingVideoService _trainingVidService;
        private readonly ITechniqueVideoService _techniqueVideoService;
        private readonly ICustomerService _customerService;
        private readonly ILiveZoomService _liveZoomService;
        private readonly ITrainingDayService _trainingDayService;
        private readonly IFaqService _faqService;
        private readonly IProgramService _programService;
        private readonly IMuscleGroupService _muscleGroupService;
        private readonly UserManager<ApplicationUser> _userManager;
        public AdminController(IMealTypeService mealTypeService, ITrainingVideoService trainingVidService, UserManager<ApplicationUser> userManager, 
            ITechniqueVideoService techniqueVideoService, ICustomerService customerService, ILiveZoomService liveZoomService, ITrainingDayService trainingDayService,
            IFaqService faqService, IProgramService programService, IMuscleGroupService muscleGroupService)
        {
            _mealTypeService = mealTypeService;
            _trainingVidService = trainingVidService;
            _userManager = userManager;
            _techniqueVideoService = techniqueVideoService;
            _customerService = customerService;
            _liveZoomService = liveZoomService;
            _trainingDayService = trainingDayService;
            _faqService = faqService;
            _programService = programService;
            _muscleGroupService = muscleGroupService;
        }
        public IActionResult Index()
        {
            return RedirectToAction(nameof(Mealtypes));
        }

        public IActionResult Mealtypes()
        {
            var allMealtypes = _mealTypeService.GetAllMealTypes();
            ViewMealTypesViewModel mealTypes = new ViewMealTypesViewModel(allMealtypes.ToList());
            //IEnumerable<MealTypeViewModel> _mealTypes = mealTypes.GetMealTypes(allMealtypes.ToList());
            return View(mealTypes);
        }

        public IActionResult NewMealType()
        {
            return View();
        }

        [HttpPost]
        public async Task<IActionResult> NewMealType(AddMealTypeViewModel mealTypeModel)
        {
            if (!ModelState.IsValid)
            {
                ModelState.AddModelError("", "Uno o más errores de validación");
                return View();
            }
            if (_mealTypeService.CheckIfMealTypeExist(mealTypeModel.Name, 0))
            {
                ModelState.AddModelError("Name", "Meal type already exist");
                return View();
            }

            var mealType = mealTypeModel.AddMealType(mealTypeModel);
            await _mealTypeService.AddMealType(mealType);
            return RedirectToAction(nameof(Mealtypes));
        }

        public IActionResult EditMealType(int id)
        {
            var mealType = _mealTypeService.GetMealTypeById(id);
            EditMealTypeViewModel mealTypeModel = new EditMealTypeViewModel(mealType);
            return View(mealTypeModel);
        }

        [HttpPost]
        public async Task<IActionResult> EditMealType(EditMealTypeViewModel mealTypeModel)
        {
            if (!ModelState.IsValid)
            {
                ModelState.AddModelError("", "Uno o más errores de validación");
                return View();
            }
            if (_mealTypeService.CheckIfMealTypeExist(mealTypeModel.Name, mealTypeModel.MealTypeId))
            {
                ModelState.AddModelError("Name", "Meal type already exist");
                return View();
            }

            var mealType = _mealTypeService.GetMealTypeById(mealTypeModel.MealTypeId);
            mealType = mealTypeModel.EditMealTypeMap(mealType);
            await _mealTypeService.EditMealType(mealType);
            return RedirectToAction(nameof(Mealtypes));
        }

        public IActionResult TrainingVideos(TrainingType TrainingType,int program, int week, int day)
        {
            var trainingVideos = _trainingVidService.GetAll();
            var tutProgram = _programService.Get(program);
            //tutProgram = tutProgram == null ? _programService.GetAll().FirstOrDefault() : tutProgram;
            //program = tutProgram == null ? 0 : tutProgram.Id;

            var trainingVidModel = trainingVideos
                .Select(t => new ViewTrainingVideos(t))
                .Where(t => t.TrainingType == EnumExtensions.GetDisplayName(TrainingType));
            if (program > 0)
                trainingVidModel = trainingVidModel.Where(t => t.ProgramId == program);
            if (week > 0)
                trainingVidModel = trainingVidModel.ToList().Where(t => t.Week == week);
            if (day > 0)
                trainingVidModel = trainingVidModel.Where(t => t.Day == day);

            var model = new AdminTrainingViewModel(TrainingType, tutProgram, week, day, 
                trainingVidModel, _programService.GetAllByType(TrainingType));
            ViewBag.ProgramId = program;
            return View(model);
        }

        public IActionResult ProgramsForTrainingType(TrainingType type)
        {
            var programs = _programService.GetAllByType(type);
            var model = programs.Select(p => new ViewProgramModel(p));
            ViewBag.ProgramId = 0;
            return PartialView("_ProgramSelectOption", model);
        }


        public IActionResult AddTrainingVideo()
        {
            var preVideos = GetAllPrevVideos();
            return View(new AddTrainingVideosViewModel(preVideos,_programService.GetAll()));
        }

        [HttpPost]
        public async Task<IActionResult> AddTrainingVideo(AddTrainingVideosViewModel trainingModel)
        {
            if (!ModelState.IsValid)
            {
                ModelState.AddModelError("", "One or more validations failed");
                var preVideos = GetAllPrevVideos();
                return View(new AddTrainingVideosViewModel(preVideos, _programService.GetAll()));
            }

            string videoPath = !string.IsNullOrEmpty(trainingModel.YouTubeUrl) ? trainingModel.YouTubeUrl : trainingModel.PrevVideoUrl;
            var program = _programService.Get(trainingModel.TrainingProgram);

            if (program == null)
            {
                ModelState.AddModelError("", "Select program");
                var preVideos = GetAllPrevVideos();
                return View(new AddTrainingVideosViewModel(preVideos, _programService.GetAll()));
            }
            if (string.IsNullOrEmpty(videoPath))
            {
                ModelState.AddModelError("", "No file selected");
                var preVideos = GetAllPrevVideos();
                return View(new AddTrainingVideosViewModel(preVideos, _programService.GetAll()));
            }

            var trainingVideo = trainingModel.AddVideo(videoPath,program);
            await _trainingVidService.Add(trainingVideo);

            return RedirectToAction(nameof(TrainingVideos));
        }
        
        public IActionResult EditTrainingVideo(int id)
        {
            var trainingVid = _trainingVidService.GetById(id);
            var trainingModel = new EditTrainingVideo(trainingVid,GetAllPrevVideos(),_programService.GetAll());
            return View(trainingModel);
        }

        [HttpPost]
        
        public async Task<IActionResult> EditTrainingVideo(EditTrainingVideo trainingModel)
        {
            if (!ModelState.IsValid)
                throw new Exception();
            var trainingVid = _trainingVidService.GetById(trainingModel.Id);
            if (trainingVid == null)
                throw new Exception();

            string videoPath = !string.IsNullOrEmpty(trainingModel.YouTubeUrl) ? trainingModel.YouTubeUrl : trainingModel.PrevVideoUrl;
            var program = _programService.Get(trainingModel.TrainingProgram);

            trainingVid = trainingModel.Edit(trainingVid, videoPath,program);
            await _trainingVidService.Edit(trainingVid);

            //delete prev video

            return RedirectToAction(nameof(TrainingVideos));
        }

        public IActionResult DeleteTrainingVideo(int id)
        {
            var trainingVid = _trainingVidService.GetById(id);
            var trainingModel = new DeleteTrainingVideo(trainingVid);

            return PartialView("_DeleteTrainingVideo",trainingModel);
        }

        [HttpPost]
        public async Task<IActionResult> DeleteTrainingVideo(DeleteTrainingVideo trainingModel)
        {
            var user = GetLoggedInUser();
            if (!await _userManager.CheckPasswordAsync(user, trainingModel.Password))
                return RedirectToAction(nameof(TrainingVideos));

            var trainingVid = _trainingVidService.GetById(trainingModel.Id);
            trainingVid.IsDeleted = true;
            await _trainingVidService.Edit(trainingVid);
            return RedirectToAction(nameof(TrainingVideos));
        }

        public IActionResult TechniqueVideos(int MuscleGroupId)
        {
            var videos = _techniqueVideoService.GetAll()
                .Select(v => new ViewTechniqueVideoModel(v))
                .OrderBy(v => v.Order);
            if (MuscleGroupId > 0)
                videos = videos.Where(v => v.MuscleGroupId == MuscleGroupId).OrderBy(v => v.Order);
            return View(new AdminTechniqueVideosViewModel(MuscleGroupId, videos,_muscleGroupService.GetAll()));
        }

        public IActionResult AddTechniqueVideo()
        {
            var preVideos = GetAllPrevVideos();
            return View(new AddTechniqueVideoModel(preVideos, _muscleGroupService.GetAll()));
        }

        [HttpPost]
        public async Task<IActionResult> AddTechniqueVideo(AddTechniqueVideoModel model)
        {
            if (!ModelState.IsValid)
            {
                var preVideos = GetAllPrevVideos();
                return View(new AddTechniqueVideoModel(preVideos,_muscleGroupService.GetAll()));
            }

            string videoPath = !string.IsNullOrEmpty(model.YouTubeUrl) ? model.YouTubeUrl : model.PrevVideoUrl;
            var muscleGroup = _muscleGroupService.Get(model.MuscleGroup);
            if (string.IsNullOrEmpty(videoPath))
            {
                ModelState.AddModelError("", "No file selected");
                var preVideos = GetAllPrevVideos();
                return View(new AddTechniqueVideoModel(preVideos,_muscleGroupService.GetAll()));
            }
            if (muscleGroup==null)
            {
                ModelState.AddModelError("", "Muscle group not selected");
                var preVideos = GetAllPrevVideos();
                return View(new AddTechniqueVideoModel(preVideos, _muscleGroupService.GetAll()));
            }

            var techniqueVideo = model.Add(videoPath,muscleGroup);
            await _techniqueVideoService.Add(techniqueVideo);

            return RedirectToAction(nameof(TechniqueVideos));
        }

        public IActionResult EditTechniqueVideo(int id)
        {
            var video = _techniqueVideoService.Get(id);
            var model = new EditTechniqueVideoModel(video, GetAllPrevVideos(), _muscleGroupService.GetAll());
            return View(model);
        }

        [HttpPost]
        public async Task<IActionResult> EditTechniqueVideo(EditTechniqueVideoModel model)
        {
            if (!ModelState.IsValid)
                throw new Exception();
            var techniqueVid = _techniqueVideoService.Get(model.Id);
            if (techniqueVid == null)
                throw new Exception();

            string videoPath = !string.IsNullOrEmpty(model.YouTubeUrl) ? model.YouTubeUrl : model.PrevVideoUrl;
            var muscleGroup = _muscleGroupService.Get(model.MuscleGroup);
            techniqueVid = model.Edit(techniqueVid, videoPath, muscleGroup);
            await _techniqueVideoService.Edit(techniqueVid);

            //delete prev video

            return RedirectToAction(nameof(TechniqueVideos));
        }

        public IActionResult DeleteTechniqueVideo(int id)
        {
            var techniqueVideo = _techniqueVideoService.Get(id);
            var model = new DeleteTechniqueVideo(techniqueVideo);

            return PartialView("_DeleteTechniqueVideo", model);
        }

        [HttpPost]
        public async Task<IActionResult> DeleteTechniqueVideo(DeleteTechniqueVideo model)
        {
            var user = GetLoggedInUser();
            if (!await _userManager.CheckPasswordAsync(user, model.Password))
                return RedirectToAction(nameof(TechniqueVideos));

            var techniqueVideo = _techniqueVideoService.Get(model.Id);
            techniqueVideo.IsDeleted = true;
            await _techniqueVideoService.Edit(techniqueVideo);
            return RedirectToAction(nameof(TechniqueVideos));
        }

        public IActionResult LiveZooms()
        {
            var livezooms = _liveZoomService.GetAll();
            var model = livezooms.Select(l => new ViewLiveZoomModel(l));
            return View(model);
        }

        public IActionResult AddLiveZoom()
        {
            return View();
        }

        [HttpPost]
        public async Task<IActionResult> AddLiveZoom(AddLiveZoomModel model)
        {
            if (!ModelState.IsValid)
            {
                ModelState.AddModelError("", "Uno o más errores de validación");
                return View();
            }
            var liveZoom = model.Add();
            await _liveZoomService.Add(liveZoom);
            return RedirectToAction(nameof(LiveZooms));
        }

        public async Task<IActionResult> ChangeLiveStatus(int id)
        {
            var liveZoom = _liveZoomService.Get(id);
            await _liveZoomService.ChangeLiveStatus(liveZoom);
            return RedirectToAction(nameof(LiveZooms));
        }

        public IActionResult TrainingDays()
        {
            var trainingDays = _trainingDayService.GetAll();
            var model = trainingDays.Select(t => new ViewTrainingDayModel(t))
                        .OrderBy(t=>t.TrainingType).ThenBy(t=>t.TrainingProgram).ThenBy(t=>t.Week).ThenBy(t=>t.Day);
            return View(model);
        }

        public IActionResult EditTrainingDay(int id)
        {
            var trainingDay = _trainingDayService.Get(id);
            return View(new EditTrainingDayModel(trainingDay));
        }

        [HttpPost]
        public async Task<IActionResult> EditTrainingDay(EditTrainingDayModel model)
        {
            if (!ModelState.IsValid)
            {
                ModelState.AddModelError("", "One or more validations failed");
                return View();
            }
            var trainingDay = _trainingDayService.Get(model.Id);
            trainingDay = model.Edit(trainingDay);
            await _trainingDayService.Update(trainingDay);
            return RedirectToAction(nameof(TrainingDays));
        }

        public async Task<IActionResult> ResetTrainingDaysNow()
        {
            var trainingDays = _trainingDayService.GetAll();
            await _trainingDayService.DeleteRange(trainingDays);
            return Content("");
        }

        public IActionResult Faq()
        {
            var answeredQuestions = _faqService.GetAnsweredQuestion().Select(f=> new ViewFaqModel(f));
            var unAnsweredQuestions = _faqService.GetUnAnsweredQuestion().Select(f => new ViewFaqModel(f));
            var model = new ViewFaqAdminModel(answeredQuestions, unAnsweredQuestions);
            return View(model);
        }

        public IActionResult AddFaq()
        {
            return View();
        }

        [HttpPost]
        public async Task<IActionResult> AddFaq(AddFaqModel model)
        {
            if (!ModelState.IsValid)
            {
                ModelState.AddModelError("", "Uno o más errores de validación");
                return View();
            }

            var faq = model.Add();
            await _faqService.Add(faq);
            return RedirectToAction(nameof(Faq));
        }

        public IActionResult ViewFaq(int id)
        {
            var faq = _faqService.Get(id);
            var model = new ViewFaqModel(faq);
            return View(model);
        }

        public IActionResult EditFaq(int id)
        {
            var faq = _faqService.Get(id);
            var model = new EditFaqModel(faq);
            return View(model);
        }

        [HttpPost]
        public async Task<IActionResult> EditFaq(EditFaqModel model)
        {
            if (!ModelState.IsValid)
            {
                ModelState.AddModelError("", "Uno o más errores de validación");
                return View();
            }

            var faq = _faqService.Get(model.Id);
            faq = model.Edit(faq);
            await _faqService.Edit(faq);
            return RedirectToAction(nameof(ViewFaq), new { id = model.Id });
        }

        public IActionResult Programs()
        {
            try
            {
                var programs = _programService.GetAll();
                var model = programs.Select(t => new ViewProgramModel(t,true)).OrderBy(t=>t.Order);
                return View(model);
            }
            catch (Exception ex)
            {
                throw;
            }
        }

        public IActionResult AddProgram()
        {
            return View();
        }

        [HttpPost]
        public async Task<IActionResult> AddProgram(AddProgramModel model)
        {
            if (!ModelState.IsValid)
            {
                ModelState.AddModelError("", "Uno o más errores de validación");
                return View();
            }

            var trainingProgram = model.Add();
            await _programService.Add(trainingProgram);
            return RedirectToAction(nameof(Programs));
        }

        public IActionResult EditProgram(int id)
        {
            var trainingProgram = _programService.Get(id);
            var model = new EditProgramModel(trainingProgram);
            return View(model);
        }

        [HttpPost]
        public async Task<IActionResult> EditProgram(EditProgramModel model)
        {
            if (!ModelState.IsValid)
            {
                ModelState.AddModelError("", "Uno o más errores de validación");
                return View();
            }

            var trainingProgram = _programService.Get(model.Id);
            trainingProgram = model.Edit(trainingProgram);
            await _programService.Edit(trainingProgram);
            return RedirectToAction(nameof(Programs));
        }

        //public async Task<IActionResult> DeleteTrainingProgram(int id)
        //{
        //    var trainingProgram = _trainingProgramService.Get(id);
        //    await _trainingProgramService.Delete(trainingProgram);
        //    return Json(new { });
        //}

        public IActionResult MuscleGroups()
        {
            var muscleGroups = _muscleGroupService.GetAll();
            var model = muscleGroups.Select(m => new ViewMuscleGroupModel(m,true    )).OrderBy(m=>m.Order);
            return View(model);
        }

        public IActionResult AddMuscleGroup()
        {
            return View();
        }

        [HttpPost]
        public async Task<IActionResult> AddMuscleGroup(AddMuscleGroupModel model)
        {
            if (!ModelState.IsValid)
            {
                ModelState.AddModelError("", "Uno o más errores de validación");
                return View();
            }

            var muslceGroup = model.Add();
            await _muscleGroupService.Add(muslceGroup);
            return RedirectToAction(nameof(MuscleGroups));
        }

        public IActionResult EditMuscleGroup(int id)
        {
            var muscleGroup = _muscleGroupService.Get(id);
            var model = new EditMuscleGroupModel(muscleGroup);
            return View(model);
        }

        [HttpPost]
        public async Task<IActionResult> EditMuscleGroup(EditMuscleGroupModel model)
        {
            if (!ModelState.IsValid)
            {
                ModelState.AddModelError("", "Uno o más errores de validación");
                return View();
            }

            var muscleGroup = _muscleGroupService.Get(model.Id);
            muscleGroup = model.Edit(muscleGroup);
            await _muscleGroupService.Edit(muscleGroup);
            return RedirectToAction(nameof(MuscleGroups));
        }

        public ApplicationUser GetLoggedInUser()
        {
            var userId = User.FindFirstValue(ClaimTypes.NameIdentifier);
            var user = _userManager.Users.Where(u => u.Id == userId).FirstOrDefault();
            if (user == null)
                throw new Exception();
            return user;
        }

        public async Task<IActionResult> DeleteFaq(int id)
        {
            var faq = _faqService.Get(id);
            await _faqService.Delete(faq);
            return RedirectToAction(nameof(Faq));
        }

        public Customer GetLoggedInCustomer()
        {
            var user = GetLoggedInUser();
            if (user == null)
                throw new Exception();
            return _customerService.GetCustomerByUserId(user.Id);
        }

        private IEnumerable<PrevVideoModel> GetAllPrevVideos()
        {
            var preVideos = new List<PrevVideoModel>();
            var allTraining = _trainingVidService.GetAll();
            var allTechnique = _techniqueVideoService.GetAll();
            preVideos.AddRange(allTraining.Select(t => new PrevVideoModel(t.UrlPath, t.Title)));
            preVideos.AddRange(allTechnique.Select(t => new PrevVideoModel(t.UrlPath, t.Title)));
            return preVideos.OrderBy(p => p.Title);
        }
    }
}