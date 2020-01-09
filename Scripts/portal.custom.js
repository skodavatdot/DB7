var DefaultDropDownText = "Please select...";
var DefaultDropDownValue = "0";
var IsDefaultDropDownEntryNeeded = true;

function RemoveBSAndTildaFromUrl(inputURL) {
    var formattedURL = inputURL;

    while (formattedURL != null && formattedURL.length >= 1 && (formattedURL.substring(0, 1) == '/' || formattedURL.substring(0, 1) == '~' || formattedURL.substring(0, 1) == '.')) {
        formattedURL = formattedURL.replace(formattedURL.substring(0, 1), '');
    }

    return formattedURL;
}
function getAbsoluteUrl(inputPartialUrl) {

    var _location = document.location.toString();
    var applicationNameIndex = _location.indexOf('/', _location.indexOf('://') + 3);
    var applicationName = _location.substring(0, applicationNameIndex) + '/';
    var webFolderIndex = _location.indexOf('/', _location.indexOf(applicationName) + applicationName.length);
    var webFolderFullPath = _location.substring(0, webFolderIndex);
    inputPartialUrl = RemoveBSAndTildaFromUrl(inputPartialUrl);
   

    //alert(document.location.pathname.toLocaleUpperCase()); ///SDMC.WEB/
    //alert(window.location.protocol); //http:
    //alert(window.location.host); //localhost
    //alert(webFolderFullPath);//http://localhost/SDMC.Web
    //alert(_location); //http://localhost/SDMC.Web/
    //alert(inputPartialUrl);//Home/Index/


    if (document.location.pathname.toLocaleUpperCase().indexOf('SDMC') == -1 ) {
       // alert(1);
        var baseUrl = window.location.protocol + "//" + window.location.host + "/";
        return baseUrl + inputPartialUrl;
    }
    else {
        if (webFolderFullPath == '') {
          //  alert(2)
            return _location + "/" + inputPartialUrl;;
        }
        else {
           // alert(3);
            return webFolderFullPath + "/" + inputPartialUrl;;
        }
    }
}
function IsEmail(email) {
    var regex = /^([a-zA-Z0-9_.+-])+\@(([a-zA-Z0-9-])+\.)+([a-zA-Z0-9]{2,4})+$/;
    return regex.test(email);
}

function setFormStatusMessage(formName, divcontainerName, isSuccess, message) {
    var container = $('#' + formName).find('#' + divcontainerName);
    if (container) {
        var messageDivSuccess = $(container).find('.alert-success');
        var messageDivError = $(container).find('.alert-danger');

        if (isSuccess) {
            $(container).show(); $(messageDivSuccess).show(); $(messageDivSuccess).html(message);
            $(messageDivError).hide();
        }
        else {
            $(container).show(); $(messageDivSuccess).hide();
            $(messageDivError).show(); $(messageDivError).html(message);
        }
    }
}

function getUrlJsonSync(url) {
    var jqxhr = $.ajax({
        type: "GET",
        url: url,
        dataType: 'json',
        cache: false,
        async: false
    });

    // 'async' has to be 'false' for this to work
    var response = { valid: jqxhr.statusText, data: jqxhr.responseJSON };

    return response;
}

function postUrlJsonSync(url) {
    var jqxhr = $.ajax({
        type: "POST",
        url: url,
        dataType: 'json',
        cache: false,
        async: false
    });

    // 'async' has to be 'false' for this to work
    var response = { valid: jqxhr.statusText, data: jqxhr.responseJSON };

    return response;
}

function HideFormStatusMessage(formName, divcontainerName) {
    var container = $('#' + formName).find('#' + divcontainerName);
    if (container) {
        $(container).hide();
    }
}

function getParameterByName(url, idtofindvaluefor) {
    idtofindvaluefor = idtofindvaluefor.replace(/[\[]/, "\\[").replace(/[\]]/, "\\]");
    var regex = new RegExp("[\\?&]" + idtofindvaluefor + "=([^&#]*)"),
        results = regex.exec(url);
    return results === null ? "" : decodeURIComponent(results[1].replace(/\+/g, " "));
}

function ShowAjaxLoadingContent(divName) {
    $('#' + divName).html('<h1 class="ajax-loading-animation" style=\'padding-left:10px;\'><i class="fa fa-cog fa-spin"></i> Loading...</h1>');
}

