function aboneOl(mail) {
    if (mail != "") {
        $.ajax({
            url: "/Yonetim/Bulten/Kayitol",
            data: { mail: mail },
            success: function () {

            }
        })
    }
}

$(document).ready(function () {
    $(".table").DataTable();
    $(".btnSil").click(function () {
        if (confirm("Ürünü silmek istediğinize emin misiniz?")) {
            var id = $(this).data("urunid");
            $.ajax({
                url: "/Yonetim/Urunler/Sil",
                data: { id: id },
                success: function () {
                    $(this).parent().remove();
                }
            })
        }
    });
    $("#fileUpload").change(function () {
        $("#resimler").empty();
        for (var i = 0; i < 5; i++) {
            var file = document.getElementById("fileUpload").files[i];
            var readImg = new FileReader();
            readImg.readAsDataURL(file);
            readImg.onload = function (e) {
                var resimadi = "resim" + i;
                $("#resimler").append("<img class='ml-2' id=" + resimadi + " src=" + e.target.result + " width='240' height='240' />");
            }
        }
    });
})