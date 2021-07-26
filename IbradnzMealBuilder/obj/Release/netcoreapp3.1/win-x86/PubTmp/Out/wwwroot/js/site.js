// Please see documentation at https://docs.microsoft.com/aspnet/core/client-side/bundling-and-minification
// for details on configuring this project to bundle and minify static web assets.

// Write your JavaScript code.

function OpenNavbarSidenav() {
    document.getElementById("navbar-sidenav").style.width = "300px";
}

function CloseNavbarSidenav() {
    document.getElementById("navbar-sidenav").style.width = "0";
}

function OpenMsgBox() {
    if (window.screen.width > 767) {
        document.getElementById("msgBox").style.width = "300px";
    } else {
        document.getElementById("msgBox").style.width = "100%";
    }
}

function CloseMsgBox() {
    document.getElementById("msgBox").style.width = "0";
}

var ltrsOfWater = document.getElementById("WaterIntake");

function CalculateMealAmount(mealNumberId) {
    var proteinSelected = $('#proteinSelect' + mealNumberId).find(":selected").val();
    var carbohydrateSelected = $('#carbohydrateSelect' + mealNumberId).find(":selected").val();
    var fatSelected = $('#fatSelect' + mealNumberId).find(":selected").val();

    var macroProtein = document.getElementById("MacrosProtein");
    var macroCarbohydrate = document.getElementById("MacrosCarbohydrate");
    var macroFat = document.getElementById("MacroFat");
    var mealNumber = document.getElementById("MealNumber");

    var carbohydrateAmt = '#carbohydrateAmt' + mealNumberId;
    var carbohydrateAmtGr = '#carbohydrateAmtGr' + mealNumberId;
    var proteinAmt = '#proteinAmt' + mealNumberId;
    var proteinAmtGr = '#proteinAmtGr' + mealNumberId;
    var fatAmt = '#fatAmt' + mealNumberId;
    var fatAmtGr = '#fatAmtGr' + mealNumberId;

    var customize = document.querySelector('input[name="Customize"]:checked').value;
    CloseMsgBox();

    $.ajax({
        url: "/Meals/CalculateMealAmount/",
        dataType: "json",
        data: {
            carbohydrateId: carbohydrateSelected, proteinId: proteinSelected, fatId: fatSelected,
            macrosCarbs: macroCarbohydrate.value, macrosProtein: macroProtein.value, macrosFat: macroFat.value, numberOfPlate: mealNumber.value,
        },
        success: function (result) {

            $(carbohydrateAmt).val(result.carbs);
            $(carbohydrateAmtGr).html(result.carbsAndUnit);

            $(proteinAmt).val(result.protein);
            $(proteinAmtGr).html(result.proteinAndUunit);

            $(fatAmt).val(result.fat);
            $(fatAmtGr).html(result.fatAndUnit);

            if (customize == 1) {
                $(".otherCarbsAmtGr").html(result.carbsAndUnit);
                $(".otherCarbsInput").val(result.carbs);
                $(".otherCarbsSelect").val(carbohydrateSelected);

                $(".otherProteinAmtGr").html(result.proteinAndUunit);
                $(".otherProteinInput").val(result.protein);
                $(".otherProteinSelect").val(proteinSelected);

                $(".otherFatAmtGr").html(result.fatAndUnit);
                $(".otherFatInput").val(result.fat);
                $(".otherFatSelect").val(fatSelected);
            }
            
            if (Number(result.fat) < 0) {
                LowProteinOption();
            }
        },
        error: function (xhr, status, error) {
            //ShowSnackbarError("Oops, sorry! Error");
        }
    });

}


function OpenSidenav() {
    var sideNav = document.getElementById("sidenav");
    sideNav.style.width = "300px";
    sideNav.classList.add("sideNavBorder");
}

function CloseSidenav() {
    var sideNav = document.getElementById("sidenav");
    sideNav.style.width = "0";
    sideNav.classList.remove("sideNavBorder");
}

function ChangeMacroNutrientsUnavailable() {

    $.ajax({
        url: "/Meals/PremiumUsersOnly/",
        dataType: "html",
        data: {
        },
        success: function (result) {
            $("#sidebarbody").html(result);
            OpenSidenav();
        },
        error: function (xhr, status, error) {

        }
    });
}

