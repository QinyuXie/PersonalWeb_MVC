const edu_url = "api/edu";
let edus = null;

const work_url = "api/work";
let works = null;

const proj_url = "api/proj";
let projs = null;
const comm_url = "api/comment";
let comms = null;

const file_url = "api/files";
let files = null;

$(document).ready(function() {
    getEduData();
      getWorkData();
    getProjData();
    getCommData();

});

function getFile() {
  $.ajax({
    type: "GET",
    url: "api/files/0",
    cache: false,
    success: function() {
        alert("Successfully download!")
    }
    });
    return false;
}

///////////////////////////////
//    edu api
//



function getEduData() {
  $.ajax({
    type: "GET",
    url: edu_url,
    cache: false,
    success: function(data) {
      edus = data;
    }
  });
}

//add new edu item
function addEduItem() {
       $("#add-eduItem").css({ display: "block" });
    $("#button-add-edu").css({display: "none"});
}

function closeAddEduInput() {
    $("#add-eduItem").css({ display: "none" });
    $("#button-add-edu").css({display: "block"});
}

function submitEduItem() {

    const item = {
        SchoolName : $("#add-schoolName").val(),
        Degree : $("#add-degree").val(),
        Major : $("#add-major").val(),
        FromYear :$("#add-fromYear").val(),
        FromMonth : $("#add-fromMonth").val(),
        ToYear : $("#add-toYear").val(),
        ToMonth : $("#add-toMonth").val(),
        RelevantCourses : $("#add-courses").val(),
  };

  $.ajax({
    type: "POST",
    accepts: "application/json",
    url: edu_url,
    contentType: "application/json",
    data: JSON.stringify(item),
    error: function(jqXHR, textStatus, errorThrown) {
      alert("Something went wrong!");
    },
    success: function(result) {
      getEduData();
    location.reload();
    }
    });
    
    location.reload();
    return false;
}

///delete item
function deleteEduItem(id) {
  $.ajax({
    url: edu_url + "/" + id,
    type: "DELETE",
    success: function(result) {
        getEduData();
        location.reload();
    }
    });

    return false;
}


///////////////////////////////
//    work api
//



function getWorkData() {
  $.ajax({
    type: "GET",
    url: work_url,
    cache: false,
    success: function(data) {
        works = data;

    }
  });
}

//add new work item
function addWorkItem() {
       $("#add-workItem").css({ display: "block" });
    $("#button-add-work").css({display: "none"});
}

function closeAddWorkInput() {
    $("#add-workItem").css({ display: "none" });
    $("#button-add-work").css({display: "block"});
}

function submitWorkItem() {

    const item = {
        CompanyName : $("#add-wk-companyName").val(),
        Position : $("#add-wk-position").val(),
        Location : $("#add-wk-location").val(),
        FromYear :$("#add-wk-fromYear").val(),
        FromMonth : $("#add-wk-fromMonth").val(),
        ToYear : $("#add-wk-toYear").val(),
        ToMonth : $("#add-wk-toMonth").val(),
        Responsibility : $("#add-responsibility").val()
  };

  $.ajax({
    type: "POST",
    accepts: "application/json",
    url: work_url,
    contentType: "application/json",
    data: JSON.stringify(item),
    error: function(jqXHR, textStatus, errorThrown) {
      alert("Something went wrong!");
    },
    success: function(result) {
      getWorkData();
    location.reload();
    }
    });
    location.reload();
    return false;
}

///delete item
function deleteWorkItem(id) {
  $.ajax({
    url: work_url + "/" + id,
    type: "DELETE",
    success: function(result) {
        getWorkData();
        location.reload();
    }
    });
    return false;

}

///////////////////////////////
//    project api
//



function getProjData() {
  $.ajax({
    type: "GET",
    url: proj_url,
    cache: false,
    success: function(data) {
        projs = data;
      
    }
    });
    return false;
}

//add new work item
function addProjItem() {
       $("#add-projItem").css({ display: "block" });
    $("#button-add-proj").css({display: "none"});
}

function closeAddProjInput() {
    $("#add-projItem").css({ display: "none" });
    $("#button-add-proj").css({display: "block"});
}

function submitProjItem() {

    const item = {
        ProjectName : $("#add-proj-projName").val(),
        Position : $("#add-proj-position").val(),
        Location : $("#add-proj-location").val(),
        FromYear :$("#add-proj-fromYear").val(),
        FromMonth : $("#add-proj-fromMonth").val(),
        ToYear : $("#add-proj-toYear").val(),
        ToMonth : $("#add-proj-toMonth").val(),
        Description : $("#add-description").val(),
  };

  $.ajax({
    type: "POST",
    accepts: "application/json",
    url: proj_url,
    contentType: "application/json",
    data: JSON.stringify(item),
    error: function(jqXHR, textStatus, errorThrown) {
      alert("Something went wrong!");
    },
    success: function(result) {
      getProjData();
      location.reload();
    }
    });
    
    location.reload();
  return false;
}

///delete item
function deleteProjItem(id) {
  $.ajax({
    url: proj_url + "/" + id,
    type: "DELETE",
    success: function(result) {
        getProjData();
          location.reload();
    }
    });
    return false;
}


////////////
// file api



function getCommData() {
  $.ajax({
    type: "GET",
    url: comm_url,
    cache: false,
    success: function(data) {
        comms = data;
     
    }
    });

}

//add new comment item
function addCommItem() {
       $("#add-commItem").css({ display: "block" });
    $("#button-add-comm").css({display: "none"});
}

function closeAddCommInput() {
    $("#add-commItem").css({ display: "none" });
    $("#button-add-comm").css({display: "block"});
}

function submitCommItem() {

    const item = {
        FromUserNm : $("#add-userName").val(),
        CommentContent : $("#add-comm").val(),
       
  };

  $.ajax({
    type: "POST",
    accepts: "application/json",
    url: comm_url,
    contentType: "application/json",
    data: JSON.stringify(item),
    error: function(jqXHR, textStatus, errorThrown) {
      alert("Something went wrong!");
    },
    success: function(result) {
      getCommData();
       location.reload();
    }
    });
    location.reload();
  return false;
}

///delete item
function deleteCommItem(id) {
  $.ajax({
    url: comm_url + "/" + id,
    type: "DELETE",
    success: function(result) {
        getCommData();
           location.reload();
    }
    });
    return false;
}