
page = 0;

function leftarrow() {
    $("#dog" + page).hide();
    page--;
    $("#dog" + page).show()
}


function rightarrow() {
    $("#dog" + page).hide();
    page++;
    $("#dog" + page).show();
}

function iconClick(item) {
    $(item).toggleClass('full')
        .animate({ backgroundColor: "#FFFFFF" }, 500);
    $(item + 'Dot').fadeToggle();
}
