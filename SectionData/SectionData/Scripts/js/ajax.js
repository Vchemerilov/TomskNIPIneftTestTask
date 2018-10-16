
    //Получить список данных о секциях
    function getSectionList() {
        $.ajax({
            type: "GET",
            url: "/conference/info",
            success: function (data) {
                getSectionsInfo(data);               
            },
            error: function(error) {
                console.log(error);
            }
        })
    }

    //Отправить данные для создания новой секций
    function setNewSection(SectionName, Name, City, Location) {
        $.ajax({
            type: "POST",
            url: "/conference/" + SectionName + "/info",
            data: JSON.stringify({ sectionName: SectionName, name: Name, city: City, location: Location }),
            contentType: "application/json; charset=utf-8",
            success: function (data) {
                var result = "";
                if (data == "True") {
                    result = "Data added to DB";
                } else {
                    result = "Data already exist in DB";
                }

                $(".modal-body").html("<p>" + result + "</p>");
                $('#myModal').modal("show");
            },
            error: function (error) {
                console.log(error);
            }
        })
}
