using System;
using System.Collections.Generic;
using System.Globalization;
using System.Text;

namespace IbradnzMealBuilder.Utility
{
    public class GeneralFunction
    {
        public static double RoundUp(double number, int digits)
        {
            return Math.Ceiling(number * Math.Pow(10, digits)) / Math.Pow(10, digits);
        }

        public static double RoundDown(double number, int decimalPlaces)
        {
            return Math.Floor(number * Math.Pow(10, decimalPlaces)) / Math.Pow(10, decimalPlaces);
        }

        public static double CalculateGramOfProtein(double proteinPerPlate, double unitValue, double proteinPerUnitGram)
        {
            return RoundUp(((proteinPerPlate - 5) * unitValue) / proteinPerUnitGram,0);
        }

        public static double CalculateGramOfFat(double fatRemaining, double unitValue, double fatPerUnitGram)
        {
            return RoundUp((fatRemaining * unitValue) / fatPerUnitGram,0);
        }

        public static double CalculateGramOfCarbs(double carbsRemaining, double unitValue, double carbsPerUnitGram)
        {
            return RoundUp((carbsRemaining * unitValue) / carbsPerUnitGram,0);
        }

        public static double CalculateGramOfVegetable(Goal goal)
        {
            if (goal == Goal.MuscleGain)
                return 100;
            else if (goal == Goal.FatLoss)
                return 150;
            else if (goal == Goal.Maintenance)
                return 100;
            return 0;
        }

        public static double CalculateRemainingFatFromProtein(double gramOfProtein, double fatPerUnitGramFromProtein, double unitValue, double fatPerPlate)
        {
            double fatOfSelection = RoundUp((gramOfProtein * fatPerUnitGramFromProtein) / unitValue,0);
            return fatPerPlate - fatOfSelection;
        }

        public static double CalculateRemainingCarbsFromProtein(double gramOfProtein, double carbsPerUnitGramFromProtein, double unitValue, double carbsPerPlate)
        {
            double carbsOfSelection = RoundUp((gramOfProtein * carbsPerUnitGramFromProtein) / unitValue,0);
            return carbsPerPlate - carbsOfSelection;
        }

        public static double CalculateRemainingCarbsFromFat(double gramOfFat, double carbsPerUnitGramFromFat, double unitValue,double remainingCarbsFromProtein)
        {
            double carbsOfSelection = RoundUp((gramOfFat * carbsPerUnitGramFromFat) / unitValue,0);
            return remainingCarbsFromProtein - carbsOfSelection;
        }


        public static double CalculateWaterIntake(double weight, Unit unit)
        {
            double waterintake = 0;
            waterintake = ((weight * 0.67) + 24) * 0.0295735;

            //if (unit == Unit.Lbs)
            //    waterintake = ((weight * 0.67) + 24) * 0.0295735;
            //else if (unit==Unit.Kgs)
            //    waterintake = ((weight * 0.67 * 0.45) + 24) * 0.0295735;
            //return Decimal.ToDouble(Decimal.Round((decimal)waterintake));
            return RoundUp(waterintake, 0);
        }

        public static double CalculateBMR(Gender gender,Unit unit, double weight, double height,DateTime dateOfBirth)
        {
            int age = CalculateAge(dateOfBirth);
            double BMR=0;
            if (gender == Gender.Male)
            {
                if (unit == Unit.Kgs)
                    BMR = (10 * weight) + (6.25D * height) - (5 * age) + 5;
                else if(unit == Unit.Lbs)
                    BMR = (10 * (weight * 0.453592)) + (6.25D * (height * 30.48)) - (5 * age) + 5;
            }
            else if(gender == Gender.Female)
            {
                if (unit == Unit.Kgs)
                    BMR = (10 * weight) + (6.25D * height) - (5 * age) - 161;
                else if (unit == Unit.Lbs)
                    BMR = (10 * (weight * 0.453592)) + (6.25D * (height * 30.48)) - (5 * age) - 161;
            }

            return RoundUp(BMR,0);
        }

        public static double CalculateBMR_IncludingActivityLevel(double BMR, ActivityLevel activityLevel)
        {
            double BMR_IncludingAL = 0;

            if (activityLevel == ActivityLevel.Sedentary)
                BMR_IncludingAL = BMR * 1.3D;
            else if (activityLevel == ActivityLevel.Active)
                BMR_IncludingAL = BMR * 1.45D;
            else if (activityLevel == ActivityLevel.Vigorously)
                BMR_IncludingAL = BMR * 1.6D;

            return RoundUp(BMR_IncludingAL, 0);
        }

        public static double CalculateDailyCalorieIntake(double BMR_IncludingAL,Goal goal)
        {
            if (goal == Goal.Maintenance)
                return BMR_IncludingAL;
            else if (goal == Goal.MuscleGain)
                return BMR_IncludingAL + 250;
            else if (goal == Goal.FatLoss)
                return BMR_IncludingAL - 750;
            return 0;
        }

