using IbradnzMealBuilder.Core;
using IbradnzMealBuilder.Data;
using IbradnzMealBuilder.Utility;
using Microsoft.AspNetCore.Identity;
using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.Configuration;
using Microsoft.Extensions.DependencyInjection;
using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace IbradnzMealBuilder
{
    public class DatabaseSeeder
    {
        public static async Task Initialize(IServiceProvider serviceProvider)
        {
            try
            {
                var _roleManager = serviceProvider.GetRequiredService<RoleManager<ApplicationRole>>();
                var _userManager = serviceProvider.GetRequiredService<UserManager<ApplicationUser>>();

                using (var context = new ApplicationDbContext(
                    serviceProvider.GetRequiredService<DbContextOptions<ApplicationDbContext>>()))
                {

                    if (await _roleManager.FindByNameAsync(AppConstant.AdminRole) == null)
                    {
                        string adminEmail = Startup.StaticConfig.GetValue<string>("AppSettings:AdminEmail");
                        string adminPassword = Startup.StaticConfig.GetValue<string>("AppSettings:AdminPassword");

                        await _roleManager.CreateAsync(new ApplicationRole(AppConstant.AdminRole));
                        var user = new ApplicationUser { UserName = adminEmail, Email = adminEmail, IsAccountSetUpComplete = true, };
                        var result = await _userManager.CreateAsync(user, adminPassword);
                        if (!result.Succeeded)
                            throw new Exception();
                        await _userManager.AddToRoleAsync(user, AppConstant.AdminRole);

                        var mealTypes = new List<MealType>()
                        {
                            new MealType{ Name = "yuca",NutrientClass=NutrientClass.Carbohydrate,CarbsPerUnitGram=27, FatPerUnitGram=0.4, ProteinPerUnitGram=3,
                                UnitValue = 100, IsDeleted=false,
                                DateCreated =DateTime.Now,DateCreatedUtc=DateTime.UtcNow,DateModified =DateTime.Now,DateModifiedUtc = DateTime.UtcNow},
                            new MealType{ Name = "Papa",NutrientClass=NutrientClass.Carbohydrate,CarbsPerUnitGram=21, FatPerUnitGram=0, ProteinPerUnitGram=2,
                                UnitValue = 100,IsDeleted=false,
                                DateCreated =DateTime.Now,DateCreatedUtc=DateTime.UtcNow,DateModified =DateTime.Now,DateModifiedUtc = DateTime.UtcNow},
                            new MealType{ Name = "Arroz integral",NutrientClass=NutrientClass.Carbohydrate,CarbsPerUnitGram=23, FatPerUnitGram=1, ProteinPerUnitGram=3,
                                UnitValue = 100,IsDeleted=false,
                                DateCreated =DateTime.Now,DateCreatedUtc=DateTime.UtcNow,DateModified =DateTime.Now,DateModifiedUtc = DateTime.UtcNow},
                             new MealType{ Name = "Arroz Blanco",NutrientClass=NutrientClass.Carbohydrate,CarbsPerUnitGram=29, FatPerUnitGram=7, ProteinPerUnitGram=0,
                                UnitValue = 100,IsDeleted=false,
                                DateCreated =DateTime.Now,DateCreatedUtc=DateTime.UtcNow,DateModified =DateTime.Now,DateModifiedUtc = DateTime.UtcNow},
                            new MealType{ Name = "Batata",NutrientClass=NutrientClass.Carbohydrate,CarbsPerUnitGram=20, FatPerUnitGram=0, ProteinPerUnitGram=2,
                                UnitValue = 100,IsDeleted=false,
                                DateCreated =DateTime.Now,DateCreatedUtc=DateTime.UtcNow,DateModified =DateTime.Now,DateModifiedUtc = DateTime.UtcNow},
                            new MealType{ Name = "Quinoa",NutrientClass=NutrientClass.Carbohydrate,CarbsPerUnitGram=20, FatPerUnitGram=2, ProteinPerUnitGram=3,
                                UnitValue = 100,IsDeleted=false,
                                DateCreated =DateTime.Now,DateCreatedUtc=DateTime.UtcNow,DateModified =DateTime.Now,DateModifiedUtc = DateTime.UtcNow},
                            new MealType{ Name = "Banana",NutrientClass=NutrientClass.Carbohydrate,CarbsPerUnitGram=23, FatPerUnitGram=0, ProteinPerUnitGram=1,
                                UnitValue = 100,IsDeleted=false,
                                DateCreated =DateTime.Now,DateCreatedUtc=DateTime.UtcNow,DateModified =DateTime.Now,DateModifiedUtc = DateTime.UtcNow},
                            new MealType{ Name = "Arandanos",NutrientClass=NutrientClass.Carbohydrate,CarbsPerUnitGram=14.5, FatPerUnitGram=0, ProteinPerUnitGram=1,
                                UnitValue = 100,IsDeleted=false,
                                DateCreated =DateTime.Now,DateCreatedUtc=DateTime.UtcNow,DateModified =DateTime.Now,DateModifiedUtc = DateTime.UtcNow},
                            new MealType{ Name = "Pina",NutrientClass=NutrientClass.Carbohydrate,CarbsPerUnitGram=13, FatPerUnitGram=0, ProteinPerUnitGram=0,
                                UnitValue = 100,IsDeleted=false,
                                DateCreated =DateTime.Now,DateCreatedUtc=DateTime.UtcNow,DateModified =DateTime.Now,DateModifiedUtc = DateTime.UtcNow},
                            new MealType{ Name = "Fresas",NutrientClass=NutrientClass.Carbohydrate,CarbsPerUnitGram=7, FatPerUnitGram=0, ProteinPerUnitGram=1,
                                UnitValue = 100,IsDeleted=false,
                                DateCreated =DateTime.Now,DateCreatedUtc=DateTime.UtcNow,DateModified =DateTime.Now,DateModifiedUtc = DateTime.UtcNow},
                            new MealType{ Name = "Kiwi",NutrientClass=NutrientClass.Carbohydrate,CarbsPerUnitGram=10, FatPerUnitGram=0.5, ProteinPerUnitGram=0,
                                UnitValue = 100,IsDeleted=false,
                                DateCreated =DateTime.Now,DateCreatedUtc=DateTime.UtcNow,DateModified =DateTime.Now,DateModifiedUtc = DateTime.UtcNow},
                            new MealType{ Name = "Manzana",NutrientClass=NutrientClass.Carbohydrate,CarbsPerUnitGram=14, FatPerUnitGram=0, ProteinPerUnitGram=0,
                                UnitValue = 100,IsDeleted=false,
                                DateCreated =DateTime.Now,DateCreatedUtc=DateTime.UtcNow,DateModified =DateTime.Now,DateModifiedUtc = DateTime.UtcNow},
                            new MealType{ Name = "Avena",NutrientClass=NutrientClass.Carbohydrate,CarbsPerUnitGram=67, FatPerUnitGram=7, ProteinPerUnitGram=12,
                                UnitValue = 100,IsDeleted=false,
                                DateCreated =DateTime.Now,DateCreatedUtc=DateTime.UtcNow,DateModified =DateTime.Now,DateModifiedUtc = DateTime.UtcNow},
                               new MealType{ Name = "Frijoles Negros Cocinados",NutrientClass=NutrientClass.Carbohydrate,CarbsPerUnitGram=22, FatPerUnitGram=1, ProteinPerUnitGram=8,
                                UnitValue = 100,IsDeleted=false,
                                DateCreated =DateTime.Now,DateCreatedUtc=DateTime.UtcNow,DateModified =DateTime.Now,DateModifiedUtc = DateTime.UtcNow},
                                new MealType{ Name = "Garbanzos Cocinados",NutrientClass=NutrientClass.Carbohydrate,CarbsPerUnitGram=27, FatPerUnitGram=3, ProteinPerUnitGram=9,
                                UnitValue = 100,IsDeleted=false,
                                DateCreated =DateTime.Now,DateCreatedUtc=DateTime.UtcNow,DateModified =DateTime.Now,DateModifiedUtc = DateTime.UtcNow},
                                  new MealType{ Name = "Kale",NutrientClass=NutrientClass.Carbohydrate,CarbsPerUnitGram=9, FatPerUnitGram=1, ProteinPerUnitGram=4,
                                UnitValue = 100,IsDeleted=false,
                                DateCreated =DateTime.Now,DateCreatedUtc=DateTime.UtcNow,DateModified =DateTime.Now,DateModifiedUtc = DateTime.UtcNow},
                                   new MealType{ Name = "Coles de brusellas",NutrientClass=NutrientClass.Carbohydrate,CarbsPerUnitGram=9, FatPerUnitGram=1, ProteinPerUnitGram=4,
                                UnitValue = 100,IsDeleted=false,
                                DateCreated =DateTime.Now,DateCreatedUtc=DateTime.UtcNow,DateModified =DateTime.Now,DateModifiedUtc = DateTime.UtcNow},
                            new MealType{ Name = "Coliflor",NutrientClass=NutrientClass.Carbohydrate,CarbsPerUnitGram=5, FatPerUnitGram=0, ProteinPerUnitGram=2,
                                UnitValue = 100,IsDeleted=false,
                                DateCreated =DateTime.Now,DateCreatedUtc=DateTime.UtcNow,DateModified =DateTime.Now,DateModifiedUtc = DateTime.UtcNow},
                            new MealType{ Name = "Broccoli",NutrientClass=NutrientClass.Carbohydrate,CarbsPerUnitGram=7, FatPerUnitGram=0, ProteinPerUnitGram=3,
                                UnitValue = 100,IsDeleted=false,
                                DateCreated =DateTime.Now,DateCreatedUtc=DateTime.UtcNow,DateModified =DateTime.Now,DateModifiedUtc = DateTime.UtcNow},
                            new MealType{ Name = "vainitas",NutrientClass=NutrientClass.Carbohydrate,CarbsPerUnitGram=7, FatPerUnitGram=0, ProteinPerUnitGram=2,
                                UnitValue = 100,IsDeleted=false,
                                DateCreated =DateTime.Now,DateCreatedUtc=DateTime.UtcNow,DateModified =DateTime.Now,DateModifiedUtc = DateTime.UtcNow},
                            new MealType{ Name = "Esparragos",NutrientClass=NutrientClass.Carbohydrate,CarbsPerUnitGram=4, FatPerUnitGram=0, ProteinPerUnitGram=2,
                                UnitValue = 100,IsDeleted=false,
                                DateCreated =DateTime.Now,DateCreatedUtc=DateTime.UtcNow,DateModified =DateTime.Now,DateModifiedUtc = DateTime.UtcNow},
                            new MealType{ Name = "Espinaca",NutrientClass=NutrientClass.Carbohydrate,CarbsPerUnitGram=4, FatPerUnitGram=0, ProteinPerUnitGram=3,
                                UnitValue = 100,IsDeleted=false,
                                DateCreated =DateTime.Now,DateCreatedUtc=DateTime.UtcNow,DateModified =DateTime.Now,DateModifiedUtc = DateTime.UtcNow},
                            new MealType{ Name = "Tomates",NutrientClass=NutrientClass.Carbohydrate,CarbsPerUnitGram=2, FatPerUnitGram=0, ProteinPerUnitGram=1,
                                UnitValue = 100,IsDeleted=false,
                                DateCreated =DateTime.Now,DateCreatedUtc=DateTime.UtcNow,DateModified =DateTime.Now,DateModifiedUtc = DateTime.UtcNow},
                            new MealType{ Name = "Hongos",NutrientClass=NutrientClass.Carbohydrate,CarbsPerUnitGram=3, FatPerUnitGram=0, ProteinPerUnitGram=3,
                                UnitValue = 100,IsDeleted=false,
                                DateCreated =DateTime.Now,DateCreatedUtc=DateTime.UtcNow,DateModified =DateTime.Now,DateModifiedUtc = DateTime.UtcNow},
                            new MealType{ Name = "Pan Integral",NutrientClass=NutrientClass.Carbohydrate,CarbsPerUnitGram=11, FatPerUnitGram=1, ProteinPerUnitGram=3,
                                UnitValue = 1,IsDeleted=false,
                                DateCreated =DateTime.Now,DateCreatedUtc=DateTime.UtcNow,DateModified =DateTime.Now,DateModifiedUtc = DateTime.UtcNow},
                               new MealType{ Name = "Tortillas de Maiz Pequenas",NutrientClass=NutrientClass.Carbohydrate,CarbsPerUnitGram=11, FatPerUnitGram=1, ProteinPerUnitGram=1,
                                UnitValue = 1,IsDeleted=false,
                                DateCreated =DateTime.Now,DateCreatedUtc=DateTime.UtcNow,DateModified =DateTime.Now,DateModifiedUtc = DateTime.UtcNow},

                            new MealType{ Name = "Espinaca",NutrientClass=NutrientClass.Vegetables,CarbsPerUnitGram = 0, FatPerUnitGram = 0, ProteinPerUnitGram = 0,
                                UnitValue = 0,IsDeleted=false,
                                DateCreated =DateTime.Now,DateCreatedUtc=DateTime.UtcNow,DateModified =DateTime.Now,DateModifiedUtc = DateTime.UtcNow},
                            new MealType{ Name = "Lechuga",NutrientClass=NutrientClass.Vegetables,CarbsPerUnitGram = 0, FatPerUnitGram = 0, ProteinPerUnitGram = 0,
                                UnitValue = 0,IsDeleted=false,
                                DateCreated =DateTime.Now,DateCreatedUtc=DateTime.UtcNow,DateModified =DateTime.Now,DateModifiedUtc = DateTime.UtcNow},
                            new MealType{ Name = "Kale",NutrientClass=NutrientClass.Vegetables,CarbsPerUnitGram = 0, FatPerUnitGram = 0, ProteinPerUnitGram = 0,
                                UnitValue = 0,IsDeleted=false,
                                DateCreated =DateTime.Now,DateCreatedUtc=DateTime.UtcNow,DateModified =DateTime.Now,DateModifiedUtc = DateTime.UtcNow},
                            new MealType{ Name = "Coles de Brusselas",NutrientClass=NutrientClass.Vegetables,CarbsPerUnitGram = 0, FatPerUnitGram = 0, ProteinPerUnitGram = 0,
                                UnitValue = 0,IsDeleted=false,
                                DateCreated =DateTime.Now,DateCreatedUtc=DateTime.UtcNow,DateModified =DateTime.Now,DateModifiedUtc = DateTime.UtcNow},
                            new MealType{ Name = "Coliflor",NutrientClass=NutrientClass.Vegetables,CarbsPerUnitGram = 0, FatPerUnitGram = 0, ProteinPerUnitGram = 0,
                                UnitValue = 0,IsDeleted=false,
                                DateCreated =DateTime.Now,DateCreatedUtc=DateTime.UtcNow,DateModified =DateTime.Now,DateModifiedUtc = DateTime.UtcNow},
                            new MealType{ Name = "Broccoli",NutrientClass=NutrientClass.Vegetables,CarbsPerUnitGram = 0, FatPerUnitGram = 0, ProteinPerUnitGram = 0,
                                UnitValue = 0,IsDeleted=false,
                                DateCreated =DateTime.Now,DateCreatedUtc=DateTime.UtcNow,DateModified =DateTime.Now,DateModifiedUtc = DateTime.UtcNow},
                            new MealType{ Name = "Espárragos",NutrientClass=NutrientClass.Vegetables,CarbsPerUnitGram = 0, FatPerUnitGram = 0, ProteinPerUnitGram = 0,
                                UnitValue = 0,IsDeleted=false,
                                DateCreated =DateTime.Now,DateCreatedUtc=DateTime.UtcNow,DateModified =DateTime.Now,DateModifiedUtc = DateTime.UtcNow},
                            new MealType{ Name = "Vainitas",NutrientClass=NutrientClass.Vegetables,CarbsPerUnitGram = 0, FatPerUnitGram = 0, ProteinPerUnitGram = 0,
                                UnitValue = 0,IsDeleted=false,
                                DateCreated =DateTime.Now,DateCreatedUtc=DateTime.UtcNow,DateModified =DateTime.Now,DateModifiedUtc = DateTime.UtcNow},
                            new MealType{ Name = "tomate",NutrientClass=NutrientClass.Vegetables,CarbsPerUnitGram = 0, FatPerUnitGram = 0, ProteinPerUnitGram = 0,
                                UnitValue = 0,IsDeleted=false,
                                DateCreated =DateTime.Now,DateCreatedUtc=DateTime.UtcNow,DateModified =DateTime.Now,DateModifiedUtc = DateTime.UtcNow},
                            new MealType{ Name = "calabacín",NutrientClass=NutrientClass.Vegetables,CarbsPerUnitGram = 0, FatPerUnitGram = 0, ProteinPerUnitGram = 0,
                                UnitValue = 0,IsDeleted=false,
                                DateCreated =DateTime.Now,DateCreatedUtc=DateTime.UtcNow,DateModified =DateTime.Now,DateModifiedUtc = DateTime.UtcNow},
                            new MealType{ Name = "pepino",NutrientClass=NutrientClass.Vegetables,CarbsPerUnitGram = 0, FatPerUnitGram = 0, ProteinPerUnitGram = 0,
                                UnitValue = 0,IsDeleted=false,
                                DateCreated =DateTime.Now,DateCreatedUtc=DateTime.UtcNow,DateModified =DateTime.Now,DateModifiedUtc = DateTime.UtcNow},

                            new MealType{ Name = "Pechuga de pollo",NutrientClass=NutrientClass.Protein,CarbsPerUnitGram=0, FatPerUnitGram=3, ProteinPerUnitGram=20,
                                UnitValue = 100,IsDeleted=false,
                                DateCreated =DateTime.Now,DateCreatedUtc=DateTime.UtcNow,DateModified =DateTime.Now,DateModifiedUtc = DateTime.UtcNow},
                            new MealType{ Name = "Pavo molido 93/7",NutrientClass=NutrientClass.Protein,CarbsPerUnitGram=0, FatPerUnitGram=7, ProteinPerUnitGram=19,
                                UnitValue = 100,IsDeleted=false,
                                DateCreated =DateTime.Now,DateCreatedUtc=DateTime.UtcNow,DateModified =DateTime.Now,DateModifiedUtc = DateTime.UtcNow},
                            new MealType{ Name = "Carne de Res molida 93/7",NutrientClass=NutrientClass.Protein,CarbsPerUnitGram=0, FatPerUnitGram=10, ProteinPerUnitGram=29,
                                UnitValue = 100,IsDeleted=false,
                                DateCreated =DateTime.Now,DateCreatedUtc=DateTime.UtcNow,DateModified =DateTime.Now,DateModifiedUtc = DateTime.UtcNow},
                            new MealType{ Name = "Chuleta de lomo de cerdo",NutrientClass=NutrientClass.Protein,CarbsPerUnitGram=0, FatPerUnitGram=6, ProteinPerUnitGram=32,
                                UnitValue = 100,IsDeleted=false,
                                DateCreated =DateTime.Now,DateCreatedUtc=DateTime.UtcNow,DateModified =DateTime.Now,DateModifiedUtc = DateTime.UtcNow},
                            new MealType{ Name = "Salmon",NutrientClass=NutrientClass.Protein,CarbsPerUnitGram=0, FatPerUnitGram=8, ProteinPerUnitGram=21,
                                UnitValue = 100,IsDeleted=false,
                                DateCreated =DateTime.Now,DateCreatedUtc=DateTime.UtcNow,DateModified =DateTime.Now,DateModifiedUtc = DateTime.UtcNow},
                            new MealType{ Name = "Bacalao",NutrientClass=NutrientClass.Protein,CarbsPerUnitGram=0, FatPerUnitGram=4, ProteinPerUnitGram=21,
                                UnitValue = 100,IsDeleted=false,
                                DateCreated =DateTime.Now,DateCreatedUtc=DateTime.UtcNow,DateModified =DateTime.Now,DateModifiedUtc = DateTime.UtcNow},
                            new MealType{ Name = "Sardinas",NutrientClass=NutrientClass.Protein,CarbsPerUnitGram=4, FatPerUnitGram=4, ProteinPerUnitGram=16,
                                UnitValue = 100,IsDeleted=false,
                                DateCreated =DateTime.Now,DateCreatedUtc=DateTime.UtcNow,DateModified =DateTime.Now,DateModifiedUtc = DateTime.UtcNow},
                            new MealType{ Name = "Camarones",NutrientClass=NutrientClass.Protein,CarbsPerUnitGram=0, FatPerUnitGram=2, ProteinPerUnitGram=25,
                                UnitValue = 100,IsDeleted=false,
                                DateCreated =DateTime.Now,DateCreatedUtc=DateTime.UtcNow,DateModified =DateTime.Now,DateModifiedUtc = DateTime.UtcNow},
                            new MealType{ Name = "Atun",NutrientClass=NutrientClass.Protein,CarbsPerUnitGram=2, FatPerUnitGram=2, ProteinPerUnitGram=18,
                                UnitValue = 100,IsDeleted=false,
                                DateCreated =DateTime.Now,DateCreatedUtc=DateTime.UtcNow,DateModified =DateTime.Now,DateModifiedUtc = DateTime.UtcNow},
                              new MealType{ Name = "Tofu",NutrientClass=NutrientClass.Protein,CarbsPerUnitGram=2, FatPerUnitGram=5, ProteinPerUnitGram=8,
                                UnitValue = 100,IsDeleted=false,
                                DateCreated =DateTime.Now,DateCreatedUtc=DateTime.UtcNow,DateModified =DateTime.Now,DateModifiedUtc = DateTime.UtcNow},
                            new MealType{ Name = "Claras de huevo",NutrientClass=NutrientClass.Protein,CarbsPerUnitGram=1, FatPerUnitGram=0, ProteinPerUnitGram=11,
                                UnitValue = 100,IsDeleted=false,
                                DateCreated =DateTime.Now,DateCreatedUtc=DateTime.UtcNow,DateModified =DateTime.Now,DateModifiedUtc = DateTime.UtcNow},
                            new MealType{ Name = "Whey Protein",NutrientClass=NutrientClass.Protein,CarbsPerUnitGram=10, FatPerUnitGram=3, ProteinPerUnitGram=82,
                                UnitValue = 100,IsDeleted=false,
                                DateCreated =DateTime.Now,DateCreatedUtc=DateTime.UtcNow,DateModified =DateTime.Now,DateModifiedUtc = DateTime.UtcNow},

                            new MealType{ Name = "Aguacate",NutrientClass=NutrientClass.Fat,CarbsPerUnitGram=10, FatPerUnitGram=15, ProteinPerUnitGram=0,
                                UnitValue = 100,IsDeleted=false,
                                DateCreated =DateTime.Now,DateCreatedUtc=DateTime.UtcNow,DateModified =DateTime.Now,DateModifiedUtc = DateTime.UtcNow},
                            new MealType{ Name = "Aceite de Oliva",NutrientClass=NutrientClass.Fat,CarbsPerUnitGram=0, FatPerUnitGram=100, ProteinPerUnitGram=0,
                                UnitValue = 100,IsDeleted=false,
                                DateCreated =DateTime.Now,DateCreatedUtc=DateTime.UtcNow,DateModified =DateTime.Now,DateModifiedUtc = DateTime.UtcNow},
                             new MealType{ Name = "Mantequilla de Mani",NutrientClass=NutrientClass.Fat,CarbsPerUnitGram=24, FatPerUnitGram=48, ProteinPerUnitGram=21,
                                UnitValue = 100,IsDeleted=false,
                                DateCreated =DateTime.Now,DateCreatedUtc=DateTime.UtcNow,DateModified =DateTime.Now,DateModifiedUtc = DateTime.UtcNow},
                            new MealType{ Name = "Mani",NutrientClass=NutrientClass.Fat,CarbsPerUnitGram = 18, FatPerUnitGram = 50, ProteinPerUnitGram = 28,
                                UnitValue = 100,IsDeleted=false,
                                DateCreated =DateTime.Now,DateCreatedUtc=DateTime.UtcNow,DateModified =DateTime.Now,DateModifiedUtc = DateTime.UtcNow},
                                  new MealType{ Name = "Almendras",NutrientClass=NutrientClass.Fat,CarbsPerUnitGram = 21, FatPerUnitGram = 50, ProteinPerUnitGram = 21,
                                UnitValue = 100,IsDeleted=false,
                                DateCreated =DateTime.Now,DateCreatedUtc=DateTime.UtcNow,DateModified =DateTime.Now,DateModifiedUtc = DateTime.UtcNow},
                            new MealType{ Name = "Semillas de Girasol",NutrientClass=NutrientClass.Fat,CarbsPerUnitGram = 20, FatPerUnitGram = 50, ProteinPerUnitGram = 23,
                                UnitValue = 100,IsDeleted=false,
                                DateCreated =DateTime.Now,DateCreatedUtc=DateTime.UtcNow,DateModified =DateTime.Now,DateModifiedUtc = DateTime.UtcNow},
                            new MealType{ Name = "Huevo Completo",NutrientClass=NutrientClass.Fat,CarbsPerUnitGram = 1, FatPerUnitGram = 5, ProteinPerUnitGram = 6,
                                UnitValue = 1,IsDeleted=false,
                                DateCreated =DateTime.Now,DateCreatedUtc=DateTime.UtcNow,DateModified =DateTime.Now,DateModifiedUtc = DateTime.UtcNow},
                        };
                        mealTypes.ForEach(m => context.MealType.Add(m));
                        await context.SaveChangesAsync();
                    }

                    if (await _roleManager.FindByNameAsync(AppConstant.CustomerRole) == null)
                        await _roleManager.CreateAsync(new ApplicationRole(AppConstant.CustomerRole));

                    //if (context.TrainingDay.Count() == 0)
                    //{
                    //    var trainingTypes = Enum.GetValues(typeof(TrainingType)).Cast<TrainingType>();
                    //    var programs = Enum.GetValues(typeof(TrainingProgram)).Cast<TrainingProgram>();
                    //    var trainingDays = new List<TrainingDay>();
                    //    foreach(var type in trainingTypes)
                    //    {
                    //        foreach (var program in programs)
                    //        {
                    //            for (int j = 1; j <= 12; j++)
                    //            {
                    //                for (int i = 1; i <= 5; i++)
                    //                {
                    //                    trainingDays.Add(new TrainingDay { Name = $"PIERNAS {i} - {j}", Day = i, Week = j, Program = program, Type = type });
                    //                }
                    //            }
                    //        }
                    //    }
                        
                    //    trainingDays.ForEach(m => context.TrainingDay.Add(m));
                    //    await context.SaveChangesAsync();
                    //}

                    if(context.CountryPhoneCode.Count() == 0)
                    {
                        var countryCodes = JsonConvert.DeserializeObject<List<CountryPhoneCode>>(AppConstant.CountryPhoneJson);
                        countryCodes.ForEach(c => c.DateCreated = DateTime.Now);
                        countryCodes.ForEach(c => c.DateCreatedUtc = DateTime.Now);
                        countryCodes.ForEach(c => c.DateModified = DateTime.Now);
                        countryCodes.ForEach(c => c.DateModifiedUtc = DateTime.Now);

                        context.CountryPhoneCode.AddRange(countryCodes);
                        await context.SaveChangesAsync();
                    }
                }
            }
            catch (Exception ex)
            {

                throw;
            }
        }
    }
}