function CustomizeMealsUnavialable() {
    $("input[name=Customize][value='1']").prop("checked", true);
    $.ajax({
        url: "/Meals/PremiumUsersOnly/",
        dataType: "html",
        data: {
        },
        success: function (result) {
            $("#sidebarbody").html(result);
            OpenSidenav();
        },
        error: function (xhr, status, error) {

        }
    });
}

function ChangeMacroNutrients() {
    var MacroNutrientRange = document.getElementById("MacroNutrientRange");
    var macroRangeSelected = 0;
    if (MacroNutrientRange != null) {
        macroRangeSelected = MacroNutrientRange.value;
    }
    $.ajax({
        url: "/Meals/ChangeMacroNutrient/",
        dataType: "html",
        data: { macroNutrientRange: macroRangeSelected },
        success: function (result) {
            $("#sidebarbody").html(result);
            OpenSidenav();
        },
        error: function (xhr, status, error) {

        }
    });
}


function ChangeMacroNutrientsPost() {

    var calories = Number(document.getElementById("Calories").value);
    var MacroNutrientRange = document.getElementById("MacroNutrientRange").value;
    $.ajax({
        url: "/Meals/ChangeMacroNutrientPost/",
        dataType: "json",
        data: {
            totalCalories: calories, macroNutrientRange: MacroNutrientRange
        },
        success: function (result) {
            $("#MacrosProtein").val(result.macrosProtein);
            document.getElementById("MacrosProteinLabel").innerHTML = result.macrosProtein + " gr";

            $("#MacroFat").val(result.macrosFat);
            document.getElementById("MacrosFatLabel").innerHTML = result.macrosFat + " gr";

            $("#MacrosCarbohydrate").val(result.macrosCarbs);
            document.getElementById("MacrosCarbohydrateLabel").innerHTML = result.macrosCarbs + " gr";

            ReloadMealTable();
            CloseSidenav();

        },
        error: function (xhr, status, error) {
            //ShowSnackbarError("Oops, sorry! Error");
        }
    });

}

function CalculateTotalMacros() {
    var MacrosProteinPercentage = Number(document.getElementById("MacrosProteinPercentage").value);
    var MacrosFatPercentage = Number(document.getElementById("MacrosFatPercentage").value);
    var MacrosCarbsPercentage = Number(document.getElementById("MacrosCarbsPercentage").value);

    var total = MacrosProteinPercentage + MacrosFatPercentage + MacrosCarbsPercentage;
    if (total == 100) {
        document.getElementById("totalPercentValid").innerHTML = "100%";
        document.getElementById("totalPercentInvalid").innerHTML = "";
    } else {
        document.getElementById("totalPercentValid").innerHTML = "";
        document.getElementById("totalPercentInvalid").innerHTML = total + "%";
    }
}

function ChangeDate(changeBy) {
    var date = $('#Date').val();
    _date = new Date(date);
    $.ajax({
        url: "/Meals/ChangeDate/",
        dataType: "json",
        data: {
            date: date, moveDateBy: changeBy
        },
        success: function (result) {
            document.getElementById("Date").value = result.date;
            document.getElementById("DateInSpanish").innerHTML = result.dateInSpanish;
            document.getElementById("mealBuilder-main-container").scrollIntoView();
        },
        error: function (xhr, status, error) {
            //ShowSnackbarError("Oops, sorry! Error");
        }
    });

}


function ChangeDateUnavailable() {

    $.ajax({
        url: "/Meals/PremiumUsersOnly/",
        dataType: "html",
        data: {
          
        },
        success: function (result) {
            $("#sidebarbody").html(result);
            OpenSidenav();
        },
        error: function (xhr, status, error) {

        }
    });
}

