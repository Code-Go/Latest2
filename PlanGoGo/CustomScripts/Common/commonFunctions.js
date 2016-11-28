function NotIntereseted(attractionId)
{
    
    var angularScope = angular.element(document.getElementById('main')).scope();
    angularScope.$apply(function () {
        angularScope.NotIntereseted(attractionId);
    });
    //alert(attractionId);
}

//Opening the dialog for edit the view time
function editTourInformation(timeRequiredToView, recordCounter) {
    
    $("#editTour")
        .data("recordCounter",recordCounter)
        .dialog("open");
    
    if (timeRequiredToView.toString().indexOf(':') == -1)
    {
        timeRequiredToView = timeRequiredToView + ":00";
    }
    $("#ViewTime").val(timeRequiredToView); 
}


//Updating the tour information
function UpdateTourInformation() {
    
    var parameter = $(this).data("recordCounter");
    
    var angularScope = angular.element(document.getElementById('main')).scope();
    angularScope.$apply(function () {
        angularScope.UpdateTourInformation(parameter,$("#ViewTime").val());
    });
    $(this).dialog("close");
    
    //return valid;
}