        public static double CalculateCalorieForGender(Gender gender, double dailyCalorie)
        {
            if(gender == Gender.Male)
            {
                if (dailyCalorie < 1600)
                    return 1600;
                else
                    return dailyCalorie;
            }
            else if(gender == Gender.Female)
            {
                if (dailyCalorie < 1200)
                    return 1200;
                else
                    return dailyCalorie;
            }
            return 0;
        }

        public static double CalculateMacroProtein(double weight,double calories, Goal goal,Unit unit)
        {
            double macroProtein = 0;
            if (unit == Unit.Kgs)
            {
                if (goal == Goal.FatLoss)
                    macroProtein = weight * 2;
                else if (goal == Goal.MuscleGain)
                    macroProtein = weight * 2;
                else if (goal == Goal.Maintenance)
                    macroProtein = (calories * 0.35D) / 4;
            }
            else if (unit == Unit.Lbs)
            {
                if (goal == Goal.FatLoss)
                    macroProtein = weight * 0.4535 * 2;
                else if (goal == Goal.MuscleGain)
                    macroProtein = weight * 0.4535 * 2;
                else if (goal == Goal.Maintenance)
                    macroProtein = (calories * 0.35D) / 4;
            }
            return RoundUp(macroProtein,0);
        }

        public static double CalculateMacroFat(double calories, Goal goal)
        {
            double macroFat = 0;
            if (goal == Goal.FatLoss)
                macroFat = (calories * 0.32) / 9;   
            else if(goal == Goal.MuscleGain)
                macroFat = (calories * 0.32) / 9;
            else if(goal == Goal.Maintenance)
                macroFat = (calories * 0.3) / 9;
            return RoundUp(macroFat,0);
        }

        public static double CalculateMacroCarbohydrate(double calories,double macroProtein, double macroFat)
        {
            double macroCarbohydrate = (calories - (macroProtein * 4) - (macroFat * 9)) / 4;
            return RoundUp(macroCarbohydrate, 0);
        }
        public static int CalculateAge(DateTime dateOfBirth)
        {
            DateTime now = DateTime.Now;
            int age = now.Year - dateOfBirth.Year;
            if (now.Month < dateOfBirth.Month || (now.Month == dateOfBirth.Month && now.Day < dateOfBirth.Day))
                age--;

            return age;


        }

        public static string ConvertDateToSpanish(DateTime Date)
        {
            var day = Date.ToString("dddd",new CultureInfo("es-Es"));
            var month = Date.ToString("MMMM", new CultureInfo("es-Es"));
            var year = Date.Year.ToString();

            string dateInSpanish = $"{day}, {Date.Day} de {month}, {year}";
            return dateInSpanish;
        }

        public static string GetUrlPath(string url)
        {
            return $"~/{url.Remove(0, 8)}";
        }

        public static string GetNutrientUnit(string name)
        {
            var unit = (name == "Huevo Completo" || name == "Pan Integral" || name == "Tortillas de Maiz Pequenas")
               ? "uni" : "gr";
            return unit;
        }

        public static bool IsCustomerSubscribed(DateTime subscriptionDate)
        {
            if (DateTime.Compare(subscriptionDate, DateTime.UtcNow) < 0)
                return false;
            else
                return true;
        }

        public static double CalculateMacroCarbs(MacroNutrientRange range, double totalCalories)
        {
            double macroCarbs = 0;
            if (range == MacroNutrientRange.LowCarbohydrate)
                macroCarbs = (totalCalories * 0.20) / 4;
            else if(range == MacroNutrientRange.HighFat)
                macroCarbs = (totalCalories * 0.25) / 4;
            else if(range == MacroNutrientRange.HighCarbohydrate)
                macroCarbs = (totalCalories * 0.40) / 4;
            return RoundUp(macroCarbs, 0);
        }

        public static double CalculateMacroProtein(MacroNutrientRange range, double totalCalories)
        {
            double macroProtein = 0;
            if(range == MacroNutrientRange.LowCarbohydrate)
                macroProtein = (totalCalories * 0.45) / 4;
            else if(range == MacroNutrientRange.HighFat)
                macroProtein = (totalCalories * 0.30) / 4;
            else if(range == MacroNutrientRange.HighCarbohydrate)
                macroProtein = (totalCalories * 0.35) / 4;
            return RoundUp(macroProtein, 0);
        }

        public static double CalculateMacroFat(MacroNutrientRange range, double totalCalories)
        {
            double macroFat = 0;
            if (range == MacroNutrientRange.LowCarbohydrate)
                macroFat = (totalCalories * 0.35) / 9;
            if (range == MacroNutrientRange.HighCarbohydrate)
                macroFat = (totalCalories * 0.25) / 9;
            else if (range == MacroNutrientRange.HighFat)
                macroFat = (totalCalories * 0.45) / 9;
            return RoundUp(macroFat, 0);
        }
    }
}
