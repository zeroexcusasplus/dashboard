using IbradnzMealBuilder.Core;
using IbradnzMealBuilder.Utility;
using Microsoft.Office.Interop.Excel;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace IbradnzMealBuilder.Models
{
    public class ViewTrainingDayModel
    {
        public int Id { get; set; }
        public int Week { get; set; }
        public int Day { get; set; }
        public string Name { get; set; }
        public string TrainingProgram { get; set; }
        public Training_Program TProgram { get; set; }
        public TrainingType TrainingType { get; set; }
        public string TraininigTypeString { get; set; }
        public ViewTrainingDayModel(TrainingDay trainingDay)
        {
            Id = trainingDay.Id;
            Day = trainingDay.Day;
            Week = trainingDay.Week;
            Name = trainingDay.Name;
            TrainingProgram = trainingDay.T_Program.Name;
            TProgram = trainingDay.T_Program;
            TrainingType = trainingDay.T_Program.TrainingType;
            TraininigTypeString = EnumExtensions.GetDisplayName(TrainingType);
        }
    }

    public class EditTrainingDayModel
    {
        public int Id { get; set; }
        public int Day { get; set; }
        public int Week { get; set; }
        public string Name { get; set; }
        public string TrainingProgram { get; set; }

        [Display(Name="Training type")]
        public string TrainingType { get; set; }

        public EditTrainingDayModel()
        {

        }
        public EditTrainingDayModel(TrainingDay trainingDay)
        {
            Id = trainingDay.Id;
            Week = trainingDay.Week;
            Day = trainingDay.Day;
            Name = trainingDay.Name;
            TrainingProgram = trainingDay.T_Program.Name;
        }

        public TrainingDay Edit(TrainingDay trainingDay)
        {
            trainingDay.Name = Name;
            return trainingDay;
        }
    }
}
