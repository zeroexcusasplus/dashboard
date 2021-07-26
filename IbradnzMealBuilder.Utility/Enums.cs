using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Reflection;
using System.Text;

namespace IbradnzMealBuilder.Utility
{
    public static class EnumExtensions
    {
        public static string GetDisplayName(this Enum enumValue)
        {
            return enumValue.GetType()
                            .GetMember(enumValue.ToString())
                            .First()
                            .GetCustomAttribute<DisplayAttribute>()
                            .GetName();
        }

        public static string GetDescription(this Enum enumValue)
        {
            return enumValue.GetType()
                            .GetMember(enumValue.ToString())
                            .First()
                            .GetCustomAttribute<MuscleGroupDescription>()
                            .Description;
        }

        public static string GetTrainingProgramDescription(this Enum enumValue)
        {
            return enumValue.GetType()
                          .GetMember(enumValue.ToString())
                          .First()
                          .GetCustomAttribute<TrainingProgramDescription>()
                          .Description;
        }

        public static string GetTrainingProgramVideoUrl(this Enum enumValue)
        {
            return enumValue.GetType()
                          .GetMember(enumValue.ToString())
                          .First()
                          .GetCustomAttribute<TrainingProgramVideoUrl>()
                          .Url;
        }

        public static string GetGoalEmojiUrl(this Enum enumValue)
        {
            return enumValue.GetType()
                            .GetMember(enumValue.ToString())
                            .First()
                            .GetCustomAttribute<GoalEmojiDescription>()
                            .EmojiUrl;
        }

        public static string GetSubscriptionName(this Enum enumValue)
        {
            return enumValue.GetType()
                            .GetMember(enumValue.ToString())
                            .First()
                            .GetCustomAttribute<SubscriptionDescriptions>()
                            .Name;
        }

  

        public static string GetSubscriptionPriceDesc(this Enum enumValue)
        {
            return enumValue.GetType()
                            .GetMember(enumValue.ToString())
                            .First()
                            .GetCustomAttribute<SubscriptionDescriptions>()
                            .PriceDescription;
        }
    }

    public enum Gender
    {
        [Display(Name = "Hombre")]
        Male,

        [Display(Name = "Mujer")]
        Female
    }

    public enum Unit
    {
        [Display(Name = "Lbs/feet")]
        Lbs,

        [Display(Name = "Kgs/cm")]
        Kgs
    }

    public enum ActivityLevel
    {
        [Display(Name = "Sedentario (Trabajas sentado todo el día. Haces actividades físicas 0 - 20 minutos al día)")]
        Sedentary,

        [Display(Name = "Ligeramente Activo (Trabajas sentado la mitad del día. Haces actividades físicas 20 - 45 minutos al día)")]
        Active,

        [Display(Name = "Activo (Trabajas en movimiento todo el día. Haces actividades físicas 45 - 90 minutos al día)")]
        Vigorously,
    }

    public enum Goal
    {
        [Display(Name = "Perdida de Grasa. Disminuye tu porcentaje de grasa y define tus musculos.")]
        [GoalEmojiDescription("/Images/icons/fire.png")]
        FatLoss,

        [Display(Name = "Aumento de Masa Muscular. Incrementa el tamaño de tus músculos.")]
        [GoalEmojiDescription("/Images/icons/biceps_goal.png")]
        MuscleGain,

        [Display(Name = "Mantenimiento. Conserva tu peso corporal actual")]
        [GoalEmojiDescription("/Images/icons/victory-hand_goal.png")]
        Maintenance
    }

    public enum NutrientClass
    {
        [Display(Name = "Carbohydrate")]
        Carbohydrate,

        [Display(Name = "Vegetables")]
        Vegetables,

        [Display(Name = "Protein")]
        Protein,

        [Display(Name = "Fat")]
        Fat
    }

    public enum SubscriptionPlan
    {
        //[Display(Name = "Zero Excusas Gratis")]
        //[SubscriptionDescriptions("Zero Excusas Gratis ", "")]
        //Free,


        [Display(Name = "Zero Excusas Plus Mensual $39,99 /mes")]
        [SubscriptionDescriptions("Zero Excusas Plus Mensual", "$39,99 /mes")]
        Monthly,

        [Display(Name = "Zero Excusas Plus Anual $19,99 /mes")]
        [SubscriptionDescriptions("Zero Excusas Plus Anual", "$19,99 /mes")]
        Yearly,


    }

