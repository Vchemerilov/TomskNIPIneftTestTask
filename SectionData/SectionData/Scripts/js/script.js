

    //Сформировать строку таблицы данных о секциях
    function getStringTable(data) {
        var stringData = "";

        stringData += "<tr scope=\"row\">";
        stringData += "<td><p class=\"text-center\">" + data["section"] + " </p></td> ";
        stringData += "<td><p class=\"text-center\">" + data["info"]["name"] + " </p></td> ";
        stringData += "<td><p class=\"text-center\">" + data["info"]["city"] + " </p></td> ";
        stringData += "<td><p class=\"text-center\">" + data["info"]["location"] + "</p></td> ";

        return stringData;
    }

    //Сформировать таблицу данных о секциях
    function getSectionsInfo(data) {
        var stringTable = "";

        data.forEach(function (element) {
            stringTable += getStringTable(element);
        });

        $("#tablebody").html(stringTable);
    }

    //Добавить новую секцию 
    function createNewSection() {
        var sectionName = $("#SectionName").val();
        var name = $("#Name").val();
        var city = $("#City").val();
        var location = $("#Location").val();

        if (sectionName.trim() != "" && name.trim() != "" && city.trim() != "" && location.trim() != "") {
            setNewSection(sectionName, name, city, location);
        } else {
            $(".modal-body").html("<p>Fill in all the fields</p>");
            $('#myModal').modal("show");
        }
    }

    $(document).ready(function () {

        getSectionList();

        $("#CreateSectionButton").click(function () {
            createNewSection();
        })

    });
