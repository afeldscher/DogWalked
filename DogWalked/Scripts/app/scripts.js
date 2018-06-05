
page = 0;
newUrl = "/DogWalked/Content/Logo.png";

function leftarrow() {
    //if there is no previous page exit
    if ($("#dog" + (page - 1)).length == 0) {
        return;
    }

    $("#dog" + page).hide();
    page--;
    $("#dog" + page).show()
}


function rightarrow() {
    //if there is no next page exit
    if ($("#dog" + (page + 1)).length == 0) {
        return;
    }

    $("#dog" + page).hide();
    page++;
    $("#dog" + page).show();
}

function iconClick(item) {
    $(item).toggleClass('full')
        .animate({ backgroundColor: "#FFFFFF" }, 500);
    $(item + 'Dot').fadeToggle();
}


//----Setup Arrow Key navigation----
document.onkeyup = function (e) {
    e = e || window.event;
    if (e.keyCode == '37') {
        leftarrow();
    }
    else if (e.keyCode == '39') {
        rightarrow();
    }
}


function createDog() {
    if ($("#createDog #dogName").val().trim() == "") {
        $("#createDog #dogName").css("background-color", "#e4868f");
        return;
    }

    //Rename create page to +1
    $("#dog" + page).attr("id", "dog" + (page + 1));
    page++;

    //---Create new Dog---
    $newDog = $("#dog" + (page - 2)).clone(true);
    $newDog.attr("id", "dog" + (page - 1));
    $newDog.find(".dogName").html($("#createDog #dogName").val());
    $newDog.find(".dogImg").attr("src", newUrl);

    //---Insert New dog and go to it---
    $("#dogs .container").append($newDog);
    leftarrow();


    //---Reset text boxes---
    $("#createDog #dogName").css("background-color", "#fff");
    $("#createDog #dogName").val("");
    newUrl = "/DogWalked/Content/Logo.png";
    $("#createDog #createDogLogo").attr('src', newUrl);
}


function uploadImg() {
    $("#createDog #imageUpload").click();
}


function readURL(input) {
    if (input.files && input.files[0]) {
        var reader = new FileReader();

        reader.onload = function (e) {
            $("#createDog #createDogLogo").attr('src', e.target.result);
            newUrl = e.target.result;
        };

        reader.readAsDataURL(input.files[0]);
    }
}