    public enum TrainingType
    {

        [Display(Name = "Entrenamiento en Casa")]
        Home,

        [Display(Name = "Entrenamiento en el gym")]
        Gym,

        //[Display(Name = "Tecnicas y Tutoriales")]
        //TechniquesAndTutorials
    }

    //public enum MuscleGroup
    //{
    //    [Display(Name = "Espalda")]
    //    [MuscleGroupDescription("Rutina de Espalda")]
    //    Shoulder,

    //    [Display(Name = "Brazos")]
    //    [MuscleGroupDescription("Rutina de Brazos")]
    //    Arms,
        
    //    [Display(Name = "Cofre")]
    //    [MuscleGroupDescription("Rutina de Cofre")]
    //    Chest,
        
    //    [Display(Name = "Abdomen")]
    //    [MuscleGroupDescription("Rutina de Abdomen")]
    //    Abdomen, 
        
    //    [Display(Name = "Atrás")]
    //    [MuscleGroupDescription("Rutina de Atrás")]
    //    Back,
        
    //    [Display(Name = "Extremo")]
    //    [MuscleGroupDescription("Rutina de Extremo")]
    //    Butt,
        
    //    [Display(Name = "Muslos")]
    //    [MuscleGroupDescription("Rutina de Muslos")]
    //    Thighs,
        
    //    [Display(Name = "Piernas")]
    //    [MuscleGroupDescription("Rutina de Piernas")]
    //    Legs
    //}

    //public enum TrainingProgram
    //{
    //    [Display(Name = "Hipertrofia Brutal Nivel Basico")]
    //    [TrainingProgramDescription("12 weeks program")]
    //    [TrainingProgramVideoUrl("~/Files/ProgramUrl/videoplayback.mp4")]
    //    HipertrofiaBrutalNivelBasico,

    //    [Display(Name ="Programa 2")]
    //    [TrainingProgramDescription("12 weeks program")]
    //    [TrainingProgramVideoUrl("~/Files/ProgramUrl/videoplayback.mp4")]
    //    Programa2,

    //    [Display(Name = "Programa 3")]
    //    [TrainingProgramDescription("12 weeks program")]
    //    [TrainingProgramVideoUrl("~/Files/ProgramUrl/videoplayback.mp4")]
    //    Programa3,

    //    [Display(Name = "Programa 4")]
    //    [TrainingProgramDescription("12 weeks program")]
    //    [TrainingProgramVideoUrl("~/Files/ProgramUrl/videoplayback.mp4")]
    //    Programa4,
    //}

    public enum MacroNutrientRange
    {
        [Display(Name = "Baja en Carbohidratos")]
        LowCarbohydrate,

        [Display(Name = "Alta en Grasas")]
        HighFat,

        [Display(Name = "Alta en Carbohidratos")]
        HighCarbohydrate,
    }

    [AttributeUsage(AttributeTargets.Field, AllowMultiple = false, Inherited = true)]
    public class MuscleGroupDescription : Attribute
    {
        public string Description { get; set; }

        public MuscleGroupDescription(string description)
        {
            Description = description;
        }
    }


    [AttributeUsage(AttributeTargets.Field, AllowMultiple = false, Inherited = true)]
    public class SubscriptionDescriptions : Attribute
    {
        public string Name { get; set; }
        public string PriceDescription { get; set; }

        public SubscriptionDescriptions(string name, string priceDescription)
        {
            Name = name;
            PriceDescription = priceDescription;
        }
    }


    [AttributeUsage(AttributeTargets.Field, AllowMultiple = false, Inherited = true)]
    public class TrainingProgramDescription : Attribute
    {
        public string Description { get; set; }

        public TrainingProgramDescription(string description)
        {
            Description = description;
        }
    }

    [AttributeUsage(AttributeTargets.Field, AllowMultiple = false, Inherited = true)]
    public class TrainingProgramVideoUrl : Attribute
    {
        public string Url { get; set; }

        public TrainingProgramVideoUrl(string url)
        {
            Url = url;
        }
    }

    [AttributeUsage(AttributeTargets.Field, AllowMultiple =false, Inherited =true)]
    public class GoalEmojiDescription : Attribute
    {
        public string EmojiUrl { get; set; }
        public GoalEmojiDescription(string url)
        {
            EmojiUrl = url;
        }
    }
}
