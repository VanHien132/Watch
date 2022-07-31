var viewmodal = function () {
    self = this;
    self.array = ko.observableArray();

    self.click = function () {
        self.array([]);
        $.ajax({
            type: "get",
            url: "https://localhost:5001/api/Product",
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

        $('#mount').val("");
        $('#categoryId').val("");
        $('#priceN').val("");
        $('#priceB').val("");
        self.save = function () {
            var crdata = {
                Id: $('#id').val(),
                Name: $("#name").val(),
                Mount: $("#mount").val(),
                CategoryId: $("#categoryId").val(),
                PriceN: $("#priceN").val(),
                PriceB: $("#priceB").val(),
            }
            $.ajax({
                type: "POST",
                url: "https://localhost:5001/api/Product",
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
        $('#mount').val(item.mount);
        $('#categoryId').val(item.categoryId);
        $('#priceN').val(item.priceN);
        $('#priceB').val(item.priceB);
        $('#idProduct').val(item.id).attr('checked', true);
        //nhan nut save
        self.save = function () {


            var crdata = {
                Id: item.id,
                Name: $('#name').val(),
                Mount: $("#mount").val(),
                CategoryId: parseInt($("#categoryId").val()),
                PriceN: $("#priceN").val(),
                PriceB: $("#priceB").val(),
            }
            $.ajax({
                type: "PUT",
                url: "https://localhost:5001/api/Product" ,
                data: JSON.stringify(crdata),
                contentType: "application/json",

                success: function (data) {
                    console.log(data);
                    self.click();
                    
                },
                error: function (err) {
                    alert("loi " + err.status + "<!----!>" + err.statusText);
                    console.log(JSON.stringify(crdata));
                    self.click();
                }
            });
        }
    }
    self.del = function (item) {
        if (confirm("ban muon xoa " + item.name + " khong")) {
            $.ajax({
                type: "delete",
                url: "https://localhost:5001/api/Product/" + item.id,
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