function ShowAjaxLoadingContentSmall(divName) {
    $('#' + divName).html('<h1 class="ajax-loading-animation-small" style=\'padding-left:10px;\'><i class="fa fa-cog fa-spin"></i> Loading...</h1>');
}

function Clear_Form(containerName) {
    var eleName = '#' + containerName;

    $(eleName).find(':input').each(function () {
        var isdisabled = $(this).is(':disabled');

        switch (this.type) {
            case 'password':
            case 'select-multiple':
            case 'select-one':
            case 'text':
            case 'tel':
            case 'email':
            case 'textarea':
                $(this).val('');
                break;
            case 'checkbox':
            case 'radio':
                this.checked = false;
        }
    });

    //hide form error area
    $(eleName).find('.DHCSFormError').hide();

    $(eleName).find('.has-error').each(function () {
        $(this).find('.has-error').remove();
        $(this).removeClass('has-error');
    });

    $(eleName).find('.has-success').each(function () {
        $(this).removeClass('has-success');
    });
}

function ControlAllowOnlyAlphabets(kCode) {
    
    if ((kCode > 64 && kCode < 91) || (kCode >= 97 && kCode < 123)) {
        return true;
    }
    else {
        event.keyCode = 0
        return false;
    }
};

function ControlAllowOnlyAlphaNumerics(kCode) {
   
    if ((kCode > 64 && kCode < 91) || (kCode >= 97 && kCode < 123) || (kCode >= 48 && kCode <= 57) || (kCode >= 97 && kCode <= 105)) {
        return true;
    }
    else {
        event.keyCode = 0
        return false;
    }
};
//for diagnosiscode
function ControlAllowOnlyAlphaNumericsAndPeriod(kCode) {
   
    if ( (kCode > 64 && kCode < 91) || (kCode >= 97 && kCode < 123) || (kCode >= 48 && kCode <= 57) || (kCode >= 97 && kCode <= 105)) {
       
        return true;
    }
    else if(kCode == 46)
    {
        return true;
    }
    else {
        event.keyCode = 0
        return false;
    }
};

function ControlAllowOnlyNumerics(kCode) {
    if ((kCode >= 48 && kCode <= 57)) {
        return true;
    }
    else {
        event.keyCode = 0
        return false;
    }
};

function ControlAllowOnlyAlphabetsWithSpace(kCode) {
    
    if ((kCode > 64 && kCode < 91) || (kCode >= 97 && kCode < 123) || kCode == 32) {
        return true;
    }
    else {
        event.keyCode = 0
        return false;
    }
};

function ControlAllowOnlyAlphabetsWithNoStartUpSpace(kCode, value) {
   
    if (value == '' && kCode == 32)
    {
        return false;
    }
    if ((kCode > 64 && kCode < 91) || (kCode >= 97 && kCode < 123) || kCode == 32) {
        return true;
    }
    else {
        event.keyCode = 0
        return false;
    }
};

function ControlAllowOnlyMouseEvents(kCode) {
    if ((kCode > 64 && kCode < 91) || (kCode >= 97 && kCode < 123) || (kCode >= 48 && kCode <= 57) || (kCode >= 97 && kCode <= 105) ||(kCode==45)) {
        return false;
    }
    else {
        event.keyCode = 0
        return true;
    }
};

function ControlAllowOnlyValidDate(input) {
    var regexes = [/^(\d{1,2})\/(\d{1,2})\/(\d{4})$/, /^(\d{1,2})\-(\d{1,2})\-(\d{4})$/];
    for (var i = 0; i < regexes.length; i++) {
        var r = regexes[i];
        if (!r.test(input)) {
            continue;
        }
        var a = input.match(r), d = new Date(a[3], a[1] - 1, a[2]);
        if (d.getFullYear() != a[3] || d.getMonth() + 1 != a[1] || d.getDate() != a[2]) {
            continue;
        }
        // All checks passed:
        return true;
    }
    return false;

};

function SetErrorMsg(divMsgName, ErrMsg, divID) {
    var $messageDiv = $('#' + divMsgName);
    $messageDiv.show().html(ErrMsg);
    $('#' + divID).val('');
    setTimeout(function () { $messageDiv.hide().html(''); }, 5000);
};

$(document).ready(function () {
});