function CustomizeMeals() {
    var customize = document.querySelector('input[name="Customize"]:checked').value;
    if (customize == 1) {
        $('.otherMealsSelect').attr("disabled", true);

        $(".otherCarbsAmtGr").val(document.getElementsByClassName("firstCarbsAmtGr")[0].value);
        $(".othercarbsinput").val(document.getElementsByClassName("firstCarbsInput")[0].value);
        $(".otherCarbsSelect").val(document.getElementsByClassName("firstCarbsSelect")[0].value);

        $(".otherProteinAmtGr").val(document.getElementsByClassName("firstProeinAmtGr")[0].value);
        $(".otherProteinInput").val(document.getElementsByClassName("firstProteinInput")[0].value);
        $(".otherProteinSelect").val(document.getElementsByClassName("firstProteinSelect")[0].value);

        $(".otherFatAmtGr").val(document.getElementsByClassName("firstFatAmtGr")[0].value);
        $(".otherFatInput").val(document.getElementsByClassName("firstFatInput")[0].value);
        $(".otherFatSelect").val(document.getElementsByClassName("firstFatSelect")[0].value);
    }
    else
        $('.otherMealsSelect').attr("disabled", false);
}

function ReloadMealTable() {
    var mealNumber = document.getElementById("MealNumber");
    var customize = document.querySelector('input[name="Customize"]:checked').value;
    var macroProtein = document.getElementById("MacrosProtein");
    var macroCarbohydrate = document.getElementById("MacrosCarbohydrate");
    var macroFat = document.getElementById("MacroFat");

    $.ajax({
        url: "/Meals/MealBuilderTable/",
        dataType: "html",
        data: {
            mealNumber: mealNumber.value, customize: customize, ltrOfWater: ltrsOfWater.value,
            macroProtein: macroProtein.value, macroCarbohydrate: macroCarbohydrate.value, macroFat: macroFat.value
        },
        success: function (result) {
            $("#mealBuilderTable").html(result);
        },
        error: function (xhr, status, error) {
            //ShowSnackbarError("Oops, sorry! Error");
        }
    });
}


function ChangeNumberOfMeals() {
    var isUserSubscribed = document.getElementById("isUserSubscribed").value;
    var mealNumber = document.getElementById("MealNumber").value;
    if (mealNumber > 4 && isUserSubscribed == false) {
        PremiumUsersOnly();
    }
    else {
        ReloadMealTable();
    }
}



function ChangeWeekOfTrainingVideo(changeBy) {
    var currentWeek = $('#DayOfWeek').val();
    var program = $("#TrainingProgramId").val();

    $.ajax({
        url: "/Training/ChangeWeek/",
        dataType: "html",
        data: {
            changeBy: changeBy, currentWeek: currentWeek, program: program
        },
        success: function (result) {
            $("#training-videos").html(result);
        },
        error: function (result, status, error) {
        }
    });

}

function PremiumUsersOnly() {
    $.ajax({
        url: "/Home/PremiumUsersOnly/",
        dataType: "html",
        data: {
        },
        success: function (result) {
            $("#sidebarbody").html(result);
            OpenSidenav();
        },
        error: function (xhr, status, error) {

        }
    });
}

function LowProteinOption() {
    $.ajax({
        url: "/Home/LowProteinOption/",
        dataType: "html",
        data: {
        },
        success: function (result) {
            $("#msgBoxBody").html(result);
            OpenMsgBox();
            //setTimeout(function () {
            //    CloseMsgBox();
            //}, 5000);
        },
        error: function (xhr, status, error) {

        }
    });
}


function PlayTrainingVid(id, type) {
    var url = "/Training/PlayVideo?id=" + id + "&type=" + type;
    $("#videoPlayerBody").load(url, function () {
        $("#videoPlayer").modal("show");
    })
}

function ShowUploading() {
    openUploadingBox();
    return true;
}

function openUploadingBox() {
    document.getElementById("loading-effect").style.display = "block";
}

function closeUploadingBox() {
    document.getElementById("loading-effect").style.display = "none";
}

$('form').submit(function () {
    if ($("form").valid()) {
        $("#submit-button").prop('disabled', true);
        //$("#submit-button").prop('value', 'Saving..');
        document.getElementById("submit-button").style.cursor = "context-menu";
        document.getElementById("submit-button").style.backgroundColor = "#59d6e9";
        document.getElementById("submit-button").style.color = "black";
    }
});