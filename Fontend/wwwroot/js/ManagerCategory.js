var viewmodal = function () {
    self = this;
    self.array = ko.observableArray();

    self.click = function () {
        self.array([]);
        $.ajax({
            type: "get",
            url: "https://localhost:5001/api/Category",
            contentType: "application/json",
            
            success: function (data) {
                console.log(data);
                $.each(data, function (ex, item) { self.array.push(item) });
            },
            error: function (err) {
                alert(err);
            },
        });
    }
    self.Create = function () {
        $('#modal').modal("show");
        $('#id').val(""),
            $('#name').val("");

        $('#address').val("");
        $('#decription').val("");
        self.save = function () {
            var crdata = {
                Id: $('#id').val(),
                Name: $("#name").val(),
                Address: $("#address").val(),
                Decription: $("#decription").val(),
             
            }
            $.ajax({
                type: "POST",
                url: "https://localhost:5001/api/Category",
                data: JSON.stringify(crdata),
                contentType: "application/json",
                success: function () {
                    console.log(crdata);
                    self.click();

                },
                error: function (err) {
                    console.log(" Not Failed");
                }
            });
        }

    }
    self.Update = function (item) {
        $('#modal').modal("show");
       
        $('#id').val(item.id),
            $('#name').val(item.name);
        $('#address').val(item.address);
        $('#decription').val(item.decription);
   
        $('#idProduct').val(item.id).attr('checked', true);
        //nhan nut save
        self.save = function () {


            var crdata = {
                Id: item.id,
                Name: $('#name').val(),
                Address: $("#address").val(),
                Decription: $("#decription").val(),
               
            }
            
            $.ajax({
                type: "PUT",
                url: "https://localhost:5001/api/Category" ,
                data: JSON.stringify(crdata),
                contentType: "application/json",

                success: function (data) {
                    console.log(data);
                    self.click();
                },
                error: function (err) {
                    console.log(JSON.stringify(crdata));
                    self.click();
                }
            });
        }
    }
    self.del = function (item) {
        if (confirm("ban muon xoa " + item.name + " khong")) {
            $.ajax({
                type: "DELETE",
                url: "https://localhost:5001/api/Category/" + item.id,
                success: function (data) {
                    self.click();
                    
                },
                error: function (error) {
                    
                    console.log(item);
                    self.click()
                }
            });
        }

    };

}
$(function () {
    var db = new viewmodal();
    db.click();
    ko.applyBindings(db);
});